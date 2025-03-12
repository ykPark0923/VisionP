using WeifenLuo.WinFormsUI.Docking;

namespace JidamVision
{
    partial class PropertiesForm : DockContent
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(19, 33);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(443, 470);
            this.panelContainer.TabIndex = 0;
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 585);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PropertiesForm";
            this.Text = "PropertiesForm";
            this.Resize += new System.EventHandler(this.PropertiesForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
    }
}