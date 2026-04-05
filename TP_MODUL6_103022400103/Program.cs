using System;
using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Title tidak boleh kosong");

        if (title.Length > 100)
            throw new ArgumentException("Title maksimal 100 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count <= 0)
            throw new ArgumentException("Jumlah play harus > 0");

        if (count > 10000000)
            throw new ArgumentException("Maksimal input 10.000.000");

        try 
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow pada PlayCount!");
        }
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("\n===== TRACK DETAIL =====");
        Console.WriteLine("ID         : " + id);
        Console.WriteLine("Title      : " + title);
        Console.WriteLine("PlayCount  : " + playCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Rick Roll");

       for (int i = 0; i < 100; i++)
       {
           track.IncreasePlayCount(500);
       }
       track.PrintTrackDetails();

        for (int i = 0; i < 100; i++)
        {
            track.IncreasePlayCount(1000);
        }
        track.PrintTrackDetails();

        for (int i = 0; i < 215; i++)
        {
            track.IncreasePlayCount(10000000);
        }
        track.PrintTrackDetails();

    }
}