namespace HelloWorld.Attributes
{
    /*
     * We can define a custom attribute (that we can use above a function with [VersionAttribute]
     */
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    // Main constructor with required version parameter
    public class VersionAttribute(string version) : Attribute
    {
        public string Version { get; } = version;
        public string? Author { get; }
        public int? Year { get; }  


        // Overload constructor with version AND author parameters
        public VersionAttribute(string version, string author) : this(version) // calls the main constructor with the version
        {
            Author = author; // Then also sets the author. This is to respect the DRY principle
        }

        // Constructor with all parameters: version, author, and year
        public VersionAttribute(string version, string author, int year) : this(version, author) // calls the constructor that has the version and author
        {
            Year = year; // Then sets the year
        }
    }
}