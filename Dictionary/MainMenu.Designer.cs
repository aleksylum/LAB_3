namespace LabDictionary
{
    partial class MainMenu
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
			this.bAdd = new System.Windows.Forms.Button();
			this.bRemove = new System.Windows.Forms.Button();
			this.bShow = new System.Windows.Forms.Button();
			this.bStat = new System.Windows.Forms.Button();
			this.bClear = new System.Windows.Forms.Button();
			this.bFind = new System.Windows.Forms.Button();
			this.tbFind = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDel = new System.Windows.Forms.TextBox();
			this.bBSer = new System.Windows.Forms.Button();
			this.bXMLS = new System.Windows.Forms.Button();
			this.bBDS = new System.Windows.Forms.Button();
			this.bXmlDS = new System.Windows.Forms.Button();
			this.bTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bAdd
			// 
			this.bAdd.Location = new System.Drawing.Point(3, 248);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(206, 23);
			this.bAdd.TabIndex = 0;
			this.bAdd.Text = "Добавить слово";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bRemove
			// 
			this.bRemove.Location = new System.Drawing.Point(115, 361);
			this.bRemove.Name = "bRemove";
			this.bRemove.Size = new System.Drawing.Size(94, 23);
			this.bRemove.TabIndex = 1;
			this.bRemove.Text = "Удалить слово";
			this.bRemove.UseVisualStyleBackColor = true;
			this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
			// 
			// bShow
			// 
			this.bShow.Location = new System.Drawing.Point(3, 277);
			this.bShow.Name = "bShow";
			this.bShow.Size = new System.Drawing.Size(206, 23);
			this.bShow.TabIndex = 2;
			this.bShow.Text = "Просмотр словаря";
			this.bShow.UseVisualStyleBackColor = true;
			this.bShow.Click += new System.EventHandler(this.bShow_Click);
			// 
			// bStat
			// 
			this.bStat.Location = new System.Drawing.Point(3, 306);
			this.bStat.Name = "bStat";
			this.bStat.Size = new System.Drawing.Size(206, 23);
			this.bStat.TabIndex = 3;
			this.bStat.Text = "Статистика";
			this.bStat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bStat.UseVisualStyleBackColor = false;
			this.bStat.Click += new System.EventHandler(this.bStat_Click);
			// 
			// bClear
			// 
			this.bClear.Location = new System.Drawing.Point(3, 335);
			this.bClear.Name = "bClear";
			this.bClear.Size = new System.Drawing.Size(206, 23);
			this.bClear.TabIndex = 4;
			this.bClear.Text = "Очистка словаря";
			this.bClear.UseVisualStyleBackColor = true;
			this.bClear.Click += new System.EventHandler(this.bClear_Click);
			// 
			// bFind
			// 
			this.bFind.Location = new System.Drawing.Point(134, 10);
			this.bFind.Name = "bFind";
			this.bFind.Size = new System.Drawing.Size(75, 23);
			this.bFind.TabIndex = 5;
			this.bFind.Text = "найти!";
			this.bFind.UseVisualStyleBackColor = true;
			this.bFind.Click += new System.EventHandler(this.bFind_Click);
			// 
			// tbFind
			// 
			this.tbFind.Location = new System.Drawing.Point(3, 12);
			this.tbFind.Name = "tbFind";
			this.tbFind.Size = new System.Drawing.Size(121, 20);
			this.tbFind.TabIndex = 6;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(3, 38);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(206, 204);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 560);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 8;
			// 
			// tbDel
			// 
			this.tbDel.Location = new System.Drawing.Point(3, 363);
			this.tbDel.Name = "tbDel";
			this.tbDel.Size = new System.Drawing.Size(96, 20);
			this.tbDel.TabIndex = 9;
			// 
			// bBSer
			// 
			this.bBSer.Location = new System.Drawing.Point(3, 389);
			this.bBSer.Name = "bBSer";
			this.bBSer.Size = new System.Drawing.Size(206, 23);
			this.bBSer.TabIndex = 10;
			this.bBSer.Text = "Бинарная сериализация";
			this.bBSer.UseVisualStyleBackColor = true;
			this.bBSer.Click += new System.EventHandler(this.bBSer_Click);
			// 
			// bXMLS
			// 
			this.bXMLS.Location = new System.Drawing.Point(3, 447);
			this.bXMLS.Name = "bXMLS";
			this.bXMLS.Size = new System.Drawing.Size(206, 23);
			this.bXMLS.TabIndex = 11;
			this.bXMLS.Text = "XML сериализация";
			this.bXMLS.UseVisualStyleBackColor = true;
			this.bXMLS.Click += new System.EventHandler(this.bXMLS_Click);
			// 
			// bBDS
			// 
			this.bBDS.Location = new System.Drawing.Point(3, 418);
			this.bBDS.Name = "bBDS";
			this.bBDS.Size = new System.Drawing.Size(206, 23);
			this.bBDS.TabIndex = 12;
			this.bBDS.Text = "Бинарная десериализация";
			this.bBDS.UseVisualStyleBackColor = true;
			this.bBDS.Click += new System.EventHandler(this.bBDS_Click);
			// 
			// bXmlDS
			// 
			this.bXmlDS.Location = new System.Drawing.Point(3, 476);
			this.bXmlDS.Name = "bXmlDS";
			this.bXmlDS.Size = new System.Drawing.Size(206, 23);
			this.bXmlDS.TabIndex = 13;
			this.bXmlDS.Text = "XML десериализация";
			this.bXmlDS.UseVisualStyleBackColor = true;
			this.bXmlDS.Click += new System.EventHandler(this.bXmlDS_Click);
			// 
			// bTest
			// 
			this.bTest.Location = new System.Drawing.Point(3, 519);
			this.bTest.Name = "bTest";
			this.bTest.Size = new System.Drawing.Size(206, 25);
			this.bTest.TabIndex = 14;
			this.bTest.Text = "Пройти тест";
			this.bTest.UseVisualStyleBackColor = true;
			this.bTest.Click += new System.EventHandler(this.bTest_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(221, 582);
			this.Controls.Add(this.bTest);
			this.Controls.Add(this.bXmlDS);
			this.Controls.Add(this.bBDS);
			this.Controls.Add(this.bXMLS);
			this.Controls.Add(this.bBSer);
			this.Controls.Add(this.tbDel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.tbFind);
			this.Controls.Add(this.bFind);
			this.Controls.Add(this.bClear);
			this.Controls.Add(this.bStat);
			this.Controls.Add(this.bShow);
			this.Controls.Add(this.bRemove);
			this.Controls.Add(this.bAdd);
			this.MinimumSize = new System.Drawing.Size(230, 500);
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dictionary";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bStat;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDel;
        private System.Windows.Forms.Button bBSer;
        private System.Windows.Forms.Button bXMLS;
        private System.Windows.Forms.Button bBDS;
        private System.Windows.Forms.Button bXmlDS;
		private System.Windows.Forms.Button bTest;
	}
}

