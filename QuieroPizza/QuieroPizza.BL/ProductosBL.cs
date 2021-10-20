using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {

        Contexto _contexto;
        public List<Producto> ListadeProdructos { get; set; }
        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProdructos = new List<Producto>();
        }
       public List<Producto> ObtenerProductos()
        {
            ListadeProdructos = _contexto.Productos.ToList();
            return _contexto.Productos.ToList(); 
        }
    }
}
