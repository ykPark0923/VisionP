namespace JidamVision.Property
{
    partial class SetCamParamInspProp
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
            this.grpCamParam = new System.Windows.Forms.GroupBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.lb_gain = new System.Windows.Forms.Label();
            this.txt_gain = new System.Windows.Forms.TextBox();
            this.txt_exposureTime = new System.Windows.Forms.TextBox();
            this.lb_exposureTime = new System.Windows.Forms.Label();
            this.grpCamParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCamParam
            // 
            this.grpCamParam.Controls.Add(this.btn_apply);
            this.grpCamParam.Controls.Add(this.lb_gain);
            this.grpCamParam.Controls.Add(this.txt_gain);
            this.grpCamParam.Controls.Add(this.txt_exposureTime);
            this.grpCamParam.Controls.Add(this.lb_exposureTime);
            this.grpCamParam.Location = new System.Drawing.Point(13, 14);
            this.grpCamParam.Name = "grpCamParam";
            this.grpCamParam.Size = new System.Drawing.Size(280, 252);
            this.grpCamParam.TabIndex = 1;
            this.grpCamParam.TabStop = false;
            this.grpCamParam.Text = "밝기조절";
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(84, 121);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(124, 29);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "적용";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lb_gain
            // 
            this.lb_gain.AutoSize = true;
            this.lb_gain.Location = new System.Drawing.Point(29, 85);
            this.lb_gain.Name = "lb_gain";
            this.lb_gain.Size = new System.Drawing.Size(31, 12);
            this.lb_gain.TabIndex = 2;
            this.lb_gain.Text = "Gain";
            // 
            // txt_gain
            // 
            this.txt_gain.Location = new System.Drawing.Point(123, 82);
            this.txt_gain.Name = "txt_gain";
            this.txt_gain.Size = new System.Drawing.Size(126, 21);
            this.txt_gain.TabIndex = 1;
            this.txt_gain.Text = "0";
            this.txt_gain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_exposureTime
            // 
            this.txt_exposureTime.Location = new System.Drawing.Point(123, 44);
            this.txt_exposureTime.Name = "txt_exposureTime";
            this.txt_exposureTime.Size = new System.Drawing.Size(126, 21);
            this.txt_exposureTime.TabIndex = 1;
            this.txt_exposureTime.Text = "0";
            this.txt_exposureTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_exposureTime
            // 
            this.lb_exposureTime.AutoSize = true;
            this.lb_exposureTime.Location = new System.Drawing.Point(18, 53);
            this.lb_exposureTime.Name = "lb_exposureTime";
            this.lb_exposureTime.Size = new System.Drawing.Size(88, 12);
            this.lb_exposureTime.TabIndex = 0;
            this.lb_exposureTime.Text = "ExposureTime";
            // 
            // SetCamParamInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCamParam);
            this.Name = "SetCamParamInspProp";
            this.Size = new System.Drawing.Size(306, 281);
            this.grpCamParam.ResumeLayout(false);
            this.grpCamParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCamParam;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lb_gain;
        private System.Windows.Forms.TextBox txt_gain;
        private System.Windows.Forms.TextBox txt_exposureTime;
        private System.Windows.Forms.Label lb_exposureTime;
    }
}
