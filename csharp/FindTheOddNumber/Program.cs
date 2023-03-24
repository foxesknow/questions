// See https://aka.ms/new-console-template for more information

using FindTheOddNumber;

/*
 * For this challenge you have an array of odd numbers which are group together in pairs.
 * There's potentially an "odd one out number" which is an odd number not part of a pair.
 * Try and find the number
 */

var numbers = new[]{9, 9, 3, 3, 7};
if(Xor.Find(numbers, out var xorResult)) Console.WriteLine($"Xor.Find found {xorResult}");

Console.WriteLine("Done");
