namespace lab04
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMake = new System.Windows.Forms.Button();
            this.tbxEps = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxClusterCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearPoints = new System.Windows.Forms.Button();
            this.btnDelPoints = new System.Windows.Forms.Button();
            this.lbxPoints = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnMake);
            this.panel1.Controls.Add(this.tbxEps);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxClusterCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClearPoints);
            this.panel1.Controls.Add(this.btnDelPoints);
            this.panel1.Controls.Add(this.lbxPoints);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(483, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 456);
            this.panel1.TabIndex = 0;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(8, 292);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(200, 23);
            this.btnMake.TabIndex = 8;
            this.btnMake.Text = "Запилить";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // tbxEps
            // 
            this.tbxEps.Location = new System.Drawing.Point(133, 257);
            this.tbxEps.Name = "tbxEps";
            this.tbxEps.Size = new System.Drawing.Size(75, 20);
            this.tbxEps.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Погрешность";
            // 
            // tbxClusterCount
            // 
            this.tbxClusterCount.Location = new System.Drawing.Point(133, 227);
            this.tbxClusterCount.Name = "tbxClusterCount";
            this.tbxClusterCount.Size = new System.Drawing.Size(75, 20);
            this.tbxClusterCount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество кластеров";
            // 
            // btnClearPoints
            // 
            this.btnClearPoints.Location = new System.Drawing.Point(110, 191);
            this.btnClearPoints.Name = "btnClearPoints";
            this.btnClearPoints.Size = new System.Drawing.Size(98, 23);
            this.btnClearPoints.TabIndex = 3;
            this.btnClearPoints.Text = "Очистить";
            this.btnClearPoints.UseVisualStyleBackColor = true;
            this.btnClearPoints.Click += new System.EventHandler(this.btnClearPoints_Click);
            // 
            // btnDelPoints
            // 
            this.btnDelPoints.Location = new System.Drawing.Point(6, 191);
            this.btnDelPoints.Name = "btnDelPoints";
            this.btnDelPoints.Size = new System.Drawing.Size(98, 23);
            this.btnDelPoints.TabIndex = 2;
            this.btnDelPoints.Text = "Удалить";
            this.btnDelPoints.UseVisualStyleBackColor = true;
            this.btnDelPoints.Click += new System.EventHandler(this.btnDelPoints_Click);
            // 
            // lbxPoints
            // 
            this.lbxPoints.FormattingEnabled = true;
            this.lbxPoints.Location = new System.Drawing.Point(6, 25);
            this.lbxPoints.Name = "lbxPoints";
            this.lbxPoints.Size = new System.Drawing.Size(202, 160);
            this.lbxPoints.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Точки";
            // 
            // pbxMain
            // 
            this.pbxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMain.Location = new System.Drawing.Point(0, 0);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(477, 456);
            this.pbxMain.TabIndex = 1;
            this.pbxMain.TabStop = false;
            this.pbxMain.SizeChanged += new System.EventHandler(this.pbxMain_SizeChanged);
            this.pbxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Лаболаторная работа №4. Метод К-средних";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxClusterCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearPoints;
        private System.Windows.Forms.Button btnDelPoints;
        private System.Windows.Forms.ListBox lbxPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox tbxEps;
        private System.Windows.Forms.Label label3;
    }
}

