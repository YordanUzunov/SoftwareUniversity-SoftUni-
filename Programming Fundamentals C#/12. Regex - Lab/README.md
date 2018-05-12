<h1>Lab: Regular Expressions (RegEx)</h1>
<p>This document defines the homework assignments from the <a href="https://softuni.bg/courses/programming-fundamentals">"Programming Fundamentals" Course @ Software University</a>. Please submit your solutions (source code) of all below described problems in the <a href="https://judge.softuni.bg/Contests/452/Regex-Lab">Judge System</a>.</p>
<h2>1.&nbsp;&nbsp; Match Full Name</h2>
<p>Write a C# Program to <strong>match full names</strong> from a list of names and <strong>print </strong>them on the console.</p>
<h3>Writing the Regular Expression</h3>
<p>First, write a regular expression to match a valid full name, according to these conditions:</p>
<ul>
<li>A valid full name has the following characteristics:
<ul>
<li>It consists of <strong>two words</strong>.</li>
<li>Each word <strong>starts</strong> with a <strong>capital letter</strong>.</li>
<li>After the first letter, it <strong>only contains lowercase letters afterwards</strong>.</li>
<li><strong>Each</strong> of the <strong>two words</strong> should be <strong>at least two letters long</strong>.</li>
<li>The <strong>two words</strong> are <strong>separated </strong>by a<strong> single space</strong>.</li>
</ul>
</li>
</ul>
<p>To help you out, we've outlined several steps:</p>
<ol>
<li>Use an online regex tester like <a href="https://regex101.com/">https://regex101.com/</a></li>
<li>Check out how to use <strong>character sets</strong> (denoted with square brackets - "[]")</li>
<li>Specify that you want <strong>two words</strong> with a space between them (the <strong>space character '</strong> <strong>'</strong>, and <strong>not</strong> any whitespace symbol)</li>
<li>For each word, specify that it should begin with an uppercase letter using a <strong>character set</strong>. The desired characters are in a range &ndash; <strong>from </strong>&lsquo;<strong>A</strong>&rsquo;<strong> to </strong>&lsquo;<strong>Z</strong>&rsquo;.</li>
<li>For each word, specify that what follows the first letter are only <strong>lowercase letters</strong>, one or more &ndash; use another character set and the correct <strong>quantifier</strong>.</li>
<li>To prevent capturing of letters across new lines, put "\b" at the beginning and at the end of your regex. This will ensure that what precedes and what follows the match is a word boundary (like a new line).</li>
</ol>
<p>In order to check your RegEx, use these values for reference (paste all of them in the <strong>Test String</strong> field):</p>
<table width="0">
<tbody>
<tr>
<td width="138">
<p><strong>Match ALL of these</strong></p>
</td>
<td width="558">
<p><strong>Match NONE of these</strong></p>
</td>
</tr>
<tr>
<td width="138">
<p>Ivan Ivanov</p>
</td>
<td width="558">
<p>ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan&nbsp;&nbsp;&nbsp;&nbsp; Ivanov</p>
</td>
</tr>
</tbody>
</table>
<p>By the end, the matches should look something like this:</p>
<p>After you&rsquo;ve constructed your regular expression, it&rsquo;s time to write the solution in C#.</p>
<h3>Implementing the Solution in C#</h3>
<p>Create a new C# project and copy your <strong>regular expression </strong>into a string variable:</p>
<p>Note: It&rsquo;s usually a good idea to use a <strong>verbatim string</strong> (@ in front of the string literal) to store <strong>regular expressions</strong>, since characters like the backslash &ldquo;\&rdquo; can clash with <strong>string escaping</strong>.</p>
<p>Now, it&rsquo;s time to <strong>read the input</strong> and <strong>extract all the matches</strong> from it. For this, we can use the MatchCollection class:</p>
<p>After we extract all the matches, we need to <strong>iterate </strong>over the MatchCollection and <strong>print </strong>every match that we found:</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="693">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="693">
<p>Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ivanov</p>
</td>
</tr>
<tr>
<td width="693">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="693">
<p>Ivan Ivanov Test Testov</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Match Phone Number</h2>
<p>Write a regular expression to match a<strong> valid phone number</strong> from <strong>Sofia</strong>. After you find all <strong>valid phones</strong>, <strong>print</strong> them on the console, separated by a <strong>comma and a space </strong>&ldquo;, &rdquo;.</p>
<h3>Compose the Regular Expression</h3>
<p>A valid number has the following characteristics:</p>
<ul>
<li>It starts with "<strong>+359</strong>"</li>
<li>Then, it is followed by the area code (always <strong>2</strong>)</li>
<li>After that, it&rsquo;s followed by the <strong>number</strong> itself:
<ul>
<li>The number consists of <strong>7 digits</strong> (separated in <strong>two</strong> <strong>groups</strong> of <strong>3</strong> and <strong>4</strong> <strong>digits</strong> respectively).</li>
</ul>
</li>
<li>The different <strong>parts</strong> are <strong>separated</strong> by <strong>either a space or a hyphen</strong> ('<strong>-</strong>').</li>
</ul>
<p>You can use the following RegEx properties to <strong>help</strong> with the matching:</p>
<ul>
<li>Use <strong>quantifiers</strong> to match a <strong>specific number</strong> of <strong>digits</strong></li>
<li>Use a <strong>capturing group</strong> to make sure the delimiter is <strong>only one of the allowed characters</strong> <strong>(space or hyphen)</strong> and <strong>not</strong> a <strong>combination</strong> of both (e.g. +359 2-111 111 has <strong>mixed delimiters</strong>, it is<strong> invalid</strong>). Use a <strong>group backreference</strong> to achieve this.</li>
<li>Add a <strong>word boundary</strong> at the <strong>end</strong> of the match to avoid <strong>partial matches</strong> (the last example on the right-hand side).</li>
<li>Ensure that before the <strong>'+'</strong> sign there is either a <strong>space</strong> or the <strong>beginning of the string</strong>.</li>
</ul>
<p>You can use the following table of values to test your RegEx against:</p>
<table width="0">
<tbody>
<tr>
<td width="281">
<p><strong>Match ALL of these</strong></p>
</td>
<td width="412">
<p><strong>Match NONE of these</strong></p>
</td>
</tr>
<tr>
<td width="281">
<p>+359 2 222 2222</p>
<p>+359-2-222-2222</p>
</td>
<td width="412">
<p>359-2-222-2222, +359/2/222/2222, +359-2 222 2222</p>
<p>+359 2-222-2222, +359-2-222-222, +359-2-222-22222</p>
</td>
</tr>
</tbody>
</table>
<h3>Implement the Solution in C#</h3>
<p>Now it&rsquo;s time to write the solution, so let&rsquo;s start writing!</p>
<p>First, just like in the previous problem, put your RegEx in a variable:</p>
<p>After that, let&rsquo;s make a MatchCollection for our matches:</p>
<p>Let&rsquo;s try to print <strong>all the matches</strong>, using only a <strong>single line</strong> <strong>of code</strong>. Since MatchCollection is, as its name suggests, a <strong>collection</strong>, we can use LINQ methods on it.</p>
<p>In order to get all of the matches and put them into a string array, we need to perform several manipulations on the MatchCollection:</p>
<ol>
<li>Cast every single element of the MatchCollection to the Match type using Cast&lt;Match&gt;().</li>
<li>Since every element is a Match now, we can extract just the Valueproperty of the match itself, which holds the <strong>match value</strong> as a <strong>string</strong>, using Select(). We can also Trim()<strong> the value</strong>, to get rid of any <strong>leading</strong> or <strong>trailing spaces</strong>.</li>
<li>After getting the match value, we can use ToArray() to <strong>convert</strong> the collection to an <strong>array</strong>.</li>
</ol>
<p>Here&rsquo;s what that looks like as a LINQ query:</p>
<p>After that, just print the valid phone number array, using string.Join():</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="690">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222</p>
</td>
</tr>
<tr>
<td width="690">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>+359 2 222 2222, +359-2-222-2222</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Match Hexadecimal Numbers</h2>
<p>Write a program, which finds all <strong>valid hexadecimal numbers</strong> in a <strong>string</strong> and <strong>print</strong> them <strong>space-separated</strong>.</p>
<h3>Compose the Regular Expression</h3>
<p>A valid hexadecimal number follows these conditions:</p>
<ul>
<li>Can have &ldquo;0x&rdquo; in front of it (not required)</li>
<li>Has <strong>one or more</strong> <strong>hexadecimal</strong> <strong>digits</strong> after it (0-9 and A-F).</li>
<li>Doesn&rsquo;t have anything on <strong>either</strong> of its sides (use \b).</li>
</ul>
<p>You can follow the table below to help with composing your RegEx:</p>
<table>
<tbody>
<tr>
<td width="282">
<p><strong>Match ALL of these</strong></p>
</td>
<td width="283">
<p><strong>Match NONE of these</strong></p>
</td>
</tr>
<tr>
<td width="282">
<p>0x10 0xAB 0x1F 10 AB 1F FF</p>
</td>
<td width="283">
<p>0xG G 0x4G 4G 0xFG FG</p>
</td>
</tr>
</tbody>
</table>
<p>Find all the <strong>hexadecimal numbers</strong> from the string and <strong>print them</strong> on the <strong>console</strong>, separated by <strong>spaces</strong>.</p>
<h3>Implement the Solution in C#</h3>
<p>After we&rsquo;re done composing our RegEx, we can put it inside a variable:</p>
<p>After that, we can <strong>read the input </strong>from the console, save it to a variable and <strong>match</strong> it against our <strong>RegEx</strong>:</p>
<p>Finally, we can just print the output, using string.Join():</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="431">
<p><strong>Input</strong></p>
</td>
<td width="262">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="431">
<p>1F 0xG 0x1F G 0x4G 4G 0xAB 0xFG FG 0x10&nbsp;&nbsp; 10 AB&nbsp; FF</p>
</td>
<td width="262">
<p>1F 0x1F 0xAB 0x10 10 AB FF</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Match Dates</h2>
<p>Write a program, which matches a date in the format &ldquo;dd{separator}MMM{separator}yyyy&rdquo;. Use <strong>named</strong> <strong>capturing groups </strong>in your regular expression.</p>
<h3>Compose the Regular Expression</h3>
<p>Every valid date has the following characteristics:</p>
<ul>
<li>Always starts with <strong>two digits</strong>, followed by a <strong>separator</strong></li>
<li>After that, it has <strong>one uppercase </strong>and <strong>two lowercase </strong>letters (e.g. Jan, Mar).</li>
<li>After that, it has a <strong>separator</strong> and <strong>exactly 4 digits</strong> (for the year).</li>
<li>The separator could be either of three things: a period (&ldquo;.&rdquo;), a hyphen (&ldquo;-&ldquo;) or a forward slash (&ldquo;/&rdquo;)</li>
<li>The separator needs to be <strong>the same</strong> for the whole date (e.g. 13.03.2016 is valid, 13.03/2016 is <strong>NOT</strong>). Use a <strong>group backreference</strong> to check for this.</li>
</ul>
<p>You can follow the table below to help with composing your RegEx:</p>
<table>
<tbody>
<tr>
<td width="286">
<p><strong>Match ALL of these</strong></p>
</td>
<td width="279">
<p><strong>Match NONE of these</strong></p>
</td>
</tr>
<tr>
<td width="286">
<p>13/Jul/1928, 10-Nov-1934, 25.Dec.1937</p>
</td>
<td width="279">
<p>01/Jan-1951, 23/sept/1973, 1/Feb/2016</p>
</td>
</tr>
</tbody>
</table>
<p>Use <strong>named capturing groups</strong> for the <strong>day</strong>, <strong>month</strong> and <strong>year</strong>.</p>
<p>Since this problem requires more complex RegEx, which includes <strong>named capturing groups</strong>, we&rsquo;ll take a look at how to construct it:</p>
<ul>
<li>First off, we don&rsquo;t want anything at the <strong>start</strong> of our date, so we&rsquo;re going to use a <strong>word boundary </strong>&ldquo;\b&rdquo;:</li>
<li>Next, we&rsquo;re going to match the <strong>day</strong>, by telling our RegEx to match <strong>exactly two digits</strong>, and since we want to <strong>extract</strong> the day from the match later, we&rsquo;re going to put it in a <strong>capturing group</strong>:<br /> <br /> We&rsquo;re also going to give our group a <strong>name</strong>, since it&rsquo;s easier to navigate by <strong>group name</strong> than by <strong>group index</strong>:</li>
<li>Next comes the separator &ndash; either a <strong>hyphen</strong>, <strong>period</strong> or <strong>forward slash</strong>. We can use a <strong>character class</strong> for this:<br /> <br /> Since we want to use the separator we matched here to match the <strong>same separator</strong> further into the date, we&rsquo;re going to put it in a <strong>capturing group</strong>:</li>
<li>Next comes the <strong>month</strong>, which consists of a<strong> capital Latin letter </strong>and <strong>exactly two lowercase Latin letters</strong>:<strong><br /> </strong></li>
<li>Next, we&rsquo;re going to match the <strong>same separator</strong> <strong>we matched earlier</strong>. We can use a <strong>backreference</strong> for that:</li>
<li>Next up, we&rsquo;re going to match the year, which consists of <strong>exactly 4 digits</strong>:</li>
<li>Finally, since we don&rsquo;t want to match the date if there&rsquo;s anything else <strong>glued to it</strong>, we&rsquo;re going to use another <strong>word boundary </strong>for the end:</li>
</ul>
<p>Now it&rsquo;s time to find all the <strong>valid dates</strong> in the input and <strong>print each date </strong>in the following format: &ldquo;Day: {day}, Month: {month}, Year: {year}&rdquo;, each on a <strong>new line</strong>.</p>
<h3>Implement the Solution in C#</h3>
<p>First off, we&rsquo;re going to put our RegEx in a variable and get a MatchCollection from the string:</p>
<p>Since RegEx works differently across different languages, before we continue, we&rsquo;re going to <strong>set our backreference from </strong>\2<strong> to </strong>\1. This is because <strong>C# backreferences</strong> don&rsquo;t count <strong>named capture groups for backreferences</strong>. So, <strong>change it before we continue</strong>.</p>
<p>Next, we&rsquo;re going to <strong>iterate </strong>over every single Match and <strong>extract </strong>the <strong>day</strong>, <strong>month</strong> and <strong>year</strong> from the <strong>groups</strong>. We can use a special syntax in C# to get a match&rsquo;s group <strong>value</strong> by its <strong>key</strong>, the <strong>same way</strong> as when we access a Dictionary&rsquo;s values:</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="632">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="632">
<p>13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016</p>
</td>
</tr>
<tr>
<td width="632">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="632">
<p>Day: 13, Month: Jul, Year: 1928</p>
<p>Day: 10, Month: Nov, Year: 1934</p>
<p>Day: 25, Month: Dec, Year: 1937</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Match Numbers</h2>
<p>Write a program, which finds all<strong> integer </strong>and<strong> floating-point numbers </strong>in a string.</p>
<h3>Compose the Regular Expression</h3>
<p>A number has the following characteristics:</p>
<ul>
<li>Has either <strong>whitespace</strong> before it or the <strong>start</strong> of the string (match either <strong>^</strong> or what&rsquo;s called a <a href="http://www.regular-expressions.info/lookaround.html">positive lookbehind</a>). The entire syntax for the <strong>beginning</strong> of your <strong>RegEx</strong> might look something like &ldquo;(^|(?&lt;=\s))&rdquo;.</li>
<li>The number might or might not be negative, so it might have a hyphen on its left side (&ldquo;-&ldquo;).</li>
<li>Consists of <strong>one or more digits</strong>.</li>
<li>Might or might not have <strong>digits after the</strong> <strong>decimal point</strong></li>
<li>The decimal part (if it exists) consists of a period (&ldquo;.&rdquo;) and <strong>one or more digits</strong> after it. Use a <strong>capturing group</strong>.</li>
<li>Has either <strong>whitespace</strong> before it or the <strong>end</strong> of the string (match either <strong>$</strong> or what&rsquo;s called a <a href="http://www.regular-expressions.info/lookaround.html">positive lookahead</a>). The syntax for the <strong>end</strong> of the <strong>RegEx</strong> might look something like &ldquo;($|(?=\s))&rdquo;.</li>
</ul>
<p>Let&rsquo;s see how we would translate the above rules into a <strong>regular expression</strong>:</p>
<ul>
<li>First off, we need to establish what needs to exist <strong>before</strong> our number. We can&rsquo;t use \b here, since it includes &ldquo;-&ldquo;, which we need to match <strong>negative numbers</strong>. <br /> Instead, we&rsquo;ll use a <strong>positive lookbehind</strong>, which <strong>matches</strong> if there&rsquo;s something <strong>immediately behind</strong> We&rsquo;ll match if we&rsquo;re either at the <strong>start</strong> of the string (^), or if there&rsquo;s any <strong>whitespace</strong> <strong>behind</strong> the string:</li>
<li>Next, we&rsquo;ll check whether there&rsquo;s a <strong>hyphen</strong>, signifying a <strong>negative number</strong>:<strong><br /> </strong> <br /> Since having a negative sign<strong> isn&rsquo;t required</strong>, we&rsquo;ll use the &ldquo;?&rdquo; quantifier, which means &ldquo;<strong>between 0 and 1 times</strong>&rdquo;.</li>
<li>After that, we&rsquo;ll match any integers &ndash; naturally, consisting <strong>one or more digits</strong>:</li>
<li>Next, we&rsquo;ll match the <strong>decimal</strong> part of the number, which <strong>might or might not exist </strong>(note: we need to escape the <strong>period</strong> character, as it&rsquo;s used for something else in RegEx):</li>
<li>Finally, we&rsquo;re going to use the same logic for the end of our string as the start &ndash; we&rsquo;re going to match <strong>only</strong> if the number has <strong>either a whitespace or the end of the string (&ldquo;</strong>$<strong>&rdquo;)</strong>:</li>
</ul>
<p>You can follow the table below to help with composing your RegEx:</p>
<table>
<tbody>
<tr>
<td width="289">
<p><strong>Match ALL of these</strong></p>
</td>
<td width="276">
<p><strong>Match NONE of these</strong></p>
</td>
</tr>
<tr>
<td width="289">
<p>1 -1 123 -123 123.456 -123.456</p>
</td>
<td width="276">
<p>1s s2 s-s -1- _55_ s-2 s-3.5 s-1.1</p>
</td>
</tr>
</tbody>
</table>
<p>Find all the <strong>numbers</strong> from the string and <strong>print them</strong> on the <strong>console</strong>, separated by <strong>spaces</strong>.</p>
<h3>Implement the Solution in C#</h3>
<p>Now that we&rsquo;ve written our regular expression, we can start by putting it in a variable and extracting the matches:</p>
<p>After that, it&rsquo;s only a matter of printing the numbers, separated by spaces:</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="351">
<p><strong>Input</strong></p>
</td>
<td width="341">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="351">
<p>1 -1 1s 123 s-s -123 _55_ _f 123.456 -123.456 s-1.1 s2 -1- zs-2 s-3.5</p>
</td>
<td width="341">
<p>1 -1 123 -123 123.456 -123.456</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Replace &lt;a&gt; Tag</h2>
<p>Write a program that replaces in a HTML document given as string <strong>all the tags </strong>&lt;a href=&hellip;&gt;&hellip;&lt;/a&gt; with corresponding <strong>tags </strong>[URL href=&hellip;&gt;&hellip;[/URL]. Read an input, until you receive the <strong>&ldquo;</strong>end&rdquo;<strong> command</strong>. <strong>Print</strong> the lines on the <strong>console</strong>, but with the &lt;a&gt; tags replaced.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="682">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="682">
<p>&lt;ul&gt;</p>
<p>&nbsp; &lt;li&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;a href=<strong>"http://softuni.bg"</strong>&gt;SoftUni&lt;/a&gt;</p>
<p>&nbsp;&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
<p><strong>end</strong></p>
</td>
</tr>
<tr>
<td width="682">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="682">
<p>&lt;ul&gt;</p>
<p>&nbsp; &lt;li&gt;</p>
<p>&nbsp; &nbsp;&nbsp;[URL href=<strong>"http://softuni.bg"</strong>]SoftUni[/URL]</p>
<p>&nbsp;&nbsp;&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
