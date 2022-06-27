using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            TabPage tabPage1 = new TabPage("11");
            TabPage tabPage2 = new TabPage("21");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            for (int i = 0; i < 10; i++)
            {
                tabControl1.Controls.Add(new TabPage(i + " "));
            }
            

            var dgv = new DataGridView();
            dgv.BackgroundColor = Color.Bisque;
            dgv.Dock = DockStyle.Fill;
            tabControl1.Controls[0].Controls.Add(dgv);
            
            dgv = new DataGridView();
            dgv.BackgroundColor = Color.MistyRose;
            tabControl1.Controls[1].Controls.Add(dgv);

        }
    }
}
