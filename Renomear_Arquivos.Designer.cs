namespace Renomear_Arquivos
{
    partial class Renomear_Arquivos
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
            this.textBox_diretorio = new System.Windows.Forms.TextBox();
            this.button_diretorio = new System.Windows.Forms.Button();
            this.textBox_nomes_originais = new System.Windows.Forms.TextBox();
            this.textBox_nomes_modificados = new System.Windows.Forms.TextBox();
            this.textBox_outro_formato = new System.Windows.Forms.TextBox();
            this.button_remover = new System.Windows.Forms.Button();
            this.comboBox_formatos = new System.Windows.Forms.ComboBox();
            this.groupBox_Formato = new System.Windows.Forms.GroupBox();
            this.button_atualizar2 = new System.Windows.Forms.Button();
            this.groupBox_Remover = new System.Windows.Forms.GroupBox();
            this.textBox_quant_remover_caracteres = new System.Windows.Forms.TextBox();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.button_limpar_campos = new System.Windows.Forms.Button();
            this.groupBox_Adicionar = new System.Windows.Forms.GroupBox();
            this.textBox_adicionar_caracteres = new System.Windows.Forms.TextBox();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_quantidade_original = new System.Windows.Forms.Label();
            this.groupBox_maiusculas_minusculas = new System.Windows.Forms.GroupBox();
            this.button_minusculas = new System.Windows.Forms.Button();
            this.button_maiusculas = new System.Windows.Forms.Button();
            this.button_aplicar_mudancas3 = new System.Windows.Forms.Button();
            this.groupBox_Formato.SuspendLayout();
            this.groupBox_Remover.SuspendLayout();
            this.groupBox_Adicionar.SuspendLayout();
            this.groupBox_maiusculas_minusculas.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_diretorio
            // 
            this.textBox_diretorio.Location = new System.Drawing.Point(41, 12);
            this.textBox_diretorio.Name = "textBox_diretorio";
            this.textBox_diretorio.Size = new System.Drawing.Size(700, 20);
            this.textBox_diretorio.TabIndex = 1;
            // 
            // button_diretorio
            // 
            this.button_diretorio.Location = new System.Drawing.Point(747, 10);
            this.button_diretorio.Name = "button_diretorio";
            this.button_diretorio.Size = new System.Drawing.Size(31, 23);
            this.button_diretorio.TabIndex = 2;
            this.button_diretorio.Text = ". . .";
            this.button_diretorio.UseVisualStyleBackColor = true;
            this.button_diretorio.Click += new System.EventHandler(this.button_diretorio_Click);
            // 
            // textBox_nomes_originais
            // 
            this.textBox_nomes_originais.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomes_originais.Location = new System.Drawing.Point(12, 38);
            this.textBox_nomes_originais.Multiline = true;
            this.textBox_nomes_originais.Name = "textBox_nomes_originais";
            this.textBox_nomes_originais.ReadOnly = true;
            this.textBox_nomes_originais.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_nomes_originais.Size = new System.Drawing.Size(380, 400);
            this.textBox_nomes_originais.TabIndex = 3;
            // 
            // textBox_nomes_modificados
            // 
            this.textBox_nomes_modificados.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.textBox_nomes_modificados.Location = new System.Drawing.Point(398, 38);
            this.textBox_nomes_modificados.Multiline = true;
            this.textBox_nomes_modificados.Name = "textBox_nomes_modificados";
            this.textBox_nomes_modificados.ReadOnly = true;
            this.textBox_nomes_modificados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_nomes_modificados.Size = new System.Drawing.Size(380, 400);
            this.textBox_nomes_modificados.TabIndex = 4;
            // 
            // textBox_outro_formato
            // 
            this.textBox_outro_formato.Enabled = false;
            this.textBox_outro_formato.Location = new System.Drawing.Point(87, 19);
            this.textBox_outro_formato.Name = "textBox_outro_formato";
            this.textBox_outro_formato.Size = new System.Drawing.Size(61, 20);
            this.textBox_outro_formato.TabIndex = 5;
            this.textBox_outro_formato.Text = ".pdf";
            // 
            // button_remover
            // 
            this.button_remover.Location = new System.Drawing.Point(6, 21);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(75, 23);
            this.button_remover.TabIndex = 8;
            this.button_remover.Text = "REMOVER";
            this.button_remover.UseVisualStyleBackColor = true;
            this.button_remover.Click += new System.EventHandler(this.button_remover_Click);
            // 
            // comboBox_formatos
            // 
            this.comboBox_formatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_formatos.FormattingEnabled = true;
            this.comboBox_formatos.Items.AddRange(new object[] {
            ".PDF",
            ".TIF",
            ".TIFF",
            ".PNG",
            ".JPG",
            ".GIF",
            ".TXT",
            ".DOC",
            ".DOCX",
            ".XLS",
            ".XLSX",
            ".MP4",
            "+MAIS"});
            this.comboBox_formatos.Location = new System.Drawing.Point(6, 19);
            this.comboBox_formatos.Name = "comboBox_formatos";
            this.comboBox_formatos.Size = new System.Drawing.Size(75, 21);
            this.comboBox_formatos.TabIndex = 9;
            this.comboBox_formatos.SelectedIndexChanged += new System.EventHandler(this.comboBox_formatos_SelectedIndexChanged_1);
            // 
            // groupBox_Formato
            // 
            this.groupBox_Formato.Controls.Add(this.button_atualizar2);
            this.groupBox_Formato.Controls.Add(this.textBox_outro_formato);
            this.groupBox_Formato.Controls.Add(this.comboBox_formatos);
            this.groupBox_Formato.Location = new System.Drawing.Point(792, 12);
            this.groupBox_Formato.Name = "groupBox_Formato";
            this.groupBox_Formato.Size = new System.Drawing.Size(186, 52);
            this.groupBox_Formato.TabIndex = 11;
            this.groupBox_Formato.TabStop = false;
            this.groupBox_Formato.Text = "FORMATO";
            // 
            // button_atualizar2
            // 
            this.button_atualizar2.Enabled = false;
            this.button_atualizar2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_atualizar2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar2.Location = new System.Drawing.Point(154, 17);
            this.button_atualizar2.Name = "button_atualizar2";
            this.button_atualizar2.Size = new System.Drawing.Size(23, 23);
            this.button_atualizar2.TabIndex = 14;
            this.button_atualizar2.Text = "⟳";
            this.button_atualizar2.UseVisualStyleBackColor = true;
            this.button_atualizar2.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // groupBox_Remover
            // 
            this.groupBox_Remover.Controls.Add(this.textBox_quant_remover_caracteres);
            this.groupBox_Remover.Controls.Add(this.button_remover);
            this.groupBox_Remover.Location = new System.Drawing.Point(792, 70);
            this.groupBox_Remover.Name = "groupBox_Remover";
            this.groupBox_Remover.Size = new System.Drawing.Size(186, 55);
            this.groupBox_Remover.TabIndex = 12;
            this.groupBox_Remover.TabStop = false;
            this.groupBox_Remover.Text = "REMOVER CARACTERES";
            // 
            // textBox_quant_remover_caracteres
            // 
            this.textBox_quant_remover_caracteres.Location = new System.Drawing.Point(87, 23);
            this.textBox_quant_remover_caracteres.Name = "textBox_quant_remover_caracteres";
            this.textBox_quant_remover_caracteres.Size = new System.Drawing.Size(90, 20);
            this.textBox_quant_remover_caracteres.TabIndex = 9;
            // 
            // button_atualizar
            // 
            this.button_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_atualizar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_atualizar.Location = new System.Drawing.Point(12, 10);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(23, 23);
            this.button_atualizar.TabIndex = 13;
            this.button_atualizar.Text = "⟳";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // button_limpar_campos
            // 
            this.button_limpar_campos.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar_campos.Location = new System.Drawing.Point(947, 407);
            this.button_limpar_campos.Name = "button_limpar_campos";
            this.button_limpar_campos.Size = new System.Drawing.Size(31, 31);
            this.button_limpar_campos.TabIndex = 14;
            this.button_limpar_campos.Text = "🗑";
            this.button_limpar_campos.UseVisualStyleBackColor = true;
            this.button_limpar_campos.Click += new System.EventHandler(this.button_Limpar);
            // 
            // groupBox_Adicionar
            // 
            this.groupBox_Adicionar.Controls.Add(this.textBox_adicionar_caracteres);
            this.groupBox_Adicionar.Controls.Add(this.button_adicionar);
            this.groupBox_Adicionar.Location = new System.Drawing.Point(792, 160);
            this.groupBox_Adicionar.Name = "groupBox_Adicionar";
            this.groupBox_Adicionar.Size = new System.Drawing.Size(186, 55);
            this.groupBox_Adicionar.TabIndex = 15;
            this.groupBox_Adicionar.TabStop = false;
            this.groupBox_Adicionar.Text = "ADICIONAR CARACTERES";
            // 
            // textBox_adicionar_caracteres
            // 
            this.textBox_adicionar_caracteres.Location = new System.Drawing.Point(87, 22);
            this.textBox_adicionar_caracteres.Name = "textBox_adicionar_caracteres";
            this.textBox_adicionar_caracteres.Size = new System.Drawing.Size(90, 20);
            this.textBox_adicionar_caracteres.TabIndex = 13;
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(6, 19);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 12;
            this.button_adicionar.Text = "ADICIONAR";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(807, 441);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/DanielSvoboda";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_quantidade_original
            // 
            this.label_quantidade_original.AutoSize = true;
            this.label_quantidade_original.Location = new System.Drawing.Point(12, 441);
            this.label_quantidade_original.Name = "label_quantidade_original";
            this.label_quantidade_original.Size = new System.Drawing.Size(56, 13);
            this.label_quantidade_original.TabIndex = 18;
            this.label_quantidade_original.Text = "0 arquivos";
            // 
            // groupBox_maiusculas_minusculas
            // 
            this.groupBox_maiusculas_minusculas.Controls.Add(this.button_minusculas);
            this.groupBox_maiusculas_minusculas.Controls.Add(this.button_maiusculas);
            this.groupBox_maiusculas_minusculas.Location = new System.Drawing.Point(792, 250);
            this.groupBox_maiusculas_minusculas.Name = "groupBox_maiusculas_minusculas";
            this.groupBox_maiusculas_minusculas.Size = new System.Drawing.Size(186, 55);
            this.groupBox_maiusculas_minusculas.TabIndex = 16;
            this.groupBox_maiusculas_minusculas.TabStop = false;
            this.groupBox_maiusculas_minusculas.Text = "MAIÚSCULAS / minúsculas";
            // 
            // button_minusculas
            // 
            this.button_minusculas.Location = new System.Drawing.Point(96, 19);
            this.button_minusculas.Name = "button_minusculas";
            this.button_minusculas.Size = new System.Drawing.Size(83, 23);
            this.button_minusculas.TabIndex = 13;
            this.button_minusculas.Text = "minúsculas";
            this.button_minusculas.UseVisualStyleBackColor = true;
            this.button_minusculas.Click += new System.EventHandler(this.button_minusculas_Click);
            // 
            // button_maiusculas
            // 
            this.button_maiusculas.Location = new System.Drawing.Point(6, 19);
            this.button_maiusculas.Name = "button_maiusculas";
            this.button_maiusculas.Size = new System.Drawing.Size(84, 23);
            this.button_maiusculas.TabIndex = 12;
            this.button_maiusculas.Text = "MAIÚSCULAS";
            this.button_maiusculas.UseVisualStyleBackColor = true;
            this.button_maiusculas.Click += new System.EventHandler(this.button_maiusculas_Click);
            // 
            // button_aplicar_mudancas3
            // 
            this.button_aplicar_mudancas3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_aplicar_mudancas3.Location = new System.Drawing.Point(792, 340);
            this.button_aplicar_mudancas3.Name = "button_aplicar_mudancas3";
            this.button_aplicar_mudancas3.Size = new System.Drawing.Size(186, 23);
            this.button_aplicar_mudancas3.TabIndex = 12;
            this.button_aplicar_mudancas3.Text = "APLICAR MUDANÇAS";
            this.button_aplicar_mudancas3.UseVisualStyleBackColor = true;
            this.button_aplicar_mudancas3.Click += new System.EventHandler(this.button_aplicar_mudancas_Click);
            // 
            // Renomear_Arquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 458);
            this.Controls.Add(this.groupBox_maiusculas_minusculas);
            this.Controls.Add(this.button_aplicar_mudancas3);
            this.Controls.Add(this.label_quantidade_original);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox_Adicionar);
            this.Controls.Add(this.button_limpar_campos);
            this.Controls.Add(this.button_atualizar);
            this.Controls.Add(this.groupBox_Remover);
            this.Controls.Add(this.groupBox_Formato);
            this.Controls.Add(this.textBox_nomes_modificados);
            this.Controls.Add(this.textBox_nomes_originais);
            this.Controls.Add(this.button_diretorio);
            this.Controls.Add(this.textBox_diretorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Renomear_Arquivos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RENOMEAR ARQUIVOS";
            this.groupBox_Formato.ResumeLayout(false);
            this.groupBox_Formato.PerformLayout();
            this.groupBox_Remover.ResumeLayout(false);
            this.groupBox_Remover.PerformLayout();
            this.groupBox_Adicionar.ResumeLayout(false);
            this.groupBox_Adicionar.PerformLayout();
            this.groupBox_maiusculas_minusculas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_diretorio;
        private System.Windows.Forms.Button button_diretorio;
        private System.Windows.Forms.TextBox textBox_nomes_originais;
        private System.Windows.Forms.TextBox textBox_nomes_modificados;
        private System.Windows.Forms.TextBox textBox_outro_formato;
        private System.Windows.Forms.Button button_remover;
        private System.Windows.Forms.ComboBox comboBox_formatos;
        private System.Windows.Forms.GroupBox groupBox_Formato;
        private System.Windows.Forms.GroupBox groupBox_Remover;
        private System.Windows.Forms.TextBox textBox_quant_remover_caracteres;
        private System.Windows.Forms.Button button_atualizar;
        private System.Windows.Forms.Button button_atualizar2;
        private System.Windows.Forms.Button button_limpar_campos;
        private System.Windows.Forms.GroupBox groupBox_Adicionar;
        private System.Windows.Forms.TextBox textBox_adicionar_caracteres;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_quantidade_original;
        private System.Windows.Forms.GroupBox groupBox_maiusculas_minusculas;
        private System.Windows.Forms.Button button_minusculas;
        private System.Windows.Forms.Button button_aplicar_mudancas3;
        private System.Windows.Forms.Button button_maiusculas;
    }
}

