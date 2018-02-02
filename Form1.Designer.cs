namespace DataShowWinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.Attention = new System.Windows.Forms.Label();
            this.Meditation = new System.Windows.Forms.Label();
            this.DeltaData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ThetaData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AlphaData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BetaData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GammaData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RawData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Eye_close = new System.Windows.Forms.Button();
            this.Eye_Start = new System.Windows.Forms.Button();
            this.PointY = new System.Windows.Forms.Label();
            this.PointX = new System.Windows.Forms.Label();
            this.BlinkStrength = new System.Windows.Forms.Label();
            this.PoorSignal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThetaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetaData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RawData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(27, 25);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(100, 30);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "启动连接";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(164, 25);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 30);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "断开连接";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("幼圆", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Status.Location = new System.Drawing.Point(33, 80);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(220, 40);
            this.Status.TabIndex = 2;
            this.Status.Text = "初始化";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Attention
            // 
            this.Attention.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Attention.Location = new System.Drawing.Point(40, 25);
            this.Attention.Name = "Attention";
            this.Attention.Size = new System.Drawing.Size(220, 30);
            this.Attention.TabIndex = 5;
            this.Attention.Text = "专注度：0";
            this.Attention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Meditation
            // 
            this.Meditation.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Meditation.Location = new System.Drawing.Point(40, 60);
            this.Meditation.Name = "Meditation";
            this.Meditation.Size = new System.Drawing.Size(220, 30);
            this.Meditation.TabIndex = 6;
            this.Meditation.Text = "冥想度：0";
            this.Meditation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeltaData
            // 
            chartArea1.Name = "ChartArea1";
            this.DeltaData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DeltaData.Legends.Add(legend1);
            this.DeltaData.Location = new System.Drawing.Point(347, 236);
            this.DeltaData.Name = "DeltaData";
            this.DeltaData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Maroon;
            series1.LabelForeColor = System.Drawing.Color.Salmon;
            series1.Legend = "Legend1";
            series1.Name = "Delta";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeltaData.Series.Add(series1);
            this.DeltaData.Size = new System.Drawing.Size(440, 200);
            this.DeltaData.TabIndex = 7;
            this.DeltaData.Text = "chart1";
            // 
            // ThetaData
            // 
            chartArea2.Name = "ChartArea1";
            this.ThetaData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ThetaData.Legends.Add(legend2);
            this.ThetaData.Location = new System.Drawing.Point(848, 10);
            this.ThetaData.Name = "ThetaData";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Green;
            series2.LabelForeColor = System.Drawing.Color.DarkSalmon;
            series2.Legend = "Legend1";
            series2.Name = "Theta";
            series2.YValuesPerPoint = 2;
            this.ThetaData.Series.Add(series2);
            this.ThetaData.Size = new System.Drawing.Size(440, 200);
            this.ThetaData.TabIndex = 8;
            this.ThetaData.Text = "chart2";
            // 
            // AlphaData
            // 
            chartArea3.Name = "ChartArea1";
            this.AlphaData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.AlphaData.Legends.Add(legend3);
            this.AlphaData.Location = new System.Drawing.Point(347, 489);
            this.AlphaData.Name = "AlphaData";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "Low Alpha";
            series3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Navy;
            series4.Legend = "Legend1";
            series4.Name = "High Alpha";
            series4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AlphaData.Series.Add(series3);
            this.AlphaData.Series.Add(series4);
            this.AlphaData.Size = new System.Drawing.Size(440, 200);
            this.AlphaData.TabIndex = 9;
            this.AlphaData.Text = "chart3";
            // 
            // BetaData
            // 
            chartArea4.Name = "ChartArea1";
            this.BetaData.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BetaData.Legends.Add(legend4);
            this.BetaData.Location = new System.Drawing.Point(848, 236);
            this.BetaData.Name = "BetaData";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.DarkOrange;
            series5.Legend = "Legend1";
            series5.Name = "Low Beta";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.MediumAquamarine;
            series6.Legend = "Legend1";
            series6.Name = "High Beta";
            this.BetaData.Series.Add(series5);
            this.BetaData.Series.Add(series6);
            this.BetaData.Size = new System.Drawing.Size(440, 200);
            this.BetaData.TabIndex = 10;
            this.BetaData.Text = "chart4";
            // 
            // GammaData
            // 
            chartArea5.Name = "ChartArea1";
            this.GammaData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.GammaData.Legends.Add(legend5);
            this.GammaData.Location = new System.Drawing.Point(848, 489);
            this.GammaData.Name = "GammaData";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.DarkViolet;
            series7.Legend = "Legend1";
            series7.Name = "Low Gamma";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Color = System.Drawing.Color.Crimson;
            series8.Legend = "Legend1";
            series8.Name = "High Gamma";
            this.GammaData.Series.Add(series7);
            this.GammaData.Series.Add(series8);
            this.GammaData.Size = new System.Drawing.Size(440, 200);
            this.GammaData.TabIndex = 11;
            this.GammaData.Text = "chart1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Controls.Add(this.BtnClose);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "启动模块";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PoorSignal);
            this.groupBox2.Controls.Add(this.BlinkStrength);
            this.groupBox2.Controls.Add(this.Attention);
            this.groupBox2.Controls.Add(this.Meditation);
            this.groupBox2.Location = new System.Drawing.Point(13, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 186);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "特征模块";
            // 
            // RawData
            // 
            chartArea6.Name = "ChartArea1";
            this.RawData.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.RawData.Legends.Add(legend6);
            this.RawData.Location = new System.Drawing.Point(347, 10);
            this.RawData.Name = "RawData";
            this.RawData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Color = System.Drawing.Color.Fuchsia;
            series9.Legend = "Legend1";
            series9.Name = "EEG";
            series9.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series9.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RawData.Series.Add(series9);
            this.RawData.Size = new System.Drawing.Size(440, 210);
            this.RawData.TabIndex = 14;
            this.RawData.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Eye_close);
            this.groupBox3.Controls.Add(this.Eye_Start);
            this.groupBox3.Controls.Add(this.PointY);
            this.groupBox3.Controls.Add(this.PointX);
            this.groupBox3.Location = new System.Drawing.Point(13, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 204);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "眼睛运动坐标显示";
            // 
            // Eye_close
            // 
            this.Eye_close.Location = new System.Drawing.Point(164, 127);
            this.Eye_close.Name = "Eye_close";
            this.Eye_close.Size = new System.Drawing.Size(87, 33);
            this.Eye_close.TabIndex = 3;
            this.Eye_close.Text = "结束";
            this.Eye_close.UseVisualStyleBackColor = true;
            this.Eye_close.Click += new System.EventHandler(this.Eye_close_Click);
            // 
            // Eye_Start
            // 
            this.Eye_Start.Location = new System.Drawing.Point(38, 127);
            this.Eye_Start.Name = "Eye_Start";
            this.Eye_Start.Size = new System.Drawing.Size(89, 33);
            this.Eye_Start.TabIndex = 2;
            this.Eye_Start.Text = "眼动";
            this.Eye_Start.UseVisualStyleBackColor = true;
            this.Eye_Start.Click += new System.EventHandler(this.Eye_Start_Click);
            // 
            // PointY
            // 
            this.PointY.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PointY.Location = new System.Drawing.Point(87, 67);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(100, 40);
            this.PointY.TabIndex = 1;
            this.PointY.Text = "0";
            this.PointY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PointX
            // 
            this.PointX.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PointX.Location = new System.Drawing.Point(87, 22);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(100, 30);
            this.PointX.TabIndex = 0;
            this.PointX.Text = "0";
            this.PointX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlinkStrength
            // 
            this.BlinkStrength.BackColor = System.Drawing.Color.Teal;
            this.BlinkStrength.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BlinkStrength.Location = new System.Drawing.Point(40, 130);
            this.BlinkStrength.Name = "BlinkStrength";
            this.BlinkStrength.Size = new System.Drawing.Size(220, 30);
            this.BlinkStrength.TabIndex = 7;
            this.BlinkStrength.Text = "眨眼强度：0";
            this.BlinkStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoorSignal
            // 
            this.PoorSignal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PoorSignal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoorSignal.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PoorSignal.Location = new System.Drawing.Point(40, 95);
            this.PoorSignal.Name = "PoorSignal";
            this.PoorSignal.Size = new System.Drawing.Size(220, 30);
            this.PoorSignal.TabIndex = 8;
            this.PoorSignal.Text = "弱信号值：0";
            this.PoorSignal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RawData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GammaData);
            this.Controls.Add(this.BetaData);
            this.Controls.Add(this.AlphaData);
            this.Controls.Add(this.ThetaData);
            this.Controls.Add(this.DeltaData);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "脑电波数据展示";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DeltaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThetaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlphaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetaData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RawData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Attention;
        private System.Windows.Forms.Label Meditation;
        private System.Windows.Forms.DataVisualization.Charting.Chart DeltaData;
        private System.Windows.Forms.DataVisualization.Charting.Chart ThetaData;
        private System.Windows.Forms.DataVisualization.Charting.Chart AlphaData;
        private System.Windows.Forms.DataVisualization.Charting.Chart BetaData;
        private System.Windows.Forms.DataVisualization.Charting.Chart GammaData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart RawData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label PointY;
        private System.Windows.Forms.Label PointX;
        private System.Windows.Forms.Button Eye_close;
        private System.Windows.Forms.Button Eye_Start;
        private System.Windows.Forms.Label PoorSignal;
        private System.Windows.Forms.Label BlinkStrength;
    }
}

