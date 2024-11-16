namespace Counter;

internal partial record Countable(int Count, int Step)
{
    public Countable Increment()
    {
        return this with
        {
            Count = Count + Step
        };
    }
}

internal partial record MainModel
{
    public IState<Countable> Countable => State.Value(this, () => new Countable(0, 1));

    public ValueTask IncrementCounter()
    {
        return Countable.UpdateAsync(c => c?.Increment());
    }
}
