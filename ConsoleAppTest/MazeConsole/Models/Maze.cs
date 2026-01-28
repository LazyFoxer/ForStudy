using MazeConsole.Models.Cells;

namespace MazeConsole.Models
{
    public class Maze
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<BaseCell> Cells { get; set; } = new List<BaseCell>();

        public void ReplaceCell(BaseCell newCell)
        {
            var oldCell = Cells.First(cell => cell.X == newCell.X && cell.Y == newCell.Y);
            Cells.Remove(oldCell);
            Cells.Add(newCell);
        }
    }
}
