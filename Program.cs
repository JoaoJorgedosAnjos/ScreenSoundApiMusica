using System.Security.Cryptography;
using System.Text.Json;
using ScreenSoundApiMusica.Filters;
using ScreenSoundApiMusica.Models;

// using (HttpClient client = new HttpClient())
// {
//     try
//     {
//         string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
//         var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
//         LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
//         //musicas[0].ExibirDetalhesDaMusica();
//         //foreach (var musica in musicas)
//         // {
//         //     musica.ExibirDetalhesDaMusica();
//         //     Console.WriteLine("");
//         // }

//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Temos um problema: {ex.Message}");
//     }
// }
// using (HttpClient client3 = new HttpClient())
// {
//     string json = await client3.GetStringAsync("https://hp-api.onrender.com/api/characters/house/gryffindor");
//     System.Console.WriteLine(json);
// }
var fruits = new List<string>();
fruits.Add("🍒");
fruits.Add("🍍");
fruits.Add("🍏");
fruits.Add("🍑");
fruits.Add("🫐");
fruits.Add("🍌");
fruits.Add("🍉");
fruits.Add("🍇");
fruits.Add("🍓");

//Console.WriteLine(fruits.All(x => x == "🍌"));


// var students = new List<Student>();
// students.Add(new Student() { Name = "A", Age = 18 });
// students.Add(new Student() { Name = "B", Age = 20 });
// students.Add(new Student() { Name = "C", Age = 30 });

// Console.WriteLine(students.All(x => x.Age >= 18));

// class Student()
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }

