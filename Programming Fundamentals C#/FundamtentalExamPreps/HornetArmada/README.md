<h1>Problem 4 &ndash; Hornet Armada</h1>
<p>The Hornet Overlord Nostalgia, who is famed for his absolute discipline and strict orders, owns the most sorted army in the Hornet history. Help Nostalgia &ldquo;computerize&rdquo; the process of sorting out his army.</p>
<p>You will be given <strong>N</strong> &ndash; an integer.<br /> On the next <strong>N</strong> lines you will be given input containing information about soldiers in the following format:</p>
<p><strong>{lastActivity} = {legionName} -&gt; {soldierType}:{soldierCount}</strong></p>
<p>The <strong>last activity</strong> is an <strong>integer</strong>. The <strong>legion name</strong> and <strong>soldier type</strong>, will both be <strong>strings</strong>. The <strong>soldier count</strong> will be an <strong>integer</strong>. You must <strong>store</strong> <strong>every</strong> <strong>legion</strong> with its <strong>activity</strong>, and <strong>every</strong> <strong>soldier type</strong> with its <strong>count</strong>, in its <strong>legion</strong>.</p>
<p>If a <strong>given legion already exists</strong>, you must <strong>add</strong> the new <strong>soldier type</strong>, with its count. If the soldier type exists <strong>ALSO</strong>, you should just <strong>add</strong> the <strong>soldier count</strong>.</p>
<p><strong>IN</strong> <strong>BOTH</strong> cases, stated above, you should <strong>update</strong> the <strong>last</strong> <strong>activity</strong>, with the newly entered one, <strong>ONLY</strong> if the <strong>entered</strong> <strong>one </strong>is <strong>GREATER</strong> than the <strong>previous one</strong>.</p>
<p>After you&rsquo;ve read <strong>all N</strong> input lines, you will receive a line in one of the following formats:</p>
<ul>
<li>{activity}\{soldierType}</li>
<li>{soldierType}</li>
</ul>
<p>In the <strong>first case,</strong> you must print all <strong>legions</strong>, and the <strong>count of soldiers</strong> they have from the <strong>given</strong> <strong>soldier</strong> <strong>type</strong>, who&rsquo;s <strong>last activity</strong> is <strong>LOWER </strong>than the <strong>given activity</strong>. The legions must be printed in <strong>descending order</strong> by <strong>soldier count</strong>.</p>
<p>In the <strong>second case</strong>, you must print all legions which <strong>have</strong> the <strong>given soldier type</strong>, with <strong>last activity</strong>, and <strong>legion name</strong>. The legions must be printed in <strong>descending</strong> <strong>order </strong>of their<strong> activity</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the first line you will receive <strong>N </strong>&ndash; the<strong> integer</strong>.</li>
<li>On the next <strong>N</strong> lines you will receive data about <strong>soldiers</strong> and <strong>legions</strong>.</li>
<li>On the last line you will receive <strong>one</strong> of the <strong>two commands</strong>, which will <strong>determine</strong> the <strong>output</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>If you are given the <strong>last activity</strong> and <strong>soldier type</strong> on the last command, you must print the legions in this format:</li>
<li>{legionName} -&gt; {soldierCount}</li>
<li>If you are given <strong>only</strong> the <strong>soldier type</strong> on the last command, you must print the legions in this format:</li>
<li>{lastActivity} : {legionName}</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The first integer &ndash; <strong>N</strong>, will be in <strong>range [0</strong><strong>; 10</strong><strong>,000]</strong>.</li>
<li>The <strong>legion names</strong> and <strong>soldier types</strong> may consist of <strong>any ASCII </strong>character, except &ldquo;<strong>=</strong>&rdquo;, &ldquo;<strong>-</strong>&rdquo;, &ldquo;<strong>&gt;</strong>&rdquo;, &ldquo;<strong>:</strong>&rdquo;, &ldquo; &rdquo;(<strong>space</strong>).</li>
<li>The <strong>soldier count</strong> and <strong>last activity</strong> will be integers in <strong>range [0</strong><strong>; 1,000,000,000]</strong>.</li>
<li>All input data will be exactly as stated above. There will be <strong>NO invalid</strong> input lines.</li>
<li>Data which has <strong>NO specified order</strong> must be sorted in <strong>order of</strong> <strong>input</strong>.</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="318">
<p><strong>Input</strong></p>
</td>
<td width="181">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="318">
<p>6</p>
<p>1 = BlackBeatles -&gt; Soldier:2000</p>
<p>2 = BlackBeatles -&gt; Worker:1000</p>
<p>1 = Red_Ones -&gt; Soldier:10000</p>
<p>5 = Rm -&gt; Soldier:30000</p>
<p>2 = Red_Ones -&gt; Soldier:20000</p>
<p>10 = RND -&gt; Soldier:100000</p>
<p>10\Soldier</p>
</td>
<td width="181">
<p>Red_Ones -&gt; 30000</p>
<p>Rm -&gt; 30000</p>
<p>BlackBeatles -&gt; 2000</p>
</td>
</tr>
<tr>
<td width="318">
<p>7</p>
<p>1000 = F1rstL3gion -&gt; Aisers:15000</p>
<p>500 = F1rstL3gion -&gt; Aisers:1000</p>
<p>200 = F1rstL3gion -&gt; Guards:2000</p>
<p>2000 = Second!egion -&gt; Guards:2000</p>
<p>1500 = Second!egion -&gt; Aisers:15000</p>
<p>2500 = Second!egion -&gt; Spies:2000</p>
<p>1000 = Forked_Ones -&gt; Guards:10000000</p>
<p>Guards</p>
</td>
<td width="181">
<p>2500 : Second!egion</p>
<p>1000 : F1rstL3gion</p>
<p>1000 : Forked_Ones</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>