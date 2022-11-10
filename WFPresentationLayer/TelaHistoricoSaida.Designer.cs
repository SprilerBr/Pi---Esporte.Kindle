﻿namespace WFPresentationLayer
{
    partial class TelaHistoricoSaida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelButtos = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnTabelaSaida = new System.Windows.Forms.Button();
            this.panelDesktopSaida = new System.Windows.Forms.Panel();
            this.dtHistoricoSaida = new System.Windows.Forms.DataGridView();
            this.dtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFormaPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtos.SuspendLayout();
            this.panelDesktopSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHistoricoSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtos
            // 
            this.panelButtos.Controls.Add(this.btnInfo);
            this.panelButtos.Controls.Add(this.btnTabelaSaida);
            this.panelButtos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtos.Location = new System.Drawing.Point(814, 0);
            this.panelButtos.Name = "panelButtos";
            this.panelButtos.Size = new System.Drawing.Size(188, 598);
            this.panelButtos.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(30, 119);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(137, 85);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Informções da Saída";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnTabelaSaida
            // 
            this.btnTabelaSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelaSaida.Location = new System.Drawing.Point(30, 28);
            this.btnTabelaSaida.Name = "btnTabelaSaida";
            this.btnTabelaSaida.Size = new System.Drawing.Size(137, 85);
            this.btnTabelaSaida.TabIndex = 0;
            this.btnTabelaSaida.Text = "Tabela Saida";
            this.btnTabelaSaida.UseVisualStyleBackColor = true;
            this.btnTabelaSaida.Click += new System.EventHandler(this.btnTabelaSaida_Click);
            // 
            // panelDesktopSaida
            // 
            this.panelDesktopSaida.Controls.Add(this.dtHistoricoSaida);
            this.panelDesktopSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopSaida.Location = new System.Drawing.Point(0, 0);
            this.panelDesktopSaida.Name = "panelDesktopSaida";
            this.panelDesktopSaida.Size = new System.Drawing.Size(814, 598);
            this.panelDesktopSaida.TabIndex = 1;
            // 
            // dtHistoricoSaida
            // 
            this.dtHistoricoSaida.AllowUserToAddRows = false;
            this.dtHistoricoSaida.AllowUserToDeleteRows = false;
            this.dtHistoricoSaida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistoricoSaida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtHistoricoSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHistoricoSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtID,
            this.dtCliente,
            this.dtFuncionario,
            this.dtData,
            this.dtFormaPag,
            this.dtValorTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtHistoricoSaida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtHistoricoSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtHistoricoSaida.Location = new System.Drawing.Point(0, 0);
            this.dtHistoricoSaida.Name = "dtHistoricoSaida";
            this.dtHistoricoSaida.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtHistoricoSaida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtHistoricoSaida.RowTemplate.Height = 25;
            this.dtHistoricoSaida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHistoricoSaida.Size = new System.Drawing.Size(814, 598);
            this.dtHistoricoSaida.TabIndex = 2;
            // 
            // dtID
            // 
            this.dtID.HeaderText = "ID";
            this.dtID.Name = "dtID";
            this.dtID.ReadOnly = true;
            // 
            // dtCliente
            // 
            this.dtCliente.HeaderText = "Cliente";
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.ReadOnly = true;
            // 
            // dtFuncionario
            // 
            this.dtFuncionario.HeaderText = "Funcionário";
            this.dtFuncionario.Name = "dtFuncionario";
            this.dtFuncionario.ReadOnly = true;
            // 
            // dtData
            // 
            this.dtData.HeaderText = "Data";
            this.dtData.Name = "dtData";
            this.dtData.ReadOnly = true;
            // 
            // dtFormaPag
            // 
            this.dtFormaPag.HeaderText = "Forma de Pagamento";
            this.dtFormaPag.Name = "dtFormaPag";
            this.dtFormaPag.ReadOnly = true;
            // 
            // dtValorTotal
            // 
            this.dtValorTotal.HeaderText = "Valor Total";
            this.dtValorTotal.Name = "dtValorTotal";
            this.dtValorTotal.ReadOnly = true;
            // 
            // TelaHistoricoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 598);
            this.Controls.Add(this.panelDesktopSaida);
            this.Controls.Add(this.panelButtos);
            this.Name = "TelaHistoricoSaida";
            this.Text = "TelaHistoricoSaida";
            this.Load += new System.EventHandler(this.TelaHistoricoSaida_Load);
            this.panelButtos.ResumeLayout(false);
            this.panelDesktopSaida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHistoricoSaida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelButtos;
        private Button btnTabelaSaida;
        private Button btnInfo;
        private Panel panelDesktopSaida;
        private DataGridView dtHistoricoSaida;
        private DataGridViewTextBoxColumn dtID;
        private DataGridViewTextBoxColumn dtCliente;
        private DataGridViewTextBoxColumn dtFuncionario;
        private DataGridViewTextBoxColumn dtData;
        private DataGridViewTextBoxColumn dtFormaPag;
        private DataGridViewTextBoxColumn dtValorTotal;
    }
}