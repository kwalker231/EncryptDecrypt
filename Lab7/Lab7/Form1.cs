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

namespace Lab7
{
    public partial class Form1 : Form
    {
        FileStream fin = null, fout = null;
        public Form1()
        {
            InitializeComponent();
            this.Text = "File Encrypt/Decrypt";
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                    textBox1.Text = openFileDialog1.FileName;
        }

        private void decryptbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == String.Empty)
                    throw new ArgumentNullException();

                string key = textBox2.Text;
                string fpath = textBox1.Text;
                if (!fpath.EndsWith(".enc"))
                {
                    MessageBox.Show("Not a .enc file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fin = new FileStream(fpath, FileMode.Open);

                string outpath = fpath.Remove(fpath.Length - 4, 4);
                Boolean exist = File.Exists(outpath);
                if (exist)
                {
                    string overwriteMsg = "Output file exists. Overwrite?";
                    DialogResult msg = MessageBox.Show(overwriteMsg, "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.No)
                        return;
                }
                fout = new FileStream(outpath, FileMode.Create);

                int rbyte;
                int pos = 0;    //position in key string
                int length = key.Length; //length of key
                byte kbyte, ebyte; //encrypted byte

                while ((rbyte = fin.ReadByte()) != -1)
                {
                    kbyte = (byte)key[pos];
                    ebyte = (byte)(rbyte ^ kbyte);
                    fout.WriteByte(ebyte);
                    ++pos;
                    if (pos == length)
                        pos = 0;
                }
                MessageBox.Show("Operation completed successfully.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open source or destination file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }

        }

        private void encryptbutton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBox2.Text == String.Empty)
                    throw new ArgumentNullException();
                string key = textBox2.Text;

                string fpath = textBox1.Text;
                fin = new FileStream(fpath, FileMode.Open);
                string outpath = fpath + ".enc";
                Boolean exist = File.Exists(outpath);
                if (exist)
                {
                    DialogResult meg = MessageBox.Show("Output file exists. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (meg == DialogResult.No)
                        return;
                }
                fout = new FileStream(outpath, FileMode.Create);
                
                int rbyte;
                int pos = 0;    //position in key string
                int length = key.Length; //length of key
                byte kbyte, ebyte; //encrypted byte

                while ((rbyte = fin.ReadByte()) != -1)
                {
                    kbyte = (byte)key[pos];
                    ebyte = (byte)(rbyte ^ kbyte);
                    fout.WriteByte(ebyte);
                    ++pos;
                    if (pos == length)
                        pos = 0;
                }
                MessageBox.Show("Operation completed successfully.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter a key.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open source or destination file.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fin != null) fin.Close();
                if (fout != null) fout.Close();
            }

        }

    }
}
