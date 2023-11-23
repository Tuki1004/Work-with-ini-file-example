namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.bWork = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOther = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Секция \"SettingForm\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Высота";
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(63, 34);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(162, 20);
            this.numHeight.TabIndex = 4;
            this.numHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(63, 60);
            this.numWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(162, 20);
            this.numWidth.TabIndex = 5;
            this.numWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // bWork
            // 
            this.bWork.Location = new System.Drawing.Point(231, 35);
            this.bWork.Name = "bWork";
            this.bWork.Size = new System.Drawing.Size(115, 40);
            this.bWork.TabIndex = 6;
            this.bWork.Text = "Применить";
            this.bWork.UseVisualStyleBackColor = true;
            this.bWork.Click += new System.EventHandler(this.bWork_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Секция \"Othrt\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Text ";
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(39, 118);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(307, 20);
            this.tbOther.TabIndex = 9;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(15, 144);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(157, 44);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(188, 144);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(158, 44);
            this.bLoad.TabIndex = 11;
            this.bLoad.Text = "Загрузить ";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 327);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbOther);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bWork);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Button bWork;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOther;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
    }
}

