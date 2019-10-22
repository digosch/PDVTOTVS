using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TPDV.Models
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ValorPagar { get; set; }
        [Required]
        public int ValorPago { get; set; }
       

      

        public int  calculatroco(int valorPagar, int valorPago)
        {
            ValorPagar = valorPagar;
            ValorPago = valorPago;

            int troco = valorPagar - valorPago;

            return troco;
        }
           

           
        
        
    }
}
