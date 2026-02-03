namespace MazeConsole.Models.Cells.Character
{
    public class Hero : BaseCell
    {
        public Hero(int x, int y) : base(x, y)
        {
        }

        public override char Symbol => throw new NotImplementedException();

        public override void InteractWithCell()
        {
            throw new NotImplementedException();
        }

        public override bool TryStep()
        {
            throw new NotImplementedException();
        }
    }
}
