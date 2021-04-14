using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JustRenameIT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dRes = folderBrowserDialog1.ShowDialog(this);
            if (dRes == DialogResult.OK) {
                txtSourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dRes = folderBrowserDialog1.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                txtDestinationFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (txtSourceFolder.Text.Length==0){
                MessageBox.Show(this, "Please select a source folder");
                this.Cursor = Cursors.Default;
                return;
            }

            if (checkBox1.Checked && txtDestinationFolder.Text.Length == 0)
            {
                MessageBox.Show(this, "Please select a destination folder");
                this.Cursor = Cursors.Default;
                return;
            }
            

            if (!Directory.Exists(txtSourceFolder.Text))
            {
                MessageBox.Show(this, "Please select an existing source folder");
                this.Cursor = Cursors.Default;
                return;
            }

            if (checkBox1.Checked  && !Directory.Exists(txtDestinationFolder.Text))
            {
                MessageBox.Show(this, "Please select an existing destination folder");
                this.Cursor = Cursors.Default;
                return;
            }

            char DS = Path.DirectorySeparatorChar;
            //scan biztalk dir for template info files
            string[] nfoEntries = Directory.GetFiles(txtSourceFolder.Text);

            decimal prefixIteration = prefixIterateFrom.Value;
            decimal appendIteration = appendIterateFrom.Value;

            string prefixPads = System.Convert.ToString(nfoEntries.Length + prefixIteration);
            string appendPads = System.Convert.ToString(nfoEntries.Length + appendIteration);

            for (int i =0; i< nfoEntries.Length;i++)
            {
                try
                {
                    string oldFileLine = nfoEntries[i];

                    string oldFileName = oldFileLine.Split('\\').Last();
                    oldFileName = oldFileName.Split('.').First();

                    string newFileName = filePrefix.Text;

                    string prefixNumericString = System.Convert.ToString(prefixIteration + nfoEntries.Length + 1);

                    if (prefixCheckbox.Checked)
                    {
                        newFileName += System.Convert.ToString(prefixIteration + i + 1).PadLeft(prefixNumericString.Length, '0');
                    }

                    newFileName += fileName.Text;
                    if (fileName.Text.Length == 0) { newFileName += oldFileName; }

                    newFileName += fileAppend.Text;

                    string appendNumericString = System.Convert.ToString(appendIteration + nfoEntries.Length + 1);
                    if (appendCheckBox.Checked)
                    {
                        newFileName += System.Convert.ToString(appendIteration + i + 1).PadLeft(appendNumericString.Length, '0');
                    }

                    string fex = oldFileLine.Split('.').Last();
                    
                    if (checkBox1.Checked)
                    {
                        newFileName = txtDestinationFolder.Text + DS + newFileName + "." + fex;
                        System.IO.File.Copy(oldFileLine, newFileName);
                    }
                    else
                    {
                        newFileName = txtSourceFolder.Text + DS + newFileName + "." + fex;
                        System.IO.File.Move(oldFileLine, newFileName);
                    }

                }
                catch (System.Exception error){
                    MessageBox.Show(this, "Error: " + error.Message);
                }
            }
            this.Cursor = Cursors.Default;
            MessageBox.Show(this, "~ Finished ~");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtDestinationFolder.Enabled = false;
            button2.Enabled = false;
            if (checkBox1.Checked) {
                txtDestinationFolder.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show(this);
        }

        private void ShowPreview() {
            string preview = "";
            if (filePrefix.Text.Length > 0) {
                preview += "[prefix] + ";
            }
            if (prefixCheckbox.Checked) {
                preview += "[zero padded iteration (";
                preview += System.Convert.ToString(prefixIterateFrom.Value) + "+1)] + ";
            }
            preview += "[";
            if (fileName.Text.Length > 0) {
                preview += "new ";
            }
            preview += "filename]";
            if (fileAppend.Text.Length > 0) {
                preview += " + [suffix]";
            }
            if (appendCheckBox.Checked)
            {
                preview += " + [zero padded iteration (";
                preview += System.Convert.ToString(appendIterateFrom.Value) + "+1)]";
            }
            preview += " . [extension]";

            lblPreview.Text = preview;
        }

        private void filePrefix_TextChanged(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void fileAppend_TextChanged(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void prefixCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void appendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void prefixIterateFrom_ValueChanged(object sender, EventArgs e)
        {
            ShowPreview();
        }

        private void appendIterateFrom_ValueChanged(object sender, EventArgs e)
        {
            ShowPreview();
        }
    }
}
