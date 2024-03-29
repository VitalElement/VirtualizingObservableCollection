namespace VitalElement.DataVirtualization.DataManagement
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;

    public class SortDescription : IFilterOrderDescription
    {
        public SortDescription(string propertyName, ListSortDirection? direction)
        {
            Direction = direction;
            PropertyName = propertyName;
        }

        public ListSortDirection? Direction { get; set; }

        public string PropertyName { get; set; }
    }
}