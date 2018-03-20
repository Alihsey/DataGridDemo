# DataGridDemo
Demonstration of Syncfusion.Xamarin.SfDataGrid issue with wrong ColumnIndex

When a table has some frozen columns (with fixed position) and their width is less than width of a not frozen ones, the tap event will catch a wrong ColumnIndex if a not frozen columns are scrolled far under the frozen ones.
