#:package Spectre.Console@0.57.0

using Spectre.Console;

var table = new Table()
    .RoundedBorder()
    .BorderColor(Color.Grey)
    .Title("[yellow bold]Top Languages[/]");

table.AddColumn("Name");
table.AddColumn("Language", col => col.Centered());
table.AddColumn("Commits", col => col.RightAligned());

table.AddRow("Alice", "C#", "1,042");
table.AddRow("Bob", "Rust", "873");
table.AddRow("Carol", "TypeScript", "1,521");

// Add footer with totals
table.Columns[0].Footer = new Text("Total", new Style(decoration: Decoration.Bold));
table.Columns[1].Footer = new Text("");
table.Columns[2].Footer = new Text("3,436", new Style(Color.Green, decoration: Decoration.Bold));

AnsiConsole.Write(table);
