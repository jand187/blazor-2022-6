// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.SignalR.Client;

Console.WriteLine("Hello, World!");


var connection = new HubConnectionBuilder()
    .WithUrl("https://localhost:7005/messagehub")
    .Build();

connection.Closed += async error =>
{
    await Task.Delay(new Random().Next(0, 5) * 1000);
    await connection.StartAsync();
};

await connection.StartAsync();


var message = "";

while (message != "quit")
{
    message = Console.ReadLine();

    await connection.InvokeAsync("SendMessage", "jand187", message);
}