<h1>Problem 3. Regexmon</h1>
<p><br /> Bojomon and Didimon are both pokemons which like to capture specific elements from a text. But they always fight so they decided to take turns in capturing things. Didimon is <strong>first</strong>, of course, because &ldquo;ladies first&rdquo;.</p>
<p><strong>Bojomon</strong> matches only <strong>pokewords</strong>. <br /> A <strong>pokeword</strong> consists of <strong>2 sequences</strong> of <strong>alphabet letters</strong>, separated by a <strong>dash</strong> (&lsquo;-&rsquo;). <strong>Example</strong>: &ldquo;pika-pika&rdquo;</p>
<p><strong>Didimon</strong> matches everything <strong>EXCEPT</strong> <strong>alphabet letters</strong> and <strong>dashes</strong>.</p>
<p>You will get a <strong>single string</strong>, containing random ASCII characters, from the input.</p>
<p><strong>Didimon starts first</strong>. If she <strong>finds</strong> a <strong>match</strong>, she prints it on the console, and <strong>switches</strong> <strong>turns</strong> with Bojomon.</p>
<p>Then Bojomon starts matching <strong>AFTER</strong> <strong>Didimon&rsquo;s match</strong>, <strong>IGNORING</strong> everything <strong>before</strong> it, from the string. When he finds a match, he prints it and <strong>switches turns</strong> with <strong>Didimon</strong>, and she starts matching <strong>AFTER</strong> Bojomon&rsquo;s match.</p>
<p>This process <strong>repeats</strong> until <strong>the one</strong> who is <strong>at turn</strong> does <strong>NOT</strong> match <strong>anything</strong> till the end of the string.</p>
<p><strong>Example</strong>: &ldquo;!!!aa-aa?_?&rdquo;</p>
<ol>
<li><strong>Didimon</strong> matches &ldquo;!!!&rdquo;, then she <strong>switches</strong> with Bojomon.</li>
<li>Bojomon <strong>starts after Didimon&rsquo;s match</strong> and so he has &ldquo;aa-aa?_?&rdquo;. He matches &ldquo;aa-aa&rdquo; and <strong>switches</strong> with Didimon.</li>
<li>Didimon <strong>starts after Bojomon&rsquo;s match</strong> and so she has &ldquo;?_?&rdquo;. She matches &ldquo;?_?&rdquo; and <strong>switches</strong> with Bojomon again.</li>
<li>Bojomon <strong>starts after Didimon&rsquo;s match</strong> and so he has &ldquo;&rdquo; (<strong>empty string</strong>). He matches <strong>nothing</strong> and the program <strong>ends</strong>.</li>
</ol>
<h3>Input</h3>
<ul>
<li>The input will consist of a <strong>single line</strong>, containing the <strong>text</strong>, that Bojomon and Didimon are going to match.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you should print Bojomon and Didimon&rsquo;s <strong>matches</strong>, each on a <strong>new line</strong>.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The input string may contain <strong>any ASCII character</strong>.</li>
<li>Allowed time / memory: <strong>100ms / 16MB</strong>.</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="127">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>^^^^pika-pika^^^^</p>
</td>
<td width="127">
<p>^^^^</p>
<p>pika-pika</p>
<p>^^^^</p>
</td>
</tr>
<tr>
<td width="297">
<p>!.!asd-asd---??!chuuuu!!!asd-dsa</p>
</td>
<td width="127">
<p>!.!</p>
<p>asd-asd</p>
<p>??!</p>
<p>asd-dsa</p>
</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>