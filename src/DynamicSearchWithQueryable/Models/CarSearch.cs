using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;

namespace DynamicSearchWithQueryable.Models
{
    public class CarSearch : ICustomQueryable, IQueryPaging, IQuerySort
    {
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string Manufacturer { get; set; }
        
        public string Model { get; set; }
        
        public int? Year { get; set; }
        
        public int? Limit { get; set; } = 10;
        
        public int? Offset { get; set; }
        
        public string Sort { get; set; }
    }
}