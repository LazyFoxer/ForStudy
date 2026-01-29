using MazeConsole.Models;

public class MazeDrawer
{
    public void Draw(Maze maze)
    {
        Console.WriteLine($"Maze has {maze.Cells.Count} cells");

        for (int y = 0; y < maze.Height; y++)
        {
            for (int x = 0; x < maze.Width; x++)
            {
                var cell = maze[x, y];
                Console.Write(cell.Symbol);
            }
            Console.WriteLine();
        }
    }
}