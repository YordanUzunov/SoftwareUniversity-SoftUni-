<h1>Problem 2 &ndash; Sneaking</h1>
<p>After our hero Sam got the recipe from the first problem, there is another thing he needs to check off from his to-do list. In order to make the recipe even more valuable, he needs to &ldquo;eliminate&rdquo; anyone who possesses the knowledge of it. That person is Sam&rsquo;s sworn enemy - <strong>Nikoladze</strong>. Sam needs to get through a rectangular room of <strong>patrolling</strong> <strong>enemies</strong> until he finally <strong>reaches Nikoladze</strong>.</p>
<p>A standard room looks like this:</p>
<table width="0">
<tbody>
<tr>
<td width="160">
<p><strong>Room</strong></p>
</td>
<td width="297">
<p><strong>Legend</strong></p>
</td>
</tr>
<tr>
<td width="160">
<p>......N...<br /> b.........<br /> ..d.......<br /> ......d...<br /> .....S....</p>
</td>
<td width="297">
<p>S &egrave; <strong>Sam</strong>, the player character</p>
<p>b/d &egrave; <strong>left/right-facing</strong> <strong>patrolling enemy</strong></p>
<p>N &egrave; <strong>Nikoladze</strong></p>
<p>. &egrave; <strong>Empty space</strong></p>
</td>
</tr>
</tbody>
</table>
<p>Each turn proceeds as follows:</p>
<ul>
<li><strong>First, Enemies</strong> move either <strong>left</strong> or <strong>right</strong>, depending on which <strong>direction</strong> they are <strong>facing</strong> (b goes <strong>right</strong>, d goes <strong>left</strong>)
<ul>
<li>If an enemy is standing on the <strong>edge</strong> of the room, he flips his <strong>direction</strong> (from d to b or from b to d) and <strong>doesn&rsquo;t move</strong> for the rest of the turn.</li>
</ul>
</li>
<li>If an enemy is on the <strong>same row</strong> as Sam, and also <strong>facing</strong> <strong>Sam</strong> (eg. .b.S.), the <strong>enemy</strong> <strong>kills Sam</strong>.</li>
<li>After that, Sam moves in the <strong>direction</strong> he is instructed to (either U/D/L/R or W).
<ul>
<li><strong>U</strong> -&gt; <strong>Up</strong>, <strong>D</strong> -&gt; <strong>Down</strong>, <strong>L</strong> -&gt; <strong>Left</strong>, <strong>R</strong> -&gt; <strong>Right</strong>, <strong>W</strong> -&gt; <strong>Wait (Sam doesn&rsquo;t move)</strong></li>
</ul>
</li>
<li>If <strong>Sam</strong> moves <strong>onto an enemy </strong>(<strong>same row</strong> and <strong>column</strong>), Sam <strong>kills</strong> the enemy and <strong>leaves no trace of him</strong>.</li>
<li>If Sam is reaches the <strong>same row</strong> as <strong>Nikoladze</strong>, <strong>Sam</strong> kills <strong>Nikoladze </strong>(replacing him with an <strong>X</strong>)</li>
</ul>
<h2>Input</h2>
<ul>
<li>On the <strong>first line</strong> of input, you will receive n &ndash; the <strong>number of rows </strong>the <strong>room</strong> will consist of. Range: <strong>[2-20]</strong></li>
<li>On the next <strong>n lines</strong>, you will receive the <strong>room</strong>, which Sam will have to navigate.</li>
<li>On the <strong>final line </strong>of input, you will receive a sequence of <strong>directions</strong> &ndash; one of (<strong>U</strong>, <strong>D</strong>, <strong>L</strong>, <strong>R</strong>, <strong>W</strong>)</li>
</ul>
<h2>Output</h2>
<ul>
<li>If Sam is <strong>killed</strong>, print &ldquo;Sam died at {row}, {col}&rdquo;</li>
<li>If Nikoladze is <strong>killed</strong>, print &ldquo;Nikoladze killed!&rdquo;</li>
<li>Then, in both cases, <strong>print</strong> the <strong>final state of the room</strong> on the <strong>console</strong>, with either <strong>Sam</strong> or <strong>Nikoladze&rsquo;s</strong> <strong>symbols</strong> replaced by an X.</li>
</ul>
<h2>Constraints</h2>
<ul>
<li>The room will always be <strong>rectangular</strong>.</li>
<li>There will <strong>always</strong> be enough moves for <strong>Sam</strong> to reach <strong>Nikoladze</strong></li>
<li>There will be <strong>no case </strong>where <strong>Sam</strong> is instructed to move <strong>out of the bounds of the room</strong>.</li>
<li>There will be <strong>no case </strong>with <strong>two enemies on the same row</strong>.</li>
<li>There will be <strong>no case </strong>with an <strong>enemy and Nikoladze</strong> standing on the <strong>same row</strong>.</li>
<li>There will be <strong>no case </strong>where Sam reaches the <strong>same</strong> <strong>row and column </strong>as <strong>Nikoladze</strong>.</li>
</ul>
<h2>Examples</h2>
<table width="0">
<tbody>
<tr>
<td width="120">
<p><strong>Input</strong></p>
</td>
<td width="160">
<p><strong>Output</strong></p>
</td>
<td width="426">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="120">
<p>5</p>
<p>......N...</p>
<p>b.........</p>
<p>..d.......</p>
<p>......d...</p>
<p>.....S....</p>
<p>UUUUR</p>
</td>
<td width="160">
<p>Sam died at 2, 5</p>
<p>......N...</p>
<p>...b......</p>
<p>b....X....</p>
<p>..........</p>
<p>..........</p>
</td>
<td width="426">
<p>Turn 1: Enemies move, then Sam steps on the enemy on the 4<sup>th</sup> row.</p>
<p>Turn 2: Enemies move, then Sam moves.</p>
<p>Turn 3: Enemy 2 turns around, Sam goes on the same row as him.</p>
<p>Turn 4: Enemy sees Sam and kills him.</p>
</td>
</tr>
<tr>
<td width="120">
<p>3</p>
<p>N......</p>
<p>.b.....</p>
<p>..dS...</p>
<p>WUUU</p>
</td>
<td width="160">
<p>Nikoladze killed!</p>
<p>X..S...</p>
<p>.......</p>
<p>b......</p>
</td>
<td width="426">
<p>Turn 1: Enemies move, Sam waits.</p>
<p>Turn 2: Enemies move, Sam goes up, steps on an enemy.</p>
<p>Turn 3: Enemies move, Sam goes up, kills Nikoladze.</p>
</td>
</tr>
<tr>
<td width="120">
<p>6</p>
<p>.............</p>
<p>....S........</p>
<p>.b...........</p>
<p>...........d.</p>
<p>.............</p>
<p>....N........</p>
<p>WWWDWWWDDRD</p>
</td>
<td width="160">
<p>Nikoladze killed!</p>
<p>.............</p>
<p>.............</p>
<p>............b</p>
<p>d............</p>
<p>.............</p>
<p>....XS.......</p>
</td>
<td width="426">
<p>Turn 1/2/3: Enemies move, Sam waits.</p>
<p>Turn 4: Enemies move, Sam goes down.</p>
<p>Turn 5/6/7: Enemies move, Sam waits.</p>
<p>Turn 8/9: Enemies move, Sam goes down.</p>
<p>Turn 10: Enemies move, Sam goes right.</p>
<p>Turn 11: Enemies move, Sam goes down and kills Nikoladze.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>