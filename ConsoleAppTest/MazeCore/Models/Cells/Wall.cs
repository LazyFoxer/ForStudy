using MazeCore.Models.Cells.Character;
using MazeCore.Models;

namespace MazeCore.Models.Cells
{
    public class Wall : BaseCell
    {
        public Wall(int x, int y, Maze maze) : base(x, y, maze)
        {
        }

        public override char Symbol => '#';

        public override void InteractWithCell(BaseCharacter character)
        {
            AddEventInfo("Boom-Boom");
        }

        public override bool TryStep(BaseCharacter character)
        {
            AddEventInfo("Boom-Boom");
            return false;
        }
    }
}
