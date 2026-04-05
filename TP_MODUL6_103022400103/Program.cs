using System;
using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private int playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
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

        for (int i = 0; i < 100; i++)
        {
            track.IncreasePlayCount(10000005);
        }
        track.PrintTrackDetails();

    }
}