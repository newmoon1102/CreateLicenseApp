using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CreateLicenseApp
{
    public partial class frmCreateLicense : Form
    {
        private string key = "";

        public frmCreateLicense()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                key = "";
                txtLicense.Text = "";

                if (txtUUID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã UUID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (txtUUID.Text.Trim().Length != 32)
                    {
                        MessageBox.Show("Mã UUID không đúng.Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                key = txtUUID.Text.Trim();

                if (cbbKeyType.Text == "Chọn mã kích hoạt")
                {
                    MessageBox.Show("Vui lòng chọn mã kích hoạt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbbKeyType.Text == "Quyền truy cập tất cả")
                {
                    key = "PEVCSALL" + key.Substring(16, 16) + key.Substring(0, 16) + "ALL05";
                }
                else if (cbbKeyType.Text == "Mã toàn khóa học")
                {
                    if (txtCourseID.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtCourseID.Text.Length != 3)
                    {
                        MessageBox.Show("Mã sản phẩm không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    key = "PEVCS" + txtCourseID.Text.Trim() + key + "ALL05";
                }
                else if (cbbKeyType.Text == "Mã từng khóa học")
                {
                    if (txtCourseID.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtCourseID.Text.Length != 8)
                    {
                        MessageBox.Show("Mã sản phẩm không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    key = txtCourseID.Text.Trim() + key + "LMT05";
                }
                else if (cbbKeyType.Text == "Mã dùng thử")
                {
                    if (txtCourseID.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtCourseID.Text.Length != 3 && txtCourseID.Text.Length != 8)
                    {
                        MessageBox.Show("Mã sản phẩm không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtTrialNum.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập số ngày dùng thử (0-99).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (Regex.IsMatch(txtTrialNum.Text, "[^0-9]"))
                        {
                            MessageBox.Show("Vui lòng nhập số ngày dùng thử (0-99).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string subKey = null;
                    if (txtCourseID.Text.Length == 3)
                    {
                        subKey = "PEVCS" + txtCourseID.Text.Trim();
                    }
                    else
                    {
                        subKey = txtCourseID.Text.Trim();
                    }

                    key = subKey + key + "TRL" + txtTrialNum.Text.PadLeft(2, '0');
                }

                string license = VDCSDK.App.EncryptKey(key, true);
                txtLicense.Text = license;
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình tạo mã.Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicense.Text = "";
                return;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(txtLicense.Text == "")
            {
                MessageBox.Show("Vui lòng tạo mã kích hoạt.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            txtLicense.SelectAll();
            txtLicense.Focus();
            SendKeys.SendWait("^(c)");
        }

        private void frmCreateLicense_Load(object sender, EventArgs e)
        {
            cbbKeyType.Text = "Chọn mã kích hoạt";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLicense.Text == "")
            {
                MessageBox.Show("Vui lòng tạo mã kích hoạt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult result = fbDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string output = fbDialog.SelectedPath + @"\license.txt";
                    using (var stream = File.CreateText(output))
                    {
                        string csvRow = string.Format("{0}: {1}", "Mã yêu cầu", txtRequest.Text);
                        stream.WriteLine(csvRow);
                        csvRow = string.Format("{0}: {1}", "Mã UUID", txtUUID.Text);
                        stream.WriteLine(csvRow);
                        if(txtCourseID.Text != "")
                        {
                            csvRow = string.Format("{0}: {1}", "Mã sản phẩm", txtCourseID.Text);
                            stream.WriteLine(csvRow);
                        }
                        csvRow = string.Format("{0}: {1}", "Loại Key", cbbKeyType.Text);
                        stream.WriteLine(csvRow);
                        if(cbbKeyType.Text == "Mã dùng thử")
                        {
                            csvRow = string.Format("{0}: {1}", "Số ngày dùng thử", txtTrialNum.Text);
                            stream.WriteLine(csvRow);
                        }
                        csvRow = string.Format("{0}: {1}", "Mã kích hoạt", txtLicense.Text);
                        stream.WriteLine(csvRow);
                    }

                    MessageBox.Show("Mã khóa học đã lưu thành công.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lưu mã thất bại. Vui lòng thử lại sau.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
