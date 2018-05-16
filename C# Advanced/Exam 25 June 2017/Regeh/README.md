<h1>Problem 1 &ndash; Regeh</h1>
<p>You need to read a line from the console and <strong>match everything</strong> that is in <strong>square brackets</strong>. However, there are some rules that you need to follow:</p>
<ul>
<li>You must have <strong>no whitespaces</strong> inside the match.</li>
<li>Inside the match you must have <strong>[</strong>(ASCII Symbols)<strong>&lt;</strong>(Some digits)<strong>REGEH</strong>(Some digits)<strong>&gt;</strong>(ASCII Symbols)<strong>]</strong></li>
<li>If you have <strong>nested brackets</strong> you need to <strong>match the inner most</strong>.</li>
</ul>
<p>&nbsp;[asdSd<strong>[asdasd&lt;4REGEH23&gt;asdUsd]</strong></p>
<p>After you find a match you must <strong>extract the numbers</strong> between the &ldquo;<strong>&lt;</strong>&rdquo;, &ldquo;<strong>&gt;</strong>&rdquo; brackets. Then use this <strong>number like index</strong> to get character from input. Every <strong>index</strong> is the sum of all <strong>previous indexes</strong>. When the index is <strong>larger</strong> than the string length <strong>start from the beginning</strong> of the string. Continue that process until you traverse the string <strong>enough times</strong> for the index to fit.</p>
<h3>Input</h3>
<ul>
<li>On the first line you will receive input that may contain any character.</li>
</ul>
<h3>Output</h3>
<ul>
<li>You must print on the console a <strong>single line with characters</strong>, that you find in the string</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The line may <strong>contain any character</strong></li>
<li>Line length will be <strong>1 &lt; n &lt; 1000000</strong></li>
<li>Time limit: 0.3 sec. Memory limit: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="597">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="597">
<p>[atdSd[asdasd&lt;4REGEH22&gt;asdosy]&nbsp;&nbsp; ***oopprefs[ew&lt;16REGEH30&gt;rdtr]pppp555b</p>
</td>
<td width="92">
<p>Soft</p>
</td>
</tr>
<tr>
<td width="597">
<p>[aаdSd[[asdasd&lt;4REGEH22&gt;asdosy]&nbsp;&nbsp; ***oopprefs[ew&lt;16REGEH30&gt;rdtr]ppp555b [tU&lt;1REGEH15&gt;s]trneti!t[dsaf&lt;3REGEH1&gt;fdwss]</p>
</td>
<td width="92">
<p>SoftUni!</p>
</td>
</tr>
<tr>
<td width="597">
<p>[atdSd[&lt;4REGEH22&gt;asdosy]&nbsp;&nbsp; ***oopprefs[ew&lt;16REGEH&gt;rdtr]pppp555b</p>
</td>
<td width="92">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="597">
<p>[atdSd[&lt;422&gt;asdosy]&nbsp;&nbsp; ***oopprefs[ew&lt;16REGEH&gt;]pppp</p>
</td>
<td width="92">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>