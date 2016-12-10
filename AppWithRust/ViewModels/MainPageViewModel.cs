using System;
using System.Reactive.Disposables;
using System.Windows.Input;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace AppWithRust
{
    public class MainPageViewModel : IDisposable
    {
        CompositeDisposable Disposables { get; } = new CompositeDisposable();
        ReactiveCommand _CallRustCommand { get; } = new ReactiveCommand();
        public MainPageViewModel()
        {
            this._CallRustCommand.Subscribe(_ =>
            {
                var intValue = NativeMethods.rust_sum(1, 2);
                this.Text.Value = intValue.ToString();
            }).AddTo(this.Disposables);
        }

        public IReactiveProperty<string> Text { get; } = new ReactiveProperty<string>("");
        public ICommand CallRustCommand => _CallRustCommand;
        public void Dispose()
        {
            this.Disposables.Dispose();
        }
    }
}
