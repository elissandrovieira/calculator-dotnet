﻿// See https://aka.ms/new-console-template for more information

Menu();

static void Menu() {
  Console.Clear();
  Console.WriteLine("What is the operation you deserve?");
  Console.WriteLine("1 - Addition");
  Console.WriteLine("2 - Subtraction");
  Console.WriteLine("3 - Multiplication");
  Console.WriteLine("4 - Division");

  var operationSign = int.Parse(Console.ReadLine());
}

static void Calculation()
