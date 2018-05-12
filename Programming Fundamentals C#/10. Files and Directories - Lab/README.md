<h1>Lab: Files, Directories and Exceptions</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<h1>&nbsp;&nbsp;&nbsp; I.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; File Operations</h1>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Odd Lines</h2>
<p>Write a program that reads a text file and writes it's every <strong>odd </strong>line in another file. Line numbers starts from 0.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="350">
<p><strong>Input.txt</strong></p>
</td>
<td width="359">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="350">
<p>Two households, both alike in dignity,<br /> In fair Verona, where we lay our scene,<br /> From ancient grudge break to new mutiny,<br /> Where civil blood makes civil hands unclean.<br /> From forth the fatal loins of these two foes<br /> A pair of star-cross'd lovers take their life;<br /> Whose misadventured piteous overthrows<br /> Do with their death bury their parents' strife.</p>
</td>
<td width="359">
<p>In fair Verona, where we lay our scene,</p>
<p>Where civil blood makes civil hands unclean.</p>
<p>A pair of star-cross&rsquo;d lovers take their life;</p>
<p>Do with their death bury their parents&rsquo; strife</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Line Numbers</h2>
<p>Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="350">
<p><strong>Input.txt</strong></p>
</td>
<td width="359">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="350">
<p>Two households, both alike in dignity,<br /> In fair Verona, where we lay our scene,<br /> From ancient grudge break to new mutiny,<br /> Where civil blood makes civil hands unclean.<br /> From forth the fatal loins of these two foes<br /> A pair of star-cross'd lovers take their life;<br /> Whose misadventured piteous overthrows<br /> Do with their death bury their parents' strife.</p>
</td>
<td width="359">
<p>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Two households, both alike in dignity,</p>
<p>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; In fair Verona, where we lay our scene,</p>
<p>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; From ancient grudge break to new mutiny,</p>
<p>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Where civil blood makes civil hands unclean.</p>
<p>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; From forth the fatal loins of these two foes</p>
<p>6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A pair of star-cross'd lovers take their life;</p>
<p>7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Whose misadventured piteous overthrows</p>
<p>8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Do with their death bury their parents' strife.</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Word Count</h2>
<p>Write a program that reads a list of words from the file <strong>words.txt</strong> and finds how many times each of the words is contained in another file <strong>text.txt</strong>. Matching should be <strong>case-insensitive</strong>.</p>
<p>The result should be written to another text file. Sort the words by frequency in descending order.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>words.txt</strong></p>
</td>
<td width="258">
<p><strong>Input.txt</strong></p>
</td>
<td width="96">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>quick is fault</p>
<p>&nbsp;</p>
</td>
<td width="258">
<p>-I was quick to judge him, but it wasn't his fault.</p>
<p>-Is this some kind of joke?! Is it?</p>
<p>-Quick, hide here&hellip;It is safer.</p>
</td>
<td width="96">
<p>is - 3</p>
<p>quick - 2</p>
<p>fault - 1</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp; Merge Files</h2>
<p>Write a program that reads the contents of two text files and merges them together into a third one.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>Input1.txt</strong></p>
</td>
<td width="258">
<p><strong>Input2.txt</strong></p>
</td>
<td width="96">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>1</p>
<p>3</p>
<p>5</p>
<p>&nbsp;</p>
</td>
<td width="258">
<p>2</p>
<p>4</p>
<p>6</p>
</td>
<td width="96">
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>5</p>
<p>6</p>
</td>
</tr>
</tbody>
</table>
<h1>&nbsp;II.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Directory Operations</h1>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp; Folder Size</h2>
<p>You are given a folder named &ldquo;TestFolder&rdquo;. Get the size of all files in the folder, which are <strong>NOT directories.</strong> The result should be written to another text file in <strong>Megabytes</strong>.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="130">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="130">
<p>5.16173839569092</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
