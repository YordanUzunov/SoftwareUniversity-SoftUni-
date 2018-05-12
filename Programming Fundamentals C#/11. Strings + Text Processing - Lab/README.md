<h1>Lab: Strings and Text Processing</h1>
<p>This document defines the homework assignments from the <a href="https://softuni.bg/courses/programming-fundamentals">"Programming Fundamentals" Course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/320/Strings-and-RegEx-Lab">Judge</a>.</p>
<h2>1.&nbsp;&nbsp; Reverse string</h2>
<p>Write a program that reads a string from the console, reverses it and prints the result back at the console.</p>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>Input</strong></p>
</td>
<td width="89">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>sample</p>
</td>
<td width="89">
<p>elpmas</p>
</td>
</tr>
<tr>
<td width="84">
<p>24tvcoi92</p>
</td>
<td width="89">
<p>29iocvt42</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Count substring occurrences</h2>
<p>Write a program to <strong>find how many times a given string appears in a given text as substring</strong>. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the <strong>character casing</strong>. <strong>Overlapping</strong> between occurrences is <strong>allowed</strong>. Examples:</p>
<table>
<tbody>
<tr>
<td width="492">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="492">
<p><strong>Wel</strong>come to the Software University (SoftUni)! <strong>Wel</strong>come to programming. Programming is <strong>wel</strong>lness for developers, said Max<strong>wel</strong>l.</p>
<p>wel</p>
</td>
<td width="66">
<p>4</p>
</td>
</tr>
<tr>
<td width="492">
<p><strong>aaaaaa</strong></p>
<p>aa</p>
</td>
<td width="66">
<p>5</p>
</td>
</tr>
<tr>
<td width="492">
<p><strong>ababa</strong> c<strong>aba</strong></p>
<p>aba</p>
</td>
<td width="66">
<p>3</p>
</td>
</tr>
<tr>
<td width="492">
<p>Welcome to SoftUni</p>
<p>Java</p>
</td>
<td width="66">
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Text filter</h2>
<p>Write a program that takes a <strong>text</strong> and a <strong>string of banned words</strong>. All words included in the ban list should be replaced with <strong>asterisks</strong> "<strong>*</strong>", equal to the word's length. The entries in the ban list will be separated by a <strong>comma</strong> and <strong>space</strong> "<strong>, </strong>".</p>
<p>The ban list should be entered on the first input line and the text on the second input line. Example:</p>
<table width="0">
<tbody>
<tr>
<td width="348">
<p><strong>Input</strong></p>
</td>
<td width="342">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="348">
<p>Linux, Windows</p>
<p>It is not <strong>Linux</strong>, it is GNU/<strong>Linux</strong>. <strong>Linux</strong> is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/<strong>Linux</strong>! Sincerely, a <strong>Windows</strong> client</p>
</td>
<td width="342">
<p>It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Palindromes</h2>
<p>Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only <strong>unique</strong> palindromes, <strong>sorted</strong> lexicographically.</p>
<p>Example:</p>
<table width="0">
<tbody>
<tr>
<td width="312">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="312">
<p>Hi,exe? ABBA! Hog fully a string. Bob</p>
</td>
<td width="108">
<p>a, ABBA, exe</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
