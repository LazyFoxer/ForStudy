using MazeConsole.Models;
using MazeConsole.Models.Cells;

public class MazeBuilder
{
    private Random _random = new();
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
        BuildCoin();

        return _maze;
    }

    private void BuildCoin()
    {
        var grounds = _maze.Cells.
            OfType<Ground>().
            ToList();

        var randomIndex = _random.Next(0, grounds.Count());
        var randomGround = grounds[randomIndex];

        var coin = new Coin(randomGround.X, randomGround.Y);
        _maze[coin.X, coin.Y] = coin;
    }

    public void BuildGround()
    {
        for (int y = 0; y < _maze.Height; y++)
        {
            for (int x = 0; x < _maze.Width; x++)
            {
                if ((x + y) % 2 == 0)
                {
                    _maze[x, y] = new Ground(x, y);
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
                _maze[x, y] = new Wall(x, y);
            }
        }
    }
}