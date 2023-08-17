namespace CS2023
{
    static class Attribute1Test
    {
        public static void Test()
        {
            Type widgetType = typeof(Widget);

            object[] widgetClassAttributes = widgetType.GetCustomAttributes(typeof(HelpAttribute), false);

            if (widgetClassAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)widgetClassAttributes[0];
                Console.WriteLine($"Widget class help URL : {attr.Url} - Related topic : {attr.Topic}");
            }

            System.Reflection.MethodInfo displayMethod = widgetType.GetMethod(nameof(Widget.Display))!;

            object[] displayMethodAttributes = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);

            if (displayMethodAttributes.Length > 0)
            {
                HelpAttribute attr = (HelpAttribute)displayMethodAttributes[0];
                Console.WriteLine($"Display method help URL : {attr.Url} - Related topic : {attr.Topic}");
            }
        }

    }
    [Help("https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
    public class Widget
    {
        [Help("https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/features",
        Topic = "Display")]
        public void Display(string text) { }
    }
    public class HelpAttribute : Attribute
    {
        string _url;
        string? _topic;

        public HelpAttribute(string url) => _url = url;

        public string Url => _url;

        public string? Topic
        {
            get => _topic;
            set => _topic = value;
        }
    }
    class Attribute1
    {
    }


}