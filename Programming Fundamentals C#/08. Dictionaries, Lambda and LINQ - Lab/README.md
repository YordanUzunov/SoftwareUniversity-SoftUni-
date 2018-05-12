<h1>Lab: Dictionaries, Lambda and LINQ</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>Check your solutions here: <a href="https://judge.softuni.bg/Contests/174/Dictionaries-Lambda-and-LINQ-Lab">https://judge.softuni.bg/Contests/174/Dictionaries-Lambda-and-LINQ-Lab</a>.</p>
<h1>&nbsp;&nbsp;&nbsp;&nbsp; I.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Associative Arrays</h1>
<h2>1.&nbsp;&nbsp; Count Real Numbers</h2>
<p>Read a <strong>list of real numbers</strong> and <strong>print them in ascending order</strong> along with their <strong>number of occurrences</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="133">
<p><strong>Input</strong></p>
</td>
<td width="82">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="25">
<p><strong>&nbsp;</strong></p>
</td>
<td width="101">
<p><strong>Input</strong></p>
</td>
<td width="82">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="126">
<p><strong>Input</strong></p>
</td>
<td width="89">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="133">
<p>8 2.5 2.5 8 2.5</p>
</td>
<td width="82">
<p>2.5 -&gt; 3</p>
<p>8 -&gt; 2</p>
</td>
<td width="101">
<p>1.5 5 1.5 3</p>
</td>
<td width="82">
<p>1.5 -&gt; 2</p>
<p>3 -&gt; 1</p>
<p>5 -&gt; 1</p>
</td>
<td width="126">
<p>-2 0.33 0.33 2</p>
</td>
<td width="89">
<p>-2 -&gt; 1</p>
<p>0.33 -&gt; 2</p>
<p>2 -&gt; 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use SortedDictionary&lt;double,int&gt; named counts.</li>
<li>Pass through each input number num and increase counts[num] (when num exists in the dictionary) or assign counts[num] = 1 (when num does not exist in the dictionary).</li>
<li>Pass through all numbers num in the dictionary (Keys) and print the number num and its count of occurrences counts[num].</li>
</ul>
<h2>2.&nbsp;&nbsp; Odd Occurrences</h2>
<p>Write a program that extracts from a given sequence of words all elements that present in it <strong>odd number of times</strong> (case-insensitive).</p>
<ul>
<li>Words are given in a single line, space separated.</li>
<li>Print the result elements in lowercase, in their order of appearance.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="265">
<p><strong>Input</strong></p>
</td>
<td width="128">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="265">
<p>Java C# PHP PHP JAVA C java</p>
</td>
<td width="128">
<p>java, c#, c</p>
</td>
</tr>
<tr>
<td width="265">
<p>3 5 5 hi pi HO Hi 5 ho 3 hi pi</p>
</td>
<td width="128">
<p>5, hi</p>
</td>
</tr>
<tr>
<td width="265">
<p>a a A SQL xx a xx a A a XX c</p>
</td>
<td width="128">
<p>a, sql, xx, c</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use a <strong>dictionary</strong> (string &agrave; int) to count the occurrences of each word (just like in the previous problem).</li>
<li>Pass through all <strong>key-value pairs</strong> in the dictionary and append to the results list all <strong>keys</strong> that have <strong>odd value</strong>.</li>
<li>Print the results list.</li>
</ul>
<h1>&nbsp; II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LINQ</h1>
<h2>3.&nbsp;&nbsp; Sum, Min, Max, Average</h2>
<p>Write a program to read <strong>n </strong>integers and print their <strong>sum</strong>, <strong>min</strong>, <strong>max</strong>, <strong>first</strong>, <strong>last</strong> and <strong>average</strong> values.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="142">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>5</strong></p>
<p>12</p>
<p>20</p>
<p>-5</p>
<p>37</p>
<p>8</p>
</td>
<td width="142">
<p>Sum = 72</p>
<p>Min = -5</p>
<p>Max = 37</p>
<p>Average = 14.4</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>4</strong></p>
<p>50</p>
<p>20</p>
<p>25</p>
<p>40</p>
</td>
<td width="142">
<p>Sum = 135</p>
<p>Min = 20</p>
<p>Max = 50</p>
<p>Average = 33.75</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Include the &ldquo;Linq&rdquo; namespace to enable aggregate functions.</li>
<li>Read the input array nums[].</li>
<li>Use Min(), nums.Max(), etc.</li>
</ul>
<h2>4.&nbsp;&nbsp; Largest 3 Numbers</h2>
<p>Read a <strong>list of real numbers</strong> and <strong>print largest 3 of them</strong>. If less than 3 numbers exit, print all of them.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="152">
<p><strong>Input</strong></p>
</td>
<td width="88">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="22">
<p><strong>&nbsp;</strong></p>
</td>
<td width="63">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>10 30 15 20 50 5</p>
</td>
<td width="88">
<p>50 30 20</p>
</td>
<td width="63">
<p>20 30</p>
</td>
<td width="66">
<p>30 20</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can use LINQ query like this: nums.OrderByDescending(x =&gt; x).Take(3).</p>
<h2>5.&nbsp;&nbsp; Short Words Sorted</h2>
<p>Read a <strong>text</strong>, extract its <strong>words</strong>, find all <strong>short words</strong> (less than 5 characters) and print them <strong>alphabetically</strong>, in <strong>lowercase</strong>.</p>
<ul>
<li>Use the following separators: .,:;()[]"'\/!?<em>(space)</em>.</li>
<li>Use case-insensitive matching.</li>
<li>Remove duplicated words.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="460">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="460">
<p>In SoftUni you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!</p>
</td>
<td width="227">
<p>2-3, and, c#, can, go, in, java, php, you</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>To extract the words from the input text, <strong>split</strong> by the specified separators.</li>
<li>Use a <strong>LINQ expression</strong>:
<ul>
<li>Filter by word length: Where(&hellip;)</li>
<li>Order by word: OrderBy(&hellip;)</li>
<li>Use <strong>distinct</strong> to avoid repeated words: Distinct().</li>
</ul>
</li>
</ul>
<h2>6.&nbsp;&nbsp; Fold and Sum</h2>
<p>Read an array of <strong>4*k integers</strong>, <strong>fold</strong> it like shown below, and <strong>print the sum</strong> of the upper and lower rows (<strong>2*k integers</strong>):</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="219">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
<td width="181">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="219">
<p>5 <strong>2 3</strong> 6</p>
</td>
<td width="132">
<p>7 9</p>
</td>
<td width="181">
<p>5 &nbsp;6 &nbsp;+</p>
<p>2 &nbsp;3 &nbsp;=</p>
<p>7 &nbsp;9</p>
</td>
</tr>
<tr>
<td width="219">
<p>1 2 <strong>3 4 5 6</strong> 7 8</p>
</td>
<td width="132">
<p>5 5 13 13</p>
</td>
<td width="181">
<p>2&nbsp; 1&nbsp; 8&nbsp; 7&nbsp; +</p>
<p>3&nbsp; 4&nbsp; 5&nbsp; 6&nbsp; =</p>
<p>5 &nbsp;5 13 13</p>
</td>
</tr>
<tr>
<td width="219">
<p>4 3 -1 <strong>2 5 0 1 9 8</strong> 6 7 -2</p>
</td>
<td width="132">
<p>1 8 4 -1 16 14</p>
</td>
<td width="181">
<p>-1&nbsp; 3&nbsp; 4 -2&nbsp; 7&nbsp; 6&nbsp; +</p>
<p>&nbsp;2&nbsp; 5&nbsp; 0&nbsp; 1&nbsp; 9&nbsp; 8&nbsp; =</p>
<p>&nbsp;1 &nbsp;8 &nbsp;4 -1 16 14</p>
</td>
</tr>
</tbody>
</table>
<p>Hints</p>
<p>Use a <strong>LINQ expression</strong>:</p>
<ul>
<li>Row 1, left part: take the <strong>first</strong> k numbers and <strong>reverse</strong>.</li>
<li>Row 1, right part: <strong>reverse</strong> and take the <strong>first</strong> k</li>
<li><strong>Concatenate</strong> the <strong>left</strong> and the <strong>right</strong> part of row 1.</li>
<li>Row 2: skip the <strong>first k</strong> numbers and take the next <strong>2*k</strong></li>
<li>Sum the arrays row1 and row2: varsum=Select((x,index)=&gt;x+row2[index]).</li>
</ul>
<p>&nbsp;</p>
