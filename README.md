# Old Phone Pad – C# Coding Challenge

This is a C# console application created by Martin Echenique as part of a coding challenge for the Help Desk Engineer position at Iron Software.

It simulates typing on an old mobile phone keypad by translating a string of numeric input into the corresponding text message (e.g., '222 2 22' → 'CAB').

## Features

- Translates number strings into text using the old phone pad model.
- Supports:
  - Letter cycling (e.g., '7777' → 'S')
  - Backspace ('*')
  - Spaces between inputs allow for using the same button repeatedly.
- Handles edge cases, like multiple characters over the limit or deleting from empty.

## Unit Testing

- 10 unit tests using xUnit
- Covers normal cases and edge conditions

## How to Run

1. Clone or download this repo.
2. Open `CodingChallenge.sln` in Visual Studio.
3. Press F5 or click the green play button to run the app.

The test results will be displayed in the console.

## Running Tests

- Click Run All Tests from the menu: Test > Run All Tests.

You can also run from terminal:

***
dotnet test
***

## Notable Edge Cases

- Inputs like '222222' cycle through letters as on real keypads.
- Deleting with '*' when output is empty is handled safely using a ternary check.

## Date

May 22, 2025

## Notes

- Developed in C# using .NET and Visual Studio
- Built with readability, maintainability, and test coverage taken into account.
