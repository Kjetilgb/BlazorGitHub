namespace BlazorGitHub.Shared
{
    public class ItemType
    {
        public string Name { get; }
        public string Value { get; }
 
        public ItemType(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}