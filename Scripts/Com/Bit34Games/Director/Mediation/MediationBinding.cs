using System;

namespace Com.Bit34Games.Director.Mediation
{
	public class MediationBinding : IMediationBinding, IMediationOptions
    {
		//	MEMBERS
		public readonly Type    viewType;
        public Type             viewCastType;
        public Type             MediatorType { get; private set; }
        public MediationBinding next;

		//	CONSTRUCTOR
		public MediationBinding(Type viewType)
		{
			this.viewType = viewType;
            viewCastType  = null;
            MediatorType  = null;
        }

		//	METHODS
		public IMediationOptions ToMediator<T>()
             where T : new()
		{
            if(MediatorType==null)
            {
                MediatorType = typeof(T);
                return this;
            }

            next = new MediationBinding(viewType);
            return next.ToMediator<T>();
        }

        public IMediationBinding As<T>()
        {
            viewCastType = typeof(T);
            return this;
        }

        public Type GetViewBindingType()
        {
            return (viewCastType != null) ? (viewCastType) : (viewType);
        }
    }
}
