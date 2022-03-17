using System;
using System.Reflection;
using Com.Bit34Games.Injector;

namespace Com.Bit34Games.Director.Mediation
{
	public class ViewInjectionOverrider : IMemberInjector
	{
		//	MEMBERS
		private Type  _viewType;
		private IView _viewInstance;

		//	CONSTRUCTOR
		public ViewInjectionOverrider( Type viewType, IView viewInstance )
		{
			_viewType     = viewType;
			_viewInstance = viewInstance;
		}

		//	METHODS
        public bool InjectIntoField(FieldInfo fieldInfo, object container)
		{
			if (fieldInfo.FieldType==_viewType)
			{
				fieldInfo.SetValue(container, _viewInstance);
				return true;
			}
			return false;
		}

        public bool InjectIntoProperty(PropertyInfo propertyInfo, object container)
        {
            if (propertyInfo.PropertyType == _viewType)
            {
                propertyInfo.SetValue(container, _viewInstance, null);
                return true;
            }
            return false;
        }
    }
}