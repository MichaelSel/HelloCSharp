namespace HelloWorld.Routes
{
    public static class ApiRoutes
    {
        private const string Base = "api/v1";

        public static class Products
        {
            public const string GetAll = $"{Base}/products";
            public const string GetById = $"{Base}/products/{{id}}";
        }
    }
}