namespace Projeto_Final_DW.Models
{
    public class Funcionarios
    {

        public Funcionarios()
        {
           
        }

        /// <summary>
        /// PK para a tabela dos Funcionarios
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nome do Funcionario
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Fotografia do Funcionario
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// NIF do Funcionario
        /// </summary>
        public string NIF { get; set; }
        
    }
}

