using ReactiveUI.Fody.Helpers;

namespace EremexTest.Structures;

public record DataGridData
{

    [Reactive]
    public string Column1 { get; set; }
    
    [Reactive]
    public string Column2 { get; set; }
    
    [Reactive]
    public string Column3 { get; set; }
    
}