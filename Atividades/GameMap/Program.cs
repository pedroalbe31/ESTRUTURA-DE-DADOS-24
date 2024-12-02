using System.Text;

TerrainEnum[,] map =
{
    // Chama a opção do Enum, que vem em conjunto a cor e símbolo embutido
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS },
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS },
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS },
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
      TerrainEnum.GRASS },
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.WALL,
      TerrainEnum.WALL},
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.SAND,
      TerrainEnum.SAND},
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
      TerrainEnum.SAND, TerrainEnum.WALL, TerrainEnum.SAND,
      TerrainEnum.SAND},
    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.SAND,
      TerrainEnum.SAND},
    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.SAND,
      TerrainEnum.SAND},
    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER,
      TerrainEnum.WATER},
    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
      TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER,
      TerrainEnum.WATER},
 };

 // Serve para definir os símbolos utilizados
Console.OutputEncoding = UTF8Encoding.UTF8;

// Determina a quantidade de símbolos por linha e coluna
for (int row = 0; row < map.GetLength(0); row++)
{
    for (int column = 0; column < map.GetLength(1); column++)
    {
        Console.ForegroundColor = map[row, column].GetColor();
        Console.Write(map[row, column].GetChar() + " ");
    }
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Gray;