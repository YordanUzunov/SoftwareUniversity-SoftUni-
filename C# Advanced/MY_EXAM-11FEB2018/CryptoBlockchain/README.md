<h1>Problem 3 &ndash; Crypto Blockchain</h1>
<p>The next task for our hero Sam is to <strong>hack the main top-secret facility server</strong>, used to manage all of Nikoladze&rsquo;s social media. He&rsquo;s already reached the server, and now it&rsquo;s time to decrypt the information on it to see if it&rsquo;s valuable or not. Luckily, you&rsquo;re Sam&rsquo;s top unpaid intern, and he has tasked you with figuring out the algorithm to decrypting the data. So, plug in some headphones and put on some hacker music. It&rsquo;s time to <strong>decrypt the</strong> <strong>Crypto Blockchain</strong>.</p>
<p>The <strong>Crypto Blockchain</strong> is a special <strong>sequence of characters</strong>, which is comprised of <strong>several lines</strong>. Each line is <strong>always 16 characters long</strong>. Inside these lines, there are several <strong>Crypto Blocks</strong> and some garbage data around them. Here&rsquo;s what a sample <strong>Crypto Blockchain</strong> looks like:</p>
<table>
<tbody>
<tr>
<td width="152">
<p>OktJULP\{FT*n*uk</p>
<p>_123120137130v}M</p>
<p>OoHw_[1291201341</p>
<p>34r`wkR]00000000</p>
</td>
</tr>
</tbody>
</table>
<p>The first step is to <strong>condense</strong> the <strong>Crypto Blockchain</strong> into <strong>one line</strong>.</p>
<p>The next step is to search for <strong>special substrings</strong> inside it, called <strong>Crypto Blocks</strong>. Each valid <strong>Crypto Block</strong> has the following characteristics:</p>
<ul>
<li>It&rsquo;s <strong>enclosed</strong> in either <strong>brackets</strong> {} or <strong>square brackets </strong>[].
<ul>
<li>If it contains <strong>mixed opening/closing brackets</strong> (such as {] or [}, <strong>ignore that Crypto Block entirely</strong>)</li>
</ul>
</li>
<li>It contains <strong>any printable ASCII character</strong> inside it</li>
<li>It contains <strong>at least three</strong> <strong>digits</strong> <strong>in a row</strong>.
<ul>
<li>If the number of digits it contains <strong>cannot be split into threes</strong> (e.g. 8 digits), <strong>ignore the Crypto Block</strong>.</li>
</ul>
</li>
</ul>
<p>We&rsquo;re looking for the <strong>digits</strong> inside each <strong>Crypto Block</strong>, which are actually <strong>encoded</strong> <strong>ASCII characters</strong>. Each character is represented by <strong>3 digits</strong> (<strong>converted to a number</strong>), and the <strong>sequence of digits</strong> can be split into threes to figure out the sequence of characters present in that crypto block.</p>
<p>Looking at these characteristics, we can look at the above expanded Crypto Blockchain and <strong>find all the Crypto Blocks </strong>(<strong>green </strong>represents the <strong>entire block</strong>, <strong>yellow</strong> represents the <strong>digits</strong> we&rsquo;re looking for):</p>
<table width="0">
<tbody>
<tr>
<td width="539">
<p>OktJULP\{FT*n*uk_123120137130v}MOoHw_[129120134134r`wkR]00000000</p>
</td>
</tr>
</tbody>
</table>
<p>Once we <strong>find</strong> the <strong>digits</strong> in one crypto block, we split them into <strong>threes</strong> and <strong>convert them</strong> to a <strong>string of characters</strong> by <strong>subtracting the length </strong>of the<strong> entire crypto block </strong>from <strong>each number individually</strong>.</p>
<p>The final step is performing this algorithm over <strong>all the crypto blocks individually</strong> and <strong>concatenating</strong> the result.</p>
<h2>Input</h2>
<ul>
<li>On the <strong>first line</strong> of input, you will receive <strong>n</strong> &ndash; the <strong>number of rows </strong>the <strong>room</strong> will consist of</li>
<li>On the next <strong>n lines</strong>, you will receive the <strong>Crypto Blockchain</strong>, a sequence of <strong>16 </strong></li>
</ul>
<h2>Output</h2>
<ul>
<li>Print the <strong>decrypted </strong>and <strong>concatenated </strong></li>
</ul>
<h2>Constraints</h2>
<ul>
<li>Crypto blocks will always contain <strong>zero or one sequence of numbers</strong>.</li>
<li>There will <strong>always</strong> be a <strong>valid</strong> <strong>crypto block</strong> in each crypto blockchain.</li>
</ul>
<h2>Examples</h2>
<table width="0">
<tbody>
<tr>
<td width="155">
<p><strong>Input</strong></p>
</td>
<td width="190">
<p><strong>Output</strong></p>
</td>
<td width="368">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>4</p>
<p>OktJULP\{FT*n*uk</p>
<p>_123120137130v}M</p>
<p>OoHw_[1291201341</p>
<p>34r`wkR]00000000</p>
</td>
<td width="190">
<p>darkness</p>
</td>
<td width="368">
<p>Block 1: {FT*n*uk_123120137130v}</p>
<p>Numbers: 123, 120, 137, 130. Crypto Block Length: 23</p>
<p>Subtracted ASCII codes: 100, 97, 114, 107 &egrave; dark</p>
<p>Block 2: [129120134134r`wkR]</p>
<p>Numbers: 129, 120, 134, 134. Crypto Block Length: 19</p>
<p>Subtracted ASCII codes: 110, 101, 115, 115 &egrave; ness</p>
</td>
</tr>
<tr>
<td width="155">
<p>7</p>
<p>[&gt;K.l ~T11715215</p>
<p>2153081069148155</p>
<p>138z]#YQej@&lt;+;|[</p>
<p>1370551271241371</p>
<p>24056]aG\'#|J q{</p>
<p>L|y!111632]!u&lt;@:</p>
<p>&lt;-&amp;D000000000000</p>
</td>
<td width="190">
<p>Psst, over here!</p>
</td>
<td width="368">
<p>Block 1: [&gt;K.l ~T117152152153081069148155138z]</p>
<p>Numbers: 117, 152, 152, 153, &hellip; Crypto Block Length: 37</p>
<p>Subtracted ASCII codes: 80, 115, 115, 116, &hellip; &egrave; Psst, ove</p>
<p>Block 2: [137055127124137124056]</p>
<p>Numbers: 137, 55, 127, 124, &hellip; Crypto Block Length: 23</p>
<p>Subtracted ASCII codes: 114, 32, 104, 101, &hellip; &egrave; r here!</p>
<p>Block 3: {L|y!111632]</p>
<p>Brackets are different &egrave; ignore</p>
</td>
</tr>
<tr>
<td width="155">
<p>4</p>
<p>[099134134130055</p>
<p>142127]{12614506</p>
<p>1091102089061131</p>
<p>140}[128121111]0</p>
</td>
<td width="190">
<p>Look what &gt;I&lt; found</p>
</td>
<td width="368">
<p>Block 1: [099134134130055142127]</p>
<p>Numbers: 99, 134, 134, 130, &hellip; Crypto Block Length: 23</p>
<p>Subtracted ASCII codes: 76, 111, 111, 107, &hellip; &egrave; Look wh</p>
<p>Block 2: {126145061091102089061131140}</p>
<p>Numbers: 126, 145, 61, 91, &hellip; Crypto Block Length: 29</p>
<p>Subtracted ASCII codes: 97, 116, 32, 62, &hellip; &egrave; at &gt;I&lt; fo</p>
<p>Block 3: [128121111]</p>
<p>Numbers: 128, 121, 111. Crypto Block Length: 11</p>
<p>Subtracted ASCII codes: 117, 110, 100, &hellip; &egrave; und</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>