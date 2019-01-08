namespace Pysslaformer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SwitchSize = new System.Windows.Forms.Button();
            this.ToTray = new System.Windows.Forms.Button();
            this.SetColors = new System.Windows.Forms.Button();
            this.SetSize = new System.Windows.Forms.Button();
            this.xDelta = new System.Windows.Forms.NumericUpDown();
            this.yDelta = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.xDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pysslaformer";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Location = new System.Drawing.Point(638, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 25);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SwitchSize
            // 
            this.SwitchSize.BackColor = System.Drawing.Color.Yellow;
            this.SwitchSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SwitchSize.Location = new System.Drawing.Point(605, 12);
            this.SwitchSize.Name = "SwitchSize";
            this.SwitchSize.Size = new System.Drawing.Size(27, 25);
            this.SwitchSize.TabIndex = 2;
            this.SwitchSize.UseVisualStyleBackColor = false;
            this.SwitchSize.Click += new System.EventHandler(this.SwitchSize_Click);
            // 
            // ToTray
            // 
            this.ToTray.BackColor = System.Drawing.Color.Lime;
            this.ToTray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToTray.Location = new System.Drawing.Point(572, 12);
            this.ToTray.Name = "ToTray";
            this.ToTray.Size = new System.Drawing.Size(27, 25);
            this.ToTray.TabIndex = 3;
            this.ToTray.UseVisualStyleBackColor = false;
            this.ToTray.Click += new System.EventHandler(this.ToTray_Click);
            // 
            // SetColors
            // 
            this.SetColors.Location = new System.Drawing.Point(17, 62);
            this.SetColors.Name = "SetColors";
            this.SetColors.Size = new System.Drawing.Size(113, 36);
            this.SetColors.TabIndex = 4;
            this.SetColors.Text = "Set 2 colors";
            this.SetColors.UseVisualStyleBackColor = true;
            this.SetColors.Click += new System.EventHandler(this.SetColors_Click);
            // 
            // SetSize
            // 
            this.SetSize.Location = new System.Drawing.Point(17, 134);
            this.SetSize.Name = "SetSize";
            this.SetSize.Size = new System.Drawing.Size(113, 36);
            this.SetSize.TabIndex = 5;
            this.SetSize.Text = "Set size";
            this.SetSize.UseVisualStyleBackColor = true;
            this.SetSize.Click += new System.EventHandler(this.SetSize_Click);
            // 
            // xDelta
            // 
            this.xDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xDelta.Location = new System.Drawing.Point(77, 104);
            this.xDelta.Name = "xDelta";
            this.xDelta.Size = new System.Drawing.Size(53, 24);
            this.xDelta.TabIndex = 6;
            // 
            // yDelta
            // 
            this.yDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yDelta.Location = new System.Drawing.Point(17, 104);
            this.yDelta.Name = "yDelta";
            this.yDelta.Size = new System.Drawing.Size(53, 24);
            this.yDelta.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Edit ForeColor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(127, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "beta 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save As";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 596);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yDelta);
            this.Controls.Add(this.xDelta);
            this.Controls.Add(this.SetSize);
            this.Controls.Add(this.SetColors);
            this.Controls.Add(this.ToTray);
            this.Controls.Add(this.SwitchSize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.xDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SwitchSize;
        private System.Windows.Forms.Button ToTray;
        private System.Windows.Forms.Button SetColors;
        private System.Windows.Forms.Button SetSize;
        private System.Windows.Forms.NumericUpDown xDelta;
        private System.Windows.Forms.NumericUpDown yDelta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog sd;
    }
}

