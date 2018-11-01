namespace Parking.UI.WindowsForm
{
    partial class frmParking
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblLicencePlate = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.MaskedTextBox();
            this.lstParking = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.LicensePlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationParking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoursCharged = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountToPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(28, 61);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(47, 13);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Entrada:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(78, 58);
            this.txtDataEntrada.Mask = "00/00/0000 90:00";
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntrada.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(78, 32);
            this.maskedTextBox1.Mask = "###-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // lblLicencePlate
            // 
            this.lblLicencePlate.AutoSize = true;
            this.lblLicencePlate.Location = new System.Drawing.Point(28, 35);
            this.lblLicencePlate.Name = "lblLicencePlate";
            this.lblLicencePlate.Size = new System.Drawing.Size(37, 13);
            this.lblLicencePlate.TabIndex = 3;
            this.lblLicencePlate.Text = "Placa:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(28, 88);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(39, 13);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Saída:";
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Location = new System.Drawing.Point(78, 85);
            this.txtCheckOut.Mask = "00/00/0000 90:00";
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(100, 20);
            this.txtCheckOut.TabIndex = 5;
            this.txtCheckOut.ValidatingType = typeof(System.DateTime);
            // 
            // lstParking
            // 
            this.lstParking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LicensePlate,
            this.CheckIn,
            this.CheckOut,
            this.DurationParking,
            this.HoursCharged,
            this.Price,
            this.AmountToPay});
            this.lstParking.Location = new System.Drawing.Point(25, 132);
            this.lstParking.Name = "lstParking";
            this.lstParking.Size = new System.Drawing.Size(460, 97);
            this.lstParking.TabIndex = 6;
            this.lstParking.UseCompatibleStateImageBehavior = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(410, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Gravar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LicensePlate
            // 
            this.LicensePlate.Text = "Placa";
            // 
            // CheckIn
            // 
            this.CheckIn.Text = "Horário de Chegada";
            // 
            // CheckOut
            // 
            this.CheckOut.Text = "Horário de Saída";
            // 
            // DurationParking
            // 
            this.DurationParking.Text = "Duração";
            // 
            // HoursCharged
            // 
            this.HoursCharged.Text = "Tempo Cobrado (hora)";
            // 
            // Price
            // 
            this.Price.Text = "Preço";
            // 
            // AmountToPay
            // 
            this.AmountToPay.Text = "Valor a Pagar";
            // 
            // frmParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 265);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstParking);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblLicencePlate);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.lblCheckIn);
            this.Name = "frmParking";
            this.Text = "Parking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.MaskedTextBox txtDataEntrada;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblLicencePlate;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.MaskedTextBox txtCheckOut;
        private System.Windows.Forms.ListView lstParking;
        private System.Windows.Forms.ColumnHeader LicensePlate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader CheckIn;
        private System.Windows.Forms.ColumnHeader CheckOut;
        private System.Windows.Forms.ColumnHeader DurationParking;
        private System.Windows.Forms.ColumnHeader HoursCharged;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader AmountToPay;
    }
}

