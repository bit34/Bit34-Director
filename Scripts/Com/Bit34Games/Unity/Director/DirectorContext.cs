using System.Collections.Generic;
using UnityEngine;
using Com.Bit34Games.Injector;
using Com.Bit34Games.Director.Mediation;
using Com.Bit34Games.Director.Signaling;
using Com.Bit34Games.Director;

namespace Com.Bit34Games.Unity.Director
{
    public class DirectorContext : MonoBehaviour, IDirectorContext
    {
		//	MEMBERS
        public    bool 		          HasStarted          { get; private set; }
		protected InjectorContext     Injector            { get; private set; }
		protected MediationBinder     MediationBinder     { get; private set; }
		protected SignalCommandBinder SignalCommandBinder { get; private set; }
		//		Internal
		private LinkedList<IView> _viewsToRegister;

        //  METHODS
        public void InitializeContext(bool throwInjectionErrors = true)
        {
			HasStarted          = false;
			Injector            = new InjectorContext(throwInjectionErrors);
            MediationBinder     = new MediationBinder(Injector);
			SignalCommandBinder = new SignalCommandBinder(Injector);

            InitializeBindings();
        }

		public void StartContext()
		{
			if(HasStarted==false)
			{
				HasStarted = true;
				SignalCommandBinder.InstantiateCommands();
				Launch();

				if (_viewsToRegister != null)
				{
					LinkedListNode<IView> viewNode = _viewsToRegister.First;
					while (viewNode != null)
					{
						MediationBinder.CreateMediators(viewNode.Value);
						viewNode = viewNode.Next;
					}
					_viewsToRegister = null;
				}
			}
		}

		public void RegisterView(IView view)
		{
			if (MediationBinder != null)
			{
				MediationBinder.CreateMediators(view);
			}
			else
			{
				if (_viewsToRegister == null)
				{
					_viewsToRegister = new LinkedList<IView>();
				}
				_viewsToRegister.AddLast(view);
			}
		}

		public void RemoveView(IView view)
		{
			if (MediationBinder != null)
			{
				MediationBinder.DestroyMediators(view);
			}
			else
			{
				_viewsToRegister.Remove(view);
			}
		}

        protected virtual void InitializeBindings()
        { }

        protected virtual void Launch()
        { }

    }
}