namespace MiFabrica
{
    partial class FabricaDeVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FabricaDeVehiculos));
            btnFabricar = new Button();
            btnElimimar = new Button();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            lstVehiculos = new ListBox();
            pcbFabrica = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(622, 212);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(200, 54);
            btnFabricar.TabIndex = 0;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnElimimar
            // 
            btnElimimar.Location = new Point(622, 272);
            btnElimimar.Name = "btnElimimar";
            btnElimimar.Size = new Size(200, 50);
            btnElimimar.TabIndex = 1;
            btnElimimar.Text = "Eliminar";
            btnElimimar.UseVisualStyleBackColor = true;
            btnElimimar.Click += btnElimimar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(622, 50);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(200, 23);
            cmbTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(643, 22);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(163, 25);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo de vehiculo:";
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 22);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(583, 319);
            lstVehiculos.TabIndex = 4;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = (Image)resources.GetObject("pcbFabrica.Image");
            pcbFabrica.Location = new Point(651, 89);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(131, 106);
            pcbFabrica.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFabrica.TabIndex = 5;
            pcbFabrica.TabStop = false;
            // 
            // FabricaDeVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 361);
            Controls.Add(pcbFabrica);
            Controls.Add(lstVehiculos);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(btnElimimar);
            Controls.Add(btnFabricar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FabricaDeVehiculos";
            Text = "Fabrica de Vehiculos";
            Load += FabricaDeVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFabricar;
        private Button btnElimimar;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private ListBox lstVehiculos;
        private PictureBox pcbFabrica;
    }
}