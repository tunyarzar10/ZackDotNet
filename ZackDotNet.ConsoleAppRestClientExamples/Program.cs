﻿// See https://aka.ms/new-console-template for more information
using ZackDotNet.ConsoleAppRestClientExamples;

Console.WriteLine("Hello, World!");

HttpClientExample clientExample = new HttpClientExample();  
await clientExample.RunAsync();

Console.ReadLine();