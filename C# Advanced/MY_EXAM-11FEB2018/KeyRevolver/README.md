<h1>Problem 1 &ndash; Key Revolver</h1>
<p>Our favorite super-spy action hero Sam is back from his mission in another exam, and this time he has an even more difficult task. He needs to <strong>unlock a</strong> <strong>safe</strong>. The problem is that the safe is <strong>locked</strong> by <strong>several locks in a row</strong>, which all have <strong>varying</strong> <strong>sizes</strong>.</p>
<p>Our hero posesses a special weapon though, called the <strong>Key Revolver</strong>, with special bullets. Each <strong>bullet </strong>can unlock a <strong>lock </strong>with a <strong>size</strong> <strong>equal to or larger</strong> <strong>than</strong> the <strong>size</strong> of the <strong>bullet</strong>. The bullet goes into the keyhole, then explodes, completely <strong>destroying</strong> it. Sam <strong>doesn&rsquo;t know the size</strong> of the locks, so he needs to just shoot at all of them, until the safe runs out of locks.</p>
<p>What&rsquo;s behind the safe, you ask? Well, intelligence! It is told that Sam&rsquo;s sworn enemy &ndash; <strong>Nikoladze</strong>, keeps his <strong>top secret</strong> <strong>Georgian</strong> <strong>Chacha Brandy </strong>recipe inside. It&rsquo;s valued differently across different times of the year, so Sam&rsquo;s boss will tell him what it&rsquo;s worth over the radio. One last thing, every bullet Sam fires will also cost him money, w<strong>hich will be deducted from his pay</strong> from the price of the intelligence.</p>
<p>Good luck, operative.</p>
<h2>Input</h2>
<ul>
<li>On the <strong>first line</strong> of input, you will receive the price of each <strong>bullet</strong> &ndash; an <strong>integer</strong> <strong>in the range [0-100]</strong></li>
<li>On the <strong>second line</strong>, you will receive the <strong>size of the gun barrel</strong> &ndash; an <strong>integer</strong> <strong>in the range [1-5000]</strong></li>
<li>On the <strong>third line</strong>, you will receive the <strong>bullets</strong> &ndash; a <strong>space-separated integer sequence</strong> with <strong>[1-100] integers</strong></li>
<li>On the <strong>fourth line</strong>, you will receive the <strong>locks</strong> &ndash; a <strong>space-separated integer sequence</strong> with <strong>[1-100] integers</strong></li>
<li>On the <strong>fifth</strong> <strong>line</strong>, you will receive the <strong>value of the intelligence</strong> &ndash; an<strong> integer</strong> <strong>in the range [1-100000]</strong></li>
</ul>
<p>After Sam receives all of his information and gear (<strong>input</strong>), he starts to <strong>shoot the locks</strong> <strong>front-to-back</strong>, while going through the bullets <strong>back-to-front</strong>.</p>
<p>If the <strong>bullet</strong> has a <strong>smaller or equal</strong> size to the <strong>current</strong> <strong>lock</strong>, print &ldquo;Bang!&rdquo;, then <strong>remove the lock</strong>. If not, print &ldquo;Ping!&rdquo;, leaving the lock <strong>intact</strong>. The bullet is removed in <strong>both cases</strong>.</p>
<p>If Sam runs out of bullets in his barrel, print &ldquo;Reloading!&rdquo; on the console, then continue shooting. If there aren&rsquo;t any bullets left, <strong>don&rsquo;t</strong> print it.</p>
<p>The program ends when Sam <strong>either</strong> <strong>runs out of bullets</strong>, or the safe <strong>runs out of</strong> <strong>locks</strong>.</p>
<h2>Output</h2>
<ul>
<li>If Sam <strong>runs out of bullets</strong> before the safe runs out of <strong>locks</strong>, print:<br /> &ldquo;Couldn't get through. Locks left: {locksLeft}&rdquo;</li>
<li>If Sam manages to <strong>open the safe</strong>, print:<br /> &ldquo;{bulletsLeft} bullets left. Earned ${moneyEarned}&rdquo;</li>
</ul>
<p>Make sure to account for the <strong>price of the bullets</strong> when calculating the <strong>money earned</strong>.</p>
<h2>Constraints</h2>
<ul>
<li>The input will be <strong>within the constaints</strong> specified above and will <strong>always be valid</strong>. There is <strong>no need</strong> to check it explicitly.</li>
<li>There will <strong>never</strong> be a case where Sam breaks the lock and ends up with <strong>negative balance</strong>.</li>
</ul>
<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
<h2>Examples</h2>
<table width="0">
<tbody>
<tr>
<td width="160">
<p><strong>Input</strong></p>
</td>
<td width="297">
<p><strong>Output</strong></p>
</td>
<td width="224">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="160">
<p>50</p>
<p>2</p>
<p>11 10 5 11 10 20</p>
<p>15 13 16</p>
<p>1500</p>
</td>
<td width="297">
<p>Ping!</p>
<p>Bang!</p>
<p>Reloading!</p>
<p>Bang!</p>
<p>Bang!</p>
<p>Reloading!</p>
<p>2 bullets left. Earned $1300</p>
</td>
<td width="224">
<p>20 shoots lock 15 (ping)</p>
<p>10 shoots lock 15 (bang)</p>
<p>11 shoots lock 13 (bang)</p>
<p>&nbsp;5 shoots lock 16 (bang)</p>
<p>&nbsp;</p>
<p>Bullet cost: 4 * 50 = $200</p>
<p>Earned: 1500 &ndash; 200 = $1300</p>
</td>
</tr>
<tr>
<td width="160">
<p>20</p>
<p>6</p>
<p>14 13 12 11 10 5</p>
<p>13 3 11 10</p>
<p>800</p>
</td>
<td width="297">
<p>Bang!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Ping!</p>
<p>Couldn't get through. Locks left: 3</p>
</td>
<td width="224">
<p>&nbsp;5 shoots lock 13 (bang)</p>
<p>10 shoots lock&nbsp; 3 (ping)</p>
<p>11 shoots lock&nbsp; 3 (ping)</p>
<p>12 shoots lock&nbsp; 3 (ping)</p>
<p>13 shoots lock&nbsp; 3 (ping)</p>
<p>14 shoots lock&nbsp; 3 (ping)</p>
</td>
</tr>
<tr>
<td width="160">
<p>33</p>
<p>1</p>
<p>12 11 10</p>
<p>10 20 30</p>
<p>100</p>
</td>
<td width="297">
<p>Bang!</p>
<p>Reloading!</p>
<p>Bang!</p>
<p>Reloading!</p>
<p>Bang!</p>
<p>0 bullets left. Earned $1</p>
</td>
<td width="224">
<p>10 shoots lock 10 (bang)</p>
<p>11 shoots lock 20 (bang)</p>
<p>12 shoots lock 30 (bang)</p>
<p>&nbsp;</p>
<p>Bullet cost: 3 * 33 = $99</p>
<p>Earned: 100 &ndash; 99 = $1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
