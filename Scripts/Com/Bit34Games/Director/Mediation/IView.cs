using System.Collections.Generic;

namespace Com.Bit34Games.Director.Mediation
{
	public interface IView
	{
        //	METHODS
		void AddMediator(IMediator mediator);
		IEnumerator<IMediator> GetMediators();
		void ClearMediators();
	}
}