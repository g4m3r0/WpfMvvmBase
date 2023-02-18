namespace GSL.Util.WpfMvvmBase;

using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// Provides the ability to easily implement the INotifyPropertyChanged interface.
/// </summary>
public class NotifiableBaseObject : INotifyPropertyChanged
{
    /// <summary>
    /// Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Occurs when a property value changes.
    /// </summary>
    /// <param name="propertyName">Name of the changed property</param>
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
