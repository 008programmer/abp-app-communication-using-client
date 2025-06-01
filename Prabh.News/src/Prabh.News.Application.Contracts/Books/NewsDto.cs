using System;
using Volo.Abp.Application.Dtos;

namespace Prabh.News.Books;

public class NewsDto : AuditedEntityDto<Guid>
{
    public string Title { get; set; }
    public string Summary { get; set; }
    public DateTime Date { get; set; }
}