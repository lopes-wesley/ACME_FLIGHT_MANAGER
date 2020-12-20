using System;
using System.Windows.Forms;
using Wesley.Connection;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Wesley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
        }        

        // Botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            LimpaCampos();
            ShowList();
        }     

        // Exibe os itens da base dados na listView
        private void ShowList()
        {
            DataTable dt = new DataTable();
            dt = Connection.Connection.ExibirTudo();

            listView1.Items.Clear();

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {

                DataRow drow = dt.Rows[i];

                if (drow.RowState != DataRowState.Deleted)
                {
                    ListViewItem item = new ListViewItem();                   
                    item.SubItems.Add(drow["DATA_VOO"].ToString());
                    item.SubItems.Add(drow["CAPTURA"].ToString());
                    item.SubItems.Add(drow["NIVEL_DOR"].ToString());
                    item.SubItems.Add(drow["ID_VOO"].ToString());

                    listView1.Items.Add(item);
                }
            }
        }

        // Botão para incluir os dados na base
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            VOO voo = new VOO();
            try
            {              
                voo.Data_VOO = mtxtData.Text;
                voo.Custo = Convert.ToDouble(txtCusto.Text);
                voo.Distancia = Convert.ToInt32(txtDistancia.Text);                
                voo.Nivel_Dor = Convert.ToInt32(txtNivelDor.Text);

                if (rbnCapturaNao.Checked && rbnCapturaSim.Checked == false)
                {
                    voo.Captura = "N";
                }
                else if (rbnCapturaSim.Checked && rbnCapturaNao.Checked == false)
                {
                    voo.Captura = "S";                }                      

                int NivelDor = Convert.ToInt32(txtNivelDor.Text);

                if (!(NivelDor > 10 || NivelDor < 0 || rbnCapturaSim.Checked == false && rbnCapturaNao.Checked == false))                
                {
                    Connection.Connection.InsereDados(voo);
                    LimpaCampos();
                    ShowList();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
        }

        // No carregamento do WindowsForm chama os métodos de Criação do BD e preenche a listView com os dados da tabela TB_VOO
        private void Form1_Load(object sender, EventArgs e)
        {              
            Connection.Connection.CriarBancoSQLite();
            ShowList();            
            mtxtData.Focus();
            
        }        

        // Preenche campos os TextBox com os dados da tabela TB_VOO
        private void PreencheCampos(SQLiteDataReader dados)
        {
            try
            {
                while (dados.Read())
                {
                    mtxtData.Text = dados["DATA_VOO"].ToString();
                    txtCusto.Text = dados["CUSTO"].ToString();
                    txtDistancia.Text = dados["DISTANCIA"].ToString();
                    txtNivelDor.Text = dados["NIVEL_DOR"].ToString();
                    txtID.Text = dados["ID_VOO"].ToString();

                    if (dados["CAPTURA"].ToString().Equals("S"))
                    {
                        rbnCapturaSim.Checked = true;
                    }
                    else if (dados["CAPTURA"].ToString().Equals("N"))
                    {
                        rbnCapturaNao.Checked = true;
                    }

                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    
                }
                dados.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }       

        // Ao selecionar um campo do ListView, chama o método ProcurarDados para exibir os dados nos TextBox
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                int codigo = Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text);                
                PreencheCampos(Connection.Connection.ProcurarDados(codigo));
            }            
        }

        // Botão de excluir os dados da base de dados
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);
                Connection.Connection.RemoveDados(codigo);
                ShowList();                
                LimpaCampos();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                MessageBox.Show("Por favor, selecione um item da lista para exclusão!");
            }
        }

        // Botão para efetuar uma alteração nos dados da tabela TB_VOO
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               
                VOO voo = new VOO();
                voo.Data_VOO = mtxtData.Text;
                voo.Custo = Convert.ToDouble(txtCusto.Text);
                voo.Distancia = Convert.ToInt32(txtDistancia.Text);               
                voo.Nivel_Dor = Convert.ToInt32(txtNivelDor.Text);
                voo.Id_VOO = Convert.ToInt32(txtID.Text);

                if (rbnCapturaNao.Checked)
                {
                    voo.Captura = "N";
                }
                else if (rbnCapturaSim.Checked)
                {
                    voo.Captura = "S";
                }

                Connection.Connection.UpdateDados(voo);                                                            

                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;

                LimpaCampos();
                ShowList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        // Método para limpar os campos do WindowsForm
        private void LimpaCampos()
        {
            mtxtData.Clear();
            txtCusto.Clear();
            txtDistancia.Clear();
            txtNivelDor.Clear();
            txtID.Clear();
            rbnCapturaSim.Checked = false;
            rbnCapturaNao.Checked = false;
            mtxtData.Focus();
        }       
    }
}

