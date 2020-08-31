namespace ProyectoMA475
{
    partial class FRM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.min_pic = new System.Windows.Forms.PictureBox();
            this.close_pic = new System.Windows.Forms.PictureBox();
            this.panelOperaciones = new System.Windows.Forms.Panel();
            this.btnExpansion = new System.Windows.Forms.Button();
            this.btnEcualizar = new System.Windows.Forms.Button();
            this.btnGrises = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.panelArchivo = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.imgPic = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelhisto = new System.Windows.Forms.Panel();
            this.chartGrises = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.chartRojo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.chartVerde = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.chartAzul = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).BeginInit();
            this.panelOperaciones.SuspendLayout();
            this.panelArchivo.SuspendLayout();
            this.imgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).BeginInit();
            this.panelhisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAzul)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.AutoScroll = true;
            this.PanelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.PanelOpciones.Controls.Add(this.label1);
            this.PanelOpciones.Controls.Add(this.min_pic);
            this.PanelOpciones.Controls.Add(this.close_pic);
            this.PanelOpciones.Controls.Add(this.panelOperaciones);
            this.PanelOpciones.Controls.Add(this.btn2);
            this.PanelOpciones.Controls.Add(this.panelArchivo);
            this.PanelOpciones.Controls.Add(this.btn1);
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Padding = new System.Windows.Forms.Padding(0, 180, 0, 0);
            this.PanelOpciones.Size = new System.Drawing.Size(220, 731);
            this.PanelOpciones.TabIndex = 2;
            this.PanelOpciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelOpciones_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 75);
            this.label1.TabIndex = 18;
            this.label1.Text = "Expansión y \r\necualización de \r\nhistogramas";
            // 
            // min_pic
            // 
            this.min_pic.Image = global::ProyectoMA475.Properties.Resources.min_icon;
            this.min_pic.Location = new System.Drawing.Point(41, 8);
            this.min_pic.Name = "min_pic";
            this.min_pic.Size = new System.Drawing.Size(18, 18);
            this.min_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min_pic.TabIndex = 17;
            this.min_pic.TabStop = false;
            this.min_pic.Click += new System.EventHandler(this.min_pic_Click);
            // 
            // close_pic
            // 
            this.close_pic.Image = global::ProyectoMA475.Properties.Resources.close_icon;
            this.close_pic.Location = new System.Drawing.Point(16, 8);
            this.close_pic.Name = "close_pic";
            this.close_pic.Size = new System.Drawing.Size(18, 18);
            this.close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_pic.TabIndex = 6;
            this.close_pic.TabStop = false;
            this.close_pic.Click += new System.EventHandler(this.close_pic_Click);
            // 
            // panelOperaciones
            // 
            this.panelOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.panelOperaciones.Controls.Add(this.btnExpansion);
            this.panelOperaciones.Controls.Add(this.btnEcualizar);
            this.panelOperaciones.Controls.Add(this.btnGrises);
            this.panelOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOperaciones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOperaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.panelOperaciones.Location = new System.Drawing.Point(0, 328);
            this.panelOperaciones.Name = "panelOperaciones";
            this.panelOperaciones.Size = new System.Drawing.Size(220, 107);
            this.panelOperaciones.TabIndex = 14;
            // 
            // btnExpansion
            // 
            this.btnExpansion.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExpansion.FlatAppearance.BorderSize = 0;
            this.btnExpansion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnExpansion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnExpansion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpansion.Location = new System.Drawing.Point(-1, 71);
            this.btnExpansion.Name = "btnExpansion";
            this.btnExpansion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExpansion.Size = new System.Drawing.Size(220, 30);
            this.btnExpansion.TabIndex = 11;
            this.btnExpansion.Text = "Expansion";
            this.btnExpansion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpansion.UseVisualStyleBackColor = true;
            this.btnExpansion.Click += new System.EventHandler(this.btnExpansion_Click);
            // 
            // btnEcualizar
            // 
            this.btnEcualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEcualizar.FlatAppearance.BorderSize = 0;
            this.btnEcualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnEcualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnEcualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcualizar.Location = new System.Drawing.Point(-1, 35);
            this.btnEcualizar.Name = "btnEcualizar";
            this.btnEcualizar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEcualizar.Size = new System.Drawing.Size(220, 30);
            this.btnEcualizar.TabIndex = 10;
            this.btnEcualizar.Text = "Ecualizar";
            this.btnEcualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEcualizar.UseVisualStyleBackColor = true;
            this.btnEcualizar.Click += new System.EventHandler(this.btnEcualizar_Click);
            // 
            // btnGrises
            // 
            this.btnGrises.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGrises.FlatAppearance.BorderSize = 0;
            this.btnGrises.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnGrises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnGrises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrises.Location = new System.Drawing.Point(-1, -1);
            this.btnGrises.Name = "btnGrises";
            this.btnGrises.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGrises.Size = new System.Drawing.Size(220, 30);
            this.btnGrises.TabIndex = 8;
            this.btnGrises.Text = "Escala de grises";
            this.btnGrises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrises.UseVisualStyleBackColor = true;
            this.btnGrises.Click += new System.EventHandler(this.btnGrises_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(0, 286);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn2.Size = new System.Drawing.Size(220, 42);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "Operaciones";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // panelArchivo
            // 
            this.panelArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.panelArchivo.Controls.Add(this.btnSave);
            this.panelArchivo.Controls.Add(this.btnOpen);
            this.panelArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArchivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelArchivo.ForeColor = System.Drawing.SystemColors.Control;
            this.panelArchivo.Location = new System.Drawing.Point(0, 222);
            this.panelArchivo.Name = "panelArchivo";
            this.panelArchivo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelArchivo.Size = new System.Drawing.Size(220, 64);
            this.panelArchivo.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(-1, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(220, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Guardar imagen";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(102)))));
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(-1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOpen.Size = new System.Drawing.Size(220, 30);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Abrir imagen";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(0, 180);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn1.Size = new System.Drawing.Size(220, 42);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "Archivo";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imgPanel
            // 
            this.imgPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPanel.AutoScroll = true;
            this.imgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPanel.Controls.Add(this.imgPic);
            this.imgPanel.Location = new System.Drawing.Point(260, 144);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(712, 433);
            this.imgPanel.TabIndex = 5;
            // 
            // imgPic
            // 
            this.imgPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPic.Location = new System.Drawing.Point(13, 12);
            this.imgPic.Name = "imgPic";
            this.imgPic.Size = new System.Drawing.Size(684, 404);
            this.imgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPic.TabIndex = 2;
            this.imgPic.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.png";
            // 
            // panelhisto
            // 
            this.panelhisto.AutoScroll = true;
            this.panelhisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelhisto.Controls.Add(this.chartAzul);
            this.panelhisto.Controls.Add(this.label5);
            this.panelhisto.Controls.Add(this.chartVerde);
            this.panelhisto.Controls.Add(this.label4);
            this.panelhisto.Controls.Add(this.chartRojo);
            this.panelhisto.Controls.Add(this.label3);
            this.panelhisto.Controls.Add(this.chartGrises);
            this.panelhisto.Controls.Add(this.label2);
            this.panelhisto.Location = new System.Drawing.Point(1009, -1);
            this.panelhisto.Name = "panelhisto";
            this.panelhisto.Padding = new System.Windows.Forms.Padding(0, 180, 0, 0);
            this.panelhisto.Size = new System.Drawing.Size(323, 732);
            this.panelhisto.TabIndex = 6;
            // 
            // chartGrises
            // 
            this.chartGrises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea9.Name = "ChartArea1";
            this.chartGrises.ChartAreas.Add(chartArea9);
            this.chartGrises.Location = new System.Drawing.Point(12, 41);
            this.chartGrises.Name = "chartGrises";
            this.chartGrises.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series9.ChartArea = "ChartArea1";
            series9.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series9.Name = "Series1";
            this.chartGrises.Series.Add(series9);
            this.chartGrises.Size = new System.Drawing.Size(300, 143);
            this.chartGrises.TabIndex = 19;
            this.chartGrises.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Grises";
            // 
            // chartRojo
            // 
            this.chartRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea10.Name = "ChartArea1";
            this.chartRojo.ChartAreas.Add(chartArea10);
            this.chartRojo.Location = new System.Drawing.Point(12, 216);
            this.chartRojo.Name = "chartRojo";
            this.chartRojo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series10.ChartArea = "ChartArea1";
            series10.Name = "Series1";
            this.chartRojo.Series.Add(series10);
            this.chartRojo.Size = new System.Drawing.Size(300, 143);
            this.chartRojo.TabIndex = 21;
            this.chartRojo.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rojo";
            // 
            // chartVerde
            // 
            this.chartVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea11.Name = "ChartArea1";
            this.chartVerde.ChartAreas.Add(chartArea11);
            this.chartVerde.Location = new System.Drawing.Point(12, 393);
            this.chartVerde.Name = "chartVerde";
            this.chartVerde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series11.ChartArea = "ChartArea1";
            series11.Name = "Series1";
            this.chartVerde.Series.Add(series11);
            this.chartVerde.Size = new System.Drawing.Size(300, 143);
            this.chartVerde.TabIndex = 23;
            this.chartVerde.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Verde";
            // 
            // chartAzul
            // 
            this.chartAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            chartArea12.Name = "ChartArea1";
            this.chartAzul.ChartAreas.Add(chartArea12);
            this.chartAzul.Location = new System.Drawing.Point(12, 569);
            this.chartAzul.Name = "chartAzul";
            this.chartAzul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series12.ChartArea = "ChartArea1";
            series12.Name = "Series1";
            this.chartAzul.Series.Add(series12);
            this.chartAzul.Size = new System.Drawing.Size(300, 143);
            this.chartAzul.TabIndex = 25;
            this.chartAzul.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(14, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Azul";
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1333, 730);
            this.Controls.Add(this.panelhisto);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.PanelOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImgHisto";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Main_MouseDown);
            this.PanelOpciones.ResumeLayout(false);
            this.PanelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.min_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_pic)).EndInit();
            this.panelOperaciones.ResumeLayout(false);
            this.panelArchivo.ResumeLayout(false);
            this.imgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).EndInit();
            this.panelhisto.ResumeLayout(false);
            this.panelhisto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAzul)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Panel panelOperaciones;
        private System.Windows.Forms.Button btnExpansion;
        private System.Windows.Forms.Button btnEcualizar;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Panel panelArchivo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.PictureBox imgPic;
        private System.Windows.Forms.PictureBox min_pic;
        private System.Windows.Forms.PictureBox close_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelhisto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrises;
        private System.Windows.Forms.Button btnGrises;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAzul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVerde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRojo;
        private System.Windows.Forms.Label label3;
    }
}