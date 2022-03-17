using System;

namespace Com.Bit34Games.Director.Signaling
{
    public interface ISignal
    {
        //  MEMBERS
        Type CommandType { get; }

        //  METHODS
        void BindCommand(ICommand command);
    }
}
