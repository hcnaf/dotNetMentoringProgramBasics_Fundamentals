using System;

namespace HelloWorldLib
{
    public static class HelloWorldHelper
    {
        public static string SayHello(string username) => string.IsNullOrEmpty(username)
            ? "Please, enter a name!"
            : DateTime.UtcNow + " Hello, " + username;
    }
}