class Widget
{
    public Widget()
    {
        // Вот и конфликт!!!!!!!
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime WidgetTime { get; set; }
}