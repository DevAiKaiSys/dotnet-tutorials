namespace SimpleCalculator;
public partial record MainModel
{
    public MainModel()
    {
        Calculator = State.Value(this, () => new Calculator());
        IsDark = State<bool>.Value(this, () => false);
    }

    public IState<bool> IsDark { get; }

    public IState<Calculator> Calculator { get; }

    public async ValueTask InputCommand(string key, CancellationToken ct)
    {
        await Calculator.Update(c => c?.Input(key), ct);
    }
}
