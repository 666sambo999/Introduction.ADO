﻿namespace Academy_PD
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
            this.tpGroups = new System.Windows.Forms.TabPage();
            this.tpSchudule = new System.Windows.Forms.TabPage();
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.cbStud = new System.Windows.Forms.ComboBox();
            this.labelDirectionStud = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.dataGridViewStud = new System.Windows.Forms.DataGridView();
            this.btnStud = new System.Windows.Forms.Button();
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
            // tpGroups
            // 
            this.tpGroups.Location = new System.Drawing.Point(4, 22);
            this.tpGroups.Name = "tpGroups";
            this.tpGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tpGroups.Size = new System.Drawing.Size(643, 424);
            this.tpGroups.TabIndex = 1;
            this.tpGroups.Text = "Группы";
            this.tpGroups.UseVisualStyleBackColor = true;
            // 
            // tpSchudule
            // 
            this.tpSchudule.Location = new System.Drawing.Point(4, 22);
            this.tpSchudule.Name = "tpSchudule";
            this.tpSchudule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchudule.Size = new System.Drawing.Size(643, 424);
            this.tpSchudule.TabIndex = 2;
            this.tpSchudule.Text = "Расписание";
            this.tpSchudule.UseVisualStyleBackColor = true;
            // 
            // tpTeacher
            // 
            this.tpTeacher.Location = new System.Drawing.Point(4, 22);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeacher.Size = new System.Drawing.Size(643, 424);
            this.tpTeacher.TabIndex = 3;
            this.tpTeacher.Text = "Преподаватели";
            this.tpTeacher.UseVisualStyleBackColor = true;
            // 
            // cbStud
            // 
            this.cbStud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStud.FormattingEnabled = true;
            this.cbStud.Location = new System.Drawing.Point(172, 59);
            this.cbStud.Name = "cbStud";
            this.cbStud.Size = new System.Drawing.Size(260, 21);
            this.cbStud.TabIndex = 0;
            // 
            // labelDirectionStud
            // 
            this.labelDirectionStud.AutoSize = true;
            this.labelDirectionStud.Location = new System.Drawing.Point(23, 59);
            this.labelDirectionStud.Name = "labelDirectionStud";
            this.labelDirectionStud.Size = new System.Drawing.Size(122, 13);
            this.labelDirectionStud.TabIndex = 1;
            this.labelDirectionStud.Text = "направление обучения";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(53, 16);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(42, 13);
            this.labelGroups.TabIndex = 2;
            this.labelGroups.Text = "Группа";
            // 
            // cbGroups
            // 
            this.cbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(172, 13);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(194, 21);
            this.cbGroups.TabIndex = 3;
            // 
            // dataGridViewStud
            // 
            this.dataGridViewStud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStud.Location = new System.Drawing.Point(7, 105);
            this.dataGridViewStud.Name = "dataGridViewStud";
            this.dataGridViewStud.Size = new System.Drawing.Size(654, 330);
            this.dataGridViewStud.TabIndex = 4;
            // 
            // btnStud
            // 
            this.btnStud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStud.Location = new System.Drawing.Point(574, 10);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(75, 23);
            this.btnStud.TabIndex = 5;
            this.btnStud.Text = "Добавить";
            this.btnStud.UseVisualStyleBackColor = true;
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
    }
}
