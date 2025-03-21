using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Entities
{
    public class producto
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string categoria { get; set; }

        public decimal precio { get; set; }

        public int cantidad_stock { get; set; }

        public DateTime fecha_registro { get; set; }

        /*
          id_producto INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT,
    categoria VARCHAR(50),
    precio DECIMAL(10, 2) NOT NULL,
    cantidad_stock INT NOT NULL,
    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP*/
    }
}
