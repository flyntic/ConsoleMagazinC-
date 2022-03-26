//Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; количество заказов 
//осуществленных клиентом; общая сумма заказов клиента.

namespace ConsoleMagazin;

public class Client
{
    private static int id = 0;

    private static Dictionary<int, string> typeofclient = new Dictionary<int, string>()
    {
        {-1, "Заблокированный"}, {0, "Новый"}
    };

    private int idClient;
    private string name;
    private string middlename;
    private string surname;
    private string address;
    private string telephone;
    private int typeClient;
    private int numbersAllOrders;
    private float costAllOrders;

    public Client()
    {
        Console.WriteLine("Введите данные клиента: Имя Отчество Фамилия телефон адрес");

        string string_in;
        string[] strings_in;
        string_in = Console.ReadLine();
        strings_in = string_in.Split();

        string name = strings_in[0];
        string middlename = strings_in[1];
        string surname = strings_in[2];
        string telephone = strings_in[3];
        string address = strings_in[4];

        this.idClient = id++;
        this.name = name;
        this.middlename = middlename;
        this.surname = surname;
        this.address = address;
        this.telephone = telephone;
        this.typeClient = 0;
        this.numbersAllOrders = 0;
        this.costAllOrders = 0;
    }

    public bool addOrder()
    {
        Console.WriteLine("Введите стоимость заказа ");
        float costOrder = float.Parse(Console.ReadLine());
        if (costOrder < 0)
        {
            this.typeClient = -1;
            return true;
        }

        if (this.typeClient == -1) return false;

        this.numbersAllOrders++;
        this.costAllOrders += costOrder;
        return true;
    }

    public void print()
    {
        Console.WriteLine(this.idClient + "\t" + this.name + "\t" + this.middlename + "\t" + this.surname
                          + "\t" + typeofclient[(int) this.typeClient] );
    }
}