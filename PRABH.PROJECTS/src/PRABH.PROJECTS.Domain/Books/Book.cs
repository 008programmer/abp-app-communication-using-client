using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace PRABH.PROJECTS.Books;

public class Book : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
}

public class Project : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public int WeeklyHours { get; set; }
}