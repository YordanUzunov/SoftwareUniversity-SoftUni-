<h1>C# OOP Advanced Retake Exam &ndash; Travel</h1>
<p>After the biggest music festival in Bulgaria ended, Bay Kiro and his chalga associates found themselves out of a job, so Kiro founded the <em>United Runways &ndash;</em> <em>an <strong>airline</strong> with a twist</em><em>&trade;</em>.</p>
<p>The twist is that <strong>every flight is free</strong>! What&rsquo;s the business model then, you ask? Well, <strong>baggage</strong> <strong>confiscation</strong>. The thing is, the terms of service state that <strong>any baggage with a combined value of over $3000 </strong>gets confiscated by the airline &ndash; but nobody reads those, right?! Exactly! It&rsquo;s practically free money!</p>
<p>Well, that&rsquo;s only <strong>half</strong> of the business model&hellip; the other half is a classic <strong>overbooking </strong>scheme. A flight allows an unlimited number of people to board it, but when the time for <strong>taking off</strong> comes, <strong>random passengers </strong>get <strong>deplaned</strong> (and their baggage confiscated, of course).</p>
<h1>Overview</h1>
<p>Your task is to build a software project, which manages an<strong> airline</strong>. This airline will have <strong>trips</strong>, which have <strong>source </strong>and <strong>destination cities</strong>, and their own <strong>airplane</strong>. Each passenger has <strong>checked </strong>bags and <strong>carry-on </strong>bags, which they explicitly declare at check-in.</p>
<h1>Task I: Structure</h1>
<p>Unfortunately, the previous maintainer of the airline code was doing a terrible job. All he managed to do correctly was <strong>create all the interfaces </strong>and the FlightController. <strong>Do not modify the interfaces or their namespaces!</strong></p>
<p>The main structure of the program should include the following elements:</p>
<ul>
<li><strong>Engine</strong> &ndash; <strong>Processes input commands</strong> and <strong>sends them</strong> to the relevant <strong>controllers</strong> to handle</li>
<li><strong>AirportController</strong> &ndash; <strong>Handles</strong> all the <strong>commands</strong> listed in the <strong>I/O</strong> section</li>
<li><strong>FlightController</strong> &ndash; Responsible for <strong>performing the trip</strong> (loading luggage into the airplane, deboarding passengers in case the flight is overbooked, etc.)</li>
<li><strong>Airport</strong> &ndash; <strong>Repository</strong>, which <strong>holds</strong> all the <strong>trips</strong>, <strong>passengers</strong>, <strong>confiscated luggage</strong> and <strong>checked</strong> <strong>luggage</strong>, and provides <strong>methods </strong>for <strong>retrieving</strong> and <strong>storing</strong></li>
</ul>
<h2>Guidelines</h2>
<ul>
<li>Make sure your Visual Studio is up-to-date. If it isn&rsquo;t, you risk a bug where <strong>the .NET Core skeleton doesn&rsquo;t build</strong> (and has red squiggles everywhere).</li>
<li>Upload <strong>only the </strong>Travel project in every problem <strong>except</strong> <strong> Unit Tests</strong>. For <strong>03. Unit Tests</strong>, upload <strong>only the </strong>Travel.Tests<strong> project </strong>with <strong>all using statements pointing to </strong>FestivalManager <strong>removed (leave any System using statements alone)</strong>.</li>
<li><strong>Do not modify any of the interfaces or their namespaces!</strong></li>
<li>You will have to refactor everything else as you see fit. Use <strong>strong cohesion </strong>and <strong>loose coupling</strong>.</li>
<li><strong>Use inheritance and the provided interfaces wherever possible</strong>. This includes <strong>constructors</strong>, <strong>method parameters </strong>and<strong> return types</strong>!</li>
<li><strong>Do not</strong> violate your <strong>interface</strong> <strong>implementations</strong> by adding <strong>more public methods</strong> or <strong>properties</strong> in the concrete class than the interface has defined!</li>
<li><strong>Do not modify any constructors</strong>.</li>
<li>Make sure you have <strong>no public fields</strong></li>
</ul>
<p>Below, you will find a detailed description of all entities and their methods.</p>
<h2>Airplanes</h2>
<p>An abstract<strong> airplane</strong> has the following characteristics:</p>
<ul>
<li>int &egrave; Seats</li>
<li>int &egrave; BaggageCompartments</li>
<li>IReadOnlyCollection &egrave; BaggageCompartment&ndash; the<strong> carry-on bags </strong>in the plane</li>
<li>IReadOnlyCollection &egrave; Passengers</li>
<li>bool &egrave; IsOverbooked &ndash; true if the passengers count is <strong>greater than </strong>the Seats (calculated property).</li>
</ul>
<p>Airplanes have several <strong>methods</strong>, most of which are self-explanatory.</p>
<ul>
<li>AddPassenger &ndash; <strong>adds</strong> the provided passenger into the plane.</li>
<li>RemovePassenger &ndash; <strong>removes</strong> the passenger at <strong>the provided seat index</strong>.</li>
<li>EjectPassengerBags &ndash; Finds all the baggage, with the provided owner, <strong>removes it from the plane </strong>and <strong>returns a list </strong>of all the <strong>removed baggage</strong>.</li>
<li>LoadBag &ndash; Adds the provided bag into the BaggageCompartment. If the number of bags inside the plane is <strong>larger than </strong>the number of <strong>baggage compartments</strong>, throw an InvalidOperationException with the message "No more bag room in {planeName}!"</li>
</ul>
<p>Create <strong>two</strong> <strong>classes</strong> for each of the three <strong>types</strong> of airplanes we have:</p>
<ul>
<li>LightAirplane&ndash; <strong>5 </strong>seats,<strong> 8 </strong>baggage compartments</li>
<li>MediumAirplane&ndash; <strong>10 </strong>seats, <strong>14</strong> baggage compartments</li>
</ul>
<h2>Items</h2>
<p>An abstract <strong>item</strong> has the following characteristics:</p>
<ul>
<li>int &egrave; Value &ndash; the <strong>monetary</strong> <strong>value</strong> of the item in <strong>USD</strong></li>
</ul>
<p>Create <strong>six</strong> <strong>classes</strong> for each of the three <strong>types</strong> of items we have:</p>
<ul>
<li>Toothbrush&ndash; <strong>$3 value</strong></li>
<li>TravelKit&ndash; <strong>$30 value</strong></li>
<li>Jewelery&ndash; <strong>$300 value</strong></li>
<li>CellPhone&ndash; <strong>$700 value</strong></li>
<li>Laptop&ndash; <strong>$3000 value</strong></li>
<li>Colombian&ndash; <strong>$50000 value</strong></li>
</ul>
<h2>Bag</h2>
<p>A bag is a container of <strong>items</strong>. It has the following characteristics:</p>
<ul>
<li>IPassenger &egrave; Owner</li>
<li>IReadOnlyCollection&lt;IItem&gt; &egrave; Items</li>
</ul>
<p>The bag receives its owner and items from the constructor, so they cannot be altered.</p>
<h2>Passenger</h2>
<p>A passenger has the following characteristics:</p>
<ul>
<li>string &egrave; Username</li>
<li>IList&lt;IBag&gt; &egrave; Bags</li>
</ul>
<h2>Trip</h2>
<p>A trip has the following characteristics:</p>
<ul>
<li>string &egrave; Id &ndash; The <strong>combination</strong> of the <strong>source</strong> and <strong>destination</strong> cities, plus an ever-increasing <strong>integer </strong>(starting at <strong>1</strong>)</li>
<li>string &egrave; Source</li>
<li>string &egrave; Destination</li>
<li>bool &egrave; IsCompleted</li>
<li>IAirplane &egrave; Airplane</li>
</ul>
<p>Trips only have <strong>one method</strong>: Complete(). I&rsquo;ll let you figure out what that does by yourself&hellip;</p>
<h2>Airport</h2>
<p>The <strong>airport </strong>class is a <strong>repository</strong> where all the current <strong>passengers</strong>, <strong>trips</strong>, <strong>checked baggage</strong> and <strong>confiscated</strong> <strong>baggage</strong> are <strong>stored</strong>. It has:</p>
<ul>
<li>Methods for <strong>Adding passengers</strong>, <strong>trips </strong>and <strong>checked/confiscated bags</strong></li>
<li>Methods for retrieving <strong>passengers </strong>by <strong>name</strong> and trips by <strong>id</strong></li>
</ul>
<p><strong>Note</strong>: The Airport is <strong>shared</strong> between the <strong>airport controller</strong> and the <strong>flight controller</strong>.</p>
<h1>Task II: Business Logic</h1>
<p>Your code should only catch exceptions on the <strong>engine level</strong>.</p>
<h2>Commands</h2>
<p>The software needs to be able to process several commands in the form of <strong>methods</strong>:</p>
<h3>RegisterPassenger {username}</h3>
<p>If the airport already has a passenger with that username, throw an InvalidOperationException with the message "Passenger {username} already registered!".</p>
<p>The command adds a new passenger into the <strong>airport </strong>and returns "Registered {passenger.Username}"</p>
<h3>RegisterTrip {source} {destination} {planeType}</h3>
<p>Creates a trip with that <strong>source </strong>and <strong>destination</strong> and <strong>adds it </strong>to the <strong>airport</strong>. The Id is auto-generated from the <strong>Trip </strong>class itself.</p>
<p>The command returns "Registered trip {tripId}".</p>
<h3>RegisterBag {username} {bagItem1} {bagItem2} {bagItemN}</h3>
<p>Gets a passenger with the provided <strong>username </strong>from the airport. Then, creates a <strong>bag</strong> with all the provided <strong>items</strong> and adds it to the <strong>passenger&rsquo;s bags</strong>.</p>
<p>The command returns "Registered bag with item1, item2, itemN for {username}"</p>
<h3>CheckIn {username} {tripId} {bagIndex1}, {bagIndex2}, {bagIndexN}</h3>
<p>Gets a <strong>passenger </strong>with the provided <strong>username </strong>and a <strong>trip </strong>with the provided <strong>id</strong>.</p>
<p>If the passenger has <strong>already checked in </strong>(is already in any trips&rsquo; airplanes), throw an InvalidOperationException with the message "{username} is already checked in!".</p>
<p>Then, the command <strong>checks in all the passenger bags</strong> with that <strong>index</strong>.</p>
<p>Checking in works like this:</p>
<p>The bag with that index gets removed from the passenger&rsquo;s bags. Then, depending on whether the bag should be <strong>confiscated</strong>, one of the following things happens:</p>
<p>If it should be <strong>confiscated</strong> (if the <strong>total value</strong> of the bag is <strong>over $3000</strong>), the bag is <strong>added to the airport&rsquo;s confiscated bags</strong>. If not, the bag gets added to the airport&rsquo;s <strong>checked bags</strong>. Any other bags, whose indices are not listed in the command input are <strong>left with the passenger </strong>(and eventually board the plane along with the passenger).</p>
<p>After checking in any bags, the <strong>passenger </strong>is <strong>added</strong> to the <strong>trip</strong>.</p>
<p>The command returns "Checked in {username} with {bagsToCheckInCount-confiscatedBagsCount}/{bagsToCheckInCount} checked in bags".</p>
<h3>TakeOff</h3>
<p>For every trip, the following is performed:</p>
<p>"{trip.Id}:" is appended to the output.</p>
<p>If the trip is <strong>already completed</strong> (the command could be called several times), the trip is <strong>skipped </strong>entirely and nothing is done. If the trip has <strong>not been completed yet</strong>, all the <strong>carry-on baggage</strong> is <strong>loaded </strong>onto the <strong>plane</strong>.</p>
<p>Then, if the plane is <strong>overbooked</strong>, <strong>passengers at random seats (indices) start getting ejected until the plane isn&rsquo;t overbooked anymore</strong>. Also, all ejected passengers&rsquo; <strong>carry-on baggage </strong>is automatically <strong>confiscated</strong>. The <strong>random generator seed</strong> is <strong>always the number 1337</strong>. After the bags are confiscated, their <strong>total value </strong>is calculated, and "Confiscated {confiscatedBagsCount} bags (${bagsTotalValue})" is appended to the output of the command.</p>
<p>Then, the trip is completed and "Successfully transported {airplanePassengersCount} passengers from {source} to {destination}." is appended to the output of the command.</p>
<p>After all trips are completed, "Confiscated bags: {totalConfiscatedBagsCount} ({totalConfiscatedItemsCount} items) =&gt; ${totalConfiscatedItemsValue}" is appended to the output of the command.</p>
<h1>Tasks III:</h1>
<h2>Reflection</h2>
<p>You need to refactor the given factories and implement new ones. Factories must <strong>use reflection</strong>, so it will be easy for us to follow the <strong>Open/Closed Principle</strong>. You are required to implement <strong>two factories</strong>:</p>
<ul>
<li>AirplaneFactory</li>
<li>ItemFactory</li>
</ul>
<p>Feel free to make additional factories for the other entities, even though they will not be tested.</p>
<p>Your task is to implement these factories in such a way that it will be <strong>easy to extend the number of concrete types of each entity</strong>.</p>
<p><strong>NOTE:</strong> <strong>Make sure you reference the Calling Assembly, instead of the Executing Assembly, since the code that&rsquo;s going to be calling your factories in the tests depends on this!</strong></p>
<p><strong>No static </strong>factories are allowed<strong>!</strong></p>
<h2>Unit Testing</h2>
<p>Like you saw at the beginning, there is а class, which does not need refactoring - FlightController<strong>. </strong>This is the class, against which you need to <strong>write unit tests</strong>. In your skeleton, you are provided with a <strong>perfectly working</strong> FlightController, but it still needs to be <strong>tested</strong>, because in <strong>Judge</strong>, we have prepared some <strong>bugs</strong>, and you need to catch them in your unit tests.</p>
<p>You are provided with a <strong>unit test project</strong> in the <strong>project skeleton</strong>. <strong>DO NOT modify its NuGet packages</strong>.</p>
<p>Note: The FlightController you need to test is in the <strong>global namespace</strong>, as are any entities, which it depends on.</p>
<p><strong>Remove any using statements</strong> <strong>pointing towards the Travel namespace </strong>before submitting your code.</p>
<p>Do not use the AirportController<strong> or any factories </strong>in your tests, as it&rsquo;s not a part of the classes you are provided with. You are only provided the FlightController <strong>and its direct dependencies</strong>.</p>
<p>Do <strong>NOT</strong> use <strong>Mocking</strong> in your unit tests!</p>
<h2>Input</h2>
<ul>
<li>The input will come from the console in the form of commands, in the format specified above - each command on new line</li>
<li>The input sequence ends when you receive the command &ldquo;<strong>END</strong>&rdquo;</li>
<li><strong>Any</strong> type of command, except &ldquo;<strong>END</strong>&rdquo; can be given at any time.</li>
</ul>
<h2>Output</h2>
<p>The <strong>output</strong> of each command must be printed <strong>on a new line</strong>.</p>
<p>If an exception is thrown because of invalid state, they should be printed in the following format: &ldquo;ERROR: {exceptionMessage}&rdquo;.</p>
<p>After the &ldquo;END&rdquo; command is received, end the program.</p>
<h2>Constraints</h2>
<ul>
<li>All input lines will be <strong>valid</strong> commands with <strong>valid </strong></li>
<li>There will be <strong>at most</strong> <strong>50</strong> commands</li>
<li><strong>All</strong> rules <strong>specified above</strong> will be <strong>strictly</strong> <strong>followed</strong>, there will be <strong>NO</strong> unexpected input or conditions</li>
</ul>
<h2>Examples</h2>
<table width="0">
<tbody>
<tr>
<td width="310">
<p><strong>Input</strong></p>
</td>
<td width="398">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>RegisterTrip Sofia London LightAirplane</p>
<p>RegisterPassenger Pesho</p>
<p>RegisterPassenger Pesho</p>
<p>RegisterPassenger Ivan</p>
<p>RegisterBag Pesho Toothbrush Jewelery</p>
<p>RegisterBag Pesho CellPhone Laptop</p>
<p>CheckIn Pesho SofiaLondon1 0</p>
<p>TakeOff</p>
<p>END</p>
</td>
<td width="398">
<p>Registered trip SofiaLondon1</p>
<p>Registered Pesho</p>
<p>ERROR: Passenger Pesho already registered!</p>
<p>Registered Ivan</p>
<p>Registered bag with Toothbrush, Jewelery for Pesho</p>
<p>Registered bag with CellPhone, Laptop for Pesho</p>
<p>Checked in Pesho with 1/1 checked in bags</p>
<p>SofiaLondon1:</p>
<p>Successfully transported 1 passengers from Sofia to London.</p>
<p>Confiscated bags: 0 (0 items) =&gt; $0</p>
</td>
</tr>
<tr>
<td width="310">
<p>RegisterTrip Sofia London LightAirplane</p>
<p>RegisterPassenger Pesho</p>
<p>RegisterBag Pesho Laptop Laptop Laptop Laptop Laptop Laptop</p>
<p>CheckIn Pesho SofiaLondon1</p>
<p>CheckIn Pesho SofiaLondon1</p>
<p>TakeOff</p>
<p>END</p>
</td>
<td width="398">
<p>Registered trip SofiaLondon1</p>
<p>Registered Pesho</p>
<p>Registered bag with Laptop, Laptop, Laptop, Laptop, Laptop, Laptop for Pesho</p>
<p>Checked in Pesho with 0/0 checked in bags</p>
<p>ERROR: Pesho is already checked in!</p>
<p>SofiaLondon1:</p>
<p>Successfully transported 1 passengers from Sofia to London.</p>
<p>Confiscated bags: 0 (0 items) =&gt; $0</p>
</td>
</tr>
<tr>
<td width="310">
<p>RegisterTrip Sofia London LightAirplane</p>
<p>RegisterTrip London Sofia MediumAirplane</p>
<p>RegisterPassenger Pesho</p>
<p>RegisterPassenger Pesho</p>
<p>RegisterPassenger Gosho</p>
<p>RegisterPassenger Ivan</p>
<p>RegisterPassenger Penka</p>
<p>RegisterPassenger Boiko</p>
<p>RegisterPassenger Goshko</p>
<p>RegisterBag Pesho Toothbrush Jewelery CellPhone</p>
<p>RegisterBag Gosho Toothbrush Jewelery Laptop</p>
<p>RegisterBag Gosho Colombian</p>
<p>RegisterBag Ivan Toothbrush TravelKit CellPhone</p>
<p>RegisterBag Penka Toothbrush Jewelery CellPhone</p>
<p>CheckIn Pesho SofiaLondon1 0</p>
<p>CheckIn Pesho SofiaLondon1</p>
<p>CheckIn Gosho SofiaLondon1 1</p>
<p>CheckIn Ivan SofiaLondon1 0</p>
<p>CheckIn Penka SofiaLondon1 0</p>
<p>CheckIn Boiko SofiaLondon1</p>
<p>CheckIn Goshko SofiaLondon1</p>
<p>TakeOff</p>
<p>RegisterPassenger Pesho1</p>
<p>RegisterPassenger Gosho1</p>
<p>RegisterPassenger Ivan1</p>
<p>RegisterPassenger Penka1</p>
<p>RegisterPassenger Boiko1</p>
<p>RegisterPassenger Goshko1</p>
<p>RegisterBag Pesho1 Toothbrush Jewelery CellPhone</p>
<p>RegisterBag Gosho1 Toothbrush Jewelery Laptop</p>
<p>RegisterBag Gosho1 Colombian</p>
<p>RegisterBag Ivan1 Toothbrush TravelKit CellPhone</p>
<p>RegisterBag Penka1 Toothbrush Jewelery CellPhone</p>
<p>CheckIn Pesho1 LondonSofia2 0</p>
<p>CheckIn Gosho1 LondonSofia2 1</p>
<p>CheckIn Ivan1 LondonSofia2 0</p>
<p>CheckIn Penka1 LondonSofia2 0</p>
<p>CheckIn Boiko1 LondonSofia2</p>
<p>CheckIn Goshko1 LondonSofia2</p>
<p>TakeOff</p>
<p>END</p>
</td>
<td width="398">
<p>Registered trip SofiaLondon1</p>
<p>Registered trip LondonSofia2</p>
<p>Registered Pesho</p>
<p>ERROR: Passenger Pesho already registered!</p>
<p>Registered Gosho</p>
<p>Registered Ivan</p>
<p>Registered Penka</p>
<p>Registered Boiko</p>
<p>Registered Goshko</p>
<p>Registered bag with Toothbrush, Jewelery, CellPhone for Pesho</p>
<p>Registered bag with Toothbrush, Jewelery, Laptop for Gosho</p>
<p>Registered bag with Colombian for Gosho</p>
<p>Registered bag with Toothbrush, TravelKit, CellPhone for Ivan</p>
<p>Registered bag with Toothbrush, Jewelery, CellPhone for Penka</p>
<p>Checked in Pesho with 1/1 checked in bags</p>
<p>ERROR: Pesho is already checked in!</p>
<p>Checked in Gosho with 0/1 checked in bags</p>
<p>Checked in Ivan with 1/1 checked in bags</p>
<p>Checked in Penka with 1/1 checked in bags</p>
<p>Checked in Boiko with 0/0 checked in bags</p>
<p>Checked in Goshko with 0/0 checked in bags</p>
<p>SofiaLondon1:</p>
<p>Overbooked! Ejected Gosho</p>
<p>Confiscated 1 bags ($3303)</p>
<p>Successfully transported 5 passengers from Sofia to London.</p>
<p>LondonSofia2:</p>
<p>Successfully transported 0 passengers from London to Sofia.</p>
<p>Confiscated bags: 2 (4 items) =&gt; $53303</p>
<p>Registered Pesho1</p>
<p>Registered Gosho1</p>
<p>Registered Ivan1</p>
<p>Registered Penka1</p>
<p>Registered Boiko1</p>
<p>Registered Goshko1</p>
<p>Registered bag with Toothbrush, Jewelery, CellPhone for Pesho1</p>
<p>Registered bag with Toothbrush, Jewelery, Laptop for Gosho1</p>
<p>Registered bag with Colombian for Gosho1</p>
<p>Registered bag with Toothbrush, TravelKit, CellPhone for Ivan1</p>
<p>Registered bag with Toothbrush, Jewelery, CellPhone for Penka1</p>
<p>Checked in Pesho1 with 1/1 checked in bags</p>
<p>Checked in Gosho1 with 0/1 checked in bags</p>
<p>Checked in Ivan1 with 1/1 checked in bags</p>
<p>Checked in Penka1 with 1/1 checked in bags</p>
<p>Checked in Boiko1 with 0/0 checked in bags</p>
<p>Checked in Goshko1 with 0/0 checked in bags</p>
<p>Confiscated bags: 3 (5 items) =&gt; $103303</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>