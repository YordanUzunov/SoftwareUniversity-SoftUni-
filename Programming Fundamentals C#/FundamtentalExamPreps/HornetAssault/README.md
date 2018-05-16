<h1>Problem 3 &ndash; Hornet Assault</h1>
<p>The hornets are preparing an assault on beehives. It takes very little amount of hornets to annihilate a beehive, but the bees are far from defenseless. You must calculate how many beehives, can the hornets annihilate, before they die.</p>
<p>You will be given a <strong>sequence of integers</strong>, separated by a <strong>space</strong>. The integers will represent the <strong>beehives</strong> and the <strong>amount of bees</strong> in them. You will then receive <strong>another</strong> sequence of integers, which will represent the <strong>hornets</strong>, and their <strong>power</strong>. The <strong>power</strong> indicates <strong>how many bees</strong> a hornet can <strong>kill</strong>.</p>
<p>The hornets must <strong>start attacking</strong> the beehives <strong>one</strong> by <strong>one</strong>. If the bees are <strong>more</strong> or <strong>equal to</strong> the <strong>summed-up power</strong> of the <strong>hornets</strong>, the <strong>first</strong> (<strong>entered</strong>) hornet, <strong>currently alive</strong>, <strong>dies</strong> in the assault of the<strong> current beehive</strong>.</p>
<p>When the hornets assault a beehive, they <strong>kill</strong> an <strong>amount of bees</strong>, <strong>equal</strong> to their <strong>summed-up power</strong>. This means that you must <strong>decrease</strong> the <strong>integer</strong> of the <strong>beehive</strong>, with the <strong>value</strong> of the summed-up power, of the <strong>live hornets</strong>.</p>
<p>After you&rsquo;ve successfully assaulted all beehives, you must print the result of the <strong>winning side</strong>. If there are <strong>ANY</strong> <strong>beehives</strong> with <strong>live bees</strong> inside them, you must print them. If there aren&rsquo;t, you must print the <strong>live hornets</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the first line of input you will receive a sequence of integers, separated by <strong>spaces</strong> &ndash; the <strong>beehives</strong>.</li>
<li>On the second line of input you will receive a sequence of integers, separated by <strong>spaces</strong> &ndash; the <strong>hornets</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>Depending on the case of printing you must either print the <strong>live</strong> beehives, or the <strong>live</strong></li>
<li>They are sequences of integers, so in both cases you must print them <strong>separated</strong> by a <strong>space</strong>.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The input will consist only of integers in <strong>range [0</strong><strong>; 1</strong><strong>,000</strong><strong>,000]</strong>.</li>
<li>There will be <strong>NO</strong> <strong>STALEMATE</strong></li>
<li>The input sequences may consist of up to <strong>3000</strong></li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="165">
<p><strong>Input</strong></p>
</td>
<td width="110">
<p><strong>Output</strong></p>
</td>
<td width="429">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="165">
<p>20 10 20 30</p>
<p>5 10 5 3</p>
</td>
<td width="110">
<p>7</p>
</td>
<td width="429">
<p>The <strong>summed power</strong> of the <strong>hornets</strong> is 23.<br /> They kill the first <strong>3 beehives</strong>, due to overwhelming power.</p>
<p>&nbsp;</p>
<p>The last beehive has <strong>higher value</strong>, and its left with <strong>7 bees</strong> <strong>alive</strong> inside it. The <strong>first hornet</strong> (<strong>5</strong>) <strong>dies</strong>.</p>
<p>All other beehives <strong>are dead</strong>, so we print <strong>only this one</strong>.</p>
</td>
</tr>
<tr>
<td width="165">
<p>10 20 10 15</p>
<p>5 6 7</p>
</td>
<td width="110">
<p>2 2</p>
</td>
<td width="429">
<p>The <strong>summed power</strong> is <strong>18</strong>. The first beehive dies. In the second one, 18 bees die, but due to higher power, the <strong>first hornet</strong> (<strong>5</strong>) <strong>dies</strong>.</p>
<p>&nbsp;</p>
<p>Now the <strong>summed power</strong> is <strong>13</strong>. The third beehive dies, but the fourth one has <strong>higher</strong> value. <strong>13 bees die</strong> from the <strong>fourth</strong> beehive and the <strong>current first hornet</strong> (<strong>6</strong>) <strong>dies</strong>.</p>
<p>We have the <strong>second</strong> and the <strong>fourth</strong> beehive with <strong>2 bees</strong>, each, so we print them.</p>
</td>
</tr>
<tr>
<td width="165">
<p>20 100 40 45 20 10</p>
<p>40 10 5 40 5</p>
</td>
<td width="110">
<p>10 5 40 5</p>
</td>
<td width="429">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>