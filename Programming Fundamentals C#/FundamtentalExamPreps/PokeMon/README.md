<h1>Problem 1. Poke Mon</h1>
<p>A Poke Mon is a special type of pokemon which likes to Poke others. But at the end of the day, the Poke Mon wants to keeps statistics, about how many pokes it has managed to make.</p>
<p>The Poke Mon pokes his target, and then proceeds to poke another target. The <strong>distance</strong> between his <strong>targets</strong> <strong>reduces</strong> his <strong>poke power</strong>.</p>
<p>You will be <strong>given</strong> the <strong>poke power</strong> the Poke Mon has, <strong>N</strong> &ndash; an <strong>integer</strong>.</p>
<p>Then you will be <strong>given</strong> the <strong>distance</strong> between the <strong>poke targets</strong>, <strong>M</strong> &ndash; an <strong>integer</strong>.</p>
<p>Then you will be <strong>given</strong> the <strong>exhaustionFactor</strong> <strong>Y</strong> &ndash; an <strong>integer</strong>.</p>
<p>Your task is to start <strong>subtracting</strong> <strong>M</strong> from <strong>N</strong> until <strong>N</strong> becomes <strong>less than M</strong>, i.e. the Poke Mon does not have enough power to reach the next target. <br /> <strong>Every time</strong> you <strong>subtract M</strong> from <strong>N</strong> that means you&rsquo;ve reached a <strong>target</strong> and poked it successfully. <strong>COUNT</strong> how <strong>many targets</strong> you&rsquo;ve poked &ndash; <strong>you&rsquo;ll need</strong> that <strong>count</strong>.</p>
<p>The Poke Mon becomes gradually more exhausted. <strong>IF</strong> <strong>N</strong> <strong>becomes equal</strong> to <strong>EXACTLY 50 %</strong> of its <strong>original value</strong>, you must <strong>divide</strong> <strong>N</strong> by <strong>Y</strong>, if it is <strong>POSSIBLE</strong>. <strong>This</strong> <strong>DIVISION</strong> is between <strong>integers</strong>.</p>
<p>If a division is <strong>not possible</strong>, you should <strong>NOT</strong> do it. Instead, you should continue <strong>subtracting</strong>.</p>
<p><strong>After dividing</strong>, you should <strong>continue</strong> subtracting from <strong>N</strong>, until it becomes <strong>less</strong> than <strong>M</strong>.</p>
<p>When <strong>N</strong> becomes <strong>less</strong> than <strong>M</strong>, you must take <strong>what has remained </strong>of<strong> N</strong> and the <strong>count </strong>of <strong>targets</strong> you&rsquo;ve poked, and print them as output.</p>
<p>&nbsp;</p>
<p><strong>NOTE</strong>: When you are <strong>calculating percentages</strong>, you should be <strong>PRECISE </strong>at <strong>maximum</strong>.</p>
<p><strong>Example</strong>: 505 is <strong>NOT EXACTLY 50 %</strong> from 1000, its <strong>50.5 %</strong>.</p>
<h3>Input</h3>
<ul>
<li>The input consists of <strong>3 lines</strong>.</li>
<li>On the <strong>first line</strong> you will receive <strong>N</strong> &ndash; an <strong>integer</strong>.</li>
<li>On the <strong>second line</strong> you will receive <strong>M</strong> &ndash; an <strong>integer</strong>.</li>
<li>On the <strong>third line</strong> you will receive <strong>Y</strong> &ndash; an <strong>integer</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output consists of <strong>2 lines</strong>.</li>
<li>On the <strong>first line</strong> print <strong>what has remained</strong> of <strong>N</strong>, after <strong>subtracting</strong> from it.</li>
<li>On the <strong>second line</strong> print the <strong>count</strong> of <strong>targets</strong>, you&rsquo;ve managed to poke.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The integer <strong>N</strong> will be in the <strong>range</strong> <strong>[1, 2.000.000.000]</strong>.</li>
<li>The integer <strong>M</strong> will be in the <strong>range</strong> <strong>[1, 1.000.000]</strong>.</li>
<li>The integer <strong>Y</strong> will be in the <strong>range</strong> <strong>[0, 9]</strong>.</li>
<li>Allowed time / memory: <strong>16 MB / 100ms</strong>.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="106">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="466">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="106">
<p>5</p>
<p>2</p>
<p>3</p>
</td>
<td width="62">
<p>1</p>
<p>2</p>
<p>&nbsp;</p>
</td>
<td width="466">
<p>N = 5, M = 2, Y = 3.</p>
<p>We start <strong>subtracting</strong> <strong>M</strong> from <strong>N</strong>.</p>
<p><strong>N &ndash; M = 3</strong>. <strong>1</strong> target poked.</p>
<p><strong>N &ndash; M = 1</strong>. <strong>2</strong> targets poked.</p>
<p><strong>N &lt; M</strong>.<br /> We print <strong>what has remained</strong> of <strong>N</strong>, which is <strong>1</strong>.</p>
<p>We print the <strong>count of targets</strong>, which is 2.</p>
</td>
</tr>
<tr>
<td width="106">
<p>10</p>
<p>5</p>
<p>2</p>
</td>
<td width="62">
<p>2</p>
<p>1</p>
<p>&nbsp;</p>
</td>
<td width="466">
<p>N = 10, M = 5, Y = 2.</p>
<p>We start <strong>subtracting</strong> <strong>M</strong> from <strong>N</strong>.</p>
<p><strong>N</strong> <strong>&ndash;</strong> <strong>M</strong> = <strong>5</strong>. (N is still not less than M, they are equal).</p>
<p><strong>N</strong> became <strong>EXACTLY</strong> <strong>50 %</strong> of its <strong>original value</strong>.</p>
<p><strong>5</strong> is <strong>50 %</strong> from <strong>10</strong>. So we divide <strong>N</strong> by <strong>Y</strong>.</p>
<p><strong>N / Y</strong> = <strong>5 / 2</strong> = <strong>2</strong>. (<strong>INTEGER DIVISION</strong>).</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>