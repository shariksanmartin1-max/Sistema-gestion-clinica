using System;
using System.Windows.Forms;

namespace SistemaClinica.Formularios
{
    public partial class FrmReportViewer : Form
    {
        public FrmReportViewer()
        {
            InitializeComponent();
        }

        public FrmReportViewer(string title, string content) : this()
        {
            this.Text = title;
            textBox1.Text = content;
        }
    }
}
