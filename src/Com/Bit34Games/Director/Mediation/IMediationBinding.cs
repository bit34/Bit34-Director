namespace Com.Bit34Games.Director.Mediation
{
    public interface IMediationBinding
    {
        //	METHODS
        IMediationOptions ToMediator<T>() where T : new();
    }
}
