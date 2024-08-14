
//10 adet tam sayı değeri olan bir dizi tanımlandı
int[] numberList = new int[10];

//For dögüsü ile kullanıcıdan dizinin doldurulması istendi
for (int i = 0; i < numberList.Length; i++)
{
    Console.WriteLine($"Lütfen {i + 1}.sayıyı giriniz ");
    numberList[i] = Convert.ToInt32(Console.ReadLine());
}

//Foreach döngüsü ile giriş yapılan dizi ekrana yazdırıldı
    Console.WriteLine("Dizi elemanları:");
    foreach (int number in numberList)
    {
        Console.WriteLine(number);
 }

//Kullanıcıdan 11. sayı olarak bir sayı istendi
Console.Write("Lütfen diziye eklemek için bir sayı giriniz: ");
int newNumber = Convert.ToInt32(Console.ReadLine());

//10 adet elemanı olan dizimiz Resize komutu ile tekrar boyutlanıdırılıp 11 eleman olarak güncellendi, ve kullanıcıdan alınan değer 11.eleman olarak diziye işlendi
Array.Resize(ref numberList, 11);
numberList[10] = newNumber;

//Sort komutu ile dizi küçükten büyüğe sıralandı ve Reverse komutu ile büyükten küçüğe olarak güncellendi.
Array.Sort(numberList);
Array.Reverse(numberList);

//Foreach döngüsü ile büyükten küçüğe sıralanmış elemanlar ekranda gösterildi
Console.WriteLine("Büyükten küçüğe sıralanmış dizi:");
foreach (int number in numberList)
{
    Console.WriteLine(number);
}
