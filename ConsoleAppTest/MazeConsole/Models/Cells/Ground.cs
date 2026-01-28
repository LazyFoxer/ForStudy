namespace MazeConsole.Models.Cells
{
    public class Ground : BaseCell
    {
        public override char Symbol => '.';

        public Ground(int x, int y) : base(x, y)
        {
        }

        public override bool TryStep()
        {
            return true;
        }

        public override void InteractWithCell()
        {
            Console.WriteLine("step-step");
        }
    }
}
