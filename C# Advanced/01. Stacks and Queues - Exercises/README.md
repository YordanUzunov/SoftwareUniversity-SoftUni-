<h1>Exercises: Stacks and Queues</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/csharp-advanced">"CSharp Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/184">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reverse Numbers with a Stack</h2>
<p>Write a program that reads <strong>N integers</strong> from the console and <strong>reverses them using a stack</strong>. Use the <strong>Stack&lt;int&gt;</strong> class. Just put the input numbers in the stack and pop them. Examples:</p>
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
<p>1 2 3 4 5</p>
</td>
<td width="372">
<p>5 4 3 2 1</p>
</td>
</tr>
<tr>
<td width="305">
<p>1</p>
</td>
<td width="372">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Basic Stack Operations</h2>
<p>Play around with a stack. You will be given an integer <strong>N </strong>representing the number of elements to push onto the stack, an integer <strong>S </strong>representing the number of elements to pop from the stack and finally an integer <strong>X</strong>, an element that you should look for in the stack. If it&rsquo;s found, print &ldquo;<strong>true</strong>&rdquo; on the console. If it isn&rsquo;t, print the <strong>smallest</strong> element currently present in the stack.</p>
<h3>Input Format:</h3>
<ul>
<li>On the first line you will be given <strong>N</strong>, <strong>S</strong> and <strong>X, </strong>separated by a single space</li>
<li>On the next line you will be given <strong>N</strong> number of integers</li>
</ul>
<h3>Output Format:</h3>
<ul>
<li>On a single line print either <strong>true </strong>if <strong>X </strong>is present in the stack, otherwise print the <strong>smallest </strong>element in the stack. If the stack is <strong>empty</strong>, print 0</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="141">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
<td width="422">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="141">
<p>5 2 13</p>
<p>1 13 45 32 4</p>
</td>
<td width="132">
<p>true</p>
</td>
<td width="422">
<p>We have to <strong>push 5 </strong>elements. Then we <strong>pop 2 </strong>of them. Finally, we have to check whether 13 is present in the stack. Since it is we print <strong>true</strong>.</p>
</td>
</tr>
<tr>
<td width="141">
<p>4 1 666</p>
<p>420 69 13 666</p>
</td>
<td width="132">
<p>13</p>
</td>
<td width="422">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Maximum Element</h2>
<p>You have an empty sequence, and you will be given&nbsp;<strong>N</strong>&nbsp;queries. Each query is one of these three types:</p>
<p>1 x - <strong>Push</strong> the element x into the stack.</p>
<p>2 - <strong>Delete</strong> the element present at the <strong>top</strong> of the stack.</p>
<p>3 - <strong>Print</strong> the <strong>maximum</strong> element in the stack.</p>
<h3>Input Format:</h3>
<ul>
<li>The first line of input contains an integer,&nbsp;<strong>N</strong></li>
<li>The next&nbsp;<strong>N</strong> lines each contain an above-mentioned query.&nbsp;<em>(It is guaranteed that each query is valid.)</em></li>
</ul>
<h3>Output Format:</h3>
<ul>
<li>For each type&nbsp;3&nbsp;query, print the <strong>maximum</strong> element in the stack on a new line</li>
</ul>
<h3>Constraints:</h3>
<ul>
<li>1 &le; N &le; 105</li>
</ul>
<ul>
<li>1 &le; x &le; 109</li>
<li>1 &le; type &le; 3</li>
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
<p>9</p>
<p>1 97</p>
<p>2</p>
<p>1 20</p>
<p>2</p>
<p>1 26</p>
<p>1 20</p>
<p>3</p>
<p>1 91</p>
<p>3</p>
</td>
<td width="372">
<p>26</p>
<p>91</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Basic Queue Operations</h2>
<p>Play around with a queue. You will be given an integer <strong>N </strong>representing the number of elements to enqueue (<strong>add</strong>), an integer <strong>S </strong>representing the <strong>number of elements</strong> to <strong>dequeue</strong> (<strong>remove</strong>) from the queue and finally an integer <strong>X</strong>, an element that you should look for in the <strong>queue</strong>. If it is, print <strong>true </strong>on the console. If it&rsquo;s not print the <strong>smallest</strong> <strong>element</strong> currently present in the queue. If there are <strong>no</strong> <strong>elements</strong> in the sequence, print <strong>0</strong> on the console.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="142">
<p><strong>Output</strong></p>
</td>
<td width="406">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>5 2 32</p>
<p>1 13 45 32 4</p>
</td>
<td width="142">
<p>true</p>
<p>&nbsp;</p>
</td>
<td width="406">
<p>We have to <strong>push 5 </strong>elements. Then we <strong>pop 2 </strong>of them. Finally, we have to check whether 13 is present in the stack. Since it is we print <strong>true</strong>.</p>
</td>
</tr>
<tr>
<td width="140">
<p>4 1 666</p>
<p>666 69 13 420</p>
</td>
<td width="142">
<p>13</p>
</td>
<td width="406">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="140">
<p>3 3 90</p>
<p>90 90 90</p>
</td>
<td width="142">
<p>0</p>
</td>
<td width="406">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Calculate Sequence with Queue</h2>
<p>We are given the following sequence of numbers:</p>
<ul>
<li>S<sub>1</sub> = N</li>
<li>S<sub>2</sub> = S<sub>1</sub> + 1</li>
<li>S<sub>3</sub> = 2*S<sub>1</sub> + 1</li>
<li>S<sub>4</sub> = S<sub>1</sub> + 2</li>
<li>S<sub>5</sub> = S<sub>2</sub> + 1</li>
<li>S<sub>6</sub> = 2*S<sub>2</sub> + 1</li>
<li>S<sub>7</sub> = S<sub>2</sub> + 2</li>
<li>S<sub>8 </sub>= S<sub>3</sub> + 1</li>
<li>&hellip;</li>
</ul>
<p>Using the <strong>Queue&lt;T&gt;</strong> class, write a program to print its first 50 members for given N.</p>
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
<p>2</p>
</td>
<td width="372">
<p>2 3 5 4 4 7 5 6 11 7 5 9 6 &hellip;</p>
</td>
</tr>
<tr>
<td width="305">
<p>-1</p>
</td>
<td width="372">
<p>-1 0 -1 1 1 1 2 &hellip;</p>
</td>
</tr>
<tr>
<td width="305">
<p>1000</p>
</td>
<td width="372">
<p>1000 1001 2001 1002 1002 2003 1003 &hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Truck Tour</h2>
<p>Suppose there is a circle. There are&nbsp;<strong>N</strong>&nbsp;petrol pumps on that circle. Petrol pumps are numbered&nbsp;0&nbsp;to&nbsp;(N&minus;1)&nbsp;(both inclusive). You have <strong>two pieces of information</strong> corresponding to each of the petrol pump: (1) the <strong>amount of petrol</strong> that particular petrol pump will give, and (2) the <strong>distance from that petrol pump</strong> to the next petrol pump.</p>
<p>Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at <strong>any</strong> of the petrol pumps. Calculate the <strong>first point</strong> from where the truck will be able to complete the circle. Consider that the truck will stop at <strong>each of the petrol pumps</strong>. The truck will move one kilometer for each liter of the petrol.</p>
<h3>Input Format:</h3>
<ul>
<li>The first line will contain the value of&nbsp;<strong>N</strong></li>
<li>The next&nbsp;<strong>N</strong>lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump</li>
</ul>
<h3>Output Format:</h3>
<ul>
<li>An integer which will be the smallest index of the petrol pump from which we can start the tour</li>
</ul>
<h3>Constraints:</h3>
<ul>
<li>1 &le; N &le; 1000001</li>
<li>1 &le; Amount of petrol, Distance &le; 1000000000</li>
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
<p>3</p>
<p>1 5</p>
<p>10 3</p>
<p>3 4</p>
</td>
<td width="372">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Balanced Parentheses</h2>
<p>Given a sequence consisting of parentheses, determine whether the expression is balanced. A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closed parenthesis that occurs after the former. Also, the interval between them must be balanced. You will be given three types of parentheses:&nbsp;(,&nbsp;{, and&nbsp;[.</p>
<p>{[()]} - This is a balanced parenthesis.</p>
<p>{[(])} - This is not a balanced parenthesis.</p>
<h3>Input Format:</h3>
<ul>
<li>Each input consists of a single line, the sequence of parentheses.</li>
</ul>
<h3>Constraints:</h3>
<ul>
<li>1 &le; len<sub>s </sub>&le; 1000, where&nbsp;len<sub>s</sub>is the length of the sequence.</li>
<li>Each character of the sequence will be one of&nbsp;{, },&nbsp;(,&nbsp;),&nbsp;[,&nbsp;].</li>
</ul>
<h3>Output Format:</h3>
<ul>
<li>For each test case, print on a new line "YES" if the parentheses are balanced. <br /> Otherwise, print "NO". Do not print the quotes.</li>
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
<p>{[()]}</p>
</td>
<td width="372">
<p>YES</p>
</td>
</tr>
<tr>
<td width="305">
<p>{[(])}</p>
</td>
<td width="372">
<p>NO</p>
</td>
</tr>
<tr>
<td width="305">
<p>{{[[(())]]}}</p>
</td>
<td width="372">
<p>YES</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Recursive Fibonacci</h2>
<p>The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is calculated from the sum of the two previous elements. The <strong>first two </strong>elements are 1, 1. Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34&hellip;<br /> The following sequence can be generated with an array, but that&rsquo;s easy, so your task is to implement recursively.</p>
<p>So if the function <strong>getFibonacci(n)</strong> returns the n&rsquo;th Fibonacci number we can express it using <strong>getFibonacci(n) = getFibonacci(n-1) + getFibonacci(n-2).</strong></p>
<p>However, this will never end and in a few seconds a StackOverflow Exception is thrown. In order for the recursion to stop it has to have a &ldquo;<strong>bottom</strong>&rdquo;. The bottom of the recursion is <strong>getFibonacci(2)</strong> should return 1 and <strong>getFibonacci(1)</strong> should return 1.</p>
<h3>Input Format:</h3>
<ul>
<li>On the only line in the input the user should enter the wanted Fibonacci number.</li>
</ul>
<h3>Output Format:</h3>
<ul>
<li>The output should be the n&rsquo;th Fibonacci number counting from 1.</li>
</ul>
<h3>Constraints:</h3>
<ul>
<li>1 &le; N &le; 50</li>
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
<p>5</p>
</td>
<td width="372">
<p>5</p>
</td>
</tr>
<tr>
<td width="305">
<p>10</p>
</td>
<td width="372">
<p>55</p>
</td>
</tr>
<tr>
<td width="305">
<p>21</p>
</td>
<td width="372">
<p>10946</p>
</td>
</tr>
</tbody>
</table>
<p>For the Nth Fibonacci number, we calculate the N-1th and the N-2th number, but for the calculation of N-1th number we calculate the N-1-1th(N-2th) and the N-1-2th number, so we have a lot of repeated calculations.</p>
<p>If you want to figure out how to skip those unnecessary calculations, you can search for a technique called <a href="https://en.wikipedia.org/wiki/Memoization">memoization</a>.</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Stack Fibonacci</h2>
<p>There is another way of calculating the Fibonacci sequence <strong>using a stack</strong>. It is non-recursive, so it does not make any unnecessary calculations. Try implementing it. This time set the Fibonacci sequence to start from 0, i.e. 0, 1, 1, 2, 3, 5, 8&hellip; and so on. First <strong>push</strong> 0 and 1 and then use <strong>popping,</strong> <strong>peeking</strong> and <strong>pushing</strong> to generate every consecutive number.</p>
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
<p>7</p>
</td>
<td width="372">
<p>13</p>
</td>
</tr>
<tr>
<td width="305">
<p>15</p>
</td>
<td width="372">
<p>610</p>
</td>
</tr>
<tr>
<td width="305">
<p>33</p>
</td>
<td width="372">
<p>3524578</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10. &nbsp;Simple Text Editor</h2>
<p>You are given an empty text. Your task is to implement 4 commands related to manipulating the text</p>
<ul>
<li>1 someString - <strong>appends</strong> someString to the end of the text</li>
<li>2 count - <strong>erases</strong> the last <em>count </em>elements from the text</li>
<li>3 index - <strong>returns</strong> the element at position <em>index </em>from the text</li>
<li>4 - <strong>undoes</strong> the last not undone command of type <em>1 / 2 </em>and returns the text to the state before that operation</li>
</ul>
<p><strong>Input format: </strong>The first line contains <strong><em>n</em></strong>, the number of operations.<br /> Each of the following <strong><em>n</em></strong> lines contains the name of the operation followed by the command argument, if any, separated by space in the following format <strong><em>CommandName Argument</em></strong>.</p>
<h3>Output Format:</h3>
<ul>
<li>For each operation of type <strong><em>3 </em></strong>print a single line with the returned character of that operation.</li>
</ul>
<h3>Constraints:</h3>
<ul>
<li>1 &le; N &le; 105</li>
<li>The length of the text will not exceed 1000000</li>
<li>All input characters are English letters.</li>
<li>It is guaranteed that the sequence of input operation is possible to perform.</li>
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
<p>8</p>
<p>1 abc</p>
<p>3 3</p>
<p>2 3</p>
<p>1 xy</p>
<p>3 2</p>
<p>4</p>
<p>4</p>
<p>3 1</p>
</td>
<td width="372">
<p>c</p>
<p>y</p>
<p>a</p>
</td>
</tr>
</tbody>
</table>
<h3>Explanation</h3>
<ul>
<li>There are&nbsp;8&nbsp;operations. Initially,&nbsp;the text&nbsp;is empty.</li>
<li>In the first operation, we append <strong>abc</strong> to&nbsp;the text.</li>
<li>Then, we print its&nbsp;3rd&nbsp;character, which is&nbsp;<strong>c</strong>at this point.</li>
<li>Next, we erase its last&nbsp;3&nbsp;characters,&nbsp;<strong>abc</strong>.</li>
<li>After that, we append&nbsp;<strong>xy</strong> to the text.</li>
<li>The text&nbsp;becomes&nbsp;<strong>xy</strong>after these previous two modifications.</li>
<li>Then, we are asked to return the&nbsp;2nd&nbsp;character of&nbsp;the text, which is&nbsp;<strong>y</strong>.</li>
<li>After that, we have to undo the last update to&nbsp;the text, so&nbsp;it&nbsp;becomes empty.</li>
<li>The next operation asks us to undo the update before that, so&nbsp;the text&nbsp;becomes <strong>abc </strong></li>
<li>Finally, we are asked to print its&nbsp;1st&nbsp;character, which is<strong>a</strong>&nbsp;at this point.</li>
</ul>
<h2>Problem 11. &nbsp;Poisonous Plants</h2>
<p>You are given&nbsp;<strong>N</strong>&nbsp;plants in a garden. Each of these plants has been added with some amount of pesticide. After each day, if any plant has <strong>more pesticide</strong> than the plant at <strong>its left</strong>, being weaker (more GMO) than the left one, <strong>it dies</strong>. You are given the initial values of the amount of pesticide and the position of each plant. Print the number of days <strong>after</strong> which no plant dies, i.e. the time after which there are no plants with more pesticide content than the plant to their left.</p>
<h3>Input Format:</h3>
<ul>
<li>The input consists of an integer&nbsp;<strong>N</strong> representing the number of plants</li>
<li>The next <strong>single line</strong> consists of&nbsp;<strong>N</strong>integers where every integer represents the position and the amount of pesticides of each plant</li>
</ul>
<h3>Output Format:</h3>
<ul>
<li>Output a single value equal to the number of days after which no plants die</li>
</ul>
<h3>Constraints:</h3>
<ul>
<li>1 &le; N &le; 100000</li>
<li>Pesticides amount on a plant is between 0 and 1000000000</li>
<li></li>
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
<p>7</p>
<p>6 5 8 4 7 10 9</p>
</td>
<td width="372">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<h3>Explanation</h3>
<p>Initially all plants are alive.&nbsp;<br /> Plants = {(6,1), (5,2), (8,3), (4,4), (7,5), (10,6), (9,7)}.<br /> Plants[k] = (i,j) =&gt; j<sup>th</sup>&nbsp;plant has pesticide amount = i.<br /> After the 1<sup>st</sup>&nbsp;day, 4 plants remain as plants 3, 5, and 6 die.<br /> Plants = {(6,1), (5,2), (4,4), (9,7)}.<br /> After the 2<sup>nd</sup>&nbsp;day, 3 plants survive as plant 7 dies. Plants = {(6,1), (5,2), (4,4)}.<br /> After the 3<sup>rd</sup>&nbsp;day, 3 plants survive and no more plants die.<br /> Plants = {(6,1), (5,2), (4,4)}.<br /> After the 2<sup>nd</sup>&nbsp;day the plants stop dying.</p>
