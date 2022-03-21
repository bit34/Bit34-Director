using System;
using System.Collections.Generic;

namespace Com.Bit34Games.Director.Signaling
{
    public class SignalListener
    {
        //  MEMBERS
        //      Internal
        private List<SignalListenerItem> _items;

        //  CONSTRUCTORS
        public SignalListener()
        {
            _items = new List<SignalListenerItem>();
        }

        //  METHODS
        public void AddListener(Signal signal,
                                Signal.ListenerDelegate listener,
                                bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }

        public void AddListener<T0>(Signal<T0> signal,
                                    Signal<T0>.ListenerDelegate listener,
                                    bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }

        public void AddListener<T0, T1>(Signal<T0, T1> signal,
                                        Signal<T0, T1>.ListenerDelegate listener,
                                        bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }

        public void AddListener<T0, T1, T2>(Signal<T0, T1, T2> signal,
                                            Signal<T0, T1, T2>.ListenerDelegate listener,
                                            bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }

        public void AddListener<T0, T1, T2, T3>(Signal<T0, T1, T2, T3> signal,
                                                Signal<T0, T1, T2, T3>.ListenerDelegate listener,
                                                bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }

        public void AddListener<T0, T1, T2, T3, T4>(Signal<T0, T1, T2, T3, T4> signal,
                                                    Signal<T0, T1, T2, T3, T4>.ListenerDelegate listener,
                                                    bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }
        
        public void AddListener<T0, T1, T2, T3, T4, T5>(Signal<T0, T1, T2, T3, T4, T5> signal,
                                                        Signal<T0, T1, T2, T3, T4, T5>.ListenerDelegate listener,
                                                        bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }
        
        public void AddListener<T0, T1, T2, T3, T4, T5, T6>(Signal<T0, T1, T2, T3, T4, T5, T6> signal,
                                                            Signal<T0, T1, T2, T3, T4, T5, T6>.ListenerDelegate listener,
                                                            bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }

        public void AddListener<T0, T1, T2, T3, T4, T5, T6, T7>(Signal<T0, T1, T2, T3, T4, T5, T6, T7> signal,
                                                                Signal<T0, T1, T2, T3, T4, T5, T6, T7>.ListenerDelegate listener,
                                                                bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }

        public void AddListener<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Signal<T0, T1, T2, T3, T4, T5, T6, T7, T8> signal,
                                                                    Signal<T0, T1, T2, T3, T4, T5, T6, T7, T8>.ListenerDelegate listener,
                                                                    bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }
        
        public void AddListener<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Signal<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> signal,
                                                                        Signal<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.ListenerDelegate listener,
                                                                        bool startListening = true)
        {
            Action addListener    = ()=>{ signal.AddListener(listener);    };
            Action removeListener = ()=>{ signal.RemoveListener(listener); };
            _items.Add(new SignalListenerItem(addListener, removeListener, startListening));

            if (startListening)
            {
                addListener();
            }
        }
        
        public void StartListening()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                SignalListenerItem item = _items[i];
                if (!item.isListening)
                {
                    item.isListening = true;
                    item.addListener();
                }
            }
        }

        public void StopListening()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                SignalListenerItem item = _items[i];
                if (item.isListening)
                {
                    item.isListening = false;
                    item.removeListener();
                }
            }
        }
    }
    
    class SignalListenerItem
    {
        //  MEMBERS
        public readonly Action addListener;
        public readonly Action removeListener;
        public bool            isListening;

        //  CONSTRUCTORS
        public SignalListenerItem(Action addListener, Action removeListener, bool isListening)
        {
            this.addListener    = addListener;
            this.removeListener = removeListener;
            this.isListening    = isListening;
        }
    }
}