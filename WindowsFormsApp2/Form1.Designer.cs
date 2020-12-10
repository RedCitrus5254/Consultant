namespace WindowsFormsApp2
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
            this.OutputDirTextBox = new System.Windows.Forms.TextBox();
            this.OutputDirLabel = new System.Windows.Forms.Label();
            this.InputFilesLabel = new System.Windows.Forms.Label();
            this.AddFilePathControlButton = new System.Windows.Forms.Button();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.CreateOutputDirCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OutputDirTextBox
            // 
            this.OutputDirTextBox.Enabled = false;
            this.OutputDirTextBox.Location = new System.Drawing.Point(149, 49);
            this.OutputDirTextBox.Name = "OutputDirTextBox";
            this.OutputDirTextBox.Size = new System.Drawing.Size(266, 20);
            this.OutputDirTextBox.TabIndex = 0;
            this.OutputDirTextBox.Text = "C:\\ConsultantFiles\\output";
            // 
            // OutputDirLabel
            // 
            this.OutputDirLabel.AutoSize = true;
            this.OutputDirLabel.Location = new System.Drawing.Point(26, 52);
            this.OutputDirLabel.Name = "OutputDirLabel";
            this.OutputDirLabel.Size = new System.Drawing.Size(117, 13);
            this.OutputDirLabel.TabIndex = 1;
            this.OutputDirLabel.Text = "Конечная директория";
            // 
            // InputFilesLabel
            // 
            this.InputFilesLabel.AutoSize = true;
            this.InputFilesLabel.Location = new System.Drawing.Point(26, 88);
            this.InputFilesLabel.Name = "InputFilesLabel";
            this.InputFilesLabel.Size = new System.Drawing.Size(47, 13);
            this.InputFilesLabel.TabIndex = 2;
            this.InputFilesLabel.Text = "Файлы:";
            // 
            // AddFilePathControlButton
            // 
            this.AddFilePathControlButton.Location = new System.Drawing.Point(101, 77);
            this.AddFilePathControlButton.Name = "AddFilePathControlButton";
            this.AddFilePathControlButton.Size = new System.Drawing.Size(26, 24);
            this.AddFilePathControlButton.TabIndex = 3;
            this.AddFilePathControlButton.Text = "+";
            this.AddFilePathControlButton.UseVisualStyleBackColor = true;
            this.AddFilePathControlButton.Click += new System.EventHandler(this.AddFilePathControlButton_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.Location = new System.Drawing.Point(476, 345);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(96, 27);
            this.AddDataButton.TabIndex = 4;
            this.AddDataButton.Text = "Добавить дату";
            this.AddDataButton.UseVisualStyleBackColor = true;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // CreateOutputDirCheckBox
            // 
            this.CreateOutputDirCheckBox.AutoSize = true;
            this.CreateOutputDirCheckBox.Location = new System.Drawing.Point(29, 32);
            this.CreateOutputDirCheckBox.Name = "CreateOutputDirCheckBox";
            this.CreateOutputDirCheckBox.Size = new System.Drawing.Size(177, 17);
            this.CreateOutputDirCheckBox.TabIndex = 5;
            this.CreateOutputDirCheckBox.Text = "Задать конечную директорию";
            this.CreateOutputDirCheckBox.UseVisualStyleBackColor = true;
            this.CreateOutputDirCheckBox.CheckedChanged += new System.EventHandler(this.CreateOutputDirCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 384);
            this.Controls.Add(this.CreateOutputDirCheckBox);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.AddFilePathControlButton);
            this.Controls.Add(this.InputFilesLabel);
            this.Controls.Add(this.OutputDirLabel);
            this.Controls.Add(this.OutputDirTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputDirTextBox;
        private System.Windows.Forms.Label OutputDirLabel;
        private System.Windows.Forms.Label InputFilesLabel;
        private System.Windows.Forms.Button AddFilePathControlButton;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.CheckBox CreateOutputDirCheckBox;
    }
}

