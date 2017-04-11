namespace oop2._4
{
    partial class FormStore
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCountCash = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxStore = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStore)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonRun);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownCountCash);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 52);
            this.panel1.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(362, 11);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(77, 24);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(252, 11);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(77, 24);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count:";
            this.label1.UseMnemonic = false;
            // 
            // numericUpDownCountCash
            // 
            this.numericUpDownCountCash.Location = new System.Drawing.Point(77, 14);
            this.numericUpDownCountCash.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownCountCash.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCountCash.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountCash.Name = "numericUpDownCountCash";
            this.numericUpDownCountCash.Size = new System.Drawing.Size(140, 22);
            this.numericUpDownCountCash.TabIndex = 0;
            this.numericUpDownCountCash.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBoxStore
            // 
            this.pictureBoxStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStore.Location = new System.Drawing.Point(0, 52);
            this.pictureBoxStore.Name = "pictureBoxStore";
            this.pictureBoxStore.Size = new System.Drawing.Size(885, 548);
            this.pictureBoxStore.TabIndex = 1;
            this.pictureBoxStore.TabStop = false;
            this.pictureBoxStore.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxStore_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 601);
            this.Controls.Add(this.pictureBoxStore);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStore";
            this.Text = "Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStore_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCountCash;
        private System.Windows.Forms.PictureBox pictureBoxStore;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
    }
}

