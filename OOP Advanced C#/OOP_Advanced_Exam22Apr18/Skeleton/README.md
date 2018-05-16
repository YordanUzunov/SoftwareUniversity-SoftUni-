<h1>C# OOP Advanced Exam &ndash; Festival Manager</h1>
<p>The biggest music festival kingpin in Bulgaria, Bay Kiro is looking for junior developers and has hired you to create a stunning festival management platform, called <strong>Festival Manager</strong>.</p>
<h1>Overview</h1>
<p>Your task is to build a software project, which manages a<strong> music</strong> <strong>festival</strong>. This festival will have <strong>sets</strong>, each of which has a list of <strong>performers </strong>(which have a list of <strong>instruments</strong>) and a list of<strong> songs </strong>to play during the set. The sets are <strong>performed in order</strong>. At the end of the program, a <strong>performance report</strong> is generated for each set.</p>
<h1>Task I: Structure</h1>
<p>Unfortunately, the previous maintainer of this code was doing a pretty terrible job. All he managed to do correctly was <strong>create all the interfaces </strong>and the SetController. <strong>Do not modify the interfaces or their namespaces!</strong></p>
<p>The main structure of the program should include the following elements:</p>
<ul>
<li><strong>Engine</strong> &ndash; <strong>Processes input commands</strong> and <strong>sends them</strong> to the relevant <strong>controllers</strong> to handle</li>
<li><strong>FestivalController</strong> &ndash; <strong>Handles</strong> all the <strong>commands</strong> listed in the <strong>I/O</strong> section</li>
<li><strong>SetController</strong> &ndash; Responsible for <strong>performing the sets</strong></li>
<li><strong>Stage</strong> &ndash; <strong>Repository</strong>, which <strong>holds</strong> all the <strong>sets</strong>, <strong>songs</strong> and <strong>performers</strong>, and provides <strong>methods </strong>for <strong>retrieving</strong> and <strong>storing</strong></li>
</ul>
<h2>Guidelines</h2>
<ul>
<li>Make sure your Visual Studio is up-to-date. If it isn&rsquo;t, <strong>disable</strong> <strong>Lightweight Solution Load</strong>, otherwise you risk a bug where <strong>the .NET Core skeleton doesn&rsquo;t build</strong> (and has red squiggles everywhere).</li>
<li>Upload <strong>only the </strong>FestivalManager project in every problem <strong>except</strong> <strong> Unit Tests</strong>. For <strong>03. Unit Tests</strong>, upload <strong>only the </strong>FestivalManager.Tests<strong> project </strong>with <strong>all using statements pointing to </strong>FestivalManager <strong>removed</strong>.</li>
<li><strong>Do not modify the interfaces or their namespaces!</strong></li>
<li>You will have to refactor everything else as you see fit. Use <strong>strong cohesion </strong>and <strong>loose coupling</strong>.</li>
<li><strong>Use inheritance and the provided interfaces wherever possible</strong>. This includes <strong>constructors</strong>, <strong>method parameters </strong>and<strong> return types</strong>!</li>
<li><strong>Do not</strong> violate your <strong>interface</strong> <strong>implementations</strong> by adding <strong>more public methods</strong> or <strong>properties</strong> in the concrete class than the interface has defined!</li>
<li>Make sure you have <strong>no public fields</strong></li>
</ul>
<p>Below, you will find a detailed description of all entities and their methods.</p>
<h2>Sets</h2>
<p>An abstract<strong> set</strong> has the following characteristics:</p>
<ul>
<li>string &egrave; Name</li>
<li>TimeSpan &egrave; MaxDuration</li>
<li>TimeSpan &egrave; ActualDuration&ndash; <strong>Sum</strong> of the <strong>duration of all the songs </strong>in the set (<strong>calculated</strong> property)</li>
<li>IReadOnlyCollection &egrave; Performers</li>
<li>IReadOnlyCollection &egrave; Songs</li>
</ul>
<p>Sets have several <strong>methods</strong>, but the most interesting one is bool CanPerform(), which ensures the set can be performed under these conditions:</p>
<ul>
<li>There is at least <strong>1 performer</strong> in the set</li>
<li>There is at least <strong>1 song</strong> in the set</li>
<li>All performers have at least <strong>1 instrument</strong>, which is <strong>not broken</strong>.</li>
</ul>
<p>The other interesting method is the AddSong(ISong song) method. If you attempt to add a song, which would be longer than the set allows, throw an InvalidOperationException with the message "Song is over the set limit!".</p>
<p>Create <strong>three</strong> <strong>classes</strong> for each of the three <strong>types</strong> of sets we have:</p>
<ul>
<li><strong>Short </strong>&ndash; <strong>15 minutes long</strong> at max</li>
<li><strong>Medium </strong>&ndash; <strong>40 minutes long</strong> at max</li>
<li><strong>Long </strong>&ndash; <strong>60 minutes long</strong> at max</li>
</ul>
<h2>Instruments</h2>
<p>An abstract <strong>Instrument</strong> has the following characteristics:</p>
<ul>
<li>Double &egrave; Wear
<ul>
<li>If the wear ever goes <strong>below 0</strong>, set it to 0, and if it ever goes <strong>above 100</strong>, set it to 100</li>
<li>All instruments have <strong>100 </strong>Wear<strong> on initialization</strong></li>
</ul>
</li>
<li>Int &egrave; RepairAmount</li>
<li>Bool &egrave; IsBroken&ndash; true if the <strong>instrument&rsquo;s</strong> <strong>wear</strong> is <strong>less than or equal to</strong> <strong>0</strong> (calculated property).</li>
</ul>
<p>An <strong>instrument</strong> has <strong>three </strong>methods &ndash; void WearDown() and void Repair(), which <strong>decrease</strong> and <strong>increase</strong> the wear of the instrument by the <strong>RepairAmount</strong> respectively.</p>
<p>The following classes inherit <strong>Instrument</strong>:</p>
<ul>
<li><strong>Drums</strong> &ndash; <strong>20</strong> RepairAmount</li>
<li><strong>Guitar</strong> &ndash; <strong>60</strong> RepairAmount</li>
<li><strong>Microphone</strong> &ndash; <strong>80</strong> RepairAmount</li>
</ul>
<h2>Performer</h2>
<p>A performer has these characteristics:</p>
<ul>
<li>string &egrave; Name</li>
<li>int &egrave; Age</li>
<li>IReadOnlyCollection &egrave; Instruments</li>
</ul>
<h2>Song</h2>
<p>A song has these characteristics:</p>
<ul>
<li>string &egrave; Name</li>
<li>TimeSpan &egrave; Duration</li>
</ul>
<h2>Stage</h2>
<p>The <strong>stage</strong> class is a <strong>repository</strong> where all the current <strong>songs</strong>, <strong>performers</strong> and <strong>sets</strong> are <strong>stored</strong>. It has:</p>
<ul>
<li>Methods for <strong>Adding sets</strong>, <strong>performers</strong> and <strong>songs</strong></li>
<li>Methods for retrieving <strong>sets</strong>, <strong>performers</strong> and <strong>songs</strong> <strong>by name</strong></li>
<li>Methods for checking if a <strong>set</strong>, <strong>performer</strong> or <strong>song</strong> <strong>exists</strong> <strong>by name</strong>.</li>
</ul>
<p><strong>Note</strong>: The Stage is <strong>shared</strong> between the <strong>festival controller</strong> and the <strong>set controller</strong>.</p>
<h1>Task II: Business Logic</h1>
<p>Your code should only catch exceptions on the <strong>engine level</strong>.</p>
<h2>Commands</h2>
<p>The software needs to be able to process several commands in the form of <strong>methods</strong>:</p>
<h3>RegisterSet {name} {type}</h3>
<p>Creates a <strong>set</strong> of the specified <strong>type </strong>with the specified <strong>name </strong>and <strong>adds it to the stage&rsquo;s sets</strong>. Upon a successful set registration, the command returns "Registered {type} set".</p>
<h3>SignUpPerformer {name} {age} {instrument1} {instrument2} {instrumentN}</h3>
<p>Creates a <strong>performer</strong> with the specified <strong>name </strong>and <strong>age</strong>, which holds a list of <strong>instruments </strong>and <strong>adds them to the stage</strong>. Upon successful creation, the command returns "Registered performer {performerName}".</p>
<p>Note: <strong>Performers can have</strong> <strong>no instruments</strong>. This is valid input.</p>
<h3>RegisterSong {name} {mm:ss}</h3>
<p>Creates a <strong>song</strong> with the specified <strong>name </strong>and <strong>duration</strong> and <strong>adds it to the stage&rsquo;s songs</strong>. Upon successful creation, the command returns "Registered song {songName} ({duration:mm\\:ss})".</p>
<h3>AddSongToSet {songName} {setName}</h3>
<p>Adds the <strong>song</strong> with the given <strong>name</strong> to the <strong>set </strong>with the given <strong>name</strong>.</p>
<p>If the set <strong>doesn&rsquo;t exist</strong> in the stage, throw an InvalidOperationException with the message "Invalid set provided".</p>
<p>If the <strong>song</strong> <strong>doesn&rsquo;t exist</strong> in the stage, throw an InvalidOperationException with the message "Invalid song provided".</p>
<p>If successful, the command returns "Added {songName} ({duration:mm\\:ss}) to {setName}".</p>
<h3>AddPerformerToSet {performerName} {setName}</h3>
<p>Adds the specified <strong>performer</strong> with the specified <strong>name </strong>to the <strong>set</strong>.</p>
<p>If the <strong>performer</strong> <strong>doesn&rsquo;t exist</strong> in the stage, throw an InvalidOperationException with the message "Invalid performer provided".</p>
<p>If the set <strong>doesn&rsquo;t exist</strong> in the stage, throw an InvalidOperationException with the message "Invalid set provided".</p>
<p>If successful, the command returns "Added {performerName} to {setName}".</p>
<h3>RepairInstruments</h3>
<p>Gets <strong>all instruments </strong>from <strong>all</strong> <strong>performers </strong>and <strong>repairs only the ones, </strong>which have a<strong> wear level lower than 100</strong>. When the repairs are finished, the command returns "Repaired {repairedInstrumentsCount} instruments".</p>
<h3>LetsRock</h3>
<p>This command is supposed to call PerformSets(), which is implemented correctly in the skeleton. The command retrieves all sets from the stage, ordered by their actual duration (descending), then by the count of their performers (descending). For each one, if it cannot be performed, "-- Did not perform" is printed as part of the command output.</p>
<p>If the set can be performed, each song is printed in the format "-- {songIndex}. {songName} ({songDuration:mm\\:ss})". <strong>After each song</strong>, each performer&rsquo;s instruments are <strong>worn down </strong>(e.g. if the set has <strong>two</strong> songs, they would be worn down <strong>twice</strong>). The command&rsquo;s output ends with "-- Set Successful" (only if the set was performed).</p>
<h1>Tasks III:</h1>
<h2>Reflection</h2>
<p>You need to refactor the given factories and implement new ones. Factories must <strong>use reflection</strong>, so it will be easy for us to follow the <strong>Open/Closed Principle</strong>. You are required to implement <strong>two factories</strong>:</p>
<ul>
<li>SetFactory</li>
<li>InstrumentFactory</li>
</ul>
<p>Feel free to make additional factories for the other entities, even though they will not be tested.</p>
<p>Your task is to implement these factories in such a way that it will be <strong>easy to extend the number of concrete types of each entity</strong>.</p>
<p><strong>NOTE:</strong> <strong>Make sure you reference the Calling Assembly, instead of the Executing Assembly, since the code that&rsquo;s going to be calling your factories in the tests depends on this!</strong></p>
<p><strong>No static </strong>factories are allowed<strong>!</strong></p>
<h2>Unit Testing</h2>
<p>Like you saw at the beginning, there is а class, which does not need refactoring - SetController<strong>. </strong>This is the class, against which you need to <strong>write unit tests</strong>. In your skeleton, you are provided with a <strong>perfectly working</strong> SetController, but it still needs to be <strong>tested</strong>, because in <strong>Judge</strong>, we have prepared some <strong>bugs</strong>, and you need to catch them in your unit tests.</p>
<p>You are provided with a <strong>unit test project</strong> in the <strong>project skeleton</strong>. <strong>DO NOT modify its NuGet packages</strong>.</p>
<p>Note: The SetController you need to test is in the <strong>global namespace</strong>, as are any entities, which it depends on, so <strong>remove any using statements</strong> pointing towards any entities and controllers before submitting your code. Do not use the FestivalController in your tests, as it&rsquo;s not a part of the classes you are provided with.</p>
<p>Do <strong>NOT</strong> use <strong>Mocking</strong> in your unit tests!</p>
<h2>Input</h2>
<ul>
<li>The input will come from the console in the form of commands, in the format specified above - each command on new line</li>
<li>The input sequence ends when you receive the command &ldquo;<strong>END</strong>&rdquo;</li>
<li><strong>Any</strong> type of command, except &ldquo;<strong>END</strong>&rdquo; can be given at any time.</li>
</ul>
<h2>Output</h2>
<p>The <strong>output</strong> of each command must be printed <strong>on a new line</strong>.</p>
<p>If an exception is thrown because of invalid state (invalid song or set name, etc.), they should be printed in the following format: &ldquo;ERROR: {exceptionMessage}&rdquo;.</p>
<p>After the &ldquo;END&rdquo; command is received, you must <strong>produce a report</strong> in the following format:</p>
<p>The <strong>first line</strong> of the report has the festival&rsquo;s <strong>total length</strong> (<strong>sum</strong> of <strong>all sets&rsquo; actual duration</strong>) in the following format:</p>
<p>"Festival length: {totalFestivalLength}"</p>
<p>After that, <strong>for each of the sets</strong>, print the following info:</p>
<p>First off, print the <strong>set&rsquo;s name</strong> and <strong>actual duration</strong> in the following format:</p>
<p>"--{setName} ({actualSetDuration}):"</p>
<p>Then, get all the performers, <strong>ordered by age in descending order</strong>, and for each one, print info in the following format, <strong>ordered descending by wear</strong>:</p>
<p>&ldquo;---{performerName} ({instrument1Name [{wear}%], instrument2Name [{wear}%], etc.})&rdquo;.</p>
<p>If an instrument is <strong>broken</strong>, put &ldquo;{instrumentName} [broken]&rdquo; <strong>instead</strong> of its wear.</p>
<p>Then, print information about each song in the set.</p>
<p>If there are <strong>no songs in the set</strong>, print "--No songs played". Otherwise, print "--Songs played:" and for each song, print "----{songName} ({songDuration:mm\\:ss})"</p>
<h2>Constraints</h2>
<ul>
<li><strong>All durations will be in the format &ldquo;</strong>mm:ss<strong>&rdquo; </strong>and will <strong>always</strong> have <strong>leading zeroes</strong>.</li>
<li><strong>All input durations will be at least 00:00 and at most 59:59</strong>.</li>
<li>A <strong>festival</strong>&rsquo;s <strong>total duration</strong> can be <strong>60 minutes long or more</strong>.</li>
<li>All input lines will be <strong>valid</strong> commands with <strong>valid </strong></li>
<li>There will be <strong>at most</strong> <strong>30</strong> commands</li>
<li><strong>All</strong> rules <strong>specified above</strong> will be <strong>strictly</strong> <strong>followed</strong>, there will be <strong>NO</strong> unexpected input or conditions</li>
</ul>
<h2>Examples</h2>
<p>You are also provided with a <strong>test archive</strong>, which contains the tests below as a <strong>.zip</strong> file.</p>
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
<p>RegisterSet Set1 Short</p>
<p>RegisterSet Set2 Medium</p>
<p>SignUpPerformer Ivan 20 Guitar</p>
<p>SignUpPerformer Gosho 24 Drums</p>
<p>SignUpPerformer Pesho 19 Guitar Microphone</p>
<p>RegisterSong Song1 01:02</p>
<p>AddSongToSet Song1 Set1</p>
<p>AddPerformerToSet Gosho Set1</p>
<p>AddPerformerToSet Pesho Set1</p>
<p>LetsRock</p>
<p>END</p>
</td>
<td width="398">
<p>Registered Short set</p>
<p>Registered Medium set</p>
<p>Registered performer Ivan</p>
<p>Registered performer Gosho</p>
<p>Registered performer Pesho</p>
<p>Registered song Song1 (01:02)</p>
<p>Added Song1 (01:02) to Set1</p>
<p>Added Gosho to Set1</p>
<p>Added Pesho to Set1</p>
<p>1. Set1:</p>
<p>-- 1. Song1 (01:02)</p>
<p>-- Set Successful</p>
<p>2. Set2:</p>
<p>-- Did not perform</p>
<p>Results:</p>
<p>Festival length: 01:02</p>
<p>--Set1 (01:02):</p>
<p>---Gosho (Drums [80%])</p>
<p>---Pesho (Guitar [40%], Microphone [20%])</p>
<p>--Songs played:</p>
<p>----Song1 (01:02)</p>
<p>--Set2 (00:00):</p>
<p>--No songs played</p>
</td>
</tr>
<tr>
<td width="310">
<p>RegisterSet Set1 Short</p>
<p>RegisterSet Set2 Medium</p>
<p>RegisterSet Set3 Long</p>
<p>SignUpPerformer Pesho 23 Guitar</p>
<p>SignUpPerformer Ivan 24 Drums</p>
<p>SignUpPerformer Gosho 25 Microphone</p>
<p>AddPerformerToSet Gosho Set1</p>
<p>AddPerformerToSet Pesho Set1</p>
<p>AddPerformerToSet Ivan Set2</p>
<p>RegisterSong Song1 05:00</p>
<p>RegisterSong Song2 05:00</p>
<p>RegisterSong Song3 05:00</p>
<p>RegisterSong Song4 00:01</p>
<p>AddSongToSet Invalid Set1</p>
<p>AddSongToSet Song2 Invalid</p>
<p>AddSongToSet Song1 Set1</p>
<p>AddSongToSet Song2 Set1</p>
<p>AddSongToSet Song3 Set1</p>
<p>AddSongToSet Song4 Set1</p>
<p>LetsRock</p>
<p>RepairInstruments</p>
<p>END</p>
</td>
<td width="398">
<p>Registered Short set</p>
<p>Registered Medium set</p>
<p>Registered Long set</p>
<p>Registered performer Pesho</p>
<p>Registered performer Ivan</p>
<p>Registered performer Gosho</p>
<p>Added Gosho to Set1</p>
<p>Added Pesho to Set1</p>
<p>Added Ivan to Set2</p>
<p>Registered song Song1 (05:00)</p>
<p>Registered song Song2 (05:00)</p>
<p>Registered song Song3 (05:00)</p>
<p>Registered song Song4 (00:01)</p>
<p>ERROR: Invalid song provided</p>
<p>ERROR: Invalid set provided</p>
<p>Added Song1 (05:00) to Set1</p>
<p>Added Song2 (05:00) to Set1</p>
<p>Added Song3 (05:00) to Set1</p>
<p>ERROR: Song is over the set limit!</p>
<p>1. Set1:</p>
<p>-- 1. Song1 (05:00)</p>
<p>-- 2. Song2 (05:00)</p>
<p>-- 3. Song3 (05:00)</p>
<p>-- Set Successful</p>
<p>2. Set2:</p>
<p>-- Did not perform</p>
<p>3. Set3:</p>
<p>-- Did not perform</p>
<p>Repaired 2 instruments</p>
<p>Results:</p>
<p>Festival length: 15:00</p>
<p>--Set1 (15:00):</p>
<p>---Gosho (Microphone [80%])</p>
<p>---Pesho (Guitar [60%])</p>
<p>--Songs played:</p>
<p>----Song1 (05:00)</p>
<p>----Song2 (05:00)</p>
<p>----Song3 (05:00)</p>
<p>--Set2 (00:00):</p>
<p>---Ivan (Drums [100%])</p>
<p>--No songs played</p>
<p>--Set3 (00:00):</p>
<p>--No songs played</p>
</td>
</tr>
<tr>
<td width="310">
<p>RegisterSet TestSet Short</p>
<p>SignUpPerformer Gosho 21 Guitar Microphone</p>
<p>SignUpPerformer Pesho 23 Drums</p>
<p>SignUpPerformer Ivan 20 Microphone</p>
<p>AddPerformerToSet Ivan TestSet</p>
<p>AddPerformerToSet Gosho InvalidSet</p>
<p>AddPerformerToSet InvalidPerformer InvalidSet</p>
<p>RegisterSong SongName 03:00</p>
<p>RegisterSong SongName2 02:00</p>
<p>RegisterSong SongName3 10:00</p>
<p>RegisterSong SongName4 00:01</p>
<p>AddSongToSet SongName TestSet</p>
<p>AddSongToSet SongName2 TestSet</p>
<p>AddSongToSet SongName3 TestSet</p>
<p>AddSongToSet SongName4 TestSet</p>
<p>AddSongToSet InvalidSongName TestSet</p>
<p>AddSongToSet SongName InvalidSet</p>
<p>LetsRock</p>
<p>RepairInstruments</p>
<p>RegisterSet TestSet2 Short</p>
<p>LetsRock</p>
<p>SignUpPerformer Ivancho 20</p>
<p>AddPerformerToSet Ivancho TestSet2</p>
<p>LetsRock</p>
<p>END</p>
</td>
<td width="398">
<p>Registered Short set</p>
<p>Registered performer Gosho</p>
<p>Registered performer Pesho</p>
<p>Registered performer Ivan</p>
<p>Added Ivan to TestSet</p>
<p>ERROR: Invalid set provided</p>
<p>ERROR: Invalid performer provided</p>
<p>Registered song SongName (03:00)</p>
<p>Registered song SongName2 (02:00)</p>
<p>Registered song SongName3 (10:00)</p>
<p>Registered song SongName4 (00:01)</p>
<p>Added SongName (03:00) to TestSet</p>
<p>Added SongName2 (02:00) to TestSet</p>
<p>Added SongName3 (10:00) to TestSet</p>
<p>ERROR: Song is over the set limit!</p>
<p>ERROR: Invalid song provided</p>
<p>ERROR: Invalid set provided</p>
<p>1. TestSet:</p>
<p>-- 1. SongName (03:00)</p>
<p>-- 2. SongName2 (02:00)</p>
<p>-- 3. SongName3 (10:00)</p>
<p>-- Set Successful</p>
<p>Repaired 1 instruments</p>
<p>Registered Short set</p>
<p>1. TestSet:</p>
<p>-- 1. SongName (03:00)</p>
<p>-- 2. SongName2 (02:00)</p>
<p>-- 3. SongName3 (10:00)</p>
<p>-- Set Successful</p>
<p>2. TestSet2:</p>
<p>-- Did not perform</p>
<p>Registered performer Ivancho</p>
<p>Added Ivancho to TestSet2</p>
<p>1. TestSet:</p>
<p>-- Did not perform</p>
<p>2. TestSet2:</p>
<p>-- Did not perform</p>
<p>Results:</p>
<p>Festival length: 15:00</p>
<p>--TestSet (15:00):</p>
<p>---Ivan (Microphone [broken])</p>
<p>--Songs played:</p>
<p>----SongName (03:00)</p>
<p>----SongName2 (02:00)</p>
<p>----SongName3 (10:00)</p>
<p>--TestSet2 (00:00):</p>
<p>---Ivancho ()</p>
<p>--No songs played</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>