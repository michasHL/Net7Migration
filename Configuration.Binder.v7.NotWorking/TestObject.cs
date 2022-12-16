namespace Configuration.Binder.Working
{
    public class TestObject
    {
        public ISet<string> Regions { get; set; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    }
}
