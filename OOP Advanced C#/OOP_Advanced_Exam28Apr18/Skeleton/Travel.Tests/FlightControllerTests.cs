// REMOVE any "using" statements, which start with "Travel." BEFORE SUBMITTING

namespace Travel.Tests
{
	using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;
    using Travel.Core.Controllers;
    using Travel.Entities;
    using Travel.Entities.Airplanes;
    using Travel.Entities.Items;
    using Travel.Entities.Items.Contracts;

    [TestFixture]
    public class FlightControllerTests
    {
        private Airport airport;
        private FlightController flightController;

        [SetUp]
        public void SetUpProviderController()
        {
            this.airport = new Airport();
            this.flightController = new FlightController(airport);
        }

        [Test]
	    public void Test1()
	    {
            var airplane = new LightAirplane();
            var trip = new Trip("Sofia", "London", airplane);
            this.airport.AddTrip(trip);

            this.airport.AddPassenger(new Passenger("Pesho1"));
            this.airport.AddPassenger(new Passenger("Pesho2"));
            this.airport.AddPassenger(new Passenger("Pesho3"));
            this.airport.AddPassenger(new Passenger("Pesho4"));
            this.airport.AddPassenger(new Passenger("Pesho5"));
            this.airport.AddPassenger(new Passenger("Pesho6"));

            var p1 = this.airport.GetPassenger("Pesho1");
            var p2 = this.airport.GetPassenger("Pesho2");
            var p3 = this.airport.GetPassenger("Pesho3");
            var p4 = this.airport.GetPassenger("Pesho4");
            var p5 = this.airport.GetPassenger("Pesho5");
            var p6 = this.airport.GetPassenger("Pesho6");

            trip.Airplane.AddPassenger(p1);
            trip.Airplane.AddPassenger(p2);
            trip.Airplane.AddPassenger(p3);
            trip.Airplane.AddPassenger(p4);
            trip.Airplane.AddPassenger(p5);
            trip.Airplane.AddPassenger(p6);

            var result = flightController.TakeOff();
            Assert.IsTrue(result.StartsWith("SofiaLondon1:\r\nOverbooked! Ejected"));

        }

        [Test]
        public void Test2()
        {
            var airplane = new LightAirplane();
            var trip = new Trip("Sofia", "London", airplane);
            this.airport.AddTrip(trip);

            this.airport.AddPassenger(new Passenger("Pesho1"));
            this.airport.AddPassenger(new Passenger("Pesho2"));
            this.airport.AddPassenger(new Passenger("Pesho3"));
            this.airport.AddPassenger(new Passenger("Pesho4"));
            this.airport.AddPassenger(new Passenger("Pesho5"));
            this.airport.AddPassenger(new Passenger("Pesho6"));

            var p1 = this.airport.GetPassenger("Pesho1");
            var p2 = this.airport.GetPassenger("Pesho2");
            var p3 = this.airport.GetPassenger("Pesho3");
            var p4 = this.airport.GetPassenger("Pesho4");
            var p5 = this.airport.GetPassenger("Pesho5");
            var p6 = this.airport.GetPassenger("Pesho6");

            trip.Airplane.AddPassenger(p1);
            trip.Airplane.AddPassenger(p2);
            trip.Airplane.AddPassenger(p3);
            trip.Airplane.AddPassenger(p4);
            trip.Airplane.AddPassenger(p5);
            trip.Airplane.AddPassenger(p6);

            this.flightController.TakeOff();
            Assert.That(trip.Airplane.Passengers.Count(), Is.EqualTo(5));

        }

        [Test]
        public void Test3()
        {
            var airplane = new LightAirplane();
            var trip1 = new Trip("Burgas", "Sofia", airplane);
            var trip2 = new Trip("Burgas", "Vidin", airplane);
            var trip3 = new Trip("Burgas", "Varna", airplane);
            this.airport.AddTrip(trip1);
            this.airport.AddTrip(trip2);
            this.airport.AddTrip(trip3);


            this.flightController.TakeOff();
            Assert.That(this.airport.Trips.Count(t => t.IsCompleted), Is.EqualTo(3));
        }


