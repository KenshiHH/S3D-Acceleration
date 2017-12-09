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
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_OuterPerimeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_InnerPerimeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Skirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_SolidLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Infill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_GapFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Support)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_DenseSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // label_OuterPerimeter
            // 
            this.label_OuterPerimeter.AutoSize = true;
            this.label_OuterPerimeter.Location = new System.Drawing.Point(146, 81);
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
            this.button_Modify.Location = new System.Drawing.Point(12, 331);
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
            this.label_InnerPerimter.Location = new System.Drawing.Point(146, 120);
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
            this.acceleration_OuterPerimeter.Location = new System.Drawing.Point(149, 97);
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
            2000,
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
            this.acceleration_InnerPerimeter.Location = new System.Drawing.Point(149, 136);
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
            this.label_skirt.Location = new System.Drawing.Point(146, 41);
            this.label_skirt.Name = "label_skirt";
            this.label_skirt.Size = new System.Drawing.Size(26, 13);
            this.label_skirt.TabIndex = 7;
            this.label_skirt.Text = "skirt";
            // 
            // label_GapFill
            // 
            this.label_GapFill.AutoSize = true;
            this.label_GapFill.Location = new System.Drawing.Point(146, 237);
            this.label_GapFill.Name = "label_GapFill";
            this.label_GapFill.Size = new System.Drawing.Size(37, 13);
            this.label_GapFill.TabIndex = 8;
            this.label_GapFill.Text = "gap fill";
            // 
            // label_SolidLayer
            // 
            this.label_SolidLayer.AutoSize = true;
            this.label_SolidLayer.Location = new System.Drawing.Point(146, 159);
            this.label_SolidLayer.Name = "label_SolidLayer";
            this.label_SolidLayer.Size = new System.Drawing.Size(53, 13);
            this.label_SolidLayer.TabIndex = 9;
            this.label_SolidLayer.Text = "solid layer";
            // 
            // label_Support
            // 
            this.label_Support.AutoSize = true;
            this.label_Support.Location = new System.Drawing.Point(146, 276);
            this.label_Support.Name = "label_Support";
            this.label_Support.Size = new System.Drawing.Size(42, 13);
            this.label_Support.TabIndex = 10;
            this.label_Support.Text = "support";
            // 
            // label_DenseSupport
            // 
            this.label_DenseSupport.AutoSize = true;
            this.label_DenseSupport.Location = new System.Drawing.Point(146, 315);
            this.label_DenseSupport.Name = "label_DenseSupport";
            this.label_DenseSupport.Size = new System.Drawing.Size(74, 13);
            this.label_DenseSupport.TabIndex = 11;
            this.label_DenseSupport.Text = "dense support";
            // 
            // label_Infill
            // 
            this.label_Infill.AutoSize = true;
            this.label_Infill.Location = new System.Drawing.Point(146, 198);
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
            this.acceleration_Skirt.Location = new System.Drawing.Point(149, 58);
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
            2000,
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
            this.acceleration_SolidLayer.Location = new System.Drawing.Point(149, 175);
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
            2000,
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
            this.acceleration_Infill.Location = new System.Drawing.Point(149, 214);
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
            this.acceleration_GapFill.Location = new System.Drawing.Point(149, 253);
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
            this.acceleration_Support.Location = new System.Drawing.Point(149, 292);
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
            2000,
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
            this.acceleration_DenseSupport.Location = new System.Drawing.Point(149, 331);
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
            2000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 368);
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
            this.Text = "S3D Gcode";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_OuterPerimeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_InnerPerimeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Skirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_SolidLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Infill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_GapFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_Support)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceleration_DenseSupport)).EndInit();
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
    }
}

