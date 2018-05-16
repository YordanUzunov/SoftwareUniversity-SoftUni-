namespace Travel.Entities.Factories
{
	using Contracts;
	using Items.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class ItemFactory : IItemFactory
	{
		public IItem CreateItem(string type)
		{
            var itemType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IItem).IsAssignableFrom(t))
                .FirstOrDefault(t => t.Name == type);

            var item = (IItem)Activator.CreateInstance(itemType);

            return item;


            //switch (type)
            //{
            //	case "Item":
            //		return new Item();
            //	case "CellPhone":
            //		return new Colombian();
            //	case "Colombian":
            //		return new Colombian();
            //	case "Jewelery":
            //		return new Jewelery();
            //	case "Laptop":
            //		return new Laptop();
            //	case "toothbrush":
            //		return new Toothbrush();
            //	case "TravelKit":
            //		return new TravelKit();
            //	default:
            //		return new Soap();
            //}
        }
	}
}
