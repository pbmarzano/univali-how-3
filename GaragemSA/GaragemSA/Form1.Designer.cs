namespace GaragemSA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnnovo = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbProprietario = new System.Windows.Forms.TextBox();
            this.tbHoraSaida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tbHoraEntrada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnchave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.tbSituacao = new System.Windows.Forms.TextBox();
            this.cbveiculo = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelcabecalho = new System.Windows.Forms.Panel();
            this.lblcapacidade = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtdata = new System.Windows.Forms.DateTimePicker();
            this.btnpesquisa = new System.Windows.Forms.Button();
            this.lbldata = new System.Windows.Forms.Label();
            this.chbexcluidos = new System.Windows.Forms.CheckBox();
            this.chbpagos = new System.Windows.Forms.CheckBox();
            this.chbabertos = new System.Windows.Forms.CheckBox();
            this.chbacumulado = new System.Windows.Forms.CheckBox();
            this.lblacumulado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelcabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(23, 10);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(97, 20);
            this.btnnovo.TabIndex = 98;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(682, 60);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(97, 22);
            this.btndeletar.TabIndex = 7;
            this.btndeletar.Text = "Excluir";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(682, 34);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(97, 20);
            this.btnatualizar.TabIndex = 6;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(682, 8);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(97, 20);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(191, 10);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(35, 20);
            this.tbID.TabIndex = 99;
            // 
            // tbProprietario
            // 
            this.tbProprietario.Location = new System.Drawing.Point(567, 10);
            this.tbProprietario.Name = "tbProprietario";
            this.tbProprietario.Size = new System.Drawing.Size(109, 20);
            this.tbProprietario.TabIndex = 2;
            // 
            // tbHoraSaida
            // 
            this.tbHoraSaida.Location = new System.Drawing.Point(410, 128);
            this.tbHoraSaida.Name = "tbHoraSaida";
            this.tbHoraSaida.Size = new System.Drawing.Size(73, 20);
            this.tbHoraSaida.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Proprietário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Situação:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(561, 117);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(67, 31);
            this.lbltotal.TabIndex = 19;
            this.lbltotal.Text = "0,00";
            // 
            // tbHoraEntrada
            // 
            this.tbHoraEntrada.Location = new System.Drawing.Point(410, 78);
            this.tbHoraEntrada.Name = "tbHoraEntrada";
            this.tbHoraEntrada.Size = new System.Drawing.Size(73, 20);
            this.tbHoraEntrada.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tipo:";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(400, 10);
            this.tbPlaca.MaxLength = 8;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(92, 20);
            this.tbPlaca.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnVeiculo,
            this.ColumnPlaca,
            this.ColumnProprietario,
            this.ColumnSituacao,
            this.ColumnEntrada,
            this.ColumnSaida,
            this.Columnchave});
            this.dataGridView1.Location = new System.Drawing.Point(4, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 239);
            this.dataGridView1.TabIndex = 999;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.Width = 40;
            // 
            // ColumnVeiculo
            // 
            this.ColumnVeiculo.HeaderText = "Veículo";
            this.ColumnVeiculo.Name = "ColumnVeiculo";
            this.ColumnVeiculo.ReadOnly = true;
            this.ColumnVeiculo.Width = 60;
            // 
            // ColumnPlaca
            // 
            this.ColumnPlaca.HeaderText = "Placa";
            this.ColumnPlaca.Name = "ColumnPlaca";
            this.ColumnPlaca.ReadOnly = true;
            this.ColumnPlaca.Width = 60;
            // 
            // ColumnProprietario
            // 
            this.ColumnProprietario.HeaderText = "Proprietario";
            this.ColumnProprietario.Name = "ColumnProprietario";
            this.ColumnProprietario.ReadOnly = true;
            this.ColumnProprietario.Width = 110;
            // 
            // ColumnSituacao
            // 
            this.ColumnSituacao.HeaderText = "Situação";
            this.ColumnSituacao.Name = "ColumnSituacao";
            this.ColumnSituacao.ReadOnly = true;
            this.ColumnSituacao.Width = 300;
            // 
            // ColumnEntrada
            // 
            this.ColumnEntrada.HeaderText = "Entrada";
            this.ColumnEntrada.Name = "ColumnEntrada";
            this.ColumnEntrada.ReadOnly = true;
            this.ColumnEntrada.Width = 50;
            // 
            // ColumnSaida
            // 
            this.ColumnSaida.HeaderText = "Saida";
            this.ColumnSaida.Name = "ColumnSaida";
            this.ColumnSaida.ReadOnly = true;
            this.ColumnSaida.Width = 50;
            // 
            // Columnchave
            // 
            this.Columnchave.HeaderText = "Chave";
            this.Columnchave.Name = "Columnchave";
            this.Columnchave.Width = 50;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(344, 78);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(60, 20);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(344, 127);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(60, 23);
            this.btnSaida.TabIndex = 6;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // tbSituacao
            // 
            this.tbSituacao.Location = new System.Drawing.Point(78, 49);
            this.tbSituacao.Name = "tbSituacao";
            this.tbSituacao.Size = new System.Drawing.Size(598, 20);
            this.tbSituacao.TabIndex = 3;
            // 
            // cbveiculo
            // 
            this.cbveiculo.FormattingEnabled = true;
            this.cbveiculo.Items.AddRange(new object[] {
            "CARRO",
            "MOTO"});
            this.cbveiculo.Location = new System.Drawing.Point(260, 9);
            this.cbveiculo.Name = "cbveiculo";
            this.cbveiculo.Size = new System.Drawing.Size(91, 21);
            this.cbveiculo.TabIndex = 0;
            this.cbveiculo.Text = "Carro";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(682, 88);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(97, 56);
            this.btnPagar.TabIndex = 1000;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 1002;
            this.label2.Text = "R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 46);
            this.label7.TabIndex = 1003;
            this.label7.Text = "GARAGENS SA.";
            // 
            // panelcabecalho
            // 
            this.panelcabecalho.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelcabecalho.Controls.Add(this.lblcapacidade);
            this.panelcabecalho.Controls.Add(this.lbl2);
            this.panelcabecalho.Controls.Add(this.lbl1);
            this.panelcabecalho.Controls.Add(this.tbHoraEntrada);
            this.panelcabecalho.Controls.Add(this.label7);
            this.panelcabecalho.Controls.Add(this.btnnovo);
            this.panelcabecalho.Controls.Add(this.label2);
            this.panelcabecalho.Controls.Add(this.btndeletar);
            this.panelcabecalho.Controls.Add(this.btnPagar);
            this.panelcabecalho.Controls.Add(this.btnatualizar);
            this.panelcabecalho.Controls.Add(this.cbveiculo);
            this.panelcabecalho.Controls.Add(this.btnsalvar);
            this.panelcabecalho.Controls.Add(this.tbSituacao);
            this.panelcabecalho.Controls.Add(this.tbID);
            this.panelcabecalho.Controls.Add(this.btnSaida);
            this.panelcabecalho.Controls.Add(this.tbProprietario);
            this.panelcabecalho.Controls.Add(this.btnEntrada);
            this.panelcabecalho.Controls.Add(this.tbHoraSaida);
            this.panelcabecalho.Controls.Add(this.label1);
            this.panelcabecalho.Controls.Add(this.tbPlaca);
            this.panelcabecalho.Controls.Add(this.label3);
            this.panelcabecalho.Controls.Add(this.label6);
            this.panelcabecalho.Controls.Add(this.label4);
            this.panelcabecalho.Controls.Add(this.label5);
            this.panelcabecalho.Controls.Add(this.lbltotal);
            this.panelcabecalho.Location = new System.Drawing.Point(-19, 0);
            this.panelcabecalho.Name = "panelcabecalho";
            this.panelcabecalho.Size = new System.Drawing.Size(815, 169);
            this.panelcabecalho.TabIndex = 1004;
            // 
            // lblcapacidade
            // 
            this.lblcapacidade.AutoSize = true;
            this.lblcapacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapacidade.Location = new System.Drawing.Point(188, 104);
            this.lblcapacidade.Name = "lblcapacidade";
            this.lblcapacidade.Size = new System.Drawing.Size(0, 17);
            this.lblcapacidade.TabIndex = 1006;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(28, 108);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(154, 17);
            this.lbl2.TabIndex = 1005;
            this.lbl2.Text = "Veiculos Estacionados:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(67, 69);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(209, 25);
            this.lbl1.TabIndex = 1004;
            this.lbl1.Text = "Capacidade 20 Carros";
            // 
            // dtdata
            // 
            this.dtdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdata.Location = new System.Drawing.Point(263, 203);
            this.dtdata.Name = "dtdata";
            this.dtdata.Size = new System.Drawing.Size(87, 20);
            this.dtdata.TabIndex = 1007;
            this.dtdata.Value = new System.DateTime(2020, 9, 17, 15, 5, 40, 0);
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisa.Image")));
            this.btnpesquisa.Location = new System.Drawing.Point(362, 206);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.Size = new System.Drawing.Size(23, 20);
            this.btnpesquisa.TabIndex = 1006;
            this.btnpesquisa.UseVisualStyleBackColor = true;
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(221, 210);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(36, 13);
            this.lbldata.TabIndex = 1004;
            this.lbldata.Text = "DATA";
            // 
            // chbexcluidos
            // 
            this.chbexcluidos.AutoSize = true;
            this.chbexcluidos.Location = new System.Drawing.Point(80, 208);
            this.chbexcluidos.Name = "chbexcluidos";
            this.chbexcluidos.Size = new System.Drawing.Size(73, 17);
            this.chbexcluidos.TabIndex = 1008;
            this.chbexcluidos.Text = "Excluídos";
            this.chbexcluidos.UseVisualStyleBackColor = true;
            // 
            // chbpagos
            // 
            this.chbpagos.AutoSize = true;
            this.chbpagos.Location = new System.Drawing.Point(159, 208);
            this.chbpagos.Name = "chbpagos";
            this.chbpagos.Size = new System.Drawing.Size(56, 17);
            this.chbpagos.TabIndex = 1009;
            this.chbpagos.Text = "Pagos";
            this.chbpagos.UseVisualStyleBackColor = true;
            // 
            // chbabertos
            // 
            this.chbabertos.AutoSize = true;
            this.chbabertos.Location = new System.Drawing.Point(12, 209);
            this.chbabertos.Name = "chbabertos";
            this.chbabertos.Size = new System.Drawing.Size(62, 17);
            this.chbabertos.TabIndex = 1010;
            this.chbabertos.Text = "Abertos";
            this.chbabertos.UseVisualStyleBackColor = true;
            // 
            // chbacumulado
            // 
            this.chbacumulado.AutoSize = true;
            this.chbacumulado.Location = new System.Drawing.Point(643, 175);
            this.chbacumulado.Name = "chbacumulado";
            this.chbacumulado.Size = new System.Drawing.Size(117, 17);
            this.chbacumulado.TabIndex = 1011;
            this.chbacumulado.Text = "Mostrar Acumulado";
            this.chbacumulado.UseVisualStyleBackColor = true;
            this.chbacumulado.CheckedChanged += new System.EventHandler(this.chbacumulado_CheckedChanged);
            // 
            // lblacumulado
            // 
            this.lblacumulado.AutoSize = true;
            this.lblacumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacumulado.Location = new System.Drawing.Point(667, 206);
            this.lblacumulado.Name = "lblacumulado";
            this.lblacumulado.Size = new System.Drawing.Size(0, 25);
            this.lblacumulado.TabIndex = 1012;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1013;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(631, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 1014;
            this.label9.Text = "R$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 518);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblacumulado);
            this.Controls.Add(this.chbacumulado);
            this.Controls.Add(this.chbabertos);
            this.Controls.Add(this.chbpagos);
            this.Controls.Add(this.chbexcluidos);
            this.Controls.Add(this.dtdata);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.panelcabecalho);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "GaragenSA";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelcabecalho.ResumeLayout(false);
            this.panelcabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbProprietario;
        private System.Windows.Forms.TextBox tbHoraSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox tbHoraEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.TextBox tbSituacao;
        private System.Windows.Forms.ComboBox cbveiculo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelcabecalho;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Button btnpesquisa;
        private System.Windows.Forms.DateTimePicker dtdata;
        private System.Windows.Forms.CheckBox chbexcluidos;
        private System.Windows.Forms.CheckBox chbpagos;
        private System.Windows.Forms.CheckBox chbabertos;
        private System.Windows.Forms.CheckBox chbacumulado;
        private System.Windows.Forms.Label lblacumulado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnchave;
        private System.Windows.Forms.Label lblcapacidade;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}

