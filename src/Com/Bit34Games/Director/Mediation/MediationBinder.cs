using System;
using System.Collections.Generic;
using Com.Bit34Games.Injector;
using Com.Bit34Games.Director.Error;

namespace Com.Bit34Games.Director.Mediation
{
	public class MediationBinder
	{
        //	MEMBERS
        private IInjector 						   _injector;
        private Dictionary<Type, MediationBinding> _bindings;

		//	CONSTRUCTOR
		public MediationBinder(IInjector injector)
		{
			_injector = injector;
			_bindings = new Dictionary<Type, MediationBinding>();
		}

		//	METHODS
		public MediationBinding BindView<T>()
		{
			MediationBinding binding = null;
			if (_bindings.TryGetValue(typeof(T), out binding) == false)
			{
				binding = new MediationBinding(typeof(T));
				_bindings.Add(typeof(T), binding);
			}
            else
            {
                while (binding.next != null)
                {
                    binding = binding.next;
                }
            }

			return binding;
		}

		public void CreateMediators(IView view)
		{
			MediationBinding binding = null;
			if (_bindings.TryGetValue(view.GetType(), out binding) == false || binding.MediatorType == null)
			{
                throw DirectorException.CreateNoMediationBindingFoundForViewType(view.GetType());
			}

            while(binding != null)
            {
                IMediator              mediator              = (IMediator)binding.MediatorType.GetConstructor(new Type[]{} ).Invoke(null);
                ViewInjectionOverrider viewInjectionOverride = new ViewInjectionOverrider(binding.GetViewBindingType(), view);
				view.AddMediator(mediator);
                _injector.InjectInto(mediator, viewInjectionOverride);
                mediator.OnRegister();

                binding = binding.next;
            }
		}

		public void DestroyMediators(IView view)
		{
			IEnumerator<IMediator> mediators = view.GetMediators();
			while(mediators.MoveNext())
			{
				mediators.Current.OnRemove();
			}
			view.ClearMediators();
		}

	}
}