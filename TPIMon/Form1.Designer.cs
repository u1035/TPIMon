namespace TPIMon
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdShowOnMap = new System.Windows.Forms.Button();
            this.cmbTPISelect = new System.Windows.Forms.ComboBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.chkOnlineOnly = new System.Windows.Forms.CheckBox();
            this.cmbMap = new System.Windows.Forms.ComboBox();
            this.lblTPIsTotal = new System.Windows.Forms.Label();
            this.lblTPIsOnline = new System.Windows.Forms.Label();
            this.cmdSettings = new System.Windows.Forms.Button();
            this.chkASUDDOnly = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 789);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(999, 92);
            this.textBox1.TabIndex = 1;
            // 
            // cmdStart
            // 
            this.cmdStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStart.Location = new System.Drawing.Point(1016, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(268, 23);
            this.cmdStart.TabIndex = 4;
            this.cmdStart.Text = "Опросить табло";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.button3_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(998, 771);
            this.gMapControl1.TabIndex = 5;
            this.gMapControl1.Zoom = 8D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdShowOnMap);
            this.groupBox1.Controls.Add(this.cmbTPISelect);
            this.groupBox1.Controls.Add(this.picImage);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Location = new System.Drawing.Point(1016, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 507);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры табло";
            // 
            // cmdShowOnMap
            // 
            this.cmdShowOnMap.Enabled = false;
            this.cmdShowOnMap.Location = new System.Drawing.Point(133, 19);
            this.cmdShowOnMap.Name = "cmdShowOnMap";
            this.cmdShowOnMap.Size = new System.Drawing.Size(135, 21);
            this.cmdShowOnMap.TabIndex = 3;
            this.cmdShowOnMap.Text = "Найти на карте";
            this.cmdShowOnMap.UseVisualStyleBackColor = true;
            this.cmdShowOnMap.Click += new System.EventHandler(this.cmdShowOnMap_Click);
            // 
            // cmbTPISelect
            // 
            this.cmbTPISelect.FormattingEnabled = true;
            this.cmbTPISelect.Location = new System.Drawing.Point(6, 19);
            this.cmbTPISelect.Name = "cmbTPISelect";
            this.cmbTPISelect.Size = new System.Drawing.Size(121, 21);
            this.cmbTPISelect.Sorted = true;
            this.cmbTPISelect.TabIndex = 2;
            this.cmbTPISelect.SelectedIndexChanged += new System.EventHandler(this.cmbTPISelect_SelectedIndexChanged);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(61, 383);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(150, 110);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(6, 46);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(262, 331);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "<Выберите табло для отображения подробной информации>";
            // 
            // chkOnlineOnly
            // 
            this.chkOnlineOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnlineOnly.AutoSize = true;
            this.chkOnlineOnly.Location = new System.Drawing.Point(1016, 68);
            this.chkOnlineOnly.Name = "chkOnlineOnly";
            this.chkOnlineOnly.Size = new System.Drawing.Size(134, 17);
            this.chkOnlineOnly.TabIndex = 7;
            this.chkOnlineOnly.Text = "Только табло онлайн";
            this.chkOnlineOnly.UseVisualStyleBackColor = true;
            this.chkOnlineOnly.CheckedChanged += new System.EventHandler(this.chkOnlineOnly_CheckedChanged);
            // 
            // cmbMap
            // 
            this.cmbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMap.FormattingEnabled = true;
            this.cmbMap.Items.AddRange(new object[] {
            "Google Maps",
            "Yandex maps",
            "Yandex Hybrid maps",
            "OSM Maps"});
            this.cmbMap.Location = new System.Drawing.Point(1016, 41);
            this.cmbMap.Name = "cmbMap";
            this.cmbMap.Size = new System.Drawing.Size(268, 21);
            this.cmbMap.TabIndex = 8;
            this.cmbMap.Text = "Google Maps";
            this.cmbMap.SelectedIndexChanged += new System.EventHandler(this.cmbMap_SelectedIndexChanged);
            // 
            // lblTPIsTotal
            // 
            this.lblTPIsTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTPIsTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTPIsTotal.Location = new System.Drawing.Point(1032, 860);
            this.lblTPIsTotal.Name = "lblTPIsTotal";
            this.lblTPIsTotal.Size = new System.Drawing.Size(234, 21);
            this.lblTPIsTotal.TabIndex = 9;
            this.lblTPIsTotal.Text = "Всего ТПИ:";
            this.lblTPIsTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTPIsOnline
            // 
            this.lblTPIsOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTPIsOnline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTPIsOnline.Location = new System.Drawing.Point(1032, 829);
            this.lblTPIsOnline.Name = "lblTPIsOnline";
            this.lblTPIsOnline.Size = new System.Drawing.Size(234, 21);
            this.lblTPIsOnline.TabIndex = 10;
            this.lblTPIsOnline.Text = "ТПИ Онлайн:";
            this.lblTPIsOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdSettings
            // 
            this.cmdSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSettings.Location = new System.Drawing.Point(1016, 627);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(274, 22);
            this.cmdSettings.TabIndex = 11;
            this.cmdSettings.Text = "Настройки";
            this.cmdSettings.UseVisualStyleBackColor = true;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // chkASUDDOnly
            // 
            this.chkASUDDOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkASUDDOnly.AutoSize = true;
            this.chkASUDDOnly.Location = new System.Drawing.Point(1016, 91);
            this.chkASUDDOnly.Name = "chkASUDDOnly";
            this.chkASUDDOnly.Size = new System.Drawing.Size(138, 17);
            this.chkASUDDOnly.TabIndex = 12;
            this.chkASUDDOnly.Text = "Только табло АСУДД";
            this.chkASUDDOnly.UseVisualStyleBackColor = true;
            this.chkASUDDOnly.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 893);
            this.Controls.Add(this.chkASUDDOnly);
            this.Controls.Add(this.cmdSettings);
            this.Controls.Add(this.lblTPIsOnline);
            this.Controls.Add(this.lblTPIsTotal);
            this.Controls.Add(this.cmbMap);
            this.Controls.Add(this.chkOnlineOnly);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Мониторинг ТПИ - v0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdStart;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.CheckBox chkOnlineOnly;
        private System.Windows.Forms.ComboBox cmbMap;
        private System.Windows.Forms.Label lblTPIsTotal;
        private System.Windows.Forms.Label lblTPIsOnline;
        private System.Windows.Forms.ComboBox cmbTPISelect;
        private System.Windows.Forms.Button cmdShowOnMap;
        private System.Windows.Forms.Button cmdSettings;
        private System.Windows.Forms.CheckBox chkASUDDOnly;
    }
}

