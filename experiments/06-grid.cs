#:package Spectre.Console@0.57.0

using Spectre.Console;

var grid = new Grid();

// Configure columns
grid.AddColumn(new GridColumn { Width = 20, Alignment = Justify.Right });
grid.AddColumn(new GridColumn());

// Add header
grid.AddRow(
	new Text("System Information", new Style(Color.Yellow, decoration: Decoration.Bold)),
	new Text(""));

grid.AddEmptyRow();

// Add data rows
grid.AddRow(new Markup("OS:"), new Markup("[blue]Linux[/]"));
grid.AddRow(new Markup("CPU:"), new Markup("[green]8 cores @ 3.2GHz[/]"));
grid.AddRow(
	new Markup("Memory:"),
	new BreakdownChart()
		.Width(40)
		.AddItem("Used", 12, Color.Red)
		.AddItem("Available", 4, Color.Green));
grid.AddRow(
	new Markup("Disk:"),
	new Panel("[yellow]65% used[/]")
		.BorderColor(Color.Yellow));
grid.AddRow(
	new Markup("Remote:"),
	new Panel(
		new Table()
			.AddColumn("Name")
			.AddColumn("Status")
			.AddRow("Server 1", "[green]Online[/]")
			.AddRow("Server 2", "[red]Offline[/]"))
		.Header("AWS")
		.RoundedBorder());

AnsiConsole.Write(grid);
