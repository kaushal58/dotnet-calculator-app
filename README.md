# Calculator App

A Windows Forms-based calculator application built with .NET 8.0.

## Project Overview

CalculatorApp is a feature-rich desktop calculator application designed for Windows platforms. It provides basic arithmetic operations with an intuitive graphical interface.

## Features

- **Basic Arithmetic Operations**: Addition, subtraction, multiplication, and division
- **Decimal Support**: Full support for decimal number calculations
- **Memory Functions**: Memory value storage for complex calculations
- **Dark Mode**: Toggle between light and dark themes
- **Keyboard Support**: Full keyboard input support for numbers and operations
- **Error Handling**: Graceful error handling and display
- **Scientific Notation**: Proper formatting of large and small numbers

## Project Structure

```
CalculatorApp/
├── Form1.cs                 # Main form UI logic and calculator operations
├── Form1.Designer.cs        # Auto-generated form designer component
├── Program.cs               # Application entry point
├── CalculatorApp.csproj     # Project configuration file
└── bin/                     # Compiled output
```

## System Requirements

- **Operating System**: Windows 7 or later
- **.NET Runtime**: .NET 8.0 or later
- **Framework**: Windows Forms (.NET Desktop Runtime)

## Dependencies

### Framework Dependencies

| Package | Version | Purpose |
|---------|---------|---------|
| .NET | 8.0 | Core runtime framework |
| Windows Forms | Built-in | UI framework for Windows desktop applications |
| System.Drawing | Built-in | Graphics and UI rendering |
| System.Globalization | Built-in | Culture-specific number formatting |

### Project Configuration

The project uses the following key properties defined in `CalculatorApp.csproj`:

- **OutputType**: `WinExe` - Produces a Windows executable
- **TargetFramework**: `net8.0-windows` - Targets .NET 8.0 for Windows
- **UseWindowsForms**: `true` - Enables Windows Forms support
- **Nullable**: `enable` - Strict null-checking enabled
- **ImplicitUsings**: `enable` - Implicit global using statements enabled

## Building the Project

### Prerequisites

Ensure you have .NET 8.0 SDK installed on your machine.

### Build Steps

1. Navigate to the project directory:
   ```bash
   cd "dotnet project for git"
   ```

2. Build the solution:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run --project CalculatorApp/CalculatorApp.csproj
   ```

## Usage

1. Launch the application
2. Enter numbers using the numeric keypad or your keyboard
3. Select an operation (+, -, *, /)
4. Enter the second number
5. Press = to see the result
6. Use memory buttons (M+, M-, MR, MC) for memory operations
7. Toggle dark mode using the theme button

## Development

### Architecture

- **Form1.cs**: Contains all calculator logic including:
  - Accumulator pattern for operation chaining
  - State management (current entry, pending operator, etc.)
  - Theme management (light/dark mode)
  - Error handling and display

### Data Structures

- `_accumulator`: Stores the first operand or intermediate result
- `_pendingOperator`: Stores the operation waiting to be executed
- `_isNewEntry`: Flag indicating when a new number entry is expected
- `_hasError`: Flag for error state
- `_memoryValue`: Storage for memory operations
- `_isDarkMode`: Current theme state

**Last Updated**: April 2026
