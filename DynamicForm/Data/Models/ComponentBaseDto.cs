namespace DynamicForm.Data.Models
{
    public class ComponentBaseDto
    {
        public ComponentBaseDto()
        {
            Id = Guid.NewGuid();
        }

        public ComponentBaseDto(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
