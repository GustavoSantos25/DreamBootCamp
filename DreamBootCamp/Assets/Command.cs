public class Command
{
    public string Name { get; set; }

    public override string ToString()
    {
        return this.Name;
    }
}