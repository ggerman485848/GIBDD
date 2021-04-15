
namespace GIBDD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CarNumber = new System.Windows.Forms.TextBox();
            this.TypeChooser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.FIO = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.TimeNarsuh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DateNarush = new System.Windows.Forms.DateTimePicker();
            this.Summa = new System.Windows.Forms.TextBox();
            this.ListNarush = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформить новый штраф";
            // 
            // CarNumber
            // 
            this.CarNumber.Location = new System.Drawing.Point(40, 53);
            this.CarNumber.MaxLength = 6;
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.PlaceholderText = "Номер машины*";
            this.CarNumber.Size = new System.Drawing.Size(142, 23);
            this.CarNumber.TabIndex = 1;
            // 
            // TypeChooser
            // 
            this.TypeChooser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeChooser.FormattingEnabled = true;
            this.TypeChooser.Items.AddRange(new object[] {
            "Побег с места ДТП",
            "Езда без прав",
            "Непропуск автомобилей экстренных служб",
            "Проезд на красный свет",
            "Езда с нечитаемыми номерами"});
            this.TypeChooser.Location = new System.Drawing.Point(37, 142);
            this.TypeChooser.Name = "TypeChooser";
            this.TypeChooser.Size = new System.Drawing.Size(155, 23);
            this.TypeChooser.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вид нарушения*";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(123, 175);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 33);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(188, 53);
            this.FIO.Name = "FIO";
            this.FIO.PlaceholderText = "ФИО нарушителя*";
            this.FIO.Size = new System.Drawing.Size(127, 23);
            this.FIO.TabIndex = 17;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(408, 212);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 23;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // TimeNarsuh
            // 
            this.TimeNarsuh.CustomFormat = "hh:mm";
            this.TimeNarsuh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeNarsuh.Location = new System.Drawing.Point(192, 98);
            this.TimeNarsuh.Name = "TimeNarsuh";
            this.TimeNarsuh.ShowUpDown = true;
            this.TimeNarsuh.Size = new System.Drawing.Size(54, 23);
            this.TimeNarsuh.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Дата и время нарушения*";
            // 
            // DateNarush
            // 
            this.DateNarush.Location = new System.Drawing.Point(39, 98);
            this.DateNarush.Name = "DateNarush";
            this.DateNarush.Size = new System.Drawing.Size(147, 23);
            this.DateNarush.TabIndex = 43;
            // 
            // Summa
            // 
            this.Summa.Location = new System.Drawing.Point(198, 142);
            this.Summa.MaxLength = 50;
            this.Summa.Name = "Summa";
            this.Summa.PlaceholderText = "Сумма штрафа*";
            this.Summa.Size = new System.Drawing.Size(117, 23);
            this.Summa.TabIndex = 44;
            this.Summa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Summa_KeyPress);
            // 
            // ListNarush
            // 
            this.ListNarush.HideSelection = false;
            this.ListNarush.Location = new System.Drawing.Point(379, 62);
            this.ListNarush.MultiSelect = false;
            this.ListNarush.Name = "ListNarush";
            this.ListNarush.Size = new System.Drawing.Size(147, 144);
            this.ListNarush.TabIndex = 45;
            this.ListNarush.UseCompatibleStateImageBehavior = false;
            this.ListNarush.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "Машины с наибольшим \r\nколичеством страфов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListNarush);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.DateNarush);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeNarsuh);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeChooser);
            this.Controls.Add(this.CarNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Штрафы ГИБДД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarNumber;
        private System.Windows.Forms.ComboBox TypeChooser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker TimeNarsuh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.DateTimePicker DateNarush;
        private System.Windows.Forms.TextBox Summa;
        private System.Windows.Forms.ListView ListNarush;
        private System.Windows.Forms.Label label4;
    }
}

