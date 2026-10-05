#if UNITY_2018_1_OR_NEWER

using Com.Bit34Games.Director.Error;
using Com.Bit34Games.Director.Mediation;
using System.Collections.Generic;
using UnityEngine;


namespace Com.Bit34Games.Director.Unity
{
	public class DirectorUnityView : MonoBehaviour, 
									 IView
	{
		//	MEMBERS
		private IDirectorContext _context;
		private List<IMediator>  _mediators;

        //	METHODS
#region Unity callbacks

        private void Awake()
		{
			_context   = gameObject.GetComponentInParent<IDirectorContext>();
			_mediators = new List<IMediator>();

			if (_context != null)
			{
				_context.RegisterView(this);
			}
			else
			{
				DirectorException.CreateViewCanNotFindContext(GetType());
			}
			PostAwake();
		}

		private void OnDestroy()
		{
			PreDestroy();
            if(_context!=null)
            {
                _context.RemoveView(this);
            }
		}

#endregion

#region IView implementation

        public void AddMediator(IMediator mediator)
        {
			_mediators.Add(mediator);
        }

        public void ClearMediators()
        {
			_mediators.Clear();
        }

        public IEnumerator<IMediator> GetMediators()
        {
            return _mediators.GetEnumerator();
        }
	
#endregion

		protected virtual void PostAwake(){}
		protected virtual void PreDestroy(){}
	}
}

#endif