﻿Console.WriteLine("Ermogenes".ToUpper().Replace("e","&"));

Console.Clear();
Console.WriteLine("---Traduzindo Para Baleês---\n");
Console.WriteLine("Digite o texto a ser traduzido:");
string texto = Console.ReadLine()!;
Console.WriteLine("\nA Dori diria...\n");
Console.WriteLine(texto
.Replace("a","aaa")
.Replace("e","eee")
.Replace("i","iii")
.Replace("o","ooo")
.Replace("u","uuu")
.Replace("A","AAA")
.Replace("E","EEE")
.Replace("I","III")
.Replace("O","OOO")
.Replace("U","UUU")
);
Console.WriteLine();
