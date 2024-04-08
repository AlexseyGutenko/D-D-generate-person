namespace D_D
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
            this.generate = new System.Windows.Forms.Button();
            this.out_person = new System.Windows.Forms.TextBox();
            this.downlode = new System.Windows.Forms.Button();
            this.race = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(67, 415);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(137, 23);
            this.generate.TabIndex = 0;
            this.generate.Text = "сгенерировать";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // out_person
            // 
            this.out_person.Location = new System.Drawing.Point(8, 2);
            this.out_person.Multiline = true;
            this.out_person.Name = "out_person";
            this.out_person.Size = new System.Drawing.Size(259, 332);
            this.out_person.TabIndex = 1;
            this.out_person.TextChanged += new System.EventHandler(this.out_person_TextChanged);
            // 
            // downlode
            // 
            this.downlode.Location = new System.Drawing.Point(392, 415);
            this.downlode.Name = "downlode";
            this.downlode.Size = new System.Drawing.Size(75, 23);
            this.downlode.TabIndex = 2;
            this.downlode.Text = "скачать";
            this.downlode.UseVisualStyleBackColor = true;
            this.downlode.Click += new System.EventHandler(this.downlode_Click);
            // 
            // race
            // 
            this.race.FormattingEnabled = true;
            this.race.Location = new System.Drawing.Point(8, 355);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(121, 21);
            this.race.TabIndex = 3;
            this.race.SelectedIndexChanged += new System.EventHandler(this.race_SelectedIndexChanged);
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(175, 354);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 21);
            this.Class.TabIndex = 4;
            this.Class.SelectedIndexChanged += new System.EventHandler(this.Class_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.race);
            this.Controls.Add(this.downlode);
            this.Controls.Add(this.out_person);
            this.Controls.Add(this.generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox out_person;
        private System.Windows.Forms.Button downlode;
        private System.Windows.Forms.ComboBox race;
        private System.Windows.Forms.ComboBox Class;
    }
}

