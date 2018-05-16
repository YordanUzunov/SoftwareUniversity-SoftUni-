<h1>OOP Basics Retake Exam &ndash; Grand Prix</h1>
<p>It&rsquo;s racing time again! Welcome to Grand Prix de SoftUni!</p>
<h3>Overview</h3>
<p>You should write a software which simulates a Formula 1 race under number of commands. Different number of <strong>Drivers</strong> can participate in each race and each driver &hellip; well, drives a <strong>Car</strong>. Drivers have different attitude on the track and cars have different specifications which makes the race that thrilling!</p>
<h2>Task 1: Structure</h2>
<h3>Drivers</h3>
<p>All drivers have a name, total time record and a car to drive:</p>
<p>Name &ndash; a <strong>string</strong></p>
<p>TotalTime &ndash; a <strong>floating-point number</strong></p>
<p>Car - parameter of type Car</p>
<p><strong>FuelConsumptionPerKm</strong> &ndash; a <strong>floating-point number</strong></p>
<p><strong>Speed </strong>&ndash; a <strong>floating-point number</strong></p>
<p>Driver&rsquo;s <strong>Speed </strong>is calculated throught the formula below. Keep in mind that Speed changes on each lap.</p>
<p><strong>Speed = &ldquo;(car&rsquo;s Hp + tyre&rsquo;s degradation) / car&rsquo;s fuelAmount&rdquo;</strong></p>
<h4>AggressiveDriver</h4>
<p>This type of drivers have <strong>FuelConsumptionPerKm</strong> equal to <strong>2.7 liters</strong>. Also aggressive driver&rsquo;s <strong>Speed</strong> is <strong>multiplied by 1.3.</strong></p>
<h4>EnduranceDriver</h4>
<p>This type of drivers have <strong>FuelConsumptionPerKm</strong> equal to <strong>1.5 liters</strong>.</p>
<h3>Cars</h3>
<p>Each car should keep its horsepower (Hp), fuel amount and the <strong>type</strong> of tyres fit at the moment</p>
<p>Hp &ndash; &nbsp;an <strong>integer</strong></p>
<p>FuelAmount &ndash; a <strong>floating-point number</strong></p>
<p>Tyre - parameter of type Tyre</p>
<p>The fuel tank&rsquo;s <strong>maximum capacity</strong> of each car is <strong>160 liters</strong>. Fuel amount <strong>cannot become bigger</strong> than the tank&rsquo;s maximum capacity. If you are given <strong>more fuel</strong> <strong>than</strong> needed you should fill up the tank to the <strong>maxiumum</strong> and <strong>nothing else happens</strong>.</p>
<p>If <strong>fuel amount</strong> drops <strong>below 0 liters</strong> you should <strong>throw an exception</strong> and the <strong>driver cannot continue</strong> the race.</p>
<h3>Tyres</h3>
<p>Every type of tyre has different hardness of the compound. It also has a degradation level, which is its lifetime:</p>
<p>Name &ndash; a <strong>string</strong></p>
<p>Hardness &ndash;&nbsp; a <strong>floating-point number</strong></p>
<p>Degradation <strong>- </strong>a<strong> floating-point number</strong></p>
<p>Every tyre <strong>starts</strong> with <strong>100</strong> points <strong>degradation</strong> and drops down <strong>towards 0</strong>. Upon each lap it&rsquo;s degradation is <strong>reduced</strong> <strong>by</strong> the value of the <strong>hardness</strong>. If a tyre&rsquo;s degradation drops <strong>below 0</strong> points the tyre blows up and the <strong>driver cannot continue</strong> the race. If a <strong>tyre blows up</strong> you should <strong>throw an exeption</strong>.</p>
<h4>UltrasoftTyre</h4>
<p>Because it&rsquo;s ultra-soft this type of tyre has an additional property:</p>
<p>Grip &ndash;&nbsp; a positive <strong>floating-point number</strong></p>
<p>The name of this tyre is always &ldquo;<strong>Ultrasoft</strong>&rdquo;.</p>
<p>Upon <strong>each lap</strong>, it&rsquo;s Degradation<strong> drops down</strong> by its Hardness<strong> summed</strong> with its Grip. Also, the ultra-soft tyre <strong>blows up</strong> when tyre&rsquo;s Degradation<strong> drops below 30</strong> points.</p>
<h4>HardTyre</h4>
<p>The name of this tyre is always &ldquo;<strong>Hard</strong>&rdquo;. Hard tyres have less grip and slow down the car but endure bigger distance.</p>
<h2>Task 2: Business Logic</h2>
<p><em>Overview: Each execution of the application simulates <strong>only one</strong> race. In the beginning, you receive info about the track (laps / length) after which drivers are registered. The start of the race is marked by the first CompleteLaps command. The race finishes when all the laps are done by the drivers.</em></p>
<h3>The Controller Class</h3>
<p>The business logic of the program should be concentrated around several commands. Implement a class called RaceTower, which will hold the <strong>main functionality</strong>, represented by these <strong>public</strong> <strong>methods</strong>:</p>
<table width="0">
<tbody>
<tr>
<td width="390">
<p>RaceTower.cs</p>
</td>
</tr>
<tr>
<td width="390">
<p>void SetTrackInfo(int lapsNumber, int trackLength)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>void RegisterDriver(List&lt;string&gt; commandArgs)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>&nbsp;</p>
<p>void DriverBoxes(List&lt;string&gt; commandArgs)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>&nbsp;</p>
<p>string CompleteLaps(List&lt;string&gt; commandArgs)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>&nbsp;</p>
<p>string GetLeaderboard()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>&nbsp;</p>
<p>void ChangeWeather(List&lt;string&gt; commandArgs)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p><strong>NOTE: RaceTower class </strong>methods are called from the outside so these methods <strong>must</strong> <strong>NOT</strong> receive the command parameter (the first argument from the input line) as part of the arguments!</p>
<p>Method <strong>SetTrackInfo</strong>() should initialize track&rsquo;s total <strong>laps number</strong> and <strong>length</strong>.</p>
<h3>Commands</h3>
<p>There are several commands that control the business logic of the application and you are supposed to build. <br /> They are stated below.</p>
<h4>RegisterDriver Command</h4>
<p>Creates a Driver, and registers it into the race. Input data may <strong>not</strong> be <strong>always</strong> <strong>valid</strong>. If you <strong>can&rsquo;t create</strong> a Driver with the data provided upon this command <strong>just skip it</strong>. All <strong>successfully</strong> <strong>registered</strong> drivers should be <strong>saved</strong> <strong>inside</strong> the Racetower class in <strong>any type</strong> data structure provided by .NET Framework (no custom structures).</p>
<h5>Parameters</h5>
<ul>
<li>type &ndash; a <strong>string</strong>, equal to either &ldquo;Aggressive&ldquo; or &ldquo;Endurance&ldquo;</li>
<li>name &ndash; a <strong>string</strong></li>
<li>hp &ndash; an <strong>integer</strong></li>
<li>fuelAmount &ndash; a <strong>floating-point number</strong></li>
<li>tyreType &ndash; a <strong>string</strong></li>
<li>tyreHardness &ndash; a <strong>floating-point number</strong></li>
</ul>
<p>If the type of tyre is Ultrasoft, you will receive <strong>1 extra parameter</strong>:</p>
<ul>
<li>grip &ndash; a positive <strong>floating-point number</strong></li>
</ul>
<h4>Leaderboard Command</h4>
<p>On the first line print:</p>
<p>Lap {current lap}/{total laps number}</p>
<p>On the next lines, all drivers should be displayed in the order of their progress in the following format:</p>
<p>{Position number} {Driver&rsquo;s Name} {Total time / Failure reason}</p>
<p>Drivers are ordered by their TotalTime in acsending order.</p>
<h4>CompleteLaps Command</h4>
<p>Upon this command, <strong>all drivers</strong> progress the race with the <strong>specified number</strong> of laps. &nbsp;<strong>On each lap</strong>, each driver&rsquo;s <strong>TotalTime</strong> should be increased with the result of the following formula:</p>
<p><strong>&ldquo;60 / (trackLength / driver&rsquo;s Speed)&rdquo;</strong></p>
<p><strong>After each</strong> lap, you must do the <strong>actions below</strong> in the <strong>exact same order</strong>:</p>
<ol>
<li>Reduce <strong>FuelAmount</strong> by: <strong>&ldquo;trackLength * driver&rsquo;s fuelConsumptionPerKm&rdquo;</strong>.</li>
<li>Degradate tyre <strong>according</strong> to its <strong>type</strong></li>
</ol>
<p>If you are given <strong>greater laps number</strong> than the number of <strong>laps left</strong> in the race you should <strong>throw an exception</strong> with the <strong>appropriate message</strong> and <strong>not increment</strong> the <strong>completed</strong> laps number.</p>
<p><strong>After </strong>increasing<strong> the </strong><strong>TotalTime </strong>and decreasing driver&rsquo;s resources (reduce FuelAmount, degradate Tyre) you should <strong>check for overtaking</strong> opportunities. For more info read the <strong>Additional Action -&gt;</strong> <strong>Overtaking</strong> section.</p>
<h5>Parameters</h5>
<ul>
<li>numberOfLaps &ndash; an <strong>integer</strong></li>
</ul>
<h4>Box Command</h4>
<p>Makes a driver to box at the current lap which <strong>adds 20 seconds</strong> to his TotalTime and either <strong>changes</strong> his <strong>tyres</strong> with <strong>new ones</strong> of the specified type <strong>or refills</strong> with <strong>fuel</strong>.</p>
<h5>Parameters</h5>
<ul>
<li>reasonToBox - a <strong>string</strong>, equal to either ChangeTyres or Refuel</li>
<li>driversName - a <strong>string</strong> specifying which driver boxes</li>
<li>tyreType / fuelAmount - a <strong>string</strong> specifying the type of the new tyre / a <strong>floating-point</strong> specifying how much fuel is refilled</li>
</ul>
<p>If the reason is ChangeTyres, you will receive<strong> extra parameters</strong>:</p>
<ul>
<li>tyreHardness- a <strong>floating-point </strong>specifying the new tyres hardness (only for the <strong>ChangeTyres</strong> case)</li>
</ul>
<p>If the type of tyre is Ultrasoft, you will receive <strong>1 extra parameter</strong>:</p>
<ul>
<li>grip &ndash; a positive <strong>floating-point number</strong></li>
</ul>
<h4>ChangeWeather Command</h4>
<p>Changes the current weather. In the beginning, the weather is <strong>Sunny </strong>by default. Input parameter will <strong>always</strong> be <strong>valid</strong>!</p>
<h5>Parameters</h5>
<ul>
<li>weather &ndash; a <strong>string </strong>equal to one of the following: &ldquo;<strong>Rainy</strong>&rdquo;, &ldquo;<strong>Foggy</strong>&rdquo;, &ldquo;<strong>Sunny</strong>&rdquo;</li>
</ul>
<h3>Additional Action</h3>
<h4>DNF</h4>
<p>If a driver <strong>stops</strong> because of <strong>some failure</strong> he <strong>doesn&rsquo;t</strong> <strong>progress</strong> in the race anymore under the <strong>CompleteLaps </strong>command (his stats get frozen). Drivers that are not racing anymore <strong>still take part</strong> at the bottom of the <strong>Leaderboard</strong> in the <strong>order</strong> of their <strong>failure occurrence</strong> (the latest failed driver is at the very bottom).</p>
<ul>
<li>The message in case of a blown tyre should be - "Blown Tyre"</li>
<li>The message in case of getting out of fuel should be - "Out of fuel"</li>
<li>The message in case of a crash should be - "Crashed"</li>
</ul>
<h4>Overtaking</h4>
<p>At <strong>certain conditions</strong> drivers overtake each other. Generally, if a driver is <strong>2 seconds or less behind</strong> another driver at the end of a lap, he <strong>overtakes </strong>the driver<strong> ahead</strong> which <strong>reduces</strong> his <strong>TotalTime</strong> with the same interval of 2 seconds and <strong>increases</strong> the drivers that <strong>has been</strong> ahead <strong>TotalTime</strong> again with <strong>the same interval</strong>. Although there are some special cases:</p>
<ul>
<li><strong>AggressiveDriver</strong> on <strong>UltrasoftTyre</strong> has an overtake <strong>interval </strong>up to <strong>3</strong> <strong>seconds</strong> to the driver ahead and <strong>crashes</strong><strong> Foggy</strong> <strong>weather</strong>.</li>
<li><strong>EnduranceDriver</strong> on <strong>HardTyre</strong> has an overtake <strong>interval</strong> up to <strong>3 seconds</strong> to the driver ahead and <strong>crashes </strong>if <strong>attempts</strong> an overtake in <strong>Rainy</strong> <strong>weather</strong>.</li>
</ul>
<p>A driver is allowed to attempt an overtake <strong>only once</strong> in a <strong>lap</strong>. An overtaken driver is <strong>not allowed</strong> to <strong>fight back</strong> for his position in the same lap.</p>
<p><strong>Checking</strong> for overtaking opportunities <strong>must</strong> <strong>happen</strong> from the <strong>slowest</strong> (last) driver <strong>to</strong> the <strong>fastest</strong> (first).</p>
<h2>Task 3: Input / Output</h2>
<h3>Input</h3>
<ul>
<li>On the <strong>first line,</strong> you will receive an <strong>integer</strong> representing the <strong>number of laps</strong> in the <strong>race</strong></li>
<li>On the <strong>second</strong> <strong>line</strong>, you will receive an <strong>integer</strong> number representing the <strong>length</strong> of the <strong>track</strong></li>
<li>On the <strong>next</strong> lines, you will receive <strong>different</strong> <strong>commands</strong>. You should <strong>stop reading the input</strong> when drivers <strong>complete</strong> <strong>all</strong> <strong>laps</strong> in the race</li>
</ul>
<p>Below, you can see the <strong>format</strong> in which <strong>each command</strong> will be given in the input:</p>
<ul>
<li>RegisterDriver {type} {name} {hp} {fuelAmount} {tyreType} {tyreHardness}</li>
<li>RegisterDriver {type} {name} {hp} {fuelAmount} Ultrasoft {tyreHardness} {grip}</li>
<li>Leaderboard</li>
<li>CompleteLaps {numberOfLaps}</li>
<li>Box Refuel {driversName} {fuelAmount}</li>
<li>Box ChangeTyres {driversName} Hard {tyreHardness}</li>
<li>Box ChangeTyres {driversName} Ultrasoft {tyreHardness} {grip}</li>
<li>ChangeWeather {weather}</li>
</ul>
<h3>Output</h3>
<p>Below you can see what output should be provided from the commands.</p>
<h4>Leaderboard Command</h4>
<p>Lap {current lap}/{total laps number}</p>
<p>On the next lines, all drivers should be displayed in the order of their progress in the following format:</p>
<p>{Position number} {Driver&rsquo;s Name} {Total time / Failure reason}</p>
<h4>CompleteLaps Command</h4>
<p>If you are given invalid number of laps print on the console:</p>
<p>&ldquo;There is no time! On lap {current lap}.&rdquo;</p>
<p>In case of a successful overtake you should print on the console:</p>
<p>&ldquo;{Overtaking driver&rsquo;s name} has overtaken {Overtaken driver&rsquo;s name} on lap {Current lap number}.&rdquo;</p>
<h4>Finish</h4>
<p>After all laps in the race are completed you should print the winner on the console in the following format:</p>
<p>&ldquo;{Driver&rsquo;s name} wins the race for {TotalTime} seconds.&rdquo;</p>
<p>The TotalTime should be rounded to <strong>three digits</strong> after the <strong>decimal </strong>point.</p>
<h3>Constraints</h3>
<ul>
<li>The Driver&rsquo;s name will be a string which may contain any ASCII character, except <strong>space</strong> (&lsquo; &rsquo;).</li>
<li>The names of all drivers will always be <strong>unique</strong>.</li>
<li>All drivers will be registered <strong>before</strong> the <strong>race begins</strong> (there won&rsquo;t be any <strong>RegisterDriver</strong> command after the first <strong>CompleteLaps</strong> command).</li>
<li>A driver will <strong>never box</strong> <strong>twice</strong> in a <strong>lap</strong>.</li>
<li>Each race <strong>will have</strong> a finishing driver.</li>
<li>There will be <strong>NO invalid</strong> input data.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="371">
<p><strong>Input</strong></p>
</td>
<td width="361">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="371">
<p>32</p>
<p>3</p>
<p>RegisterDriver Aggressive FirstDriver 650 140 Ultrasoft 0.2 3.8</p>
<p>RegisterDriver Endurance SecondDriver 467 78.48 Hard 0.8</p>
<p>RegisterDriver Endurance ThirdDriver 160 78.48 Ultrasoft 0.4 2.7</p>
<p>CompleteLaps 17</p>
<p>Leaderboard</p>
<p>Box Refuel SecondDriver 98.28</p>
<p>CompleteLaps 15</p>
</td>
<td width="361">
<p>Lap 17/32</p>
<p>1 ThirdDriver 2896.110</p>
<p>2 FirstDriver 6918.938</p>
<p>3 SecondDriver 7209.032</p>
<p>SecondDriver wins the race for 9838.183 seconds.</p>
</td>
</tr>
<tr>
<td width="371">
<p>10</p>
<p>5</p>
<p>RegisterDriver Aggressive FirstDriver 650 140 Ultrasoft 10.2 3.0</p>
<p>RegisterDriver Aggressive SecondDriver 650 140 Hard 3.9</p>
<p>RegisterDriver Endurance ThirdDriver 360 78.48 Ultrasoft 2.4 0.7</p>
<p>CompleteLaps 14</p>
<p>CompleteLaps 8</p>
<p>Leaderboard</p>
<p>Box ChangeTyres ThirdDriver Hard 0.3</p>
<p>CompleteLaps 2</p>
</td>
<td width="361">
<p>There is no time! On lap 0.</p>
<p>FirstDriver has overtaken SecondDriver on lap 1.</p>
<p>Lap 8/10</p>
<p>1 ThirdDriver 931.587</p>
<p>2 SecondDriver 1127.098</p>
<p>3 FirstDriver Blown Tyre</p>
<p>ThirdDriver wins the race for 1752.693 seconds.</p>
</td>
</tr>
<tr>
<td width="371">
<p>14</p>
<p>5</p>
<p>RegisterDriver Endurance FirstDriver 650 140 Hard 0.2</p>
<p>RegisterDriver Endurance SecondDriver 650 140 Ultrasoft 0.2 0.3</p>
<p>RegisterDriver Aggressive ThirdDriver 350 100 Ultrasoft 0.2 0.3</p>
<p>RegisterDriver Aggressive FourthDriver 450 60 Hard 1.2</p>
<p>ChangeWeather Rainy</p>
<p>CompleteLaps 1</p>
<p>Leaderboard</p>
<p>Box Refuel FourthDriver 168</p>
<p>CompleteLaps 6</p>
<p>Box Refuel FourthDriver 2</p>
<p>CompleteLaps 6</p>
<p>Leaderboard</p>
<p>CompleteLaps 1</p>
</td>
<td width="361">
<p>Lap 1/14</p>
<p>1 SecondDriver 64.286</p>
<p>2 ThirdDriver 70.200</p>
<p>3 FourthDriver 143.000</p>
<p>4 FirstDriver Crashed</p>
<p>Lap 13/14</p>
<p>1 SecondDriver 1353.124</p>
<p>2 FourthDriver 2122.949</p>
<p>3 ThirdDriver Out of fuel</p>
<p>4 FirstDriver Crashed</p>
<p>SecondDriver wins the race for 1563.054 seconds.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Task 4: Bonus</h2>
<h3>Factories</h3>
<p>You know, that the keyword <strong>new</strong> is a bottleneck and we are trying to use it as less as possible. We even try to separate it in new classes. These classes are called Factories and the convention for them is <strong>{TypeOfObject}Factory</strong><strong>. </strong>You need to have <strong>two</strong> <strong>different</strong> <strong>factories</strong>, <strong>one for Driver and one for Tyre</strong>. This is actually a design pattern and you can read more about it. <a href="https://www.dotnetperls.com/factory">Factory Pattern</a></p>
<h2>Points</h2>
<p>For all tasks, you can submit the same project. Every different task gives you points:</p>
<ul>
<li>120 points</li>
<li>180 points</li>
<li>100 points</li>
<li>25 points</li>
</ul>
<p>&nbsp;</p>