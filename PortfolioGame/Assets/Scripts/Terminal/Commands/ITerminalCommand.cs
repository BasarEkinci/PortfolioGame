namespace Terminal.Commands
{
    public interface ITerminalCommand
    {
        string CommandName { get; }
        void Execute();
    }
}