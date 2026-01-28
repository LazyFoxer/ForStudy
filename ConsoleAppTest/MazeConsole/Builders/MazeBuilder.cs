using MazeConsole.Models;
using MazeConsole.Models.Cells;

public class MazeBuilder
{
    private Maze _maze;
    public Maze Build(int width, int height)
    {
        _maze = new Maze
        { 
            Width = width, 
            Height = height 
        };
        BuildWall();
        BuildGround();

        return _maze;
    }

    public void BuildGround()
    {
        for (int y = 0; y < _maze.Height; y++)
        {
            for (int x = 0; x < _maze.Width; x++)
            {
                if ((x + y) % 2 == 0)
                {
                    var cell = new Ground(x, y);
                    _maze.ReplaceCell(cell);
                }
            }
        }
    }

    public void BuildWall()
    {
        for (int y = 0; y < _maze.Height; y++)
        {
            for (int x = 0; x < _maze.Width; x++)
            {
                var cell = new Wall(x, y);
                _maze.Cells.Add(cell);
            }
        }
    }
}