using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Dizi tanımlama
        string []renkler = new string [5];

        string[]hayvanlar={"kedi","köpek","kuş","maymun"};
        int [] dizi;
        dizi = new int [5];

        //Dizilere deger atama
        renkler [0] = "mavi";
        dizi [3]=10;

        Console.WriteLine(hayvanlar [1]);
        Console.WriteLine(dizi [3]);
        Console.WriteLine( renkler [0]);

        //Döngülerler dizi kulanımk
        //Klavyeden girelen n tane sayının ortalamasını hesaplayan program
        Console.Write("lütfen dizinin eleman sayisini giriniz ");
        int diziuzunlugu = int.Parse(Console.ReadLine());   
        int[] sayiDizisi = new int [diziuzunlugu];

        for(int i = 0 ; i < diziuzunlugu;  i++) 
        {
            Console.Write("lütfen {0}. sayisi giriniz",i+1);
            sayiDizisi[i]= int.Parse(Console.ReadLine());
        }
        int toplam = 0;
        foreach ( var sayi in sayiDizisi)
        toplam += sayi ;
      Console.WriteLine("ortalama :"+ toplam/diziuzunlugu );
    }
}