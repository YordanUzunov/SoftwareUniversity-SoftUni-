<h1>OOP Advanced Exam &ndash; Minedraft</h1>
<p>You ever heard about the Rick and Morty&rsquo;s Foundation for mining Plumbus Ore. Naaa, probably not. Well let&rsquo;s just say there is this company that mines things, and they hired you to write them a supervising software. A draft which will be used to analyze the data of the mining &ndash; a &hellip; Minedraft.</p>
<h3>Overview</h3>
<p>You have a task to write a software program, which represent a system for future mining industry. You already have some of the functionalities implemented, although ... the guy that started the project &hellip; well it&rsquo;s obvious he is <strong>quite a rookie</strong> so you need to <strong>refactor</strong> his code and finish the project. The <strong>only</strong> thing he has <strong>done right</strong> is the <strong>class</strong> ProviderController and<strong> ALL </strong>the<strong> INTERFACES</strong>. You must leave these as they are and <strong>don&rsquo;t modify anything</strong>.</p>
<h2>Task 1: Structure</h2>
<p>The main structure of the program should include the following elements:</p>
<ul>
<li><strong>Engine</strong></li>
<li><strong>CommandInterpreter</strong></li>
<li><strong>HarvesterController</strong></li>
<li><strong>ProviderController</strong></li>
<li><strong>EnergyRepository</strong></li>
</ul>
<p>Everywhere you need to inject all dependencies by constructor injection.</p>
<p>The Structure also consists of Harvesters and Providers.</p>
<h3>Harvesters</h3>
<p>A basic Harvester has the following properties:</p>
<p>id - a <strong>int</strong>.</p>
<p>oreOutput - a <strong>floating-point number</strong>.</p>
<p>energyRequirement - a <strong>floating-point number</strong>.</p>
<p>durability - a <strong>floating-point number</strong>.</p>
<p>All harvesters start with <strong>1000</strong> <strong>durability</strong>. There are generally <strong>4 </strong>types of Harversters:</p>
<h4>StandartHarvester</h4>
<p>This type of harvester doesn&rsquo;t have anything special, so all stats are standart for harvester.</p>
<h4>SonicHarvester</h4>
<p>Really fast and of course weaker than standart ones. Upon initialization, their <strong>energy requirement </strong>is divided by 2, but their <strong>durability</strong> is also decreased by <strong>300</strong>.</p>
<h4>HammerHarvester</h4>
<p>Heavy harvesters are bigger than standart ones. Upon initialization, their <strong>energy requirement </strong>is <strong>multiplied</strong> by <strong>2</strong>, but their ore output is <strong>multiplied</strong> by <strong>4</strong>.</p>
<h4>InfinityHarvester</h4>
<p>Infinity harvesters are very special, they have special ability to repair themselves over nights. Upon initialization, their <strong>ore ourput </strong>is <strong>divided</strong> by <strong>10</strong>, but they <strong>cannot be broken.</strong></p>
<h3>Providers</h3>
<p>A basic Provider has the following properties:</p>
<p>id - a <strong>int</strong>.</p>
<p>energyOutput - a <strong>floating-point number</strong>.</p>
<p>durability - a <strong>floating-point number.</strong></p>
<p>All providers start with <strong>1000</strong> durability. There are generally <strong>3 </strong>types of Providers:</p>
<h4>StandartProvider</h4>
<p>This type of provider doesn&rsquo;t have anything special, so all stats are standart for provider.</p>
<h4>SolarProvider</h4>
<p>Extracts energy from the Sun. Upon initialization, their <strong>durability is increased by 500</strong>.</p>
<h4>PressureProvider</h4>
<p>Extracts energy from deep beneath the earth. Upon initialization, their <strong>durability is decreased by 300</strong>, but their <strong>energy output is multiplied by 2</strong>.</p>
<h2>Task 2: Business Logic</h2>
<h3>The Command Pattern</h3>
<p>The business logic of the program should be concentrated around several commands, so this program is perfect place to implement Command pattern. Implement a class called Engine, which will read commands and will pass them to the CommandInterpreter.</p>
<h3>Functionality</h3>
<p>The whole system never stops working, but for easy counting how much work is done, process is separated to days. Every day all the Providers produce energy and the Harvesters consume energy and mine Plumbus Ore. In your program a <strong>day passes</strong> when you have been given the <strong>corresponding command</strong>.</p>
<p>The Providers produce energy which is being stored on the system. When there is <strong>ENOUGH</strong> <strong>energy</strong> for a whole day, <strong>power up</strong> <strong>ALL</strong> Harvesters, the Harvesters <strong>consume</strong> it and return the ore.</p>
<p>Because of terrible sound, which Harvester produce, they work in different modes, which are 3 types. Each mode change their <strong>energy requirement </strong>and <strong>ore output</strong> to percent of their initial values.</p>
<p>Energy - <strong>20%</strong></p>
<p>Half - <strong>50%</strong></p>
<p>Full - <strong>100%</strong></p>
<p>For now it seems so easy and perfect, but like you know from real world, everything can be broke. Harvesters and Providers can be broke too. Actually they get broken at different events:</p>
<p>Harvesters - lose 100 of their durability each time, when <strong>mode is changed.</strong></p>
<p>Providers - lose 100 of their durability each <strong>day.</strong></p>
<p>When any entity durability is <strong>reach less than 0</strong>, it is broken and should be remove from system. Here is difference between providers and harvesters. Providers <strong>can</strong> be repaired, but harvesters <strong>CAN</strong> <strong>NOT</strong> be repaired.</p>
<h3>Commands</h3>
<p>There are several commands that control the business logic of the application you are supposed to build. <br /> They are stated below.</p>
<h4>Register Command</h4>
<p>Creates a Harvester or Provider, and registers it into the system, so they can start working.</p>
<p>type of entity - a <strong>string</strong>, equal to either Harvester or Provider.</p>
<p>type - a <strong>string, </strong>that correspond with types of Harvester or Provider.</p>
<p>id &ndash; a <strong>int</strong>.</p>
<p>If you receive Provider, command end with:</p>
<p>energy output - a <strong>double</strong>.</p>
<p>If you receive Harvester, command end with:</p>
<p>energy requirement - a <strong>double</strong>.</p>
<p>ore output - a <strong>double</strong>.</p>
<h4>Day Command</h4>
<p>When you receive this command, a day passes. This is the moment, where real work start. You need to <strong>calculate</strong> all provided <strong>energy</strong> and <strong>STORE</strong> it on the system. Then you need to <strong>check</strong> if there is <strong>enough</strong> <strong>energy</strong> for harvesters to start mining. If energy requirement of <strong>ALL</strong> harvesters is more than <strong>stored energy</strong> then <strong>NOTHING</strong> happen. But if there is <strong>enough energy</strong>, <strong>ALL</strong> harvesters <strong>start mining</strong> and they <strong>consume</strong> <strong>energy</strong> from store <strong>EQUAL</strong> to their energy requirement.</p>
<p><strong>NOTE</strong>: The summed up energyRequirement might be <strong>less</strong> or <strong>more</strong> depending on the current <strong>working</strong> <strong>Mode</strong>.</p>
<h4>Mode Command</h4>
<p>Changes the <strong>mode</strong> of the system, to the <strong>given one</strong>.</p>
<p>mode - a <strong>string</strong>, equal to either Full, Half or Energy.</p>
<h4>Repair Command</h4>
<p>Provided id will always be valid and will be provider&rsquo;s id, so you don&rsquo;t need to check it.</p>
<p>value - <strong>double. </strong></p>
<h4>Inspect Command</h4>
<p><strong>Checks</strong> the Provider or the Harvester with the <strong>given id</strong>, returning a <strong>string representation</strong> of it. The system should check if there is an <strong>element</strong> with the <strong>given id</strong> among the Providers or the Harvesters. The<strong> ids</strong> are <strong>unique</strong> so there should be only <strong>one</strong> with that <strong>id</strong>.</p>
<p>id - <strong>int</strong></p>
<h4>Shutdown Command</h4>
<p><strong>Ends</strong> the program and <strong>prints the total ore mined.</strong></p>
<p>&nbsp;</p>
<h2>Task 3: Tasks</h2>
<h3>Reflection</h3>
<p>You need to refactor the given Engine class by implementing a Command pattern. You are given an ICommand interface, which you need to implement in all your commands. You should implement all commands.</p>
<p>RegisterCommand</p>
<p>DayCommand</p>
<p>InspectCommand</p>
<p>ModeCommand</p>
<p>RepairCommand</p>
<p>ShutdownCommand</p>
<h3>Unit Testing</h3>
<p>Like you see at the beginning there is а class, which does not need refactoring - ProviderController<strong>. </strong>This is the class, against which you need to <strong>write unit tests</strong>. For easy testing, there are some stuff that are not high quality (setters are public, etc.), but you can use them in your unit tests. In your skeleton, the ProviderController is working <strong>perfect</strong>, but it still needs to be tested, because in <strong>Judge</strong> we have prepared some <strong>bugs</strong> and you need to catch them in your unit tests.</p>
<p>Do <strong>NOT</strong> use <strong>Mocking</strong> in your unit tests!</p>
<h3>Input</h3>
<p>Below, you can see the <strong>format</strong> in which <strong>each command</strong> will be given from the input:</p>
<ul>
<li>Register Harvester Sonic {id} {oreOutput} {energyRequirement}</li>
<li>Register Provider Hammer {id} {energyOutput}</li>
<li>Day</li>
<li>Mode {mode}</li>
<li>Inspect {id}</li>
<li>Repair {id} {rapairValue}</li>
<li>Shutdown</li>
</ul>
<h3>Output</h3>
<h4>Register Command</h4>
<p>If registration is successful, print message:</p>
<p>&ldquo;Successfully registered {Class Name}&rdquo;.</p>
<h4>Day Command</h4>
<p>After each day command, you need to print:</p>
<p>&ldquo;Produced {energy produced this day} energy today!</p>
<p>Produced {ore produced this day} ore today!&rdquo;.</p>
<h4>Mode Command</h4>
<p>On mode changing you need to print:</p>
<p>&ldquo;Mode changed to {new mode}!&rdquo;.</p>
<h4>Repair Command</h4>
<p>Repair a provider with a specific id. The provided id will always be valid and will be a provider&rsquo;s id, so you don&rsquo;t need to check it.</p>
<p>&ldquo;Providers are repaired by {value}&rdquo;</p>
<h4>Inspect Command</h4>
<p>Should return a <strong>string representation</strong> of the element with the <strong>given id</strong>. If there is no such entity, the command should output a message:</p>
<p>&ldquo;No entity found with id &ndash; {id}&rdquo;.</p>
<p>If there is a entity with this id, you need to print:</p>
<p>&ldquo;{full type of entity}</p>
<p>Durability: {entity durability}&rdquo;.</p>
<h4>Shutdown Command</h4>
<p>Should output a message</p>
<p>&ldquo;System Shutdown</p>
<p>Total Energy Produced: {totalEnergyProduced}</p>
<p>Total Mined Plumbus Ore: {totalMinedOre}&rdquo;.</p>
<p>The totalEnergyStored and totalMinedOre are the total values that have been gathered throughout the program&rsquo;s execution.</p>
<h3>Constraints</h3>
<ul>
<li>The id will be a string which may contain any ASCII character, except <strong>space</strong> (&lsquo; &rsquo;).</li>
<li>All members in our mining industry program <strong>(harvesters and providers)</strong> have <strong>unique id's</strong>.</li>
<li>All <strong>floating-point numbers</strong> will be in <strong>range [-100.000, 100.000]</strong>.</li>
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
<p>Register Harvester Hammer 20 100 100</p>
<p>Register Provider Pressure 40 100</p>
<p>Day</p>
<p>Mode Half</p>
<p>Day</p>
<p>Inspect 60</p>
<p>Shutdown</p>
</td>
<td width="361">
<p>Successfully registered HammerHarvester</p>
<p>Successfully registered PressureProvider</p>
<p>Produced 200 energy today!</p>
<p>Produced 400 ore today!</p>
<p>Mode changed to Half!</p>
<p>Produced 200 energy today!</p>
<p>Produced 200 ore today!</p>
<p>No entity found with id - 60</p>
<p>System Shutdown</p>
<p>Total Energy Produced: 400</p>
<p>Total Mined Plumbus Ore: 600</p>
</td>
</tr>
<tr>
<td width="371">
<p>Register Harvester Standart 20 100 100</p>
<p>Register Harvester Standart 40 100 100</p>
<p>Inspect 20</p>
<p>Day</p>
<p>Mode Energy</p>
<p>Day</p>
<p>Shutdown</p>
</td>
<td width="361">
<p>Successfully registered StandartHarvester</p>
<p>Successfully registered StandartHarvester</p>
<p>StandartHarvester</p>
<p>Durability: 1000</p>
<p>Produced 0 energy today!</p>
<p>Produced 0 ore today!</p>
<p>Mode changed to Energy!</p>
<p>Produced 0 energy today!</p>
<p>Produced 0 ore today!</p>
<p>System Shutdown</p>
<p>Total Energy Produced: 0</p>
<p>Total Mined Plumbus Ore: 0</p>
</td>
</tr>
<tr>
<td width="371">
<p>Register Harvester Hammer 20 100 100</p>
<p>Register Harvester Sonic 30 100 50</p>
<p>Register Provider Pressure 40 100</p>
<p>Register Provider Solar 80 100</p>
<p>Day</p>
<p>Day</p>
<p>Day</p>
<p>Mode Full</p>
<p>Mode Half</p>
<p>Inspect 30</p>
<p>Repair 20</p>
<p>Day</p>
<p>Day</p>
<p>Mode Half</p>
<p>Mode Energy</p>
<p>Mode Full</p>
<p>Mode Half</p>
<p>Mode Energy</p>
<p>Mode Half</p>
<p>Mode Energy</p>
<p>Mode Half</p>
<p>Mode Energy</p>
<p>Inspect 30</p>
<p>Day</p>
<p>Shutdown</p>
</td>
<td width="361">
<p>Successfully registered HammerHarvester</p>
<p>Successfully registered SonicHarvester</p>
<p>Successfully registered PressureProvider</p>
<p>Successfully registered SolarProvider</p>
<p>Produced 300 energy today!</p>
<p>Produced 500 ore today!</p>
<p>Produced 300 energy today!</p>
<p>Produced 500 ore today!</p>
<p>Produced 300 energy today!</p>
<p>Produced 500 ore today!</p>
<p>Mode changed to Full!</p>
<p>Mode changed to Half!</p>
<p>SonicHarvester</p>
<p>Durability: 500</p>
<p>Providers are repaired by 20</p>
<p>Produced 300 energy today!</p>
<p>Produced 250 ore today!</p>
<p>Produced 300 energy today!</p>
<p>Produced 250 ore today!</p>
<p>Mode changed to Half!</p>
<p>Mode changed to Energy!</p>
<p>Mode changed to Full!</p>
<p>Mode changed to Half!</p>
<p>Mode changed to Energy!</p>
<p>Mode changed to Half!</p>
<p>Mode changed to Energy!</p>
<p>Mode changed to Half!</p>
<p>Mode changed to Energy!</p>
<p>No entity found with id - 30</p>
<p>Produced 300 energy today!</p>
<p>Produced 0 ore today!</p>
<p>System Shutdown</p>
<p>Total Energy Produced: 1800</p>
<p>Total Mined Plumbus Ore: 2000</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>