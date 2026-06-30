#:package Spectre.Console@0.57.0

using Spectre.Console;

AnsiConsole.Write(new Text(" ⚠ WriteException ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();
AnsiConsole.WriteLine();

try
{
	TestException1.Throw();
}
catch (Exception ex)
{
	AnsiConsole.WriteException(ex);
}

AnsiConsole.WriteLine();
AnsiConsole.Write(new Text(" ⚠ ShortenEverything ", new Style(foreground: Color.Black, background: Color.Yellow)));
AnsiConsole.WriteLine();
AnsiConsole.WriteLine();

try
{
	TestException1.Throw();
}
catch (Exception ex)
{
	AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
}

public static class TestException1
{
	public static void Throw()
	{
		try
		{
			TestException2.Throw();
		}
		catch (Exception ex)
		{
		throw new Exception("This is a test exception", ex);
		}
	}
}
public static class TestException2
{
	public static void Throw()
	{
		throw new Exception("This is a nested exception");
	}
}
