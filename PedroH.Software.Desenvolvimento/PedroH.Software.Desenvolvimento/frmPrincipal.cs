using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedroH.Software.Desenvolvimento
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"c:\Nova Pasta");
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\WINDOWS\system32\calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            using (var file = new StreamWriter(@"c:\Nova Pasta\test.txt", true)) {
                file.Write(texto);   
            }
        }
    }
}
