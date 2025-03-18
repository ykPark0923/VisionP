namespace JidamVision.Setting
{
    partial class CameraSetting
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
            this.lbCameraType = new System.Windows.Forms.Label();
            this.cbCameraType = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lbl_exposureTime = new System.Windows.Forms.Label();
            this.lbl_gain = new System.Windows.Forms.Label();
            this.tbx_exposureTime = new System.Windows.Forms.TextBox();
            this.tbx_gain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCameraType
            // 
            this.lbCameraType.AutoSize = true;
            this.lbCameraType.Location = new System.Drawing.Point(53, 90);
            this.lbCameraType.Name = "lbCameraType";
            this.lbCameraType.Size = new System.Drawing.Size(104, 18);
            this.lbCameraType.TabIndex = 0;
            this.lbCameraType.Text = "카메라 종류";
            // 
            // cbCameraType
            // 
            this.cbCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCameraType.FormattingEnabled = true;
            this.cbCameraType.Location = new System.Drawing.Point(173, 82);
            this.cbCameraType.Name = "cbCameraType";
            this.cbCameraType.Size = new System.Drawing.Size(184, 26);
            this.cbCameraType.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(267, 260);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 42);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "적용";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // lbl_exposureTime
            // 
            this.lbl_exposureTime.AutoSize = true;
            this.lbl_exposureTime.Location = new System.Drawing.Point(53, 151);
            this.lbl_exposureTime.Name = "lbl_exposureTime";
            this.lbl_exposureTime.Size = new System.Drawing.Size(124, 18);
            this.lbl_exposureTime.TabIndex = 3;
            this.lbl_exposureTime.Text = "ExposureTime";
            // 
            // lbl_gain
            // 
            this.lbl_gain.AutoSize = true;
            this.lbl_gain.Location = new System.Drawing.Point(53, 186);
            this.lbl_gain.Name = "lbl_gain";
            this.lbl_gain.Size = new System.Drawing.Size(43, 18);
            this.lbl_gain.TabIndex = 4;
            this.lbl_gain.Text = "Gain";
            // 
            // tbx_exposureTime
            // 
            this.tbx_exposureTime.Location = new System.Drawing.Point(215, 151);
            this.tbx_exposureTime.Name = "tbx_exposureTime";
            this.tbx_exposureTime.Size = new System.Drawing.Size(100, 28);
            this.tbx_exposureTime.TabIndex = 5;
            // 
            // tbx_gain
            // 
            this.tbx_gain.Location = new System.Drawing.Point(215, 186);
            this.tbx_gain.Name = "tbx_gain";
            this.tbx_gain.Size = new System.Drawing.Size(100, 28);
            this.tbx_gain.TabIndex = 6;
            // 
            // CameraSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbx_gain);
            this.Controls.Add(this.tbx_exposureTime);
            this.Controls.Add(this.lbl_gain);
            this.Controls.Add(this.lbl_exposureTime);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbCameraType);
            this.Controls.Add(this.lbCameraType);
            this.Name = "CameraSetting";
            this.Size = new System.Drawing.Size(524, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCameraType;
        private System.Windows.Forms.ComboBox cbCameraType;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lbl_exposureTime;
        private System.Windows.Forms.Label lbl_gain;
        private System.Windows.Forms.TextBox tbx_exposureTime;
        private System.Windows.Forms.TextBox tbx_gain;
    }
}
