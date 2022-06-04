
void ExibirMensagem() =>
    Console.WriteLine("Testando Hot Reload. Incrível");

ConsoleKeyInfo tecla;

Console.WriteLine("Aperte uma tecla\r\n");

while (true)
{
    tecla = Console.ReadKey();

    if (tecla.Key == ConsoleKey.Escape) break;

    ExibirMensagem();
}
