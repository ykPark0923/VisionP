namespace JidamVision.Setting
{
    partial class NetworkSetting
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIPAdress = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbCommType = new System.Windows.Forms.ComboBox();
            this.lbCommType = new System.Windows.Forms.Label();
            this.maskedtbx_ip = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblIPAdress
            // 
            this.lblIPAdress.AutoSize = true;
            this.lblIPAdress.Location = new System.Drawing.Point(43, 94);
            this.lblIPAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPAdress.Name = "lblIPAdress";
            this.lblIPAdress.Size = new System.Drawing.Size(67, 12);
            this.lblIPAdress.TabIndex = 11;
            this.lblIPAdress.Text = "IP Address";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(141, 147);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(52, 28);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbCommType
            // 
            this.cbCommType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommType.FormattingEnabled = true;
            this.cbCommType.Location = new System.Drawing.Point(141, 61);
            this.cbCommType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCommType.Name = "cbCommType";
            this.cbCommType.Size = new System.Drawing.Size(130, 20);
            this.cbCommType.TabIndex = 8;
            // 
            // lbCommType
            // 
            this.lbCommType.AutoSize = true;
            this.lbCommType.Location = new System.Drawing.Point(12, 66);
            this.lbCommType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCommType.Name = "lbCommType";
            this.lbCommType.Size = new System.Drawing.Size(127, 12);
            this.lbCommType.TabIndex = 7;
            this.lbCommType.Text = "Communication Type";
            // 
            // maskedtbx_ip
            // 
            this.maskedtbx_ip.Location = new System.Drawing.Point(141, 94);
            this.maskedtbx_ip.Mask = "000.000.000.000";
            this.maskedtbx_ip.Name = "maskedtbx_ip";
            this.maskedtbx_ip.Size = new System.Drawing.Size(130, 21);
            this.maskedtbx_ip.TabIndex = 14;
            this.maskedtbx_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtbx_ip.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // NetworkSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedtbx_ip);
            this.Controls.Add(this.lblIPAdress);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbCommType);
            this.Controls.Add(this.lbCommType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NetworkSetting";
            this.Size = new System.Drawing.Size(309, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIPAdress;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cbCommType;
        private System.Windows.Forms.Label lbCommType;
        private System.Windows.Forms.MaskedTextBox maskedtbx_ip;
    }
}
