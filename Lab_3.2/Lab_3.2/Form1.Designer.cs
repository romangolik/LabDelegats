namespace Lab_3._2
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
            this.SetOpacity = new System.Windows.Forms.Button();
            this.SetBackgroundColor = new System.Windows.Forms.Button();
            this.btnSayHelloWorld = new System.Windows.Forms.Button();
            this.btnSetOfActions = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SetOpacity
            // 
            this.SetOpacity.Location = new System.Drawing.Point(12, 12);
            this.SetOpacity.Name = "SetOpacity";
            this.SetOpacity.Size = new System.Drawing.Size(110, 32);
            this.SetOpacity.TabIndex = 0;
            this.SetOpacity.Text = "Прозорість";
            this.SetOpacity.UseVisualStyleBackColor = true;
            this.SetOpacity.Click += new System.EventHandler(this.SetOpacity_Click);
            // 
            // SetBackgroundColor
            // 
            this.SetBackgroundColor.Location = new System.Drawing.Point(128, 12);
            this.SetBackgroundColor.Name = "SetBackgroundColor";
            this.SetBackgroundColor.Size = new System.Drawing.Size(92, 32);
            this.SetBackgroundColor.TabIndex = 1;
            this.SetBackgroundColor.Text = "Колір тла";
            this.SetBackgroundColor.UseVisualStyleBackColor = true;
            this.SetBackgroundColor.Click += new System.EventHandler(this.SetBackgroundColor_Click);
            // 
            // btnSayHelloWorld
            // 
            this.btnSayHelloWorld.Location = new System.Drawing.Point(226, 12);
            this.btnSayHelloWorld.Name = "btnSayHelloWorld";
            this.btnSayHelloWorld.Size = new System.Drawing.Size(93, 32);
            this.btnSayHelloWorld.TabIndex = 2;
            this.btnSayHelloWorld.Text = "Hello World";
            this.btnSayHelloWorld.UseVisualStyleBackColor = true;
            this.btnSayHelloWorld.Click += new System.EventHandler(this.btnSayHelloWorld_Click);
            // 
            // btnSetOfActions
            // 
            this.btnSetOfActions.Location = new System.Drawing.Point(12, 50);
            this.btnSetOfActions.Name = "btnSetOfActions";
            this.btnSetOfActions.Size = new System.Drawing.Size(307, 31);
            this.btnSetOfActions.TabIndex = 3;
            this.btnSetOfActions.Text = "супермегакнопка";
            this.btnSetOfActions.UseVisualStyleBackColor = true;
            this.btnSetOfActions.Click += new System.EventHandler(this.btnSetOfActions_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(305, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "\"супермегакнопка\" поглинає \"Прозорість\"";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 134);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(295, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "\"супермегакнопка\" поглинає \"Колір тла\"";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(305, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "\"супермегакнопка\" поглинає \"Hello World\"";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(403, 357);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSetOfActions);
            this.Controls.Add(this.btnSayHelloWorld);
            this.Controls.Add(this.SetBackgroundColor);
            this.Controls.Add(this.SetOpacity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetOpacity;
        private System.Windows.Forms.Button SetBackgroundColor;
        private System.Windows.Forms.Button btnSayHelloWorld;
        private System.Windows.Forms.Button btnSetOfActions;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

