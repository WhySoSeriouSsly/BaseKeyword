using System;

class Program
{
static void Main()
{
Ogrenci o = new Ogrenci("Öğrenci", "Emre", "Topçuoğlu");
//yukarıdaki metotlar constructor olduğundan instance
//tanımlar gibi değerleri bu şekilde veriliyor
Console.WriteLine();
Mudur m = new Mudur("Müdür", "Ali", "Yılmaz");
}

class Kisi
{
public Kisi(string ad, string soyad)
{
Console.WriteLine("Adınız : " + ad + "nSoyadınız : " + soyad);
}
}
class Ogrenci : Kisi
{
public Ogrenci(string departman, string ad, string soyad)
: base(ad, soyad)
{
Console.WriteLine("Departman : " + departman);
//Base class Kisi olduğundan ilk kişi çalışır ad soyad alır
//yazar sonra ogrenciden departmanı yazar
}
}
class Mudur : Kisi
{
public Mudur(string departman, string ad, string soyad)
: base(ad, soyad)
{
Console.WriteLine("Departman : " + departman);
//Base class Kisi olduğundan ilk kişi çalışır ad soyad alır
//yazar sonra mudurden departmanı yazar
}
}
}