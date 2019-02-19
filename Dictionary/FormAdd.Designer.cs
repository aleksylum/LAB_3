namespace LabDictionary
{
    partial class FormAdd
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
			this.bSaveAll = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.bAddVar = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// bSaveAll
			// 
			this.bSaveAll.Location = new System.Drawing.Point(3, 176);
			this.bSaveAll.Name = "bSaveAll";
			this.bSaveAll.Size = new System.Drawing.Size(273, 23);
			this.bSaveAll.TabIndex = 0;
			this.bSaveAll.Text = "Сохранить всё";
			this.bSaveAll.UseVisualStyleBackColor = true;
			this.bSaveAll.Click += new System.EventHandler(this.bSaveAll_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(115, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(317, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// bAddVar
			// 
			this.bAddVar.Location = new System.Drawing.Point(3, 216);
			this.bAddVar.Name = "bAddVar";
			this.bAddVar.Size = new System.Drawing.Size(273, 23);
			this.bAddVar.TabIndex = 2;
			this.bAddVar.Text = "Добавить вариант перевода";
			this.bAddVar.UseVisualStyleBackColor = true;
			this.bAddVar.Click += new System.EventHandler(this.bAddVar_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(115, 66);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(317, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Введите слово:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Введите перевод:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Введите часть речи:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Noun ",
            "Verb",
            "Adjective",
            "Numeral",
            "Pronoun ",
            "Adverb",
            "Article ",
            "Preposition",
            "Conjunction ",
            "Interjection  "});
			this.comboBox1.Location = new System.Drawing.Point(115, 121);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(317, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// FormAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 248);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.bAddVar);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.bSaveAll);
			this.Name = "FormAdd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление слова";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSaveAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bAddVar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}