using System.Windows.Input;

namespace salon.view;

public class VIewModel: ICommand
{
    private Action action;
    public VIewModel(Action action) => this.action = action;
    public bool CanExecute(object parameter) => true;
#pragma warning disable CS0067
    public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067
    public void Execute(object parameter) => action();
}