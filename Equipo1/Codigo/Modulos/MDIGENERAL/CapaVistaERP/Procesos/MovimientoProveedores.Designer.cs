namespace CapaVistaERP.Procesos
{
    partial class MovimientoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientoProveedores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PagoProv = new System.Windows.Forms.Button();
            this.txt_nitprov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_facturasporpagar = new System.Windows.Forms.DataGridView();
            this.txt_nombreprov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscarprov = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Idprov = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturasporpagar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_PagoProv);
            this.groupBox1.Controls.Add(this.txt_nitprov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_facturasporpagar);
            this.groupBox1.Controls.Add(this.txt_nombreprov);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscarprov);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Idprov);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1071, 478);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimientos";
            // 
            // btn_PagoProv
            // 
            this.btn_PagoProv.Location = new System.Drawing.Point(49, 407);
            this.btn_PagoProv.Name = "btn_PagoProv";
            this.btn_PagoProv.Size = new System.Drawing.Size(190, 38);
            this.btn_PagoProv.TabIndex = 37;
            this.btn_PagoProv.Text = "Pago de Proveedor";
            this.btn_PagoProv.UseVisualStyleBackColor = true;
            this.btn_PagoProv.Click += new System.EventHandler(this.btn_PagoProv_Click);
            // 
            // txt_nitprov
            // 
            this.txt_nitprov.Location = new System.Drawing.Point(688, 50);
            this.txt_nitprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nitprov.Name = "txt_nitprov";
            this.txt_nitprov.Size = new System.Drawing.Size(184, 24);
            this.txt_nitprov.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "NIT";
            // 
            // dgv_facturasporpagar
            // 
            this.dgv_facturasporpagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_facturasporpagar.Location = new System.Drawing.Point(49, 93);
            this.dgv_facturasporpagar.Name = "dgv_facturasporpagar";
            this.dgv_facturasporpagar.RowHeadersWidth = 51;
            this.dgv_facturasporpagar.RowTemplate.Height = 24;
            this.dgv_facturasporpagar.Size = new System.Drawing.Size(943, 293);
            this.dgv_facturasporpagar.TabIndex = 34;
            // 
            // txt_nombreprov
            // 
            this.txt_nombreprov.Location = new System.Drawing.Point(396, 48);
            this.txt_nombreprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreprov.Name = "txt_nombreprov";
            this.txt_nombreprov.Size = new System.Drawing.Size(184, 24);
            this.txt_nombreprov.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            // 
            // btn_buscarprov
            // 
            this.btn_buscarprov.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscarprov.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarprov.BackgroundImage")));
            this.btn_buscarprov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarprov.Location = new System.Drawing.Point(959, 50);
            this.btn_buscarprov.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarprov.Name = "btn_buscarprov";
            this.btn_buscarprov.Size = new System.Drawing.Size(33, 25);
            this.btn_buscarprov.TabIndex = 21;
            this.btn_buscarprov.UseVisualStyleBackColor = false;
            this.btn_buscarprov.Click += new System.EventHandler(this.btn_buscarprov_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Proveedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Idprov
            // 
            this.txt_Idprov.Location = new System.Drawing.Point(171, 46);
            this.txt_Idprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Idprov.Name = "txt_Idprov";
            this.txt_Idprov.Size = new System.Drawing.Size(116, 24);
            this.txt_Idprov.TabIndex = 11;
            // 
            // MovimientoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 515);
            this.Controls.Add(this.groupBox1);
            this.Name = "MovimientoProveedores";
            this.Text = "MovimientoProveedores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_facturasporpagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_facturasporpagar;
        private System.Windows.Forms.TextBox txt_nombreprov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscarprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Idprov;
        private System.Windows.Forms.TextBox txt_nitprov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PagoProv;
    }
}