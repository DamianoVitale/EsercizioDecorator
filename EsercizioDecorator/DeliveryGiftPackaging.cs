using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioDecorator
{
    internal class DeliveryGiftPackaging : DeliveryDecorator
    {
        public DeliveryGiftPackaging(Delivery delivery) : base(delivery)
        {
        }
        public override string Info() => "Delivery with gift packaging ";
        public override double Price() => base.Price() + 3.99D;
    }
}
