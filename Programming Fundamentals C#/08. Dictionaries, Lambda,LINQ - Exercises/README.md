<h1>Exercises: Dictionaries, Lambda and LINQ</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>Check your solutions here: <a href="https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises">https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises</a>.</p>
<h2>1.&nbsp;&nbsp; Phonebook</h2>
<p>Write a program that receives some info from the console about <strong>people</strong> and their <strong>phone numbers</strong>. Each <strong>entry</strong> should have just <strong>one name</strong> and <strong>one number</strong> (both of them strings).</p>
<p>On each line, you will receive some of the following commands:</p>
<ul>
<li><strong>A {name} {phone}</strong> &ndash; adds entry to the phonebook. In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.</li>
<li><strong>S {name}</strong> &ndash; searches for a contact by given name and prints it in format "<strong>{name} -&gt; {number}</strong>". In case the contact isn't found, print "<strong>Contact {name} does not exist.</strong>".</li>
<li><strong>END</strong> &ndash; stop receiving more commands.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="274">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>A Nakov 0888080808</p>
<p>S Mariika</p>
<p>S Nakov</p>
<p>END</p>
</td>
<td width="274">
<p>Contact Mariika does not exist.</p>
<p>Nakov -&gt; 0888080808</p>
</td>
</tr>
<tr>
<td width="189">
<p>A Nakov +359888001122</p>
<p>A RoYaL(Ivan) 666</p>
<p>A Gero 5559393</p>
<p>A Simo 02/987665544</p>
<p>S Simo</p>
<p>S simo</p>
<p>S RoYaL</p>
<p>S RoYaL(Ivan)</p>
<p>END</p>
</td>
<td width="274">
<p>Simo -&gt; 02/987665544</p>
<p>Contact simo does not exist.</p>
<p>Contact RoYaL does not exist.</p>
<p>RoYaL(Ivan) -&gt; 666</p>
</td>
</tr>
<tr>
<td width="189">
<p>A Misho +359883123</p>
<p>A Misho 02/3123</p>
<p>S Misho</p>
<p>END</p>
</td>
<td width="274">
<p>Misho -&gt; 02/3123</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Parse the commands</strong> by splitting by space. Execute the commands until &ldquo;<strong>END</strong>&rdquo; is reached.</li>
<li>Store the <strong>phonebook entries</strong> in <strong>Dictionary&lt;string, string&gt;</strong> with key <strong>{name}</strong> and value <strong>{phone number}</strong>.</li>
</ul>
<h2>2.&nbsp;&nbsp; &nbsp;Phonebook Upgrade</h2>
<p><strong>Add functionality to the phonebook</strong> from the previous task to <strong>print all contacts ordered lexicographically</strong> when receive the command &ldquo;ListAll&rdquo;.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>A Nakov +359888001122</p>
<p>A RoYaL(Ivan) 666</p>
<p>A Gero 5559393</p>
<p>A Simo 02/987665544</p>
<p>ListAll</p>
<p>END</p>
</td>
<td width="189">
<p>Gero -&gt; 5559393</p>
<p>Nakov -&gt; +359888001122</p>
<p>RoYaL(Ivan) -&gt; 666</p>
<p>Simo -&gt; 02/987665544</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li><strong>Variant I (slower):</strong> Sort all entries in the dictionary by key and print them.</li>
<li><strong>Variant II (faster):</strong> Keep the entries in more appropriate data structure that will keep them in sorted order for better performance.</li>
</ol>
<h2>3.&nbsp;&nbsp; A Miner Task</h2>
<p>You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even &ndash; quantity. Your task is to collect the resources and print them each on a new line.</p>
<p><strong>Print the resources and their quantities in format:</strong></p>
<p><strong>{resource} &ndash;&gt; {quantity}</strong></p>
<p>The quantities inputs will be in the range [1 &hellip; 2 000 000 000]</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="63">
<p><strong>Input</strong></p>
</td>
<td width="117">
<p><strong>Output</strong></p>
</td>
<td width="30">
<p><strong>&nbsp;</strong></p>
</td>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="116">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="63">
<p>Gold</p>
<p>155</p>
<p>Silver</p>
<p>10</p>
<p>Copper</p>
<p>17</p>
<p>stop</p>
</td>
<td width="117">
<p>Gold -&gt; 155</p>
<p>Silver -&gt; 10</p>
<p>Copper -&gt; 17</p>
</td>
<td width="30">
<p>&nbsp;</p>
</td>
<td width="68">
<p>gold</p>
<p>155</p>
<p>silver</p>
<p>10</p>
<p>copper</p>
<p>17</p>
<p>gold</p>
<p>15</p>
<p>stop</p>
</td>
<td width="116">
<p>gold -&gt; 170</p>
<p>silver -&gt; 10</p>
<p>copper -&gt; 17</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Fix Emails</h2>
<p>You are given a sequence of strings, each on a new line, <strong>until you receive the &ldquo;stop&rdquo; command</strong>. The first string is the <strong>name</strong> of a person. On the second line, you will receive their <strong>email</strong>. Your task is to <strong>collect</strong> their <strong>names</strong> and <strong>emails</strong>, and <strong>remove</strong> emails whose domain <strong>ends with</strong> "<strong>us</strong>" or "<strong>uk</strong>" (case insensitive). Print:</p>
<p><strong>{name} &ndash; &gt; {email}</strong></p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="182">
<p><strong>Input</strong></p>
</td>
<td width="309">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="182">
<p>Ivan</p>
<p>ivanivan@abv.bg</p>
<p>Petar Ivanov</p>
<p>petartudjarov@abv.bg</p>
<p>Mike Tyson</p>
<p>myke@gmail.us</p>
<p>stop</p>
</td>
<td width="309">
<p>Ivan -&gt; ivanivan@abv.bg</p>
<p>Petar Ivanov -&gt; petartudjarov@abv.bg</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Hands of Cards</h2>
<p>You are given a sequence of people and for every person what cards he draws from the deck. The input will be separate lines in the format:</p>
<ul>
<li>{personName}: {PT, PT, PT,&hellip; PT}</li>
</ul>
<p>Where <strong>P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A</strong>) is the power of the card and <strong>T (S, H, D, C)</strong> is the type. The input ends when a <strong>"JOKER"</strong> is drawn. The name can contain any ASCII symbol except <strong>':'</strong>. The input will always be valid and in the format described, there is no need to check it.</p>
<p>A single person <strong>cannot have more than one</strong> card with the <strong>same power and type</strong>, if they draw such a card they <strong>discard</strong> it. The people are playing with <strong>multiple decks</strong>. Each card has a value that is calculated by the <strong>power multiplied by the type</strong>. Powers <strong>2 to 10</strong> have the same value and <strong>J to A</strong> are <strong>11 to 14</strong>. Types are mapped to multipliers the following way (<strong>S -&gt; 4, H-&gt; 3, D -&gt; 2, C -&gt; 1</strong>).</p>
<p>Finally print out the total value each player has in his hand in the format:</p>
<ul>
<li>{personName}: {value}</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="272">
<p><strong>Input</strong></p>
</td>
<td width="327">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="272">
<p>Pesho: 2C, 4H, 9H, AS, QS</p>
<p>Slav: 3H, 10S, JC, KD, 5S, 10S</p>
<p>Peshoslav: QH, QC, QS, QD</p>
<p>Slav: 6H, 7S, KC, KD, 5S, 10C</p>
<p>Peshoslav: QH, QC, JS, JD, JC</p>
<p>Pesho: JD, JD, JD, JD, JD, JD</p>
<p>JOKER</p>
</td>
<td width="327">
<p>Pesho: 167</p>
<p>Slav: 175</p>
<p>Peshoslav: 197</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; * User Logs</h2>
<p>Marian is a famous system administrator. The person to overcome the security of his servers has not yet been born. However, there is a new type of threat where users flood the server with messages and are hard to be detected since they change their IP address all the time. Well, Marian is a system administrator and is not so into programming. Therefore, he needs a skillful programmer to track the user logs of his servers. You are the chosen one to help him!</p>
<p>You are given an input in the format:</p>
<ul>
<li><strong>IP=(IP.Address) message=(A&amp;sample&amp;message) user=(username)</strong></li>
</ul>
<p>Your task is to parse the IP and the username from the input and for <strong>every user</strong>, you have to display <strong>every IP</strong> from which the corresponding user has sent a message and the <strong>count of the messages</strong> sent with the corresponding IP. In the output, the usernames must be <strong>sorted alphabetically</strong> while their IP addresses should be displayed in the <strong>order of their first appearance. </strong>The output should be in the following format:</p>
<table width="0">
<tbody>
<tr>
<td width="196">
<p><strong>username: </strong></p>
<p><strong>IP =&gt; count, IP =&gt; count.</strong></p>
</td>
</tr>
</tbody>
</table>
<p>For example, given the following input:</p>
<ul>
<li>&ldquo;<strong>IP=192.23.30.40 message='Hello&amp;derps.' user=destroyer</strong>&rdquo;,</li>
</ul>
<p>You will have to get the username <strong>destroyer</strong> and the IP <strong>192.23.30.40</strong> and display it in the following format:</p>
<table width="0">
<tbody>
<tr>
<td width="196">
<p><strong>destroyer: </strong></p>
<p><strong>192.23.30.40 =&gt; 1.</strong></p>
</td>
</tr>
</tbody>
</table>
<p>The username <strong>destroyer</strong> has sent a message from IP <strong>192.23.30.40</strong> once.</p>
<p>Check the examples below. They will further clarify the assignment.</p>
<h3>Input</h3>
<p>The input comes from the console as <strong>varying number</strong> of lines. You have to parse every command until the command that follows is <strong>end.</strong> The input will be in the format displayed above, there is no need to check it explicitly.</p>
<h3>Output</h3>
<p>For every user found, you have to display each log in the format:</p>
<p><strong>username: </strong></p>
<p><strong>IP =&gt; count, IP =&gt; count&hellip;</strong></p>
<p>The IP addresses must be split with a comma, and each line of IP addresses must end with a dot.</p>
<h3>Constraints</h3>
<ul>
<li>The number of commands will be in the range <strong>[1..50]</strong></li>
<li>The IP addresses will be in the format of either<strong> IPv4</strong> or <strong>IPv6.</strong></li>
<li>The messages will be in the format: This&amp;is&amp;a&amp;message</li>
<li>The username will be a string with length in the range <strong>[3..50]</strong></li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="404">
<p><strong>Input</strong></p>
</td>
<td width="297">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="404">
<p>IP=192.23.30.40 message='Hello&amp;derps.' user=destroyer</p>
<p>IP=192.23.30.41 message='Hello&amp;yall.' user=destroyer</p>
<p>IP=192.23.30.40 message='Hello&amp;hi.' user=destroyer</p>
<p>IP=192.23.30.42 message='Hello&amp;Dudes.' user=destroyer</p>
<p>end</p>
</td>
<td width="297">
<p>destroyer:</p>
<p>192.23.30.40 =&gt; 2, 192.23.30.41 =&gt; 1, 192.23.30.42 =&gt; 1.</p>
</td>
</tr>
<tr>
<td width="404">IP=FE80:0000:0000:0000:0202:B3FF:FE1E:8329 message='Hey&amp;son' user=mother
<p>IP=192.23.33.40 message='Hi&amp;mom!' user=child0</p>
<p>IP=192.23.30.40 message='Hi&amp;from&amp;me&amp;too' user=child1</p>
<p>IP=192.23.30.42 message='spam' user=destroyer</p>
<p>IP=192.23.30.42 message='spam' user=destroyer</p>
<p>IP=192.23.50.40 message='' user=yetAnotherUsername</p>
<p>IP=192.23.50.40 message='comment' user=yetAnotherUsername</p>
<p>IP=192.23.155.40 message='Hello.' user=unknown</p>
<p>end</p>
</td>
<td width="297">
<p>child0:</p>
<p>192.23.33.40 =&gt; 1.</p>
<p>child1:</p>
<p>192.23.30.40 =&gt; 1.</p>
<p>destroyer:</p>
<p>192.23.30.42 =&gt; 2.</p>
<p>mother:</p>
<p>FE80:0000:0000:0000:0202:B3FF:FE1E:8329 =&gt; 1.</p>
<p>unknown:</p>
<p>192.23.155.40 =&gt; 1.</p>
<p>yetAnotherUsername:</p>
<p>192.23.50.40 =&gt; 2.</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; * Population Counter</h2>
<p>So many people! It&rsquo;s hard to count them all. But that&rsquo;s your job as a statistician. You get raw data for a given city and you need to aggregate it.</p>
<p>On each input line, you&rsquo;ll be given data in format: <strong>"</strong>city|country|population<strong>"</strong>. There will be <strong>no redundant whitespaces anywhere</strong> in the input. Aggregate the data <strong>by country and by city</strong> and print it on the console.</p>
<p>For each country, print its <strong>total population</strong> and on separate lines, the data for each of its <strong>cities</strong>. <strong>Countries should be ordered by their total population in descending order</strong> and within each country, the <strong>cities should be ordered by the same criterion</strong>.</p>
<p>If two countries/cities have the same population, keep them <strong>in the order in which they were entered.</strong> Check out the examples; follow the output format strictly!</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>It consists of a variable number of lines and ends when the command "<strong>report</strong>" is received.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console.</li>
<li>Print the aggregated data for each country and city in the format shown below.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The name of the city, country and the population count will be separated from each other by <strong>a pipe ('|')</strong>.</li>
<li>The <strong>number of input lines</strong> will be in the range [2 &hellip; 50].</li>
<li>A city-country pair will not be repeated.</li>
<li>The <strong>population count</strong> of each city will be an integer in the range [0 &hellip; 2 000 000 000].</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="456">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>Sofia|Bulgaria|1000000</p>
<p>report</p>
</td>
<td width="456">
<p>Bulgaria (total population: 1000000)</p>
<p>=&gt;Sofia: 1000000</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="456">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>Sofia|Bulgaria|1</p>
<p>Veliko Tarnovo|Bulgaria|2</p>
<p>London|UK|4</p>
<p>Rome|Italy|3</p>
<p>report</p>
</td>
<td width="456">
<p>UK (total population: 4)</p>
<p>=&gt;London: 4</p>
<p>Bulgaria (total population: 3)</p>
<p>=&gt;Veliko Tarnovo: 2</p>
<p>=&gt;Sofia: 1</p>
<p>Italy (total population: 3)</p>
<p>=&gt;Rome: 3</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; * Logs Aggregator</h2>
<p>You are given a sequence of access logs in format <strong>&lt;IP&gt; &lt;user&gt; &lt;duration&gt;</strong>. For example:</p>
<ul>
<li>168.0.11 peter 33</li>
<li>10.17.33 alex 12</li>
<li>10.17.35 peter 30</li>
<li>10.17.34 peter 120</li>
<li>10.17.34 peter 120</li>
<li>50.118.81 alex 46</li>
<li>50.118.81 alex 4</li>
</ul>
<p>Write a program to aggregate the logs data and print <strong>for each user</strong> the <strong>total duration</strong> of his sessions and a <strong>list of unique IP addresses</strong> in format "<strong>&lt;user&gt;: &lt;duration&gt; [&lt;IP<sub>1</sub>&gt;, &lt;IP<sub>2</sub>&gt;, &hellip;]</strong>". Order the <strong>users alphabetically</strong>. Order the <strong>IPs alphabetically</strong>. In our example, the output should be the following:</p>
<ul>
<li>alex: 62 [10.10.17.33, 212.50.118.81]</li>
<li>peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]</li>
</ul>
<h3>Input</h3>
<p>The input comes from the console. At the first line a number <strong>n</strong> stays which says how many log lines will follow. Each of the next n lines holds a log information in format <strong>&lt;IP&gt; &lt;user&gt; &lt;duration&gt;</strong>. The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print <strong>one line for each user</strong> (order users alphabetically). For each user print its sum of durations and all of his sessions' IPs, ordered alphabetically in format <strong>&lt;user&gt;: &lt;duration&gt; [&lt;IP<sub>1</sub>&gt;, &lt;IP<sub>2</sub>&gt;, &hellip;]</strong>. Remove any duplicated values in the IP addresses and order them alphabetically (like we order strings).</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>count</strong> of the order lines <strong>n</strong> is in the range [1&hellip;1000].</li>
<li>The <strong>&lt;IP&gt;</strong> is a standard IP address in format <strong>a.b.c.d</strong> where <strong>a</strong>, <strong>b</strong>, <strong>c</strong> and <strong>d</strong> are integers in the range [0&hellip;255].</li>
<li>The <strong>&lt;user&gt;</strong> consists of only of <strong>Latin characters</strong>, with length of [1&hellip;20].</li>
<li>The <strong>&lt;duration&gt;</strong> is an integer number in the range [1&hellip;1000].</li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="430">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>7</p>
<p>192.168.0.11 peter 33</p>
<p>10.10.17.33 alex 12</p>
<p>10.10.17.35 peter 30</p>
<p>10.10.17.34 peter 120</p>
<p>10.10.17.34 peter 120</p>
<p>212.50.118.81 alex 46</p>
<p>212.50.118.81 alex 4</p>
</td>
<td width="430">
<p>alex: 62 [10.10.17.33, 212.50.118.81]</p>
<p>peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]</p>
</td>
</tr>
<tr>
<td width="205">
<p>2</p>
<p>84.238.140.178 nakov 25</p>
<p>84.238.140.178 nakov 35</p>
</td>
<td width="430">
<p>nakov: 60 [84.238.140.178]</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; * Legendary Farming</h2>
<p>You&rsquo;ve beaten all the content and the last thing left to accomplish is own a legendary item. However, it&rsquo;s a tedious process and requires quite a bit of farming. Anyway, you are not too pretentious &ndash; any legendary will do. The possible items are:</p>
<ul>
<li><strong>Shadowmourne</strong> &ndash; requires <strong>250 Shards</strong>;</li>
<li><strong>Valanyr</strong> &ndash; requires <strong>250 Fragments</strong>;</li>
<li><strong>Dragonwrath </strong>&ndash; requires <strong>250 Motes</strong>;</li>
</ul>
<p><strong>Shards, Fragments </strong>and<strong> Motes </strong>are the <strong>key materials</strong>, all else is <strong>junk. </strong>You will be given lines of input, such as <br /> <strong>2 motes 3 ores 15 stones. </strong>Keep track of the <strong>key materials - </strong>the <strong>first</strong> that reaches the <strong>250 mark</strong> <strong>wins</strong> the <strong>race</strong>. At that point, print the corresponding legendary obtained. Then, print the <strong>remaining</strong> shards, fragments, motes, ordered by <strong>quantity</strong> in <strong>descending</strong> order, then by <strong>name</strong> in <strong>ascending </strong>order, each on a new line. Finally, print the collected <strong>junk</strong> items, in <strong>alphabetical </strong>order.</p>
<h3>Input</h3>
<ul>
<li>Each line of input is in format <strong>{quantity} {material} {quantity} {material} &hellip; {quantity} {material}</strong></li>
</ul>
<h3>Output</h3>
<ul>
<li>On the first line, print the obtained item in format <strong>{Legendary item} obtained!</strong></li>
<li>On the next three lines, print the remaining key materials in descending order by quantity
<ul>
<li>If two key materials have the same quantity, print them in alphabetical order</li>
</ul>
</li>
<li>On the final several lines, print the junk items in alphabetical order
<ul>
<li>All materials are printed in format <strong>{material}: {quantity}</strong></li>
<li>All output should be <strong>lowercase</strong>, except the first letter of the legendary</li>
</ul>
</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The quantity-material pairs are between 1 and 25 per line.</li>
<li>The number of lines is in range [1..10]</li>
<li>All materials are case-insensitive.</li>
<li>Allowed working time: 0.25s</li>
<li>Allowed memory: 16 MB</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="299">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="299">
<p>3 Motes 5 stones 5 Shards</p>
<p>6 leathers 255 fragments 7 Shards</p>
</td>
<td width="378">
<p>Valanyr obtained!</p>
<p>fragments: 5</p>
<p>shards: 5</p>
<p>motes: 3</p>
<p>leathers: 6</p>
<p>stones: 5</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>123 silver 6 shards 8 shards 5 motes</p>
<p>9 fangs 75 motes 103 MOTES 8 Shards</p>
<p>86 Motes 7 stones 19 silver</p>
</td>
<td width="372">
<p>Dragonwrath obtained!</p>
<p>shards: 22</p>
<p>motes: 19</p>
<p>fragments: 0</p>
<p>fangs: 9</p>
<p>silver: 123</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Сръбско Unleashed</h2>
<p>Admit it &ndash; the СРЪБСКО is your favorite sort of music. You never miss a concert and you have become quite the geek concerning everything involved with СРЪБСКО. You can&rsquo;t decide between all the singers you know who your favorite one is. One way to find out is to keep statistics of how much money their concerts make. Write a program that does all the boring calculations for you.</p>
<p>On each input line you&rsquo;ll be given data in format: <strong>"</strong>singer @venue ticketsPrice ticketsCount<strong>"</strong>. There will be <strong>no redundant whitespaces anywhere</strong> in the input. Aggregate the data <strong>by venue and by singer</strong>. For each venue, print the singer and the total amount of money his/her concerts have made on a separate line. <strong>Venues </strong>should be kept in the <strong>same order </strong>they were entered; the <strong>singers </strong>should be<strong> sorted by how much money </strong>they have made in<strong> descending order</strong>. If two singers have made the same amount of money, keep them <strong>in the order </strong>in which<strong> they were entered.</strong></p>
<p>Keep in mind that if a line is in incorrect format, it should be skipped and its data should not be added to the output. Each of the four tokens must be separated by <strong>a space</strong>, everything else is invalid. The venue should be denoted with <strong>@</strong> in front of it, such as @Sunny Beach</p>
<p><strong>SKIP THOSE</strong>: Ceca@Belgrade125 12378, Ceca @Belgrade12312 123</p>
<p>The singer and town name may consist of one to three words.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>It consists of a variable number of lines and ends when the command &ldquo;<strong>End</strong>" is received.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console.</li>
<li>Print the aggregated data for each venue and singer in the format shown below.</li>
<li>Format for singer lines is <strong>#{2*space}{singer}{space}-&gt;{space}{total money}</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The <strong>number of input lines</strong> will be in the range [2 &hellip; 50].</li>
<li>The <strong>ticket price</strong> will be an integer in the range [0 &hellip; 200].</li>
<li>The <strong>ticket count </strong>will be an integer in the range [0 &hellip; 100 000]</li>
<li><strong>Singers</strong> and <strong>venues</strong> are case sensitive</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>Lepa Brena @Sunny Beach 25 3500</p>
<p>Dragana @Sunny Beach 23 3500</p>
<p>Ceca @Sunny Beach 28 3500</p>
<p>Mile Kitic @Sunny Beach 21 3500</p>
<p>Ceca @Sunny Beach 35 3500</p>
<p>Ceca @Sunny Beach 70 15000</p>
<p>Saban Saolic @Sunny Beach 120 35000</p>
<p>End</p>
</td>
<td width="372">
<p>Sunny Beach</p>
<p>#&nbsp; Saban Saolic -&gt; 4200000</p>
<p>#&nbsp; Ceca -&gt; 1270500</p>
<p>#&nbsp; Lepa Brena -&gt; 87500</p>
<p>#&nbsp; Dragana -&gt; 80500</p>
<p>#&nbsp; Mile Kitic -&gt; 73500</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>Lepa Brena @Sunny Beach 25 3500</p>
<p>Dragana@Belgrade23 3500</p>
<p>Ceca @Sunny Beach 28 3500</p>
<p>Mile Kitic @Sunny Beach 21 3500</p>
<p>Ceca @Belgrade 35 3500</p>
<p>Ceca @Sunny Beach 70 15000</p>
<p>Saban Saolic @Sunny Beach 120 35000</p>
<p>End</p>
</td>
<td width="372">
<p>Sunny Beach</p>
<p>#&nbsp; Saban Saolic -&gt; 4200000</p>
<p>#&nbsp; Ceca -&gt; 1148000</p>
<p>#&nbsp; Lepa Brena -&gt; 87500</p>
<p>#&nbsp; Mile Kitic -&gt; 73500</p>
<p>Belgrade</p>
<p>#&nbsp; Ceca -&gt; 122500</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *** Dragon Army</h2>
<p>Heroes III is the best game ever. Everyone loves it and everyone plays it all the time. Stamat is no exclusion to this rule. His favorite units in the game are all <strong>types</strong> of dragons &ndash; black, red, gold, azure etc&hellip; He likes them so much that he gives them <strong>names</strong> and keeps logs of their <strong>stats</strong>: <strong>damage, health </strong>and<strong> armor</strong>. The process of aggregating all the data is quite tedious, so he would like to have a program doing it. Since he is no programmer, it&rsquo;s your task to help him</p>
<p>You need to categorize dragons by their <strong>type</strong>. For each dragon, identified by <strong>name, </strong>keep information about his <strong>stats. </strong>Type is <strong>preserved </strong>as in the order of input, but dragons are <strong>sorted</strong> alphabetically by name. For each type, you should also print the average <strong>damage</strong>, <strong>health</strong> and <strong>armor</strong> of the dragons. For each dragon, print his own stats.</p>
<p>There <strong>may</strong> be <strong>missing</strong> stats in the input, though. If a stat is missing you should assign it default values. Default values are as follows: health <strong>250</strong>, damage <strong>45</strong>, and armor <strong>10</strong>. Missing stat will be marked by <strong>null</strong>.</p>
<p>The input is in the following format <strong>{type} {name} {damage} {health} {armor}. </strong>Any of the integers may be assigned null value. See the examples below for better understanding of your task.</p>
<p>If the same dragon is added a second time, the new stats should <strong>overwrite</strong> the previous ones. Two dragons are considered <strong>equal</strong> if they match by <strong>both</strong> name and type.</p>
<h3>Input</h3>
<ul>
<li>On the first line, you are given number N -&gt; the number of dragons to follow</li>
<li>On the next N lines, you are given input in the above described format. There will be single space separating each element.</li>
</ul>
<h3>Output</h3>
<ul>
<li>Print the aggregated data on the console</li>
<li>For each type, print average stats of its dragons in format <strong>{Type}::({damage}/{health}/{armor})</strong></li>
<li>Damage, health and armor should be rounded to two digits after the decimal separator</li>
<li>For each dragon, print its stats in format <strong>-{Name} -&gt; damage: {damage}, health: {health}, armor: {armor}</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>N is in range [1&hellip;100]</li>
<li>The dragon type and name are one word only, starting with capital letter.</li>
<li>Damage health and armor are integers in range [0 &hellip; 100000] or <strong>null</strong></li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="274">
<p><strong>Input</strong></p>
</td>
<td width="421">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="274">
<p>5</p>
<p>Red Bazgargal 100 2500 25</p>
<p>Black Dargonax 200 3500 18</p>
<p>Red Obsidion 220 2200 35</p>
<p>Blue Kerizsa 60 2100 20</p>
<p>Blue Algordox 65 1800 50</p>
</td>
<td width="421">
<p>Red::(160.00/2350.00/30.00)</p>
<p>-Bazgargal -&gt; damage: 100, health: 2500, armor: 25</p>
<p>-Obsidion -&gt; damage: 220, health: 2200, armor: 35</p>
<p>Black::(200.00/3500.00/18.00)</p>
<p>-Dargonax -&gt; damage: 200, health: 3500, armor: 18</p>
<p>Blue::(62.50/1950.00/35.00)</p>
<p>-Algordox -&gt; damage: 65, health: 1800, armor: 50</p>
<p>-Kerizsa -&gt; damage: 60, health: 2100, armor: 20</p>
</td>
</tr>
<tr>
<td width="274">
<p><strong>Input</strong></p>
</td>
<td width="421">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="274">
<p>4</p>
<p>Gold Zzazx null 1000 10</p>
<p>Gold Traxx 500 null 0</p>
<p>Gold Xaarxx 250 1000 null</p>
<p>Gold Ardrax 100 1055 50</p>
</td>
<td width="421">
<p>Gold::(223.75/826.25/17.50)</p>
<p>-Ardrax -&gt; damage: 100, health: 1055, armor: 50</p>
<p>-Traxx -&gt; damage: 500, health: 250, armor: 0</p>
<p>-Xaarxx -&gt; damage: 250, health: 1000, armor: 10</p>
<p>-Zzazx -&gt; damage: 45, health: 1000, armor: 10</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
