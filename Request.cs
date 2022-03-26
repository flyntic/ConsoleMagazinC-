//Описать структуру Request содержащую поля: код заказа; клиент; дата заказа; перечень заказанных товаров; 
//сумма заказа (реализовать вычисляемым свойством).

namespace ConsoleMagazin;

public class Request
{
    private enum PayType
    {
        cash,
        creditcard
    }

    private static int id = 1;
    private static Dictionary<string, Article> articleProduct = new Dictionary<string, Article>();

    private int idOrder;
    private Client client;
    private DateTime dateOrder;
    private Dictionary<int, RequestItem> products;
    private PayType payType;
    private float summa;

    public Request()
    {
        this.idOrder = id++;
        this.client = new Client();
        this.dateOrder = DateTime.Now;
        Console.WriteLine("Добавить товары в заказ? ( Y/N ) ");
        string str_in = Console.ReadLine();
        this.products = new Dictionary<int, RequestItem>();

        while (str_in == "Y")
        {
            RequestItem r_temp = new RequestItem();
            this.products.Add(this.products.Count, r_temp);
            this.summa += r_temp.getSumma();
            Console.WriteLine("Добавить товары в заказ? ( Y/N ) ");
            str_in = Console.ReadLine();
        }

        Console.WriteLine("Оплата будет наличными? ( Y/N ) ");
        str_in = Console.ReadLine();
        this.payType = (str_in == "Y") ? PayType.cash : PayType.creditcard;
    }

    public void print()
    {   Console.WriteLine("-------------------------------------");
        Console.WriteLine("Заказ №");
        this.client.print();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Дата " + this.dateOrder.Date + " Время " + this.dateOrder.TimeOfDay);
        Console.WriteLine("-------------------------------------");

        foreach (var product in this.products)
        {
          product.Value.print();
        }

        Console.WriteLine("Общая сумма заказа " + this.summa + " рублей ");
        Console.WriteLine(this.payType == PayType.cash ? "Оплата наличными" : "Безналичная оплата");
    }
}