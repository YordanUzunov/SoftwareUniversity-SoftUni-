<h2>Problem 3 &ndash; Number Wars</h2>
<p>There is one very popular card game for little children - "Voina". Most of us played this game before and it is well known for being pretty easy. So, in this task you will implement a slightly different version of the game.&nbsp;</p>
<p>There are two players. Each of them have cards in their hands. Cards consist of a number and an English letter - something like <strong>"11f", "53g", "55g", "3k", "66666p"</strong>.</p>
<p>Every turn of the game, each of the players puts his top (longest been in deck) card on the field. The player with the bigger card (<strong>higher number</strong>) gets both cards and puts them in the bottom of his deck.</p>
<p>It is easy when there is a clear winner, but what happens when the cards&rsquo; numbers are equal. Then every player has to <strong>put 3 more cards</strong> on the field. Again check for winner, but this time you need to check for the <strong>bigger sum of letters</strong> at the end of the cards. Each letter represents their position in the English alphabet <strong>a -&gt; 1, b -&gt; 2, c -&gt; 3</strong> etc. The player with the <strong>biggest sum of these 3 cards collects all cards</strong> from the field and put them in his deck. If there is a draw, the players put <strong>3 new cards</strong> from their decks.</p>
<p>When you find the result, <strong>end the turn and all cards from the field go to the winner hand</strong>. Cards are added in <strong>descending order</strong>:</p>
<p>Hand &lt;- <strong>"111f", "111a", "99p", "77a", "55a", "8p"</strong></p>
<p>The <strong>game ends</strong> under two conditions - if any of the <strong>players loses all his cards</strong>, he loses the game. After <strong>1000000 turns</strong>, if both players still have cards, the <strong>player with more cards wins the game</strong>.</p>
<h3>Input</h3>
<p>On the first line you will receive the first players&rsquo; cards separated with a space.</p>
<p>On the second line you will receive the second players&rsquo; cards separated with a space.</p>
<h3>Output</h3>
<p>You need to print a single line with the winner or draw: "<strong>{Result} after {turns} turns"</strong></p>
<h3>Constraints</h3>
<ul>
<li>Each player will have N cards, where 1 &lt; N &lt; 1000</li>
<li>Each number will contain an integer with a single letter at the end</li>
<li>Time limit: 0.3 sec. Memory limit: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="188">
<p><strong>Input</strong></p>
</td>
<td width="253">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="188">
<p>20y 28j 45s 21i 81i</p>
<p>26z 9f 80a 68g 67z</p>
</td>
<td width="253">
<p>First player wins after 25 turns</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="610">
<p><strong>Input</strong></p>
</td>
<td width="101">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="610">
<p>111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 6p</p>
<p>111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 6p</p>
</td>
<td width="101">
<p>Draw after 1 turns</p>
</td>
</tr>
<tr>
<td width="610">
<p><strong>Input</strong></p>
</td>
<td width="101">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="610">
<p>111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 6p</p>
<p>111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 111j 33k 88k 99p 77k 5p 6a</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="101">
<p>First player wins after 1 turns</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>