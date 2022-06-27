namespace Editor
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.listViewSubjects = new System.Windows.Forms.ListView();
            this.tabPageAudiences = new System.Windows.Forms.TabPage();
            this.listViewErrors = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageTeachers.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewSchedule);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(947, 626);
            this.splitContainer1.SplitterDistance = 651;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AllowUserToAddRows = false;
            this.dataGridViewSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewSchedule.ColumnHeadersHeight = 30;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSchedule.ColumnHeadersVisible = false;
            this.dataGridViewSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.RowHeadersVisible = false;
            this.dataGridViewSchedule.RowTemplate.Height = 30;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(651, 425);
            this.dataGridViewSchedule.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 425);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listViewErrors);
            this.splitContainer2.Size = new System.Drawing.Size(292, 626);
            this.splitContainer2.SplitterDistance = 268;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageTeachers);
            this.tabControl2.Controls.Add(this.tabPageAudiences);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(292, 268);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.listViewSubjects);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(284, 242);
            this.tabPageTeachers.TabIndex = 0;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // listViewSubjects
            // 
            this.listViewSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSubjects.HideSelection = false;
            this.listViewSubjects.Location = new System.Drawing.Point(3, 3);
            this.listViewSubjects.Name = "listViewSubjects";
            this.listViewSubjects.Size = new System.Drawing.Size(278, 236);
            this.listViewSubjects.TabIndex = 0;
            this.listViewSubjects.UseCompatibleStateImageBehavior = false;
            this.listViewSubjects.View = System.Windows.Forms.View.Details;
            // 
            // tabPageAudiences
            // 
            this.tabPageAudiences.Location = new System.Drawing.Point(4, 22);
            this.tabPageAudiences.Name = "tabPageAudiences";
            this.tabPageAudiences.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAudiences.Size = new System.Drawing.Size(284, 242);
            this.tabPageAudiences.TabIndex = 1;
            this.tabPageAudiences.Text = "Аудитории";
            this.tabPageAudiences.UseVisualStyleBackColor = true;
            // 
            // listViewErrors
            // 
            this.listViewErrors.BackColor = System.Drawing.Color.LightPink;
            this.listViewErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewErrors.HideSelection = false;
            this.listViewErrors.Location = new System.Drawing.Point(0, 0);
            this.listViewErrors.Name = "listViewErrors";
            this.listViewErrors.Size = new System.Drawing.Size(292, 354);
            this.listViewErrors.TabIndex = 1;
            this.listViewErrors.UseCompatibleStateImageBehavior = false;
            this.listViewErrors.View = System.Windows.Forms.View.Details;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 626);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Schedule Editor 2.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPageTeachers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewErrors;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.ListView listViewSubjects;
        private System.Windows.Forms.TabPage tabPageAudiences;
    }
}

