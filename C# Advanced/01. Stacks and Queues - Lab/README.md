<h1>Lab: Stacks and Queues</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/csharp-advanced">"CSharp Advanced" course @ Software University</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/Practice/Index/925">https://judge.softuni.bg/Contests/Practice/Index/925</a>.</p>
<ol>
<li>Working with Stacks</li>
</ol>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reverse Strings</h2>
<p>Write program that:</p>
<ul>
<li><strong>Reads </strong>an<strong> input string</strong></li>
<li><strong>Reverses </strong>it<strong> using a </strong>Stack&lt;T&gt;</li>
<li><strong>Prints </strong>the result back at the terminal</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="192">
<p><strong>Input</strong></p>
</td>
<td width="467">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="192">
<p>Learning Java</p>
</td>
<td width="467">
<p>avaJ gninraeL</p>
</td>
</tr>
<tr>
<td width="192">
<p>Stacks and Queues</p>
</td>
<td width="467">
<p>seueuQ dna skcatS</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use a Stack&lt;string&gt;</li>
<li>Use the methods <strong>Push()</strong>, <strong>Pop()</strong></li>
</ul>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Simple Calculator</h2>
<p><strong>Create a simple calculator</strong> that can <strong>evaluate simple expressions</strong> with only addition and subtraction. There will not be any parentheses.</p>
<p>Solve the problem <strong>using a Stack</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="155">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>2 + 5 + 10 - 2 - 1</p>
</td>
<td width="132">
<p>14</p>
</td>
</tr>
<tr>
<td width="155">
<p>2 - 2 + 5</p>
</td>
<td width="132">
<p>5</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use a <strong>Stack&lt;string&gt;</strong></li>
<li>You can either
<ul>
<li>add the elements and then Pop() them out</li>
<li>or Push() them and reverse the stack</li>
</ul>
</li>
</ul>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Decimal to Binary Converter</h2>
<p>Create a simple program that <strong>can convert a decimal number to its binary representation</strong>. Implement an elegant solution <strong>using a Stack</strong>.</p>
<p><strong>Print the binary representation</strong> back at the terminal.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="153">
<p><strong>Input</strong></p>
</td>
<td width="267">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="153">
<p>10</p>
</td>
<td width="267">
<p>1010</p>
</td>
</tr>
<tr>
<td width="153">
<p>1024</p>
</td>
<td width="267">
<p>10000000000</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>If the given number is 0, just print 0</li>
<li>Else, while the number is greater than zero, divide it by 2 and push the remainder into the stack</li>
<li>When you are done dividing, pop all remainders from the stack &ndash; that is the binary representation</li>
</ul>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Matching Brackets</h2>
<p>We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.</p>
<p>Print the result back at the terminal.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="240">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="240">
<p>1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5</p>
</td>
<td width="246">
<p>(2 + 3)</p>
<p>(3 + 1)</p>
<p>(2 - (2 + 3) * 4 / (3 + 1))</p>
</td>
</tr>
<tr>
<td width="240">
<p>(2 + 3) - (2 + 3)</p>
</td>
<td width="246">
<p>(2 + 3)</p>
<p>(2 + 3)</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Scan through the expression searching for brackets
<ul>
<li>If you find an opening bracket, push the index into the stack</li>
<li>If you find a closing bracket pop the topmost element from the stack. This is the index of the opening bracket.</li>
<li>Use the current and the popped index to extract the sub-expression</li>
</ul>
</li>
</ul>
<ol>
<li>Working with Queues</li>
</ol>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hot Potato</h2>
<p>Hot potato is a game in which <strong>children form a circle and start passing a hot potato</strong>. The counting starts with the fist kid. <strong>Every n<sup>th</sup></strong><strong> toss the child left with the potato leaves the game</strong>. When a kid leaves the game, it passes the potato along. This continues <strong>until there is only one kid left</strong>.</p>
<p>Create a program that simulates the game of Hot Potato. &nbsp;<strong>Print every kid that is removed from the circle</strong>. In the end, <strong>print the kid that is left last</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="283">
<p><strong>Input</strong></p>
</td>
<td width="217">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="283">
<p>Mimi Pepi Toshko</p>
<p>2</p>
</td>
<td width="217">
<p>Removed Pepi</p>
<p>Removed Mimi</p>
<p>Last is Toshko</p>
</td>
</tr>
<tr>
<td width="283">
<p>Gosho Pesho Misho Stefan Krasi</p>
<p>10</p>
</td>
<td width="217">
<p>Removed Krasi</p>
<p>Removed Pesho</p>
<p>Removed Misho</p>
<p>Removed Gosho</p>
<p>Last is Stefan</p>
</td>
</tr>
<tr>
<td width="283">
<p>Gosho Pesho Misho Stefan Krasi</p>
<p>1</p>
</td>
<td width="217">
<p>Removed Gosho</p>
<p>Removed Pesho</p>
<p>Removed Misho</p>
<p>Removed Stefan</p>
<p>Last is Krasi</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Traffic Light</h2>
<p>Create a program that simulates the <strong>queue</strong> that forms during a <strong>traffic</strong> <strong>jam</strong>. During a traffic jam only <strong>N</strong> cars can <strong>pass</strong> the crossroads when the <strong>light</strong> <strong>goes</strong> <strong>green</strong>. Then the program reads the <strong>vehicles</strong> that <strong>arrive</strong> one by one and <strong>adds</strong> them to the <strong>queue</strong>. When the light <strong>goes</strong> <strong>green</strong> <strong>N</strong> number of cars <strong>pass</strong> the crossroads and <strong>for</strong> <strong>each</strong> a <strong>message</strong> "{car} passed!" is displayed. When the "<strong>end</strong>" command is given, <strong>terminate</strong> the program and <strong>display</strong> a <strong>message</strong> with the <strong>total</strong> <strong>number</strong> of cars that <strong>passed</strong> the crossroads.</p>
<h3>Input</h3>
<ul>
<li>On the <strong>first</strong> <strong>line</strong> you will receive <strong>N</strong> &ndash; the number of cars that can pass during a green light</li>
<li>On the <strong>next</strong> <strong>lines</strong>, until the "<strong>end</strong>" command is given, you will receive <strong>commands</strong> &ndash; a <strong>single</strong> <strong>string</strong>, either a <strong>car</strong> or "<strong>green</strong>"</li>
</ul>
<h3>Output</h3>
<ul>
<li>Every time the "<strong>green</strong>" command is given, <strong>print</strong> <strong>out</strong> a message for <strong>every</strong> <strong>car</strong> that <strong>passes</strong> the crossroads in the format "{car} passed!"</li>
<li>When the "<strong>end</strong>" command is given, <strong>print</strong> <strong>out</strong> a message in the format "{number of cars} cars passed the crossroads."</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="283">
<p><strong>Input</strong></p>
</td>
<td width="253">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="283">
<p>4</p>
<p>Hummer H2</p>
<p>Audi</p>
<p>Lada</p>
<p>Tesla</p>
<p>Renault</p>
<p>Trabant</p>
<p>Mercedes</p>
<p>MAN Truck</p>
<p>green</p>
<p>green</p>
<p>Tesla</p>
<p>Renault</p>
<p>Trabant</p>
<p>end</p>
</td>
<td width="253">
<p>Hummer H2 passed!</p>
<p>Audi passed!</p>
<p>Lada passed!</p>
<p>Tesla passed!</p>
<p>Renault passed!</p>
<p>Trabant passed!</p>
<p>Mercedes passed!</p>
<p>MAN Truck passed!</p>
<p>8 cars passed the crossroads.</p>
</td>
</tr>
<tr>
<td width="283">
<p>3</p>
<p>Pesho's car</p>
<p>Gosho's car</p>
<p>Mercedes CLS</p>
<p>Nekva troshka</p>
<p>green</p>
<p>BMW X5</p>
<p>green</p>
<p>end</p>
</td>
<td width="253">
<p>Pesho's car passed!</p>
<p>Gosho's car passed!</p>
<p>Mercedes CLS passed!</p>
<p>Nekva troshka passed!</p>
<p>BMW X5 passed!</p>
<p>5 cars passed the crossroads.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
