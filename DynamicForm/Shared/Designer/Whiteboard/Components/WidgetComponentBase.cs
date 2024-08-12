using DynamicForm.Data.Models;
using Microsoft.AspNetCore.Components;

namespace DynamicForm.Shared.Designer.Whiteboard.Components
{
    public partial class WidgetComponentBase : ComponentBase
    {
        [Parameter]
        public ComponentDto Component { get; set; }

        public WidgetComponentBase()
        {

        }
    }
}
