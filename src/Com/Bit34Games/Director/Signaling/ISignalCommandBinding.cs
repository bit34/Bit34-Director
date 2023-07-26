namespace Com.Bit34Games.Director.Signaling
{
    public interface ISignalCommandBinding
    {
        //  METHODS
        void ToCommand<TCommand>() where TCommand : ICommand, new();
    }
}
