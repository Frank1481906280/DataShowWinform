using NeuronDotNet.Core.Backpropagation;
using NeuroSky.ThinkGear;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Tobii.Interaction;

namespace DataShowWinform
{
    public partial class Form1 : Form
    {
        static Connector connector;
        //int nchar = 0;
        public static BackpropagationNetwork network;
        bool closeAllThread = false;
        bool eegTime = false;
        private Host _host;
        bool flag = false;
        private Point prevPos;
        private float alpha = 0.3f;

        public Form1()
        {
            InitializeComponent();
        }
        public void connect()
        {


            // Initialize a new Connector and add event handlers
            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnected);
            connector.DeviceConnectFail += new EventHandler(OnDeviceFail);
            connector.DeviceValidating += new EventHandler(OnDeviceValidating);


            // Scan for devices
            connector.ConnectScan("COM12");

            //Thread.Sleep(450000);

        }
        private void OnDeviceValidating(object sender, EventArgs e)
        {
            Status.Invoke((Action)(() => Status.Text = "搜索中...... "));
        }

        private void OnDeviceFail(object sender, EventArgs e)
        {
            Status.Invoke((Action)(() => Status.Text = "设备未找到 "));
        }

        private void OnDeviceConnected(object sender, EventArgs e)
        {
            Connector.DeviceEventArgs de = (Connector.DeviceEventArgs)e;

            Status.Invoke((Action)(() => Status.Text = "已经在 " + de.Device.PortName + "建立连接"));
            de.Device.DataReceived += new EventHandler(OnDataReceived);
            connector.enableTaskDifficulty(); //depricated
            connector.enableTaskFamiliarity(); //depricated

            connector.setMentalEffortRunContinuous(true);
            connector.setMentalEffortEnable(true);
            connector.setTaskFamiliarityRunContinuous(true);
            connector.setTaskFamiliarityEnable(true);
            connector.setBlinkDetectionEnabled(true);
        }

        private void OnDataReceived(object sender, EventArgs e)
        {

            if (!closeAllThread)
            {
                Device.DataEventArgs de = (Device.DataEventArgs)e;
                var Attention_Data = new Thread(() => plotAttention(de));
                Attention_Data.Start();

                var Medition_Data = new Thread(() => plotMedition(de));
                Medition_Data.Start();

               var BlinkStrength_Data = new Thread(() => plotBlinkStrength(de));
               BlinkStrength_Data.Start();

                var PoorSignal_Data = new Thread(() => plotPoorSignal(de));
                PoorSignal_Data.Start();

                var tWaves = new Thread(() => plotWaves(de));
                tWaves.Start();

                var tRaw = new Thread(() => plotRaw(de));
                tRaw.Start();

            }
        }

