using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Wesley.Connection
{
    class Connection
    {

        private static SQLiteConnection sqlliteConnection;

        public Connection() { }

        // Estabelece Conexão com a base dados
        public static SQLiteConnection ConnectionDB()
        {

            SQLiteConnection SQLiteConnection = new SQLiteConnection("Data Source=C:\\Users\\wesle\\source\\repos\\Wesley\\BD\\acme.sqlite; Version=3;");
            sqlliteConnection = SQLiteConnection;
            sqlliteConnection.Open();
            return sqlliteConnection;

        }

        // Criar a base dados caso não exista
        public static void CriarBancoSQLite()
        {
            if (!File.Exists("C:\\Users\\wesle\\source\\repos\\Wesley\\BD\\acme.sqlite")) { 
           
                try
                {
                    SQLiteConnection.CreateFile(@"C:\Users\wesle\source\repos\Wesley\acme.sqlite");

                    using (var cmd = ConnectionDB().CreateCommand())
                    {
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(ID_VOO integer PRIMARY KEY AUTOINCREMENT, DATA_VOO varchar(50) not null, CUSTO numeric (10,2) not null, DISTANCIA int not null, CAPTURA char (2) not null, NIVEL_DOR int not null)";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        // Realiza um select na base de dados e exibe todos os campos
        public static DataTable ExibirTudo()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionDB().CreateCommand())
                {
                    cmd.CommandText = "Select * from TB_VOO";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionDB());
                    da.Fill(dt);
                    return dt;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Salvar dados na tabela TB_VOO
        public static void InsereDados(VOO voo)
        {     
            try
            {
                using (var cmd = ConnectionDB().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TB_VOO(DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR)" +
                        "values (@data_voo, @custo, @distancia, @captura, @nivel_dor)";
                    cmd.Parameters.AddWithValue("@data_voo", voo.Data_VOO);
                    cmd.Parameters.AddWithValue("@custo", voo.Custo);
                    cmd.Parameters.AddWithValue("@distancia", voo.Distancia);
                    cmd.Parameters.AddWithValue("@captura", voo.Captura);
                    cmd.Parameters.AddWithValue("@nivel_dor", voo.Nivel_Dor);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Remover dados da tabela usando a chave primária ID_VOO
        public static int RemoveDados(int id)
        {
            int res = 1;
            try
            {
                using (var cmd = ConnectionDB().CreateCommand())
                {
                    cmd.CommandText = "Delete from TB_VOO where ID_VOO = @id_voo";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id_voo", id);
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }

            return res;
        }

        // Realiza a busca na tabela usando a chave primária ID_VOO
        public static SQLiteDataReader ProcurarDados(int id)
        {
            try
            {
                using (var cmd = ConnectionDB().CreateCommand())
                {
                    cmd.CommandText = "Select * from TB_VOO where ID_VOO = @id_voo";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id_voo", id);
                    return cmd.ExecuteReader();
                }
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        // Realiza a alteração dos dados usando a chave primária ID_VOO
        public static void UpdateDados(VOO voo)
        {
            try
            {
                using (var cmd = ConnectionDB().CreateCommand())
                {
                    cmd.CommandText = "UPDATE TB_VOO set DATA_VOO=@data_voo, CUSTO=@custo, DISTANCIA=@distancia," +
                        "CAPTURA=@captura, NIVEL_DOR=@nivel_dor where ID_VOO=@id_voo";                    
                    cmd.Parameters.AddWithValue("@data_voo", voo.Data_VOO);
                    cmd.Parameters.AddWithValue("@custo", voo.Custo);
                    cmd.Parameters.AddWithValue("@distancia", voo.Distancia);
                    cmd.Parameters.AddWithValue("@captura", voo.Captura);
                    cmd.Parameters.AddWithValue("@nivel_dor", voo.Nivel_Dor);
                    cmd.Parameters.AddWithValue("@id_voo", voo.Id_VOO);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
  
 

