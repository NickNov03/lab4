namespace RGBColorControl
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.myTextControl3 = new RGBColorControl.MyTextControl();
            this.myTextControl2 = new RGBColorControl.MyTextControl();
            this.myTextControl1 = new RGBColorControl.MyTextControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(423, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 178);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(60, 263);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dec";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(227, 263);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hex";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // myTextControl3
            // 
            this.myTextControl3.Channel = RGBColorControl.MyTextControl.ColorChannel.Red;
            this.myTextControl3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.myTextControl3.Location = new System.Drawing.Point(139, 197);
            this.myTextControl3.Margin = new System.Windows.Forms.Padding(4);
            this.myTextControl3.Mode = RGBColorControl.MyTextControl.InputMode.Decimal;
            this.myTextControl3.Name = "myTextControl3";
            this.myTextControl3.Size = new System.Drawing.Size(196, 22);
            this.myTextControl3.TabIndex = 11;
            this.myTextControl3.Text = "0";
            this.myTextControl3.TextChanged += new System.EventHandler(this.myTextControl3_TextChanged);
            this.myTextControl3.Leave += new System.EventHandler(this.myTextControl3_TextChanged);
            // 
            // myTextControl2
            // 
            this.myTextControl2.Channel = RGBColorControl.MyTextControl.ColorChannel.Red;
            this.myTextControl2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.myTextControl2.Location = new System.Drawing.Point(139, 116);
            this.myTextControl2.Margin = new System.Windows.Forms.Padding(4);
            this.myTextControl2.Mode = RGBColorControl.MyTextControl.InputMode.Decimal;
            this.myTextControl2.Name = "myTextControl2";
            this.myTextControl2.Size = new System.Drawing.Size(196, 22);
            this.myTextControl2.TabIndex = 10;
            this.myTextControl2.Text = "0";
            this.myTextControl2.TextChanged += new System.EventHandler(this.myTextControl2_TextChanged);
            this.myTextControl2.Leave += new System.EventHandler(this.myTextControl2_TextChanged);
            // 
            // myTextControl1
            // 
            this.myTextControl1.Channel = RGBColorControl.MyTextControl.ColorChannel.Red;
            this.myTextControl1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.myTextControl1.Location = new System.Drawing.Point(139, 43);
            this.myTextControl1.Margin = new System.Windows.Forms.Padding(4);
            this.myTextControl1.Mode = RGBColorControl.MyTextControl.InputMode.Decimal;
            this.myTextControl1.Name = "myTextControl1";
            this.myTextControl1.Size = new System.Drawing.Size(196, 22);
            this.myTextControl1.TabIndex = 9;
            this.myTextControl1.Text = "0";
            this.myTextControl1.TextChanged += new System.EventHandler(this.myTextControl1_TextChanged);
            this.myTextControl1.Leave += new System.EventHandler(this.myTextControl1_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myTextControl3);
            this.Controls.Add(this.myTextControl2);
            this.Controls.Add(this.myTextControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(723, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private MyTextControl myTextControl1;
        private MyTextControl myTextControl2;
        private MyTextControl myTextControl3;
    }
}
