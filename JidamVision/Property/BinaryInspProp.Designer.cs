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
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grpBinary.Margin = new System.Windows.Forms.Padding(4);
            this.grpBinary.Name = "grpBinary";
            this.grpBinary.Padding = new System.Windows.Forms.Padding(4);
            this.grpBinary.Size = new System.Drawing.Size(282, 259);
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
            this.chkInvert.Location = new System.Drawing.Point(33, 229);
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
            this.chkShowBinary.Location = new System.Drawing.Point(148, 188);
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
            this.chkHighlight.Location = new System.Drawing.Point(33, 188);
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
            this.trackBarUpper.Location = new System.Drawing.Point(33, 111);
            this.trackBarUpper.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarUpper.Maximum = 255;
            this.trackBarUpper.Name = "trackBarUpper";
            this.trackBarUpper.Size = new System.Drawing.Size(214, 69);
            this.trackBarUpper.TabIndex = 1;
            this.trackBarUpper.Value = 255;
            // 
            // trackBarLower
            // 
            this.trackBarLower.Location = new System.Drawing.Point(33, 34);
            this.trackBarLower.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarLower.Maximum = 255;
            this.trackBarLower.Name = "trackBarLower";
            this.trackBarLower.Size = new System.Drawing.Size(214, 69);
            this.trackBarLower.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(282, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "필터";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(85, 149);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(146, 59);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "필터적용";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(120, 29);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 28);
            this.txtArea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
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
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
    }
}
