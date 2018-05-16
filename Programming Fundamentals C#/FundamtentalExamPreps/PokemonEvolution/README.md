<h1>Problem 4. Pokemon Evolution</h1>
<p>You have been tasked to keep track of pokemons and their evolutions. A pokemon can evolve in several phases and types. When it evolves, the pokemon has an evolution index, which indicates how much it has evolved.</p>
<p>You will receive input lines in the following format:<br /> {pokemonName} -&gt; {evolutionType} -&gt; {evolutionIndex}</p>
<p>The pokemonName and evolutionType will be <strong>strings</strong>. The evolutionIndex will be an <strong>integer</strong>. Your task is to store every <strong>pokemon</strong> and his <strong>evolutions</strong>. <br /> If you receive an existent pokemonName, you should <strong>add</strong> the <strong>new</strong> <strong>evolution</strong> to it.</p>
<p>A single <strong>pokemon</strong> may have <strong>many evolutions</strong> with the <strong>same type </strong>and the <strong>same index</strong>.</p>
<p>In some rare cases you may receive the following input:<br /> {pokemonName}</p>
<p>When you receive only a pokemonName, you must <strong>check if there is</strong> such a <strong>pokemon</strong>, and if there is, you must print all of its <strong>evolutions</strong> by <strong>order of input</strong>.</p>
<p>The <strong>input sequence ends</strong> when you <strong>receive</strong> the command &ldquo;wubbalubbadubdub&rdquo;. <br /> Then you must print all pokemons and their evolutions. The pokemons must be printed by <strong>order of input</strong>. Each <strong>pokemon&rsquo;s evolutions</strong> must be <strong>ordered</strong> by <strong>evolution index </strong>in <strong>descending order</strong>.</p>
<h3>Input</h3>
<ul>
<li>The input will come in the form of lines in the format specified above.</li>
<li>In some rare cases you may have only one element of the input &ndash; the pokemonName.</li>
<li>The input sequence ends when you receive the command &ldquo;wubbalubbadubdub&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li><strong>Pokemons</strong> and their <strong>evolutions</strong> must be printed in the following format:</li>
</ul>
<p>&ldquo;# {pokemoName}<br /> &nbsp;{evolution1Type} &lt;-&gt; {evolution1Index}<br /> &nbsp;{evolution2Type} &lt;-&gt; {evolution2Index}</p>
<p>&nbsp;&hellip;&rdquo;</p>
<ul>
<li>If you have received a pokemonName and you are <strong>printing its evolutions</strong>, the order is &ndash; by <strong>order of input</strong>.</li>
<li>If you have received the <strong>ending command</strong>, and you are printing the <strong>pokemons&rsquo; evolutions</strong>, the order is &ndash; by evolutionIndex in <strong>descending order</strong>.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The pokemonName and evolutionType are strings which may contain any ASCII character <br /> (except &lsquo;-&rsquo;, &lsquo; &rsquo;, &lsquo;&gt;&rsquo;).</li>
<li>The evolutionIndex will be an <strong>integer</strong> in <strong>range [0, 1.000.000.000]</strong>.</li>
<li>There will be <strong>NO invalid</strong> input data.</li>
<li>Allowed time / memory: <strong>100ms / 16 MB</strong>.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="181">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>Ekans -&gt; Hybrid -&gt; 100</p>
<p>Nidoran -&gt; Physical -&gt; 150</p>
<p>Ekans -&gt; Psychological -&gt; 50</p>
<p>Jigglypuff -&gt; Hybrid -&gt; 1000</p>
<p>Jigglypuff -&gt; Physical -&gt; 2000</p>
<p>wubbalubbadubdub</p>
</td>
<td width="181">
<p># Ekans</p>
<p>Hybrid &lt;-&gt; 100</p>
<p>Psychological &lt;-&gt; 50</p>
<p># Nidoran</p>
<p>Physical &lt;-&gt; 150</p>
<p># Jigglypuff</p>
<p>Physical &lt;-&gt; 2000</p>
<p>Hybrid &lt;-&gt; 1000</p>
</td>
</tr>
<tr>
<td width="297">
<p>Pikachu -&gt; Hybrid -&gt; 100</p>
<p>Meowth -&gt; Physical -&gt; 100</p>
<p>Pikachu -&gt; Psychological -&gt; 50</p>
<p>Meowth -&gt; Physical -&gt; 50</p>
<p>Pikachu -&gt; Hybrid -&gt; 150</p>
<p>Meowth</p>
<p>Pikachu</p>
<p>wubbalubbadubdub</p>
</td>
<td width="181">
<p># Meowth</p>
<p>Physical &lt;-&gt; 100</p>
<p>Physical &lt;-&gt; 50</p>
<p># Pikachu</p>
<p>Hybrid &lt;-&gt; 100</p>
<p>Psychological &lt;-&gt; 50</p>
<p>Hybrid &lt;-&gt; 150</p>
<p># Pikachu</p>
<p>Hybrid &lt;-&gt; 150</p>
<p>Hybrid &lt;-&gt; 100</p>
<p>Psychological &lt;-&gt; 50</p>
<p># Meowth</p>
<p>Physical &lt;-&gt; 100</p>
<p>Physical &lt;-&gt; 50</p>
</td>
</tr>
</tbody>
</table>