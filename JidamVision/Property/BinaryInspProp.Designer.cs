namespace JidamVision.Property
{
    partial class BinaryInspProp
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
                if (trackBarLower != null)
                    trackBarLower.ValueChanged -= OnValueChanged;

                if (trackBarUpper != null)
                    trackBarUpper.ValueChanged -= OnValueChanged;

                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBinary = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkInvert = new System.Windows.Forms.CheckBox();
            this.chkShowBinary = new System.Windows.Forms.CheckBox();
            this.chkHighlight = new System.Windows.Forms.CheckBox();
            this.trackBarUpper = new System.Windows.Forms.TrackBar();
            this.trackBarLower = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar_heightMax = new System.Windows.Forms.TrackBar();
            this.trackBar_heightMin = new System.Windows.Forms.TrackBar();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.trackBar_widthMax = new System.Windows.Forms.TrackBar();
            this.trackBar_widthMin = new System.Windows.Forms.TrackBar();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.trackBar_areaMax = new System.Windows.Forms.TrackBar();
            this.trackBar_areaMin = new System.Windows.Forms.TrackBar();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.grpBinary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_heightMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_heightMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_widthMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_widthMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_areaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_areaMin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBinary
            // 
            this.grpBinary.Controls.Add(this.button2);
            this.grpBinary.Controls.Add(this.chkInvert);
            this.grpBinary.Controls.Add(this.chkShowBinary);
            this.grpBinary.Controls.Add(this.chkHighlight);
            this.grpBinary.Controls.Add(this.trackBarUpper);
            this.grpBinary.Controls.Add(this.trackBarLower);
            this.grpBinary.Location = new System.Drawing.Point(4, 4);
            this.grpBinary.Margin = new System.Windows.Forms.Padding(4);
            this.grpBinary.Name = "grpBinary";
            this.grpBinary.Padding = new System.Windows.Forms.Padding(4);
            this.grpBinary.Size = new System.Drawing.Size(330, 210);
            this.grpBinary.TabIndex = 0;
            this.grpBinary.TabStop = false;
            this.grpBinary.Text = "이진화";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkInvert
            // 
            this.chkInvert.AutoSize = true;
            this.chkInvert.Location = new System.Drawing.Point(43, 183);
            this.chkInvert.Margin = new System.Windows.Forms.Padding(4);
            this.chkInvert.Name = "chkInvert";
            this.chkInvert.Size = new System.Drawing.Size(70, 22);
            this.chkInvert.TabIndex = 5;
            this.chkInvert.Text = "반전";
            this.chkInvert.UseVisualStyleBackColor = true;
            this.chkInvert.CheckedChanged += new System.EventHandler(this.chkInvert_CheckedChanged);
            // 
            // chkShowBinary
            // 
            this.chkShowBinary.AutoSize = true;
            this.chkShowBinary.Location = new System.Drawing.Point(167, 153);
            this.chkShowBinary.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowBinary.Name = "chkShowBinary";
            this.chkShowBinary.Size = new System.Drawing.Size(88, 22);
            this.chkShowBinary.TabIndex = 4;
            this.chkShowBinary.Text = "이진화";
            this.chkShowBinary.UseVisualStyleBackColor = true;
            this.chkShowBinary.CheckedChanged += new System.EventHandler(this.chkShowBinary_CheckedChanged);
            // 
            // chkHighlight
            // 
            this.chkHighlight.AutoSize = true;
            this.chkHighlight.Checked = true;
            this.chkHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHighlight.Location = new System.Drawing.Point(44, 153);
            this.chkHighlight.Margin = new System.Windows.Forms.Padding(4);
            this.chkHighlight.Name = "chkHighlight";
            this.chkHighlight.Size = new System.Drawing.Size(99, 22);
            this.chkHighlight.TabIndex = 3;
            this.chkHighlight.Text = "Highlight";
            this.chkHighlight.UseVisualStyleBackColor = true;
            this.chkHighlight.CheckedChanged += new System.EventHandler(this.chkHighlight_CheckedChanged);
            // 
            // trackBarUpper
            // 
            this.trackBarUpper.Location = new System.Drawing.Point(60, 106);
            this.trackBarUpper.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarUpper.Maximum = 255;
            this.trackBarUpper.Name = "trackBarUpper";
            this.trackBarUpper.Size = new System.Drawing.Size(214, 69);
            this.trackBarUpper.TabIndex = 1;
            this.trackBarUpper.Value = 255;
            // 
            // trackBarLower
            // 
            this.trackBarLower.Location = new System.Drawing.Point(60, 29);
            this.trackBarLower.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLower.Maximum = 255;
            this.trackBarLower.Name = "trackBarLower";
            this.trackBarLower.Size = new System.Drawing.Size(214, 69);
            this.trackBarLower.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar_heightMax);
            this.groupBox1.Controls.Add(this.trackBar_heightMin);
            this.groupBox1.Controls.Add(this.lbl_Height);
            this.groupBox1.Controls.Add(this.trackBar_widthMax);
            this.groupBox1.Controls.Add(this.trackBar_widthMin);
            this.groupBox1.Controls.Add(this.lbl_Width);
            this.groupBox1.Controls.Add(this.trackBar_areaMax);
            this.groupBox1.Controls.Add(this.trackBar_areaMin);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.lbl_Area);
            this.groupBox1.Location = new System.Drawing.Point(14, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 331);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "필터";
            // 
            // trackBar_heightMax
            // 
            this.trackBar_heightMax.Location = new System.Drawing.Point(113, 254);
            this.trackBar_heightMax.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_heightMax.Maximum = 255;
            this.trackBar_heightMax.Name = "trackBar_heightMax";
            this.trackBar_heightMax.Size = new System.Drawing.Size(188, 69);
            this.trackBar_heightMax.TabIndex = 14;
            this.trackBar_heightMax.Value = 255;
            // 
            // trackBar_heightMin
            // 
            this.trackBar_heightMin.Location = new System.Drawing.Point(115, 208);
            this.trackBar_heightMin.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_heightMin.Maximum = 255;
            this.trackBar_heightMin.Name = "trackBar_heightMin";
            this.trackBar_heightMin.Size = new System.Drawing.Size(188, 69);
            this.trackBar_heightMin.TabIndex = 13;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(30, 229);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(57, 18);
            this.lbl_Height.TabIndex = 12;
            this.lbl_Height.Text = "Height";
            // 
            // trackBar_widthMax
            // 
            this.trackBar_widthMax.Location = new System.Drawing.Point(6, 144);
            this.trackBar_widthMax.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_widthMax.Maximum = 255;
            this.trackBar_widthMax.Name = "trackBar_widthMax";
            this.trackBar_widthMax.Size = new System.Drawing.Size(188, 69);
            this.trackBar_widthMax.TabIndex = 11;
            this.trackBar_widthMax.Value = 255;
            // 
            // trackBar_widthMin
            // 
            this.trackBar_widthMin.Location = new System.Drawing.Point(6, 107);
            this.trackBar_widthMin.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_widthMin.Maximum = 255;
            this.trackBar_widthMin.Name = "trackBar_widthMin";
            this.trackBar_widthMin.Size = new System.Drawing.Size(188, 69);
            this.trackBar_widthMin.TabIndex = 10;
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(229, 134);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(51, 18);
            this.lbl_Width.TabIndex = 9;
            this.lbl_Width.Text = "Width";
            // 
            // trackBar_areaMax
            // 
            this.trackBar_areaMax.Location = new System.Drawing.Point(98, 51);
            this.trackBar_areaMax.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_areaMax.Maximum = 255;
            this.trackBar_areaMax.Name = "trackBar_areaMax";
            this.trackBar_areaMax.Size = new System.Drawing.Size(188, 69);
            this.trackBar_areaMax.TabIndex = 8;
            this.trackBar_areaMax.Value = 255;
            // 
            // trackBar_areaMin
            // 
            this.trackBar_areaMin.Location = new System.Drawing.Point(98, 6);
            this.trackBar_areaMin.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_areaMin.Maximum = 255;
            this.trackBar_areaMin.Name = "trackBar_areaMin";
            this.trackBar_areaMin.Size = new System.Drawing.Size(188, 69);
            this.trackBar_areaMin.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(10, 276);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(98, 47);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "필터적용";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(18, 51);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(46, 18);
            this.lbl_Area.TabIndex = 0;
            this.lbl_Area.Text = "Area";
            // 
            // BinaryInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBinary);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BinaryInspProp";
            this.Size = new System.Drawing.Size(338, 569);
            this.grpBinary.ResumeLayout(false);
            this.grpBinary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_heightMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_heightMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_widthMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_widthMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_areaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_areaMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBinary;
        private System.Windows.Forms.TrackBar trackBarUpper;
        private System.Windows.Forms.TrackBar trackBarLower;
        private System.Windows.Forms.CheckBox chkHighlight;
        private System.Windows.Forms.CheckBox chkInvert;
        private System.Windows.Forms.CheckBox chkShowBinary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.TrackBar trackBar_heightMax;
        private System.Windows.Forms.TrackBar trackBar_heightMin;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TrackBar trackBar_widthMax;
        private System.Windows.Forms.TrackBar trackBar_widthMin;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TrackBar trackBar_areaMax;
        private System.Windows.Forms.TrackBar trackBar_areaMin;
    }
}
