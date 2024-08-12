using DynamicForm.Data.Models;

namespace DynamicForm.Data.Extensions
{
    public static class PaletteWidgetDtoExtensions
    {
        public static ComponentDto CreateComponent(this PaletteWidgetDto paletteWidget)
        {
            var componentData = new ComponentDto(paletteWidget.ComponentType);
            return componentData;
        }
    }
}
