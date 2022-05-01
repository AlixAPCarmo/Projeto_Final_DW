using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Final_DW.Models
{
    public class CentrosDeDia
    {

        /// <summary>
        /// PK da tabela CentrosDeDia, id do centro de dia
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nome do centro de dia
        /// </summary>
        public string Nome { get; set; }    

        /// <summary>
        /// fotografia do centro de dia
        /// </summary>
        public string Fotografia { get; set; }  

        /// <summary>
        /// FK "funcioanrios"
        /// </summary>
        [ForeignKey(nameof(Funcionarios))]
        public int FuncionariosFK { get; set; }  
        public Funcionarios Funcionarios { get; set; }

        /// <summary>
        /// foreign key "Administradores"
        /// </summary>
        [ForeignKey(nameof(Administradores))]
        public int AdministradoresFK { get; set; }
        public Administradores Administradores { get; set; }

        /// <summary>
        /// foreign key "Utentes"
        /// </summary>
        [ForeignKey(nameof(Utentes))]
        public int UtentesFK { get; set; }
        public Utentes Utentes { get; set; }


    }

   

}
