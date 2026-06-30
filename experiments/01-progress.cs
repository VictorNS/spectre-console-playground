#:package Spectre.Console@0.57.0

using Spectre.Console;

AnsiConsole.Write(new Text(" ⚠ Spinner ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();
AnsiConsole.WriteLine();

AnsiConsole.Status()
    .Start("Grinding in progress.", ctx =>
    {
        // Simulate grinding
        Thread.Sleep(3000);
    });

AnsiConsole.MarkupLine("[green]Grinding complete![/]");

AnsiConsole.WriteLine();
AnsiConsole.Write(new Text(" ⚠ Progress Bar ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();
AnsiConsole.WriteLine();

AnsiConsole.Progress()
    .Start(ctx =>
    {
        var task = ctx.AddTask("Grinding");
  
        while (!ctx.IsFinished)
        {
            task.Increment(1.5);
            Thread.Sleep(50);
        }
    });

AnsiConsole.MarkupLine("[green]Complete![/]");
