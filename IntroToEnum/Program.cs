using IntroToEnum.Entities;
using IntroToEnum.Entities.Enums;


namespace IntroToEnum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // testando Parse de tipos
            string txt = OrderStatus.PendingPayment.ToString(); // para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // ppara o tipo OrderStatus

            Console.WriteLine(txt);
            Console.WriteLine(os);


        }
    }
}