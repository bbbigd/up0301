namespace AISUchetPersonala
{
    partial class FormAddDolg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOklad = new System.Windows.Forms.TextBox();
            this.tbNaimenovanie_dolgnosti = new System.Windows.Forms.TextBox();
            this.tbID_Dolgnosti = new System.Windows.Forms.TextBox();
            this.labelImia = new System.Windows.Forms.Label();
            this.labelFamilia = new System.Windows.Forms.Label();
            this.labelSNILS = new System.Windows.Forms.Label();
            this.BotmenaAddDolg = new System.Windows.Forms.Button();
            this.BaddDolg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOklad
            // 
            this.tbOklad.Location = new System.Drawing.Point(167, 89);
            this.tbOklad.Name = "tbOklad";
            this.tbOklad.Size = new System.Drawing.Size(162, 20);
            this.tbOklad.TabIndex = 36;
            // 
            // tbNaimenovanie_dolgnosti
            // 
            this.tbNaimenovanie_dolgnosti.Location = new System.Drawing.Point(167, 53);
            this.tbNaimenovanie_dolgnosti.Name = "tbNaimenovanie_dolgnosti";
            this.tbNaimenovanie_dolgnosti.Size = new System.Drawing.Size(162, 20);
            this.tbNaimenovanie_dolgnosti.TabIndex = 35;
            // 
            // tbID_Dolgnosti
            // 
            this.tbID_Dolgnosti.Location = new System.Drawing.Point(167, 8);
            this.tbID_Dolgnosti.Name = "tbID_Dolgnosti";
            this.tbID_Dolgnosti.Size = new System.Drawing.Size(162, 20);
            this.tbID_Dolgnosti.TabIndex = 34;
            // 
            // labelImia
            // 
            this.labelImia.AutoSize = true;
            this.labelImia.Location = new System.Drawing.Point(20, 96);
            this.labelImia.Name = "labelImia";
            this.labelImia.Size = new System.Drawing.Size(39, 13);
            this.labelImia.TabIndex = 26;
            this.labelImia.Text = "Оклад";
            // 
            // labelFamilia
            // 
            this.labelFamilia.AutoSize = true;
            this.labelFamilia.Location = new System.Drawing.Point(20, 56);
            this.labelFamilia.Name = "labelFamilia";
            this.labelFamilia.Size = new System.Drawing.Size(141, 13);
            this.labelFamilia.TabIndex = 25;
            this.labelFamilia.Text = "Наименование должности";
            // 
            // labelSNILS
            // 
            this.labelSNILS.AutoSize = true;
            this.labelSNILS.Location = new System.Drawing.Point(20, 15);
            this.labelSNILS.Name = "labelSNILS";
            this.labelSNILS.Size = new System.Drawing.Size(18, 13);
            this.labelSNILS.TabIndex = 24;
            this.labelSNILS.Text = "№";
            // 
            // BotmenaAddDolg
            // 
            this.BotmenaAddDolg.Location = new System.Drawing.Point(254, 142);
            this.BotmenaAddDolg.Name = "BotmenaAddDolg";
            this.BotmenaAddDolg.Size = new System.Drawing.Size(75, 23);
            this.BotmenaAddDolg.TabIndex = 23;
            this.BotmenaAddDolg.Text = "Отмена";
            this.BotmenaAddDolg.UseVisualStyleBackColor = true;
            this.BotmenaAddDolg.Click += new System.EventHandler(this.BotmenaAddDolg_Click);
            // 
            // BaddDolg
            // 
            this.BaddDolg.Location = new System.Drawing.Point(23, 142);
            this.BaddDolg.Name = "BaddDolg";
            this.BaddDolg.Size = new System.Drawing.Size(75, 23);
            this.BaddDolg.TabIndex = 22;
            this.BaddDolg.Text = "Добавить";
            this.BaddDolg.UseVisualStyleBackColor = true;
            this.BaddDolg.Click += new System.EventHandler(this.BaddDolg_Click);
            // 
            // FormAddDolg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 184);
            this.Controls.Add(this.tbOklad);
            this.Controls.Add(this.tbNaimenovanie_dolgnosti);
            this.Controls.Add(this.tbID_Dolgnosti);
            this.Controls.Add(this.labelImia);
            this.Controls.Add(this.labelFamilia);
            this.Controls.Add(this.labelSNILS);
            this.Controls.Add(this.BotmenaAddDolg);
            this.Controls.Add(this.BaddDolg);
            this.Name = "FormAddDolg";
            this.Text = "Добавление новой должности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOklad;
        private System.Windows.Forms.TextBox tbNaimenovanie_dolgnosti;
        private System.Windows.Forms.TextBox tbID_Dolgnosti;
        private System.Windows.Forms.Label labelImia;
        private System.Windows.Forms.Label labelFamilia;
        private System.Windows.Forms.Label labelSNILS;
        private System.Windows.Forms.Button BotmenaAddDolg;
        private System.Windows.Forms.Button BaddDolg;
    }
}