        private void plotPoorSignal(Device.DataEventArgs de)
        {
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);
            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {

                if (tgParser.ParsedData[i].ContainsKey("PoorSignal"))
                {
                    PoorSignal.Invoke((Action)(() => PoorSignal.Text = "弱信号值：" + tgParser.ParsedData[i]["PoorSignal"]));
                }
                if (closeAllThread)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        private void plotBlinkStrength(Device.DataEventArgs de)
        {
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);
            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {

                if (tgParser.ParsedData[i].ContainsKey("BlinkStrength"))
                {
                    BlinkStrength.Invoke((Action)(() => BlinkStrength.Text = "眨眼强度：" + tgParser.ParsedData[i]["BlinkStrength"]));

                }
                if (closeAllThread)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        private void plotRaw(Device.DataEventArgs de)
        {

            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);

            if (eegTime && closeAllThread == false)
            {

                RawData.Invoke((MethodInvoker)(() => RawData.ChartAreas[0].AxisY.Minimum = -400));
                RawData.Invoke((MethodInvoker)(() => RawData.ChartAreas[0].AxisY.Maximum = 400));
                for (int i = 0; i < tgParser.ParsedData.Length; i++)
                {
                    if (tgParser.ParsedData[i].ContainsKey("Raw"))
                    {
                        eegTime = false;
                        RawData.Invoke((MethodInvoker)(() => RawData.Series["EEG"].Points.AddY(tgParser.ParsedData[i]["Raw"])));
                    }
                    if (RawData.Series["EEG"].Points.Count > 200)
                    {
                        RawData.Invoke((MethodInvoker)(() => RawData.Series["EEG"].Points.RemoveAt(0)));
                    }
                }
            }

            Thread.CurrentThread.Abort();
        }

        private void plotWaves(Device.DataEventArgs de)
        {
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);
            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {

                if (tgParser.ParsedData[i].ContainsKey("EegPowerDelta") && tgParser.ParsedData[i]["EegPowerDelta"] > 0)
                {
                    DeltaData.Invoke((MethodInvoker)(() => DeltaData.Series["Delta"].Points.AddY(tgParser.ParsedData[i]["EegPowerDelta"])));
                    if (DeltaData.Series["Delta"].Points.Count > 20)
                    {
                        DeltaData.Invoke((MethodInvoker)(() => DeltaData.Series["Delta"].Points.RemoveAt(0)));
                    }
                    ThetaData.Invoke((MethodInvoker)(() => ThetaData.ChartAreas[0].AxisY.Maximum = 1000000));
                }
                if (tgParser.ParsedData[i].ContainsKey("EegPowerTheta") && tgParser.ParsedData[i]["EegPowerTheta"] > 0)
                {

                    ThetaData.Invoke((MethodInvoker)(() => ThetaData.Series["Theta"].Points.AddY(tgParser.ParsedData[i]["EegPowerTheta"])));


                    if (ThetaData.Series["Theta"].Points.Count > 20)
                    {
                        ThetaData.Invoke((MethodInvoker)(() => ThetaData.Series["Theta"].Points.RemoveAt(0)));

                    }

                    ThetaData.Invoke((MethodInvoker)(() => ThetaData.ChartAreas[0].AxisY.Maximum = 400000));

                    if (tgParser.ParsedData[i].ContainsKey("EegPowerAlpha1") && tgParser.ParsedData[i]["EegPowerAlpha1"] > 0)
                    {

                        AlphaData.Invoke((MethodInvoker)(() => AlphaData.Series["Low Alpha"].Points.AddY(tgParser.ParsedData[i]["EegPowerAlpha1"])));


                        if (AlphaData.Series["Low Alpha"].Points.Count > 20)
                        {
                            AlphaData.Invoke((MethodInvoker)(() => AlphaData.Series["Low Alpha"].Points.RemoveAt(0)));

                        }

                       AlphaData.Invoke((MethodInvoker)(() => AlphaData.ChartAreas[0].AxisY.Maximum = 100000));

                    }

                    if (tgParser.ParsedData[i].ContainsKey("EegPowerAlpha2") && tgParser.ParsedData[i]["EegPowerAlpha2"] > 0)
                    {

                        AlphaData.Invoke((MethodInvoker)(() => AlphaData.Series["High Alpha"].Points.AddY(tgParser.ParsedData[i]["EegPowerAlpha2"])));


                        if (AlphaData.Series["High Alpha"].Points.Count > 20)
                        {
                           AlphaData.Invoke((MethodInvoker)(() => AlphaData.Series["High Alpha"].Points.RemoveAt(0)));

                        }


                    }
                    
                    if (tgParser.ParsedData[i].ContainsKey("EegPowerBeta1") && tgParser.ParsedData[i]["EegPowerAlpha1"] > 0)
                    {

                        BetaData.Invoke((MethodInvoker)(() => BetaData.Series["Low Beta"].Points.AddY(tgParser.ParsedData[i]["EegPowerBeta1"])));


                        if (BetaData.Series["Low Beta"].Points.Count > 20)
                        {
                            BetaData.Invoke((MethodInvoker)(() => BetaData.Series["Low Beta"].Points.RemoveAt(0)));

                        }

                        BetaData.Invoke((MethodInvoker)(() => BetaData.ChartAreas[0].AxisY.Maximum = 50000));
                        //  chart4.Invoke((MethodInvoker)(() => chart4.ChartAreas[0].AxisY.Minimum = 5));

                    }

                    if (tgParser.ParsedData[i].ContainsKey("EegPowerBeta2") && tgParser.ParsedData[i]["EegPowerBeta2"] > 0)
                    {

                        BetaData.Invoke((MethodInvoker)(() => BetaData.Series["High Beta"].Points.AddY(tgParser.ParsedData[i]["EegPowerBeta2"])));



                        if (BetaData.Series["High Beta"].Points.Count > 20)
                        {
                            BetaData.Invoke((MethodInvoker)(() =>BetaData.Series["High Beta"].Points.RemoveAt(0)));

                        }

                    }


                    if (tgParser.ParsedData[i].ContainsKey("EegPowerGamma1") && tgParser.ParsedData[i]["EegPowerGamma1"] > 0)
                    {

                        GammaData.Invoke((MethodInvoker)(() =>GammaData.Series["Low Gamma"].Points.AddY(tgParser.ParsedData[i]["EegPowerGamma1"])));


                        if (GammaData.Series["Low Gamma"].Points.Count > 20)
                        {GammaData.Invoke((MethodInvoker)(() => GammaData.Series["Low Gamma"].Points.RemoveAt(0)));

                        }

                        GammaData.Invoke((MethodInvoker)(() => GammaData.ChartAreas[0].AxisY.Maximum = 20000));

                    }


                    if (tgParser.ParsedData[i].ContainsKey("EegPowerGamma2") && tgParser.ParsedData[i]["EegPowerGamma2"] > 0)
                    {

                        GammaData.Invoke((MethodInvoker)(() => GammaData.Series["High Gamma"].Points.AddY(tgParser.ParsedData[i]["EegPowerGamma2"])));


                        if (GammaData.Series["High Gamma"].Points.Count > 20)
                        {
                            GammaData.Invoke((MethodInvoker)(() => GammaData.Series["High Gamma"].Points.RemoveAt(0)));

                        }


                    }



                    if (closeAllThread)
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
            }
        }

        private void plotMedition(Device.DataEventArgs de)
        {
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);
            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {

                if (tgParser.ParsedData[i].ContainsKey("Meditation"))
                {
                    Meditation.Invoke((Action)(() => Meditation.Text ="冥想度：" +tgParser.ParsedData[i]["Meditation"]));

                }
                if (closeAllThread)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }


        private void plotAttention(Device.DataEventArgs de)
        {
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);
            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {

                if (tgParser.ParsedData[i].ContainsKey("Attention"))
                {
                    Attention.Invoke((Action)(() => Attention.Text = "专注度："+tgParser.ParsedData[i]["Attention"]));
                }
                if (closeAllThread)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            connect();
            timer2.Enabled = true;
                
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Status.Text = "已经断开了连接！";
            connector.Close();
            closeAllThread = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            eegTime = true;
        }

        private void Eye_Start_Click(object sender, EventArgs e)
        {
            _host = new Host();
            flag = true;
            var gazePointDataStream = _host.Streams.CreateGazePointDataStream(Tobii.Interaction.Framework.GazePointDataMode.LightlyFiltered);
            gazePointDataStream.GazePoint((x, y, _) =>
            {
                moveCursor((int)x, (int)y);
                PointX.Invoke((MethodInvoker)(() => PointX.Text = "X:"+(int)x));
                PointY.Invoke((MethodInvoker)(() => PointY.Text = "Y:" + (int)y));
            });
        }

        private void moveCursor(int x, int y)
        {
            if (flag)
            {
                Cursor.Position = SmoothFilter(new Point(x, y));
            }
        }

        private Point SmoothFilter(Point point)
        {
            Point filteredPoint = new Point();
            prevPos = point;
            filteredPoint = new Point((int)((point.X * alpha) + (prevPos.X *
            (1.0f - alpha))), (int)((point.Y * alpha) + (prevPos.Y
            * (1.0f - alpha))));
            return filteredPoint;
        }

        private void Eye_close_Click(object sender, EventArgs e)
        {
            flag = false;
            _host.DisableConnection();
        }
    }
}
