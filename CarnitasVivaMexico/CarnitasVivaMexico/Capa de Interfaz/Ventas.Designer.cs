namespace CarnitasVivaMexico.Capa_de_Interfaz
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_DetalleVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDeProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-2, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 30);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_DetalleVenta,
            this.Id_Producto,
            this.CantidadDeProducto,
            this.UnidadDeMedida,
            this.Id_Venta});
            this.dataGridView1.Location = new System.Drawing.Point(111, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 383);
            this.dataGridView1.TabIndex = 15;
            // 
            // Id_DetalleVenta
            // 
            this.Id_DetalleVenta.HeaderText = "Id_DetalleVenta";
            this.Id_DetalleVenta.Name = "Id_DetalleVenta";
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id_Producto";
            this.Id_Producto.Name = "Id_Producto";
            // 
            // CantidadDeProducto
            // 
            this.CantidadDeProducto.HeaderText = "CantidadDeProducto";
            this.CantidadDeProducto.Name = "CantidadDeProducto";
            // 
            // UnidadDeMedida
            // 
            this.UnidadDeMedida.HeaderText = "UnidadDeMedida";
            this.UnidadDeMedida.Name = "UnidadDeMedida";
            // 
            // Id_Venta
            // 
            this.Id_Venta.HeaderText = "Id_Venta";
            this.Id_Venta.Name = "Id_Venta";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_DetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Venta;
    }
}