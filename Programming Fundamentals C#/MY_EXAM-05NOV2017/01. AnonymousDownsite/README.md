<h1>Problem 1. Anonymous Downsite</h1>
<p>The Anonymous informal group of activists have hacked a few commercial websites and the CIA has hired you to write a software which calculates the losses. Based on the given data, use the appropiate data types.</p>
<p>You will receive <strong>2 input lines </strong>&ndash; each containing an <strong>integer</strong>.</p>
<ul>
<li>The <strong>first</strong> is <strong>N</strong> &ndash; the <strong>number</strong> of <strong>websites</strong> which are down.</li>
<li>The <strong>second</strong> is the security key.</li>
</ul>
<p>On the <strong>next N lines</strong> you will receive <strong>data</strong> about <strong>websites</strong> in the following format:<br /> {siteName} {siteVisits} {siteCommercialPricePerVisit}</p>
<p>You must <strong>calculate</strong> the site loss by the following formula: siteVisits * siteCommercialPricePerVisit</p>
<p>When you <strong>finish reading all data</strong>, you must print the <strong>affected sites&rsquo; names</strong> &ndash; each on a <strong>new line</strong>.<br /> Then you must print the total money loss &ndash; <strong>sum</strong> of all site loss, on a <strong>new line</strong>.<br /> Finally you must print the security token, which is the security key, <strong>POWERED</strong> by the <strong>COUNT </strong>of <strong>affected sites</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the <strong>first input line</strong> you will get <strong>N</strong> &ndash; the <strong>count </strong>of <strong>affected websites</strong>.</li>
<li>On the <strong>second input line</strong> you will the <strong>security key</strong>.</li>
<li>On the <strong>next N input lines</strong> you will get <strong>data</strong> about the <strong>websites</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print <strong>all affected websites&rsquo; names</strong> &ndash; <strong>each</strong> on a <strong>new line</strong>.</li>
<li><strong>After</strong> the <strong>website names</strong> you must print the <strong>total loss </strong>of<strong> data</strong>, printed to the <strong>20<sup>th</sup> digit</strong> after the <strong>decimal point</strong>. The format is &ldquo;Total Loss: {totalLoss}&rdquo;.</li>
<li>Finally you must <strong>print</strong> the <strong>security token</strong>. The format is &ldquo;Security Token: {securityToken}&rdquo;.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The integer <strong>N</strong> will be in <strong>range</strong> <strong>[0, 100]</strong>.</li>
<li>The <strong>security token</strong> will be in<strong> range</strong> <strong>[0, 10]</strong>.</li>
<li>The <strong>website name</strong> may contain any <strong>ASCII character</strong> except <strong>whitespace</strong>.</li>
<li>The <strong>site visits</strong> will be an <strong>integer</strong> in <strong>range [0, 2<sup>31</sup>].</strong></li>
<li>The <strong>price per visit</strong> will be a <strong>floating point number</strong> in <strong>range [0, 100]</strong> and will have <strong>up</strong> to <strong>20 digits</strong> after the decimal point.</li>
<li>Allowed working <strong>time/memory</strong>: <strong>100ms / 16MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="261">
<p><strong>Input</strong></p>
</td>
<td width="350">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="261">
<p>3</p>
<p>8</p>
<p>www.google.com 122300 94.23233</p>
<p>www.abv.bg 2333 11</p>
<p>www.kefche.com 12322 23.3222</p>
</td>
<td width="350">
<p>www.google.com</p>
<p>www.abv.bg</p>
<p>www.kefche.com</p>
<p>Total Loss: 11837653.10740000000000000000</p>
<p>Security Token: 512</p>
</td>
</tr>
<tr>
<td width="261">
<p>1</p>
<p>1</p>
<p>www.facebook.com 100000 10.45</p>
</td>
<td width="350">
<p>www.facebook.com</p>
<p>Total Loss: 1045000.00000000000000000000</p>
<p>Security Token: 1</p>
</td>
</tr>
</tbody>
</table>
<p><em>Remember, remember!</em></p>
<p><em>The fifth of November...</em></p>