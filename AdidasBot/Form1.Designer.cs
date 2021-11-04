
namespace AdidasBot
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
            this.LinkField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SizeField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CityField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ZipField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StreetField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HouseField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ApartField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkField
            // 
            this.LinkField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkField.Location = new System.Drawing.Point(61, 134);
            this.LinkField.Name = "LinkField";
            this.LinkField.Size = new System.Drawing.Size(470, 41);
            this.LinkField.TabIndex = 1;
            this.LinkField.Text = "https://www.adidas.ru/vysokie-krossovki-hoops-2.0/B44621.html";
            this.LinkField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1054, 809);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(555, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ссылка на товар";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(555, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер";
            // 
            // SizeField
            // 
            this.SizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeField.Location = new System.Drawing.Point(61, 181);
            this.SizeField.Name = "SizeField";
            this.SizeField.Size = new System.Drawing.Size(470, 41);
            this.SizeField.TabIndex = 5;
            this.SizeField.Text = "43";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(103, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Данные для доставки";
            // 
            // FNameField
            // 
            this.FNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNameField.Location = new System.Drawing.Point(61, 528);
            this.FNameField.Name = "FNameField";
            this.FNameField.Size = new System.Drawing.Size(470, 41);
            this.FNameField.TabIndex = 8;
            this.FNameField.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(555, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // LNameField
            // 
            this.LNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNameField.Location = new System.Drawing.Point(61, 575);
            this.LNameField.Name = "LNameField";
            this.LNameField.Size = new System.Drawing.Size(470, 41);
            this.LNameField.TabIndex = 10;
            this.LNameField.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(555, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фамилия";
            // 
            // CityField
            // 
            this.CityField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityField.Location = new System.Drawing.Point(61, 622);
            this.CityField.Name = "CityField";
            this.CityField.Size = new System.Drawing.Size(470, 41);
            this.CityField.TabIndex = 12;
            this.CityField.Text = "Город";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(555, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Город";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ZipField
            // 
            this.ZipField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZipField.Location = new System.Drawing.Point(61, 669);
            this.ZipField.Name = "ZipField";
            this.ZipField.Size = new System.Drawing.Size(470, 41);
            this.ZipField.TabIndex = 14;
            this.ZipField.Text = "127642";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(554, 716);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Улица";
            // 
            // StreetField
            // 
            this.StreetField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetField.Location = new System.Drawing.Point(61, 716);
            this.StreetField.Name = "StreetField";
            this.StreetField.Size = new System.Drawing.Size(470, 41);
            this.StreetField.TabIndex = 16;
            this.StreetField.Text = "Улица";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(555, 763);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дом";
            // 
            // HouseField
            // 
            this.HouseField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseField.Location = new System.Drawing.Point(61, 763);
            this.HouseField.Name = "HouseField";
            this.HouseField.Size = new System.Drawing.Size(470, 41);
            this.HouseField.TabIndex = 18;
            this.HouseField.Text = "Дом";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(555, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 36);
            this.label9.TabIndex = 17;
            this.label9.Text = "Почтовый индекс";
            // 
            // ApartField
            // 
            this.ApartField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApartField.Location = new System.Drawing.Point(61, 810);
            this.ApartField.Name = "ApartField";
            this.ApartField.Size = new System.Drawing.Size(470, 41);
            this.ApartField.TabIndex = 20;
            this.ApartField.Text = "Квартира";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(555, 810);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "Квартира";
            // 
            // PhoneField
            // 
            this.PhoneField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneField.Location = new System.Drawing.Point(61, 857);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(470, 41);
            this.PhoneField.TabIndex = 22;
            this.PhoneField.Text = "9778031097";
            this.PhoneField.TextChanged += new System.EventHandler(this.PhoneField_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(555, 857);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 36);
            this.label11.TabIndex = 21;
            this.label11.Text = "Телефон (без +7/8)";
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(892, 181);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(470, 41);
            this.PassField.TabIndex = 26;
            this.PassField.Text = "Navi228131";
            this.PassField.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1386, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 36);
            this.label12.TabIndex = 25;
            this.label12.Text = "Пароль";
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(892, 134);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(470, 41);
            this.loginField.TabIndex = 24;
            this.loginField.Text = "TIMA.ARSLANOV.20@BK.RU";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(1386, 134);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 36);
            this.label.TabIndex = 23;
            this.label.Text = "Логин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 1131);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ApartField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HouseField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StreetField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ZipField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CityField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LNameField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FNameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SizeField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LinkField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LinkField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SizeField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FNameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LNameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CityField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ZipField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StreetField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HouseField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ApartField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label label;
    }
}

