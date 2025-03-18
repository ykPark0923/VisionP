namespace JidamVision.Property
{
    partial class FmInspProp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_diffGV = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.tbx_diffGV = new System.Windows.Forms.TextBox();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.tbx_sizeX = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.tbx_sizeY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_sizeY);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Controls.Add(this.tbx_sizeX);
            this.groupBox1.Controls.Add(this.cmb_color);
            this.groupBox1.Controls.Add(this.tbx_diffGV);
            this.groupBox1.Controls.Add(this.lbl_size);
            this.groupBox1.Controls.Add(this.lbl_color);
            this.groupBox1.Controls.Add(this.lbl_diffGV);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이물검사";
            // 
            // lbl_diffGV
            // 
            this.lbl_diffGV.AutoSize = true;
            this.lbl_diffGV.Location = new System.Drawing.Point(30, 50);
            this.lbl_diffGV.Name = "lbl_diffGV";
            this.lbl_diffGV.Size = new System.Drawing.Size(117, 18);
            this.lbl_diffGV.TabIndex = 0;
            this.lbl_diffGV.Text = "Difference GV";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(30, 113);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(51, 18);
            this.lbl_color.TabIndex = 1;
            this.lbl_color.Text = "Color";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(30, 169);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(41, 18);
            this.lbl_size.TabIndex = 2;
            this.lbl_size.Text = "Size";
            // 
            // tbx_diffGV
            // 
            this.tbx_diffGV.Location = new System.Drawing.Point(160, 50);
            this.tbx_diffGV.Name = "tbx_diffGV";
            this.tbx_diffGV.Size = new System.Drawing.Size(166, 28);
            this.tbx_diffGV.TabIndex = 3;
            // 
            // cmb_color
            // 
            this.cmb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Location = new System.Drawing.Point(160, 113);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(166, 26);
            this.cmb_color.TabIndex = 4;
            // 
            // tbx_sizeX
            // 
            this.tbx_sizeX.Location = new System.Drawing.Point(129, 169);
            this.tbx_sizeX.Name = "tbx_sizeX";
            this.tbx_sizeX.Size = new System.Drawing.Size(80, 28);
            this.tbx_sizeX.TabIndex = 5;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(183, 270);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(109, 64);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "적용";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // tbx_sizeY
            // 
            this.tbx_sizeY.Location = new System.Drawing.Point(244, 169);
            this.tbx_sizeY.Name = "tbx_sizeY";
            this.tbx_sizeY.Size = new System.Drawing.Size(71, 28);
            this.tbx_sizeY.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // FmInspProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FmInspProp";
            this.Size = new System.Drawing.Size(436, 464);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_diffGV;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.TextBox tbx_sizeX;
        private System.Windows.Forms.ComboBox cmb_color;
        private System.Windows.Forms.TextBox tbx_diffGV;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.TextBox tbx_sizeY;
        private System.Windows.Forms.Label label1;
    }
}
