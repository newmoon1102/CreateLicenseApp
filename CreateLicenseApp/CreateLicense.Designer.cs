namespace CreateLicenseApp
{
    partial class frmCreateLicense
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbKeyType = new System.Windows.Forms.ComboBox();
            this.lbTrialNum = new System.Windows.Forms.Label();
            this.txtTrialNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(140, 97);
            this.txtCourseID.MaxLength = 13;
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(144, 25);
            this.txtCourseID.TabIndex = 3;
            // 
            // txtUUID
            // 
            this.txtUUID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUUID.Location = new System.Drawing.Point(140, 59);
            this.txtUUID.MaxLength = 32;
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(445, 25);
            this.txtUUID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã UUID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại kích hoạt:";
            // 
            // cbbKeyType
            // 
            this.cbbKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKeyType.FormattingEnabled = true;
            this.cbbKeyType.Items.AddRange(new object[] {
            "Chọn mã kích hoạt",
            "Mã dùng thử",
            "Mã từng khóa học",
            "Mã toàn khóa học",
            "Quyền truy cập tất cả"});
            this.cbbKeyType.Location = new System.Drawing.Point(414, 97);
            this.cbbKeyType.Name = "cbbKeyType";
            this.cbbKeyType.Size = new System.Drawing.Size(170, 25);
            this.cbbKeyType.TabIndex = 4;
            // 
            // lbTrialNum
            // 
            this.lbTrialNum.AutoSize = true;
            this.lbTrialNum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrialNum.Location = new System.Drawing.Point(393, 136);
            this.lbTrialNum.Name = "lbTrialNum";
            this.lbTrialNum.Size = new System.Drawing.Size(127, 17);
            this.lbTrialNum.TabIndex = 6;
            this.lbTrialNum.Text = "Số ngày dùng thử:";
            // 
            // txtTrialNum
            // 
            this.txtTrialNum.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrialNum.Location = new System.Drawing.Point(529, 128);
            this.txtTrialNum.MaxLength = 2;
            this.txtTrialNum.Name = "txtTrialNum";
            this.txtTrialNum.Size = new System.Drawing.Size(55, 25);
            this.txtTrialNum.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã kích hoạt:";
            // 
            // txtLicense
            // 
            this.txtLicense.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicense.Location = new System.Drawing.Point(140, 174);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ReadOnly = true;
            this.txtLicense.Size = new System.Drawing.Size(445, 25);
            this.txtLicense.TabIndex = 6;
            this.txtLicense.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(200, 224);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 28);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Tạo mã";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(338, 224);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(106, 28);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy mã";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(478, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save mã";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fbDialog
            // 
            this.fbDialog.Description = "Vui lòng chọn thư mục lưu key";
            // 
            // txtRequest
            // 
            this.txtRequest.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(140, 19);
            this.txtRequest.MaxLength = 32;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(445, 25);
            this.txtRequest.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã yêu cầu:";
            // 
            // frmCreateLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(611, 263);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrialNum);
            this.Controls.Add(this.lbTrialNum);
            this.Controls.Add(this.cbbKeyType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(627, 302);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(627, 302);
            this.Name = "frmCreateLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create License App";
            this.Load += new System.EventHandler(this.frmCreateLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbKeyType;
        private System.Windows.Forms.Label lbTrialNum;
        private System.Windows.Forms.TextBox txtTrialNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label label4;
    }
}

