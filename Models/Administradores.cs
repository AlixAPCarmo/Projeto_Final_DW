namespace Projeto_Final_DW.Models
{
    public class Administradores
    {

        /// <summary>
        /// PK da tabela administradores, íd do funcionario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nome do funcionario
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Fotografia do funcionario
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// nº de telefone do funcionario
        /// </summary>
        public string NumTelefone { get; set; }

        /// <summary>
        /// Idade do funcionario
        /// </summary>
        public int Idade { get; set; }

        /// <summary>
        /// Sexo do funcionario
        /// </summary>
        public string Sexo { get; set; }
        
        /// <summary>
        /// centros de dia, identificados pelo ID, pelo qual o administrador é responsavel
        /// </summary>
        public string CentrosdeDia { get; set; } //string ou outro tipo de var?


        ///tabela dos centros de dia que os administradores têm acesso
    }


}
