# Epicodus Week6 Project Word Counter

## Created

06/29/2018

## About

Create a program that checks how frequently a word appears in a given string

## Spec

|Behavior|	Input1	|Input2	|Output	|Justification|
|:--------|:-------------:|:--------------:|:---:|:---:|
|Takes user inputs: 1. word 2. list of words	|hello|	hello world hello	|1: hello 2: hello world hello	|To take 2 inputs for comparison
|Splits inputs	|hello	|hello world hello	|1. "hello" 2: "hello", "world", "hello"	|To compare inputs for matching words
|Compares the inputs and detect same value in input 2	|hello	|hello world hello	|"hello", "hello"	|To detect matching value
|Adds detected matching values to a list	|hello	|hello world hello	|["hello", "hello"]	|To take only matching value from Input2
|Counts the matching value in the list|	["hello", "hello"]	|-	|2|To count the matching values


## Technology Used

C#, .NET Core 1.1

## Installation

Clone from:
https://github.com/hisatokawaminami/WordCounter.git

## Credits
Hisato Kawaminami


## License

The MIT License (MIT)

Copyright (c) 2015 Hisato Kawaminami

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
