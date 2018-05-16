<h1>Problem 2 &ndash; Hornet Comm</h1>
<p>The Hornet Ex-King &ndash; Horny, has established an innovative technology providing communication for his fellow hornets, called Hornet Comm. Inc. Hornet Comm. provides functionality from private messages to wide broadcasts.</p>
<p>You will be given data of several tracked comm. channels, which you must decrypt. The input data will come in the following format:</p>
<p>{firstQuery} &lt;-&gt; {secondQuery}</p>
<p>If the <strong>first query</strong> consists <strong>only of digits</strong> and the <strong>second one</strong> consists of <strong>digits and / or letters</strong>, it is a <strong>private message</strong>.</p>
<p>If the <strong>first query</strong> consists of <strong>anything but digits</strong>, and the <strong>second one</strong> consists of <strong>letters and / or digits,</strong> it is a <strong>broadcast</strong>.</p>
<p>Any input that <strong>does</strong> <strong>NOT</strong> <strong>follow</strong> the format, specified above, should be <strong>IGNORED</strong>.</p>
<p>If the <strong>given data</strong> is a <strong>private message</strong>, the first query is the <strong>recipient&rsquo;s code</strong>, and the second query is the <strong>message</strong>. You must <strong>reverse</strong> the <strong>recipient&rsquo;s code</strong> and <strong>store</strong> it along with the message.</p>
<p>If the <strong>given data</strong> is a <strong>broadcast</strong>, the first query is the message, and the second query is the <strong>frequency</strong>. You must take the <strong>frequency</strong> and make <strong>all capital letters</strong> &ndash; <strong>small</strong> and <strong>all small letters</strong> &ndash; <strong>capital</strong>. Then you must <strong>store</strong> it, along with the <strong>message</strong>.</p>
<p>You must <strong>keep</strong> all input broadcasts and messages after you <strong>decrypt</strong> them.</p>
<p>When you receive the command &ldquo;<strong>Hornet is Green</strong>&rdquo;, the input sequences <strong>ends</strong>, and you must print the stored broadcasts and messages.</p>
<h3>Input</h3>
<ul>
<li>The input comes in the form of several input lines in the format specified above.</li>
<li>The input ends when you receive the command &ldquo;<strong>Hornet is Green</strong>&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print all broadcasts and messages, printing first the broadcasts, in the following format:
<ul>
<li>Broadcasts:</li>
<li>{frequency} -&gt; {message}</li>
<li>. . .</li>
<li>Messages:</li>
<li>{recipient} -&gt; {message}</li>
<li>. . .</li>
</ul>
</li>
<li>If there are <strong>no messages</strong>, or <strong>no broadcasts</strong>, print &ldquo;<strong>None</strong>&rdquo; in their place.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The input lines may consist of <strong>any ASCII</strong></li>
<li>There will be <strong>NO</strong> more than 1000 lines of input.</li>
<li><strong>All data</strong> must be printed in <strong>order of input</strong>.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>213094 &lt;-&gt; BeeQueenDown</p>
<p>213094 &lt;-&gt; Repeat</p>
<p>Foxtrot &lt;-&gt; 123321</p>
<p>213094 &lt;-&gt; BeeQueenDown</p>
<p>Unicorn &lt;-&gt; 871203</p>
<p>Charlie &lt;-&gt; 56210</p>
<p>Kilo &lt;-&gt; 423211</p>
<p>Hornet is Green</p>
</td>
<td width="189">
<p>Broadcasts:</p>
<p>123321 -&gt; Foxtrot</p>
<p>871203 -&gt; Unicorn</p>
<p>56210 -&gt; Charlie</p>
<p>423211 -&gt; Kilo</p>
<p>Messages:</p>
<p>490312 -&gt;BeeQueenDown</p>
<p>490312 -&gt;Repeat</p>
<p>490312 -&gt;BeeQueenDown</p>
</td>
</tr>
<tr>
<td width="205">
<p>&lt;+&gt;.&lt;+&gt; &lt;-&gt; az13b6</p>
<p>&lt;-&gt;.&lt;-&gt; &lt;-&gt; P2Z4x789</p>
<p>12345 &lt;-&gt; Pr1v@teM3ssage</p>
<p>Hornet is Green</p>
</td>
<td width="189">
<p>Broadcasts:</p>
<p>AZ13B6 -&gt; &lt;+&gt;.&lt;+&gt;</p>
<p>p2z4X789 -&gt; &lt;-&gt;.&lt;-&gt;</p>
<p>Messages:</p>
<p>None</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>