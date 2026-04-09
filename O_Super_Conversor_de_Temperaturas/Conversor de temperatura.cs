//Autoriza o uso de emoji e caracteres especiais
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Digite a Temperatura em C° 🌡️:");
float.TryParse(Console.ReadLine(), out float celsius);
float resultado = (celsius * 9 / 5) + 32;
Console.WriteLine($"A temperatura é C°: {celsius}\nA conversão em F°: {resultado}");

Console.WriteLine("Digite a tempetura em F°🤒:");
float.TryParse(Console.ReadLine(), out float Fahrenheit);
float resposta = (Fahrenheit - 32) * 5 / 9;
Console.WriteLine($"A temperatura é F°: {Fahrenheit}\nA conversão em C°: {resposta}");

Console.WriteLine("Digite a temperatura em K° 😰:");
float.TryParse(Console.ReadLine(), out float Kelvin);
float resto = (Kelvin - 292.15F);
Console.WriteLine($"A temperatura é K°: {Kelvin}\nA conersão em C°: {resposta}");

Console.WriteLine("Digite a temperatura em K°:");
float.TryParse(Console.ReadLine(), out Kelvin);
float F = (Kelvin - 292.15F) * 9 / 5 + 32;
Console.WriteLine($"A temperatura é K°: {Kelvin}\nA convesão em F°: {resposta}");