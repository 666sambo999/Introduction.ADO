namespace Academy_PD
{
    partial class FormMy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMy));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpStud = new System.Windows.Forms.TabPage();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStud = new System.Windows.Forms.Button();
            this.dataGridViewStud = new System.Windows.Forms.DataGridView();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.labelGroups = new System.Windows.Forms.Label();
            this.labelDirectionStud = new System.Windows.Forms.Label();
            this.cbStud = new System.Windows.Forms.ComboBox();
            this.tpGroups = new System.Windows.Forms.TabPage();
            this.tpSchudule = new System.Windows.Forms.TabPage();
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tpStud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStud)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpStud);
            this.tabControl.Controls.Add(this.tpGroups);
            this.tabControl.Controls.Add(this.tpSchudule);
            this.tabControl.Controls.Add(this.tpTeacher);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(672, 464);
            this.tabControl.TabIndex = 0;
            // 
            // tpStud
            // 
            this.tpStud.Controls.Add(this.richTextBox);
            this.tpStud.Controls.Add(this.btnSearch);
            this.tpStud.Controls.Add(this.label2);
            this.tpStud.Controls.Add(this.label1);
            this.tpStud.Controls.Add(this.btnStud);
            this.tpStud.Controls.Add(this.dataGridViewStud);
            this.tpStud.Controls.Add(this.cbGroups);
            this.tpStud.Controls.Add(this.labelGroups);
            this.tpStud.Controls.Add(this.labelDirectionStud);
            this.tpStud.Controls.Add(this.cbStud);
            this.tpStud.Location = new System.Drawing.Point(4, 22);
            this.tpStud.Name = "tpStud";
            this.tpStud.Padding = new System.Windows.Forms.Padding(3);
            this.tpStud.Size = new System.Drawing.Size(664, 438);
            this.tpStud.TabIndex = 0;
            this.tpStud.Text = "Студенты";
            this.tpStud.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(407, 13);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(168, 23);
            this.richTextBox.TabIndex = 9;
            this.richTextBox.Text = "";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(581, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество групп";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество студентов";
            // 
            // btnStud
            // 
            this.btnStud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStud.Location = new System.Drawing.Point(295, 11);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(75, 23);
            this.btnStud.TabIndex = 5;
            this.btnStud.Text = "Добавить";
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // dataGridViewStud
            // 
            this.dataGridViewStud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStud.Location = new System.Drawing.Point(7, 92);
            this.dataGridViewStud.Name = "dataGridViewStud";
            this.dataGridViewStud.Size = new System.Drawing.Size(654, 315);
            this.dataGridViewStud.TabIndex = 4;
            // 
            // cbGroups
            // 
            this.cbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(76, 13);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(194, 21);
            this.cbGroups.TabIndex = 3;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(8, 16);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(42, 13);
            this.labelGroups.TabIndex = 2;
            this.labelGroups.Text = "Группа";
            // 
            // labelDirectionStud
            // 
            this.labelDirectionStud.AutoSize = true;
            this.labelDirectionStud.Location = new System.Drawing.Point(8, 59);
            this.labelDirectionStud.Name = "labelDirectionStud";
            this.labelDirectionStud.Size = new System.Drawing.Size(122, 13);
            this.labelDirectionStud.TabIndex = 1;
            this.labelDirectionStud.Text = "направление обучения";
            this.labelDirectionStud.Click += new System.EventHandler(this.labelDirectionStud_Click);
            // 
            // cbStud
            // 
            this.cbStud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStud.FormattingEnabled = true;
            this.cbStud.Location = new System.Drawing.Point(136, 51);
            this.cbStud.Name = "cbStud";
            this.cbStud.Size = new System.Drawing.Size(258, 21);
            this.cbStud.TabIndex = 0;
            this.cbStud.SelectedIndexChanged += new System.EventHandler(this.cbStud_SelectedIndexChanged);
            // 
            // tpGroups
            // 
            this.tpGroups.Location = new System.Drawing.Point(4, 22);
            this.tpGroups.Name = "tpGroups";
            this.tpGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tpGroups.Size = new System.Drawing.Size(664, 438);
            this.tpGroups.TabIndex = 1;
            this.tpGroups.Text = "Группы";
            this.tpGroups.UseVisualStyleBackColor = true;
            // 
            // tpSchudule
            // 
            this.tpSchudule.Location = new System.Drawing.Point(4, 22);
            this.tpSchudule.Name = "tpSchudule";
            this.tpSchudule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchudule.Size = new System.Drawing.Size(664, 438);
            this.tpSchudule.TabIndex = 2;
            this.tpSchudule.Text = "Расписание";
            this.tpSchudule.UseVisualStyleBackColor = true;
            // 
            // tpTeacher
            // 
            this.tpTeacher.Location = new System.Drawing.Point(4, 22);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeacher.Size = new System.Drawing.Size(664, 438);
            this.tpTeacher.TabIndex = 3;
            this.tpTeacher.Text = "Преподаватели";
            this.tpTeacher.UseVisualStyleBackColor = true;
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 464);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMy";
            this.Text = "Academy";
            this.tabControl.ResumeLayout(false);
            this.tpStud.ResumeLayout(false);
            this.tpStud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpStud;
        private System.Windows.Forms.TabPage tpGroups;
        private System.Windows.Forms.TabPage tpSchudule;
        private System.Windows.Forms.Label labelDirectionStud;
        private System.Windows.Forms.ComboBox cbStud;
        private System.Windows.Forms.TabPage tpTeacher;
        private System.Windows.Forms.DataGridView dataGridViewStud;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

