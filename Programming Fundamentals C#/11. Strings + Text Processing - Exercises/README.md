<h1>Exercises: Strings and Text Processing</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/programming-fundamentals">"Programming Fundamentals" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/321/Strings-and-RegEx-Exercise">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Convert from Base-10 to Base-N</h2>
<p>Write a program that takes a base-10 number (0 to 10<sup>50</sup>) and converts it to a base-N number, where 2 &lt;= N &lt;= 10.<br /> The input consists of 1 line containing two numbers separated by a single space. The first number is the base N to which you should convert. The second one is the base 10 number to be converted. <strong>Do not use any built in converting functionality, try to write your own algorithm.</strong></p>
<h3>Hints</h3>
<p>About the algorithm (from base-10 to base-2) you can read this <a href="https://interactivepython.org/runestone/static/pythonds/BasicDS/ConvertingDecimalNumberstoBinaryNumbers.html">article</a>.</p>
<p>The algorithm for converting from base-10 to base-N is similar: instead of &ldquo;% 2&rdquo;, use &ldquo;% N&rdquo;.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="74">
<p><strong>Base-10</strong></p>
</td>
<td width="76">
<p><strong>Base-N</strong></p>
</td>
</tr>
<tr>
<td width="74">
<p>7 10</p>
</td>
<td width="76">
<p>13</p>
</td>
</tr>
<tr>
<td width="74">
<p>3 154</p>
</td>
<td width="76">
<p>12201</p>
</td>
</tr>
<tr>
<td width="74">
<p>5 123</p>
</td>
<td width="76">
<p>443</p>
</td>
</tr>
<tr>
<td width="74">
<p>4 1000</p>
</td>
<td width="76">
<p>33220</p>
</td>
</tr>
<tr>
<td width="74">
<p>9 3487</p>
</td>
<td width="76">
<p>4704</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Convert from Base-N to Base-10</h2>
<p>Write a program that takes a base-N number and converts it to a base-10 number (0 to 10<sup>50</sup>), where 2 &lt;= N &lt;= 10.<br /> The input consists of 1 line containing two numbers separated by a single space. The first number is the base N to which you have to convert. The second one is the base N number to be converted. <strong>Do not use any built in converting functionality, try to write your own algorithm.</strong></p>
<h3>Hints</h3>
<p>See <a href="http://4.bp.blogspot.com/-_ozWsmbO7-g/VMj49QivTWI/AAAAAAAACbg/b5BxEpJqAQ4/s1600/Algorithm%2Bto%2Bconvert%2BBinary%2Bto%2BDecimal%2Bin%2BJava.gif">this</a> picture for more clarity about base-2 to base-10. Again, the algorithm for N-base is similar.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="74">
<p><strong>Base-N</strong></p>
</td>
<td width="76">
<p><strong>Base-10</strong></p>
</td>
</tr>
<tr>
<td width="74">
<p>7 13</p>
</td>
<td width="76">
<p>10</p>
</td>
</tr>
<tr>
<td width="74">
<p>3 12201</p>
</td>
<td width="76">
<p>154</p>
</td>
</tr>
<tr>
<td width="74">
<p>5 443</p>
</td>
<td width="76">
<p>123</p>
</td>
</tr>
<tr>
<td width="74">
<p>4 33220</p>
</td>
<td width="76">
<p>1000</p>
</td>
</tr>
<tr>
<td width="74">
<p>9 4704</p>
</td>
<td width="76">
<p>3487</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Unicode Characters</h2>
<p>Write a program that converts a string to a sequence of Unicode character literals.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="99">
<p><strong>Input</strong></p>
</td>
<td width="297">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="99">
<p>Hi!</p>
</td>
<td width="297">
<p>\u0048\u0069\u0021</p>
</td>
</tr>
<tr>
<td width="99">
<p>What?!?</p>
</td>
<td width="297">
<p>\0057\0068\0061\0074\003f\0021\003f</p>
</td>
</tr>
<tr>
<td width="99">
<p>SoftUni</p>
</td>
<td width="297">
<p>\0053\006f\0066\0074\0055\006e\0069</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Character Multiplier</h2>
<p>Create a <strong>method</strong> that takes two strings as arguments and returns the sum of their character codes multiplied (multiply str1.charAt (0) with str2.charAt (0) and add to the total sum). Then continue with the next two characters. If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="112">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="112">
<p>Gosho Pesho</p>
</td>
<td width="66">
<p>53253</p>
</td>
</tr>
<tr>
<td width="112">
<p>123 522</p>
</td>
<td width="66">
<p>7647</p>
</td>
</tr>
<tr>
<td width="112">
<p>a aaaa</p>
</td>
<td width="66">
<p>9700</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Magic Exchangeable Words</h2>
<p>Write a <strong>method </strong>that takes as input two strings, and returns Boolean if they are exchangeable or not. Exchangeable are words where the characters in the first string can be replaced to get the second string. Example: "<strong>egg"</strong> and "<strong>add" </strong>are exchangeable, but "aabbccbb<strong>"</strong> and "nnooppzz<strong>"</strong> are not. (First '<strong>b'</strong> corresponds to '<strong>o'</strong>, but then it also corresponds to '<strong>z'</strong>). The two words may not have the same length, if such is the case they are exchangeable only if the longer one doesn't have more types of characters then the shorter one ("Clint<strong>" </strong>and "Eastwaat" are exchangeable because '<strong>a' </strong>and<strong> 't'</strong> are already mapped as '<strong>l' </strong>and<strong> 'n'</strong>, but "Clint<strong>" </strong>and<strong> "</strong>Eastwood" aren't exchangeable because '<strong>o'</strong> and '<strong>d'</strong> are not contained in "<strong>Clint"</strong>).</p>
<h3>Examples</h3>
<table>
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
<p>gosho hapka</p>
</td>
<td width="76">
<p>true</p>
</td>
</tr>
<tr>
<td width="140">
<p>aabbaa ddeedd</p>
</td>
<td width="76">
<p>true</p>
</td>
</tr>
<tr>
<td width="140">
<p>foo bar</p>
</td>
<td width="76">
<p>false</p>
</td>
</tr>
<tr>
<td width="140">
<p>Clint Eastwood</p>
</td>
<td width="76">
<p>false</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sum Big Numbers</h2>
<p>You are given two lines - each can be a really big number (0 to 10<sup>50</sup>). You must display the sum of these numbers.</p>
<p>Note: do not use the BigInteger or BigDecimal classes for solving this problem.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="58">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="52">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>23</p>
<p>23</p>
</td>
<td width="62">
<p>46</p>
</td>
<td width="52">
<p>9999</p>
<p>1</p>
</td>
<td width="62">
<p>10000</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="286">
<p><strong>Input</strong></p>
</td>
<td width="285">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="286">
<p>923847238931983192462832102</p>
<p>934572893617836459843471846187346</p>
</td>
<td width="285">
<p>934573817465075391826664309019448</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Multiply Big Number</h2>
<p>You are given two lines &ndash; the first one can be a really big number (0 to 10<sup>50</sup>). The second one will be a single digit number (0 to 9). You must display the product of these numbers.</p>
<p>Note: do not use the BigInteger or BigDecimal classes for solving this problem.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="44">
<p><strong>Input</strong></p>
</td>
<td width="55">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="12">
<p><strong>&nbsp;</strong></p>
</td>
<td width="44">
<p><strong>Input</strong></p>
</td>
<td width="55">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="12">
<p><strong>&nbsp;</strong></p>
</td>
<td width="229">
<p><strong>Input</strong></p>
</td>
<td width="278">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="44">
<p>23</p>
<p>2</p>
</td>
<td width="55">
<p>46</p>
</td>
<td width="44">
<p>9999</p>
<p>9</p>
</td>
<td width="55">
<p>89991</p>
</td>
<td width="229">
<p>923847238931983192462832102</p>
<p>4</p>
</td>
<td width="278">
<p>934573817465075391826664309019448</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Letters Change Numbers</h2>
<p><strong>This problem is from the Java Basics exam (8 February 2015). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/69#1">here</a><strong>.</strong></p>
<p>Nakov likes Math. But he also likes the English alphabet a lot. He invented a game with numbers and letters from the <strong>English</strong> alphabet. The game was simple. You get a string consisting of a <strong>number between two letters</strong>. Depending on whether the letter was in front of the number or after it you would perform different mathematical operations on the number to achieve the result.</p>
<p><strong>First</strong> you start with the letter <strong>before </strong>the number.</p>
<ul>
<li>If it's <strong>uppercase</strong> you <strong>divide</strong> the number by the letter's <strong>position</strong> in the alphabet.</li>
<li>If it's <strong>lowercase</strong> you <strong>multiply</strong> the number with the letter's <strong>position </strong>in the alphabet.</li>
</ul>
<p><strong>Then</strong> you move to the <strong>letter after</strong> the number.</p>
<ul>
<li>If it's <strong>uppercase</strong> you <strong>subtract</strong> its position from the resulted number.</li>
<li>If it's <strong>lowercase</strong> you <strong>add</strong> its position to the resulted number.</li>
</ul>
<p>But the game became too easy for Nakov really quick. He decided to complicate it a bit by doing the same but with <strong>multiple</strong> strings keeping track of only the <strong>total sum</strong> of all results. Once he started to solve this with more strings and bigger numbers it became quite hard to do it only in his mind. So he kindly asks you to write a program that <strong>calculates the sum of all numbers after the operations on each number have been done</strong>.</p>
<p><strong>For example</strong>, you are given the sequence "A12b s17G":</p>
<p>We have two strings &ndash; <strong>"</strong>A12b<strong>"</strong> and <strong>"</strong>s17G<strong>"</strong>. We do the operations on each and sum them. We start with the letter before the number on the first string. <strong>A is Uppercase</strong> and its position in the alphabet is <strong>1</strong>. So we divide the number 12 with the position 1 (<strong>12/1 = 12)</strong>. Then we move to the letter after the number. <strong>b is lowercase</strong> and its position is 2. So we add 2 to the resulted number (<strong>12+2=14)</strong>. Similarly for the second string <strong>s is lowercase</strong> and its position is 19 so we multiply it with the number (<strong>17*19 = 323)</strong>. Then we have Uppercase G with position 7, so we subtract it from the resulted number&nbsp;(<strong>323 &ndash; 7 = 316)</strong>. Finally, we sum the 2 results and we get <strong>14 + 316=330</strong>.</p>
<h3>Input</h3>
<p>The input comes from the console as a <strong>single line, holding the sequence of strings</strong>. Strings are separated by <strong>one or more white spaces</strong>.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print at the console a single number: the <strong>total sum of all processed numbers </strong>rounded up to<strong> two digits </strong>after the decimal separator.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>count</strong> of the strings will be in the range <strong>[1 &hellip; 10].</strong></li>
<li>The numbers between the letters will be integers in range <strong>[1 &hellip; 2 147 483 647].</strong></li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="197">
<p><strong>Input</strong></p>
</td>
<td width="84">
<p><strong>Output</strong></p>
</td>
<td width="416">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="197">
<p>A12b s17G</p>
</td>
<td width="84">
<p>330.00</p>
</td>
<td width="416">
<p>12/1=12, 12+2=14, 17*19=323, 323&ndash;7=316, <strong>14+316=330</strong></p>
</td>
</tr>
<tr>
<td width="197">
<p>P34562Z q2576f&nbsp;&nbsp; H456z</p>
</td>
<td width="84">
<p>46015.13</p>
</td>
<td width="416">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="197">
<p>a1A</p>
</td>
<td width="84">
<p>0.00</p>
</td>
<td width="416">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Melrah Shake</h2>
<p>You are given a <strong>string</strong> of random characters, and a <strong>pattern</strong> of random characters. You need to &ldquo;shake off&rdquo; (<strong>remove</strong>) all of the <strong>border</strong> occurrences of that pattern, in other words, the <strong>very</strong> <strong>first</strong> <strong>match</strong> and the <strong>very last match </strong>of the pattern you find in the string.</p>
<p>When you successfully shake off a match, you <strong>remove</strong> from the pattern the character which corresponds to the <strong>index</strong> equal to <strong>the pattern&rsquo;s length / 2</strong>. Then you continue to shake off the border occurrences of the new pattern until the pattern becomes <strong>empty</strong> or until there is <strong>less </strong>than the - needed for shake, matches in the remaining string.</p>
<p>In case you have found at least <strong>two</strong> matches, and you have successfully shaken them off, you print &ldquo;Shaked it.&rdquo; on the console. Otherwise you print &ldquo;No shake.&rdquo;, the remains of the main string, and you end the program. See the examples for more info.</p>
<h3>Input</h3>
<ul>
<li>The input will consist only of two lines.</li>
<li>On the first line, you will get a string of random characters.</li>
<li>On the second line, you will receive the pattern and that ends the input sequence.</li>
</ul>
<h3>Output</h3>
<ul>
<li>You must print &ldquo;Shaked it.&rdquo; for every time you successfully do the melrah shake.</li>
<li>If the melrah shake fails, you print &ldquo;No shake.&rdquo;, and on the next line you print what has remained of the main string.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The two strings may contain <strong>ANY </strong>ASCII character.</li>
<li>Allowed time/memory: 250ms/16MB.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="164">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="164">
<p>astalavista baby</p>
<p>sta</p>
</td>
<td width="108">
<p>Shaked it.</p>
<p>No shake.</p>
<p>alavi baby</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="165">
<p><strong>Input</strong></p>
</td>
<td width="107">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="165">
<p>##mtm!!mm.mm*mtm.#</p>
<p>mtm</p>
</td>
<td width="107">
<p>Shaked it.</p>
<p>Shaked it.</p>
<p>No shake.</p>
<p>##!!.*.#</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
