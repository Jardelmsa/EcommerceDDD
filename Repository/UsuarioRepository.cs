using Infra;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class UsuarioRepository:Conexao
    {
        public void AddUsuario( Usuarios usuarios)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO USUARIOS ( NOME, SENHA ) VALUES (@v1, @v2)", Con);
                Cmd.Parameters.AddWithValue("@v1", usuarios.Nome);
                Cmd.Parameters.AddWithValue("@v2", usuarios.Senha);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Usuarios> GetAllUsers()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("SELECT * FROM USUARIOS", Con);
                Dr = Cmd.ExecuteReader();

               
                List<Usuarios> lista = new List<Usuarios>();
                while (Dr.Read())
                {

                    Usuarios users = new Usuarios();
                    users.Id = Convert.ToInt32(Dr["ID"]);
                    users.Nome = Convert.ToString(Dr["NOME"]);
                    users.Senha = Convert.ToString(Dr["SENHA"]);
                    lista.Add(users);

                }
                
                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            finally
            {
                FecharConexao();
            }
        }
    }
}
