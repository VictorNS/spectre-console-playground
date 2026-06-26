#:package Spectre.Console@0.57.0

using Spectre.Console;

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

// Color.FromInt (uses the 256-color terminal palette index)
AnsiConsole.Write(new Text("Color from int (index 208)", new Style(foreground: Color.FromInt32(208))));
AnsiConsole.WriteLine();
