﻿namespace JidamVision.Setting
{
    partial class SetupForm
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
            this.tabSetting = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabSetting.Location = new System.Drawing.Point(12, 12);
            this.tabSetting.Name = "tabControl1";
            this.tabSetting.SelectedIndex = 0;
            this.tabSetting.Size = new System.Drawing.Size(776, 642);
            this.tabSetting.TabIndex = 0;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.tabSetting);
            this.Name = "SetupForm";
            this.Text = "SetupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSetting;
    }
}