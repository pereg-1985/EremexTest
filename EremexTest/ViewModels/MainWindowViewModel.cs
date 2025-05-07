using System.Collections.ObjectModel;
using EremexTest.Structures;

namespace EremexTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    
    #pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
    #pragma warning restore CA1822 // Mark members as static

    public ObservableCollection<DataGridData> Items { get; set; } = [];

    public MainWindowViewModel()
    {
        
        this.Items.Add(item: new DataGridData
        {
            Column1 = "Column1 - 1",
            Column2 = "Column2 - 1",
            Column3 = "Column3 - 1"
        });
        
        this.Items.Add(item: new DataGridData
        {
            Column1 = "Column1 - 2",
            Column2 = "Column2 - 2",
            Column3 = "Column3 - 2"
        });
        
        this.Items.Add(item: new DataGridData
        {
            Column1 = "Column1 - 3",
            Column2 = "Column2 - 3",
            Column3 = "Column3 - 3"
        });
        
    }

}