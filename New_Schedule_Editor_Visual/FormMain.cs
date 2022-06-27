using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Schedule_Editor_Visual
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tabControl1.Width = (int)(this.Width * 0.6);


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
            MessageBox.Show(this.Width + " = " + tabControl1.Width + " + " + panel1.Width);
        }

        
    }
}
