﻿namespace GeoHelper
{
    partial class EditForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.groupBoxCity = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCityContinent = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxCityCountry = new System.Windows.Forms.ComboBox();
            this.checkBoxIsCapital = new System.Windows.Forms.CheckBox();
            this.textBoxCityArea = new System.Windows.Forms.TextBox();
            this.textBoxCityPopulation = new System.Windows.Forms.TextBox();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioButtonContinent = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonCountry = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCity = new System.Windows.Forms.RadioButton();
            this.groupBoxContinent = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxContinent = new System.Windows.Forms.ComboBox();
            this.textBoxContinentName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxCountry = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCountryContinent = new System.Windows.Forms.ComboBox();
            this.continentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxGovForm = new System.Windows.Forms.ComboBox();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxCity.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            this.groupBoxContinent.SuspendLayout();
            this.groupBoxCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCity
            // 
            this.groupBoxCity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxCity.Controls.Add(this.label16);
            this.groupBoxCity.Controls.Add(this.comboBoxCity);
            this.groupBoxCity.Controls.Add(this.textBoxLongitude);
            this.groupBoxCity.Controls.Add(this.label15);
            this.groupBoxCity.Controls.Add(this.textBoxLatitude);
            this.groupBoxCity.Controls.Add(this.label13);
            this.groupBoxCity.Controls.Add(this.comboBoxCityContinent);
            this.groupBoxCity.Controls.Add(this.label11);
            this.groupBoxCity.Controls.Add(this.comboBoxCityCountry);
            this.groupBoxCity.Controls.Add(this.checkBoxIsCapital);
            this.groupBoxCity.Controls.Add(this.textBoxCityArea);
            this.groupBoxCity.Controls.Add(this.textBoxCityPopulation);
            this.groupBoxCity.Controls.Add(this.textBoxCityName);
            this.groupBoxCity.Controls.Add(this.label8);
            this.groupBoxCity.Controls.Add(this.label7);
            this.groupBoxCity.Controls.Add(this.label6);
            this.groupBoxCity.Controls.Add(this.label5);
            this.groupBoxCity.Controls.Add(this.label4);
            this.groupBoxCity.Location = new System.Drawing.Point(12, 98);
            this.groupBoxCity.Name = "groupBoxCity";
            this.groupBoxCity.Size = new System.Drawing.Size(261, 231);
            this.groupBoxCity.TabIndex = 31;
            this.groupBoxCity.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Город:";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DisplayMember = "Name";
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(83, 74);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCity.TabIndex = 32;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(65, 179);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(51, 20);
            this.textBoxLongitude.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(132, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Широта:";
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(186, 179);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(51, 20);
            this.textBoxLatitude.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Континент:";
            // 
            // comboBoxCityContinent
            // 
            this.comboBoxCityContinent.DisplayMember = "Name";
            this.comboBoxCityContinent.FormattingEnabled = true;
            this.comboBoxCityContinent.Location = new System.Drawing.Point(83, 19);
            this.comboBoxCityContinent.Name = "comboBoxCityContinent";
            this.comboBoxCityContinent.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCityContinent.TabIndex = 27;
            this.comboBoxCityContinent.SelectedIndexChanged += new System.EventHandler(this.comboBoxCityContinent_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Страна:";
            // 
            // comboBoxCityCountry
            // 
            this.comboBoxCityCountry.DisplayMember = "Name";
            this.comboBoxCityCountry.FormattingEnabled = true;
            this.comboBoxCityCountry.Location = new System.Drawing.Point(83, 47);
            this.comboBoxCityCountry.Name = "comboBoxCityCountry";
            this.comboBoxCityCountry.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCityCountry.TabIndex = 25;
            this.comboBoxCityCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCityCountry_SelectedIndexChanged);
            // 
            // checkBoxIsCapital
            // 
            this.checkBoxIsCapital.AutoSize = true;
            this.checkBoxIsCapital.Location = new System.Drawing.Point(116, 208);
            this.checkBoxIsCapital.Name = "checkBoxIsCapital";
            this.checkBoxIsCapital.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsCapital.TabIndex = 24;
            this.checkBoxIsCapital.UseVisualStyleBackColor = true;
            // 
            // textBoxCityArea
            // 
            this.textBoxCityArea.Location = new System.Drawing.Point(83, 127);
            this.textBoxCityArea.Name = "textBoxCityArea";
            this.textBoxCityArea.Size = new System.Drawing.Size(172, 20);
            this.textBoxCityArea.TabIndex = 23;
            // 
            // textBoxCityPopulation
            // 
            this.textBoxCityPopulation.Location = new System.Drawing.Point(83, 153);
            this.textBoxCityPopulation.Name = "textBoxCityPopulation";
            this.textBoxCityPopulation.Size = new System.Drawing.Size(172, 20);
            this.textBoxCityPopulation.TabIndex = 21;
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.Location = new System.Drawing.Point(83, 101);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(172, 20);
            this.textBoxCityName.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Название:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Является столицей:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Население:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Площадь:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Долгота:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(147, 335);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 28);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 335);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(126, 28);
            this.buttonOK.TabIndex = 32;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxRadio.Controls.Add(this.radioButtonContinent);
            this.groupBoxRadio.Controls.Add(this.label3);
            this.groupBoxRadio.Controls.Add(this.label2);
            this.groupBoxRadio.Controls.Add(this.radioButtonCountry);
            this.groupBoxRadio.Controls.Add(this.label1);
            this.groupBoxRadio.Controls.Add(this.radioButtonCity);
            this.groupBoxRadio.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(261, 75);
            this.groupBoxRadio.TabIndex = 30;
            this.groupBoxRadio.TabStop = false;
            // 
            // radioButtonContinent
            // 
            this.radioButtonContinent.AutoSize = true;
            this.radioButtonContinent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonContinent.Location = new System.Drawing.Point(38, 43);
            this.radioButtonContinent.Name = "radioButtonContinent";
            this.radioButtonContinent.Size = new System.Drawing.Size(14, 13);
            this.radioButtonContinent.TabIndex = 7;
            this.radioButtonContinent.UseVisualStyleBackColor = true;
            this.radioButtonContinent.CheckedChanged += new System.EventHandler(this.radioButtonContinent_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Страна";
            // 
            // radioButtonCountry
            // 
            this.radioButtonCountry.AutoSize = true;
            this.radioButtonCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCountry.Location = new System.Drawing.Point(124, 43);
            this.radioButtonCountry.Name = "radioButtonCountry";
            this.radioButtonCountry.Size = new System.Drawing.Size(14, 13);
            this.radioButtonCountry.TabIndex = 1;
            this.radioButtonCountry.UseVisualStyleBackColor = true;
            this.radioButtonCountry.CheckedChanged += new System.EventHandler(this.radioButtonCountry_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Континент";
            // 
            // radioButtonCity
            // 
            this.radioButtonCity.AutoSize = true;
            this.radioButtonCity.Checked = true;
            this.radioButtonCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCity.Location = new System.Drawing.Point(213, 43);
            this.radioButtonCity.Name = "radioButtonCity";
            this.radioButtonCity.Size = new System.Drawing.Size(14, 13);
            this.radioButtonCity.TabIndex = 2;
            this.radioButtonCity.TabStop = true;
            this.radioButtonCity.UseVisualStyleBackColor = true;
            this.radioButtonCity.CheckedChanged += new System.EventHandler(this.radioButtonCity_CheckedChanged);
            // 
            // groupBoxContinent
            // 
            this.groupBoxContinent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxContinent.Controls.Add(this.label17);
            this.groupBoxContinent.Controls.Add(this.comboBoxContinent);
            this.groupBoxContinent.Controls.Add(this.textBoxContinentName);
            this.groupBoxContinent.Controls.Add(this.label14);
            this.groupBoxContinent.Location = new System.Drawing.Point(12, 97);
            this.groupBoxContinent.Name = "groupBoxContinent";
            this.groupBoxContinent.Size = new System.Drawing.Size(261, 232);
            this.groupBoxContinent.TabIndex = 35;
            this.groupBoxContinent.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Континент:";
            // 
            // comboBoxContinent
            // 
            this.comboBoxContinent.DisplayMember = "Name";
            this.comboBoxContinent.FormattingEnabled = true;
            this.comboBoxContinent.Location = new System.Drawing.Point(83, 20);
            this.comboBoxContinent.Name = "comboBoxContinent";
            this.comboBoxContinent.Size = new System.Drawing.Size(172, 21);
            this.comboBoxContinent.TabIndex = 31;
            // 
            // textBoxContinentName
            // 
            this.textBoxContinentName.Location = new System.Drawing.Point(83, 48);
            this.textBoxContinentName.Name = "textBoxContinentName";
            this.textBoxContinentName.Size = new System.Drawing.Size(172, 20);
            this.textBoxContinentName.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Название:";
            // 
            // groupBoxCountry
            // 
            this.groupBoxCountry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxCountry.Controls.Add(this.label12);
            this.groupBoxCountry.Controls.Add(this.comboBoxCountryContinent);
            this.groupBoxCountry.Controls.Add(this.label18);
            this.groupBoxCountry.Controls.Add(this.comboBoxCountry);
            this.groupBoxCountry.Controls.Add(this.comboBoxGovForm);
            this.groupBoxCountry.Controls.Add(this.textBoxCountryName);
            this.groupBoxCountry.Controls.Add(this.label9);
            this.groupBoxCountry.Controls.Add(this.label10);
            this.groupBoxCountry.Location = new System.Drawing.Point(12, 98);
            this.groupBoxCountry.Name = "groupBoxCountry";
            this.groupBoxCountry.Size = new System.Drawing.Size(261, 231);
            this.groupBoxCountry.TabIndex = 34;
            this.groupBoxCountry.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Континент:";
            // 
            // comboBoxCountryContinent
            // 
            this.comboBoxCountryContinent.DataSource = this.continentBindingSource;
            this.comboBoxCountryContinent.DisplayMember = "Name";
            this.comboBoxCountryContinent.FormattingEnabled = true;
            this.comboBoxCountryContinent.Location = new System.Drawing.Point(83, 19);
            this.comboBoxCountryContinent.Name = "comboBoxCountryContinent";
            this.comboBoxCountryContinent.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCountryContinent.TabIndex = 31;
            this.comboBoxCountryContinent.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountryContinent_SelectedIndexChanged);
            // 
            // continentBindingSource
            // 
            this.continentBindingSource.DataSource = typeof(GeoHelper.Continent);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Страна:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DisplayMember = "Name";
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(83, 47);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCountry.TabIndex = 29;
            // 
            // comboBoxGovForm
            // 
            this.comboBoxGovForm.FormattingEnabled = true;
            this.comboBoxGovForm.Location = new System.Drawing.Point(135, 100);
            this.comboBoxGovForm.Name = "comboBoxGovForm";
            this.comboBoxGovForm.Size = new System.Drawing.Size(120, 21);
            this.comboBoxGovForm.TabIndex = 21;
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(83, 74);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(172, 20);
            this.textBoxCountryName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Название:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Форма гос. управления:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 371);
            this.Controls.Add(this.groupBoxCity);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.groupBoxContinent);
            this.Controls.Add(this.groupBoxCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.groupBoxCity.ResumeLayout(false);
            this.groupBoxCity.PerformLayout();
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.groupBoxContinent.ResumeLayout(false);
            this.groupBoxContinent.PerformLayout();
            this.groupBoxCountry.ResumeLayout(false);
            this.groupBoxCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.continentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxCityContinent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxCityCountry;
        private System.Windows.Forms.CheckBox checkBoxIsCapital;
        private System.Windows.Forms.TextBox textBoxCityArea;
        private System.Windows.Forms.TextBox textBoxCityPopulation;
        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.RadioButton radioButtonContinent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonCity;
        private System.Windows.Forms.GroupBox groupBoxContinent;
        private System.Windows.Forms.TextBox textBoxContinentName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxGovForm;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxContinent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCountryContinent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.BindingSource continentBindingSource;
    }
}