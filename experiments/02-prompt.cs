#:package Spectre.Console@0.57.0

using Spectre.Console;

AnsiConsole.Write(new Text(" ⚠ Ask ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();
AnsiConsole.WriteLine();

var name = AnsiConsole.Ask<string>("What's your name?");
AnsiConsole.MarkupLine($"Hello, [blue]{name}[/]!");

AnsiConsole.WriteLine();
AnsiConsole.Write(new Text(" ⚠ Choice ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();
AnsiConsole.WriteLine();

var choice = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Select a fruit:")
        .AddChoices("Apple", "Banana", "Orange", "Grape"));
AnsiConsole.MarkupLine($"Good for you [blue]{choice}[/]");
