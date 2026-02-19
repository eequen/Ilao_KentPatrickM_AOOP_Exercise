using System;

Console.Write("Songs to add: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

Song[] playlist = new Song[n];


for (int i = 0; i < n; i++)
{
    Console.WriteLine("Song #{0}", i + 1);
    Console.Write("Title: ");
    string title = Console.ReadLine();
    Console.Write("Artist: ");
    string artist = Console.ReadLine();
    Console.Write("Duration (minutes): ");
    double duration = double.Parse(Console.ReadLine());

    playlist[i] = new Song(title, artist, duration);
    Console.WriteLine();
}

Console.WriteLine("=== || MY PLAYLIST || ===");
Console.WriteLine("{0,-20} {1,-20} {2,-10}", "Title", "Artist", "Time");
Console.WriteLine(new string('-', 50));

double totalDuration = 0;


foreach (Song s in playlist)
{
    s.DisplayTableRow();
    totalDuration += s.GetDuration();
}

double averageDuration = n > 0 ? totalDuration / n : 0;

Console.WriteLine();
Console.WriteLine("Total Duration: {0:F2} mins", totalDuration);
Console.WriteLine("Average Duration: {0:F2} mins", averageDuration);

class Song
{
    private string title;
    private string artist;
    private double duration;

    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    public double GetDuration() => duration;

    public void DisplayTableRow()
    {
        Console.WriteLine("{0,-20} {1,-20} {2,-10:F2}", title, artist, duration);
    }
}