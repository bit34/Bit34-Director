using System;
using System.Diagnostics;

namespace Com.Bit34Games.Director.Error
{
    public class DirectorException : Exception
    {
        //  MEMBERS
        public readonly DirectorErrorType errorType;

        //  CONSTRUCTOR
        public DirectorException(DirectorErrorType errorType, string message) :
            base(message)
        {
            this.errorType = errorType;
        }

        //  METHODS
        public static DirectorException CreateViewCanNotFindContext(Type viewType, int callerLevel=0)
        {
            string            callerInfo   = GetCallerInfo(1+callerLevel);
            DirectorErrorType errorType    = DirectorErrorType.ViewCanNotFindContext;
            string            errorMessage = String.Format("MediationError : [{1}] is not placed under a context view\n{0}", callerInfo, viewType);
            return new DirectorException(errorType, errorMessage);
        }

        public static DirectorException CreateNoMediationBindingFoundForViewType(Type viewType, int callerLevel=0)
        {
            string            callerInfo   = GetCallerInfo(1+callerLevel);
            DirectorErrorType errorType    = DirectorErrorType.NoMediationBindingFoundForViewType;
            string            errorMessage = String.Format("MediationError : Can not find mediation binding for view [{1}]\n{0}", callerInfo, viewType);
            return new DirectorException(errorType, errorMessage);
        }

        public static DirectorException CreateCommandIsNotAssignableToSignal(Type signalType, Type commandType, int callerLevel=0)
        {
            string            callerInfo   = GetCallerInfo(1+callerLevel);
            DirectorErrorType errorType    = DirectorErrorType.CommandIsNotAssignableToSignal;
            string            errorMessage = String.Format("SignalError : Can not bind command [{1}] to signal [{2}]\n{0}", callerInfo, commandType, signalType);
            return new DirectorException(errorType, errorMessage);
        }
        
        private static string GetCallerInfo(int callerLevel=0)
        {
            StackTrace st   = new StackTrace(true);
            StackFrame sf   = st.GetFrame(1+callerLevel);
            string     info = String.Format("\tFilename:{0}\n\tMethod:{1}\n\tLine:{2}", sf.GetFileName(), sf.GetMethod(), sf.GetFileLineNumber() );

            return info;
        }
    }
}
