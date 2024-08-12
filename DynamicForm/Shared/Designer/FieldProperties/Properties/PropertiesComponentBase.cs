using Microsoft.AspNetCore.Components;
using DynamicForm.Data.Models;

namespace DynamicForm.Shared.Designer.FieldProperties.Properties
{
    public class PropertiesComponentBase : ComponentBase
    {
        public PropertiesComponentBase()
        {
        }

        [CascadingParameter(Name = "FormDesigner")]
        //public FormDesigner FormDesigner { get; set; }

        [Parameter]
        public ComponentDto ComponentData { get; set; }

        public async Task OnLabelChangedAsync(ChangeEventArgs e)
        {
            ComponentData.Label = e.Value.ToString();

            //await FormDesigner.StateHasChangedAsync();
            StateHasChanged();
            await Task.CompletedTask;
        }

        public async Task OnWidthChangedAsync(ChangeEventArgs e)
        {
            ComponentData.Width = Convert.ToInt32(e.Value);

            //await FormDesigner.StateHasChangedAsync();
            StateHasChanged();
            await Task.CompletedTask;
        }
    }
}
