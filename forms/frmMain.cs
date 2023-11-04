using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_to_String_Builder
{
    //<a href="https://www.flaticon.es/iconos-gratis/nlp" title="nlp iconos">Nlp iconos creados por Freepik - Flaticon</a>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string text = edtOriginalText.Text;
            edtConvertedText.Text = null;
            string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                string newLine = string.Empty;
                if (line.Length > 0)
                {
                    if (rbSQLtoSB.Checked)
                        newLine = "sql.AppendLine(\"" + line + "\");";
                    else
                    {
                        newLine = line.Replace("sql.AppendLine(\"", "");
                        newLine = newLine.Substring(0, newLine.Length - 3);
                    }
                }
                edtConvertedText.EditValue = edtConvertedText.EditValue + newLine + Environment.NewLine;
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(edtConvertedText.EditValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al copiar datos al portapapeles: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
