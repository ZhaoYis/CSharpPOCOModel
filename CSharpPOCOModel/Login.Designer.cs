namespace CSharpPOCOModel
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_server_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_login_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtb_login_pwd = new System.Windows.Forms.TextBox();
            this.mcb_authentication = new System.Windows.Forms.ComboBox();
            this.mbtn_login = new System.Windows.Forms.Button();
            this.mbtn_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器名称：";
            // 
            // mtb_server_name
            // 
            this.mtb_server_name.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtb_server_name.Location = new System.Drawing.Point(115, 22);
            this.mtb_server_name.Name = "mtb_server_name";
            this.mtb_server_name.Size = new System.Drawing.Size(186, 23);
            this.mtb_server_name.TabIndex = 1;
            this.mtb_server_name.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "身份验证：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "登录名：";
            // 
            // mtb_login_name
            // 
            this.mtb_login_name.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtb_login_name.Location = new System.Drawing.Point(115, 106);
            this.mtb_login_name.Name = "mtb_login_name";
            this.mtb_login_name.Size = new System.Drawing.Size(186, 23);
            this.mtb_login_name.TabIndex = 1;
            this.mtb_login_name.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(33, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码：";
            // 
            // mtb_login_pwd
            // 
            this.mtb_login_pwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtb_login_pwd.Location = new System.Drawing.Point(115, 148);
            this.mtb_login_pwd.Name = "mtb_login_pwd";
            this.mtb_login_pwd.Size = new System.Drawing.Size(186, 23);
            this.mtb_login_pwd.TabIndex = 1;
            // 
            // mcb_authentication
            // 
            this.mcb_authentication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcb_authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcb_authentication.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mcb_authentication.FormattingEnabled = true;
            this.mcb_authentication.Items.AddRange(new object[] {
            "Windows身份验证",
            "SQL Server身份验证"});
            this.mcb_authentication.Location = new System.Drawing.Point(115, 68);
            this.mcb_authentication.Name = "mcb_authentication";
            this.mcb_authentication.Size = new System.Drawing.Size(186, 21);
            this.mcb_authentication.TabIndex = 2;
            this.mcb_authentication.SelectedIndexChanged += new System.EventHandler(this.mcb_authentication_SelectedIndexChanged);
            // 
            // mbtn_login
            // 
            this.mbtn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtn_login.Location = new System.Drawing.Point(168, 200);
            this.mbtn_login.Name = "mbtn_login";
            this.mbtn_login.Size = new System.Drawing.Size(84, 29);
            this.mbtn_login.TabIndex = 3;
            this.mbtn_login.Text = "连接";
            this.mbtn_login.UseVisualStyleBackColor = true;
            this.mbtn_login.Click += new System.EventHandler(this.mbtn_login_Click);
            // 
            // mbtn_cancle
            // 
            this.mbtn_cancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtn_cancle.Location = new System.Drawing.Point(268, 200);
            this.mbtn_cancle.Name = "mbtn_cancle";
            this.mbtn_cancle.Size = new System.Drawing.Size(84, 29);
            this.mbtn_cancle.TabIndex = 3;
            this.mbtn_cancle.Text = "取消";
            this.mbtn_cancle.UseVisualStyleBackColor = true;
            this.mbtn_cancle.Click += new System.EventHandler(this.mbtn_cancle_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 241);
            this.Controls.Add(this.mbtn_cancle);
            this.Controls.Add(this.mbtn_login);
            this.Controls.Add(this.mcb_authentication);
            this.Controls.Add(this.mtb_login_pwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtb_login_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_server_name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 280);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "连接到服务器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mtb_server_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mtb_login_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mtb_login_pwd;
        private System.Windows.Forms.ComboBox mcb_authentication;
        private System.Windows.Forms.Button mbtn_login;
        private System.Windows.Forms.Button mbtn_cancle;
    }
}