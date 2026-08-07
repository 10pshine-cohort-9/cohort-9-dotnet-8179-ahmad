using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingManagementSystem.Domain.Enums;

namespace TrackingManagementSystem.Domain.Entities
{
    public class TaskItem
    {
        public int TaskId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }

        public int? CategoryId { get; set; }
        public Categorys? Category { get; set; }

        public TaskPriorityType Priority { get; set; } = TaskPriorityType.Medium;
        public TaskStatusType Status { get; set; } = TaskStatusType.Pending;

        public int? AssignedToUserId { get; set; }
        public Users? AssignedToUser { get; set; }

        public int CreatedByUserId { get; set; }
        public Users CreatedByUser { get; set; } = null!;

        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
