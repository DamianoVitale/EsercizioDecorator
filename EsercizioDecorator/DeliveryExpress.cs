using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDecorator
{
    internal class DeliveryExpress : DeliveryDecorator
    {
        public DeliveryExpress(Delivery delivery) : base(delivery)
        {
        }

        public override string Info() => "Express Delivery ";
        

        public override double Price() => base.Price() + 9.99D;



    }
}
