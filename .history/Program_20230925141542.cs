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
  Calculation(operationSign);
}

static void Calculation(int calOperator) {
  Console.WriteLine("First value:");
  double value1 = double.Parse(Console.ReadLine());

  Console.WriteLine("Second value:");
  double value2 = double.Parse(Console.ReadLine());
  
  var operationSign = calOperator;
  switch (operationSign) {
    case 1: Console.W
  }
}
