/*
 * Created by SharpDevelop.
 * User: Michael
 * Date: 10.06.2016
 * Time: 16:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EnergyMonitor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.gaugeLieferung = new System.Windows.Forms.AGauge();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBezugWirkleistung = new System.Windows.Forms.TextBox();
			this.txtLieferungWirkleistung = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBezugPhase1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtLieferungPhase1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtStromPhase1 = new System.Windows.Forms.TextBox();
			this.txtSpannungPhase1 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtSpannungPhase2 = new System.Windows.Forms.TextBox();
			this.txtStromPhase2 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtLieferungPhase2 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txtBezugPhase2 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.txtSpannungPhase3 = new System.Windows.Forms.TextBox();
			this.txtStromPhase3 = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txtLieferungPhase3 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.txtBezugPhase3 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.btnEnde = new System.Windows.Forms.Button();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.gaugeBezug = new System.Windows.Forms.AGauge();
			this.label1 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.txtBezugScheinleistung = new System.Windows.Forms.TextBox();
			this.txtBezugBlindleistung = new System.Windows.Forms.TextBox();
			this.txtLieferungScheinleistung = new System.Windows.Forms.TextBox();
			this.txtLieferungBlindleistung = new System.Windows.Forms.TextBox();
			this.grpPhase1 = new System.Windows.Forms.GroupBox();
			this.grpPhase2 = new System.Windows.Forms.GroupBox();
			this.grpPhase3 = new System.Windows.Forms.GroupBox();
			this.grpSumme = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.grpPhase1.SuspendLayout();
			this.grpPhase2.SuspendLayout();
			this.grpPhase3.SuspendLayout();
			this.grpSumme.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(358, 279);
			this.txtStatus.Multiline = true;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(473, 81);
			this.txtStatus.TabIndex = 0;
			// 
			// gaugeLieferung
			// 
			this.gaugeLieferung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gaugeLieferung.BaseArcColor = System.Drawing.Color.Black;
			this.gaugeLieferung.BaseArcRadius = 80;
			this.gaugeLieferung.BaseArcStart = 135;
			this.gaugeLieferung.BaseArcSweep = 270;
			this.gaugeLieferung.BaseArcWidth = 2;
			this.gaugeLieferung.Center = new System.Drawing.Point(110, 110);
			aGaugeLabel1.Color = System.Drawing.SystemColors.WindowText;
			aGaugeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			aGaugeLabel1.Name = "gaugeLieferungLabel";
			aGaugeLabel1.Position = new System.Drawing.Point(70, 190);
			aGaugeLabel1.Text = "Lieferung W";
			this.gaugeLieferung.GaugeLabels.Add(aGaugeLabel1);
			this.gaugeLieferung.Location = new System.Drawing.Point(612, 27);
			this.gaugeLieferung.MaxValue = 1000F;
			this.gaugeLieferung.MinValue = 0F;
			this.gaugeLieferung.Name = "gaugeLieferung";
			this.gaugeLieferung.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
			this.gaugeLieferung.NeedleColor2 = System.Drawing.Color.DarkRed;
			this.gaugeLieferung.NeedleRadius = 80;
			this.gaugeLieferung.NeedleType = System.Windows.Forms.NeedleType.Simple;
			this.gaugeLieferung.NeedleWidth = 3;
			this.gaugeLieferung.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.gaugeLieferung.ScaleLinesInterInnerRadius = 73;
			this.gaugeLieferung.ScaleLinesInterOuterRadius = 80;
			this.gaugeLieferung.ScaleLinesInterWidth = 1;
			this.gaugeLieferung.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.gaugeLieferung.ScaleLinesMajorInnerRadius = 70;
			this.gaugeLieferung.ScaleLinesMajorOuterRadius = 80;
			this.gaugeLieferung.ScaleLinesMajorStepValue = 500F;
			this.gaugeLieferung.ScaleLinesMajorWidth = 2;
			this.gaugeLieferung.ScaleLinesMinorColor = System.Drawing.Color.Gray;
			this.gaugeLieferung.ScaleLinesMinorInnerRadius = 75;
			this.gaugeLieferung.ScaleLinesMinorOuterRadius = 80;
			this.gaugeLieferung.ScaleLinesMinorTicks = 9;
			this.gaugeLieferung.ScaleLinesMinorWidth = 1;
			this.gaugeLieferung.ScaleNumbersColor = System.Drawing.Color.Black;
			this.gaugeLieferung.ScaleNumbersFormat = "0";
			this.gaugeLieferung.ScaleNumbersRadius = 95;
			this.gaugeLieferung.ScaleNumbersRotation = 0;
			this.gaugeLieferung.ScaleNumbersStartScaleLine = 1;
			this.gaugeLieferung.ScaleNumbersStepScaleLines = 100;
			this.gaugeLieferung.Size = new System.Drawing.Size(220, 220);
			this.gaugeLieferung.TabIndex = 1;
			this.gaugeLieferung.Text = "Summe";
			this.gaugeLieferung.Value = 0F;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Wirkleistung";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(251, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Lieferung W";
			// 
			// txtBezugWirkleistung
			// 
			this.txtBezugWirkleistung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBezugWirkleistung.Location = new System.Drawing.Point(128, 30);
			this.txtBezugWirkleistung.Name = "txtBezugWirkleistung";
			this.txtBezugWirkleistung.Size = new System.Drawing.Size(95, 26);
			this.txtBezugWirkleistung.TabIndex = 5;
			this.txtBezugWirkleistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtLieferungWirkleistung
			// 
			this.txtLieferungWirkleistung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLieferungWirkleistung.Location = new System.Drawing.Point(236, 30);
			this.txtLieferungWirkleistung.Name = "txtLieferungWirkleistung";
			this.txtLieferungWirkleistung.Size = new System.Drawing.Size(95, 26);
			this.txtLieferungWirkleistung.TabIndex = 6;
			this.txtLieferungWirkleistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(146, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Bezug W";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Bezug";
			// 
			// txtBezugPhase1
			// 
			this.txtBezugPhase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBezugPhase1.Location = new System.Drawing.Point(65, 15);
			this.txtBezugPhase1.Name = "txtBezugPhase1";
			this.txtBezugPhase1.Size = new System.Drawing.Size(70, 26);
			this.txtBezugPhase1.TabIndex = 11;
			this.txtBezugPhase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(135, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 20);
			this.label8.TabIndex = 12;
			this.label8.Text = "W";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(315, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(24, 20);
			this.label9.TabIndex = 13;
			this.label9.Text = "W";
			// 
			// txtLieferungPhase1
			// 
			this.txtLieferungPhase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLieferungPhase1.Location = new System.Drawing.Point(245, 15);
			this.txtLieferungPhase1.Name = "txtLieferungPhase1";
			this.txtLieferungPhase1.Size = new System.Drawing.Size(70, 26);
			this.txtLieferungPhase1.TabIndex = 14;
			this.txtLieferungPhase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(160, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 20);
			this.label10.TabIndex = 15;
			this.label10.Text = "Lieferung";
			// 
			// txtStromPhase1
			// 
			this.txtStromPhase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStromPhase1.Location = new System.Drawing.Point(65, 45);
			this.txtStromPhase1.Name = "txtStromPhase1";
			this.txtStromPhase1.Size = new System.Drawing.Size(70, 26);
			this.txtStromPhase1.TabIndex = 16;
			this.txtStromPhase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtSpannungPhase1
			// 
			this.txtSpannungPhase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSpannungPhase1.Location = new System.Drawing.Point(245, 45);
			this.txtSpannungPhase1.Name = "txtSpannungPhase1";
			this.txtSpannungPhase1.Size = new System.Drawing.Size(70, 26);
			this.txtSpannungPhase1.TabIndex = 17;
			this.txtSpannungPhase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 20);
			this.label11.TabIndex = 18;
			this.label11.Text = "Strom";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(137, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 20);
			this.label12.TabIndex = 19;
			this.label12.Text = "A";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(160, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(83, 20);
			this.label13.TabIndex = 20;
			this.label13.Text = "Spannung";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(317, 48);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(20, 20);
			this.label14.TabIndex = 21;
			this.label14.Text = "V";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(317, 48);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(20, 20);
			this.label15.TabIndex = 34;
			this.label15.Text = "V";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(160, 48);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(83, 20);
			this.label16.TabIndex = 33;
			this.label16.Text = "Spannung";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(137, 48);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(20, 20);
			this.label17.TabIndex = 32;
			this.label17.Text = "A";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(6, 48);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(52, 20);
			this.label18.TabIndex = 31;
			this.label18.Text = "Strom";
			// 
			// txtSpannungPhase2
			// 
			this.txtSpannungPhase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSpannungPhase2.Location = new System.Drawing.Point(245, 45);
			this.txtSpannungPhase2.Name = "txtSpannungPhase2";
			this.txtSpannungPhase2.Size = new System.Drawing.Size(70, 26);
			this.txtSpannungPhase2.TabIndex = 30;
			this.txtSpannungPhase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtStromPhase2
			// 
			this.txtStromPhase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStromPhase2.Location = new System.Drawing.Point(65, 45);
			this.txtStromPhase2.Name = "txtStromPhase2";
			this.txtStromPhase2.Size = new System.Drawing.Size(70, 26);
			this.txtStromPhase2.TabIndex = 29;
			this.txtStromPhase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(160, 18);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(76, 20);
			this.label19.TabIndex = 28;
			this.label19.Text = "Lieferung";
			// 
			// txtLieferungPhase2
			// 
			this.txtLieferungPhase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLieferungPhase2.Location = new System.Drawing.Point(245, 15);
			this.txtLieferungPhase2.Name = "txtLieferungPhase2";
			this.txtLieferungPhase2.Size = new System.Drawing.Size(70, 26);
			this.txtLieferungPhase2.TabIndex = 27;
			this.txtLieferungPhase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(315, 18);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(24, 20);
			this.label20.TabIndex = 26;
			this.label20.Text = "W";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(135, 18);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(24, 20);
			this.label21.TabIndex = 25;
			this.label21.Text = "W";
			// 
			// txtBezugPhase2
			// 
			this.txtBezugPhase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBezugPhase2.Location = new System.Drawing.Point(65, 15);
			this.txtBezugPhase2.Name = "txtBezugPhase2";
			this.txtBezugPhase2.Size = new System.Drawing.Size(70, 26);
			this.txtBezugPhase2.TabIndex = 24;
			this.txtBezugPhase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(6, 18);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(55, 20);
			this.label22.TabIndex = 23;
			this.label22.Text = "Bezug";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(317, 48);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(20, 20);
			this.label24.TabIndex = 47;
			this.label24.Text = "V";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(160, 48);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(83, 20);
			this.label25.TabIndex = 46;
			this.label25.Text = "Spannung";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(137, 48);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(20, 20);
			this.label26.TabIndex = 45;
			this.label26.Text = "A";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(6, 48);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(52, 20);
			this.label27.TabIndex = 44;
			this.label27.Text = "Strom";
			// 
			// txtSpannungPhase3
			// 
			this.txtSpannungPhase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSpannungPhase3.Location = new System.Drawing.Point(245, 45);
			this.txtSpannungPhase3.Name = "txtSpannungPhase3";
			this.txtSpannungPhase3.Size = new System.Drawing.Size(70, 26);
			this.txtSpannungPhase3.TabIndex = 43;
			this.txtSpannungPhase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtStromPhase3
			// 
			this.txtStromPhase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStromPhase3.Location = new System.Drawing.Point(65, 45);
			this.txtStromPhase3.Name = "txtStromPhase3";
			this.txtStromPhase3.Size = new System.Drawing.Size(70, 26);
			this.txtStromPhase3.TabIndex = 42;
			this.txtStromPhase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(160, 18);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(76, 20);
			this.label28.TabIndex = 41;
			this.label28.Text = "Lieferung";
			// 
			// txtLieferungPhase3
			// 
			this.txtLieferungPhase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLieferungPhase3.Location = new System.Drawing.Point(245, 15);
			this.txtLieferungPhase3.Name = "txtLieferungPhase3";
			this.txtLieferungPhase3.Size = new System.Drawing.Size(70, 26);
			this.txtLieferungPhase3.TabIndex = 40;
			this.txtLieferungPhase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(315, 18);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(24, 20);
			this.label29.TabIndex = 39;
			this.label29.Text = "W";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(135, 18);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(24, 20);
			this.label30.TabIndex = 38;
			this.label30.Text = "W";
			// 
			// txtBezugPhase3
			// 
			this.txtBezugPhase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBezugPhase3.Location = new System.Drawing.Point(65, 15);
			this.txtBezugPhase3.Name = "txtBezugPhase3";
			this.txtBezugPhase3.Size = new System.Drawing.Size(70, 26);
			this.txtBezugPhase3.TabIndex = 37;
			this.txtBezugPhase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(6, 18);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(55, 20);
			this.label31.TabIndex = 36;
			this.label31.Text = "Bezug";
			// 
			// btnEnde
			// 
			this.btnEnde.Location = new System.Drawing.Point(516, 373);
			this.btnEnde.Name = "btnEnde";
			this.btnEnde.Size = new System.Drawing.Size(316, 26);
			this.btnEnde.TabIndex = 48;
			this.btnEnde.Text = "Ende";
			this.btnEnde.UseVisualStyleBackColor = true;
			this.btnEnde.Click += new System.EventHandler(this.BtnEndeClick);
			// 
			// chart
			// 
			chartArea1.Name = "Area";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Name = "Legend";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(12, 408);
			this.chart.Name = "chart";
			this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			this.chart.Size = new System.Drawing.Size(819, 214);
			this.chart.TabIndex = 49;
			this.chart.Text = "chart1";
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Items.AddRange(new object[] {
									"Alle",
									"0:05",
									"0:10",
									"0:15",
									"0:30",
									"1:00",
									"2:00",
									"3:00",
									"6:00",
									"12:00",
									"24:00",
									"ttt"});
			this.comboBox.Location = new System.Drawing.Point(427, 375);
			this.comboBox.Name = "comboBox";
			this.comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBox.Size = new System.Drawing.Size(83, 24);
			this.comboBox.TabIndex = 50;
			// 
			// gaugeBezug
			// 
			this.gaugeBezug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gaugeBezug.BaseArcColor = System.Drawing.Color.Black;
			this.gaugeBezug.BaseArcRadius = 80;
			this.gaugeBezug.BaseArcStart = 135;
			this.gaugeBezug.BaseArcSweep = 270;
			this.gaugeBezug.BaseArcWidth = 2;
			this.gaugeBezug.Center = new System.Drawing.Point(110, 110);
			aGaugeLabel2.Color = System.Drawing.SystemColors.WindowText;
			aGaugeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			aGaugeLabel2.Name = "gaugeBezugLabel";
			aGaugeLabel2.Position = new System.Drawing.Point(75, 190);
			aGaugeLabel2.Text = "Bezug W";
			this.gaugeBezug.GaugeLabels.Add(aGaugeLabel2);
			this.gaugeBezug.Location = new System.Drawing.Point(386, 27);
			this.gaugeBezug.MaxValue = 1000F;
			this.gaugeBezug.MinValue = 0F;
			this.gaugeBezug.Name = "gaugeBezug";
			this.gaugeBezug.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
			this.gaugeBezug.NeedleColor2 = System.Drawing.Color.DarkRed;
			this.gaugeBezug.NeedleRadius = 80;
			this.gaugeBezug.NeedleType = System.Windows.Forms.NeedleType.Simple;
			this.gaugeBezug.NeedleWidth = 3;
			this.gaugeBezug.ScaleLinesInterColor = System.Drawing.Color.Black;
			this.gaugeBezug.ScaleLinesInterInnerRadius = 73;
			this.gaugeBezug.ScaleLinesInterOuterRadius = 80;
			this.gaugeBezug.ScaleLinesInterWidth = 1;
			this.gaugeBezug.ScaleLinesMajorColor = System.Drawing.Color.Black;
			this.gaugeBezug.ScaleLinesMajorInnerRadius = 70;
			this.gaugeBezug.ScaleLinesMajorOuterRadius = 80;
			this.gaugeBezug.ScaleLinesMajorStepValue = 500F;
			this.gaugeBezug.ScaleLinesMajorWidth = 2;
			this.gaugeBezug.ScaleLinesMinorColor = System.Drawing.Color.Gray;
			this.gaugeBezug.ScaleLinesMinorInnerRadius = 75;
			this.gaugeBezug.ScaleLinesMinorOuterRadius = 80;
			this.gaugeBezug.ScaleLinesMinorTicks = 9;
			this.gaugeBezug.ScaleLinesMinorWidth = 1;
			this.gaugeBezug.ScaleNumbersColor = System.Drawing.Color.Black;
			this.gaugeBezug.ScaleNumbersFormat = "0";
			this.gaugeBezug.ScaleNumbersRadius = 95;
			this.gaugeBezug.ScaleNumbersRotation = 0;
			this.gaugeBezug.ScaleNumbersStartScaleLine = 1;
			this.gaugeBezug.ScaleNumbersStepScaleLines = 100;
			this.gaugeBezug.Size = new System.Drawing.Size(220, 220);
			this.gaugeBezug.TabIndex = 51;
			this.gaugeBezug.Text = "Summe";
			this.gaugeBezug.Value = 0F;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(358, 380);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 52;
			this.label1.Text = "Zeitspanne:";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.Location = new System.Drawing.Point(6, 63);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(113, 20);
			this.label33.TabIndex = 53;
			this.label33.Text = "Scheinleistung";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(6, 93);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(99, 20);
			this.label34.TabIndex = 54;
			this.label34.Text = "Blindleistung";
			// 
			// txtBezugScheinleistung
			// 
			this.txtBezugScheinleistung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBezugScheinleistung.Location = new System.Drawing.Point(128, 60);
			this.txtBezugScheinleistung.Name = "txtBezugScheinleistung";
			this.txtBezugScheinleistung.Size = new System.Drawing.Size(95, 26);
			this.txtBezugScheinleistung.TabIndex = 55;
			this.txtBezugScheinleistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtBezugBlindleistung
			// 
			this.txtBezugBlindleistung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBezugBlindleistung.Location = new System.Drawing.Point(128, 90);
			this.txtBezugBlindleistung.Name = "txtBezugBlindleistung";
			this.txtBezugBlindleistung.Size = new System.Drawing.Size(95, 26);
			this.txtBezugBlindleistung.TabIndex = 56;
			this.txtBezugBlindleistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtLieferungScheinleistung
			// 
			this.txtLieferungScheinleistung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLieferungScheinleistung.Location = new System.Drawing.Point(236, 60);
			this.txtLieferungScheinleistung.Name = "txtLieferungScheinleistung";
			this.txtLieferungScheinleistung.Size = new System.Drawing.Size(95, 26);
			this.txtLieferungScheinleistung.TabIndex = 57;
			this.txtLieferungScheinleistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtLieferungBlindleistung
			// 
			this.txtLieferungBlindleistung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLieferungBlindleistung.Location = new System.Drawing.Point(236, 90);
			this.txtLieferungBlindleistung.Name = "txtLieferungBlindleistung";
			this.txtLieferungBlindleistung.Size = new System.Drawing.Size(95, 26);
			this.txtLieferungBlindleistung.TabIndex = 58;
			this.txtLieferungBlindleistung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// grpPhase1
			// 
			this.grpPhase1.Controls.Add(this.label7);
			this.grpPhase1.Controls.Add(this.txtBezugPhase1);
			this.grpPhase1.Controls.Add(this.label8);
			this.grpPhase1.Controls.Add(this.txtStromPhase1);
			this.grpPhase1.Controls.Add(this.label11);
			this.grpPhase1.Controls.Add(this.label12);
			this.grpPhase1.Controls.Add(this.label10);
			this.grpPhase1.Controls.Add(this.label9);
			this.grpPhase1.Controls.Add(this.txtLieferungPhase1);
			this.grpPhase1.Controls.Add(this.txtSpannungPhase1);
			this.grpPhase1.Controls.Add(this.label13);
			this.grpPhase1.Controls.Add(this.label14);
			this.grpPhase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpPhase1.Location = new System.Drawing.Point(12, 146);
			this.grpPhase1.Name = "grpPhase1";
			this.grpPhase1.Size = new System.Drawing.Size(340, 80);
			this.grpPhase1.TabIndex = 59;
			this.grpPhase1.TabStop = false;
			this.grpPhase1.Text = "Phase 1";
			// 
			// grpPhase2
			// 
			this.grpPhase2.Controls.Add(this.label18);
			this.grpPhase2.Controls.Add(this.label22);
			this.grpPhase2.Controls.Add(this.txtBezugPhase2);
			this.grpPhase2.Controls.Add(this.label21);
			this.grpPhase2.Controls.Add(this.txtStromPhase2);
			this.grpPhase2.Controls.Add(this.label17);
			this.grpPhase2.Controls.Add(this.label16);
			this.grpPhase2.Controls.Add(this.label20);
			this.grpPhase2.Controls.Add(this.txtLieferungPhase2);
			this.grpPhase2.Controls.Add(this.label19);
			this.grpPhase2.Controls.Add(this.txtSpannungPhase2);
			this.grpPhase2.Controls.Add(this.label15);
			this.grpPhase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpPhase2.Location = new System.Drawing.Point(12, 234);
			this.grpPhase2.Name = "grpPhase2";
			this.grpPhase2.Size = new System.Drawing.Size(340, 80);
			this.grpPhase2.TabIndex = 60;
			this.grpPhase2.TabStop = false;
			this.grpPhase2.Text = "Phase 2";
			// 
			// grpPhase3
			// 
			this.grpPhase3.Controls.Add(this.label31);
			this.grpPhase3.Controls.Add(this.txtBezugPhase3);
			this.grpPhase3.Controls.Add(this.label30);
			this.grpPhase3.Controls.Add(this.txtStromPhase3);
			this.grpPhase3.Controls.Add(this.label27);
			this.grpPhase3.Controls.Add(this.label26);
			this.grpPhase3.Controls.Add(this.label28);
			this.grpPhase3.Controls.Add(this.label29);
			this.grpPhase3.Controls.Add(this.txtLieferungPhase3);
			this.grpPhase3.Controls.Add(this.txtSpannungPhase3);
			this.grpPhase3.Controls.Add(this.label25);
			this.grpPhase3.Controls.Add(this.label24);
			this.grpPhase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpPhase3.Location = new System.Drawing.Point(12, 322);
			this.grpPhase3.Name = "grpPhase3";
			this.grpPhase3.Size = new System.Drawing.Size(340, 80);
			this.grpPhase3.TabIndex = 61;
			this.grpPhase3.TabStop = false;
			this.grpPhase3.Text = "Phase 3";
			// 
			// grpSumme
			// 
			this.grpSumme.Controls.Add(this.label2);
			this.grpSumme.Controls.Add(this.label3);
			this.grpSumme.Controls.Add(this.txtBezugWirkleistung);
			this.grpSumme.Controls.Add(this.txtLieferungWirkleistung);
			this.grpSumme.Controls.Add(this.txtLieferungBlindleistung);
			this.grpSumme.Controls.Add(this.label4);
			this.grpSumme.Controls.Add(this.txtLieferungScheinleistung);
			this.grpSumme.Controls.Add(this.label33);
			this.grpSumme.Controls.Add(this.txtBezugBlindleistung);
			this.grpSumme.Controls.Add(this.label34);
			this.grpSumme.Controls.Add(this.txtBezugScheinleistung);
			this.grpSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpSumme.Location = new System.Drawing.Point(12, 12);
			this.grpSumme.Name = "grpSumme";
			this.grpSumme.Size = new System.Drawing.Size(340, 125);
			this.grpSumme.TabIndex = 62;
			this.grpSumme.TabStop = false;
			this.grpSumme.Text = "Summe";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 634);
			this.ControlBox = false;
			this.Controls.Add(this.grpSumme);
			this.Controls.Add(this.grpPhase3);
			this.Controls.Add(this.grpPhase2);
			this.Controls.Add(this.grpPhase1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gaugeBezug);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.btnEnde);
			this.Controls.Add(this.gaugeLieferung);
			this.Controls.Add(this.txtStatus);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "SMA Energy Monitor";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.grpPhase1.ResumeLayout(false);
			this.grpPhase1.PerformLayout();
			this.grpPhase2.ResumeLayout(false);
			this.grpPhase2.PerformLayout();
			this.grpPhase3.ResumeLayout(false);
			this.grpPhase3.PerformLayout();
			this.grpSumme.ResumeLayout(false);
			this.grpSumme.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox grpSumme;
		private System.Windows.Forms.GroupBox grpPhase3;
		private System.Windows.Forms.GroupBox grpPhase2;
		private System.Windows.Forms.GroupBox grpPhase1;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.AGauge gaugeLieferung;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBezugWirkleistung;
		private System.Windows.Forms.TextBox txtLieferungWirkleistung;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBezugPhase1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtLieferungPhase1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtStromPhase1;
		private System.Windows.Forms.TextBox txtSpannungPhase1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtSpannungPhase2;
		private System.Windows.Forms.TextBox txtStromPhase2;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtLieferungPhase2;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtBezugPhase2;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtSpannungPhase3;
		private System.Windows.Forms.TextBox txtStromPhase3;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txtLieferungPhase3;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox txtBezugPhase3;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Button btnEnde;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.AGauge gaugeBezug;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox txtBezugScheinleistung;
		private System.Windows.Forms.TextBox txtBezugBlindleistung;
		private System.Windows.Forms.TextBox txtLieferungScheinleistung;
		private System.Windows.Forms.TextBox txtLieferungBlindleistung;
	}
}
