using System;
using Volo.Abp.Application.Dtos;

namespace Prabh.Stock.Books;

public class StockDto : AuditedEntityDto<Guid>
{
    public string Ticker { get; set; }
    public string CompanyName { get; set; }
    public decimal CurrentPrice { get; set; }
    public decimal Change { get; set; }
    public decimal PercentChange { get; set; }
}