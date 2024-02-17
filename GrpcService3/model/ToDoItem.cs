namespace GrpcService3.model
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string ToDoStutus { get; set; } = "NEW";

    }
}
