//1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
int[] sayılar = new int[10];

//2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
for (int i = 0; i < sayılar.Length; i++)
{
    sayılar[i] = i + 1;
}

foreach (int sayı in sayılar)
{
    Console.WriteLine(sayı);
}

//3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
    
Console.Write("Lütfen diziye eklemek için bir sayı girin: ");
int yeniSayı = Convert.ToInt32(Console.ReadLine());

    // Mevcut diziyi genişletmek için yeni bir dizi oluşturuyoruz
int[] yeniDizi = new int[sayılar.Length + 1];

    // Mevcut dizinin elemanlarını yeni diziye kopyalıyoruz
for (int i = 0; i < sayılar.Length; i++)
{
    yeniDizi[i] = sayılar[i];
}

    // Kullanıcının girdiği sayıyı yeni dizinin son elemanı olarak ekliyoruz
yeniDizi[yeniDizi.Length - 1] = yeniSayı;

    // Genişletilmiş diziyi ekrana yazdırıyoruz
Console.WriteLine("Güncellenmiş dizi elemanları:");
foreach (int sayı in yeniDizi)
{
    Console.WriteLine(sayı);
}


//4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.

    // Diziyi büyükten küçüğe sıralıyoruz
Array.Sort(yeniDizi);
Array.Reverse(yeniDizi);

foreach (int sayı in yeniDizi)
{
    Console.WriteLine(sayı);
}
