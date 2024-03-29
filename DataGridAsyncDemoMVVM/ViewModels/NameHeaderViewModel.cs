namespace DataGridAsyncDemoMVVM.ViewModels;

using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Input;
using ReactiveUI;
using VitalElement.DataVirtualization.Extensions;

public partial class NameHeaderViewModel : ViewModelBase
{
    private ListSortDirection _sortDirection;

    public NameHeaderViewModel(RemoteOrDbDataSource dataSource, Expression<Func<RemoteOrDbDataItem, string>> property)
    {
        ToggleSortCommand = ReactiveCommand.Create(() =>
        {
            _sortDirection = _sortDirection == ListSortDirection.Ascending
                ? ListSortDirection.Descending
                : ListSortDirection.Ascending;

            dataSource.CreateSortDescription(property, _sortDirection);
        });
    }
    
    public ICommand ToggleSortCommand { get; }
}