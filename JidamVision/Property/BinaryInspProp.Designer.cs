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
            this.textBox_widthMax = new System.Windows.Forms.TextBox();
            this.textBox_widthMin = new System.Windows.Forms.TextBox();
            this.textBox_heightMax = new System.Windows.Forms.TextBox();
            this.textBox_heightMin = new System.Windows.Forms.TextBox();
            this.textBox_areaMax = new System.Windows.Forms.TextBox();
            this.textBox_areaMin = new System.Windows.Forms.TextBox();
            this.checkBox_height = new System.Windows.Forms.CheckBox();
            this.checkBox_width = new System.Windows.Forms.CheckBox();
            this.checkBox_area = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grpBinary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.grpBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBinary.Name = "grpBinary";
            this.grpBinary.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBinary.Size = new System.Drawing.Size(330, 210);
            this.grpBinary.TabIndex = 0;
            this.grpBinary.TabStop = false;
            this.grpBinary.Text = "이진화";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 8);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkInvert
            // 
            this.chkInvert.AutoSize = true;
            this.chkInvert.Location = new System.Drawing.Point(43, 183);
            this.chkInvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.chkShowBinary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.chkHighlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.trackBarUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarUpper.Maximum = 255;
            this.trackBarUpper.Name = "trackBarUpper";
            this.trackBarUpper.Size = new System.Drawing.Size(214, 69);
            this.trackBarUpper.TabIndex = 1;
            this.trackBarUpper.Value = 255;
            // 
            // trackBarLower
            // 
            this.trackBarLower.Location = new System.Drawing.Point(60, 28);
            this.trackBarLower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarLower.Maximum = 255;
            this.trackBarLower.Name = "trackBarLower";
            this.trackBarLower.Size = new System.Drawing.Size(214, 69);
            this.trackBarLower.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_widthMax);
            this.groupBox1.Controls.Add(this.textBox_widthMin);
            this.groupBox1.Controls.Add(this.textBox_heightMax);
            this.groupBox1.Controls.Add(this.textBox_heightMin);
            this.groupBox1.Controls.Add(this.textBox_areaMax);
            this.groupBox1.Controls.Add(this.textBox_areaMin);
            this.groupBox1.Controls.Add(this.checkBox_height);
            this.groupBox1.Controls.Add(this.checkBox_width);
            this.groupBox1.Controls.Add(this.checkBox_area);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Location = new System.Drawing.Point(14, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(287, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "필터";
            // 
            // textBox_widthMax
            // 
            this.textBox_widthMax.Location = new System.Drawing.Point(121, 152);
            this.textBox_widthMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_widthMax.Name = "textBox_widthMax";
            this.textBox_widthMax.Size = new System.Drawing.Size(141, 28);
            this.textBox_widthMax.TabIndex = 21;
            // 
            // textBox_widthMin
            // 
            this.textBox_widthMin.Location = new System.Drawing.Point(121, 111);
            this.textBox_widthMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_widthMin.Name = "textBox_widthMin";
            this.textBox_widthMin.Size = new System.Drawing.Size(141, 28);
            this.textBox_widthMin.TabIndex = 20;
            // 
            // textBox_heightMax
            // 
            this.textBox_heightMax.Location = new System.Drawing.Point(121, 228);
            this.textBox_heightMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_heightMax.Name = "textBox_heightMax";
            this.textBox_heightMax.Size = new System.Drawing.Size(141, 28);
            this.textBox_heightMax.TabIndex = 19;
            // 
            // textBox_heightMin
            // 
            this.textBox_heightMin.Location = new System.Drawing.Point(121, 188);
            this.textBox_heightMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_heightMin.Name = "textBox_heightMin";
            this.textBox_heightMin.Size = new System.Drawing.Size(141, 28);
            this.textBox_heightMin.TabIndex = 18;
            // 
            // textBox_areaMax
            // 
            this.textBox_areaMax.Location = new System.Drawing.Point(121, 70);
            this.textBox_areaMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_areaMax.Name = "textBox_areaMax";
            this.textBox_areaMax.Size = new System.Drawing.Size(141, 28);
            this.textBox_areaMax.TabIndex = 17;
            // 
            // textBox_areaMin
            // 
            this.textBox_areaMin.Location = new System.Drawing.Point(121, 30);
            this.textBox_areaMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_areaMin.Name = "textBox_areaMin";
            this.textBox_areaMin.Size = new System.Drawing.Size(141, 28);
            this.textBox_areaMin.TabIndex = 16;
            // 
            // checkBox_height
            // 
            this.checkBox_height.AutoSize = true;
            this.checkBox_height.Location = new System.Drawing.Point(14, 195);
            this.checkBox_height.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_height.Name = "checkBox_height";
            this.checkBox_height.Size = new System.Drawing.Size(83, 22);
            this.checkBox_height.TabIndex = 15;
            this.checkBox_height.Text = "Height";
            this.checkBox_height.UseVisualStyleBackColor = true;
            this.checkBox_height.CheckedChanged += new System.EventHandler(this.checkBox_height_CheckedChanged);
            // 
            // checkBox_width
            // 
            this.checkBox_width.AutoSize = true;
            this.checkBox_width.Location = new System.Drawing.Point(14, 118);
            this.checkBox_width.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_width.Name = "checkBox_width";
            this.checkBox_width.Size = new System.Drawing.Size(77, 22);
            this.checkBox_width.TabIndex = 14;
            this.checkBox_width.Text = "Width";
            this.checkBox_width.UseVisualStyleBackColor = true;
            this.checkBox_width.CheckedChanged += new System.EventHandler(this.checkBox_width_CheckedChanged);
            // 
            // checkBox_area
            // 
            this.checkBox_area.AutoSize = true;
            this.checkBox_area.Location = new System.Drawing.Point(14, 48);
            this.checkBox_area.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_area.Name = "checkBox_area";
            this.checkBox_area.Size = new System.Drawing.Size(72, 22);
            this.checkBox_area.TabIndex = 13;
            this.checkBox_area.Text = "Area";
            this.checkBox_area.UseVisualStyleBackColor = true;
            this.checkBox_area.CheckedChanged += new System.EventHandler(this.checkBox_area_CheckedChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(14, 252);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(99, 46);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "필터적용";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // BinaryInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBinary);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BinaryInspProp";
            this.Size = new System.Drawing.Size(339, 568);
            this.grpBinary.ResumeLayout(false);
            this.grpBinary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_widthMax;
        private System.Windows.Forms.TextBox textBox_widthMin;
        private System.Windows.Forms.TextBox textBox_heightMax;
        private System.Windows.Forms.TextBox textBox_heightMin;
        private System.Windows.Forms.TextBox textBox_areaMax;
        private System.Windows.Forms.TextBox textBox_areaMin;
        private System.Windows.Forms.CheckBox checkBox_height;
        private System.Windows.Forms.CheckBox checkBox_width;
        private System.Windows.Forms.CheckBox checkBox_area;
    }
}
