namespace dataGridView_Shamilova_variant_4.Forms
{
    partial class TourForm
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxWiFi = new System.Windows.Forms.CheckBox();
            this.numericUpDownSurcharges = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberOfVacationer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCostVacationer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberOfNights = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurcharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfVacationer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostVacationer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfNights)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBoxWiFi
            // 
            this.checkBoxWiFi.AutoSize = true;
            this.checkBoxWiFi.Font = new System.Drawing.Font("MV Boli", 10.2F);
            this.checkBoxWiFi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxWiFi.Location = new System.Drawing.Point(334, 333);
            this.checkBoxWiFi.Name = "checkBoxWiFi";
            this.checkBoxWiFi.Size = new System.Drawing.Size(154, 26);
            this.checkBoxWiFi.TabIndex = 21;
            this.checkBoxWiFi.Text = "Наличие Wi-Fi";
            this.checkBoxWiFi.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSurcharges
            // 
            this.numericUpDownSurcharges.Location = new System.Drawing.Point(334, 278);
            this.numericUpDownSurcharges.Name = "numericUpDownSurcharges";
            this.numericUpDownSurcharges.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownSurcharges.TabIndex = 17;
            // 
            // numericUpDownNumberOfVacationer
            // 
            this.numericUpDownNumberOfVacationer.Location = new System.Drawing.Point(334, 235);
            this.numericUpDownNumberOfVacationer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfVacationer.Name = "numericUpDownNumberOfVacationer";
            this.numericUpDownNumberOfVacationer.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownNumberOfVacationer.TabIndex = 18;
            this.numericUpDownNumberOfVacationer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCostVacationer
            // 
            this.numericUpDownCostVacationer.Location = new System.Drawing.Point(334, 191);
            this.numericUpDownCostVacationer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCostVacationer.Name = "numericUpDownCostVacationer";
            this.numericUpDownCostVacationer.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownCostVacationer.TabIndex = 19;
            this.numericUpDownCostVacationer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNumberOfNights
            // 
            this.numericUpDownNumberOfNights.Location = new System.Drawing.Point(334, 147);
            this.numericUpDownNumberOfNights.Name = "numericUpDownNumberOfNights";
            this.numericUpDownNumberOfNights.Size = new System.Drawing.Size(222, 22);
            this.numericUpDownNumberOfNights.TabIndex = 20;
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(334, 102);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(222, 22);
            this.dateTimePickerDepartureDate.TabIndex = 16;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(334, 58);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(222, 23);
            this.comboBoxDirection.TabIndex = 15;
            this.comboBoxDirection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDirection_DrawItem);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 58);
            this.panel2.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(334, 13);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 33);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "CANCEl";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(148, 13);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(120, 33);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(56, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Доплаты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(56, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество отдыхающих";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(56, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Стоимость за отдыхающего";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(56, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Количество ночей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(56, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата вылета";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(144, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Заполните форму по турам ниже";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Направление";
            // 
            // TourForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.checkBoxWiFi);
            this.Controls.Add(this.numericUpDownSurcharges);
            this.Controls.Add(this.numericUpDownNumberOfVacationer);
            this.Controls.Add(this.numericUpDownCostVacationer);
            this.Controls.Add(this.numericUpDownNumberOfNights);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Описание туров";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurcharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfVacationer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostVacationer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfNights)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBoxWiFi;
        private System.Windows.Forms.NumericUpDown numericUpDownSurcharges;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfVacationer;
        private System.Windows.Forms.NumericUpDown numericUpDownCostVacationer;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfNights;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        public System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}