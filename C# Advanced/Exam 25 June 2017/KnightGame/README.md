<p>Problem 2 &ndash; Knight Game</p>
<p>Chess is the oldest game, but it is still popular these days. For this task we will use only one chess piece &ndash; the <strong>Knight</strong>.</p>
<p>The knight&nbsp;moves to the <strong>nearest square but not on the same&nbsp;</strong><a href="https://en.wikipedia.org/wiki/Glossary_of_chess#rank">row</a><strong>,</strong><strong>&nbsp;</strong><a href="https://en.wikipedia.org/wiki/Glossary_of_chess#file">column</a><strong>, or</strong><strong>&nbsp;</strong><a href="https://en.wikipedia.org/wiki/Glossary_of_chess#diagonal">diagonal</a>. (This can be thought of as moving two squares horizontally, then one square vertically, or moving one square horizontally then two squares vertically&mdash; i.e. in an <strong>"L" pattern</strong>.)&nbsp;</p>
<p>The knight game is played on a board with dimensions <strong>N x N</strong> and a lot of chess knights <strong>0 &lt;= K &lt;= N<sup>2</sup></strong>.</p>
<p>You will receive a board with <strong>K</strong> for knights and '<strong>0' </strong>for empty cells. Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight.</p>
<h3>Input</h3>
<p>On the first line, you will receive the <strong>N </strong>size of the board</p>
<p>On the next <strong>N </strong>lines you will receive strings with <strong>Ks</strong> and <strong>0s</strong>.</p>
<h3>Output</h3>
<p>Print a single integer with the minimum amount of knights that needs to be removed</p>
<h3>Constraints</h3>
<ul>
<li>Size of the board will be 0 &lt; N &lt; 30</li>
<li>Time limit: 0.3 sec. Memory limit: 16 MB.</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="84">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>5</p>
<p>0K0K0</p>
<p>K000K</p>
<p>00K00</p>
<p>K000K</p>
<p>0K0K0</p>
</td>
<td width="62">
<p>1</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="84">
<p>2</p>
<p>KK</p>
<p>KK</p>
</td>
<td width="62">
<p>0</p>
</td>
</tr>
<tr>
<td width="84">
<p>8</p>
<p>0K0KKK00</p>
<p>0K00KKKK</p>
<p>00K0000K</p>
<p>KKKKKK0K</p>
<p>K0K0000K</p>
<p>KK00000K</p>
<p>00K0K000</p>
<p>000K00KK</p>
</td>
<td width="62">
<p>12</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>