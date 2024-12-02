
//Define os tipos de requisições que serão feitas
public enum TerrainEnum
{
    SAND,
    WALL,
    GRASS,
    WATER
}


public static class TerrainEnumExtensions
 {
    // Define a cor do símbolo que irá aparecer quando cada tipo for chamado
    public static ConsoleColor GetColor(this TerrainEnum terrain)
    {
        switch (terrain)
        {
            case TerrainEnum.GRASS: return ConsoleColor.Green;
            case TerrainEnum.SAND: return ConsoleColor.Yellow;
            case TerrainEnum.WATER: return ConsoleColor.Blue;
            default: return ConsoleColor.DarkGray;
        }
    }
    // Define o símbolo que irá aparecer quando cada tipo for chamado
    public static char GetChar(this TerrainEnum terrain)
    {
        switch (terrain)
        {
            case TerrainEnum.GRASS: return '\u201c';
            case TerrainEnum.SAND: return '\u25cb';
            case TerrainEnum.WATER: return '\u2248';
            default: return '\u25cf';
        }
    }
 }