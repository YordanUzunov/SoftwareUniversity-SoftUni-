<h1>Exercises: Files, Directories and Exceptions</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>This exercise does <strong>NOT</strong> have <strong>Judge Contest</strong>. That means that you will need to <strong>create input and output files</strong> from the examples and <strong>test</strong> the solutions on your own.</p>
<h2>1.&nbsp;&nbsp; &nbsp;Most Frequent Number</h2>
<p>Write a program that finds the <strong>most frequent number</strong> in a given sequence of numbers.</p>
<ul>
<li>Numbers will be in the range <strong>[0&hellip;</strong><strong>65535]</strong>.</li>
<li>In case of multiple numbers with the same maximum frequency, print the <strong>leftmost</strong></li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="216">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="421">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="216">
<p><strong>4</strong> 1 1 <strong>4</strong> 2 3 <strong>4 4</strong> 1 2 <strong>4</strong> 9 3</p>
</td>
<td width="62">
<p>4</p>
</td>
<td width="421">
<p>The number <strong>4</strong> is the most frequent (occurs 5 times)</p>
</td>
</tr>
<tr>
<td width="216">
<p><strong>2 2 2 2</strong> 1 <strong>2 2 2</strong></p>
</td>
<td width="62">
<p>2</p>
</td>
<td width="421">
<p>The number <strong>2</strong> is the most frequent (occurs 7 times)</p>
</td>
</tr>
<tr>
<td width="216">
<p><strong>7 7 7</strong> 0 2 2 2 0 10 10 10</p>
</td>
<td width="62">
<p>7</p>
</td>
<td width="421">
<p>The numbers <strong>2</strong>, <strong>7</strong> and <strong>10</strong> have the same maximal frequence (each occurs 3 times). The leftmost of them is <strong>7</strong>.</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Index of Letters</h2>
<p>Write a program that creates an array containing all letters from the alphabet (<strong>a</strong>-<strong>z</strong>). Read a lowercase word from the console and print the <strong>index of each of its letters in the letters array</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>abcz</p>
</td>
<td width="76">
<p>a -&gt; 0</p>
<p>b -&gt; 1</p>
<p>c -&gt; 2</p>
<p>z -&gt; 25</p>
</td>
</tr>
<tr>
<td width="76">
<p>softuni</p>
</td>
<td width="76">
<p>s -&gt; 18</p>
<p>o -&gt; 14</p>
<p>f -&gt; 5</p>
<p>t -&gt; 19</p>
<p>u -&gt; 20</p>
<p>n -&gt; 13</p>
<p>i -&gt; 8</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Equal Sums</h2>
<p>Write a program that determines if there <strong>exists an element in the array</strong> such that the <strong>sum of the elements on its left</strong> is <strong>equal</strong> to the <strong>sum of the elements on its right</strong>. If there are <strong>no elements to the left / right</strong>, their <strong>sum is considered to be 0</strong>. Print the <strong>index</strong> that satisfies the required condition or <strong>&ldquo;no&rdquo;</strong> if there is no such index.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="422">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>1 2 3 3</p>
</td>
<td width="62">
<p>2</p>
</td>
<td width="422">
<p>At a[2] -&gt; left sum = 3, right sum = 3</p>
<p>a[0] + a[1] = a[3]</p>
</td>
</tr>
<tr>
<td width="205">
<p>1 2</p>
</td>
<td width="62">
<p>no</p>
</td>
<td width="422">
<p>At a[0] -&gt; left sum = 0, right sum = 2</p>
<p>At a[1] -&gt; left sum = 1, right sum = 0</p>
<p>No such index exists</p>
</td>
</tr>
<tr>
<td width="205">
<p>1</p>
</td>
<td width="62">
<p>0</p>
</td>
<td width="422">
<p>At a[0] -&gt; left sum = 0, right sum = 0</p>
</td>
</tr>
<tr>
<td width="205">
<p>1 2 3</p>
</td>
<td width="62">
<p>no</p>
</td>
<td width="422">
<p>No such index exists</p>
</td>
</tr>
<tr>
<td width="205">
<p>10 5 5 99 3 4 2 5 1 1 4</p>
</td>
<td width="62">
<p>3</p>
</td>
<td width="422">
<p>At a[3] -&gt; left sum = 20, right sum = 20</p>
<p>a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Max Sequence of Equal Elements</h2>
<p>Read a <strong>list of integers</strong> and find the <strong>longest sequence of equal elements</strong>. If several exist, print the <strong>leftmost</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>3 4 4 <strong>5 5 5</strong> 2 2</p>
</td>
<td width="62">
<p>5 5 5</p>
</td>
</tr>
<tr>
<td width="140">
<p><strong>7 7</strong> 4 4 5 5 3 3</p>
</td>
<td width="62">
<p>7 7</p>
</td>
</tr>
<tr>
<td width="140">
<p>1 2 <strong>3 3</strong></p>
</td>
<td width="62">
<p>3 3</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Scan positions <strong>p</strong> from left to right and keep the <strong>start</strong> and <strong>length</strong> of the current sequence of equal numbers ending at <strong>p</strong>.</li>
<li>Keep also the currently best (longest) sequence (bestStart + bestLength) and update it after each step.</li>
</ul>
<h2>5.&nbsp;&nbsp; A Miner Task</h2>
<p>You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on), and every even &ndash; quantity. Your task is to <strong>collect</strong> the resources and <strong>print</strong> them each on a new line. <strong>Print the resources and their quantities in format</strong>:</p>
<p><strong>{resource} &ndash;&gt; {quantity}</strong></p>
<p>The quantities inputs will be in the range <strong>[1 &hellip; 2 000 000 000]</strong></p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="117">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="68">
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
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Fix Emails</h2>
<p>You are given a sequence of strings, each on a new line, <strong>until you receive &ldquo;stop&rdquo; command</strong>. First string is a name of a person. On the second line, you receive his email. Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive). Print:</p>
<p><strong>{name} &ndash; &gt; {email}</strong></p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="181">
<p><strong>Input</strong></p>
</td>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="181">
<p>Ivan</p>
<p>ivanivan@abv.bg</p>
<p>Petar Ivanov</p>
<p>petartudjarov@abv.bg</p>
<p>Mike Tyson</p>
<p>myke@gmail.us</p>
<p>stop</p>
</td>
<td width="310">
<p>Ivan -&gt; ivanivan@abv.bg</p>
<p>Petar Ivanov -&gt; petartudjarov@abv.bg</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Advertisement Message</h2>
<p>Write a program that <strong>generate random fake advertisement message</strong> to extol some product. The messages must consist of 4 parts: laudatory <strong>phrase</strong> + <strong>event</strong> + <strong>author</strong> + <strong>city</strong>. Use the following predefined parts:</p>
<ul>
<li><strong>Phrases</strong> &ndash; {&ldquo;Excellent product.&rdquo;, &ldquo;Such a great product.&rdquo;, &ldquo;I always use that product.&rdquo;, &ldquo;Best product of its category.&rdquo;, &ldquo;Exceptional product.&rdquo;, &ldquo;I can&rsquo;t live without this product.&rdquo;}</li>
<li><strong>Events</strong> &ndash; {&ldquo;Now I feel good.&rdquo;, &ldquo;I have succeeded with this product.&rdquo;, &ldquo;Makes miracles. I am happy of the results!&rdquo;, &ldquo;I cannot believe but now I feel awesome.&rdquo;, &rdquo;Try it yourself, I am very satisfied.&rdquo;, &ldquo;I feel great!&rdquo;}</li>
<li><strong>Author</strong> &ndash; {&ldquo;Diana&rdquo;, &ldquo;Petya&rdquo;, &ldquo;Stella&rdquo;, &ldquo;Elena&rdquo;, &ldquo;Katya&rdquo;, &ldquo;Iva&rdquo;, &ldquo;Annie&rdquo;, &ldquo;Eva&rdquo;}</li>
<li><strong>Cities</strong> &ndash; {&ldquo;Burgas&rdquo;, &ldquo;Sofia&rdquo;, &ldquo;Plovdiv&rdquo;, &ldquo;Varna&rdquo;, &ldquo;Ruse&rdquo;}</li>
</ul>
<p>The format of the output message is: <strong>{phrase} {event} {author} &ndash; {city}</strong>.</p>
<p>As an input, you take the <strong>number of messages</strong> to be generated. Print each random message at a separate line.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="608">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>3</p>
</td>
<td width="608">
<p>Such a great product. Now I feel good. Elena &ndash; Ruse</p>
<p>Excelent product. Makes miracles. I am happy of the results! Katya &ndash; Varna</p>
<p>Best product of its category. That makes miracles. Eva - Sofia</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Hold the phrases, events, authors and towns in 4 arrays of strings.</li>
<li>Create Random object and generate 4 random numbers each in its range:
<ul>
<li>phraseIndex &agrave; &shy;[0, phrases.Length]</li>
<li>eventIndex &agrave; [0, events.Length]</li>
<li>authorIndex &agrave; [0, authors.Length]</li>
<li>townIndex &agrave; [0, towns.Length]</li>
</ul>
</li>
<li>Get one<strong> random element </strong>from each of the four arrays and <strong>compose a message</strong> in the required format.</li>
</ul>
<h2>8.&nbsp;&nbsp; Average Grades</h2>
<p>Define a class Student, which holds the following information about students: <strong>name</strong>, <strong>list of grades</strong> and <strong>average grade</strong> (calculated property, read-only). A single grade will be in range [2&hellip;6], e.g. 3.25 or 5.50.</p>
<p>Read a <strong>list of students</strong> and print the students that have <strong>average grade &ge; 5.00</strong> ordered <strong>by name</strong> (ascending), then by <strong>average</strong> <strong>grade </strong>(descending). Print the student name and the calculated average grade.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>3</p>
<p>Ivan 3</p>
<p>Todor 5 5 6</p>
<p>Diana 6 5.50</p>
</td>
<td width="165">
<p>Diana -&gt; 5.75</p>
<p>Todor -&gt; 5.33</p>
</td>
</tr>
<tr>
<td width="205">
<p>6</p>
<p>Petar 3 5 4 3 2 5 6 2 6</p>
<p>Mitko 6 6 5 6 5 6</p>
<p>Gosho 6 6 6 6 6 6</p>
<p>Ani 6 5 6 5 6 5 6 5</p>
<p>Iva 4 5 4 3 4 5 2 2 4</p>
<p>Ani 5.50 5.25 6.00</p>
</td>
<td width="165">
<p>Ani -&gt; 5.58</p>
<p>Ani -&gt; 5.50</p>
<p>Gosho -&gt; 6.00</p>
<p>Mitko -&gt; 5.67</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create class Student with properties Name (string), Grades (double[]), and property AverageGrade (calculated by LINQ as Average(), read-only).</li>
<li>Make a <strong>list of students</strong> and <strong>filter with LINQ </strong>all students that has average grade &gt;= 00.</li>
<li>Print the filtered students <strong>ordered by name</strong> in ascending order, then by <strong>average grade</strong> in descending order.</li>
</ul>
<h2>9.&nbsp;&nbsp; Book Library</h2>
<p>To model a <strong>book library</strong>, define classes to hold a <strong>book</strong> and a <strong>library</strong>. The library must have a <strong>name</strong> and a <strong>list of books</strong>. The books must contain the <strong>title</strong>, <strong>author</strong>,<strong> publisher</strong>,<strong> release date</strong>,<strong> ISBN-number </strong>and<strong> price. </strong></p>
<p>Read a <strong>list of books</strong>, add them to the library and print the <strong>total sum of prices by author</strong>, ordered <strong>descending by price</strong> and <strong>then by author&rsquo;s name lexicographically</strong>.</p>
<p>Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="439">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="439">
<p>5</p>
<p>LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</p>
<p>Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25</p>
<p>HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50</p>
<p>HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00</p>
<p>AC OBowden PenguinBooks 20.11.2009 0395082555 14.00</p>
</td>
<td width="165">
<p>Tolkien -&gt; 40.25</p>
<p>JKRowling -&gt; 35.50</p>
<p>OBowden -&gt; 14.00</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create classes Book and Library with all the mentioned above properties:</li>
<li><strong>Create</strong> an object of type Library.</li>
<li><strong>Read the input</strong> and create a Book object for each book in the input.</li>
<li>Create a <strong>LINQ</strong> query that will <strong>sum the prices by author</strong>, <strong>order the results</strong> as requested.</li>
<li><strong>Print</strong> the results.</li>
</ul>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Book Library Modification</h2>
<p>Use the classes from the previous problem and make a program that <strong>read a list of books</strong> and <strong>print all titles</strong> <strong>released after given date</strong> ordered <strong>by date</strong> and then <strong>by</strong> <strong>title lexicographically</strong>. The date is given if format &ldquo;<strong>day-month-year</strong>&rdquo; at the last line in the input.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="447">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="447">
<p>5</p>
<p>LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</p>
<p>Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25</p>
<p>HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50</p>
<p>HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00</p>
<p>AC OBowden PenguinBooks 20.11.2009 0395082555 14.00</p>
<p>30.07.1954</p>
</td>
<td width="165">
<p>HP1 -&gt; 26.06.1997</p>
<p>HP7 -&gt; 21.07.2007</p>
<p>AC -&gt; 20.11.2009</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
