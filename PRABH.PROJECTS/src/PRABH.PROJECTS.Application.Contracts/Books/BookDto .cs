using System;
using Volo.Abp.Application.Dtos;

namespace PRABH.PROJECTS.Books;

public class BookDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
}

public class ProjectDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public int WeeklyHours { get; set; }
}


