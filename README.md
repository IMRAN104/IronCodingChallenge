# OldPhoneKeyPadConverter

## Overview
The IronCodingChallenge is a C# Console Application that simulates the behavior of old mobile phone keypads. It converts sequences of key presses into corresponding text, similar to how texting was done on early mobile phones.

## Features
- Converts sequences of numeric key presses into text.
- Supports multi-tap input method.
- Handles repeated key presses to cycle through letters.
- Validates input sequence for inavlid characters

## Getting Started

### Prerequisites
- .NET 8 Runtime or SDK

### Installation
1. Clone the repository:
    ```sh
    git clone https://github.com/IMRAN104/IronCodingChallenge.git
    ```
2. Navigate to the project directory:
    ```sh
    cd IronCodingChallenge
    cd IronCodingChallenge
    ```

### Usage
1. Build the project:
    ```sh
    dotnet build
    ```
2. Run the project:
    ```sh
    dotnet run
    ```
3. The application demonstrates how to convert old phone keypad inputs to text. Here are some examples:

- Input: `33#` → Output: `E`
- Input: `227*#` → Output: `B`
- Input: `4433555 555666#` → Output: `HELLO`
- Input: `8 88777444666*664#` → Output: `TURING`
- Input: `222 2 22#` → Output: `CAB`

For more detailed usage, refer to the `OldPhoneKeyPadConverter` class in `OldPhoneKeyPadConverter.cs`.


## Example
Given the input sequence `222`, the converter will output `C` because pressing `2` three times cycles through `A`, `B`, and `C`.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.