namespace ConfigurationProvider.Net6.DoubleConfigure.Working
{
    public class TestOptions
    {
        public const string SettingName = "TestOptions";

        /// <summary>
        /// Connection string uses format - nam--eastus2--0
        /// </summary>
        public IDictionary<string, IDictionary<string, string[]>> Connections { get; set; } =
            new Dictionary<string, IDictionary<string, string[]>>(StringComparer.OrdinalIgnoreCase);
    }
}