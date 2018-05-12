<h1>Exercises: Arrays</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/207/Arrays-Exercises">https://judge.softuni.bg/Contests/207/Arrays-Exercises</a>.</p>
<h2>1.&nbsp;&nbsp; Largest Common End</h2>
<p>Read <strong>two</strong> <strong>arrays</strong> <strong>of</strong> <strong>words</strong> and find the length of the <strong>largest common end</strong> (left or right).</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="243">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="340">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="243">
<p><strong>hi php java</strong> csharp sql html css js</p>
<p><strong>hi php java</strong> js softuni nakov java learn</p>
</td>
<td width="62">
<p>3</p>
</td>
<td width="340">
<p>The largest common end is at the left: <strong>hi php java</strong></p>
</td>
</tr>
<tr>
<td width="243">
<p>hi php java xml csharp <strong>sql html css js</strong></p>
<p>nakov java <strong>sql html css js</strong></p>
</td>
<td width="62">
<p>4</p>
</td>
<td width="340">
<p>The largest common end is at the right: <strong>sql html css js</strong></p>
</td>
</tr>
<tr>
<td width="243">
<p>I love programming</p>
<p>Learn Java or C#</p>
</td>
<td width="62">
<p>0</p>
</td>
<td width="340">
<p>No common words at the left and right</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Scan the arrays from left to right until the end of the shorter is reached and count the equal elements.</li>
<li>Scan the arrays form right to left until the start of the shorter is reached.</li>
<li>Keep the start position and the length of the longest equal start / end.</li>
</ul>
<h2>2.&nbsp;&nbsp; Rotate and Sum</h2>
<p>To &ldquo;<strong>rotate</strong> an array on the right&rdquo; means to move its last element first: {1, 2, 3} &agrave; {3, 1, 2}.</p>
<p>Write a program to read an array of <strong>n</strong> <strong>integers</strong> (space separated on a single line) and an integer <strong>k</strong>, rotate the array right <strong>k</strong> <strong>times</strong> and sum the obtained arrays after each rotation as shown below.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="92">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
<td width="237">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>3 2 4 -1</p>
<p>2</p>
</td>
<td width="108">
<p>3 2 5 6</p>
<p>&nbsp;</p>
</td>
<td width="237">
<p>rotated1[] = -1 &nbsp;3 &nbsp;2 &nbsp;4</p>
<p>rotated2[] =&nbsp; 4 -1 &nbsp;3 &nbsp;2</p>
<p>sum[] =&nbsp; 3&nbsp; 2 &nbsp;5 &nbsp;6</p>
</td>
</tr>
<tr>
<td width="92">
<p>1 2 3</p>
<p>1</p>
</td>
<td width="108">
<p>3 1 2</p>
<p>&nbsp;</p>
</td>
<td width="237">
<p>rotated1[] = 3 1 2</p>
<p>sum[] = 3 1 2</p>
</td>
</tr>
<tr>
<td width="92">
<p>1 2 3 4 5</p>
<p>3</p>
</td>
<td width="108">
<p>12 10 8 6 9</p>
<p>&nbsp;</p>
</td>
<td width="237">
<p>rotated1[] = &nbsp;5 &nbsp;1 &nbsp;2 &nbsp;3 &nbsp;4</p>
<p>rotated2[] = &nbsp;4 &nbsp;5 &nbsp;1 &nbsp;2 &nbsp;3</p>
<p>rotated3[] = &nbsp;3&nbsp; 4&nbsp; 5&nbsp; 1&nbsp; 2</p>
<p>sum[] = 12 10&nbsp; 8&nbsp; 6&nbsp; 9</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>After r rotations the element at position i goes to position (i + r) % n.</li>
<li>The sum[] array can be calculated by two nested loops: for r = 1 &hellip; k; for i = 0 &hellip; n-1.</li>
</ul>
<h2>3.&nbsp;&nbsp; Fold and Sum</h2>
<p>Read an array of <strong>4*k</strong> integers, fold it like shown below, and print the sum of the upper and lower two rows (each holding 2 * k integers):</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="221">
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
<td width="221">
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
<td width="221">
<p>1 2 <strong>3 4 5 6</strong> 7 8</p>
</td>
<td width="132">
<p>5 5 13 13</p>
</td>
<td width="181">
<p>2&nbsp; 1&nbsp; 8&nbsp; 7 &nbsp;+</p>
<p>3&nbsp; 4&nbsp; 5&nbsp; 6 &nbsp;=</p>
<p>5 &nbsp;5 13 13</p>
</td>
</tr>
<tr>
<td width="221">
<p>4 3 -1 <strong>2 5 0 1 9 8</strong> 6 7 -2</p>
</td>
<td width="132">
<p>1 8 4 -1 16 14</p>
</td>
<td width="181">
<p>-1&nbsp; 3&nbsp; 4 -2&nbsp; 7&nbsp; 6 &nbsp;+</p>
<p>&nbsp;2&nbsp; 5&nbsp; 0&nbsp; 1&nbsp; 9&nbsp; 8 &nbsp;=</p>
<p>&nbsp;1 &nbsp;8 &nbsp;4 -1 16 14</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create the <strong>first row</strong> after folding: the first <strong>k</strong> numbers reversed, followed by the last <strong>k</strong> numbers reversed.</li>
<li>Create the <strong>second row</strong> after folding: the middle 2*<strong>k</strong></li>
<li><strong>Sum</strong> the first and the second rows.</li>
</ul>
<h2>4.&nbsp;&nbsp; Sieve of Eratosthenes</h2>
<p>Write a program to find <strong>all prime numbers in range [1&hellip;n]</strong>. Implement the algorithm called &ldquo;Sieve of Eratosthenes&rdquo;: <a href="https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes">https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes</a>. Steps in the &ldquo;Sieve of Eratosthenes&rdquo; algorithm:</p>
<ol>
<li>Assign <strong>primes</strong>[0&hellip;<strong>n</strong>] = <strong>true</strong></li>
<li>Assign <strong>primes</strong>[0] = <strong>primes</strong>[1] = <strong>false</strong></li>
<li>Find the smallest <strong>p</strong>, which holds <strong>primes</strong>[<strong>p</strong>] = <strong>true</strong></li>
<ul>
<li>Print <strong>p</strong> (it is prime)</li>
<li>Assign <strong>primes</strong>[2*<strong>p</strong>] = <strong>primes</strong>[3*<strong>p</strong>] = <strong>primes</strong>[4*<strong>p</strong>] = &hellip; = <strong>false</strong></li>
</ul>
<li>Repeat for the next smallest <strong>p</strong> &lt; <strong>n</strong>.</li>
</ol>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="55">
<p><strong>Input</strong></p>
</td>
<td width="197">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="55">
<p>6</p>
</td>
<td width="197">
<p>2 3 5</p>
</td>
</tr>
<tr>
<td width="55">
<p>25</p>
</td>
<td width="197">
<p>2 3 5 7 11 13 17 19 23</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Compare Char Arrays</h2>
<p>Compare two char arrays lexicographically (letter by letter).</p>
<p>Print the them in alphabetical order, each on separate line.</p>
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
</tr>
<tr>
<td width="92">
<p>a b c</p>
<p>d e f</p>
</td>
<td width="62">
<p>abc</p>
<p>def</p>
</td>
</tr>
<tr>
<td width="92">
<p>p e t e r</p>
<p>a n n i e</p>
</td>
<td width="62">
<p>annie</p>
<p>peter</p>
</td>
</tr>
<tr>
<td width="92">
<p>a n n i e</p>
<p>a n</p>
</td>
<td width="62">
<p>an</p>
<p>annie</p>
</td>
</tr>
<tr>
<td width="92">
<p>a b</p>
<p>a b</p>
</td>
<td width="62">
<p>ab</p>
<p>ab</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Compare the first letter of arr1[] and arr2[], if equal, compare the next letter, etc.</li>
<li>If all letters are equal, the smaller array is the <strong>shorter</strong>.</li>
<li>If all letters are equal and the array lengths are the same, the arrays are <strong>equal</strong>.</li>
</ul>
<h2>6.&nbsp;&nbsp; Max Sequence of Equal Elements</h2>
<p>Write a program that finds the <strong>longest sequence of equal elements</strong> in an array of integers. If several longest sequences exist, print the leftmost one.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="173">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="173">
<p>2 1 1 2 3 3 <strong>2 2 2</strong> 1</p>
</td>
<td width="76">
<p>2 2 2</p>
</td>
</tr>
<tr>
<td width="173">
<p><strong>1 1 1</strong> 2 3 1 3 3</p>
</td>
<td width="76">
<p>1 1 1</p>
</td>
</tr>
<tr>
<td width="173">
<p><strong>4 4 4 4</strong></p>
</td>
<td width="76">
<p>4 4 4 4</p>
</td>
</tr>
<tr>
<td width="173">
<p>0 <strong>1 1</strong> 5 2 2 6 3 3</p>
</td>
<td width="76">
<p>1 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Start with the sequence that consists of the first element: start=0, len=1.</li>
<li>Scan the elements from left to right, starting at the second element: pos=1&hellip;n-1.
<ul>
<li>At each step compare the current element with the element on the left.
<ul>
<li>Same value &agrave; you have found a sequence longer by one &agrave; len++.</li>
<li>Different value &agrave; start a new sequence from the current element: start=pos, len=1.</li>
</ul>
</li>
<li>After each step remember the sequence it is found to be longest at the moment: bestStart=start, bestLen=len.</li>
</ul>
</li>
<li>Finally, print the longest sequence by using bestStart and bestLen.</li>
</ul>
<h2>7.&nbsp;&nbsp; Max Sequence of Increasing Elements</h2>
<p>Write a program that finds the <strong>longest increasing subsequence</strong> in an array of integers. The longest increasing subsequence is a <strong>portion of the array</strong> (subsequence) that is strongly <strong>increasing</strong> and has the <strong>longest possible length</strong>. If several such subsequences exist, find the left most of them.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="130">
<p><strong>Input</strong></p>
</td>
<td width="94">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="130">
<p>3 <strong>2 3 4</strong> 2 2 4</p>
</td>
<td width="94">
<p>2 3 4</p>
</td>
</tr>
<tr>
<td width="130">
<p>4 5 <strong>1 2 3 4 5</strong></p>
</td>
<td width="94">
<p>1 2 3 4 5</p>
</td>
</tr>
<tr>
<td width="130">
<p><strong>3 4 5 6</strong></p>
</td>
<td width="94">
<p>3 4 5 6</p>
</td>
</tr>
<tr>
<td width="130">
<p><strong>0 1 </strong>1 2 2 3 3</p>
</td>
<td width="94">
<p>0 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use the same algorithm like in the previous problem (Max Sequence of Equal Elements).</li>
</ul>
<h2>8.&nbsp;&nbsp; Most Frequent Number</h2>
<p>Write a program that finds the <strong>most frequent number</strong> in a given sequence of numbers.</p>
<ul>
<li>Numbers will be in the range [0&hellip;65535].</li>
<li>In case of multiple numbers with the same maximal frequency, print the leftmost of them.</li>
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
<h2>9.&nbsp;&nbsp; Index of Letters</h2>
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
<h2>10.&nbsp;&nbsp; Pairs by Difference</h2>
<p>Write a program that <strong>count the number of pairs</strong> in given array <strong>which</strong> <strong>difference is equal to given number</strong>.</p>
<h3>Input</h3>
<ul>
<li>The <strong>first line</strong> holds the <strong>sequence of numbers</strong>.</li>
<li>The <strong>second line</strong> holds the <strong>difference</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="124">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="501">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="124">
<p>1 5 3 4 2</p>
<p>2</p>
</td>
<td width="62">
<p>3</p>
</td>
<td width="501">
<p>Pairs of elements with difference 2 -&gt; {1, 3}, {5, 3}, {4, 2}</p>
</td>
</tr>
<tr>
<td width="124">
<p>5 3 8 10 12 1</p>
<p>1</p>
</td>
<td width="62">
<p>0</p>
</td>
<td width="501">
<p>No pairs with difference 1</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp; Equal Sums</h2>
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
<td width="345">
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
<td width="345">
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
<td width="345">
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
<td width="345">
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
<td width="345">
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
<td width="345">
<p>At a[3] -&gt; left sum = 20, right sum = 20</p>
<p>a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
