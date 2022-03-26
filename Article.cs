//Описать структуру Article, содержащую следующие 
//поля: код товара; название товара; цену товара

namespace ConsoleMagazin;

public class Article
{
    private static Dictionary<int, string> articletypes = new Dictionary<int, string>();
    private static int id = 0;
    private int idProduct;
    private string nameProduct;
    private string typeProduct;
    private float priceProduct;

    public string getType()
    {
        return typeProduct;
    }

  public Article()
    {
        Console.WriteLine("Введите название, тип, стоимость товара ( через ' ')");
        string string_in;
        string[] strings_in;

        string new_name;
        string new_type;
        float new_price;

        string_in = Console.ReadLine();
        strings_in = string_in.Split();
        new_name = strings_in[0];
        new_type = strings_in[1];
        string_in = strings_in[2];

        while (!float.TryParse(string_in, out new_price))
        {
            Console.WriteLine("Повторите ввод стоимости товара ");
            string_in = Console.ReadLine();
        }

        if (!articletypes.ContainsValue(new_type))
        {
            articletypes.Add(articletypes.Count, new_type);
        }

        id++;
        this.idProduct = id;
        this.nameProduct = new_name;
        this.typeProduct = new_type;
        this.priceProduct = new_price;
    }

    public Article(string new_name)
    {
        Console.WriteLine("-------------------------------------");

        Console.WriteLine("Введите тип товара");
        string new_type = Console.ReadLine();
        Console.WriteLine("Введите стоимость товара ");
        string string_in = Console.ReadLine();
        float new_price;

        while (!float.TryParse(string_in, out new_price))
        {
            Console.WriteLine("Повторите ввод стоимости товара ");
            string_in = Console.ReadLine();
        }

        if (!articletypes.ContainsValue(new_type))
        {
            articletypes.Add(articletypes.Count, new_type);
        }

        id++;
        this.idProduct = id;
        this.nameProduct = new_name;
        this.typeProduct = new_type;
        this.priceProduct = new_price;
        Console.WriteLine("-------------------------------------");
    }

    public void print()
    {
        Console.WriteLine(this.idProduct + "\t" + this.nameProduct + "\t" + this.typeProduct + "\t" +
                          this.priceProduct + " руб.");
    }

    public float getPrice()
    {
        return priceProduct;
    }

    public string getName()
    {
        return nameProduct;
    }
}