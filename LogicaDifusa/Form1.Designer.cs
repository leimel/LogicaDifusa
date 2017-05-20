namespace LogicaDifusa
{
    partial class Form1
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
            this.triangular = new System.Windows.Forms.CheckBox();
            this.trapezoidal = new System.Windows.Forms.CheckBox();
            this.gaussiana = new System.Windows.Forms.CheckBox();
            this.bell = new System.Windows.Forms.CheckBox();
            this.sigmoide = new System.Windows.Forms.CheckBox();
            this.TriA = new System.Windows.Forms.TextBox();
            this.TriB = new System.Windows.Forms.TextBox();
            this.TriC = new System.Windows.Forms.TextBox();
            this.TraA = new System.Windows.Forms.TextBox();
            this.TraB = new System.Windows.Forms.TextBox();
            this.TraC = new System.Windows.Forms.TextBox();
            this.TraD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TriInferior = new System.Windows.Forms.TextBox();
            this.TriSuperior = new System.Windows.Forms.TextBox();
            this.TraInferio = new System.Windows.Forms.TextBox();
            this.TraSuperior = new System.Windows.Forms.TextBox();
            this.GaInferior = new System.Windows.Forms.TextBox();
            this.GaSuperior = new System.Windows.Forms.TextBox();
            this.BeInferior = new System.Windows.Forms.TextBox();
            this.BeSuperior = new System.Windows.Forms.TextBox();
            this.SigInferior = new System.Windows.Forms.TextBox();
            this.SigSuperior = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.GaB = new System.Windows.Forms.TextBox();
            this.GaA = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.BeC = new System.Windows.Forms.TextBox();
            this.BeB = new System.Windows.Forms.TextBox();
            this.BeA = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SigB = new System.Windows.Forms.TextBox();
            this.SigA = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.valoresTri = new System.Windows.Forms.GroupBox();
            this.valoresTra = new System.Windows.Forms.GroupBox();
            this.valoresBe = new System.Windows.Forms.GroupBox();
            this.valoresSi = new System.Windows.Forms.GroupBox();
            this.valoresGa = new System.Windows.Forms.GroupBox();
            this.graficar = new System.Windows.Forms.Button();
            this.valoresTri.SuspendLayout();
            this.valoresTra.SuspendLayout();
            this.valoresBe.SuspendLayout();
            this.valoresSi.SuspendLayout();
            this.valoresGa.SuspendLayout();
            this.SuspendLayout();
            // 
            // triangular
            // 
            this.triangular.AutoSize = true;
            this.triangular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangular.Location = new System.Drawing.Point(7, 25);
            this.triangular.Name = "triangular";
            this.triangular.Size = new System.Drawing.Size(106, 17);
            this.triangular.TabIndex = 0;
            this.triangular.Text = "TRIANGULAR";
            this.triangular.UseVisualStyleBackColor = true;
            this.triangular.CheckedChanged += new System.EventHandler(this.triangular_CheckedChanged);
            // 
            // trapezoidal
            // 
            this.trapezoidal.AutoSize = true;
            this.trapezoidal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trapezoidal.Location = new System.Drawing.Point(7, 123);
            this.trapezoidal.Name = "trapezoidal";
            this.trapezoidal.Size = new System.Drawing.Size(112, 17);
            this.trapezoidal.TabIndex = 1;
            this.trapezoidal.Text = "TRAPEZOIDAL";
            this.trapezoidal.UseVisualStyleBackColor = true;
            this.trapezoidal.CheckedChanged += new System.EventHandler(this.trapezoidal_CheckedChanged);
            // 
            // gaussiana
            // 
            this.gaussiana.AutoSize = true;
            this.gaussiana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussiana.Location = new System.Drawing.Point(6, 234);
            this.gaussiana.Name = "gaussiana";
            this.gaussiana.Size = new System.Drawing.Size(97, 17);
            this.gaussiana.TabIndex = 2;
            this.gaussiana.Text = "GAUSSIANA";
            this.gaussiana.UseVisualStyleBackColor = true;
            this.gaussiana.CheckedChanged += new System.EventHandler(this.gaussiana_CheckedChanged);
            // 
            // bell
            // 
            this.bell.AutoSize = true;
            this.bell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bell.Location = new System.Drawing.Point(7, 346);
            this.bell.Name = "bell";
            this.bell.Size = new System.Drawing.Size(56, 17);
            this.bell.TabIndex = 3;
            this.bell.Text = "BELL";
            this.bell.UseVisualStyleBackColor = true;
            this.bell.CheckedChanged += new System.EventHandler(this.bell_CheckedChanged);
            // 
            // sigmoide
            // 
            this.sigmoide.AutoSize = true;
            this.sigmoide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigmoide.Location = new System.Drawing.Point(7, 458);
            this.sigmoide.Name = "sigmoide";
            this.sigmoide.Size = new System.Drawing.Size(87, 17);
            this.sigmoide.TabIndex = 4;
            this.sigmoide.Text = "SIGMOIDE";
            this.sigmoide.UseVisualStyleBackColor = true;
            this.sigmoide.CheckedChanged += new System.EventHandler(this.sigmoide_CheckedChanged);
            // 
            // TriA
            // 
            this.TriA.Location = new System.Drawing.Point(32, 48);
            this.TriA.Name = "TriA";
            this.TriA.Size = new System.Drawing.Size(43, 20);
            this.TriA.TabIndex = 5;
            this.TriA.Tag = "";
            // 
            // TriB
            // 
            this.TriB.Location = new System.Drawing.Point(120, 48);
            this.TriB.Name = "TriB";
            this.TriB.Size = new System.Drawing.Size(42, 20);
            this.TriB.TabIndex = 6;
            // 
            // TriC
            // 
            this.TriC.Location = new System.Drawing.Point(199, 48);
            this.TriC.Name = "TriC";
            this.TriC.Size = new System.Drawing.Size(42, 20);
            this.TriC.TabIndex = 7;
            // 
            // TraA
            // 
            this.TraA.Location = new System.Drawing.Point(28, 46);
            this.TraA.Name = "TraA";
            this.TraA.Size = new System.Drawing.Size(43, 20);
            this.TraA.TabIndex = 8;
            // 
            // TraB
            // 
            this.TraB.Location = new System.Drawing.Point(109, 47);
            this.TraB.Name = "TraB";
            this.TraB.Size = new System.Drawing.Size(42, 20);
            this.TraB.TabIndex = 9;
            // 
            // TraC
            // 
            this.TraC.Location = new System.Drawing.Point(189, 47);
            this.TraC.Name = "TraC";
            this.TraC.Size = new System.Drawing.Size(42, 20);
            this.TraC.TabIndex = 10;
            this.TraC.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // TraD
            // 
            this.TraD.Location = new System.Drawing.Point(268, 46);
            this.TraD.Name = "TraD";
            this.TraD.Size = new System.Drawing.Size(40, 20);
            this.TraD.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inferior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Superior";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Inferior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Superior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Inferior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Superior";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Inferior";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Superior";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Inferior";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Superior";
            // 
            // TriInferior
            // 
            this.TriInferior.Location = new System.Drawing.Point(56, 20);
            this.TriInferior.Name = "TriInferior";
            this.TriInferior.Size = new System.Drawing.Size(42, 20);
            this.TriInferior.TabIndex = 29;
            this.TriInferior.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // TriSuperior
            // 
            this.TriSuperior.Location = new System.Drawing.Point(177, 20);
            this.TriSuperior.Name = "TriSuperior";
            this.TriSuperior.Size = new System.Drawing.Size(42, 20);
            this.TriSuperior.TabIndex = 30;
            // 
            // TraInferio
            // 
            this.TraInferio.Location = new System.Drawing.Point(52, 9);
            this.TraInferio.Name = "TraInferio";
            this.TraInferio.Size = new System.Drawing.Size(42, 20);
            this.TraInferio.TabIndex = 31;
            // 
            // TraSuperior
            // 
            this.TraSuperior.Location = new System.Drawing.Point(207, 13);
            this.TraSuperior.Name = "TraSuperior";
            this.TraSuperior.Size = new System.Drawing.Size(42, 20);
            this.TraSuperior.TabIndex = 32;
            // 
            // GaInferior
            // 
            this.GaInferior.Location = new System.Drawing.Point(60, 25);
            this.GaInferior.Name = "GaInferior";
            this.GaInferior.Size = new System.Drawing.Size(42, 20);
            this.GaInferior.TabIndex = 33;
            // 
            // GaSuperior
            // 
            this.GaSuperior.Location = new System.Drawing.Point(175, 25);
            this.GaSuperior.Name = "GaSuperior";
            this.GaSuperior.Size = new System.Drawing.Size(42, 20);
            this.GaSuperior.TabIndex = 34;
            // 
            // BeInferior
            // 
            this.BeInferior.Location = new System.Drawing.Point(46, 21);
            this.BeInferior.Name = "BeInferior";
            this.BeInferior.Size = new System.Drawing.Size(42, 20);
            this.BeInferior.TabIndex = 35;
            // 
            // BeSuperior
            // 
            this.BeSuperior.Location = new System.Drawing.Point(172, 21);
            this.BeSuperior.Name = "BeSuperior";
            this.BeSuperior.Size = new System.Drawing.Size(42, 20);
            this.BeSuperior.TabIndex = 36;
            // 
            // SigInferior
            // 
            this.SigInferior.Location = new System.Drawing.Point(51, 16);
            this.SigInferior.Name = "SigInferior";
            this.SigInferior.Size = new System.Drawing.Size(42, 20);
            this.SigInferior.TabIndex = 37;
            // 
            // SigSuperior
            // 
            this.SigSuperior.Location = new System.Drawing.Point(170, 16);
            this.SigSuperior.Name = "SigSuperior";
            this.SigSuperior.Size = new System.Drawing.Size(42, 20);
            this.SigSuperior.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "a: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "b:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(168, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "c:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "a:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "b:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(167, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "c:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(246, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "d:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(123, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "b:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "a:";
            // 
            // GaB
            // 
            this.GaB.Location = new System.Drawing.Point(163, 59);
            this.GaB.Name = "GaB";
            this.GaB.Size = new System.Drawing.Size(42, 20);
            this.GaB.TabIndex = 49;
            // 
            // GaA
            // 
            this.GaA.Location = new System.Drawing.Point(59, 59);
            this.GaA.Name = "GaA";
            this.GaA.Size = new System.Drawing.Size(43, 20);
            this.GaA.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(151, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "c:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(81, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 13);
            this.label23.TabIndex = 56;
            this.label23.Text = "b:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "a: ";
            // 
            // BeC
            // 
            this.BeC.Location = new System.Drawing.Point(173, 52);
            this.BeC.Name = "BeC";
            this.BeC.Size = new System.Drawing.Size(42, 20);
            this.BeC.TabIndex = 54;
            // 
            // BeB
            // 
            this.BeB.Location = new System.Drawing.Point(103, 52);
            this.BeB.Name = "BeB";
            this.BeB.Size = new System.Drawing.Size(42, 20);
            this.BeB.TabIndex = 53;
            // 
            // BeA
            // 
            this.BeA.Location = new System.Drawing.Point(32, 52);
            this.BeA.Name = "BeA";
            this.BeA.Size = new System.Drawing.Size(43, 20);
            this.BeA.TabIndex = 52;
            this.BeA.Tag = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(91, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "b:";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(16, 13);
            this.label26.TabIndex = 60;
            this.label26.Text = "a:";
            // 
            // SigB
            // 
            this.SigB.Location = new System.Drawing.Point(113, 42);
            this.SigB.Name = "SigB";
            this.SigB.Size = new System.Drawing.Size(42, 20);
            this.SigB.TabIndex = 59;
            // 
            // SigA
            // 
            this.SigA.Location = new System.Drawing.Point(28, 42);
            this.SigA.Name = "SigA";
            this.SigA.Size = new System.Drawing.Size(43, 20);
            this.SigA.TabIndex = 58;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(360, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(221, 13);
            this.label27.TabIndex = 62;
            this.label27.Text = "GRAFICAS DE FUNCIONES DIFUSAS";
            // 
            // valoresTri
            // 
            this.valoresTri.Controls.Add(this.TriInferior);
            this.valoresTri.Controls.Add(this.TriA);
            this.valoresTri.Controls.Add(this.TriB);
            this.valoresTri.Controls.Add(this.TriC);
            this.valoresTri.Controls.Add(this.label1);
            this.valoresTri.Controls.Add(this.label2);
            this.valoresTri.Controls.Add(this.TriSuperior);
            this.valoresTri.Controls.Add(this.label11);
            this.valoresTri.Controls.Add(this.label12);
            this.valoresTri.Controls.Add(this.label13);
            this.valoresTri.Location = new System.Drawing.Point(118, 25);
            this.valoresTri.Name = "valoresTri";
            this.valoresTri.Size = new System.Drawing.Size(320, 77);
            this.valoresTri.TabIndex = 64;
            this.valoresTri.TabStop = false;
            this.valoresTri.Text = "Valores";
            this.valoresTri.Visible = false;
            // 
            // valoresTra
            // 
            this.valoresTra.Controls.Add(this.TraInferio);
            this.valoresTra.Controls.Add(this.TraA);
            this.valoresTra.Controls.Add(this.TraB);
            this.valoresTra.Controls.Add(this.TraC);
            this.valoresTra.Controls.Add(this.TraD);
            this.valoresTra.Controls.Add(this.label3);
            this.valoresTra.Controls.Add(this.label4);
            this.valoresTra.Controls.Add(this.TraSuperior);
            this.valoresTra.Controls.Add(this.label14);
            this.valoresTra.Controls.Add(this.label15);
            this.valoresTra.Controls.Add(this.label16);
            this.valoresTra.Controls.Add(this.label17);
            this.valoresTra.Location = new System.Drawing.Point(119, 123);
            this.valoresTra.Name = "valoresTra";
            this.valoresTra.Size = new System.Drawing.Size(319, 82);
            this.valoresTra.TabIndex = 65;
            this.valoresTra.TabStop = false;
            this.valoresTra.Text = "Valores";
            this.valoresTra.Visible = false;
            // 
            // valoresBe
            // 
            this.valoresBe.Controls.Add(this.label20);
            this.valoresBe.Controls.Add(this.label7);
            this.valoresBe.Controls.Add(this.label8);
            this.valoresBe.Controls.Add(this.BeInferior);
            this.valoresBe.Controls.Add(this.BeSuperior);
            this.valoresBe.Controls.Add(this.BeA);
            this.valoresBe.Controls.Add(this.BeB);
            this.valoresBe.Controls.Add(this.label23);
            this.valoresBe.Controls.Add(this.BeC);
            this.valoresBe.Controls.Add(this.label24);
            this.valoresBe.Location = new System.Drawing.Point(119, 346);
            this.valoresBe.Name = "valoresBe";
            this.valoresBe.Size = new System.Drawing.Size(319, 90);
            this.valoresBe.TabIndex = 66;
            this.valoresBe.TabStop = false;
            this.valoresBe.Text = "Valores";
            this.valoresBe.Visible = false;
            // 
            // valoresSi
            // 
            this.valoresSi.Controls.Add(this.SigInferior);
            this.valoresSi.Controls.Add(this.label9);
            this.valoresSi.Controls.Add(this.label10);
            this.valoresSi.Controls.Add(this.SigSuperior);
            this.valoresSi.Controls.Add(this.SigA);
            this.valoresSi.Controls.Add(this.SigB);
            this.valoresSi.Controls.Add(this.label25);
            this.valoresSi.Controls.Add(this.label26);
            this.valoresSi.Location = new System.Drawing.Point(119, 458);
            this.valoresSi.Name = "valoresSi";
            this.valoresSi.Size = new System.Drawing.Size(319, 85);
            this.valoresSi.TabIndex = 66;
            this.valoresSi.TabStop = false;
            this.valoresSi.Text = "Valores";
            this.valoresSi.Visible = false;
            // 
            // valoresGa
            // 
            this.valoresGa.Controls.Add(this.label5);
            this.valoresGa.Controls.Add(this.label6);
            this.valoresGa.Controls.Add(this.GaInferior);
            this.valoresGa.Controls.Add(this.GaSuperior);
            this.valoresGa.Controls.Add(this.GaA);
            this.valoresGa.Controls.Add(this.GaB);
            this.valoresGa.Controls.Add(this.label22);
            this.valoresGa.Controls.Add(this.label21);
            this.valoresGa.Location = new System.Drawing.Point(118, 234);
            this.valoresGa.Name = "valoresGa";
            this.valoresGa.Size = new System.Drawing.Size(320, 84);
            this.valoresGa.TabIndex = 66;
            this.valoresGa.TabStop = false;
            this.valoresGa.Text = "Valores";
            this.valoresGa.Visible = false;
            // 
            // graficar
            // 
            this.graficar.Location = new System.Drawing.Point(611, 4);
            this.graficar.Name = "graficar";
            this.graficar.Size = new System.Drawing.Size(75, 23);
            this.graficar.TabIndex = 67;
            this.graficar.Text = "GRAFICAR";
            this.graficar.UseVisualStyleBackColor = true;
            this.graficar.Click += new System.EventHandler(this.graficar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 555);
            this.Controls.Add(this.graficar);
            this.Controls.Add(this.valoresSi);
            this.Controls.Add(this.valoresGa);
            this.Controls.Add(this.valoresBe);
            this.Controls.Add(this.valoresTra);
            this.Controls.Add(this.valoresTri);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.sigmoide);
            this.Controls.Add(this.bell);
            this.Controls.Add(this.gaussiana);
            this.Controls.Add(this.trapezoidal);
            this.Controls.Add(this.triangular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.valoresTri.ResumeLayout(false);
            this.valoresTri.PerformLayout();
            this.valoresTra.ResumeLayout(false);
            this.valoresTra.PerformLayout();
            this.valoresBe.ResumeLayout(false);
            this.valoresBe.PerformLayout();
            this.valoresSi.ResumeLayout(false);
            this.valoresSi.PerformLayout();
            this.valoresGa.ResumeLayout(false);
            this.valoresGa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox triangular;
        private System.Windows.Forms.CheckBox trapezoidal;
        private System.Windows.Forms.CheckBox gaussiana;
        private System.Windows.Forms.CheckBox bell;
        private System.Windows.Forms.CheckBox sigmoide;
        private System.Windows.Forms.TextBox TriA;
        private System.Windows.Forms.TextBox TriB;
        private System.Windows.Forms.TextBox TriC;
        private System.Windows.Forms.TextBox TraA;
        private System.Windows.Forms.TextBox TraB;
        private System.Windows.Forms.TextBox TraC;
        private System.Windows.Forms.TextBox TraD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TriInferior;
        private System.Windows.Forms.TextBox TriSuperior;
        private System.Windows.Forms.TextBox TraInferio;
        private System.Windows.Forms.TextBox TraSuperior;
        private System.Windows.Forms.TextBox GaInferior;
        private System.Windows.Forms.TextBox GaSuperior;
        private System.Windows.Forms.TextBox BeInferior;
        private System.Windows.Forms.TextBox BeSuperior;
        private System.Windows.Forms.TextBox SigInferior;
        private System.Windows.Forms.TextBox SigSuperior;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox GaB;
        private System.Windows.Forms.TextBox GaA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox BeC;
        private System.Windows.Forms.TextBox BeB;
        private System.Windows.Forms.TextBox BeA;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox SigB;
        private System.Windows.Forms.TextBox SigA;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox valoresTri;
        private System.Windows.Forms.GroupBox valoresTra;
        private System.Windows.Forms.GroupBox valoresBe;
        private System.Windows.Forms.GroupBox valoresSi;
        private System.Windows.Forms.GroupBox valoresGa;
        private System.Windows.Forms.Button graficar;
    }
}

