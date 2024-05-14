using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDecorator
{
    public abstract class DeliveryDecorator : Delivery
    {
        private Delivery _delivery;

        protected DeliveryDecorator(Delivery delivery)
        {
           _delivery = delivery;
        }

        public override double Price() => _delivery.Price();
        
            
        
    }

}
