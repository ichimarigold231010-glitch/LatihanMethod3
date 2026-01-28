int luaspersegi, luaspersegipanjang;
double luaslingkaran, luassegitiga;


double hitungluaslingkaran(double jari, double pi = 3.14)
{
    return pi * jari * jari;
}

int hitungluaspersegi(int sisi)
{
    return sisi * sisi;
}

int hitungluaspersegipanjang(int panjang, int lebar)
{
    return panjang * lebar;
}

double hitungluassegitiga(double alas, double tinggi)
{
    return 0.5 * alas * tinggi;
}

Console.WriteLine(hitungluaslingkaran(50));
Console.WriteLine(hitungluaspersegi(10));
Console.WriteLine(hitungluaspersegipanjang(20, 10));
Console.WriteLine(hitungluassegitiga(8, 3));