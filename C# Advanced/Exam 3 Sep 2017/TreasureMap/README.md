<h1>Problem 4 &ndash; Treasure Map</h1>
<p>Believe it or not you are just about to receive a letter from a ridiculously rich uncle of yours who happened to have lived in the very same city as you. The special thing about that letter is that it is actually a map which leads you to a secret treasure you have inherited. The map consists of list of addresses you must visit in order to get to the treasure&hellip; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Though the &ldquo;old fox&rdquo; is not stupid so he has also written a password next to each address which you must tell when you reach there. Easy-peasy &hellip; yeah, sure! The only problem is that your uncle&rsquo;s little daughter has found the letter by accident and drew some extra symbols on it before it was sent to you. Fortunately, we have some hints for you on how to read the letter.</p>
<h3>Instructions</h3>
<p>Your uncle has written everything in the middle of the paper so you need to <strong>search</strong> for the <strong>most inner valid</strong> <strong>instruction</strong>. If the matches are even number <strong>take the second </strong>one from the <strong>central pair</strong> (the one on the right).</p>
<ul>
<li>All valid instructions are <strong>locked between</strong> the symbols <strong>&ldquo;#&rdquo;</strong> and <strong>&ldquo;!&rdquo;</strong>. <strong>Each</strong> of them <strong>can stay before</strong> <u>or</u> <strong>ahead</strong> of the instruction block but they <strong>should not be repeating</strong>! g.:</li>
</ul>
<p>&nbsp;</p>
<p><strong>&ldquo;</strong><strong>#</strong><strong>{instruction pattern}</strong><strong>!</strong><strong>&rdquo; </strong><strong>or &ldquo;</strong><strong>!</strong><strong>{instruction pattern}</strong><strong>#</strong><strong>&rdquo;</strong></p>
<p>Inside the locking symbols you should find:</p>
<ul>
<li>The <strong>first</strong> <strong>four</strong> <strong>letter</strong> <strong>word</strong> - the name of the street (only letters, should not be preceded or followed by a digit or a letter)</li>
<li>The <strong>last</strong> street number - password <strong>pair</strong> in the format:</li>
</ul>
<p><strong>&ldquo;{street number}-{password}&rdquo; </strong>where the <strong>street number</strong> consists of <strong>3 digits</strong> and the <strong>password</strong> consists of <strong>4 <u>OR</u> 6 digits</strong></p>
<h3>Input</h3>
<ul>
<li>On the first line, you will receive an <strong>integer</strong> <strong>N</strong></li>
<li>On the next <strong>N</strong> lines, you will receive <strong>strings</strong> that may contain <strong>any</strong> ASCII <strong>symbol</strong></li>
</ul>
<h3>Output</h3>
<ul>
<li>You must <strong>print</strong> on the console <strong>all read </strong>instructions, <strong>each on new lin</strong>e in the format:</li>
</ul>
<p><strong>&ldquo;Go to str. {address name} {street number}. Secret pass: {password}.&rdquo;</strong></p>
<h3>Constraints</h3>
<ul>
<li>The first line containing digits <strong>won&rsquo;t be longer</strong> than <strong>60</strong> symbols</li>
<li>Each address name - street number <strong>pair</strong> will be <strong>unique</strong></li>
<li>There will not be any <strong>nested valid</strong> instructions</li>
<li>Time limit: 0.3 sec. Memory limit: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="490">
<p><strong>Input</strong></p>
</td>
<td width="199">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="490">
<p>2</p>
<p><u>#a asda 90a 164-1854ipo!</u>21#w!i1p<u>#Chen 800-1989!</u>912!90!d09#</p>
<p><u>#Sivu 111-198990ads387-0990!</u></p>
</td>
<td width="199">
<p>Go to str. Chen 800. Secret pass: 1989.</p>
<p>Go to str. Sivu 387. Secret pass: 0990.</p>
</td>
</tr>
<tr>
<td width="490">
<p>2</p>
<p>.`#2#asio800-1989!9<u>#ioio 123-3211!!</u> <u>a aJax asd asdf asio 007-1914#</u>+#sh shi shak 89 12 sa 980.6573! <u>!jdmu 890-890899#</u></p>
<p>?phpjfa9f0a09<u>!kop.uoi-haya &lt;&gt;918-3123+#</u>\x\k;</p>
</td>
<td width="199">
<p>Go to str. aJax 007. Secret pass: 1914.</p>
<p>Go to str. haya 918. Secret pass: 3123.</p>
</td>
</tr>
<tr>
<td width="490">
<p>3</p>
<p>#189-3123ahij!ds.,/21a<u>!vnkaa pehA ;lf984-123129 ao 276-0001#</u>shjlk!da901-13!2#!asdf</p>
<p>i #sd.<u>#swe.,jkas-112-0131!# oio Perl.123-1234!!jj ko staa mo staa 777-7171adfsa#</u>io</p>
<p>.,`213.31245.0-9gFk!!!!!1-1####flks0--+\&lt;<u>!@AsfA kit </u><u>444-444111</u><u>#</u>1&gt;&gt;#oppo154-2017ak!jik tak</p>
</td>
<td width="199">
<p>Go to str. pehA 276. Secret pass: 0001.</p>
<p>Go to str. Perl 123. Secret pass: 1234.</p>
<p>Go to str. AsfA 444. Secret pass: 444111.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>