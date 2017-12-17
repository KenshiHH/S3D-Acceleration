namespace GCode_Edit
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
            this.label_OuterPerimeter = new System.Windows.Forms.Label();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.button_Modify = new System.Windows.Forms.Button();
            this.label_InnerPerimter = new System.Windows.Forms.Label();
            this.acceleration_OuterPerimeter = new System.Windows.Forms.NumericUpDown();
            this.acceleration_InnerPerimeter = new System.Windows.Forms.NumericUpDown();
            this.label_skirt = new System.Windows.Forms.Label();
            this.label_GapFill = new System.Windows.Forms.Label();
            this.label_SolidLayer = new System.Windows.Forms.Label();
            this.label_Support = new System.Windows.Forms.Label();
            this.label_DenseSupport = new System.Windows.Forms.Label();
            this.label_Infill = new System.Windows.Forms.Label();
            this.acceleration_Skirt = new System.Windows.Forms.NumericUpDown();
            this.acceleration_SolidLayer = new System.Windows.Forms.NumericUpDown();
            this.acceleration_Infill = new System.Windows.Forms.NumericUpDown();
            this.acceleration_GapFill = new System.Windows.Forms.NumericUpDown();
            this.acceleration_Support = new System.Windows.Forms.NumericUpDown();
            this.acceleration_DenseSupport = new System.Windows.Forms.NumericUpDown();
            this.label_FileLabel = new System.Windows.Forms.Label();
            this.label_FileSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jerk_Skirt = new System.Windows.Forms.NumericUpDown();
            this.jerk_OuterPerimeter = new System.Windows.Forms.NumericUpDown();
            this.jerk_InnerPerimeter = new System.Windows.Forms.NumericUpDown();
            this.jerk_SolidLayer = new System.Windows.Forms.NumericUpDown();
            this.jerk_Infill = new System.Windows.Forms.NumericUpDown();
            this.jerk_GapFill = new System.Windows.Forms.NumericUpDown();
            this.jerk_Support = new System.Windows.Forms.NumericUpDown();
            this.jerk_DenseSupport = new System.Windows.Forms.NumericUpDown();
            this.checkBox_skirt = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_OuterPerimeter = new System.Windows.Forms.CheckBox();
            this.checkBox_InnerPerimeter = new System.Windows.Forms.CheckBox();
            this.checkBox_SolidLayer = new System.Windows.Forms.CheckBox();
            this.checkBox_Infill = new System.Windows.Forms.CheckBox();
            this.checkBox_GapFill = new System.Windows.Forms.CheckBox();
            this.checkBox_Support = new System.Windows.Forms.CheckBox();
            this.checkBox_DenseSupport = new System.Windows.Forms.CheckBox();
            this.checkBox_bridge = new System.Windows.Forms.CheckBox();
            this.jerk_bridge = new System.Windows.Forms.NumericUpDown();
            this.acceleration_bridge = new System.Windows.Forms.NumericUpDown();
            this.label_bridge = new System.Windows.Forms.Label();
            this.LinearAdvance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_OuterPerimeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_InnerPerimeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Skirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_SolidLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Infill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_GapFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Support)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_DenseSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_Skirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_OuterPerimeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_InnerPerimeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_SolidLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_Infill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_GapFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_Support)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_DenseSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_bridge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_bridge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // label_OuterPerimeter
            // 
            this.label_OuterPerimeter.AutoSize = true;
            this.label_OuterPerimeter.Location = new System.Drawing.Point(140, 113);
            this.label_OuterPerimeter.Name = "label_OuterPerimeter";
            this.label_OuterPerimeter.Size = new System.Drawing.Size(77, 13);
            this.label_OuterPerimeter.TabIndex = 1;
            this.label_OuterPerimeter.Text = "outer perimeter";
            this.label_OuterPerimeter.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.Location = new System.Drawing.Point(12, 41);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.button_OpenFile.TabIndex = 2;
            this.button_OpenFile.Text = "Open File";
            this.button_OpenFile.UseVisualStyleBackColor = true;
            this.button_OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Modify
            // 
            this.button_Modify.Enabled = false;
            this.button_Modify.Location = new System.Drawing.Point(6, 363);
            this.button_Modify.Name = "button_Modify";
            this.button_Modify.Size = new System.Drawing.Size(75, 23);
            this.button_Modify.TabIndex = 11;
            this.button_Modify.Text = "Modify";
            this.button_Modify.UseVisualStyleBackColor = true;
            this.button_Modify.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_InnerPerimter
            // 
            this.label_InnerPerimter.AutoSize = true;
            this.label_InnerPerimter.Location = new System.Drawing.Point(140, 152);
            this.label_InnerPerimter.Name = "label_InnerPerimter";
            this.label_InnerPerimter.Size = new System.Drawing.Size(76, 13);
            this.label_InnerPerimter.TabIndex = 4;
            this.label_InnerPerimter.Text = "inner perimeter";
            // 
            // acceleration_OuterPerimeter
            // 
            this.acceleration_OuterPerimeter.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_OuterPerimeter.InterceptArrowKeys = false;
            this.acceleration_OuterPerimeter.Location = new System.Drawing.Point(143, 129);
            this.acceleration_OuterPerimeter.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_OuterPerimeter.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_OuterPerimeter.Name = "acceleration_OuterPerimeter";
            this.acceleration_OuterPerimeter.Size = new System.Drawing.Size(120, 20);
            this.acceleration_OuterPerimeter.TabIndex = 4;
            this.acceleration_OuterPerimeter.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.acceleration_OuterPerimeter.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // acceleration_InnerPerimeter
            // 
            this.acceleration_InnerPerimeter.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_InnerPerimeter.InterceptArrowKeys = false;
            this.acceleration_InnerPerimeter.Location = new System.Drawing.Point(143, 168);
            this.acceleration_InnerPerimeter.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_InnerPerimeter.Name = "acceleration_InnerPerimeter";
            this.acceleration_InnerPerimeter.Size = new System.Drawing.Size(120, 20);
            this.acceleration_InnerPerimeter.TabIndex = 5;
            this.acceleration_InnerPerimeter.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label_skirt
            // 
            this.label_skirt.AutoSize = true;
            this.label_skirt.Location = new System.Drawing.Point(140, 73);
            this.label_skirt.Name = "label_skirt";
            this.label_skirt.Size = new System.Drawing.Size(26, 13);
            this.label_skirt.TabIndex = 7;
            this.label_skirt.Text = "skirt";
            // 
            // label_GapFill
            // 
            this.label_GapFill.AutoSize = true;
            this.label_GapFill.Location = new System.Drawing.Point(140, 269);
            this.label_GapFill.Name = "label_GapFill";
            this.label_GapFill.Size = new System.Drawing.Size(37, 13);
            this.label_GapFill.TabIndex = 8;
            this.label_GapFill.Text = "gap fill";
            // 
            // label_SolidLayer
            // 
            this.label_SolidLayer.AutoSize = true;
            this.label_SolidLayer.Location = new System.Drawing.Point(140, 191);
            this.label_SolidLayer.Name = "label_SolidLayer";
            this.label_SolidLayer.Size = new System.Drawing.Size(53, 13);
            this.label_SolidLayer.TabIndex = 9;
            this.label_SolidLayer.Text = "solid layer";
            // 
            // label_Support
            // 
            this.label_Support.AutoSize = true;
            this.label_Support.Location = new System.Drawing.Point(140, 308);
            this.label_Support.Name = "label_Support";
            this.label_Support.Size = new System.Drawing.Size(42, 13);
            this.label_Support.TabIndex = 10;
            this.label_Support.Text = "support";
            // 
            // label_DenseSupport
            // 
            this.label_DenseSupport.AutoSize = true;
            this.label_DenseSupport.Location = new System.Drawing.Point(140, 347);
            this.label_DenseSupport.Name = "label_DenseSupport";
            this.label_DenseSupport.Size = new System.Drawing.Size(74, 13);
            this.label_DenseSupport.TabIndex = 11;
            this.label_DenseSupport.Text = "dense support";
            // 
            // label_Infill
            // 
            this.label_Infill.AutoSize = true;
            this.label_Infill.Location = new System.Drawing.Point(140, 230);
            this.label_Infill.Name = "label_Infill";
            this.label_Infill.Size = new System.Drawing.Size(25, 13);
            this.label_Infill.TabIndex = 12;
            this.label_Infill.Text = "Infill";
            // 
            // acceleration_Skirt
            // 
            this.acceleration_Skirt.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_Skirt.Location = new System.Drawing.Point(143, 90);
            this.acceleration_Skirt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_Skirt.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_Skirt.Name = "acceleration_Skirt";
            this.acceleration_Skirt.Size = new System.Drawing.Size(120, 20);
            this.acceleration_Skirt.TabIndex = 3;
            this.acceleration_Skirt.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // acceleration_SolidLayer
            // 
            this.acceleration_SolidLayer.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_SolidLayer.Location = new System.Drawing.Point(143, 207);
            this.acceleration_SolidLayer.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_SolidLayer.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_SolidLayer.Name = "acceleration_SolidLayer";
            this.acceleration_SolidLayer.Size = new System.Drawing.Size(120, 20);
            this.acceleration_SolidLayer.TabIndex = 6;
            this.acceleration_SolidLayer.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // acceleration_Infill
            // 
            this.acceleration_Infill.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_Infill.Location = new System.Drawing.Point(143, 246);
            this.acceleration_Infill.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_Infill.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_Infill.Name = "acceleration_Infill";
            this.acceleration_Infill.Size = new System.Drawing.Size(120, 20);
            this.acceleration_Infill.TabIndex = 7;
            this.acceleration_Infill.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // acceleration_GapFill
            // 
            this.acceleration_GapFill.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_GapFill.Location = new System.Drawing.Point(143, 285);
            this.acceleration_GapFill.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_GapFill.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_GapFill.Name = "acceleration_GapFill";
            this.acceleration_GapFill.Size = new System.Drawing.Size(120, 20);
            this.acceleration_GapFill.TabIndex = 8;
            this.acceleration_GapFill.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // acceleration_Support
            // 
            this.acceleration_Support.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_Support.InterceptArrowKeys = false;
            this.acceleration_Support.Location = new System.Drawing.Point(143, 324);
            this.acceleration_Support.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.acceleration_Support.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_Support.Name = "acceleration_Support";
            this.acceleration_Support.Size = new System.Drawing.Size(120, 20);
            this.acceleration_Support.TabIndex = 9;
            this.acceleration_Support.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // acceleration_DenseSupport
            // 
            this.acceleration_DenseSupport.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_DenseSupport.Location = new System.Drawing.Point(143, 363);
            this.acceleration_DenseSupport.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_DenseSupport.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_DenseSupport.Name = "acceleration_DenseSupport";
            this.acceleration_DenseSupport.Size = new System.Drawing.Size(120, 20);
            this.acceleration_DenseSupport.TabIndex = 10;
            this.acceleration_DenseSupport.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label_FileLabel
            // 
            this.label_FileLabel.AutoEllipsis = true;
            this.label_FileLabel.AutoSize = true;
            this.label_FileLabel.Location = new System.Drawing.Point(9, 9);
            this.label_FileLabel.Name = "label_FileLabel";
            this.label_FileLabel.Size = new System.Drawing.Size(26, 13);
            this.label_FileLabel.TabIndex = 13;
            this.label_FileLabel.Text = "File:";
            // 
            // label_FileSource
            // 
            this.label_FileSource.AutoSize = true;
            this.label_FileSource.Location = new System.Drawing.Point(41, 9);
            this.label_FileSource.Name = "label_FileSource";
            this.label_FileSource.Size = new System.Drawing.Size(31, 13);
            this.label_FileSource.TabIndex = 14;
            this.label_FileSource.Text = "none";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Acceleration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Jerk";
            // 
            // jerk_Skirt
            // 
            this.jerk_Skirt.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_Skirt.Location = new System.Drawing.Point(286, 90);
            this.jerk_Skirt.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_Skirt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_Skirt.Name = "jerk_Skirt";
            this.jerk_Skirt.Size = new System.Drawing.Size(50, 20);
            this.jerk_Skirt.TabIndex = 17;
            this.jerk_Skirt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // jerk_OuterPerimeter
            // 
            this.jerk_OuterPerimeter.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_OuterPerimeter.Location = new System.Drawing.Point(286, 129);
            this.jerk_OuterPerimeter.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_OuterPerimeter.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_OuterPerimeter.Name = "jerk_OuterPerimeter";
            this.jerk_OuterPerimeter.Size = new System.Drawing.Size(50, 20);
            this.jerk_OuterPerimeter.TabIndex = 18;
            this.jerk_OuterPerimeter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // jerk_InnerPerimeter
            // 
            this.jerk_InnerPerimeter.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_InnerPerimeter.Location = new System.Drawing.Point(286, 168);
            this.jerk_InnerPerimeter.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_InnerPerimeter.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_InnerPerimeter.Name = "jerk_InnerPerimeter";
            this.jerk_InnerPerimeter.Size = new System.Drawing.Size(50, 20);
            this.jerk_InnerPerimeter.TabIndex = 19;
            this.jerk_InnerPerimeter.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // jerk_SolidLayer
            // 
            this.jerk_SolidLayer.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_SolidLayer.Location = new System.Drawing.Point(286, 207);
            this.jerk_SolidLayer.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_SolidLayer.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_SolidLayer.Name = "jerk_SolidLayer";
            this.jerk_SolidLayer.Size = new System.Drawing.Size(50, 20);
            this.jerk_SolidLayer.TabIndex = 20;
            this.jerk_SolidLayer.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // jerk_Infill
            // 
            this.jerk_Infill.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_Infill.Location = new System.Drawing.Point(286, 246);
            this.jerk_Infill.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_Infill.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_Infill.Name = "jerk_Infill";
            this.jerk_Infill.Size = new System.Drawing.Size(50, 20);
            this.jerk_Infill.TabIndex = 21;
            this.jerk_Infill.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // jerk_GapFill
            // 
            this.jerk_GapFill.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_GapFill.Location = new System.Drawing.Point(286, 285);
            this.jerk_GapFill.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_GapFill.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_GapFill.Name = "jerk_GapFill";
            this.jerk_GapFill.Size = new System.Drawing.Size(50, 20);
            this.jerk_GapFill.TabIndex = 22;
            this.jerk_GapFill.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // jerk_Support
            // 
            this.jerk_Support.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_Support.Location = new System.Drawing.Point(286, 324);
            this.jerk_Support.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_Support.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_Support.Name = "jerk_Support";
            this.jerk_Support.Size = new System.Drawing.Size(50, 20);
            this.jerk_Support.TabIndex = 23;
            this.jerk_Support.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // jerk_DenseSupport
            // 
            this.jerk_DenseSupport.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_DenseSupport.Location = new System.Drawing.Point(286, 363);
            this.jerk_DenseSupport.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_DenseSupport.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_DenseSupport.Name = "jerk_DenseSupport";
            this.jerk_DenseSupport.Size = new System.Drawing.Size(50, 20);
            this.jerk_DenseSupport.TabIndex = 24;
            this.jerk_DenseSupport.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // checkBox_skirt
            // 
            this.checkBox_skirt.AutoSize = true;
            this.checkBox_skirt.Location = new System.Drawing.Point(366, 92);
            this.checkBox_skirt.Name = "checkBox_skirt";
            this.checkBox_skirt.Size = new System.Drawing.Size(15, 14);
            this.checkBox_skirt.TabIndex = 25;
            this.checkBox_skirt.UseVisualStyleBackColor = true;
            this.checkBox_skirt.CheckedChanged += new System.EventHandler(this.checkBox_skirt_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "LinAdvance";
            // 
            // checkBox_OuterPerimeter
            // 
            this.checkBox_OuterPerimeter.AutoSize = true;
            this.checkBox_OuterPerimeter.Location = new System.Drawing.Point(366, 131);
            this.checkBox_OuterPerimeter.Name = "checkBox_OuterPerimeter";
            this.checkBox_OuterPerimeter.Size = new System.Drawing.Size(15, 14);
            this.checkBox_OuterPerimeter.TabIndex = 27;
            this.checkBox_OuterPerimeter.UseVisualStyleBackColor = true;
            // 
            // checkBox_InnerPerimeter
            // 
            this.checkBox_InnerPerimeter.AutoSize = true;
            this.checkBox_InnerPerimeter.Location = new System.Drawing.Point(366, 170);
            this.checkBox_InnerPerimeter.Name = "checkBox_InnerPerimeter";
            this.checkBox_InnerPerimeter.Size = new System.Drawing.Size(15, 14);
            this.checkBox_InnerPerimeter.TabIndex = 28;
            this.checkBox_InnerPerimeter.UseVisualStyleBackColor = true;
            // 
            // checkBox_SolidLayer
            // 
            this.checkBox_SolidLayer.AutoSize = true;
            this.checkBox_SolidLayer.Location = new System.Drawing.Point(366, 209);
            this.checkBox_SolidLayer.Name = "checkBox_SolidLayer";
            this.checkBox_SolidLayer.Size = new System.Drawing.Size(15, 14);
            this.checkBox_SolidLayer.TabIndex = 29;
            this.checkBox_SolidLayer.UseVisualStyleBackColor = true;
            // 
            // checkBox_Infill
            // 
            this.checkBox_Infill.AutoSize = true;
            this.checkBox_Infill.Location = new System.Drawing.Point(366, 248);
            this.checkBox_Infill.Name = "checkBox_Infill";
            this.checkBox_Infill.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Infill.TabIndex = 30;
            this.checkBox_Infill.UseVisualStyleBackColor = true;
            // 
            // checkBox_GapFill
            // 
            this.checkBox_GapFill.AutoSize = true;
            this.checkBox_GapFill.Location = new System.Drawing.Point(366, 287);
            this.checkBox_GapFill.Name = "checkBox_GapFill";
            this.checkBox_GapFill.Size = new System.Drawing.Size(15, 14);
            this.checkBox_GapFill.TabIndex = 31;
            this.checkBox_GapFill.UseVisualStyleBackColor = true;
            // 
            // checkBox_Support
            // 
            this.checkBox_Support.AutoSize = true;
            this.checkBox_Support.Location = new System.Drawing.Point(366, 326);
            this.checkBox_Support.Name = "checkBox_Support";
            this.checkBox_Support.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Support.TabIndex = 32;
            this.checkBox_Support.UseVisualStyleBackColor = true;
            // 
            // checkBox_DenseSupport
            // 
            this.checkBox_DenseSupport.AutoSize = true;
            this.checkBox_DenseSupport.Location = new System.Drawing.Point(366, 365);
            this.checkBox_DenseSupport.Name = "checkBox_DenseSupport";
            this.checkBox_DenseSupport.Size = new System.Drawing.Size(15, 14);
            this.checkBox_DenseSupport.TabIndex = 33;
            this.checkBox_DenseSupport.UseVisualStyleBackColor = true;
            // 
            // checkBox_bridge
            // 
            this.checkBox_bridge.AutoSize = true;
            this.checkBox_bridge.Location = new System.Drawing.Point(366, 404);
            this.checkBox_bridge.Name = "checkBox_bridge";
            this.checkBox_bridge.Size = new System.Drawing.Size(15, 14);
            this.checkBox_bridge.TabIndex = 37;
            this.checkBox_bridge.UseVisualStyleBackColor = true;
            // 
            // jerk_bridge
            // 
            this.jerk_bridge.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.jerk_bridge.Location = new System.Drawing.Point(286, 402);
            this.jerk_bridge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.jerk_bridge.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.jerk_bridge.Name = "jerk_bridge";
            this.jerk_bridge.Size = new System.Drawing.Size(50, 20);
            this.jerk_bridge.TabIndex = 36;
            this.jerk_bridge.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.jerk_bridge.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_2);
            // 
            // acceleration_bridge
            // 
            this.acceleration_bridge.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.acceleration_bridge.Location = new System.Drawing.Point(143, 402);
            this.acceleration_bridge.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.acceleration_bridge.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.acceleration_bridge.Name = "acceleration_bridge";
            this.acceleration_bridge.Size = new System.Drawing.Size(120, 20);
            this.acceleration_bridge.TabIndex = 34;
            this.acceleration_bridge.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label_bridge
            // 
            this.label_bridge.AutoSize = true;
            this.label_bridge.Location = new System.Drawing.Point(140, 386);
            this.label_bridge.Name = "label_bridge";
            this.label_bridge.Size = new System.Drawing.Size(36, 13);
            this.label_bridge.TabIndex = 35;
            this.label_bridge.Text = "bridge";
            // 
            // LinearAdvance
            // 
            this.LinearAdvance.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LinearAdvance.Location = new System.Drawing.Point(350, 66);
            this.LinearAdvance.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.LinearAdvance.Name = "LinearAdvance";
            this.LinearAdvance.Size = new System.Drawing.Size(50, 20);
            this.LinearAdvance.TabIndex = 38;
            this.LinearAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 438);
            this.Controls.Add(this.LinearAdvance);
            this.Controls.Add(this.checkBox_bridge);
            this.Controls.Add(this.jerk_bridge);
            this.Controls.Add(this.acceleration_bridge);
            this.Controls.Add(this.label_bridge);
            this.Controls.Add(this.checkBox_DenseSupport);
            this.Controls.Add(this.checkBox_Support);
            this.Controls.Add(this.checkBox_GapFill);
            this.Controls.Add(this.checkBox_Infill);
            this.Controls.Add(this.checkBox_SolidLayer);
            this.Controls.Add(this.checkBox_InnerPerimeter);
            this.Controls.Add(this.checkBox_OuterPerimeter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_skirt);
            this.Controls.Add(this.jerk_DenseSupport);
            this.Controls.Add(this.jerk_Support);
            this.Controls.Add(this.jerk_GapFill);
            this.Controls.Add(this.jerk_Infill);
            this.Controls.Add(this.jerk_SolidLayer);
            this.Controls.Add(this.jerk_InnerPerimeter);
            this.Controls.Add(this.jerk_OuterPerimeter);
            this.Controls.Add(this.jerk_Skirt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_FileSource);
            this.Controls.Add(this.label_FileLabel);
            this.Controls.Add(this.acceleration_DenseSupport);
            this.Controls.Add(this.acceleration_Support);
            this.Controls.Add(this.acceleration_GapFill);
            this.Controls.Add(this.acceleration_Infill);
            this.Controls.Add(this.acceleration_SolidLayer);
            this.Controls.Add(this.acceleration_Skirt);
            this.Controls.Add(this.label_Infill);
            this.Controls.Add(this.label_DenseSupport);
            this.Controls.Add(this.label_Support);
            this.Controls.Add(this.label_SolidLayer);
            this.Controls.Add(this.label_GapFill);
            this.Controls.Add(this.label_skirt);
            this.Controls.Add(this.acceleration_InnerPerimeter);
            this.Controls.Add(this.acceleration_OuterPerimeter);
            this.Controls.Add(this.label_InnerPerimter);
            this.Controls.Add(this.button_Modify);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.label_OuterPerimeter);
            this.Name = "Form1";
            this.Text = "S3D Gcode 1.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_OuterPerimeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_InnerPerimeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Skirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_SolidLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Infill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_GapFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Support)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_DenseSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_Skirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_OuterPerimeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_InnerPerimeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_SolidLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_Infill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_GapFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_Support)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_DenseSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jerk_bridge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_bridge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearAdvance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_OuterPerimeter;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Button button_Modify;
        private System.Windows.Forms.Label label_InnerPerimter;
        private System.Windows.Forms.NumericUpDown acceleration_OuterPerimeter;
        private System.Windows.Forms.NumericUpDown acceleration_InnerPerimeter;
        private System.Windows.Forms.Label label_skirt;
        private System.Windows.Forms.Label label_GapFill;
        private System.Windows.Forms.Label label_SolidLayer;
        private System.Windows.Forms.Label label_Support;
        private System.Windows.Forms.Label label_DenseSupport;
        private System.Windows.Forms.Label label_Infill;
        private System.Windows.Forms.NumericUpDown acceleration_Skirt;
        private System.Windows.Forms.NumericUpDown acceleration_SolidLayer;
        private System.Windows.Forms.NumericUpDown acceleration_Infill;
        private System.Windows.Forms.NumericUpDown acceleration_GapFill;
        private System.Windows.Forms.NumericUpDown acceleration_Support;
        private System.Windows.Forms.NumericUpDown acceleration_DenseSupport;
        private System.Windows.Forms.Label label_FileLabel;
        private System.Windows.Forms.Label label_FileSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown jerk_Skirt;
        private System.Windows.Forms.NumericUpDown jerk_OuterPerimeter;
        private System.Windows.Forms.NumericUpDown jerk_InnerPerimeter;
        private System.Windows.Forms.NumericUpDown jerk_SolidLayer;
        private System.Windows.Forms.NumericUpDown jerk_Infill;
        private System.Windows.Forms.NumericUpDown jerk_GapFill;
        private System.Windows.Forms.NumericUpDown jerk_Support;
        private System.Windows.Forms.NumericUpDown jerk_DenseSupport;
        private System.Windows.Forms.CheckBox checkBox_skirt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_OuterPerimeter;
        private System.Windows.Forms.CheckBox checkBox_InnerPerimeter;
        private System.Windows.Forms.CheckBox checkBox_SolidLayer;
        private System.Windows.Forms.CheckBox checkBox_Infill;
        private System.Windows.Forms.CheckBox checkBox_GapFill;
        private System.Windows.Forms.CheckBox checkBox_Support;
        private System.Windows.Forms.CheckBox checkBox_DenseSupport;
        private System.Windows.Forms.CheckBox checkBox_bridge;
        private System.Windows.Forms.NumericUpDown jerk_bridge;
        private System.Windows.Forms.NumericUpDown acceleration_bridge;
        private System.Windows.Forms.Label label_bridge;
        private System.Windows.Forms.NumericUpDown LinearAdvance;
    }
}

