using System;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        int angka1 = 10;
        int angka2 = 30;
        int angka3 = 22;

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(angka1);
        db.AddNewData(angka2);
        db.AddNewData(angka3);

        Console.WriteLine("NIM : 103022330138");
        db.PrintAllData();
    }
}