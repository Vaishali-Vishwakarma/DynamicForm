namespace DynamicForm.Data.Models
{
    public class PaletteWidgetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ComponentType ComponentType { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string Icon { get; set; }
        public bool Visible { get; set; }
    }
}
