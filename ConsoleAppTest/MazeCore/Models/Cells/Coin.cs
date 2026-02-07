using MazeCore.Models.Cells.Character;
using MazeCore.Models;

namespace MazeCore.Models.Cells
{

    public class Coin : BaseCell
    {
        public Coin(int x, int y, Maze maze) : base(x, y, maze)
        {
        }

        public override char Symbol => 'c';

        public override void InteractWithCell(BaseCharacter character)
        {
            AddEventInfo("How, wow, it's a coin");
        }

        public override bool TryStep(BaseCharacter character)
        {
            character.Coins++;
            Maze[X, Y] = new Ground(X, Y, Maze);
            return true;
        }
    }
}
