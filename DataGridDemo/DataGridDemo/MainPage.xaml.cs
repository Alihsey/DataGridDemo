using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;

namespace DataGridDemo
{
	public partial class MainPage : ContentPage
	{
	    public static readonly BindableProperty SampleTableProperty =
            BindableProperty.Create(nameof(SampleTable), typeof(ObservableCollection<TableRow>), typeof(ContentPage));
	    public ObservableCollection<TableRow> SampleTable
	    {
	        get { return (ObservableCollection<TableRow>)GetValue(SampleTableProperty); }
	        set { SetValue(SampleTableProperty, value); }
	    }

	    public MainPage()
	    {
	        InitializeComponent();
            SampleDataGrid.PullToRefreshCommand = new Command(ClearTable);
	        ClearTable();
	    }

	    private void ClearTable()
	    {
	        SampleTable = new ObservableCollection<TableRow>();
	        for (int i = 0; i < 10; i++)
	        {
	            SampleTable.Add(new TableRow());
	        }
        }

	    private void SampleDataGrid_OnGridTapped(object sender, GridTappedEventArgs e)
	    {
	        if (!(e?.RowData is TableRow selectedItem)) return;

	        switch (e.RowColumnIndex.ColumnIndex)
	        {
                case 0: selectedItem.Column1 = "1"; break;
                case 1: selectedItem.Column2 = "2"; break;
                case 2: selectedItem.Column3 = "3"; break;
                case 3: selectedItem.Column4 = "4"; break;
                case 4: selectedItem.Column5 = "5"; break;
                case 5: selectedItem.Column6 = "6"; break;
                case 6: selectedItem.Column7 = "7"; break;
	        }
	    }
    }

    public class TableRow : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public TableRow()
        {
            Column1 = string.Empty;
            Column2 = string.Empty;
            Column3 = string.Empty;
            Column4 = string.Empty;
            Column5 = string.Empty;
            Column6 = string.Empty;
            Column7 = string.Empty;
        }

        private string _column1;
        public string Column1
        {
            get { return _column1; }
            set
            {
                _column1 = value;
                OnPropertyChanged();
            }
        }

        private string _column2;
        public string Column2
        {
            get { return _column2; }
            set
            {
                _column2 = value;
                OnPropertyChanged();
            }
        }

        private string _column3;
        public string Column3
        {
            get { return _column3; }
            set
            {
                _column3 = value;
                OnPropertyChanged();
            }
        }

        private string _column4;
        public string Column4
        {
            get { return _column4; }
            set
            {
                _column4 = value;
                OnPropertyChanged();
            }
        }

        private string _column5;
        public string Column5
        {
            get { return _column5; }
            set
            {
                _column5 = value;
                OnPropertyChanged();
            }
        }

        private string _column6;
        public string Column6
        {
            get { return _column6; }
            set
            {
                _column6 = value;
                OnPropertyChanged();
            }
        }

        private string _column7;
        public string Column7
        {
            get { return _column7; }
            set
            {
                _column7 = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
