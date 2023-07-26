using System;
using System.Collections.Generic;
using Com.Bit34Games.Injector;

namespace Com.Bit34Games.Director.Signaling
{
    public class SignalCommandBinder
    {
        //	MEMBERS
        private readonly IInjector _injector;
        private Dictionary<Type,ISignalCommandBindingInternal> _bindings;

        //	CONSTRUCTOR
        public SignalCommandBinder(IInjector injector)
        {
            _injector = injector;
            _bindings = new Dictionary<Type, ISignalCommandBindingInternal>();
        }

        //  METHODS
        public ISignalCommandBinding BindSignal<TSignal>()
            where TSignal : ISignal, new()
        {
            Type signalType = typeof(TSignal);

            ISignalCommandBindingInternal binding;
            if(_bindings.TryGetValue(signalType, out binding)==false)
            {
                binding = new SignalCommandBinding<TSignal>(_injector);
                _bindings.Add(signalType, binding);
                _injector.AddBinding<TSignal>().ToType<TSignal>();
            }

            return binding;
        }

        public void InstantiateCommands()
        {
            foreach (ISignalCommandBindingInternal binding in _bindings.Values)
            {
                binding.InstantiateCommands();
            }
        }

    }
}
