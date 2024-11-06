namespace HelloWorld.Configurations
{
    public class DatabaseSettings
    {
        // Using auto-property initializer - What we'll use most of the time
        public required string? ConnectionString { get; set; }
        public required string? DatabaseName { get; set; }
        
        
        
        // Using constructor initializer - Useful when you need to do more than just set the value
        private string? _additionalProperty;  // Hidden field managed by the compiler. 

        public string AdditionalProperty
        {
            get => $"{_additionalProperty} is the property"; // A more complex getter that returns the property with a suffix
            set => _additionalProperty = $"{value} {value}"; // A more complex setter that sets the property twice
        }
    }
}