namespace serializer.Model;

public class designItem
{
    public string item { get; set; }
    public WidgetPosition position { get; set; }
    public string name { get; set; }
    public string uniqueId { get; set; }
}

public class WidgetPosition
{
    public string x { get; set; }
    public string y { get; set; }
}