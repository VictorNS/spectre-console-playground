# Spectre.Console Playground — Learning Plan

Experiments with [Spectre.Console](https://spectreconsole.net) on .NET 10
using **file-based apps**: one file = one experiment.

Run:

```bash
dotnet run 09-table.cs
```

Header for every file:

```csharp
#:package Spectre.Console@0.57.0

using Spectre.Console;
```

---

## Progress

### Block 0. Output basics
- [ ] `00-hello.cs` — AnsiConsole.WriteLine, first run of a file-based app
- [ ] `01-markup.cs` — markup `[bold red]...[/]`, escaping `[[ ]]`
- [ ] `02-colors.cs` — named colors, hex, RGB, Color.FromInt
- [ ] `03-styles.cs` — bold/italic/underline/dim/blink, Decoration
- [ ] `04-emoji.cs` — `:rocket:`, Emoji.Known, Emoji.Replace

### Block 1. Text and headings
- [ ] `05-figlet.cs` — FigletText, fonts, color, alignment
- [ ] `06-text-wrapping.cs` — overflow, justify, text wrapping
- [ ] `07-rule.cs` — Rule, horizontal dividers with a title

### Block 2. Container widgets
- [ ] `08-panel.cs` — Panel: borders, title, padding, expand
- [ ] `09-table.cs` — Table: columns, alignment, border styles
- [ ] `10-table-advanced.cs` — nested widgets in cells, footer, caption
- [ ] `11-tree.cs` — Tree: nodes, nesting, guide lines
- [ ] `12-columns.cs` — Columns, arranging items across columns
- [ ] `13-grid.cs` — Grid, aligning "key: value" pairs
- [ ] `14-rows-padder-align.cs` — Rows, Padder, Align, layout composition
- [ ] `15-layout.cs` — Layout, splitting the screen into regions (splits)

### Block 3. Data and graphics
- [ ] `16-barchart.cs` — BarChart
- [ ] `17-breakdown-chart.cs` — BreakdownChart
- [ ] `18-calendar.cs` — Calendar
- [ ] `19-canvas.cs` — Canvas, pixel-by-pixel drawing

### Block 4. Dynamic output
- [ ] `20-status.cs` — AnsiConsole.Status(), spinner for the duration of an operation
- [ ] `21-progress.cs` — Progress, a single progress bar
- [ ] `22-progress-multi.cs` — multiple tasks, parallel tasks, async
- [ ] `23-live.cs` — Live, updating a widget in real time

### Block 5. Input and interaction
- [ ] `24-prompt-text.cs` — TextPrompt, validation, secrets (password)
- [ ] `25-prompt-confirm.cs` — ConfirmationPrompt (y/n)
- [ ] `26-prompt-selection.cs` — SelectionPrompt, picking one item from a list
- [ ] `27-prompt-multiselection.cs` — MultiSelectionPrompt, checkboxes, groups

### Block 6. Extras and "production"
- [ ] `28-exceptions.cs` — WriteException, pretty stack traces
- [ ] `29-profile-capabilities.cs` — AnsiConsole.Profile: color, width, Unicode/ANSI
- [ ] `30-cli-commandapp.cs` — Spectre.Console.Cli, a mini CLI with commands

---

## "Quick wow effect" route

After Block 0 you can jump straight to the flashiest parts:
`09-table.cs` → `21-progress.cs` → `26-prompt-selection.cs`,
and circle back to the rest later.

## Notes
- `30-cli-commandapp.cs` is the only item that's tightly bound to a single
  file; move it into a separate project if you'd like.
- Useful documentation sections: Markup, Widgets, Prompts, Live Display, Cli.
