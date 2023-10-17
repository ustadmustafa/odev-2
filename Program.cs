using System.Collections;

namespace odev_2;

/*
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/
class Program
{
    static void Main(string[] args)
    {
        /*ArrayList arrayList = new ArrayList();
        int sayi;
        Console.WriteLine("20 adet sayı gir:(negatif ve numeric olmayan degerler olmasın)");
        for (int i = 0; i < 20; i++)
        {
            try
            {
                sayi = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("format hatasi baska sayi gir.");
                i--;
                continue;
                
            }
            
            if(sayi < 0){
                Console.WriteLine("negatif sayı girdin başka sayi gir");
                i--;
                continue;
            }

            arrayList.Add(sayi);
        }

        ArrayList asalArrayList = new ArrayList();
        ArrayList asalOlmayanArrayList = new ArrayList();

        int asalsum =0;
        int asalolmayansum=0;
        string s1;
        foreach (var item in arrayList)
        {
            s1 = item.ToString();
            if(SayiAsalMi(int.Parse(s1))){
                asalArrayList.Add(item);
                asalsum+= int.Parse(s1);
            }else{
                asalOlmayanArrayList.Add(item);
                asalolmayansum+=int.Parse(s1);
            }
        }

        asalArrayList.Sort();
        asalArrayList.Reverse();

        asalOlmayanArrayList.Sort();
        asalOlmayanArrayList.Reverse();

        

        Console.WriteLine("asal olan");
        foreach (var item in asalArrayList)
        {
            Console.WriteLine(item);
            
        }

        Console.WriteLine("****asal olmayan**");
        foreach (var item in asalOlmayanArrayList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Asal dizi eleman sayısı ve ortalaması: " + asalArrayList.Count + " ortalama: " + asalsum/asalArrayList.Count);
        Console.WriteLine("Asal olmayan dizi eleman sayısı ve ortalaması: " + asalOlmayanArrayList.Count + " ortalama: " + asalolmayansum/asalOlmayanArrayList.Count);*/

        
        //soru2

        //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki 
        //grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
        //console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

        /*Console.WriteLine("klavyeden 20 tane sayı gir ");
        ArrayList arrayList = new ArrayList();
        int sayi;
        for (int i = 0; i < 20; i++)
        {
            sayi = int.Parse(Console.ReadLine());
            arrayList.Add(sayi);
        }

        arrayList.Sort();
        int enBuyukUcToplam = 0;
        int enKucukUcToplam = 0;

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        enKucukUcToplam = (int) arrayList[0] + (int) arrayList[1] + (int) arrayList[2];
        enBuyukUcToplam = (int) arrayList[arrayList.Count-1] + (int) arrayList[arrayList.Count-2] + (int) arrayList[arrayList.Count - 3];

        int enBuyukOrt = enBuyukUcToplam / 3;
        int enKucukOrt = enKucukUcToplam / 3;

        Console.WriteLine("En buyuk 3 sayi ortalama: " + enBuyukOrt + " en kucuk 3 sayi ortalama : " + enKucukOrt + " ortalama toplamları: "  + (enBuyukOrt+enKucukOrt));*/

        //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan
        // ve dizinin elemanlarını sıralayan programı yazınız.
        
        string cumle;
        cumle = Console.ReadLine();
        int i = 0;
        foreach (var item in cumle)
        {
            i++;
        }
        char[] sesliharfdizisi = new char[i];
        i=0;
        foreach (var sesliharf in cumle)
        {   
            if(sesliharf == 'a' || sesliharf == 'A' || sesliharf == 'e' || sesliharf == 'E' || 
            sesliharf == 'ı' || sesliharf == 'I' || sesliharf == 'i' || sesliharf == 'İ' ||
            sesliharf == 'o' || sesliharf == 'O' || sesliharf == 'ö' || sesliharf == 'Ö' ||
            sesliharf == 'u' || sesliharf == 'U' || sesliharf == 'ü' || sesliharf == 'Ü'){
                sesliharfdizisi[i] = sesliharf;
                i++;
                
            }
        }
        
        foreach (var item in sesliharfdizisi)
        {
            Console.WriteLine(item);
        }

        
        
       

        

        



        
    }

    public static bool SayiAsalMi(int sayi){
        for(int i = 2;i<sayi;i++){
            if(sayi%i==0){
                return false;
                
            }
            
        }

        return true;
        
    }
}
