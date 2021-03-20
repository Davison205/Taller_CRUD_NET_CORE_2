using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_CRUD_NET_CORE_2.git.Models.Entities
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
        public String Nombre { get; set; }
        public String PersonaContacto { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }



    }
}
