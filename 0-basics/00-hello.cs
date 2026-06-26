#:package Spectre.Console@0.57.0

using Spectre.Console;

// Hello
AnsiConsole.WriteLine("Hello, World!");

// Multiline
AnsiConsole.WriteLine("\nThis is\n a multiline\n message.");

// Formatted
AnsiConsole.WriteLine(System.Globalization.CultureInfo.InvariantCulture, 12345.6789m);
AnsiConsole.WriteLine(System.Globalization.CultureInfo.InvariantCulture, "The value is: {0}", 12345.6789m);
