namespace WebFletch.Order.Models
{
    public class KeyNamePair<k, v>
    {
        public KeyNamePair() { }
        public KeyNamePair(k key, v name)
        {
            Key = key;
            Name = name;
        }
        public k Key { get; set; }
        public v Name { get; set; }
    }
}