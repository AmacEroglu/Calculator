
public class Program
{

    public static void Main()
    {
        MenuGoster();
    }

    static void MenuGoster()
    {
        Console.Clear();
        Console.WriteLine("1. Topla\n2. Çıkar\n3. Çarp\n4. Böl");
        SecimYap();

    }

    static void SecimYap()
    {
        Console.Write("İşleminizi Seçin: ");
        string choose = Console.ReadLine();

        if (choose == "1")
            Topla();
        else if (choose == "2")
            Cikar();
        else if (choose == "3")
            Carp();
        else if (choose == "4")
            Bol();
        else if (choose == "5")
            Environment.Exit(0);
        YeniIslemIsterMısın();
    }
    //static double OperantAl()
    //  {
    //      Console.Write("Operant girin: ");
    //      double opr1 = Convert.ToDouble(Console.ReadLine());
    //      return opr1; 


    //  }
    //  static void Topla()
    //  {
    //      double  x = OperantAl();
    //      double y = OperantAl();
    //      double sonuc = x + y;
    //      Console.WriteLine("Toplam {0}", sonuc);
    //  }

    static (double Operant1, double Operant2) OperanlarıAl()
    {
        Console.Write("Operant 1 girin: ");
        double opr1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Operant 2 girin: ");
        double opr2 = Convert.ToDouble(Console.ReadLine());
        return (opr1, opr2);


    }
    static void Topla()
    {

        var oprs = OperanlarıAl();
        //Console.WriteLine("Toplam {0}", (oprs.Operant1 + oprs.Operant2));

        Console.WriteLine($"{oprs.Operant1} ve {oprs.Operant2} toplamı: {oprs.Operant1 + oprs.Operant2}");


    }
    static void Cikar()
    {
        var oprs = OperanlarıAl();
        Console.WriteLine($"{oprs.Operant1} ve {oprs.Operant2} kalan: {oprs.Operant1 - oprs.Operant2}");

    }

    static void Carp()
    {
        var oprs = OperanlarıAl();
        Console.WriteLine($"{oprs.Operant1} ve {oprs.Operant2} çarpımı: {oprs.Operant1 * oprs.Operant2}");
    }

    static void Bol()
    {
        var oprs = OperanlarıAl();
        Console.WriteLine($"{oprs.Operant1} ve {oprs.Operant2} kalan: {oprs.Operant1 / oprs.Operant2}");
    }

    static void YeniIslemIsterMısın()
    {
        Console.WriteLine("Başka bir işlem yapmak ister misiniz?(y/n)");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
            MenuGoster();
        else
            Environment.Exit(0);
    }


}