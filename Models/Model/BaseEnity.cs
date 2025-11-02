namespace APIGenerationProject.Repository.Model
{
    public class BaseEnity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "System";
        public bool isDeleted { get; set; }
        public string UpdatedBy { get; set; } = "System";
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
