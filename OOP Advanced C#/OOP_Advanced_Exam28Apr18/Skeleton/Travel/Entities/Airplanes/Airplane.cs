namespace Travel.Entities.Airplanes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.Immutable;
	using System.Linq;
	using Entities.Contracts;
    using Travel.Entities.Airplanes.Contracts;

    public abstract class Airplane : IAirplane
    {
		private readonly List<IBag> bags;
		private readonly List<IPassenger> passengers;

		protected Airplane(int seats, int baggageCompartments) // changed to protected
        {
			this.Seats = seats;
			this.BaggageCompartments = baggageCompartments;
            this.bags = new List<IBag>();
            this.passengers = new List<IPassenger>();
        }

		public int Seats { get; }

		public int BaggageCompartments { get; }

        public IReadOnlyCollection<IBag> BaggageCompartment => this.bags.AsReadOnly();

		public IReadOnlyCollection<IPassenger> Passengers => this.passengers.AsReadOnly();

		public bool IsOverbooked => this.Passengers.Count() > this.Seats;

        public void AddPassenger(IPassenger passenger)
        {
			this.passengers.Add(passenger);
		}

		public IPassenger RemovePassenger(int seatindex)
        {
            var passenger = this.passengers[seatindex];

            this.passengers.RemoveAt(seatindex);

			return passenger;
		}

		public IEnumerable<IBag> EjectPassengerBags(IPassenger passenger)  //returns a list of all the removed baggage
        {
			var passengerBags = this.bags
				.Where(b => b.Owner == passenger)
				.ToList();   // was .ToArray();

			foreach (var bag in passengerBags)
				this.bags.Remove(bag);

			return passengerBags;
		}

		public void LoadBag(IBag bag)
        {
			var isBaggageCompartmentFull = this.BaggageCompartment.Count > this.BaggageCompartments;
            if (isBaggageCompartmentFull)
            {
                throw new InvalidOperationException($"No more bag room in {this.GetType().ToString()}!");
            }
			this.bags.Add(bag);
		}
	}
}