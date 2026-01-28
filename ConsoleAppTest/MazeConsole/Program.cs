var mazeBuilder = new MazeBuilder();
var mazeDrawer = new MazeDrawer();

var maze = mazeBuilder.Build(5,8);
mazeDrawer.Draw(maze);