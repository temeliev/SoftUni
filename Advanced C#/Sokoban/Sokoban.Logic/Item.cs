namespace Sokoban.Logic
{
    public class Item
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public ItemType Type { get; set; }
    }

    public enum ItemType
    {
        Player,
        PlayerOnHole,
        PlayerOnSnake,
        PlayerOnGoal,
        Wall,
        Floor,
        Goal,
        Box,
        BoxOnGoal,
        BoxOnSnake,
        Hole,
        Snake,
        BoxOnHole
    }
}
