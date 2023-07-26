using System;

namespace Com.Bit34Games.Director.Signaling
{





    public class Signal : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate();

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch()                                { if(_event!=null) _event.Invoke(); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }
            public Type ListenerType{ get{ return typeof(ListenerDelegate); } }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod();
        }
    }






    public class Signal<T0> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0)                       { if(_event!=null) _event.Invoke(param0); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0);
        }
    }







    public class Signal<T0, T1> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1)            { if(_event!=null) _event.Invoke(param0, param1); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1);
        }
    }







    public class Signal<T0, T1, T2> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2) { if(_event!=null) _event.Invoke(param0, param1, param2); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2);
        }
    }







    public class Signal<T0, T1, T2, T3> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2, T3 param3);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2, T3 param3) { if(_event!=null) _event.Invoke(param0, param1, param2, param3); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2, T3 param3);
        }
    }







    public class Signal<T0, T1, T2, T3, T4> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4) { if(_event!=null) _event.Invoke(param0, param1, param2, param3, param4); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4);
        }
    }







    public class Signal<T0, T1, T2, T3, T4, T5> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) { if(_event!=null) _event.Invoke(param0, param1, param2, param3, param4, param5); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5);
        }
    }







    public class Signal<T0, T1, T2, T3, T4, T5, T6> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) { if(_event!=null) _event.Invoke(param0, param1, param2, param3, param4, param5, param6); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6);
        }
    }







    public class Signal<T0, T1, T2, T3, T4, T5, T6, T7> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) { if(_event!=null) _event.Invoke(param0, param1, param2, param3, param4, param5, param6, param7); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7);
        }
    }







    public class Signal<T0, T1, T2, T3, T4, T5, T6, T7, T8> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8) { if(_event!=null) _event.Invoke(param0, param1, param2, param3, param4, param5, param6, param7, param8); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8);
        }
    }







    public class Signal<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : ISignal
    {
        //  DELEGATES
        public delegate void ListenerDelegate(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9);

        //  MEMBERS
        public Type CommandType { get{return typeof(Command);} }
        //      Internal
        private event ListenerDelegate _event;

        //  CONSTRUCTOR
        public Signal() { }

        //  METHODS
        public void AddListener(ListenerDelegate listener)    { _event += listener; }
        public void RemoveListener(ListenerDelegate listener) { _event -= listener; }
//      public void RemoveAllListeners()                      { _event = null; }      -> Using this can cause problems
        public void BindCommand(ICommand command)             { AddListener(((Command)command).Execute); }
        public void Dispatch(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9) { if(_event!=null) _event.Invoke(param0, param1, param2, param3, param4, param5, param6, param7, param8, param9); }

        //  COMMAND CLASS
        public abstract class Command : ICommand
        {
            //  MEMBERS
            public ListenerDelegate Execute { get; private set; }

            //  CONSTRUCTOR
            protected Command() { Execute = ExecuteMethod; }

            //  METHODS
            abstract protected void ExecuteMethod(T0 param0, T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9);
        }
    }
    
}
