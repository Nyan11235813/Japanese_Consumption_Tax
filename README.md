# SimpleCalc2 - Simple Calculator Application

## Overview

SimpleCalc2 is a basic Windows Forms calculator application that performs arithmetic operations between two numbers. The current version supports addition, though the code structure suggests it was designed to handle multiple operations.

## Features

- Simple GUI with two input fields and a result display
- Basic input validation to ensure numeric values
- Addition operation (currently hardcoded as the only operation)
- Error handling for non-numeric inputs

## How to Use

1. Enter a number in the first input box (left side)
2. Enter a number in the second input box (right side)
3. Click the "計算する" (Calculate) button
4. View the result in the output box

## Technical Details

- Built with .NET 8.0
- Windows Forms application
- C# programming language
- Simple architecture with:
  - Input validation
  - Basic arithmetic operations
  - Error messaging

## Limitations

- Currently only performs addition (though code is structured for more operations)
- Uses long integers only
- Basic UI with minimal features

## Future Improvements

The code appears to be structured to support multiple operations (as seen in the `keisan` method's switch statement). Potential enhancements could include:

1. Adding a dropdown to select operation type (+, -, ×, ÷)
2. Implementing all basic arithmetic operations
3. Adding support for decimal numbers
4. Improving the UI layout
5. Adding calculation history

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- Visual Studio (recommended) or another C# IDE

### Running the Application

1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution
4. Run the application

Alternatively, from the command line:
```
dotnet run
```
