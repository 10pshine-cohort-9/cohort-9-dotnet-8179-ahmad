namespace TrackingManagementSystem.Domain.Entities
{
    public class Categorys
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        public int? CreatedByUserId { get; set; }
        public Users? CreatedByUser { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
