
namespace Wesley
{
    partial class Form1
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
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.lblNivelDor = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtNivelDor = new System.Windows.Forms.TextBox();
            this.rbnCapturaNao = new System.Windows.Forms.RadioButton();
            this.rbnCapturaSim = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.falseData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Captura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtID = new System.Windows.Forms.TextBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(349, 24);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(430, 24);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(349, 257);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(430, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(346, 69);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(346, 108);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(34, 13);
            this.lblCusto.TabIndex = 5;
            this.lblCusto.Text = "Custo";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(346, 146);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 6;
            this.lblDistancia.Text = "Distância";
            // 
            // lblCaptura
            // 
            this.lblCaptura.AutoSize = true;
            this.lblCaptura.Location = new System.Drawing.Point(346, 184);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(44, 13);
            this.lblCaptura.TabIndex = 7;
            this.lblCaptura.Text = "Captura";
            // 
            // lblNivelDor
            // 
            this.lblNivelDor.AutoSize = true;
            this.lblNivelDor.Location = new System.Drawing.Point(346, 218);
            this.lblNivelDor.Name = "lblNivelDor";
            this.lblNivelDor.Size = new System.Drawing.Size(51, 13);
            this.lblNivelDor.TabIndex = 8;
            this.lblNivelDor.Text = "Nível dor";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(403, 146);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 11;
            // 
            // txtNivelDor
            // 
            this.txtNivelDor.Location = new System.Drawing.Point(403, 215);
            this.txtNivelDor.MaxLength = 2;
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(100, 20);
            this.txtNivelDor.TabIndex = 12;
            // 
            // rbnCapturaNao
            // 
            this.rbnCapturaNao.AutoSize = true;
            this.rbnCapturaNao.Location = new System.Drawing.Point(403, 182);
            this.rbnCapturaNao.Name = "rbnCapturaNao";
            this.rbnCapturaNao.Size = new System.Drawing.Size(45, 17);
            this.rbnCapturaNao.TabIndex = 13;
            this.rbnCapturaNao.TabStop = true;
            this.rbnCapturaNao.Text = "Não";
            this.rbnCapturaNao.UseVisualStyleBackColor = true;
            // 
            // rbnCapturaSim
            // 
            this.rbnCapturaSim.AutoSize = true;
            this.rbnCapturaSim.Location = new System.Drawing.Point(454, 182);
            this.rbnCapturaSim.Name = "rbnCapturaSim";
            this.rbnCapturaSim.Size = new System.Drawing.Size(42, 17);
            this.rbnCapturaSim.TabIndex = 14;
            this.rbnCapturaSim.TabStop = true;
            this.rbnCapturaSim.Text = "Sim";
            this.rbnCapturaSim.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.falseData,
            this.cData,
            this.Captura,
            this.cDor,
            this.cID});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 272);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // falseData
            // 
            this.falseData.Text = "";
            this.falseData.Width = 0;
            // 
            // cData
            // 
            this.cData.Text = "Data";
            this.cData.Width = 100;
            // 
            // Captura
            // 
            this.Captura.Text = "Captura";
            this.Captura.Width = 100;
            // 
            // cDor
            // 
            this.cDor.Text = "Nídel de dor";
            this.cDor.Width = 100;
            // 
            // cID
            // 
            this.cID.Text = "ID_ocultado";
            this.cID.Width = 0;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(297, 302);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(19, 20);
            this.txtID.TabIndex = 18;
            this.txtID.Visible = false;
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(403, 66);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(100, 20);
            this.mtxtData.TabIndex = 19;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(403, 105);
            this.txtCusto.MaxLength = 5;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 301);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbnCapturaSim);
            this.Controls.Add(this.rbnCapturaNao);
            this.Controls.Add(this.txtNivelDor);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblNivelDor);
            this.Controls.Add(this.lblCaptura);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "ACME FLIGHT MANAGER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCaptura;
        private System.Windows.Forms.Label lblNivelDor;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtNivelDor;
        private System.Windows.Forms.RadioButton rbnCapturaNao;
        private System.Windows.Forms.RadioButton rbnCapturaSim;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader falseData;
        private System.Windows.Forms.ColumnHeader cData;
        private System.Windows.Forms.ColumnHeader Captura;
        private System.Windows.Forms.ColumnHeader cDor;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.TextBox txtCusto;
    }
}

