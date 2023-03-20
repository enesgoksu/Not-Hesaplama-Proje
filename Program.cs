class Program
{
    private static void Main(string[] args)
    {
        int vize,final;
        float ort;
        Console.Write("Vize Notu: ");
        vize = Convert.ToInt32(Console.ReadLine());
        Console.Write("Final Notu: ");
        final = Convert.ToInt32(Console.ReadLine());
        ort = (vize * 3 / 10) + (final * 7 / 10);    // vize * 0.3 + final * 0.7 olarak da yazılabilir.

        if(ort < 50)
            Console.WriteLine("Ortalamanız: "+ ort +" "+ "ve Dersten kaldınız.");
        else
            Console.WriteLine("Ortalamanız: "+ ort +" "+ "ve Dersten Geçtiniz");
    }
}