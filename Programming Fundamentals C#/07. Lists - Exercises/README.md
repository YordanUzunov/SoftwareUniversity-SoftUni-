<h1>Exercises: Lists</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/398/Lists-Exercises">https://judge.softuni.bg/Contests/398/Lists-Exercises</a>.</p>
<h2>1.&nbsp;&nbsp; Max Sequence of Equal Elements</h2>
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
<h2>2.&nbsp;&nbsp; Change List</h2>
<p>Write a program, which reads a <strong>list</strong> of <strong>integers</strong> from the <strong>console</strong> and receives <strong>commands</strong>, which <strong>manipulate</strong> the list. Your program may receive the following commands:</p>
<ul>
<li>Delete {element} &ndash; delete all elements in the array, which are equal to the given element</li>
<li>Insert {element} {position} &ndash; insert element and the given position</li>
</ul>
<p>You should stop the program when you receive the command Odd or Even. If you receive Odd &egrave; print all <strong>odd</strong> numbers in the array separated with <strong>single</strong> whitespace, otherwise print the <strong>even</strong> numbers.</p>
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
<td width="29">
<p><strong>&nbsp;</strong></p>
</td>
<td width="261">
<p><strong>Input</strong></p>
</td>
<td width="173">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>1 2 3 4 5 5 5 6</p>
<p>Delete 5</p>
<p>Insert 10 1</p>
<p>Delete 5</p>
<p>Odd</p>
</td>
<td width="62">
<p>1 3</p>
</td>
<td width="29">
<p>&nbsp;</p>
</td>
<td width="261">
<p>20 12 4 319 21 31234 2 41 23 4</p>
<p>Insert 50 2</p>
<p>Insert 50 5</p>
<p>Delete 4</p>
<p>Even</p>
</td>
<td width="173">
<p>20 12 50 50 31234 2</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Search for a Number</h2>
<p>On the <strong>first</strong> <strong>line</strong>, you will receive a <strong>list</strong> of <strong>integers</strong>. On the <strong>next</strong> line, you will receive an <strong>array</strong> with exactly <strong>three</strong> <strong>numbers</strong>. <strong>First</strong> number represents the <strong>number</strong> of <strong>elements</strong> you have to <strong>take</strong> from the <strong>list</strong> (<strong>starting</strong> from the <strong>first</strong> <strong>one</strong>). <strong>Second</strong> number represents the <strong>number</strong> of <strong>elements</strong> you have to <strong>delete</strong> from the numbers you took (<strong>starting</strong> from the <strong>first</strong> <strong>one</strong>). <strong>Last</strong> <strong>number</strong> is the <strong>number</strong> we search in our <strong>collection</strong> after the manipulations. If it is present print: &ldquo;<strong>YES!</strong>&rdquo;, otherwise print &ldquo;<strong>NO!</strong>&rdquo;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="58">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="52">
<p><strong>&nbsp;</strong></p>
</td>
<td width="245">
<p><strong>Input</strong></p>
</td>
<td width="56">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>1 2 3 4 5 6</p>
<p>5 2 3</p>
</td>
<td width="58">
<p>YES!</p>
</td>
<td width="245">
<p>12 412 123 21 654 34 65 3 23</p>
<p>7 4 21</p>
</td>
<td width="56">
<p>NO!</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; ** Longest Increasing Subsequence (LIS)</h2>
<p>Read a <strong>list of integers</strong> and find the <strong>longest increasing subsequence</strong> (LIS). If several such exist, print the <strong>leftmost</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="302">
<p><strong>Input</strong></p>
</td>
<td width="124">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="302">
<p><strong>1</strong></p>
</td>
<td width="124">
<p>1</p>
</td>
</tr>
<tr>
<td width="302">
<p>7 <strong>3 5</strong> 8 -1 0 <strong>6 7</strong></p>
</td>
<td width="124">
<p>3 5 6 7</p>
</td>
</tr>
<tr>
<td width="302">
<p><strong>1 2</strong> 5 <strong>3 5</strong> 2 4 1</p>
</td>
<td width="124">
<p>1 2 3 5</p>
</td>
</tr>
<tr>
<td width="302">
<p><strong>0</strong> 10 20 30 30 40 <strong>1</strong> 50 <strong>2 3 4 5 6</strong></p>
</td>
<td width="124">
<p>0 1 2 3 4 5 6</p>
</td>
</tr>
<tr>
<td width="302">
<p>11 12 13 <strong>3</strong> 14 <strong>4</strong> 15 <strong>5 6 7 8</strong> 7 <strong>16</strong> 9 8</p>
</td>
<td width="124">
<p>3 4 5 6 7 8 16</p>
</td>
</tr>
<tr>
<td width="302">
<p><strong>3 </strong>14 <strong>5</strong> 12 15 <strong>7 8 9 11</strong> 10 1</p>
</td>
<td width="124">
<p>3 5 7 8 9 11</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Assume we have n numbers in an array nums[0&hellip;n-1].</li>
<li>Let len[p] holds the length of the longest increasing subsequence (LIS) ending at position p.</li>
<li>In a for loop, we shall calculate len[p] for p = 0 &hellip; n-1 as follows:
<ul>
<li>Let left is the leftmost position on the left of p (left &lt; p), such that len[left] is the largest possible.</li>
<li>Then, len[p] = 1 + len[left]. If left does not exist, len[p] = 1.</li>
<li>Also, save prev[p] = left (we hold if prev[] the previous position, used to obtain the best length for position p).</li>
</ul>
</li>
<li>Once the values for len[0&hellip;n-1] are calculated, restore the LIS starting from position p such that len[p] is maximal and go back and back through p = prev[p].</li>
<li>The table below illustrates these computations:</li>
</ul>
<table width="0">
<tbody>
<tr>
<td width="64">
<p>index</p>
</td>
<td width="30">
<p>0</p>
</td>
<td width="47">
<p>1</p>
</td>
<td width="40">
<p>2</p>
</td>
<td width="57">
<p>3</p>
</td>
<td width="74">
<p>4</p>
</td>
<td width="51">
<p>5</p>
</td>
<td width="61">
<p>6</p>
</td>
<td width="71">
<p>7</p>
</td>
<td width="87">
<p>8</p>
</td>
<td width="87">
<p>9</p>
</td>
<td width="32">
<p>10</p>
</td>
</tr>
<tr>
<td width="64">
<p>nums[]</p>
</td>
<td width="30">
<p><strong>3</strong></p>
</td>
<td width="47">
<p><strong>14</strong></p>
</td>
<td width="40">
<p><strong>5</strong></p>
</td>
<td width="57">
<p><strong>12</strong></p>
</td>
<td width="74">
<p><strong>15</strong></p>
</td>
<td width="51">
<p><strong>7</strong></p>
</td>
<td width="61">
<p><strong>8</strong></p>
</td>
<td width="71">
<p><strong>9</strong></p>
</td>
<td width="87">
<p><strong>11</strong></p>
</td>
<td width="87">
<p><strong>10</strong></p>
</td>
<td width="32">
<p><strong>1</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>len[]</p>
</td>
<td width="30">
<p>1</p>
</td>
<td width="47">
<p>2</p>
</td>
<td width="40">
<p>2</p>
</td>
<td width="57">
<p>3</p>
</td>
<td width="74">
<p>4</p>
</td>
<td width="51">
<p>3</p>
</td>
<td width="61">
<p>4</p>
</td>
<td width="71">
<p>5</p>
</td>
<td width="87">
<p>6</p>
</td>
<td width="87">
<p>6</p>
</td>
<td width="32">
<p>1</p>
</td>
</tr>
<tr>
<td width="64">
<p>prev[]</p>
</td>
<td width="30">
<p>-1</p>
</td>
<td width="47">
<p>0</p>
</td>
<td width="40">
<p>0</p>
</td>
<td width="57">
<p>2</p>
</td>
<td width="74">
<p>3</p>
</td>
<td width="51">
<p>2</p>
</td>
<td width="61">
<p>5</p>
</td>
<td width="71">
<p>6</p>
</td>
<td width="87">
<p>7</p>
</td>
<td width="87">
<p>7</p>
</td>
<td width="32">
<p>-1</p>
</td>
</tr>
<tr>
<td width="64">
<p>LIS</p>
</td>
<td width="30">
<p>{3}</p>
</td>
<td width="47">
<p>{3,14}</p>
</td>
<td width="40">
<p>{3,5}</p>
</td>
<td width="57">
<p>{3,5,12}</p>
</td>
<td width="74">
<p>{3,5,12,15}</p>
</td>
<td width="51">
<p>{3,5,7}</p>
</td>
<td width="61">
<p>{3,5,7,8}</p>
</td>
<td width="71">
<p>{3,5,7,8,9}</p>
</td>
<td width="87">
<p>{3,5,7,8,9,11}</p>
</td>
<td width="87">
<p>{3,5,7,8,9,10}</p>
</td>
<td width="32">
<p>{1}</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; * Array Manipulator</h2>
<p>Write a program that <strong>reads an array of integers</strong> from the console and <strong>set of commands</strong> and <strong>executes them over the array</strong>. The commands are as follows:</p>
<ul>
<li><strong>add &lt;index&gt; &lt;element&gt;</strong> &ndash; adds element at the specified index (elements right from this position inclusively are shifted to the right).</li>
<li><strong>addMany &lt;index&gt; &lt;element 1&gt; &lt;element 2&gt; &hellip; &lt;element n&gt;</strong> &ndash; adds a set of elements at the specified index.</li>
<li><strong>contains &lt;element&gt;</strong> &ndash; prints the index of the first occurrence of the specified element (if exists) in the array or <strong>-1</strong> if the element is not found.</li>
<li><strong>remove &lt;index&gt;</strong> &ndash; removes the element at the specified index.</li>
<li><strong>shift &lt;positions&gt;</strong> &ndash; <strong>shifts every element</strong> of the array the number of positions <strong>to the</strong> <strong>left</strong> (with rotation).
<ul>
<li>For example, [1, 2, 3, 4, 5] -&gt; shift 2 -&gt; [3, 4, 5, 1, 2]</li>
</ul>
</li>
<li><strong>sumPairs</strong> &ndash; sums the elements in the array by pairs (first + second, third + fourth, &hellip;).
<ul>
<li>For example, [1, 2, 4, 5, 6, 7, 8] -&gt; [3, 9, 13, 8].</li>
</ul>
</li>
<li><strong>print</strong> &ndash; stop receiving more commands and print the last state of the array.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="237">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>1 2 4 5 6 7</p>
<p>add 1 8</p>
<p>contains 1</p>
<p>contains -3</p>
<p>print</p>
</td>
<td width="237">
<p>0</p>
<p>-1</p>
<p>[1, 8, 2, 4, 5, 6, 7]</p>
</td>
</tr>
<tr>
<td width="205">
<p>1 2 3 4 5</p>
<p>addMany 5 9 8 7 6 5</p>
<p>contains 15</p>
<p>remove 3</p>
<p>shift 1</p>
<p>print</p>
</td>
<td width="237">
<p>-1</p>
<p>[2, 3, 5, 9, 8, 7, 6, 5, 1]</p>
</td>
</tr>
<tr>
<td width="205">
<p>2 2 4 2 4</p>
<p>add 1 4</p>
<p>sumPairs</p>
<p>print</p>
</td>
<td width="237">
<p>[6, 6, 6]</p>
</td>
</tr>
<tr>
<td width="205">
<p>1 2 1 2 1 2 1 2 1 2 1 2</p>
<p>sumPairs</p>
<p>sumPairs</p>
<p>addMany 0 -1 -2 -3</p>
<p>print</p>
</td>
<td width="237">
<p>[-1, -2, -3, 6, 6, 6]</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Sum Reversed Numbers</h2>
<p>Write a program that reads sequence of numbers, reverses their digits, and prints their sum.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="157">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="277">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="157">
<p>123 234 12</p>
</td>
<td width="62">
<p>774</p>
</td>
<td width="277">
<p>321 + 432 + 21 = 774</p>
</td>
</tr>
<tr>
<td width="157">
<p>12 12 34 84 66 12</p>
</td>
<td width="62">
<p>220</p>
</td>
<td width="277">
<p>21 + 21 + 43+ 48 + 66 + 21 = 220</p>
</td>
</tr>
<tr>
<td width="157">
<p>120 1200 12000</p>
</td>
<td width="62">
<p>63</p>
</td>
<td width="277">
<p>21 + 21 + 21 = 63</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Bomb Numbers</h2>
<p>Write a program that <strong>reads sequence of numbers</strong> and <strong>special bomb number </strong>with a certain<strong> power</strong>. Your task is to <strong>detonate every occurrence of the special bomb number</strong> and according to its power <strong>his neighbors from left and right</strong>. Detonations are performed from left to right and all detonated numbers disappear. Finally print the<strong> sum of the remaining elements</strong> in the sequence.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="173">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="453">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="173">
<p>1 2 2 4 2 2 2 9</p>
<p>4 2</p>
</td>
<td width="62">
<p>12</p>
</td>
<td width="453">
<p>Special number is <strong>4</strong> with power 2. After detontaion we left with the sequence [1, 2, 9] with sum 12.</p>
</td>
</tr>
<tr>
<td width="173">
<p>1 4 4 2 8 9 1</p>
<p>9 3</p>
</td>
<td width="62">
<p>5</p>
</td>
<td width="453">
<p>Special number is <strong>9</strong> with power 3. After detontaion we left with the sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just it (one number instead of 3).</p>
</td>
</tr>
<tr>
<td width="173">
<p>1 7 7 1 2 3</p>
<p>7 1</p>
</td>
<td width="62">
<p>6</p>
</td>
<td width="453">
<p>Detonations are performed from left to right. We could not detonate the second occurance of 7 because its already destroyed by the first occurance. The numbers [1, 2, 3] survive. Their sum is 6.</p>
</td>
</tr>
<tr>
<td width="173">
<p>1 1 2 1 1 1 2 1 1 1</p>
<p>2 1</p>
</td>
<td width="62">
<p>4</p>
</td>
<td width="453">
<p>The red and yellow numbers disappear in two sequential detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
