<h1>Problem 2. Anonymous Threat</h1>
<p>The Anonymous have created a cyber hypervirus which steals data from the CIA. You, as the lead security developer in CIA, have been tasked to analyze the software of the virus and observe its actions on the data. The virus is known for his innovative and unbeleivably clever technique of merging and dividing data into partitions.</p>
<p>You will receive a <strong>single input line</strong> containing <strong>STRINGS</strong> separated by <strong>spaces</strong>. <br /> The strings may contain <strong>any ASCII</strong> character except <strong>whitespace</strong>.</p>
<p>You will then begin receiving commands in one of the following formats:</p>
<ul>
<li>merge {startIndex} {endIndex}</li>
<li>divide {index} {partitions}</li>
</ul>
<p>Every time you receive the merge command, you must merge all elements from the startIndex, till the endIndex. In other words, you should concatenate them. <br /> <strong>Example</strong>: {abc, def, ghi} -&gt; merge 0 1 -&gt; {abcdef, ghi}</p>
<p>If <strong>any </strong>of the <strong>given indexes</strong> is <strong>out of the array</strong>, you must take <strong>ONLY </strong>the <strong>range</strong> that is <strong>INSIDE</strong> the <strong>array</strong> and <strong>merge</strong> it.</p>
<p>Every time you receive the divide command, you must <strong>DIVIDE</strong> the <strong>element</strong> at the <strong>given index</strong>, into<strong> several small substrings </strong>with <strong>equal length</strong>. The <strong>count</strong> of the <strong>substrings</strong> should be <strong>equal</strong> to the <strong>given partitions</strong>.</p>
<p><strong>Example</strong>: {abcdef, ghi, jkl} -&gt; divide 0 3 -&gt; {ab, cd, ef, ghi, jkl}</p>
<p>If the string <strong>CANNOT</strong> be <strong>exactly</strong> <strong>divided</strong> into the <strong>given partitions</strong>, <strong>make all partitions</strong> <strong>except</strong> the <strong>LAST</strong> with <strong>EQUAL LENGTHS</strong>, and make the <strong>LAST one</strong> &ndash; <strong>the</strong> <strong>LONGEST</strong>.</p>
<p><strong>Example</strong>: {abcd, efgh, ijkl} -&gt; divide 0 3 -&gt; {a, b, cd, efgh, ijkl}</p>
<p>The <strong>input ends</strong> when you receive the command &ldquo;3:1&rdquo;. At that point you must print the <strong>resulting elements</strong>, <strong>joined</strong> by a <strong>space</strong>.</p>
<h3>Input</h3>
<ul>
<li>The <strong>first input line</strong> will contain the <strong>array</strong> of <strong>data</strong>.</li>
<li>On the <strong>next several input</strong> lines you will <strong>receive commands</strong> in the <strong>format specified above</strong>.</li>
<li>The <strong>input ends</strong> when you receive the command &ldquo;3:1&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print a single line containing the elements of the array, <strong>joined</strong> by a <strong>space</strong>.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The <strong>strings</strong> in the <strong>array</strong> may contain any <strong>ASCII character</strong> except <strong>whitespace</strong>.</li>
<li>The startIndex and the endIndex will be in <strong>range [-1000, 1000]</strong>.</li>
<li>The endIndex will <strong>ALWAYS</strong> be <strong>GREATER</strong> than the startIndex.</li>
<li>The index in the divide command will <strong>ALWAYS</strong> be <strong>INSIDE</strong> the array.</li>
<li>The partitions will be in <strong>range [0, 100]</strong>.</li>
<li>Allowed working <strong>time/memory</strong>: <strong>100ms / 16MB</strong>.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="328">
<p><strong>Input</strong></p>
</td>
<td width="336">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="328">
<p>Ivo Johny Tony Bony Mony</p>
<p>merge 0 3</p>
<p>merge 3 4</p>
<p>merge 0 3</p>
<p>3:1</p>
</td>
<td width="336">
<p>IvoJohnyTonyBonyMony</p>
</td>
</tr>
<tr>
<td width="328">
<p>abcd efgh ijkl mnop qrst uvwx yz</p>
<p>merge 4 10</p>
<p>divide 4 5</p>
<p>3:1</p>
</td>
<td width="336">
<p>abcd efgh ijkl mnop qr st uv wx yz</p>
</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>
<p><em>...The Gunpowder treason and plot;...</em></p>