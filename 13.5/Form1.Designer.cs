namespace _13._5
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCollection = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstSortedList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstHashtable = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.tabOperations = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBitString2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBitString1 = new System.Windows.Forms.TextBox();
            this.tabArray = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtArrayResults = new System.Windows.Forms.TextBox();
            this.btnTestArray = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCollection.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOperations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabArray.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabCollection);
            this.tabControl1.Controls.Add(this.tabOperations);
            this.tabControl1.Controls.Add(this.tabArray);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCollection
            // 
            this.tabCollection.Controls.Add(this.groupBox3);
            this.tabCollection.Controls.Add(this.groupBox1);
            this.tabCollection.Location = new System.Drawing.Point(4, 22);
            this.tabCollection.Name = "tabCollection";
            this.tabCollection.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollection.Size = new System.Drawing.Size(852, 511);
            this.tabCollection.TabIndex = 0;
            this.tabCollection.Text = "Колекції";
            this.tabCollection.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblCount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lstSortedList);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstHashtable);
            this.groupBox3.Location = new System.Drawing.Point(6, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(840, 364);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Відображення колекцій";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(6, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(142, 15);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Кількість елементів: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "SortedList (відсортований):";
            // 
            // lstSortedList
            // 
            this.lstSortedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSortedList.FormattingEnabled = true;
            this.lstSortedList.Location = new System.Drawing.Point(425, 56);
            this.lstSortedList.Name = "lstSortedList";
            this.lstSortedList.Size = new System.Drawing.Size(409, 290);
            this.lstSortedList.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hashtable:";
            // 
            // lstHashtable
            // 
            this.lstHashtable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHashtable.FormattingEnabled = true;
            this.lstHashtable.Location = new System.Drawing.Point(9, 56);
            this.lstHashtable.Name = "lstHashtable";
            this.lstHashtable.Size = new System.Drawing.Size(410, 290);
            this.lstHashtable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnShowInfo);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управління колекцією";
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(278, 90);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(100, 23);
            this.btnShowInfo.TabIndex = 7;
            this.btnShowInfo.Text = "Інформація";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(184, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистити все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(103, 90);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Бінарна стрічка (0 і 1):";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(149, 55);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(685, 20);
            this.txtValue.TabIndex = 2;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ключ:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(149, 29);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(200, 20);
            this.txtKey.TabIndex = 0;
            // 
            // tabOperations
            // 
            this.tabOperations.Controls.Add(this.groupBox2);
            this.tabOperations.Location = new System.Drawing.Point(4, 22);
            this.tabOperations.Name = "tabOperations";
            this.tabOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperations.Size = new System.Drawing.Size(852, 511);
            this.tabOperations.TabIndex = 1;
            this.tabOperations.Text = "Операції з бітовими стрічками";
            this.tabOperations.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtResults);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBitString2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBitString1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 499);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операції з бітовими стрічками";
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResults.Location = new System.Drawing.Point(6, 117);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(828, 376);
            this.txtResults.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(22, 88);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Друга бітова стрічка:";
            // 
            // txtBitString2
            // 
            this.txtBitString2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBitString2.Location = new System.Drawing.Point(149, 55);
            this.txtBitString2.Name = "txtBitString2";
            this.txtBitString2.Size = new System.Drawing.Size(685, 20);
            this.txtBitString2.TabIndex = 2;
            this.txtBitString2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBitString2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Перша бітова стрічка:";
            // 
            // txtBitString1
            // 
            this.txtBitString1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBitString1.Location = new System.Drawing.Point(149, 29);
            this.txtBitString1.Name = "txtBitString1";
            this.txtBitString1.Size = new System.Drawing.Size(685, 20);
            this.txtBitString1.TabIndex = 0;
            this.txtBitString1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBitString1_KeyPress);
            // 
            // tabArray
            // 
            this.tabArray.Controls.Add(this.groupBox4);
            this.tabArray.Location = new System.Drawing.Point(4, 22);
            this.tabArray.Name = "tabArray";
            this.tabArray.Padding = new System.Windows.Forms.Padding(3);
            this.tabArray.Size = new System.Drawing.Size(852, 511);
            this.tabArray.TabIndex = 2;
            this.tabArray.Text = "Тестування масиву";
            this.tabArray.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtArrayResults);
            this.groupBox4.Controls.Add(this.btnTestArray);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(840, 499);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тестування масиву об'єктів";
            // 
            // txtArrayResults
            // 
            this.txtArrayResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArrayResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArrayResults.Location = new System.Drawing.Point(6, 52);
            this.txtArrayResults.Multiline = true;
            this.txtArrayResults.Name = "txtArrayResults";
            this.txtArrayResults.ReadOnly = true;
            this.txtArrayResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArrayResults.Size = new System.Drawing.Size(828, 441);
            this.txtArrayResults.TabIndex = 1;
            // 
            // btnTestArray
            // 
            this.btnTestArray.Location = new System.Drawing.Point(6, 19);
            this.btnTestArray.Name = "btnTestArray";
            this.btnTestArray.Size = new System.Drawing.Size(150, 27);
            this.btnTestArray.TabIndex = 0;
            this.btnTestArray.Text = "Тестувати масив";
            this.btnTestArray.UseVisualStyleBackColor = true;
            this.btnTestArray.Click += new System.EventHandler(this.btnTestArray_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 559);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Статус: Готово";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бітові стрічки - Управління колекціями";
            this.tabControl1.ResumeLayout(false);
            this.tabCollection.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOperations.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabArray.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCollection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstSortedList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstHashtable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TabPage tabOperations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBitString2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBitString1;
        private System.Windows.Forms.TabPage tabArray;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtArrayResults;
        private System.Windows.Forms.Button btnTestArray;
        private System.Windows.Forms.Label lblStatus;
    }
}