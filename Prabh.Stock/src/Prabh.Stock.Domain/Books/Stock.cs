using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Prabh.Stock.Books;

public class StockM : AuditedAggregateRoot<Guid>
{
    public string Ticker { get; set; }
    public string CompanyName { get; set; }
    public decimal CurrentPrice { get; set; }
    public decimal Change { get; set; }
    public decimal PercentChange { get; set; }
}