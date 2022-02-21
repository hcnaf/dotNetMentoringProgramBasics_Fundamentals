namespace HelloWorldLib
{
    public static class HelloWorldHelper
    {
        public static string SayHello(string username) => DateTime.UtcNow + "Hello, " + username;
    }
}