﻿
namespace CapaVista_SisB
{
    partial class MovimientosBancarios
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_vistaTransacciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_stCon = new System.Windows.Forms.TextBox();
            this.txt_valorTrans = new System.Windows.Forms.TextBox();
            this.cb_tipoTrans = new System.Windows.Forms.ComboBox();
            this.txt_ttransaccion = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_descripcionTransferencia = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelarTransaccion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rtrans = new System.Windows.Forms.Button();
            this.txt_valorTransferencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_vistaTransacciones);
            this.groupBox2.Location = new System.Drawing.Point(39, 402);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(955, 316);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista de transacciones";
            // 
            // dgv_vistaTransacciones
            // 
            this.dgv_vistaTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaTransacciones.Location = new System.Drawing.Point(43, 36);
            this.dgv_vistaTransacciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_vistaTransacciones.Name = "dgv_vistaTransacciones";
            this.dgv_vistaTransacciones.RowHeadersWidth = 51;
            this.dgv_vistaTransacciones.RowTemplate.Height = 24;
            this.dgv_vistaTransacciones.Size = new System.Drawing.Size(887, 256);
            this.dgv_vistaTransacciones.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_stCon);
            this.groupBox1.Controls.Add(this.txt_valorTrans);
            this.groupBox1.Controls.Add(this.cb_tipoTrans);
            this.groupBox1.Controls.Add(this.txt_ttransaccion);
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.txt_descripcionTransferencia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_cancelarTransaccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_rtrans);
            this.groupBox1.Controls.Add(this.txt_valorTransferencia);
            this.groupBox1.Location = new System.Drawing.Point(39, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(955, 368);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar transacciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_stCon
            // 
            this.txt_stCon.Enabled = false;
            this.txt_stCon.Location = new System.Drawing.Point(691, 145);
            this.txt_stCon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_stCon.Name = "txt_stCon";
            this.txt_stCon.ReadOnly = true;
            this.txt_stCon.Size = new System.Drawing.Size(41, 22);
            this.txt_stCon.TabIndex = 90;
            this.txt_stCon.Text = "0";
            this.txt_stCon.Visible = false;
            // 
            // txt_valorTrans
            // 
            this.txt_valorTrans.Enabled = false;
            this.txt_valorTrans.Location = new System.Drawing.Point(641, 145);
            this.txt_valorTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valorTrans.Name = "txt_valorTrans";
            this.txt_valorTrans.ReadOnly = true;
            this.txt_valorTrans.Size = new System.Drawing.Size(41, 22);
            this.txt_valorTrans.TabIndex = 89;
            this.txt_valorTrans.Visible = false;
            // 
            // cb_tipoTrans
            // 
            this.cb_tipoTrans.FormattingEnabled = true;
            this.cb_tipoTrans.Location = new System.Drawing.Point(349, 101);
            this.cb_tipoTrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_tipoTrans.Name = "cb_tipoTrans";
            this.cb_tipoTrans.Size = new System.Drawing.Size(203, 24);
            this.cb_tipoTrans.TabIndex = 18;
            // 
            // txt_ttransaccion
            // 
            this.txt_ttransaccion.Location = new System.Drawing.Point(585, 104);
            this.txt_ttransaccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ttransaccion.Name = "txt_ttransaccion";
            this.txt_ttransaccion.Size = new System.Drawing.Size(215, 22);
            this.txt_ttransaccion.TabIndex = 16;
            this.txt_ttransaccion.Visible = false;
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(585, 145);
            this.txt_estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(41, 22);
            this.txt_estado.TabIndex = 14;
            this.txt_estado.Text = "1";
            this.txt_estado.Visible = false;
            // 
            // txt_descripcionTransferencia
            // 
            this.txt_descripcionTransferencia.Location = new System.Drawing.Point(349, 176);
            this.txt_descripcionTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_descripcionTransferencia.Name = "txt_descripcionTransferencia";
            this.txt_descripcionTransferencia.Size = new System.Drawing.Size(203, 84);
            this.txt_descripcionTransferencia.TabIndex = 9;
            this.txt_descripcionTransferencia.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuenta a debitar:";
            // 
            // btn_cancelarTransaccion
            // 
            this.btn_cancelarTransaccion.Location = new System.Drawing.Point(191, 323);
            this.btn_cancelarTransaccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelarTransaccion.Name = "btn_cancelarTransaccion";
            this.btn_cancelarTransaccion.Size = new System.Drawing.Size(372, 33);
            this.btn_cancelarTransaccion.TabIndex = 13;
            this.btn_cancelarTransaccion.Text = "Cancelar transacción";
            this.btn_cancelarTransaccion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de transacción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción: ";
            // 
            // btn_rtrans
            // 
            this.btn_rtrans.Location = new System.Drawing.Point(191, 284);
            this.btn_rtrans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rtrans.Name = "btn_rtrans";
            this.btn_rtrans.Size = new System.Drawing.Size(372, 33);
            this.btn_rtrans.TabIndex = 10;
            this.btn_rtrans.Text = "Realizar transacción";
            this.btn_rtrans.UseVisualStyleBackColor = true;
            // 
            // txt_valorTransferencia
            // 
            this.txt_valorTransferencia.Location = new System.Drawing.Point(349, 142);
            this.txt_valorTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_valorTransferencia.Name = "txt_valorTransferencia";
            this.txt_valorTransferencia.Size = new System.Drawing.Size(203, 22);
            this.txt_valorTransferencia.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 91;
            this.label7.Text = "Cuenta a acreditar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 22);
            this.textBox1.TabIndex = 92;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(349, 34);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 22);
            this.textBox2.TabIndex = 93;
            // 
            // MovimientosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1031, 718);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovimientosBancarios";
            this.Text = "MovimientosBancarios";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_vistaTransacciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_stCon;
        private System.Windows.Forms.TextBox txt_valorTrans;
        private System.Windows.Forms.ComboBox cb_tipoTrans;
        private System.Windows.Forms.TextBox txt_ttransaccion;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.RichTextBox txt_descripcionTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelarTransaccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rtrans;
        private System.Windows.Forms.TextBox txt_valorTransferencia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}