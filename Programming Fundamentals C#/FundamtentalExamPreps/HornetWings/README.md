<h1>Problem 1 &ndash; Hornet Wings</h1>
<p>The hornets are having a cardio contest. Your task is to calculate a contestant&rsquo;s distance travelled, based upon the wing flaps he made. However some hornet contestants are faster and less durable, while others are slower but have more endurance.</p>
<p>You will be given <strong>N</strong> &ndash; an <strong>integer</strong> indicating the <strong>wing flaps</strong>, a contestant has chosen to do.</p>
<p>After that, you will receive <strong>M</strong> &ndash; a <strong>floating-point number</strong> indicating the <strong>distance</strong>, in <strong>meters</strong>, the hornet travels for <strong>1000 wing flaps</strong>.</p>
<p>Then you will receive <strong>P</strong> &ndash; an <strong>integer</strong> indicating the <strong>endurance</strong> of the contestant, or <strong>how many wing flaps</strong> he can make, before <strong>he stops to take a break</strong> and rest. A hornet <strong>rests</strong> for <strong>5</strong> <strong>seconds</strong>.</p>
<p>You can assume that a hornet makes <strong>100 </strong>wing flaps <strong>per</strong> <strong>second</strong>.</p>
<p>Your task is to <strong>calculate</strong> how much <strong>distance</strong> will the hornet <strong>travel</strong>, after it <strong>flaps</strong> its <strong>wings</strong> <strong>N times</strong>, and how much <strong>time</strong> it <strong>took him</strong>, to travel it. The <strong>distance</strong> is measured in <strong>meters</strong> and the time &ndash; in <strong>seconds</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the first input line you will receive N &ndash; the wing flaps, the hornet has chosen to do.</li>
<li>On the second input line you will receive M &ndash; the distance the hornet travels for 1000 wing flaps.</li>
<li>On the third input line you will receive P &ndash; the endurance of the hornet.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print the total distance the hornet contestant has travelled, and the amount of time it took him.</li>
<li>The output must be in the format of two lines:</li>
<li>On the first output line you must print the distance: &ldquo;<strong>{</strong><strong>metersTraveled} m.</strong>&rdquo;</li>
<li>On the second output line you must print the time: &ldquo;<strong>{secondsPassed} s.</strong></li>
<li>The <strong>distance</strong> must be <strong>printed</strong> to the <strong>second digit</strong> after the <strong>decimal point</strong>.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The integer <strong>N</strong> &ndash; the wing flaps, will be in <strong>range [0</strong><strong>; 1,000,000,000]</strong>.</li>
<li>The floating-point number <strong>M</strong> &ndash; the distance for 1000 wing flaps, will be in <strong>range [0</strong><strong>; 1,000,000]</strong>.</li>
<li>The integer <strong>P</strong> &ndash; the endurance, will be in range <strong>[1</strong><strong>; N]</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="97">
<p><strong>Input</strong></p>
</td>
<td width="120">
<p><strong>Output</strong></p>
</td>
<td width="455">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="97">
<p>2000</p>
<p>5</p>
<p>200</p>
</td>
<td width="120">
<p>10.00 m.</p>
<p>70 s.</p>
</td>
<td width="455">
<p>The contestant has chosen to do <strong>2000 wing flaps</strong>. <br /> He moves <strong>5 meters</strong> per <strong>1000</strong> wing flaps.</p>
<p>He rests every <strong>200</strong> <strong>wing flaps</strong> for <strong>5</strong> <strong>seconds</strong>.</p>
<p>The distance is <strong>(2000 / 1000) * 5 = 2 * 5 = 10.00</strong> meters.</p>
<p>The hornet flaps <strong>100 times</strong> for a <strong>second</strong>, so <strong>2000 / 100 =</strong> <strong>20 </strong>seconds. <br /> But it also rests for <strong>5</strong> seconds every <strong>200</strong> flaps.</p>
<p><strong>(2000 / 200) * 5 = 10 * 5</strong> = <strong>50</strong>; <strong>20</strong> + <strong>50</strong> = <strong>70</strong> seconds.</p>
</td>
</tr>
<tr>
<td width="97">
<p>1000000</p>
<p>10</p>
<p>1500</p>
</td>
<td width="120">
<p>10000.00 m.</p>
<p>13330 s.</p>
</td>
<td width="455">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>