using System;

class PemrosesData
{
    public int DapatkanNilaiTerbesar<T>(T angka1, T angka2, T angka3)
    {
        dynamic ang1 = 0;
        dynamic ang2 = 0;
        dynamic ang3 = 0;
        dynamic temp = 0;

        ang1 = angka1;
        ang2 = angka2;
        ang3 = angka3;

        if (ang1 > ang2 && ang1 > ang3)
        {
            temp = ang1;
        }

        if (ang2 > ang1 && ang2 > ang3)
        {
            temp = ang2;
        }

        if (ang3 > ang1 && ang3 > ang2)
        {
            temp = ang3;
        }

        return temp;
    }
}

class Program
{
    static void Main()
    {
        int angka1 = 10;
        int angka2 = 30;
        int angka3 = 22;

        PemrosesData data = new PemrosesData();
        Console.WriteLine("NIM = 103022330138");
        Console.WriteLine("Angka 1 = " + angka1);
        Console.WriteLine("Angka 2 = " + angka2);
        Console.WriteLine("Angka 3 = " + angka3);
        Console.WriteLine("Nilai terbesar adalah " + data.DapatkanNilaiTerbesar(angka1, angka2, angka3));
    }
}