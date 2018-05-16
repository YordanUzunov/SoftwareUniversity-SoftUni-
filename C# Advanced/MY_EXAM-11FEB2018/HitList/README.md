<h1>Problem 4 &ndash; Hit List</h1>
<p>One final task for Sam before he gets to go home... Data mining!</p>
<p>Sam will receive info about one or several people in the format</p>
<ul>
<li>&ldquo;{name}={key}:{value};{key}:{value};&hellip;&rdquo;.</li>
</ul>
<p>The goal here is to <strong>group</strong> the info for every person by their <strong>name</strong>. If a <strong>key</strong> is received <strong>multiple times</strong>, keep <strong>only the most recent value</strong>.</p>
<p>On the last line, you will receive &ldquo;Kill {name}&rdquo;. Your task is to find all the info on that name and print it, <strong>ordered alphabetically by key</strong>.</p>
<p>Then, Sam needs to build a so-called <strong>info index</strong> on them. The <strong>info index</strong> is comprised of the <strong>sum</strong> of all the <strong>keys&rsquo; lengths</strong> and <strong>values&rsquo; lengths</strong> of that person&rsquo;s info.</p>
<p>If the <strong>info index</strong> is <strong>larger or equal to</strong> the <strong>target info index </strong>(given on the <strong>first line</strong> of input), print &ldquo;Proceed&rdquo;. Otherwise, print &ldquo;Need {infoNeeded} more info.&ldquo;.</p>
<h2>Input</h2>
<ul>
<li>On the <strong>first line</strong>, you will receive the <strong>target info index</strong>, an <strong>integer </strong>in the <strong>range</strong> <strong>[25-90]</strong></li>
<li>Until you receive the text &ldquo;end transmissions&rdquo;, <strong>keep reading</strong> <strong>new lines</strong> with information.</li>
<li>On the final line, you will receive &ldquo;Kill {name}&rdquo;</li>
</ul>
<h2>Output</h2>
<ul>
<li>On the first line, print &ldquo;Info on {name}:&rdquo;.</li>
<li>On the next lines, print &ldquo;---{info}: {value}&rdquo;</li>
<li>On the next line, print &ldquo;Info index: {infoIndex}&rdquo; with the <strong>info index </strong>of the selected person.</li>
<li>On the final line, print either &ldquo;Proceed&rdquo; or &ldquo;Need {infoNeeded} more info.&rdquo;, depending on whether the info is <strong>enough</strong> to carry out the hit or not.</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>There will <strong>always</strong> be at least <strong>one</strong> name in the input.</li>
<li>Each name will <strong>always </strong>have <strong>one or several</strong> <strong>key/value </strong>pairs associated with it.</li>
</ul>
<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
<h2>Examples</h2>
<table width="0">
<tbody>
<tr>
<td width="296">
<p><strong>Input</strong></p>
</td>
<td width="243">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="296">
<p>30</p>
<p>Kobin=age:20;salary:700</p>
<p>Grimsdottir=salary:5000</p>
<p>Kobin=education:High School</p>
<p>end transmissions</p>
<p>Kill Kobin</p>
</td>
<td width="243">
<p>Info on Kobin:</p>
<p>---age: 20</p>
<p>---education: High School</p>
<p>---salary: 700</p>
<p>Info index: 34</p>
<p>Proceed</p>
</td>
</tr>
<tr>
<td width="296">
<p>20</p>
<p>Lambert=age:57;salary:7000</p>
<p>Grimsdottir=salary:5000</p>
<p>John=salary:1550</p>
<p>John=lastName:Smith</p>
<p>John=salary:1800</p>
<p>Kobin=education:High School</p>
<p>end transmissions</p>
<p>Kill Lambert</p>
</td>
<td width="243">
<p>Info on Lambert:</p>
<p>---age: 57</p>
<p>---salary: 7000</p>
<p>Info index: 15</p>
<p>Need 5 more info.</p>
</td>
</tr>
<tr>
<td width="296">
<p>25</p>
<p>Bill=salary:900;lastName:Billov</p>
<p>Kobin=salary:1300</p>
<p>Kobin=education:High School</p>
<p>end transmissions</p>
<p>Kill Bill</p>
</td>
<td width="243">
<p>Info on Bill:</p>
<p>---lastName: Billov</p>
<p>---salary: 900</p>
<p>Info index: 23</p>
<p>Need 2 more info.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>