namespace CarnitasVivaMexico.Capa_de_Interfaz
{
    partial class Insumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insumos));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 44);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnBackInsumos);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Insumo,
            this.Id_Proveedor,
            this.NombreInsumo,
            this.Stock,
            this.PrecioDeCompra,
            this.UnidadDeMedida});
            this.dataGridView1.Location = new System.Drawing.Point(59, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 344);
            this.dataGridView1.TabIndex = 14;
            // 
            // Id_Insumo
            // 
            this.Id_Insumo.HeaderText = "Id_Insumo";
            this.Id_Insumo.Name = "Id_Insumo";
            // 
            // Id_Proveedor
            // 
            this.Id_Proveedor.HeaderText = "Id_Proveedor";
            this.Id_Proveedor.Name = "Id_Proveedor";
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.HeaderText = "NombreInsumo";
            this.NombreInsumo.Name = "NombreInsumo";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // PrecioDeCompra
            // 
            this.PrecioDeCompra.HeaderText = "PrecioDeCompra";
            this.PrecioDeCompra.Name = "PrecioDeCompra";
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.HeaderText = "UnidadDeMedida";
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lista de los insumos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Insumos";
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.Insumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.Label label1;
    }
}