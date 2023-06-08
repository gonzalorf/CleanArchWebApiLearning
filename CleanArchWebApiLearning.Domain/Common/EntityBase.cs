namespace CleanArchWebApiLearning.Domain.Common;

public class EntityBase
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset? DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}
