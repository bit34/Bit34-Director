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
			}
		}

		public void RegisterView(IView view)
		{
			MediationBinder.CreateMediators(view);
		}

		public void RemoveView(IView view)
		{
			MediationBinder.DestroyMediators(view);
		}

        protected virtual void InitializeBindings()
        { }

        protected virtual void Launch()
        { }

    }
}