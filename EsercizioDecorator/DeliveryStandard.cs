using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDecorator
{
    
    internal class DeliveryStandard : DeliveryDecorator
    {
        public DeliveryStandard(Delivery delivery) : base(delivery)
        {
        }

        public override string Info() => $"Standard Delivery ";
        

        public override double Price() =>  base.Price() + 5.99D;
        
    }
}
