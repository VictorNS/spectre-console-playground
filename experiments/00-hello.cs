#:package Spectre.Console@0.57.0

using Spectre.Console;

AnsiConsole.Write(new Text(" ⚠ Basics ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();

// Hello
AnsiConsole.WriteLine("Hello, World!");

// Multiline
AnsiConsole.WriteLine("\nThis is\n a multiline\n message.");

// Formatted
AnsiConsole.WriteLine(System.Globalization.CultureInfo.InvariantCulture, 12345.6789m);
AnsiConsole.WriteLine(System.Globalization.CultureInfo.InvariantCulture, "The value is: {0}", 12345.6789m);

AnsiConsole.WriteLine();
AnsiConsole.Write(new Text(" ⚠ Markup ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();

// Colored text
AnsiConsole.MarkupLine("[green]Done[/]");
AnsiConsole.MarkupLine("[red]Error occurred[/]");

int processing = 3;
AnsiConsole.MarkupLine($"[blue]Info:[/] Processing [yellow]{processing}[/] items");
  
// Text decorations
AnsiConsole.MarkupLine("[bold]Bold text[/] [italic]Italic text[/] [underline]Underlined text[/]");
AnsiConsole.MarkupLine("[bold red]Critical error[/]");
AnsiConsole.MarkupLine("[bold green on yellow]Highlighted success[/]");

// Markup with multi-line content
var multiLine = new Markup(
    "[yellow]Warning:[/] Multiple issues detected.\n" +
    "[dim]See log for details.[/]"
);
AnsiConsole.Write(multiLine);
AnsiConsole.WriteLine();

AnsiConsole.WriteLine();
AnsiConsole.Write(new Text(" ⚠ Colors ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();

// Named colors
AnsiConsole.Write(new Text("White", new Style(foreground: Color.White)));
AnsiConsole.Write(new Text("White on Red", new Style(foreground: Color.White, background: Color.Red)));
AnsiConsole.Write(new Text("Blue on Yellow", new Style(foreground: Color.Blue, background: Color.Yellow)));
AnsiConsole.WriteLine();

// Hex color
AnsiConsole.Write(new Text("Hex color", new Style(foreground: Color.FromHex("FF6347"))));
AnsiConsole.WriteLine();

// RGB color
AnsiConsole.Write(new Text("RGB color", new Style(foreground: new Color(30, 144, 255))));
AnsiConsole.WriteLine();
