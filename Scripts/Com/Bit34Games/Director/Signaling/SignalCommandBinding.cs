using System;
using System.Collections.Generic;
using Com.Bit34Games.Injector;
using Com.Bit34Games.Director.Error;

namespace Com.Bit34Games.Director.Signaling
{
    public class SignalCommandBinding<TSignal> : ISignalCommandBindingInternal
        where TSignal : ISignal, new()
    {
        //  MEMBERS
        public Type SignalType   { get; private set; }
        //      Internal
        private IInjector    _injector;
        private List<Type>   _commandTypes;
        private List<Action> _commandInstances;

        //  CONSTRUCTOR(S)
        public SignalCommandBinding(IInjector injector)
        {
            SignalType        = typeof(TSignal);
            _injector         = injector;
            _commandTypes     = new List<Type>();
            _commandInstances = new List<Action>();
        }

        //  METHODS
        public void ToCommand<TCommand>()
            where TCommand : ICommand, new()
        {
            Type commandType = typeof(TCommand);

            TSignal testSignal = new TSignal();
            if(!testSignal.CommandType.IsAssignableFrom(commandType))
            {
                throw DirectorException.CreateCommandIsNotAssignableToSignal(typeof(TSignal), commandType, 1);
            }

            _commandTypes.Add(commandType);
            _commandInstances.Add(()=>
            {
                TCommand command = new TCommand();
                _injector.InjectInto(command);

                TSignal signal = _injector.GetInstance<TSignal>();
                signal.BindCommand(command);
            });
        }

        public void InstantiateCommands()
        {
            for (int i = 0; i < _commandInstances.Count; i++)
            {
                _commandInstances[i]();
            }

        }
    }
}
