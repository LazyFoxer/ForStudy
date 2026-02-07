using MazeCore.Models;

namespace MazeCore.Models.Cells.Character
{
    public class Hero : BaseCharacter
    {
        public string Name { get; set; }

        public Hero(int x, int y, Maze maze) : base(x, y, maze)
        {
        }

        public override char Symbol => '@';

        public override void InteractWithCell(BaseCharacter character)
        {
            throw new NotImplementedException();
        }
    }
}
