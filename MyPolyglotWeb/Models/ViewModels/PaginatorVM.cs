using System.Collections.Generic;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class PaginatorVM
    {
        public int TotalRecordCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public List<int> PageSizeOptions
        {
            get
            {
                return new List<int>() { 5, 10, 15, 20 };
            }
        }
        public int TotalPageCount
        {
            get
            {
                return TotalRecordCount % PageSize == 0
                    ? TotalRecordCount / PageSize
                    : TotalRecordCount / PageSize + 1;
            }
        }
        public SortColumn SortColumn { get; set; }
        public SortDirection SortDirection { get; set; }
    }

    public enum SortColumn
    {
        LessonId,
        RusPhrase,
        EngPhrase,
    }

    public enum SortDirection
    {
        ASC,
        DESC
    }
}
