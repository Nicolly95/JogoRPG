Random aleatorio = new Random();
int ataque;
int vidaHeroi = 10;
int vidaMonstro = 10;

do
{
    ataque = aleatorio.Next(1, 11);
    vidaMonstro -= ataque;
    Console.WriteLine($"O Monstro foi atingido e perdeu {ataque} de vida, ele permanece com {vidaMonstro} pontos de vida.");

    ataque = aleatorio.Next(1, 11);
    vidaHeroi -= ataque;
    Console.WriteLine($"O Heroi foi atingido e perdeu {ataque} de vida, ele permanece com {vidaHeroi} pontos de vida.");

} while (vidaHeroi > 0 && vidaMonstro > 0);

Console.WriteLine(vidaHeroi > vidaMonstro ? "Heroi venceu!" : "Monstro venceu!");

