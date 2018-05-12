<h1>Lab: Arrays</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/172/Arrays-Lab">https://judge.softuni.bg/Contests/172/Arrays-Lab</a>.</p>
<h2>1.&nbsp;&nbsp; Day of Week</h2>
<p>Enter a <strong>day number</strong> [1&hellip;7] and print the <strong>day name</strong> (in English) or &ldquo;<strong>Invalid Day!</strong>&rdquo;. Use an <strong>array of strings</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="123">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>1</p>
</td>
<td width="123">
<p>Monday</p>
</td>
</tr>
<tr>
<td width="64">
<p>2</p>
</td>
<td width="123">
<p>Tuesday</p>
</td>
</tr>
<tr>
<td width="64">
<p>7</p>
</td>
<td width="123">
<p>Sunday</p>
</td>
</tr>
<tr>
<td width="64">
<p>0</p>
</td>
<td width="123">
<p>Invalid Day!</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use an <strong>array of strings</strong> holding the day names: {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}.</li>
<li>Print the element at index (<strong>day-1</strong>) when it is in the range [1&hellip;7] or &ldquo;<strong>Invalid Day!</strong>&rdquo; otherwise.</li>
</ul>
<h2>2.&nbsp;&nbsp; Reverse an Array of Integers</h2>
<p>Write a program to read <strong>an array of integers</strong>, <strong>reverse</strong> it and <strong>print</strong> its elements. The input consists of a <strong>number</strong> n (the number of elements) + n integers, each as a separate line. Print the output on a single line (space separated).</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="104">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>3</strong></p>
<p>10</p>
<p>20</p>
<p>30</p>
</td>
<td width="104">
<p>30 20 10</p>
</td>
</tr>
<tr>
<td width="64">
<p><strong>4</strong></p>
<p>-1</p>
<p>20</p>
<p>99</p>
<p>5</p>
</td>
<td width="104">
<p>5 99 20 -1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>First, read the number n.</li>
<li>Allocate an array of n</li>
<li>Read the integers in a for-loop.</li>
<li>Instead of reversing the array, you can just pass through the elements from the last (<strong>n-1</strong>) to the first (<strong>0</strong>) with a reverse for-loop.</li>
</ul>
<h2>3.&nbsp;&nbsp; Last K Numbers Sums Sequence</h2>
<p>Enter two integers <strong>n</strong> and <strong>k</strong>. Generate and print the following sequence of n elements:</p>
<ul>
<li>The first element is: <strong>1</strong></li>
<li>All other elements = sum of the previous <strong>k</strong> elements (if less than <strong>k</strong> are available, sum all of them)</li>
<li>Example: n = <strong>9</strong>, k = <strong>5</strong> &agrave; <strong>120</strong> = 4 + 8 + 16 + 31 + 61</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="202">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>6</p>
<p>3</p>
</td>
<td width="202">
<p>1 1 2 4 7 13</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="51">
<p>8</p>
<p>2</p>
</td>
<td width="202">
<p>1 1 2 3 5 8 13 21</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="51">
<p>9</p>
<p>5</p>
</td>
<td width="202">
<p>1 1 2 4 8 16 31 61 120</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use an <strong>array of integers</strong> to hold the sequence.</li>
<li>Initially seq[0] = 1</li>
<li>Use two nested loops:
<ul>
<li>Loop through all elements i = <strong>1 &hellip; </strong>n</li>
<li>Sum the elements i<strong>-k &hellip; </strong>i<strong>-1</strong>: seq[i] = sum(seq[i<strong>-k &hellip; </strong>i<strong>-1</strong>])</li>
</ul>
</li>
</ul>
<h2>4.&nbsp;&nbsp; Triple Sum</h2>
<p>Write a program to read <strong>an array of integers</strong> and find all triples of elements <strong>a</strong>, <strong>b</strong> and <strong>c</strong>, such that <strong>a</strong> + <strong>b</strong> == <strong>c</strong> (where <strong>a</strong> stays to the left from <strong>b</strong>). Print &ldquo;<strong>No</strong>&rdquo; if no such triples exist.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="107">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>1 1 1 1</p>
</td>
<td width="107">
<p>No</p>
</td>
</tr>
<tr>
<td width="108">
<p>4 2 8 6</p>
</td>
<td width="107">
<p>4 + 2 == 6</p>
<p>2 + 6 == 8</p>
</td>
</tr>
<tr>
<td width="108">
<p>2 7 5 0</p>
</td>
<td width="107">
<p>2 + 5 == 7</p>
<p>2 + 0 == 2</p>
<p>7 + 0 == 7</p>
<p>5 + 0 == 5</p>
</td>
</tr>
<tr>
<td width="108">
<p>3 1 5 6 1 2</p>
</td>
<td width="107">
<p>3 + 2 == 5</p>
<p>1 + 5 == 6</p>
<p>1 + 1 == 2</p>
<p>1 + 2 == 3</p>
<p>5 + 1 == 6</p>
<p>1 + 2 == 3</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints:</h3>
<ul>
<li>Read the input numbers in array arr[].</li>
<li>Use nested loops to generate all pairs {a, b}, such that 0 &le; a &lt; b &lt; n.</li>
<li>Check whether arr[] contains the sum arr[a]+arr[b].</li>
</ul>
<h2>5.&nbsp;&nbsp; Rounding Numbers Away from Zero</h2>
<p>Write a program to read <strong>an array of real numbers</strong> (space separated values), <strong>round</strong> them to the nearest integer in &ldquo;<strong>away from 0</strong>&rdquo; style and <strong>print</strong> the output as in the examples below.</p>
<p>Rounding in &ldquo;<a href="https://www.mathsisfun.com/numbers/rounding-methods.html">away from zero</a>&rdquo; style means:</p>
<ul>
<li>To round to the nearest integer, e.g. 2.9 &agrave; 3; -1.75 &agrave; -2</li>
<li>In case the number is exactly in the middle of two integers (midpoint value), round it to the next integer which is away from the 0:</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="116">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>0.9 1.5 2.4 2.5 3.14</p>
</td>
<td width="116">
<p>0.9 =&gt; 1</p>
<p>1.5 =&gt; 2</p>
<p>2.4 =&gt; 2</p>
<p>2.5 =&gt; 3</p>
<p>3.14 =&gt; 3</p>
</td>
</tr>
<tr>
<td width="221">
<p>-5.01 -1.599 -2.5 -1.50 0</p>
</td>
<td width="116">
<p>-5.01 =&gt; -5</p>
<p>-1.599 =&gt; -2</p>
<p>-2.5 =&gt; -3</p>
<p>-1.50 =&gt; -2</p>
<p>0 =&gt; 0</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints:</h3>
<ul>
<li><strong>Approach I</strong>: Take the <strong>absolute value</strong> of each input number, add <strong>5</strong> and <strong>truncate</strong> the integral part. If the original number is negative, make the result also negative.</li>
<li><strong>Approach II</strong>: <strong>Search in Internet</strong> for <strong>&ldquo;rounding away from zero&rdquo; + C#</strong>. You should find a built-in C# method for rounding in many styles. Choose the &ldquo;away from zero&rdquo; rounding.</li>
</ul>
<h2>6.&nbsp;&nbsp; Reverse an Array of Strings</h2>
<p>Write a program to read <strong>an array of strings</strong>, <strong>reverse</strong> it and <strong>print</strong> its elements. The input consists of a sequence of space separated strings. Print the output on a single line (space separated).</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="100">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="100">
<p>a b c d e</p>
</td>
<td width="100">
<p>e d c b a</p>
</td>
</tr>
<tr>
<td width="100">
<p>-1 hi ho w</p>
</td>
<td width="100">
<p>w ho hi -1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read the array of strings.</li>
<li><strong>Exchange </strong>the <strong>first</strong> element (at index 0) with the <strong>last</strong> element (at index n-1).</li>
<li><strong>Exchange </strong>the <strong>second</strong> element (at index 1) with the element <strong>before the</strong> <strong>last</strong> (at index n-2).</li>
<li>Continue the same way until the middle of the array is reached.</li>
<li>Another, shorter approach, is to use the .Reverse() extension method from &ldquo;Linq&rdquo;.</li>
</ul>
<h2>7.&nbsp;&nbsp; Sum Arrays</h2>
<p>Write a program that reads two <strong>arrays of integers</strong> and sums them. When the arrays are not of the same size, duplicate the smaller array a few times.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="92">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
<td width="108">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1 2 3 4</p>
<p>2 3 4 5</p>
</td>
<td width="92">
<p>3 5 7 9</p>
<p>&nbsp;</p>
</td>
<td width="108">
<p>1 2 3 4 +</p>
<p>2 3 4 5 =</p>
<p>3 5 7 9</p>
</td>
</tr>
<tr>
<td width="92">
<p>1 2 3 4 5</p>
<p>2 3</p>
</td>
<td width="92">
<p>3 5 5 7 7</p>
<p>&nbsp;</p>
</td>
<td width="108">
<p>1 2 3 4 5 +</p>
<p>2 3 2 3 2 =</p>
<p>3 5 5 7 7</p>
</td>
</tr>
<tr>
<td width="92">
<p>5 4 3</p>
<p>2 3 1 4</p>
</td>
<td width="92">
<p>7 7 4 9</p>
<p>&nbsp;</p>
</td>
<td width="108">
<p>5 4 3 5 +</p>
<p>2 3 1 4 +</p>
<p>7 7 4 9</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Assume the first array arr1 has len1 elements and the second arr2 has len2</li>
<li>The result array will have max(len1, len2)</li>
<li>We sum array elements one by one (from the first to the last). To enable <strong>rotating</strong> (take the first element as next after the last), we use the position % length indexing: arr1[i % len1] and arr2[i % len2].</li>
</ul>
<h2>8.&nbsp;&nbsp; Condense Array to Number</h2>
<p>Write a program to read <strong>an array of integers</strong> and <strong>condense</strong> them by <strong>summing</strong> adjacent couples of elements until a <strong>single integer</strong> is obtained. For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="92">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="534">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>2 10 3</p>
</td>
<td width="62">
<p>25</p>
</td>
<td width="534">
<p>2 10 3 &agrave; 2+10 10+3 &agrave; 12 13 &agrave; 12 + 13 &agrave; 25</p>
</td>
</tr>
<tr>
<td width="92">
<p>5 0 4 1 2</p>
</td>
<td width="62">
<p>35</p>
</td>
<td width="534">
<p>5 0 4 1 2 &agrave; 5+0 0+4 4+1 1+2 &agrave; 5 4 5 3 &agrave; 5+4 4+5 5+3 &agrave; 9 9 8 &agrave; 9+9 9+8 &agrave; 18 17 &agrave; 18+17 &agrave; 35</p>
</td>
</tr>
<tr>
<td width="92">
<p>1</p>
</td>
<td width="62">
<p>1</p>
</td>
<td width="534">
<p>1 is already condensed to number</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>While we have more than one element in the array nums[], repeat the following:</p>
<ul>
<li>Allocate a new array condensed[] of size Length-1.</li>
<li>Sum the numbers from nums[] to condensed[]:
<ul>
<li>condensed[i] = nums[i] + nums[i+1]</li>
</ul>
</li>
<li>nums[] = condensed[]</li>
</ul>
<p>The process is illustrated below:</p>
<p>&nbsp;</p>
<h2>9.&nbsp;&nbsp; Extract Middle 1, 2 or 3 Elements</h2>
<p>Write a method to extract the <strong>middle</strong> <strong>1</strong>, <strong>2</strong> or <strong>3</strong> <strong>elements</strong> from array of <strong>n</strong> integers and <strong>print</strong> them.</p>
<ul>
<li><strong>n</strong> = 1 -&gt; <strong>1</strong> element</li>
<li>even <strong>n</strong> -&gt; <strong>2</strong> elements</li>
<li>odd <strong>n</strong> -&gt; <strong>3</strong> elements</li>
</ul>
<p>Create a program that reads an <strong>array of integers</strong> (space separated values) and prints the middle elements in the format shown in the examples.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p><strong>5</strong></p>
</td>
<td width="100">
<p>{ 5 }</p>
</td>
</tr>
<tr>
<td width="205">
<p>2 3 <strong>8 1</strong> 7 4</p>
</td>
<td width="100">
<p>{ 8, 1 }</p>
</td>
</tr>
<tr>
<td width="205">
<p>1 2 <strong>3 4 5</strong> 6 7</p>
</td>
<td width="100">
<p>{ 3, 4, 5 }</p>
</td>
</tr>
<tr>
<td width="205">
<p>10 20 30 <strong>40 50</strong> 60 70 80</p>
</td>
<td width="100">
<p>{ 40, 50 }</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Write different logic for each case (n = 1, even n, odd n)</li>
<li>n = 1 &agrave; take the first element</li>
<li>odd n &agrave; take elements n/2-1, n/2, n/2+1</li>
<li>even n &agrave; take elements n/2-1 and n/2</li>
</ul>
