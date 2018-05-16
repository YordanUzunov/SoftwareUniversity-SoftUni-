namespace Travel.Entities.Factories
{
	using Contracts;
	using Airplanes.Contracts;
    using System.Reflection;
    using System.Linq;
    using System;

    public class AirplaneFactory : IAirplaneFactory
	{
		public IAirplane CreateAirplane(string type)
		{
            var airplaneType = Assembly.GetCallingAssembly().GetTypes()
                .Where(t => typeof(IAirplane).IsAssignableFrom(t))
                .FirstOrDefault(t => t.Name == type);

            var airplane = (IAirplane)Activator.CreateInstance(airplaneType);

            return airplane;


            //switch (type)
            //{
            //	case "LightAirplane":
            //		return new LightAirplane();
            //	case "MediumAirplane":
            //		return new MediumAirplane();
            //	default:
            //		return new Airplane();
            //}
        }
	}
}