        [Test]
        public void Test4()
        {
            var airplane = new LightAirplane();
            var trip = new Trip("Sofia", "London", airplane);
            this.airport.AddTrip(trip);

            this.airport.AddPassenger(new Passenger("Pesho1"));
            this.airport.AddPassenger(new Passenger("Pesho2"));

            var p1 = this.airport.GetPassenger("Pesho1");
            var p2 = this.airport.GetPassenger("Pesho2");

            var bag1 = new Bag(p1, new List<IItem>() { });
            var bag2 = new Bag(p2, new List<IItem>());

            p1.Bags.Add(bag1);
            p2.Bags.Add(bag2);

            trip.Airplane.AddPassenger(p1);
            trip.Airplane.AddPassenger(p2);

            this.flightController.TakeOff();

            Assert.That(trip.Airplane.BaggageCompartment.Count(), Is.EqualTo(2));
        }

        //[Test]
        //public void Test5()
        //{
        //    var airplane = new LightAirplane();
        //    var trip = new Trip("Sofia", "London", airplane);
        //    this.airport.AddTrip(trip);

        //    this.airport.AddPassenger(new Passenger("Pesho1"));
        //    this.airport.AddPassenger(new Passenger("Pesho2"));
        //    this.airport.AddPassenger(new Passenger("Pesho3"));
        //    this.airport.AddPassenger(new Passenger("Pesho4"));
        //    this.airport.AddPassenger(new Passenger("Pesho5"));
        //    this.airport.AddPassenger(new Passenger("Pesho6"));
        //    this.airport.AddPassenger(new Passenger("Pesho7"));

        //    var p1 = this.airport.GetPassenger("Pesho1");
        //    var p2 = this.airport.GetPassenger("Pesho2");
        //    var p3 = this.airport.GetPassenger("Pesho3");
        //    var p4 = this.airport.GetPassenger("Pesho4");
        //    var p5 = this.airport.GetPassenger("Pesho5");
        //    var p6 = this.airport.GetPassenger("Pesho6");
        //    var p7 = this.airport.GetPassenger("Pesho7");
            
        //    var item1 = new Colombian();
        //    var item2 = new Colombian();
        //    var item3 = new Colombian();
        //    var item4 = new Colombian();
        //    var item5 = new Colombian();
        //    var item6 = new Colombian();
        //    var item7 = new Colombian();

        //    var list1 = new List<IItem> { item1 };
        //    var list2 = new List<IItem> { item2 };
        //    var list3 = new List<IItem> { item3 };
        //    var list4 = new List<IItem> { item4 };
        //    var list5 = new List<IItem> { item5 };
        //    var list6 = new List<IItem> { item6 };
        //    var list7 = new List<IItem> { item7 };

        //    var bag1 = new Bag(p1, list1);
        //    var bag2 = new Bag(p2, list2);
        //    var bag3 = new Bag(p3, list3);
        //    var bag4 = new Bag(p4, list4);
        //    var bag5 = new Bag(p5, list5);
        //    var bag6 = new Bag(p6, list6);
        //    var bag7 = new Bag(p7, list7);

        //    p1.Bags.Add(bag1);
        //    p2.Bags.Add(bag2);
        //    p3.Bags.Add(bag3);
        //    p4.Bags.Add(bag4);
        //    p5.Bags.Add(bag5);
        //    p6.Bags.Add(bag6);
        //    p7.Bags.Add(bag7);

        //    trip.Airplane.AddPassenger(p1);
        //    trip.Airplane.AddPassenger(p2);
        //    trip.Airplane.AddPassenger(p3);
        //    trip.Airplane.AddPassenger(p4);
        //    trip.Airplane.AddPassenger(p5);
        //    trip.Airplane.AddPassenger(p6);
        //    trip.Airplane.AddPassenger(p7);

        //    this.flightController.TakeOff();

        //    Assert.That(this.airport.ConfiscatedBags.Count(), Is.EqualTo(2));
        //}
    }
}
