using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
 
    public class Department
    {
        public Department()
        {
            // Inicialize a propriedade Name aqui
            Name = ""; // Ou qualquer outro valor padrão que você preferir
        }
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
