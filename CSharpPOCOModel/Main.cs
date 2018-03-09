using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSharpPOCOModel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        private string connString = String.Empty;

        private List<string> listDescription = new List<string>();

        /// <summary>
        /// 连接到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 连接到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.ShowDialog();
        }

        /// <summary>
        /// 系统初始化
        /// </summary>
        public void Init(string conn)
        {
            this.connString = conn;

            this.mlab_staus_tips.Text = @"连接成功...";

            LoadDatabase();
        }

        /// <summary>
        /// 加载数据库
        /// </summary>
        private void LoadDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connString))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    string cmdText = "use master;select * from sysdatabases";
                    SqlCommand comm = new SqlCommand(cmdText, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    //填充到DataSet
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "database_table");

                    this.mcb_database.DataSource = ds.Tables["database_table"];
                    this.mcb_database.DisplayMember = "name";
                    this.mcb_database.ValueMember = "name";
                }

                this.connString = Regex.Replace(this.connString, "Catalog=[0-9a-zA-Z_]+;", "Catalog=" + this.mcb_database.Text + ";");
                LoadTables(this.mcb_database.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"数据库加载错误！错误信息：" + ex.Message);
            }
        }

        /// <summary>
        /// 加载数据表
        /// </summary>
        /// <param name="database"></param>
        private void LoadTables(string database)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connString))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    StringBuilder builder = new StringBuilder().AppendFormat("use {0};select * from sysobjects where xtype='U'", database);
                    SqlCommand comm = new SqlCommand(builder.ToString(), conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    //填充到DataSet
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "datatable_table");

                    this.mlist_datatable.DataSource = ds.Tables["datatable_table"];
                    this.mlist_datatable.DisplayMember = "name";
                    this.mlist_datatable.ValueMember = "name";
                    //清理
                    this.mlist_datatable.SelectedItems.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 生成实体
        /// </summary>
        /// <param name="tableName"></param>
        private void GenerateEntity(string tableName)
        {
            try
            {
                this.mlab_staus_tips.Text = string.Format("正在操作表[{0}]", tableName);

                int num = 0;
                StringBuilder stringBuilder = new StringBuilder();
                string cmdText = "select syscolumns.name as ColName,systypes.name as TypeName,sys.extended_properties.value as Description,sysobjects.name as TableName from syscolumns inner join sysobjects on syscolumns.id=sysobjects.id inner join systypes on syscolumns.xtype=systypes.xtype left join sys.extended_properties on sys.extended_properties.major_id=syscolumns.id and sys.extended_properties.minor_id=syscolumns.colorder where sysobjects.name='" + tableName + "' and systypes.name<>'sysname' order by sys.extended_properties.minor_id asc";

                using (SqlConnection conn = new SqlConnection(this.connString))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    SqlCommand comm = new SqlCommand(cmdText.ToString(), conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);

                    //填充到DataSet
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "entity_table");

                    if (ds.Tables["entity_table"].Rows.Count == 0)
                    {
                        this.mrtb_content.Text = @"没有查询结果...";
                    }
                    else
                    {
                        stringBuilder.Append("using System;\r\n\r\n");

                        if (!string.IsNullOrEmpty(this.mtb_namespace.Text.Trim()))
                        {
                            stringBuilder.AppendLine("namespace " + this.mtb_namespace.Text + "\r\n{");
                            num += 4;
                        }

                        stringBuilder.Append("    /// <summary>\r\n");
                        stringBuilder.Append($"    /// 创建人：{Environment.UserName}\r\n");
                        stringBuilder.Append($"    /// 日  期：{DateTime.Now:yyyy.MM.dd HH:mm}\r\n");
                        stringBuilder.Append($"    /// 描  述：{ds.Tables["entity_table"].Rows[0][3]}实体\r\n");
                        stringBuilder.Append("    /// </summary>\r\n");

                        stringBuilder.Append(new string(' ', num));
                        stringBuilder.AppendLine("public class " + ds.Tables["entity_table"].Rows[0][3].ToString() + "Entity");
                        stringBuilder.Append(new string(' ', num));
                        stringBuilder.AppendLine("{");
                        for (int i = 0; i < ds.Tables["entity_table"].Rows.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(ds.Tables["entity_table"].Rows[i][2].ToString()))
                            {
                                stringBuilder.Append(new string(' ', num + 4));
                                stringBuilder.AppendLine("/// <summary>");
                                stringBuilder.Append(new string(' ', num + 4));
                                stringBuilder.AppendLine("/// " + ds.Tables["entity_table"].Rows[i][2]);

                                this.listDescription.Add(ds.Tables["entity_table"].Rows[i][2].ToString());

                                stringBuilder.Append(new string(' ', num + 4));
                                stringBuilder.AppendLine("/// </summary>");
                            }
                            stringBuilder.Append(new string(' ', num + 4));
                            stringBuilder.AppendLine(string.Concat(new string[]
                            {
                            "public ",
                            ds.Tables["entity_table"].Rows[i][1].ToString(),
                            " ",
                            ds.Tables["entity_table"].Rows[i][0].ToString(),
                            " { get; set; }"
                            }));
                        }
                        stringBuilder.Append(new string(' ', num));
                        stringBuilder.AppendLine("}");
                        if (!string.IsNullOrEmpty(this.mtb_namespace.Text.Trim()))
                        {
                            stringBuilder.AppendLine("}");
                        }
                        string text = ChangeWords(stringBuilder.ToString());
                        this.mrtb_content.Text = text;
                        this.ChangeColor();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"类生成失败！错误信息：" + ex.Message);
            }
        }

        /// <summary>
        /// 修正数据类型
        /// </summary>
        /// <param name="content">数据库数据类型</param>
        /// <returns></returns>
        private string ChangeWords(string content)
        {
            string input = Regex.Replace(content, "nvarchar", "string");
            input = Regex.Replace(input, "bit", "bool");
            input = Regex.Replace(input, "varchar", "string");
            input = Regex.Replace(input, "text", "string");
            input = Regex.Replace(input, "ntext", "string");
            input = Regex.Replace(input, "nchar", "string");
            input = Regex.Replace(input, "char", "string");
            input = Regex.Replace(input, "tinyint", "byte");
            input = Regex.Replace(input, "smallint", "short");
            input = Regex.Replace(input, "bigint", "long");
            input = Regex.Replace(input, "numeric", "decimal");
            input = Regex.Replace(input, "money", "decimal");
            input = Regex.Replace(input, "float", "double");
            input = Regex.Replace(input, "real", "float");
            input = Regex.Replace(input, "uniqueidentifier", "Guid");
            input = Regex.Replace(input, "datetime", "DateTime");
            input = Regex.Replace(input, "image", "byte[]");
            input = Regex.Replace(input, "binary", "byte[]");
            
            return input;
        }

        /// <summary>
        /// 着色
        /// </summary>
        private void ChangeColor()
        {
            this.mrtb_content.SelectionStart = 0;
            this.mrtb_content.SelectionLength = this.mrtb_content.Text.Length;
            this.mrtb_content.SelectionColor = Color.Black;
            if (this.listDescription.Count > 0)
            {
                this.ChangeKeyColor(this.listDescription, Color.Green);
            }
            this.ChangeKeyColor("using", Color.Blue);
            this.ChangeKeyColor("namespace", Color.Blue);
            this.ChangeKeyColor("public", Color.Blue);
            this.ChangeKeyColor("class", Color.Blue);
            this.ChangeKeyColor("/// <summary>", Color.Gray);
            this.ChangeKeyColor("///", Color.Gray);
            this.ChangeKeyColor("/// </summary>", Color.Gray);
            this.ChangeKeyColor("int", Color.Blue);
            this.ChangeKeyColor("double", Color.Blue);
            this.ChangeKeyColor("float", Color.Blue);
            this.ChangeKeyColor("char", Color.Blue);
            this.ChangeKeyColor("string", Color.Blue);
            this.ChangeKeyColor("bool", Color.Blue);
            this.ChangeKeyColor("decimal", Color.Blue);
            this.ChangeKeyColor("enum", Color.Blue);
            this.ChangeKeyColor("const", Color.Blue);
            this.ChangeKeyColor("struct", Color.Blue);
            this.ChangeKeyColor("DateTime", Color.CadetBlue);
            this.ChangeKeyColor("get", Color.Blue);
            this.ChangeKeyColor("set", Color.Blue);
        }

        /// <summary>
        /// 着色
        /// </summary>
        /// <param name="key"></param>
        /// <param name="color"></param>
        private void ChangeKeyColor(string key, Color color)
        {
            Regex regex = new Regex(key);
            MatchCollection matchCollection = regex.Matches(this.mrtb_content.Text);
            foreach (Match match in matchCollection)
            {
                this.mrtb_content.SelectionStart = match.Index;
                this.mrtb_content.SelectionLength = key.Length;
                this.mrtb_content.SelectionColor = color;
            }
        }

        /// <summary>
        /// 描述信息着色
        /// </summary>
        /// <param name="list"></param>
        /// <param name="color"></param>
        private void ChangeKeyColor(List<string> list, Color color)
        {
            foreach (string current in list)
            {
                this.ChangeKeyColor(current, color);
            }
        }

        /// <summary>
        /// 选择数据库，加载数据表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mcb_database_DropDownClosed(object sender, EventArgs e)
        {
            string text = this.mcb_database.Text;
            this.connString = Regex.Replace(this.connString, "Catalog=[0-9a-zA-Z_]+;", "Catalog=" + text + ";");
            this.LoadTables(text);
        }

        /// <summary>
        /// 选择数据表，生成实体代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlist_datatable_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateEntity(this.mlist_datatable.Text);
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 选择文件保存地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtn_selectpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = @"请选择文件路径"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = dialog.SelectedPath;
                this.mtb_filepath.Text = savePath;
            }
        }

        /// <summary>
        /// 导出文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtn_tofile_Click(object sender, EventArgs e)
        {
            string fileName = this.mlist_datatable.Text;
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show(@"请选择数据表");
            }
            else
            {
                string path = this.mtb_filepath.Text + "\\File\\";
                if (string.IsNullOrEmpty(path)) path = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = path + "\\" + fileName + ".cs";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                StreamWriter streamWriter = new StreamWriter(filePath, false, Encoding.Default);
                streamWriter.Write(this.mrtb_content.Text);

                streamWriter.Flush();
                streamWriter.Close();
                streamWriter.Dispose();

                MessageBox.Show(@"文件生成成功！");
            }
        }

        #region 其他

        //SQLServer类型    C#类型
        //    bit           bool
        //    tinyint       byte
        //    smallint      short
        //    int           int
        //    bigint        long
        //    real          float
        //    float         double
        //    money         decimal
        //    datetime      DateTime
        //    char          string
        //    varchar       string
        //    nchar         string
        //    nvarchar      string
        //    text          string
        //    ntext         string
        //    image         byte[]
        //    binary        byte[]
        //    uniqueidentifier    Guid

        #endregion
    }
}
