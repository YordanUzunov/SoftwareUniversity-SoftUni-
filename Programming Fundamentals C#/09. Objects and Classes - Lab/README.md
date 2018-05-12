<h1>Lab: Objects and Classes</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab">https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab</a>.</p>
<h1>&nbsp;&nbsp;&nbsp; I.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Using the Built-in .NET Classes</h1>
<h2>1.&nbsp;&nbsp; Day of Week</h2>
<p>You are given a <strong>date</strong> in format <strong>day-month-year</strong>. Calculate and print the <strong>day of week</strong> in <strong>English</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="100">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="100">
<p>18-04-2016</p>
</td>
<td width="92">
<p>Monday</p>
</td>
</tr>
<tr>
<td width="100">
<p>27-11-1996</p>
</td>
<td width="92">
<p>Wednesday</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Read the date as string</strong> from the Console.</li>
<li>Use the method <a href="https://msdn.microsoft.com/en-us/library/w2sa9yss(v=vs.110).aspx"><strong>ParseExact(string date, </strong><strong>format, </strong><strong>provider)</strong></a> to convert the input string to object of type DateTime. Use format <strong>&ldquo;</strong>d-M-yyyy<strong>&rdquo;</strong> and CultureInfo.InvariantCulture.
<ul>
<li>Alternatively split the input by &ldquo;-&ldquo; and you will get the day, month and year as numbers. Now you can create new DateTime(year, month, day).</li>
</ul>
</li>
<li>The newly created DateTime object has property <a href="https://msdn.microsoft.com/en-us/library/system.datetime.dayofweek(v=vs.110).aspx"><strong>DayOfWeek</strong></a>.</li>
</ul>
<h2>2.&nbsp;&nbsp; Randomize Words</h2>
<p>You are given a <strong>list of words in one line</strong>. <strong>Randomize their order</strong> and print each word at a separate line.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="282">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="293">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="282">
<p>Welcome to SoftUni and have fun learning programming</p>
</td>
<td width="113">
<p>learning</p>
<p>Welcome</p>
<p>SoftUni</p>
<p>and</p>
<p>fun</p>
<p>programming</p>
<p>have</p>
<p>to</p>
</td>
<td width="293">
<p>The order of the words in the output will be different after each program execution.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Split</strong> the input string by (space) and create an <strong>array of words</strong>.</li>
<li>Create a random number generator &ndash; an object rnd of type <strong>Random</strong>.</li>
<li>In a<strong> for-loop exchange each number</strong> at positions 0, 1, &hellip; Length-1 by a number at <strong>random position</strong>. To generate a random number in range use <strong>rnd.</strong><a href="https://msdn.microsoft.com/en-us/library/2dx6wyd4(v=vs.110).aspx"><strong>Next(minValue, maxValue)</strong></a>. Note that by definition minValue is <strong>inclusive</strong>, but maxValue is <strong>exclusive</strong>.</li>
<li>Print each word in the array on new line.</li>
</ul>
<h2>3.&nbsp;&nbsp; Big Factorial</h2>
<p>Calculate and print n! (n factorial) for very big integer n (e.g. 1000).</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="536">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>5</p>
</td>
<td width="536">
<p>120</p>
</td>
</tr>
<tr>
<td width="51">
<p>50</p>
</td>
<td width="536">
<p>3041409320171337804361260816606476884437764156896051200000000000</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Use the class BigInteger from the built-in .NET library System.Numerics.dll.</p>
<ol>
<li>Add reference to Numerics.dll.</li>
<li>Import the namespace &ldquo;Numerics&rdquo;:</li>
<li>Use the type BigInteger instead of long or decimal to keep the factorial value:</li>
</ol>
<h1>&nbsp;II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Defining Simple Classes</h1>
<h2>4.&nbsp;&nbsp; Distance Between Points</h2>
<p>Write a method to calculate the distance between two points <strong>p<sub>1</sub></strong> {<strong>x<sub>1</sub></strong>, <strong>y<sub>1</sub></strong>} and <strong>p<sub>2</sub></strong> {<strong>x<sub>2</sub></strong>, <strong>y<sub>2</sub></strong>}. Write a program to read <strong>two points</strong> (given as two integers) and print the <strong>Euclidean distance</strong> between them.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="68">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="52">
<p>3 4</p>
<p>6 8</p>
</td>
<td width="68">
<p>5.000</p>
</td>
</tr>
<tr>
<td width="52">
<p>3 4</p>
<p>5 4</p>
</td>
<td width="68">
<p>2.000</p>
</td>
</tr>
<tr>
<td width="52">
<p>8 -2</p>
<p>-1 5</p>
</td>
<td width="68">
<p>11.402</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create a <strong>class </strong>Point holding properties X and Y.</li>
<li>Write a method CalcDistance(Pointp1,Pointp2) that returns the distance between the given points &ndash; a double</li>
<li>Use <a href="http://www.cut-the-knot.org/pythagoras/DistanceFormula.shtml">this formula</a> to calculate the distance between two points. How it works?
<ul>
<li>Let's have two points <strong>p<sub>1</sub></strong> {<strong>x<sub>1</sub></strong>, <strong>y<sub>1</sub></strong>} and <strong>p<sub>2</sub></strong> {<strong>x<sub>2</sub></strong>, <strong>y<sub>2</sub></strong>}</li>
<li>Draw a right-angled triangle</li>
<li>Side<strong> a = |x<sub>1</sub> - x<sub>2</sub>|</strong></li>
<li>Side<strong> b = |y<sub>1</sub> - y<sub>2</sub>|</strong></li>
<li>Distance == side <strong>c</strong> (hypotenuse)</li>
<li><strong>c<sup>2</sup></strong> = <strong>a<sup>2</sup></strong> + <strong>b<sup>2</sup></strong> (Pythagorean theorem)</li>
<li>Distance = <strong>c</strong> =</li>
</ul>
</li>
<li>You can use <a href="https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.90).aspx"><strong>Sqrt(number)</strong></a> method for calculating a square root.</li>
</ul>
<h2>5.&nbsp;&nbsp; Closest Two Points</h2>
<p>Write a program to read <strong>n </strong>points and find the <strong>closest two</strong> of them.</p>
<h3>Input</h3>
<p>The <strong>input</strong> holds the number of points n and n lines, each holding a point {X and Y coordinate}.</p>
<h3>Output</h3>
<ul>
<li>The <strong>output</strong> holds the shortest distance and the closest two points.</li>
<li>If several pairs of points are equally close, print <strong>the first</strong> of them (from top to bottom).</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="251">
<p><strong>Visualization</strong></p>
</td>
<td width="293">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="68">
<p>4</p>
<p>3 4</p>
<p>6 8</p>
<p>2 5</p>
<p>-1 3</p>
</td>
<td width="76">
<p>1.414</p>
<p>(3, 4)</p>
<p>(2, 5)</p>
</td>
<td width="251">&nbsp;</td>
<td width="293">
<p>The closest two points are <strong>{3, 4}</strong> and <strong>{2, 5}</strong> at distance 1.4142135623731 &asymp; <strong>1.414</strong>.</p>
</td>
</tr>
<tr>
<td width="68">
<p>3</p>
<p>12 -30</p>
<p>6 18</p>
<p>6 18</p>
</td>
<td width="76">
<p>0.000</p>
<p>(6, 18)</p>
<p>(6, 18)</p>
</td>
<td width="251">&nbsp;</td>
<td width="293">
<p>Two of the points have the same coordinates <strong>{6, 18}</strong>, so the distance between them is <strong>0</strong>.</p>
</td>
</tr>
<tr>
<td width="68">
<p>3</p>
<p>1 1</p>
<p>2 2</p>
<p>3 3</p>
</td>
<td width="76">
<p>1.414</p>
<p>(1, 1)</p>
<p>(2, 2)</p>
</td>
<td width="251">&nbsp;</td>
<td width="293">
<p>The pairs of points {{1, 1}, {2, 2}} and {{2,2}, {3,3}} stay at the same distance, but the first pair is {<strong>{1, 1}</strong>, <strong>{2, 2}</strong>}. The distance between them is 1.4142135623731 &asymp; <strong>1.414</strong>.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use the <strong>class</strong> Point you created in the previous task.</li>
<li>Create an array Point[]points that will keep all points.</li>
<li>Create a method Point[]FindClosestPoints(Point[]points) that will check distance <strong>between every two pairs </strong>from the array of points and returns the two closest points in a new array.</li>
<li>Print the <strong>closest distance</strong> and the <strong>coordinates</strong> of the two closest points.</li>
</ul>
<h2>6.&nbsp;&nbsp; Rectangle Position</h2>
<p>Write a program to <strong>read two rectangles</strong> {left, top, width, height} and print whether the first is inside the second.</p>
<p>The input is given as two lines, each holding a rectangle, described by 4 integers: <strong>left</strong>, <strong>top</strong>, <strong>width</strong> and <strong>height</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="92">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
<td width="239">
<p><strong>Visualization</strong></p>
</td>
<td width="266">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>4 -3 6 4</p>
<p>2 -3 10 6</p>
</td>
<td width="100">
<p>Inside</p>
</td>
<td width="239">&nbsp;</td>
<td width="266">
<p>The first rectangle stays <strong>inside</strong> the second.</p>
</td>
</tr>
<tr>
<td width="92">
<p>2 -3 10 6</p>
<p>4 -5 6 10</p>
</td>
<td width="100">
<p>Not inside</p>
</td>
<td width="239">&nbsp;</td>
<td width="266">
<p>The rectangles intersect, no the first is <strong>not insid</strong>e the second.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create a class Rectangle holding properties Top, Left, Width and Height.</li>
<li>Define calculated properties Right and Bottom.</li>
<li>Define a method boolIsInside(Rectangler). A rectangle r1 is inside another rectangle r2 when:
<ul>
<li>Left &ge; r2.Left</li>
<li>Right &le; r2.Right</li>
<li>Top &le; r2.Top</li>
<li>Bottom &le; r2.Bottom</li>
</ul>
</li>
<li>Create a method to <strong>read</strong> a Rectangle.</li>
<li>Combine all methods into a single program.</li>
</ul>
<h2>7.&nbsp;&nbsp; Sales Report</h2>
<p>Write a class Sale holding the following data: <strong>town</strong>, <strong>product</strong>, <strong>price</strong>, <strong>quantity</strong>. Read a <strong>list of sales</strong> and calculate and print the <strong>total sales by town</strong> as shown in the output. Order <strong>alphabetically</strong> the towns in the output.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="148">
<p><strong>Output</strong></p>
</td>
<td width="335">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>5</p>
<p>Sofia beer 1.20 160</p>
<p>Varna chocolate 2.35 86</p>
<p>Sofia coffee 0.40 853</p>
<p>Varna apple 0.86 75.44</p>
<p>Plovdiv beer 1.10 88</p>
</td>
<td width="148">
<p>Plovdiv -&gt; 96.80</p>
<p>Sofia -&gt; 533.20</p>
<p>Varna -&gt; 266.98</p>
</td>
<td width="335">
<p>Plovdiv -&gt; 1.10 * 88 = 96.80</p>
<p>Sofia -&gt; 1.20 * 160 + 0.40 * 853 = 533.20</p>
<p>Varna -&gt; 2.35 * 86 + 0.86 * 75.44 = 266.98</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Define the class Sale holding properties Town, Product, Price and Quantity.</li>
<li>Create a method ReadSale() that reads a sale data line from the console and returns Sale It could split the input line by space and parse the price and quantity.</li>
<li>To read the input, first read an integer n, then n times read a sale.</li>
<li><strong>Approach I &ndash; LINQ</strong>
<ul>
<li>Using <strong>LINQ</strong> select the <strong>distinct town names</strong> from the array of sales and sort them.</li>
<li>For <strong>each town</strong> in a loop use a LINQ query to calculate the <strong>total sales</strong> (aggregate the sum of <strong>price</strong> * <strong>quantity</strong> for all sales by the current town).</li>
</ul>
</li>
<li><strong>Approach II &ndash; Dictionary {town </strong><strong>&agrave; sales}</strong>
<ul>
<li>Define a dictionary SortedDictionary&lt;string,decimal&gt;salesByTown to hold the total sales for each town.</li>
<li>Pass through all the sales from the input in a loop and for each sale, add its <strong>price</strong> * <strong>quantity</strong> to the salesByTown for the current town. If the town is missing in the dictionary, first create it.</li>
<li>Finally print the dictionary.</li>
</ul>
</li>
<li>The second approach is faster, because it scans the array of sales only once.</li>
</ul>
<p>&nbsp;</p>
