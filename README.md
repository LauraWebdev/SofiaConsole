# SofiaConsole
An easy to use in-game dev console for Godot 4 (C#)

![](/docs/screenshot.png)

## Getting Started
### How to install
- Copy the `addons/sofiaconsole` folder into your project
- Build your project
- Enable the plugin
- Make sure, that `res://addons/sofiaconsole/Console.tscn` is a global autoload with the name `Console`

### How to use
- Press `F3` in-game to open the console
  - You can create an input action named "toggle_console" to define a custom key/button

## Commands
### How to add commands
Simply add the `[ConsoleCommand]` attribute to a method to register it as a command. A command must always provide a command name to be executed. You can also optionally provide a `Description` and `Usage` string.

#### Examples
- `[ConsoleCommand("mycommand")]`
- `[ConsoleCommand("mycommand", Description = "This should describe my command")]`
- `[ConsoleCommand("move", Description = "Moves player", Usage = "move [x] [y] [z]")]`

#### Helpers
There are a few helper methods your command can call.
- `Console.Instance.ClearConsole();` - clears the console
- `Console.Instance.Space();` - adds a blank line
- `Console.Instance.Space(n);` - adds n blank lines
- `Console.Instance.Print("Hello World");` - adds a string as output (PrintType is Default)
  - `Console.Instance.Print("Hello World", Console.PrintType.Default);` - white
  - `Console.Instance.Print("Hello World", Console.PrintType.Hint);` - grey
  - `Console.Instance.Print("Hello World", Console.PrintType.Warning);` - orange
  - `Console.Instance.Print("Hello World", Console.PrintType.Error);` - red
  - `Console.Instance.Print("Hello World", Console.PrintType.Success);` - green

### Built in commands
We have created a few default commands that are always available.

- `clear`
  - Clears the console history
- `devcam`
  - Toggles between the current camera and a free-flying camera
- `fps / togglefps`
  - Toggles the FPS counter
- `maxfps [fps]`
  - Adds an fps limit, 0 (or no parameter value) disabled the limiter
- `helloworld`
  - Prints 'Hello World!' in the console
- `help [command?]`
  - Shows all registered commands. If command is specified, it will display the description and usage of a single command
- `info`
  - Prints general information about your game, engine and PC
- `reload`
  - Reloads the current scene
- `timescale`
  - Sets the timescale
- `toggleconsole`
  - Toggles the console

### Demo Project
This repository contains a demo project that implements a `noclip` console command to showcase the usage of this addon.