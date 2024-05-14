using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDecorator
{
    internal class PickUpInStore : Delivery
    {
      
        public override string Info() => "Pick up in store ";
        public override double Price() => 0.00;
    }
}
