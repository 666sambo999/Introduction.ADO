namespace Police_base
{
    partial class Police
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Police));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageViolation = new System.Windows.Forms.TabPage();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.cbViolation = new System.Windows.Forms.ComboBox();
            this.dataGridViolation = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPageViolation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViolation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageViolation);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(704, 445);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageViolation
            // 
            this.tabPageViolation.Controls.Add(this.btnAlter);
            this.tabPageViolation.Controls.Add(this.btnAdd);
            this.tabPageViolation.Controls.Add(this.label);
            this.tabPageViolation.Controls.Add(this.cbViolation);
            this.tabPageViolation.Controls.Add(this.dataGridViolation);
            this.tabPageViolation.Location = new System.Drawing.Point(4, 22);
            this.tabPageViolation.Name = "tabPageViolation";
            this.tabPageViolation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViolation.Size = new System.Drawing.Size(696, 419);
            this.tabPageViolation.TabIndex = 0;
            this.tabPageViolation.Text = "Violation";
            this.tabPageViolation.UseVisualStyleBackColor = true;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(521, 8);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "изменить";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(612, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Тип нарушения";
            // 
            // cbViolation
            // 
            this.cbViolation.FormattingEnabled = true;
            this.cbViolation.Location = new System.Drawing.Point(119, 10);
            this.cbViolation.Name = "cbViolation";
            this.cbViolation.Size = new System.Drawing.Size(386, 21);
            this.cbViolation.TabIndex = 1;
            this.cbViolation.SelectedIndexChanged += new System.EventHandler(this.cbViolation_SelectedIndexChanged);
            // 
            // dataGridViolation
            // 
            this.dataGridViolation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViolation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViolation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViolation.Location = new System.Drawing.Point(7, 46);
            this.dataGridViolation.Name = "dataGridViolation";
            this.dataGridViolation.Size = new System.Drawing.Size(680, 362);
            this.dataGridViolation.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Police
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 445);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Police";
            this.Text = "Police";
            this.tabControl.ResumeLayout(false);
            this.tabPageViolation.ResumeLayout(false);
            this.tabPageViolation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViolation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageViolation;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViolation;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbViolation;
    }
}

