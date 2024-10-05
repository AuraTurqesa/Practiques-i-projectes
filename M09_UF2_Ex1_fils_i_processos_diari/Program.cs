using System.Diagnostics;

class ProvaFils
{
    static void Music()
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("#Música");
            Thread.Sleep(20);
        }
        Console.WriteLine("Canvi de so");
        
    }
    static void Despertarse()
    {
        Thread.Sleep(20);
        Console.WriteLine("Ja estic despert");
    }
    static void Dutxarse()
    {
        Thread.Sleep(40);
        Console.WriteLine("Entro a la dutxa");
        Thread.Sleep(30);
        Console.WriteLine("Surto de la dutxa");
    }

    //Podcast
    static void Podcast()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("#Podcast");
            Thread.Sleep(30);
        }
        Console.WriteLine("Fora so, es hora d'anar al cicle");

    }
    static void Esmorzar()
    {
        Thread.Sleep(20);
        Console.WriteLine("Començo a esmorzar");
        Thread.Sleep(20);
        Console.WriteLine("Acabo d'esmorzar");
    }
    static void Vestirse()
    {
        Thread.Sleep(40);
        Console.WriteLine("Començo a vestir-me");
        Thread.Sleep(10);
        Console.WriteLine("Acabo de vestir-me");
    }
    static void Main()
    {
        Thread T_music = new Thread(Music);
        Thread T_despertarse = new Thread(Despertarse);
        Thread T_dutxarse = new Thread(Dutxarse);
        Thread T_podcast = new Thread(Podcast);
        Thread T_esmorzar = new Thread(Esmorzar);
        Thread T_vestirse = new Thread(Vestirse);
        T_music.Start();
        T_despertarse.Start();
        T_dutxarse.Start();
        T_music.Join();
        T_dutxarse.Join();
        T_podcast.Start();
        T_esmorzar.Start();
        T_esmorzar.Join();
        T_vestirse.Start();
        T_podcast.Join();
        Console.ReadLine();
    }
}