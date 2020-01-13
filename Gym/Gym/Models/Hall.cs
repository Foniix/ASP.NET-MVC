namespace Gym.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Descr { get; set; }
        public int CounterOfClient { get; set; }
        //Style
        public string Headin { get; set; }
        public string Collapse { get; set; }
        public bool Expanded { get; set; }
    }
}