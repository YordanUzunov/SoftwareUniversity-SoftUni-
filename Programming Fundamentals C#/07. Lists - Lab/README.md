<h1>Lab: Lists</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/397/Lists-Lab">https://judge.softuni.bg/Contests/397/Lists-Lab</a>.</p>
<h2>1.&nbsp;&nbsp; Remove Negatives and Reverse</h2>
<p>Read a <strong>list of integers</strong>, <strong>remove all negative numbers</strong> from it and print the remaining elements in <strong>reversed order</strong>. In case of no elements left in the list, print &ldquo;empty&rdquo;.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="148">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="148">
<p>10 -5 7 9 -33 50</p>
</td>
<td width="92">
<p>50 9 7 10</p>
</td>
</tr>
<tr>
<td width="148">
<p>7 -2 -10 1</p>
</td>
<td width="92">
<p>1 7</p>
</td>
</tr>
<tr>
<td width="148">
<p>-1 -2 -3</p>
</td>
<td width="92">
<p>empty</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read a text line from the console, split it by space, parse the obtained items as integers and convert them to list of integers.</li>
<li>Create a new empty list for the results.</li>
<li>Scan the input list from the end to the beginning. Check each element and append all non-negative elements to the result list.</li>
<li>Finally, print the results list (at a single line holding space-separated numbers).</li>
</ul>
<h2>2.&nbsp;&nbsp; Append Lists</h2>
<p>Write a program to <strong>append several lists</strong> of numbers.</p>
<ul>
<li>Lists are separated by &lsquo;|&rsquo;.</li>
<li>Values are separated by spaces (&lsquo; &rsquo;, one or several)</li>
<li>Order the lists from the <strong>last</strong> to the <strong>first</strong>, and their values from <strong>left</strong> to <strong>right</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="187">
<p><strong>Input</strong></p>
</td>
<td width="140">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="187">
<p>1 2 3 |4 5 6 |&nbsp; 7&nbsp; 8</p>
</td>
<td width="140">
<p>7 8 4 5 6 1 2 3</p>
</td>
</tr>
<tr>
<td width="187">
<p>7 | 4&nbsp; 5|1 0| 2 5 |3</p>
</td>
<td width="140">
<p>3 2 5 1 0 4 5 7</p>
</td>
</tr>
<tr>
<td width="187">
<p>1| 4 5 6 7 &nbsp;| &nbsp;8 9</p>
</td>
<td width="140">
<p>8 9 4 5 6 7 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create a new empty list for the results.</li>
<li>Split the input by &lsquo;|&rsquo; into array of tokens.</li>
<li>Pass through each of the obtained tokens from tight to left.
<ul>
<li>For each token, split it by space and append all non-empty tokens to the results.</li>
</ul>
</li>
<li>Print the results.</li>
</ul>
<h2>3.&nbsp;&nbsp; Sum Adjacent Equal Numbers</h2>
<p>Write a program to <strong>sum all adjacent equal numbers</strong> in a list of decimal numbers, starting from <strong>left to right</strong>.</p>
<ul>
<li>After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).</li>
<li>Always sum the <strong>leftmost</strong> two equal neighbors (if several couples of equal neighbors are available).</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="110">
<p><strong>Input</strong></p>
</td>
<td width="74">
<p><strong>Output</strong></p>
</td>
<td width="409">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="110">
<p>3 3 6 1</p>
</td>
<td width="74">
<p>12 1</p>
</td>
<td width="409">
<p><strong>3 3</strong> 6 1 &agrave; <strong>6 6</strong> 1 &agrave; 12 1</p>
</td>
</tr>
<tr>
<td width="110">
<p>8 2 2 4 8 16</p>
</td>
<td width="74">
<p>16 8 16</p>
</td>
<td width="409">
<p>8 <strong>2 2</strong> 4 8 16 &agrave; 8 <strong>4 4</strong> 8 16 &agrave; <strong>8 8</strong> 8 16 &agrave; 16 8 16</p>
</td>
</tr>
<tr>
<td width="110">
<p>5 4 2 1 1 4</p>
</td>
<td width="74">
<p>5 8 4</p>
</td>
<td width="409">
<p>5 4 2 <strong>1 1</strong> 4 &agrave; 5 4 <strong>2 </strong><strong>2</strong> 4 &agrave; 5 <strong>4 </strong><strong>4</strong> 4 &agrave; 5 8 4</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ol>
<li>Read the <strong>input</strong> and parse it to <strong>list of numbers</strong>.</li>
<li>Find the <strong>leftmost</strong> two <strong>adjacent equal cells</strong>.</li>
<li><strong>Replace</strong> them with their <strong>sum</strong>.</li>
<li><strong>Repeat</strong> (1) and (2) until no two equal adjacent cells survive.</li>
<li><strong>Print</strong> the processed list of numbers.</li>
</ol>
<h2>4.&nbsp;&nbsp; Split by Word Casing</h2>
<p>Read a <strong>text</strong>, split it into words and distribute them into <strong>3 lists</strong>.</p>
<ul>
<li><strong>Lower-case words</strong> like &ldquo;programming&rdquo;, &ldquo;at&rdquo; and &ldquo;databases&rdquo; &ndash; consist of lowercase letters only.</li>
<li><strong>Upper-case words</strong> like &ldquo;PHP&rdquo;, &ldquo;JS&rdquo; and &ldquo;SQL&rdquo; &ndash; consist of uppercase letters only.</li>
<li><strong>Mixed-case words</strong> like &ldquo;C#&rdquo;, &ldquo;SoftUni&rdquo; and &ldquo;Java&rdquo; &ndash; all others.</li>
</ul>
<p>Use the following <strong>separators </strong>between the words: , ; : . ! ( ) " ' \ / [ ] space</p>
<p>Print the 3 lists as shown in the example below.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="310">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.</p>
</td>
<td width="378">
<p>Lower-case: programming, at, databases, etc</p>
<p>Mixed-case: Learn, SoftUni, Java, 5, Web, C#</p>
<p>Upper-case: PHP, JS, HTML, CSS, SQL, AJAX</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Split</strong> the input text using the above described <strong>separators</strong>.</li>
<li><strong>Process</strong> the obtained <strong>list of words</strong> one by one.</li>
<li>Create 3 lists of words (initially empty): lowercase words, mixed-case words and uppercase words.</li>
<li>Check each word and append it to one of the above 3 lists:
<ul>
<li>Count the <strong>lowercase letters</strong> and <strong>uppercase letters</strong>.</li>
<li>If all letters are <strong>lowercase</strong>, append the word to the lowercase list.</li>
<li>If all letters are <strong>uppercase</strong>, append the word to the uppercase list.</li>
<li>Otherwise the word is considered mixed-case &agrave; append it to the mixed-case list.</li>
</ul>
</li>
<li>Print the obtained 3 lists as shown in the example above.</li>
</ul>
<h2>5.&nbsp;&nbsp; Sort Numbers</h2>
<p>Read a <strong>list of decimal numbers </strong>and <strong>sort</strong> them in increasing order. Print the output as shown in the examples below.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="148">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>8 2 7 3</p>
</td>
<td width="148">
<p>2 &lt;= 3 &lt;= 7 &lt;= 8</p>
</td>
</tr>
<tr>
<td width="76">
<p>2 4 -9</p>
</td>
<td width="148">
<p>-9 &lt;= 2 &lt;= 4</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use the built-in method List&lt;T&gt;.Sort().</li>
</ul>
<h2>6.&nbsp;&nbsp; Square Numbers</h2>
<p>Read a <strong>list of integers</strong> and <strong>extract all square numbers</strong> from it and print them in <strong>descending order</strong>. A <strong>square number</strong> is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="197">
<p><strong>Input</strong></p>
</td>
<td width="157">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="197">
<p>3 <strong>16 4</strong> 5 6 8 <strong>9</strong></p>
</td>
<td width="157">
<p>16 9 4</p>
</td>
</tr>
<tr>
<td width="197">
<p>12 <strong>1 9 4 16</strong> 8 <strong>25 49 16</strong></p>
</td>
<td width="157">
<p>49 25 16 16 9 4 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>To find out whether an integer is &ldquo;<strong>square number</strong>&rdquo;, check whether its square root is integer number (has no fractional part):
<ul>
<li>if (&radic;num == (int)&radic;num) &hellip;</li>
</ul>
</li>
<li>To order the results list in descending order use sorting by lambda function:
<ul>
<li>squareNums.Sort((a, b) =&gt; b.CompareTo(a));</li>
</ul>
</li>
</ul>
<h2>7.&nbsp;&nbsp; Count Numbers</h2>
<p>Read a <strong>list of integers </strong>in range [0&hellip;1000] and <strong>print them in ascending order</strong> along with their <strong>number of occurrences</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>8 2 2 8 2 2 3 7</p>
</td>
<td width="76">
<p>2 -&gt; 4</p>
<p>3 -&gt; 1</p>
<p>7 -&gt; 1</p>
<p>8 -&gt; 2</p>
</td>
</tr>
<tr>
<td width="140">
<p>10 8 8 10 10</p>
</td>
<td width="76">
<p>8 -&gt; 2</p>
<p>10 -&gt; 3</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Several algorithms can solve this problem:</p>
<ul>
<li>Use an <strong>array</strong> count[0&hellip;1000] to count in counts[x] the occurrences of each element x.</li>
<li><strong>Sort</strong> the numbers and count occurrences of each number.</li>
<li>Use a dictionary counts&lt;int,int&gt; to count in counts[x] the occurrences of each element x.</li>
</ul>
<h4>Counting Occurrences Using Array</h4>
<ol>
<li>Read the input elements in array of integers nums[].</li>
<li>Assume max holds the largest element in nums[].
<ul>
<li>max = nums.Max()</li>
</ul>
</li>
<li>Allocate an array counts[0&hellip;max+1].
<ul>
<li>It will hold for each number x its number of occurrences counts[x].</li>
</ul>
</li>
<li><strong>Scan</strong> the input elements and for each element x increase counts[x].
<ul>
<li>For each value v in [0&hellip;max], print v-&gt;count[v].</li>
<li>Skip all values which do not occur in nums[], i.e. counts[v] == 0.</li>
</ul>
</li>
</ol>
<p>This algorithm has a <strong>serious drawback</strong>:</p>
<ul>
<li>It depends on <strong>mapping numbers to array indexes</strong>.</li>
<li>It will work well for input values in the range [0&hellip;1000].</li>
<li>It will <strong>not work</strong> for very large and very small values, e.g. if the input holds -100 000 000 or 100 000&nbsp;000.</li>
<li>It will <strong>not work</strong> for real numbers, e.g. 3.14 or 2.5.</li>
</ul>
<h4>Counting Occurrences by After Sorting</h4>
<ol>
<li>Read the input elements in array of integers nums[]. Example: {8, 2, 2, 8, 2, 2, 3, 7}.</li>
<li>Sort nums[] in increasing order: {2, 2, 2, 2, 3, 7, 8, 8}. Now find all subsequences of equal numbers.</li>
<li><strong>Scan</strong> the numbers from left to right. Count how many times each number occurs.
<ul>
<li>Start at count = 1.</li>
<li>While the next number on the right is <strong>the same</strong> as the current number, <strong>increase</strong> count and proceed to the next number.</li>
<li>When the next number on the right is <strong>different</strong> (or there is no next number), <strong>print</strong> the current number and its count.</li>
<li>Continue scanning from the next number on the right.</li>
</ul>
</li>
</ol>
<p>This algorithm will work correctly for real numbers and very large numbers. It does not depend on mapping numbers to array indexes.</p>
<h4>Counting Occurrences with Dictionary</h4>
<p>Dictionaries map some input <strong>key</strong> (e.g. string, integer or real number) to some <strong>value</strong>. Using a dictionary, we can map an input number x to a dictionary value dict[x] and apply the first occurrence counting algorithm. Learn more about dictionaries at <a href="https://www.dotnetperls.com/dictionary">https://www.dotnetperls.com/dictionary</a>. In the next lesson you will learn how to use dictionaries.</p>
<p>&nbsp;</p>
