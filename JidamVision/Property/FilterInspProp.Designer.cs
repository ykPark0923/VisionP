namespace JidamVision.Property
{
    partial class FilterInspProp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.select_effect2 = new System.Windows.Forms.ComboBox();
            this.select_effect = new System.Windows.Forms.ComboBox();
            this.apply = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.select_effect2);
            this.groupBox1.Controls.Add(this.select_effect);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(223, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "속성";
            // 
            // select_effect2
            // 
            this.select_effect2.FormattingEnabled = true;
            this.select_effect2.Location = new System.Drawing.Point(12, 63);
            this.select_effect2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.select_effect2.Name = "select_effect2";
            this.select_effect2.Size = new System.Drawing.Size(175, 20);
            this.select_effect2.TabIndex = 1;
            this.select_effect2.SelectedIndexChanged += new System.EventHandler(this.select_effect2_SelectedIndexChanged);
            // 
            // select_effect
            // 
            this.select_effect.FormattingEnabled = true;
            this.select_effect.Items.AddRange(new object[] {
            "연산",
            "비트연산(Bitwise)",
            "블러링",
            "Edge"});
            this.select_effect.Location = new System.Drawing.Point(12, 29);
            this.select_effect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.select_effect.Name = "select_effect";
            this.select_effect.Size = new System.Drawing.Size(175, 20);
            this.select_effect.TabIndex = 0;
            this.select_effect.Text = "적용할 효과를 선택하세요.";
            this.select_effect.SelectedIndexChanged += new System.EventHandler(this.select_effect_SelectedIndexChanged_1);
            // 
            // apply
            // 
            this.apply.ForeColor = System.Drawing.SystemColors.Highlight;
            this.apply.Location = new System.Drawing.Point(20, 145);
            this.apply.Margin = new System.Windows.Forms.Padding(2);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(66, 25);
            this.apply.TabIndex = 7;
            this.apply.Text = "적용";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // FilterInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.apply);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FilterInspProp";
            this.Size = new System.Drawing.Size(300, 277);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox select_effect2;
        private System.Windows.Forms.ComboBox select_effect;
        private System.Windows.Forms.Button apply;
    }
}
