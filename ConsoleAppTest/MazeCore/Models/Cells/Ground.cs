using MazeCore.Models.Cells.Character;
using MazeCore.Models;

namespace MazeCore.Models.Cells
{
    public class Ground : BaseCell
    {
        public override char Symbol => '.';

        public Ground(int x, int y, Maze maze) : base(x, y, maze)
        {
        }

        public override bool TryStep(BaseCharacter character)
        {
            return true;
        }

        public override void InteractWithCell(BaseCharacter character)
        {
            AddEventInfo("step-step");
        }
    }
}
