namespace Academy_PD
{
    partial class FormStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStud));
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.richTextBoxLast = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFirst = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMiddle = new System.Windows.Forms.RichTextBox();
            this.lbBirth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDirection = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.richTextBoxDirection = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGroup = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelContact = new System.Windows.Forms.Label();
            this.richTextBoxContact = new System.Windows.Forms.RichTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancal = new System.Windows.Forms.Button();
            this.btnBrauw = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBoxStud = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStud)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(28, 38);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(29, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "Имя";
            this.lbFirstName.Click += new System.EventHandler(this.lbFirstName_Click);
            // 
            // lbMiddleName
            // 
            this.lbMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMiddleName.AutoSize = true;
            this.lbMiddleName.Location = new System.Drawing.Point(29, 69);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(54, 13);
            this.lbMiddleName.TabIndex = 2;
            this.lbMiddleName.Text = "Отчество";
            this.lbMiddleName.Click += new System.EventHandler(this.lbMiddleName_Click);
            // 
            // lbLastName
            // 
            this.lbLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(24, 7);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Фамилия";
            // 
            // richTextBoxLast
            // 
            this.richTextBoxLast.Location = new System.Drawing.Point(145, 3);
            this.richTextBoxLast.MaxLength = 256;
            this.richTextBoxLast.Multiline = false;
            this.richTextBoxLast.Name = "richTextBoxLast";
            this.richTextBoxLast.Size = new System.Drawing.Size(206, 19);
            this.richTextBoxLast.TabIndex = 3;
            this.richTextBoxLast.Text = "";
            // 
            // richTextBoxFirst
            // 
            this.richTextBoxFirst.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.richTextBoxFirst.Location = new System.Drawing.Point(146, 33);
            this.richTextBoxFirst.MaxLength = 256;
            this.richTextBoxFirst.Multiline = false;
            this.richTextBoxFirst.Name = "richTextBoxFirst";
            this.richTextBoxFirst.Size = new System.Drawing.Size(205, 22);
            this.richTextBoxFirst.TabIndex = 4;
            this.richTextBoxFirst.Text = "";
            // 
            // richTextBoxMiddle
            // 
            this.richTextBoxMiddle.Location = new System.Drawing.Point(145, 63);
            this.richTextBoxMiddle.MaxLength = 256;
            this.richTextBoxMiddle.Multiline = false;
            this.richTextBoxMiddle.Name = "richTextBoxMiddle";
            this.richTextBoxMiddle.Size = new System.Drawing.Size(206, 22);
            this.richTextBoxMiddle.TabIndex = 5;
            this.richTextBoxMiddle.Text = "";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(28, 96);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(86, 13);
            this.lbBirth.TabIndex = 6;
            this.lbBirth.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.89218F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.10782F));
            this.tableLayoutPanel.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.richTextBoxFirst, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lbMiddleName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lbFirstName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbBirth, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.richTextBoxMiddle, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.richTextBoxLast, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lbLastName, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 10);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.77778F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(361, 122);
            this.tableLayoutPanel.TabIndex = 8;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.67403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.32597F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxGroup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxDirection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDirection, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 220);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 57);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lbDirection
            // 
            this.lbDirection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbDirection.AutoSize = true;
            this.lbDirection.Location = new System.Drawing.Point(3, 7);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(122, 13);
            this.lbDirection.TabIndex = 10;
            this.lbDirection.Text = "направление обучения";
            // 
            // lbGroup
            // 
            this.lbGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGroup.AutoSize = true;
            this.lbGroup.Location = new System.Drawing.Point(49, 36);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(42, 13);
            this.lbGroup.TabIndex = 10;
            this.lbGroup.Text = "Группа";
            // 
            // richTextBoxDirection
            // 
            this.richTextBoxDirection.Location = new System.Drawing.Point(143, 3);
            this.richTextBoxDirection.Name = "richTextBoxDirection";
            this.richTextBoxDirection.Size = new System.Drawing.Size(208, 22);
            this.richTextBoxDirection.TabIndex = 10;
            this.richTextBoxDirection.Text = "";
            // 
            // richTextBoxGroup
            // 
            this.richTextBoxGroup.Location = new System.Drawing.Point(143, 31);
            this.richTextBoxGroup.Name = "richTextBoxGroup";
            this.richTextBoxGroup.Size = new System.Drawing.Size(208, 23);
            this.richTextBoxGroup.TabIndex = 10;
            this.richTextBoxGroup.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.95028F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.04972F));
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxEmail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxContact, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelContact, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelEmail, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 151);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 62);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(42, 9);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(56, 13);
            this.labelContact.TabIndex = 11;
            this.labelContact.Text = "Контакты";
            // 
            // richTextBoxContact
            // 
            this.richTextBoxContact.Location = new System.Drawing.Point(144, 3);
            this.richTextBoxContact.MaxLength = 20;
            this.richTextBoxContact.Name = "richTextBoxContact";
            this.richTextBoxContact.Size = new System.Drawing.Size(207, 24);
            this.richTextBoxContact.TabIndex = 11;
            this.richTextBoxContact.Text = "";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(54, 40);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email";
            // 
            // richTextBoxEmail
            // 
            this.richTextBoxEmail.Location = new System.Drawing.Point(144, 34);
            this.richTextBoxEmail.MaxLength = 25;
            this.richTextBoxEmail.Name = "richTextBoxEmail";
            this.richTextBoxEmail.Size = new System.Drawing.Size(207, 25);
            this.richTextBoxEmail.TabIndex = 11;
            this.richTextBoxEmail.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(388, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancal
            // 
            this.btnCancal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancal.Location = new System.Drawing.Point(505, 256);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(75, 23);
            this.btnCancal.TabIndex = 13;
            this.btnCancal.Text = "отмена";
            this.btnCancal.UseVisualStyleBackColor = true;
            // 
            // btnBrauw
            // 
            this.btnBrauw.Location = new System.Drawing.Point(505, 224);
            this.btnBrauw.Name = "btnBrauw";
            this.btnBrauw.Size = new System.Drawing.Size(75, 23);
            this.btnBrauw.TabIndex = 14;
            this.btnBrauw.Text = "обзор";
            this.btnBrauw.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // pictureBoxStud
            // 
            this.pictureBoxStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxStud.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStud.Image")));
            this.pictureBoxStud.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStud.InitialImage")));
            this.pictureBoxStud.Location = new System.Drawing.Point(388, 13);
            this.pictureBoxStud.Name = "pictureBoxStud";
            this.pictureBoxStud.Size = new System.Drawing.Size(192, 191);
            this.pictureBoxStud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStud.TabIndex = 16;
            this.pictureBoxStud.TabStop = false;
            // 
            // FormStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 320);
            this.Controls.Add(this.pictureBoxStud);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBrauw);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStud";
            this.Text = "Добавление студента";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbMiddleName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.RichTextBox richTextBoxLast;
        private System.Windows.Forms.RichTextBox richTextBoxFirst;
        private System.Windows.Forms.RichTextBox richTextBoxMiddle;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbDirection;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.RichTextBox richTextBoxGroup;
        private System.Windows.Forms.RichTextBox richTextBoxDirection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox richTextBoxContact;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.RichTextBox richTextBoxEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancal;
        private System.Windows.Forms.Button btnBrauw;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBoxStud;
    }
}