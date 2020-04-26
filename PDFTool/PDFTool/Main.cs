using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PDFTool
{
    public partial class PDFTool : Form
    {
        public PDFTool()
        {
            InitializeComponent();
        }

        // Global var
        string g_file = "";

        #region Deal with check button
        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_all.Checked)
            {
                chk_spec.Enabled = false;
                chk_spec_range.Enabled = false;
                chk_spec_range_pdf.Enabled = false;
                gb_merge.Enabled = false;
            }
            else
            {
                chk_spec.Enabled = true;
                chk_spec_range.Enabled = true;
                chk_spec_range_pdf.Enabled = true;
                gb_merge.Enabled = true;
            }
        }

        private void chk_spec_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_spec.Checked)
            {
                chk_all.Enabled = false;
                chk_spec_range.Enabled = false;
                chk_spec_range_pdf.Enabled = false;
                gb_merge.Enabled = false;
                txt_spec_one.Clear();
            }
            else
            {
                chk_all.Enabled = true;
                chk_spec_range.Enabled = true;
                chk_spec_range_pdf.Enabled = true;
                gb_merge.Enabled = true;
            }
        }

        private void chk_spec_range_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_spec_range.Checked)
            {
                chk_all.Enabled = false;
                chk_spec.Enabled = false;
                chk_spec_range_pdf.Enabled = false;
                gb_merge.Enabled = false;
                txt_spec_range_start.Clear();
                txt_spec_range_end.Clear();
            }
            else
            {
                chk_all.Enabled = true;
                chk_spec.Enabled = true;
                chk_spec_range_pdf.Enabled = true;
                gb_merge.Enabled = true;
            }
        }

        private void chk_spec_range_pdf_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_spec_range_pdf.Checked)
            {
                chk_all.Enabled = false;
                chk_spec.Enabled = false;
                chk_spec_range.Enabled = false;
                gb_merge.Enabled = false;
                txt_spec_range_one_start.Clear();
                txt_spec_range_one_end.Clear();
            }
            else
            {
                chk_all.Enabled = true;
                chk_spec.Enabled = true;
                chk_spec_range.Enabled = true;
                gb_merge.Enabled = true;
            }
        }

        private void chk_merge_spec_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_merge_spec.Checked)
            {
                gb_split.Enabled = false;
                chk_spec_merge.Enabled = false;
            }
            else
            {
                gb_split.Enabled = true;
                chk_spec_merge.Enabled = true;
            }
        }

        private void chk_spec_merge_CheckedChanged(object sender, EventArgs e)
        {
            txt_merge_page.Text = "";

            if (chk_spec_merge.Checked)
            {
                gb_split.Enabled = false;
                chk_merge_spec.Enabled = false;
            }
            else
            {
                gb_split.Enabled = true;
                chk_merge_spec.Enabled = true;
            }
        }

        #endregion

        /// <summary>
        /// Choose PDF file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fDialog = new OpenFileDialog();
                fDialog.Multiselect = false;
                fDialog.Title = "ファイルを選びます";
                fDialog.Filter = "ファイル (*.pdf)|*.pdf";
                if (fDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    file_name.Text = g_file = fDialog.FileName;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Split PDF file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_split_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string[] ary = new string[30];

            if (g_file == "")
            {
                MessageBox.Show("Please choose PDF file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Do for all checked
            if (chk_all.Checked)
            {
                RunPythonScript("-a", g_file);
                flag = true;
            }

            // Do for spec one page
            if (chk_spec.Checked)
            {
                ary[0] = g_file;
                string[] tmp = Regex.Split(txt_spec_one.Text.TrimStart().TrimEnd(), "\\s+", RegexOptions.IgnoreCase);

                tmp.CopyTo(ary, 1);
                RunPythonScript("-s", ary);
                flag = true;
            }

            // Do for special page in a range
            if (chk_spec_range.Checked)
            {
                ary[0] = g_file;
                ary[1] = txt_spec_range_start.Text.Trim().ToString();
                ary[2] = txt_spec_range_end.Text.Trim().ToString();
                RunPythonScript("-r", ary);
                flag = true;
            }

            // Do for special page by a range to one pdf file
            if (chk_spec_range_pdf.Checked)
            {
                ary[0] = g_file;
                ary[1] = txt_spec_range_one_start.Text.Trim().ToString();
                ary[2] = txt_spec_range_one_end.Text.Trim().ToString();
                RunPythonScript("-rs", ary);
                flag = true;
            }
            if (!flag)
            {
                MessageBox.Show("Please choose one function!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Add file into listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_file_merge_Click(object sender, EventArgs e)
        {
            if (!chk_merge_spec.Checked)
            {
                return;
            }
            try
            {
                OpenFileDialog fDialog = new OpenFileDialog();
                fDialog.Multiselect = true;
                fDialog.Title = "ファイルを選びます";
                fDialog.Filter = "ファイル (*.pdf)|*.pdf";
                if (fDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (fDialog.FileNames.Length != 0)
                    {
                        foreach (string file in fDialog.FileNames)
                        {
                            list_files.Items.Add(file);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Clear list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (!chk_merge_spec.Checked)
            {
                return;
            }
            list_files.Items.Clear();
        }

        /// <summary>
        /// Delete select file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!chk_merge_spec.Checked)
            {
                return;
            }

            try
            {
                if (list_files.SelectedItems.Count > 0)
                {
                    list_files.Items.Remove(list_files.SelectedItem.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Merge pdf file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_merge_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string[] ary = new string[30];
            try
            {
                if (chk_merge_spec.Checked)
                {
                    if (list_files.Items.Count > 0)
                    {
                        list_files.Items.Cast<string>().ToArray().CopyTo(ary, 0);
                        RunPythonScript("-m", ary);
                        flag = true;
                    }
                }

                if (chk_spec_merge.Checked)
                {
                    ary[0] = g_file;
                    if (txt_merge_page.Text == "")
                    {
                        return;
                    }
                    string[] tmp = Regex.Split(txt_merge_page.Text.TrimStart().TrimEnd(), "\\s+", RegexOptions.IgnoreCase);

                    tmp.CopyTo(ary, 1);
                    RunPythonScript("-ms", ary);
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (!flag)
            {
                MessageBox.Show("Please choose one function!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Call Python file
        /// </summary>
        /// <param name="args"></param>
        /// <param name="teps"></param>
        public static void RunPythonScript(string args = "", params string[] argvs)
        {
            try
            {
                string sArgName = @"PDFTool.py";
                Process pro = new Process();
                string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + sArgName + " " + args;
                //string path = System.Environment.CurrentDirectory + sArgName + " " + args;
                pro.StartInfo.FileName = @"python.exe";
                string sArguments = path;
                foreach (string str in argvs)
                {
                    if (str == null)
                        break;
                    sArguments += " " + str;
                }

                pro.StartInfo.Arguments = sArguments;
                pro.StartInfo.UseShellExecute = false;
                pro.StartInfo.RedirectStandardOutput = true;
                pro.StartInfo.RedirectStandardInput = true;
                pro.StartInfo.RedirectStandardError = true;
                pro.StartInfo.CreateNoWindow = true;

                pro.Start();
                pro.BeginOutputReadLine();
                pro.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
                Console.ReadLine();
                pro.WaitForExit();
                pro.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                AppendText(e.Data + Environment.NewLine);
            }
        }

        public delegate void AppendTextCallback(string text);
        public static void AppendText(string text)
        {
            Console.WriteLine(text);
        }

        private void btn_file_merge_spec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fDialog = new OpenFileDialog();
                fDialog.Multiselect = false;
                fDialog.Title = "ファイルを選びます";
                fDialog.Filter = "ファイル (*.pdf)|*.pdf";
                if (fDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txt_spec_merge.Text = g_file = fDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
