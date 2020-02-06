using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicada2Parcial1.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }

        [Required(ErrorMessage = "Es necesario fijar una fecha")]
        [Range(typeof(DateTime), minimum:"1/1/1980",maximum:"1/1/2025",ErrorMessage ="La fecha esta fuera de rango") ]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Es necesario una descripcion")]
        [StringLength(maximumLength:99, MinimumLength=2,ErrorMessage ="La cadena es muy contro o muy larga")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Es necesario un costo")]
        [Range(typeof(decimal),minimum:"0",maximum:"1000000" ,ErrorMessage ="El costo esta fuera de rango")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage ="En necesario establecer una ganancia")]
        [Range(typeof(decimal), minimum: "0", maximum: "1000000", ErrorMessage = "Las ganancias estan fuera de rango")]
        public decimal Ganancias { get; set; }

        [Required(ErrorMessage = "Es necesario fijar un precio")]
        public decimal Precio { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            //PctItbis = 0;
            //Itbis = 0;
            Ganancias = 0;
            Precio = 0;
        }
    }
}
