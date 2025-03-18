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
            this.tbx_gain = new System.Windows.Forms.TextBox();
            this.lblIPAdress = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.cbCommType = new System.Windows.Forms.ComboBox();
            this.lbCommType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_gain
            // 
            this.tbx_gain.Location = new System.Drawing.Point(202, 141);
            this.tbx_gain.Name = "tbx_gain";
            this.tbx_gain.Size = new System.Drawing.Size(184, 28);
            this.tbx_gain.TabIndex = 13;
            // 
            // lblIPAdress
            // 
            this.lblIPAdress.AutoSize = true;
            this.lblIPAdress.Location = new System.Drawing.Point(62, 141);
            this.lblIPAdress.Name = "lblIPAdress";
            this.lblIPAdress.Size = new System.Drawing.Size(96, 18);
            this.lblIPAdress.TabIndex = 11;
            this.lblIPAdress.Text = "IP Address";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(202, 213);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 42);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbCommType
            // 
            this.cbCommType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommType.FormattingEnabled = true;
            this.cbCommType.Location = new System.Drawing.Point(202, 91);
            this.cbCommType.Name = "cbCommType";
            this.cbCommType.Size = new System.Drawing.Size(184, 26);
            this.cbCommType.TabIndex = 8;
            // 
            // lbCommType
            // 
            this.lbCommType.AutoSize = true;
            this.lbCommType.Location = new System.Drawing.Point(17, 99);
            this.lbCommType.Name = "lbCommType";
            this.lbCommType.Size = new System.Drawing.Size(179, 18);
            this.lbCommType.TabIndex = 7;
            this.lbCommType.Text = "Communication Type";
            // 
            // NetworkSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbx_gain);
            this.Controls.Add(this.lblIPAdress);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbCommType);
            this.Controls.Add(this.lbCommType);
            this.Name = "NetworkSetting";
            this.Size = new System.Drawing.Size(441, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_gain;
        private System.Windows.Forms.Label lblIPAdress;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cbCommType;
        private System.Windows.Forms.Label lbCommType;
    }
}
