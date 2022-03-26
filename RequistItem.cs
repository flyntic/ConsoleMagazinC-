//Описать структуру RequestItem содержащую поля: товар; количество единиц товара.
namespace ConsoleMagazin;

public class RequestItem
{
    private static Dictionary<string,Article> articleProduct=new Dictionary<string,Article>();

    private string Product;
    private int countProduct;
    private float summa=0;
    public RequestItem()
    {
        Console.WriteLine("Введите товар ");
        this.Product=Console.ReadLine();

        Console.WriteLine("Введите количество ");
        this.countProduct=Int32.Parse(Console.ReadLine());

        if (!articleProduct.ContainsKey(this.Product))
        {   Console.WriteLine("Необходимо заполнить информацию об артикле этого товара");
            articleProduct[this.Product] = new Article(this.Product);
        }

        summa += this.countProduct * articleProduct[this.Product].getPrice();
    }

    public float getSumma()
    {
        return summa;
    }

    public void print()
    {
        Console.WriteLine("Товар "+this.Product+" тип "+articleProduct[this.Product].getType()+
                          " количество "+this.countProduct);
    }

}