// See https://aka.ms/new-console-template for more information


using System.Reflection;
using OOPtask.Models;

Student emp = new Student();

string name, major;

Console.WriteLine("enter name");
name = Console.ReadLine();

Console.WriteLine("enter your major");
major= Console.ReadLine();

Console.WriteLine("enter your GPA");
double GPA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(emp.GetInfo(name, major, GPA));