<h1>Problem 2. Pokemon Don&rsquo;t Go</h1>
<p>Ely likes to play Pokemon Go a lot. But Pokemon Go bankrupted &hellip; So the developers made Pokemon Don&rsquo;t Go out of depression. And so Ely now plays Pokemon Don&rsquo;t Go. In Pokemon Don&rsquo;t Go, when you walk to a certain pokemon, those closer to you, naturally get further, and those further from you, get closer.</p>
<p>You will receive a <strong>sequence</strong> of <strong>integers</strong>, separated by <strong>spaces</strong> &ndash; the distances to the pokemons.<br /> Then you will begin <strong>receiving integers</strong>, which will <strong>correspond</strong> to <strong>indexes</strong> in <strong>that</strong> <strong>sequence</strong>.</p>
<p>When you <strong>receive</strong> an <strong>index</strong>, you must <strong>remove</strong> the <strong>element</strong> at <strong>that index</strong> from the <strong>sequence</strong> (as if you&rsquo;ve captured the pokemon).</p>
<ul>
<li>You must <strong>INCREASE</strong> the <strong>value</strong> of <strong>all elements</strong> in the sequence which are <strong>LESS</strong> or <strong>EQUAL</strong> to the <strong>removed element</strong>, with the <strong>value</strong> of the <strong>removed element</strong>.</li>
<li>You must <strong>DECREASE</strong> the <strong>value</strong> of <strong>all elements</strong> in the sequence which are <strong>GREATER</strong> than the <strong>removed element</strong>, with the <strong>value</strong> of the <strong>removed element</strong>.</li>
</ul>
<p>If the <strong>given index</strong> is <strong>LESS</strong> than <strong>0</strong>, <strong>remove</strong> the <strong>first element</strong> of the <strong>sequence</strong>, and <strong>COPY</strong> the <strong>last element</strong> to its place.</p>
<p>If the <strong>given index</strong> is <strong>GREATER </strong>than the <strong>last index </strong>of the <strong>sequence</strong>, <strong>remove</strong> the <strong>last element</strong> from the sequence, and <strong>COPY</strong> the <strong>first element</strong> to its place.</p>
<p>The <strong>increasing</strong> and <strong>decreasing</strong> of elements should be done in these cases, <strong>also</strong>. The <strong>element</strong>, whose value you should use is the <strong>REMOVED</strong> element.</p>
<p>The program <strong>ends</strong> when the <strong>sequence</strong> has <strong>no elements</strong> (there are no pokemons left for Ely to catch).</p>
<h3>Input</h3>
<ul>
<li>On the <strong>first line</strong> of input you will receive a <strong>sequence</strong> of <strong>integers</strong>, <strong>separated</strong> by <strong>spaces</strong>.</li>
<li>On the <strong>next several</strong> lines you will receive <strong>integers</strong> &ndash; the <strong>indexes</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>When the program ends, you must print on the console, the <strong>summed up</strong> <strong>value</strong> of <strong>all REMOVED elements</strong>.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The input data will consist <strong>ONLY</strong> of <strong>valid integers</strong> in the <strong>range [-2.147.483.648, 2.147.483.647]</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="123">
<p><strong>Output</strong></p>
</td>
<td width="406">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>4 5 3</p>
<p>1</p>
<p>1</p>
<p>0</p>
</td>
<td width="123">
<p>14</p>
</td>
<td width="406">
<p>The <strong>array</strong> is {4, 5, 3}. The index is 1.</p>
<p>We <strong>remove</strong> 5, and we <strong>increase all</strong> <strong>lower</strong> than it and <strong>decrease all higher</strong> than it.</p>
<p>In this case there are <strong>no higher</strong> than 5.</p>
<p>The result is {9, 8}.</p>
<p>The <strong>index</strong> is 1. So we remove 8, and <strong>decrease all higher</strong> than it.</p>
<p>The result is {1}.</p>
<p>The <strong>index</strong> is 0. So we remove 1.</p>
<p>There are <strong>no elements</strong> <strong>left</strong>, so we print the <strong>sum </strong>of <strong>all removed elements</strong>.</p>
<p>5 + 8 + 1 = 14.</p>
</td>
</tr>
<tr>
<td width="140">
<p>5 10 6 3 5</p>
<p>2</p>
<p>4</p>
<p>1</p>
<p>1</p>
<p>3</p>
<p>0</p>
<p>0</p>
</td>
<td width="123">
<p>51</p>
</td>
<td width="406">
<p><strong>Step 1</strong>: {11, 4, 9, 11}</p>
<p><strong>Step 2</strong>: {22, 15, 20, 22}</p>
<p><strong>Step 3</strong>: {7, 5, 7}</p>
<p><strong>Step 4</strong>: {2, 2}</p>
<p><strong>Step 5</strong>: {4, 4}</p>
<p><strong>Step 6</strong>: {8}</p>
<p><strong>Step 7</strong>: {} <strong>(empty).</strong></p>
<p><strong>Result</strong> = 6 + 11 + 15 + 5 + 2 + 4 + 8 = 51.</p>
</td>
</tr>
</tbody>
</table>