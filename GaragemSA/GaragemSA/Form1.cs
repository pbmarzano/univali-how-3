using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;



namespace GaragemSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dtdata.Value = dt;
            atualizarGrid();
            quantidadecarros();
        }
        private void checagem()
        {
           
        }

        private void atualizarGrid()
        {
            MySqlConnection realizaconexaoDB = new MySqlConnection("server=localhost;database=garagem;uid=root;pwd=1234");
            try
            {
                realizaconexaoDB.Open();
                MySqlCommand comandoMySql = realizaconexaoDB.CreateCommand();
                int pago = chbpagos.Checked == true ? 1 : 0;
                int excluido = chbexcluidos.Checked == true ? 1 : 0;
                comandoMySql.CommandText = "SELECT * from garagem WHERE pago = " + pago + " and excluido = " + excluido + " and Data = '" + dtdata.Value.ToString("yyyy-MM-dd") + "' ";
                MySqlDataReader reader = comandoMySql.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                    row.Cells[6].Value = reader.GetString(6);
                    row.Cells[7].Value = reader.GetString(7);
                    dataGridView1.Rows.Add(row);
                }
                realizaconexaoDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar lista de carros,verifique");
                Console.WriteLine(ex.Message);
            }

        }
        private void quantidadecarros()
        {
            MySqlConnection realizaconexaoDB = new MySqlConnection("server=localhost;database=garagem;uid=root;pwd=1234");
            try
            {
                realizaconexaoDB.Open();              
                    MySqlCommand comandoMySql = realizaconexaoDB.CreateCommand();
                    comandoMySql.CommandText = "SELECT COUNT(pago) AS CARRO from garagem WHERE pago = 0 and excluido = 0 and Data = '" + dtdata.Value.ToString("yyyy-MM-dd") + "' ";
                    MySqlDataReader reader = comandoMySql.ExecuteReader();
                    if (reader.Read())
                        lblcapacidade.Text = reader["CARRO"].ToString();
                    realizaconexaoDB.Close();                              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível somar os Valores, Verifique.");
                Console.WriteLine(ex.Message);
            }
        }
        private void limparCampos()
        {
            lbltotal.Text = "0";
            tbID.Clear();
            tbPlaca.Clear();
            tbProprietario.Clear();
            tbSituacao.Clear();
            tbHoraEntrada.Clear();
            tbHoraSaida.Clear();
            lbltotal.Text = "";
            lblacumulado.Text = "";
            atualizarGrid();
            quantidadecarros();
        }
       
       
        private void btndeletar_Click(object sender, EventArgs e)
        {
            MySqlConnection realizaconexaoDB = new MySqlConnection("server=localhost;database=garagem;uid=root;pwd=1234");
            
            try
            {
                realizaconexaoDB.Open();
                MySqlCommand comandoMySql = realizaconexaoDB.CreateCommand();
                comandoMySql.CommandText = "UPDATE garagem SET excluido = 1 WHERE id = "
                + tbID.Text + " ";
                comandoMySql.ExecuteNonQuery();
                realizaconexaoDB.Close();
                MessageBox.Show("Deletado com sucesso!");
                limparCampos();
                atualizarGrid();
                cbveiculo.Focus();
                quantidadecarros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("não foi possível deletar, Verifique se carro ja esta pago");
                Console.WriteLine(ex.Message);
                cbveiculo.Focus();
            }
        }
        
        private void btnnovo_Click(object sender, EventArgs e)
        {
         
            limparCampos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (tbPlaca.Text.ToString() == "")
            {
                MessageBox.Show("Placa em branco");
                tbPlaca.Focus();
                return;
            }
            if (tbHoraEntrada.Text.ToString() == "")
            {
                MessageBox.Show("Hora de Entrada em Branco");
                btnEntrada.Focus();
                return;
            }
           
            int capacidademaxima = 20;
            int capacidadeaviso = 16;
            var horamaxima = "22:00";
            DateTime horalimite = Convert.ToDateTime(horamaxima);
            DateTime dt = DateTime.Now;
            String strDate = "";
            strDate = dt.ToString("HH:mm");
            DateTime horaagora = Convert.ToDateTime(strDate);
            DateTime horamax = Convert.ToDateTime(horalimite);
           
            var chave = "NÃO";
            int quantidade = Convert.ToInt32(lblcapacidade.Text);
            if (quantidade >= capacidadeaviso && quantidade < capacidademaxima )
            {
                MessageBox.Show("Capacidade em 80% do seu total, cliente deve deixar a chave do carro");
                chave = "SIM";
            }
            if (quantidade == capacidademaxima)
            {
                MessageBox.Show("ATENÇÃO, Capacidade Maxima atingida!");
                MessageBox.Show("Não será permitido aceitar mais Veiculos!");
                limparCampos();
                return;
                
            }
            if (horaagora >= horamax)
            {
                MessageBox.Show("Proibido Aceitar carro devido ao Horário!!!");
                limparCampos();
                return;
                
            }

            MySqlConnection realizaconexaoDB = new MySqlConnection("server=localhost;database=garagem;uid=root;pwd=1234");

            try
            {
                realizaconexaoDB.Open();
                MySqlCommand comandoMySql = realizaconexaoDB.CreateCommand();
                comandoMySql.CommandText =
                    "INSERT INTO garagem (nome_veiculo, placa_veiculo, proprietario_veiculo, situacao_veiculo,chave, hora_entrada, Data) VALUES('"
                    + cbveiculo.Text.ToUpper().Trim()+"', '"
                    + tbPlaca.Text.ToUpper().Trim()+"', '"
                    + tbProprietario.Text.ToUpper()+"', '"
                    + tbSituacao.Text.ToUpper()+"', '"
                    + chave + "', '"
                    + tbHoraEntrada.Text.ToUpper()+"', '"
                    + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                comandoMySql.ExecuteNonQuery();
                realizaconexaoDB.Close();
                MessageBox.Show("Inserido com sucesso!Aguarde impressão do comprovante!");
                atualizarGrid();
                limparCampos();
                quantidadecarros();
                cbveiculo.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível Salvar novo carro, Verifique.");
                Console.WriteLine(ex.Message);
                cbveiculo.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            limparCampos();



            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            
            {
                dataGridView1.CurrentRow.Selected = true;
                tbID.Text = dataGridView1.Rows[e.RowIndex].Cells["columnID"].FormattedValue.ToString();
                cbveiculo.Text = dataGridView1.Rows[e.RowIndex].Cells["columnVeiculo"].FormattedValue.ToString();
                tbPlaca.Text = dataGridView1.Rows[e.RowIndex].Cells["columnPlaca"].FormattedValue.ToString();
                tbProprietario.Text = dataGridView1.Rows[e.RowIndex].Cells["columnProprietario"].FormattedValue.ToString();
                tbSituacao.Text = dataGridView1.Rows[e.RowIndex].Cells["columnSituacao"].FormattedValue.ToString();
                tbHoraEntrada.Text = dataGridView1.Rows[e.RowIndex].Cells["columnEntrada"].FormattedValue.ToString();
                tbHoraSaida.Text = dataGridView1.Rows[e.RowIndex].Cells["columnSaida"].FormattedValue.ToString();
                tbHoraSaida.Text = dataGridView1.Rows[e.RowIndex].Cells["columnSaida"].FormattedValue.ToString();
            }
        }
                         
        private void btnatualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection realizaconexaoDB = new MySqlConnection("server=localhost;database=garagem;uid=root;pwd=1234");
            try
            {
                realizaconexaoDB.Open();
                MySqlCommand comandoMySql = realizaconexaoDB.CreateCommand();
                comandoMySql.CommandText = "UPDATE garagem SET nome_veiculo = '" + cbveiculo.Text
                + "', " + "placa_veiculo = '" + tbPlaca.Text.ToUpper()
                + "', " + "proprietario_veiculo = '" + tbProprietario.Text.ToUpper()
                + "', " + "situacao_veiculo = '" + tbSituacao.Text.ToUpper()
                + "', " + "hora_entrada = '" + tbHoraEntrada.Text.ToUpper()
                + "', " + "hora_saida = '" + tbHoraSaida.Text.ToUpper()
                + "' WHERE id = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();
                realizaconexaoDB.Close();
                MessageBox.Show("Atualizado com sucesso!");
                atualizarGrid();
                limparCampos();
                quantidadecarros();
                cbveiculo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("não foi possível atualizar");
                Console.WriteLine(ex.Message);
                cbveiculo.Focus();
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;
            String strDate = "";
            strDate = dt.ToString("HH:mm");
            tbHoraEntrada.Text = strDate;
            
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;
            String strDate = "";
            strDate = dt.ToString("HH:mm");
            tbHoraSaida.Text = strDate;
            DateTime entrada = Convert.ToDateTime(tbHoraEntrada.Text);
            DateTime saida = Convert.ToDateTime(tbHoraSaida.Text);
            int valor = 0;
                if (cbveiculo.Text.ToString().Trim() == "CARRO")
                {
                 valor = 5;
                }
                else
                 valor = 4;
            
            var difere = (saida - entrada);

            if (difere.TotalHours <= 0.083334)
            {
                valor = 0;
            }
            double preco = Convert.ToDouble(difere.TotalHours);
            if(preco <= 1)
            {
              var valorFinal = valor * 1;
              lbltotal.Text = valorFinal.ToString("F");
            }
            if (preco > 1 && preco <= 2)
            {
                var valorFinal = valor * 2;
                lbltotal.Text = valorFinal.ToString("F");
            }
            if (preco > 2 && preco <= 3)
            {
                var valorFinal = valor * 3;
                lbltotal.Text = valorFinal.ToString("F");
            }
            if (preco > 3 && preco <= 4)
            {
                var valorFinal = valor * 4;
                lbltotal.Text = valorFinal.ToString("F");
            }
            if (preco > 4 && preco <= 5)
            {
                var valorFinal = valor * 5;
                lbltotal.Text = valorFinal.ToString("F");
            }
            if (preco > 5 && preco <= 6)
            {
                var valorFinal = valor * 6;
                lbltotal.Text = valorFinal.ToString("F");
            }
            if (preco > 6 && preco <= 7)
            {
                var valorFinal = valor * 7;
                lbltotal.Text = valorFinal.ToString("F");
            }
            if (preco > 7)
            {
                var valorFinal = 8 * valor;
                lbltotal.Text = valorFinal.ToString("F");
            }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            
            if (tbHoraSaida.Text.ToString() == "")
            {
                MessageBox.Show("Sem Horario de saída, Verifique");
                btnSaida.Focus();
                return;
            }
            double valorpag = Convert.ToDouble(lbltotal.Text);

            MySqlConnection realizaconexaoDB = new MySqlConnection("server=localhost;database=garagem;uid=root;pwd=1234");

            try
            {
                realizaconexaoDB.Open();
                MySqlCommand comandoMySql = realizaconexaoDB.CreateCommand();
                comandoMySql.CommandText = "UPDATE garagem SET Pago = 1 , " + "hora_saida = '"
                    + tbHoraSaida.Text +"', " +
                    "Valor = '" + valorpag + "' WHERE id = "
                + tbID.Text + "" ;
                comandoMySql.ExecuteNonQuery();

                realizaconexaoDB.Close();
                MessageBox.Show("Pagamento Efetuado, Aguarde Comprovante!");
                atualizarGrid();
                limparCampos();
                cbveiculo.Focus();
                quantidadecarros();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi Efetuar Pagamento");
                Console.WriteLine(ex.Message);
                cbveiculo.Focus();
            }

        }
           
     
               
        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            limparCampos();
            DateTime dt = DateTime.Now;

            if (dtdata.Value.Date == dt.Date)
            {
                btnPagar.Enabled = true;
                atualizarGrid();
            }
            else
                btnPagar.Enabled = false;
                atualizarGrid();
            
        }

        private void chbacumulado_CheckedChanged(object sender, EventArgs e)
        {
            
            MySqlConnection realizaconexaoDB = new MySqlConnection("server=localhost;database=garagem;uid=root;pwd=1234");


            try
            {
                realizaconexaoDB.Open();
                if (chbacumulado.Checked == true)
                {
                    MySqlCommand comandoMySql = realizaconexaoDB.CreateCommand();
                    comandoMySql.CommandText = "SELECT SUM(Valor) AS TOTAL from garagem WHERE pago = 1 and Data = '" + dtdata.Value.ToString("yyyy-MM-dd") + "' ";
                    MySqlDataReader reader = comandoMySql.ExecuteReader();
                    if (reader.Read())
                        lblacumulado.Text = reader["TOTAL"].ToString();
                    realizaconexaoDB.Close();
                }
                else
                    lblacumulado.Text = "";

            }
             catch(Exception ex)
            {
                MessageBox.Show("Não foi possível Somar os Valores, Verifique.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
