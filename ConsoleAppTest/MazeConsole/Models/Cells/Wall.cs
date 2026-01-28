namespace MazeConsole.Models.Cells
{
    public class Wall : BaseCell
    {
        public Wall(int x, int y) : base(x, y)
        {
        }

        public override char Symbol => '#';

        public override void InteractWithCell()
        {
            Console.WriteLine("Boom-Boom");
        }

        public override bool TryStep()
        {
            return false;
        }
    }
}
