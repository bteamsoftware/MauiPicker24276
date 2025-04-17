using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiPicker8845;


public partial class ViewModel : ObservableObject
{
	 [ObservableProperty]
	 public partial string Status { get; set; } = string.Empty;
}
