using System;
using System.Text.Json;
using System.IO;

survivor player = new();


player.strength = 6;
player.durability = 4;

Console.WriteLine("Hello survivior, what is your name?");
player.name = Console.ReadLine();


string save = JsonSerializer.Serialize<survivor>(player);

File.WriteAllText("save.txt", save);

Console.WriteLine(save);

Console.ReadLine();