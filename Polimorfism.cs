using System;

class MusicalInstrument
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string HistoryText { get; set; }

    public MusicalInstrument(string name, string desc, string history)
    {
        Name = name;
        Description = desc;
        HistoryText = history;
    }

    public virtual void Sound()
    {
        Console.Beep(400, 500);
    }

    public virtual void Show()
    {
        Console.WriteLine("Інструмент: " + Name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Опис: " + Description);
    }

    public virtual void History()
    {
        Console.WriteLine("Історія: " + HistoryText);
    }
}

class Skripka : MusicalInstrument
{
    public Skripka()
        : base("Скрипка", "Струнний смичковий інструмент.", "Скрипка виникла у XVI столітті в Італії.") { }

    public override void Sound()
    {
        Console.Beep(800, 300);
    }
}

class Trombon : MusicalInstrument
{
    public Trombon()
        : base("Тромбон", "Мідний духовий інструмент.", "Тромбон відомий з XV століття.") { }

    public override void Sound()
    {
        Console.Beep(200, 300);
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele()
        : base("Укулеле", "Гавайський струнний щипковий інструмент.", "З'явився наприкінці XIX століття.") { }

    public override void Sound()
    {
        Console.Beep(600, 300);
    }
}

class Violonchel : MusicalInstrument
{
    public Violonchel()
        : base("Віолончель", "Струнний смичковий інструмент великого розміру.", "Створена в XVI столітті в Італії.") { }

    public override void Sound()
    {
        Console.Beep(300, 300);
    }
}

class Program
{
    static void Main()
    {
        MusicalInstrument[] arr =
        {
            new Skripka(),
            new Trombon(),
            new Ukulele(),
            new Violonchel()
        };

        foreach (var i in arr)
        {
            i.Show();
            i.Desc();
            i.History();
            i.Sound();
            Console.WriteLine();
        }
    }
}
