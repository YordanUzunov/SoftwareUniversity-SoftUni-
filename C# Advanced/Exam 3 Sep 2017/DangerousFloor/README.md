<h1>Problem 1 - Dangerous Floor</h1>
<p>You have just entered the door at the final address. In the end of the room there is a safe which holds the treasure you are searching for. The floor between you and the safe though is dangerous! If you do a wrong move it will collapse and you will never reach the treasure &hellip;or anything ...ever. Luckily you have gathered all the pieces of instructions left from this uncle of yours at each address you have visited before.</p>
<p>Imagine the floor in the form of a chess board. On different squares of this &ldquo;board&rdquo; are placed some chess pieces. If you follow all the instructions correctly (where possible) you will be able to pass safely on the other side.</p>
<p>The board is <strong>8</strong>x<strong>8 squares</strong>. There are <strong>6 kinds</strong> of <strong>pieces</strong>:</p>
<ul>
<li><strong>K</strong>ing - moves exactly one square horizontally, vertically, or diagonally.</li>
<li><strong>R</strong>ook- moves any number of vacant squares in a horizontal or vertical direction.</li>
<li><strong>B</strong>ishop - moves any number of vacant squares in any diagonal direction.</li>
<li><strong>Q</strong>ueen - moves any number of vacant squares in a horizontal, vertical, or diagonal direction.</li>
<li><strong>P</strong>awn &ndash; moves straight forward <strong>one square to the top.</strong></li>
</ul>
<p>Yeah, we know, that there are some more moves and <strong>figures</strong>, but for now these are enough. You can check the visual representation of the moves <a href="https://en.wikipedia.org/wiki/Rules_of_chess#Basic_moves">here.</a></p>
<h3>Input</h3>
<p>On the <strong>first 8 rows</strong>, you will receive а board with <strong>some pieces</strong> placed on it. <strong>Empty cells</strong> will be marked with "<strong>x</strong>" and all squares will be separated by comma.</p>
<p><strong>{x,x,Q,x,R,x,x,P}</strong></p>
<p><strong>{x,B,x,x,x,K,x,P}</strong></p>
<p>There are 7 symbols all in all:</p>
<ul>
<li><strong>K</strong> &ndash; King</li>
<li><strong>R</strong> &ndash; Rook</li>
<li><strong>B</strong> &ndash; Bishop</li>
<li><strong>Q &ndash; </strong>Queen</li>
<li><strong>P &ndash; </strong>Pawn</li>
<li><strong>x &ndash; </strong>Empty cell</li>
</ul>
<p>On the <strong>next lines</strong>, you will receive <strong>moves</strong> that <strong>need to be checked </strong>and <strong>if</strong> they are <strong>valid</strong> you should <strong>move</strong> the <strong>piece</strong> to its <strong>new position</strong>. There are <strong>3</strong> kinds of <strong>problems</strong> that may occur and you need to be looking for. The <strong>check</strong> <strong>must</strong> <strong>happen</strong> in the <strong>very same order</strong> as shown <strong>below</strong>:</p>
<ol>
<li>There is no such a piece on starting square.</li>
<li>Piece makes invalid move (look above).</li>
<li>Piece gets out of board.</li>
</ol>
<p>So, if you find that there is no such a piece, you don't need to check for the other problems. <strong>If</strong> you <strong>find any</strong> <strong>problem</strong> then you must <strong>cancel</strong> the <strong>move</strong> and the<strong> board stays the same</strong> for the next move.</p>
<p><strong>{Q01-12}</strong></p>
<p>The <strong>first symbol</strong> is the <strong>type</strong> <strong>of</strong> <strong>piece</strong> you need to move. Then you will read <strong>two digits</strong> which sate the <strong>position</strong> on which the <strong>piece</strong> <strong>should be</strong> currently (row, col). The <strong>next two digits </strong>are the <strong>final position</strong> (row, col) where you should <strong>try to move</strong> the <strong>piece</strong> to.</p>
<p>Read moves till you find the keyword "<strong>END</strong>".</p>
<h3>Output</h3>
<p>You should <strong>print</strong> lines on the console <strong>only when</strong> the <strong>move</strong> is <strong>not possible</strong>. You can have three different types of output, depending on what kind of problem you hit.</p>
<ol>
<li><strong>There is no such a piece!</strong></li>
<li><strong>Invalid move!</strong></li>
<li><strong>Move go out of board!</strong></li>
</ol>
<p>You can print only <strong>one</strong> <strong>message</strong> <strong>per</strong> invalid <strong>input</strong> <strong>move</strong>, so <strong>check</strong> for the problems <strong>in the order</strong> shown <strong>above</strong>. The <strong>check</strong> <strong>must</strong> <strong>happen</strong> in the <strong>very same order.</strong></p>
<h3>Constraints</h3>
<ul>
<li>Pieces will never go to a cell with another piece</li>
<li><strong>Moves count</strong> will be <strong>in</strong> the <strong>range</strong> [0&hellip;1000]</li>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="148">
<p><strong>Input</strong></p>
</td>
<td width="221">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="148">
<p>x,x,x,x,x,x,x,x</p>
<p>x,K,x,x,x,x,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>x,x,x,x,x,P,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>K33-44</p>
<p>K11-02</p>
<p>P44-34</p>
<p>P65-55</p>
<p>P55-65</p>
<p>END</p>
</td>
<td width="221">
<p>There is no such a piece!</p>
<p>There is no such a piece!</p>
<p>Invalid move!</p>
</td>
</tr>
<tr>
<td width="148">
<p>x,x,x,x,x,x,x,x</p>
<p>x,Q,x,x,x,x,x,x</p>
<p>x,x,x,x,x,x,x,R</p>
<p>x,x,x,x,x,x,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>x,x,x,B,x,x,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>x,x,x,x,x,x,x,x</p>
<p>Q11-15</p>
<p>Q15-24</p>
<p>R27-36</p>
<p>R27-28</p>
<p>B53-55</p>
<p>Q24-26</p>
<p>R27-07</p>
<p>R27-07</p>
<p>END</p>
</td>
<td width="221">
<p>Invalid move!</p>
<p>Move go out of board!</p>
<p>Invalid move!</p>
<p>There is no such a piece!</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>