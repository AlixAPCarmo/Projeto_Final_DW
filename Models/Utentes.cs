namespace Projeto_Final_DW.Models
{
    public class Utentes
    {
        public Utentes()
        {  
        }
        /// <summary>
        /// PK da tabela Utentes, íd do utente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nome do utente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fotografia do utente
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// nº de telefone do utente
        /// </summary>
        public string NumTelefone { get; set; }

        /// <summary>
        /// Idade do utente
        /// </summary>
        public int Idade { get; set; }

        /// <summary>
        /// Local de nascimento do utente
        /// </summary>
        public string LocalNascimento { get; set; }

        /// <summary>
        /// Sexo do utente
        /// </summary>
        public string Sexo { get; set; }

    }

}