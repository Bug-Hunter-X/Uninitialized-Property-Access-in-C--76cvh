# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property before it's been assigned a value.  The example shows how this can lead to unexpected results, and offers a solution to prevent this problem. 

## The Problem

In C#, if you access a property of a class before explicitly assigning it a value within a constructor or method, the property will have its default value. For value types (like `int`), this is 0; for reference types, it's `null`.  This can lead to logic errors that are difficult to track down. 

## The Solution

Always initialize properties in the constructor to ensure they have a predictable, consistent value when accessed.

## How to Run

1. Clone this repository.
2. Open the solution in Visual Studio.
3. Build and run the project.