using MazeCore.Models.Cells;
using MazeCore.Models.Cells.Character;
using MazeCore.Models;
using MazeCore.Helper;

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
        BuildCoin();

        BuildHero();

        return _maze;
    }

    private void BuildHero()
    {
        var grounds = _maze.Cells.OfType<Ground>().ToList();
        var randomGround = GetRandom(grounds);
        var hero = new Hero(randomGround.X, randomGround.Y, _maze);
        _maze.Hero = hero;
    }

    private void BuildCoin()
    {
        var grounds = _maze.Cells.
            OfType<Ground>().
            ToList();

        var randomGround = GetRandom(grounds);

        var coin = new Coin(randomGround.X, randomGround.Y, _maze);
        _maze[coin.X, coin.Y] = coin;
    }

    public void BuildGround()
    {
        var walls = _maze.Cells;

        var wallReadyToDestroy = new List<BaseCell>();
        wallReadyToDestroy.Add(GetRandom(walls));

        do
        {
            var miner = GetRandom(wallReadyToDestroy);
            _maze[miner.X, miner.Y] = new Ground(miner.X, miner.Y, _maze);
            wallReadyToDestroy.Remove(miner);

            var nearWalls = GetNearCells<Wall>(miner);
            wallReadyToDestroy.AddRange(nearWalls);

            wallReadyToDestroy = wallReadyToDestroy
                .Where(wall =>
                    GetNearCells<Ground>(wall).Count == 1)
                .ToList();

        } while (wallReadyToDestroy.Any());
    }

    private List<CellType> GetNearCells<CellType>(BaseCell miner)
        where CellType : BaseCell
    {
        return MazeHelper.GetNearCells<CellType>(_maze, miner);
    }

    public void BuildWall()
    {
        for (int y = 0; y < _maze.Height; y++)
        {
            for (int x = 0; x < _maze.Width; x++)
            {
                _maze[x, y] = new Wall(x, y, _maze);
            }
        }
    }

    private T GetRandom<T>(List<T> cells)
    {
        return MazeHelper.GetRandom(_maze, cells);
    }
}