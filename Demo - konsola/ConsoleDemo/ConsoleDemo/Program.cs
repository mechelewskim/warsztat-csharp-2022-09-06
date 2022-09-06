using Spectre.Console;

Console.WriteLine("Hello, World!");

var age = AnsiConsole.Ask<int>("Ile masz [green]lat[/]?");
Console.WriteLine($"Masz {age} lat");

Console.ReadLine();
Console.Clear();

var calendar = new Calendar(2022, 09);
calendar.Culture("pl-PL");
calendar.AddCalendarEvent(2022, 09, 06);
calendar.HighlightStyle(Style.Parse("yellow bold"));
AnsiConsole.Write(calendar);

Console.ReadLine();
Console.Clear();

var asciiArt = new FigletText("Wprowadzenie do C#")
        .LeftAligned()
        .Color(Color.Red);
AnsiConsole.Write(asciiArt);

Console.ReadLine();
Console.Clear();

AnsiConsole.Write(new BarChart()
    .Width(60)
    .Label("[yellow bold]Jaki język programowania lubisz najbardziej?[/]")
    .CenterLabel()
    .AddItem("C#", 54, Color.Purple)
    .AddItem("python", 12, Color.Green)
    .AddItem("javascript", 33, Color.Red));

Console.ReadLine();
Console.Clear();

var table = new Table();

table.AddColumn("Nagłówek 1");
table.AddColumn(new TableColumn("Nagłówek wyśrodkowany").Centered());

table.AddRow("Odpowiedź 1", "[green]Odpowiedź 2[/]");
table.AddRow("[blue]Odpowiedź 3[/]", "Odpowiedź 4");

AnsiConsole.Write(table);

Console.ReadLine();
Console.Clear();

AnsiConsole.Progress()
    .Start(ctx =>
    {
        // Define tasks
        var task1 = ctx.AddTask("[green]ładowanie bardzo ważnego pliku[/]");
        var task2 = ctx.AddTask("[red]przetwarzanie informacji z pliku[/]");
        var task3 = ctx.AddTask("[yellow]zapisywanie informacji do pliku[/]");

        while (!ctx.IsFinished)
        {
            task1.Increment(1.5);
            task2.Increment(1.0);
            task3.Increment(0.8);
            Thread.Sleep(80);
        }
    });

Console.ReadLine();
Console.Clear();