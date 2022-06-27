using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            for (int i = 0; i < 10; i++)
            {
                tabControl1.Controls.Add(new TabPage(i + " "));
            }
            tabControl1.Height = 40;
            dataGridViewSchedule.RowTemplate.Height = 40;

            for (int i = 0; i < 4; i++)
            {
                dataGridViewSchedule.Columns.Add(new SpannedDataGridView.DataGridViewTextBoxColumnEx());
                dataGridViewSchedule.Columns[i].Width = 200;
            }
            dataGridViewSchedule.RowCount = 20;
            listViewSubjects.Columns.Add("Дисциплина");
            listViewSubjects.Columns.Add("Преподователь");
            listViewSubjects.Columns.Add("Тип занятия");
            listViewSubjects.Columns.Add("Кол-во часов");
            for (int i = 0; i < 4; i++)
            {
                listViewSubjects.Columns[i].Width = 140;
            }

            listViewSubjects.Font = new Font(FontFamily.GenericSansSerif, 12);

            listViewErrors.Columns.Add("Тип ошибки");
            listViewErrors.Columns.Add("Сведения");
            listViewErrors.Columns.Add("Еще сведелния");
            listViewErrors.Columns.Add("Какая-то цифра");
            for (int i = 0; i < 4; i++)
            {
                listViewErrors.Columns[i].Width = 140;
            }
            listViewErrors.Font = new Font(FontFamily.GenericSansSerif, 12);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListViewItem lvi = new ListViewItem("qqq");
                lvi.SubItems.Add("www");
                lvi.SubItems.Add("eee");
                lvi.SubItems.Add(i.ToString());
                listViewSubjects.Items.Add(lvi);
            }
            for (int i = 0; i < 10; i++)
            {
                ListViewItem lvi = new ListViewItem("Error");
                lvi.SubItems.Add("very");
                lvi.SubItems.Add("bad");
                lvi.SubItems.Add(i.ToString());
                listViewErrors.Items.Add(lvi);
            }

        }
    }
}
