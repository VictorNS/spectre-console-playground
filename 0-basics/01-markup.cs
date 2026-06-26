#:package Spectre.Console@0.57.0

using Spectre.Console;

// Simple colored text
AnsiConsole.MarkupLine("[green]Done[/]");
AnsiConsole.MarkupLine("[red]Error occurred[/]");

// Multiple colors in one line
int processing = 3;
AnsiConsole.MarkupLine($"[blue]Info:[/] Processing [yellow]{processing}[/] items");
  
// Text decorations
AnsiConsole.MarkupLine("[bold]Bold text[/] [italic]Italic text[/] [underline]Underlined text[/]");
  
// Combined styles
AnsiConsole.MarkupLine("[bold red]Critical error[/]");
AnsiConsole.MarkupLine("[bold green on yellow]Highlighted success[/]");

// Markup with multi-line content
var multiLine = new Markup(
    "[yellow]Warning:[/] Multiple issues detected.\n" +
    "[dim]See log for details.[/]"
);
AnsiConsole.Write(multiLine);
AnsiConsole.WriteLine();

// Safe to use in markup string
var userInput = "Use [brackets] for arrays";
var escaped = Markup.Escape(userInput);
AnsiConsole.MarkupLine($"[blue]Escaped string:[/] {escaped}");
