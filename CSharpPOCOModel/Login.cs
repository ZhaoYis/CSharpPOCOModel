using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharpPOCOModel
{
    public partial class Login : Form
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private string connString = String.Empty;

        /// <summary>
        /// 主窗体
        /// </summary>
        private Main _main = null;

        public Login(Main main)
        {
            InitializeComponent();

            this._main = main;
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtn_login_Click(object sender, EventArgs e)
        {
            bool check = InputCheck();
            if (check)
            {
                string serverName = this.mtb_server_name.Text.Trim();
                serverName = this.FormatServerAddress(serverName);

                //0-Windows身份验证 1-SQL Server身份验证
                int auth = this.mcb_authentication.SelectedIndex;
                string loginName = this.mtb_login_name.Text.Trim();
                string pwd = this.mtb_login_pwd.Text.Trim();

                if (auth == 0)
                {
                    this.connString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true;", serverName, "master");
                }
                else
                {
                    this.connString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=false;User={2};Password={3};", new object[]
                    {
                        serverName,
                        "master",
                        loginName,
                        pwd
                    });
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(this.connString))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        //初始化数据库连接
                        _main.Init(this.connString);
                        //关闭登陆窗口
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"连接失败！错误信息：" + ex.Message);
                }
            }
        }

        /// <summary>
        /// 校验
        /// </summary>
        private bool InputCheck()
        {
            string serverName = this.mtb_server_name.Text.Trim();
            //0-Windows身份验证 1-SQL Server身份验证
            int auth = this.mcb_authentication.SelectedIndex;
            string loginName = this.mtb_login_name.Text.Trim();
            string pwd = this.mtb_login_pwd.Text.Trim();

            if (string.IsNullOrEmpty(serverName))
            {
                DialogResult result = MessageBox.Show(@"请输入服务器名称", @"警告", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.mtb_server_name.Focus();
                    return false;
                }
            }
            else if (auth == -1)
            {
                DialogResult result = MessageBox.Show(@"请选择身份验证类型", @"警告", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    return false;
                }
            }
            else if (string.IsNullOrEmpty(loginName) && auth != 0)
            {
                DialogResult result = MessageBox.Show(@"请输入登录名", @"警告", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.mtb_login_name.Focus();
                    return false;
                }
            }
            else if (string.IsNullOrEmpty(pwd) && auth != 0)
            {
                DialogResult result = MessageBox.Show(@"请登陆密码", @"警告", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.mtb_login_pwd.Focus();
                    return false;
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        private void mcb_authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            //0-Windows身份验证 1-SQL Server身份验证
            int auth = this.mcb_authentication.SelectedIndex;

            if (auth == 0)
            {
                this.mtb_login_name.Enabled = false;
                this.mtb_login_pwd.Enabled = false;
            }
            else
            {
                this.mtb_login_name.Enabled = true;
                this.mtb_login_pwd.Enabled = true;
            }
        }

        private string FormatServerAddress(string address)
        {
            string pattern = "(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)\\.(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)\\.(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)\\.(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)";
            string pattern2 = "(https|http)?://(www|\\w+).\\w+.(com|cn|net|top|xyz|xin|tech|org|gov|edu)?";
            string text = ",1433";
            bool flag = Regex.IsMatch(address, pattern, RegexOptions.IgnoreCase);
            string result;
            if (flag)
            {
                bool flag2 = !address.Contains(text);
                if (flag2)
                {
                    result = address + text;
                    return result;
                }
            }
            else
            {
                bool flag3 = Regex.IsMatch(address, pattern2, RegexOptions.IgnoreCase);
                if (!flag3)
                {
                    result = address;
                    return result;
                }
                bool flag4 = !address.Contains(text);
                if (flag4)
                {
                    result = address + text;
                    return result;
                }
            }
            result = address;
            return result;
        }

    }
}
