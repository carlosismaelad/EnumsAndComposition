using System.Globalization;
using System.Text;
using FinalExerEnumsAndComposition.Entities.Enums;
namespace FinalExerEnumsAndComposition.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public Order()
    {
        
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }

    public double Total()
    {
        double sum = 0.0;
        foreach (OrderItem item in Items)
        {
            sum += item.SubTotal();
        }

        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine("Order Status: " + Status);
        sb.AppendLine("Client: " + Client);
        sb.AppendLine("Order Items:");
        foreach (OrderItem item in Items)
        {
            sb.AppendLine(item.ToString());
        }

        sb.AppendLine("Total Price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return sb.ToString();

    }
}