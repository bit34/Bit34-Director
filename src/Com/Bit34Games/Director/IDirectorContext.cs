using Com.Bit34Games.Director.Mediation;

namespace Com.Bit34Games.Director
{
    public interface IDirectorContext
    {
		//	MEMBERS
        bool HasStarted { get;}

        //  METHODS
        void StartContext();
        void RegisterView(IView view);
        void RemoveView(IView view);

    }
}
