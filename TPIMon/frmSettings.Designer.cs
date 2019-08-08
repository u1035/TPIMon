namespace TPIMon
{
    partial class frmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtASUDDTPIs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numModems = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModemPage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndexPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdDefault = new System.Windows.Forms.Button();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPreview);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtASUDDTPIs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numTimeout);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numModems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtModemPage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIndexPage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки сервера";
            // 
            // txtASUDDTPIs
            // 
            this.txtASUDDTPIs.Location = new System.Drawing.Point(206, 173);
            this.txtASUDDTPIs.Name = "txtASUDDTPIs";
            this.txtASUDDTPIs.Size = new System.Drawing.Size(535, 20);
            this.txtASUDDTPIs.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ТПИ АСУДД (через пробел):";
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(206, 147);
            this.numTimeout.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(120, 20);
            this.numTimeout.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Таймаут соединения (мс):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "(Этот номер вида 001, 002, ... добавляется к адресу страницы модема)";
            // 
            // numModems
            // 
            this.numModems.Location = new System.Drawing.Point(206, 123);
            this.numModems.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numModems.Name = "numModems";
            this.numModems.Size = new System.Drawing.Size(120, 20);
            this.numModems.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество модемов для опроса:";
            // 
            // txtModemPage
            // 
            this.txtModemPage.Location = new System.Drawing.Point(206, 71);
            this.txtModemPage.Name = "txtModemPage";
            this.txtModemPage.Size = new System.Drawing.Size(535, 20);
            this.txtModemPage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страница модема:";
            // 
            // txtIndexPage
            // 
            this.txtIndexPage.Location = new System.Drawing.Point(206, 45);
            this.txtIndexPage.Name = "txtIndexPage";
            this.txtIndexPage.Size = new System.Drawing.Size(535, 20);
            this.txtIndexPage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Страница с перечнем модемов:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(206, 19);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(535, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервер:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(700, 223);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Отмена";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(619, 223);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Сохранить";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdDefault
            // 
            this.cmdDefault.Location = new System.Drawing.Point(12, 223);
            this.cmdDefault.Name = "cmdDefault";
            this.cmdDefault.Size = new System.Drawing.Size(100, 23);
            this.cmdDefault.TabIndex = 3;
            this.cmdDefault.Text = "По умолчанию";
            this.cmdDefault.UseVisualStyleBackColor = true;
            this.cmdDefault.Click += new System.EventHandler(this.cmdDefault_Click);
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(206, 97);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(535, 20);
            this.txtPreview.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Адрес превью:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(785, 253);
            this.Controls.Add(this.cmdDefault);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numModems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModemPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndexPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdDefault;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtASUDDTPIs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label label8;
    }
}