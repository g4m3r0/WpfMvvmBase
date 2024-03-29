# WPF MVVM Base Library
[![NuGet](https://img.shields.io/nuget/v/GSL.Util.WpfMvvmBase.svg)](https://www.nuget.org/packages/GSL.Util.WpfMvvmBase)
[![NuGet Downloads](https://img.shields.io/nuget/dt/GSL.Util.WpfMvvmBase.svg)](https://www.nuget.org/packages/GSL.Util.WpfMvvmBase)

This library makes it easier to create simple WPF applications using the [MVVM (Model-View-ViewModel)](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm) pattern.

It basically consists of two parts
1) *NotifiableBaseObject*
The *NotifiableBaseObject* implements the *INotifyPropertyChanged* interface, to raise an event when the value of an object changed.

2) *DelegateCommand*
The *DelegateCommand* extends the [*ICommand*](https://learn.microsoft.com/en-us/dotnet/api/system.windows.input.icommand?view=net-7.0) interface.
It provides a code contract for commands, which basically provides the commanding behavior for UI elements.


## Basic Example
todo
