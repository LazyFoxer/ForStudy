using MazeConsole.Models.Cells.Character;

namespace MazeConsole.Models.Cells
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
            Console.WriteLine("step-step");
        }
    }
}
