<h1>Problem 3. Anonymous Vox</h1>
<p>The Anonymous&rsquo;s main communication channel is based on encoded messages. The CIA has targetted that channel, assuming that it holds sensitive information. You have been hired to decode and break their internal com. system.</p>
<p>You will receive an input line containing a <strong>single string</strong> &ndash; the <strong>encoded text</strong>. Then, on the <strong>next line</strong> you will receive several values in the following format: &ldquo;{value1}{value2}{value3}...&rdquo;.</p>
<p>You must find the <strong>encoded placeholders</strong> in the <strong>text</strong> and <strong>REPLACE</strong> each one of them with the <strong>value</strong> that corresponds to its <strong>index</strong>. <br /> <strong>Example</strong>: <strong>placeholder1 &ndash; value1</strong>, <strong>placeholder2 &ndash; value2</strong> etc. There may be <strong>more values</strong> than <strong>placeholders</strong> or <strong>more placeholders</strong> than <strong>values</strong>.</p>
<p>The <strong>placeholders</strong> consist of 3 blocks {start}{placeholder}{end}. The <strong>start</strong> should consist only of <strong>English alphabet letters</strong>. The <strong>placeholder</strong> may contain <strong>ANY ASCII</strong> character. The <strong>end</strong> should be <strong>EXACTLY EQUAL </strong>to the <strong>start</strong>. The idea is that you have to find the <strong>placeholders</strong>, and <strong>REPLACE</strong> their placeholder block with the <strong>value</strong> at that <strong>index</strong>.</p>
<p>Example Placeholders: &ldquo;a.....a&rdquo;, &ldquo;b!d!b&rdquo;, &ldquo;asdxxxxxasd&rdquo;, &ldquo;peshogoshopesho&rdquo;...</p>
<p>You <strong>must</strong> <strong>ALWAYS</strong> match the placeholder with the <strong>LONGEST</strong> start and the <strong>RIGHTMOST</strong> end. For example if you have &ldquo;asddvdasd&rdquo; you should <strong>NOT</strong> match &ldquo;dvd&rdquo; as a placeholder, you should match &ldquo;asddvdasd&rdquo;.</p>
<p>At the end you must <strong>print</strong> the <strong>result</strong> <strong>text</strong>, after you&rsquo;ve <strong>replaced</strong> the <strong>values</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the <strong>first input line</strong> you will receive the <strong>encoded text</strong>.</li>
<li>On the <strong>second input line</strong> you will receive the <strong>placeholders</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print a <strong>single line</strong> containing the <strong>resulting text</strong>, after the replacing of values.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The <strong>given</strong> <strong>text</strong> may contain <strong>ANY ASCII</strong></li>
<li>The <strong>given values</strong> may contain <strong>ANY ASCII</strong> character except &lsquo;{&rsquo; and &lsquo;}&rsquo;.</li>
<li>The <strong>given values</strong> will <strong>AWLAYS</strong> follow the format specified above.</li>
<li>Allowed working <strong>time/memory</strong>: <strong>100ms / 16MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="328">
<p><strong>Input</strong></p>
</td>
<td width="324">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="328">
<p>Hello_mister,_Hello</p>
<p>{ Jack }</p>
</td>
<td width="324">
<p>Hello Jack Hello</p>
</td>
</tr>
<tr>
<td width="328">
<p>ASD___asdfffasd</p>
<p>{this}{exam}{problem}{is}{boring}</p>
</td>
<td width="324">
<p>ASD___asdthisasd</p>
</td>
</tr>
<tr>
<td width="328">
<p>Whatsup_ddd_sup</p>
<p>{Dude}</p>
</td>
<td width="324">
<p>WhatsupDudesup</p>
</td>
</tr>
<tr>
<td width="328">
<p>HeypalHey______how_ya_how_doin_how</p>
<p>{first}{second}</p>
</td>
<td width="324">
<p>HeyfirstHey______howsecondhow</p>
</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>
<p><em>...I know of no reason...</em></p>