// See https://aka.ms/new-console-template for more information

using EsercizioDecorator;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var pickInstore = new PickUpInStore();
var deliveryExpress = new DeliveryExpress(pickInstore);
var packaging = new DeliveryGiftPackaging(pickInstore);
var delivery = new DeliveryStandard(pickInstore);
var expressPackaging = new DeliveryExpress(packaging);
var pickUpGiftPackaging = new DeliveryGiftPackaging(pickInstore);

short s = 0;

do
{
   
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("Select type of delivery:");
    Console.WriteLine("1 Standard Delivery");
    Console.WriteLine("2 Express Delivery");
    Console.WriteLine("3 Delivery with gift packaging");
    Console.WriteLine("4 Pick up in store");
    Console.WriteLine("5 Express Delivery with gift packaging");
    Console.WriteLine("6 Pick up in store with gift packaging");

    Console.WriteLine("0 EXIT ");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
    Console.Write("Enter the delivery type: ");
    s = short.Parse(Console.ReadLine());




    switch (s)
    {
        case 1:
            Console.WriteLine(delivery.Info() + delivery.Price().ToString("C"));
            break;

        case 2:

            Console.WriteLine(deliveryExpress.Info() + deliveryExpress.Price().ToString("C"));
            break;

        case 3:
            Console.WriteLine(packaging.Info() + packaging.Price().ToString("C"));
            break;

        case 4:
            Console.WriteLine(pickInstore.Info() + pickInstore.Price().ToString("C"));
            break;
        case 5:
            Console.WriteLine(expressPackaging.Info() + packaging.Info() + expressPackaging.Price().ToString("C"));
            break;

        case 6:
            Console.WriteLine( pickInstore.Info() + "with gift packaging" + pickUpGiftPackaging.Price().ToString("C"));
            break;


        case 0:
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
} while (s != 0);



     