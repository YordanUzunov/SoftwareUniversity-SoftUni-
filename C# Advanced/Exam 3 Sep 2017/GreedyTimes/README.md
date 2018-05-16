<h1>Problem 3 &ndash; Greedy Times</h1>
<p>&nbsp;</p>
<p>Finally, you have unlocked the safe and reached the treasure! Inside there are all kinds of gems, cash in different currencies and gold bullions. Next to you there is a bag which unfortunately has a limited space. You don&rsquo;t have much time so you need take as much wealth as possible! But in order to get bigger amount of the most valuable items you need to keep the following rules:</p>
<ul>
<li>The <strong>gold amount</strong> in your bag should <strong>always</strong> <strong>be</strong> <strong>more</strong> than <strong>or equal</strong> the <strong>gem</strong> <strong>amount </strong>at <strong>any</strong> time</li>
<li>The <strong>gem amount</strong> should <strong>always</strong> <strong>be</strong> <strong>more</strong> than <strong>or</strong> <strong>equal</strong> the <strong>cash</strong> <strong>amount </strong>at <strong>any</strong> time</li>
</ul>
<p>If you read an <strong>item</strong> which <strong>breaks</strong> <strong>this rule</strong> you <strong>should not put</strong> it in the <strong>bag</strong>. You should <strong>always </strong>be careful <strong>not</strong> to <strong>exceed</strong> the overall <strong>bag&rsquo;s capacity</strong> as it will tear down you will lose everything! You will receive the <strong>content</strong> <strong>of</strong> the <strong>safe</strong> on a <strong>single line</strong> in the <strong>format</strong> of <strong>item - quantity</strong> pairs separated by <strong>whitespace</strong>. You need to gather <strong>only</strong> <strong>three</strong> <strong>types</strong> of items:</p>
<ul>
<li>Cash - All <strong>three letter</strong> items</li>
<li>Gem - All <strong>items</strong> which <strong>end </strong>on &ldquo;<strong>Gem</strong>&rdquo; (at least 4 symbols)</li>
<li>Gold - this type has <strong>only one item</strong> with the name - &ldquo;<strong>Gold</strong>&rdquo;</li>
</ul>
<p>Each <strong>item</strong> which <strong>does not</strong> fall <strong>in</strong> one of the <strong>above categories</strong> is <strong>useless</strong> and you should <strong>skip it</strong>. Reading item&rsquo;s <strong>names</strong> should be <strong>CASE-INSENSITIVE</strong>. You should <strong>aggregate</strong> <strong>item&rsquo;s quantities</strong> which have the <strong>same</strong> <strong>name</strong>.</p>
<p>If you kept the rules you should have escaped successfully with a bag full of wealth. Now it&rsquo;s time to review what you have managed to get out of the safe. <strong>Print all</strong> the <strong>types</strong> ordered by <strong>total amount </strong>in<strong> descending order</strong>. Inside a type <strong>order</strong> the <strong>items</strong> first <strong>alphabetically</strong> in <strong>descending</strong> order and <strong>then by </strong>their<strong> amount</strong> in <strong>ascending</strong> order. Use the following format for each type:</p>
<p><strong>&ldquo;&lt;{type}&gt; ${total amount}&rdquo;</strong></p>
<p><strong>&ldquo;##{item} - {amount}&rdquo; </strong>- each item from this type on new line</p>
<h3>Input</h3>
<ul>
<li>On the <strong>first line</strong>, you will receive a <strong>number</strong> which represents the <strong>capacity</strong> of the <strong>bag</strong></li>
<li>On the <strong>second line</strong>, you will receive a <strong>sequence</strong> of <strong>item - quantity</strong> pairs</li>
</ul>
<h3>Output</h3>
<p>Print <strong>only</strong> the <strong>types </strong>from which you <strong>have items in the bag</strong> ordered by <strong>Total Amount</strong> descending. Inside a type order the <strong>items</strong> <strong>first</strong> <strong>alphabetically</strong> in <strong>descending</strong> order and <strong>then</strong> by <strong>amount</strong> in <strong>ascending</strong> <strong>order</strong>. Use the following format for each type:</p>
<p><strong>&ldquo;&lt;{type}&gt; ${total amount}&rdquo;</strong></p>
<p><strong>&ldquo;##{item} - {amount}&rdquo; </strong>- each item on new line</p>
<h3>Constraints</h3>
<ul>
<li>Bag&rsquo;s <strong>max capacity</strong> will <strong>always</strong> be in the range [0 &hellip; 90000000000]</li>
<li>All <strong>quantities</strong> will be <strong>positive</strong> <strong>integer </strong>in the range [0 &hellip; 2100000000]</li>
<li>Each item of type <strong>gem </strong>will have a<strong> name</strong> - <strong>at</strong> <strong>least 4</strong> symbols</li>
<li>Time limit: 0.1 sec. Memory limit: 16 MB</li>
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
<p>150</p>
<p>Gold 28 Rubygem 16 USD 9 GBP 8</p>
</td>
<td width="199">
<p>&lt;Gold&gt; $28</p>
<p>##Gold - 28</p>
<p>&lt;Gem&gt; $16</p>
<p>##Rubygem - 16</p>
<p>&lt;Cash&gt; $9</p>
<p>##USD - 9</p>
</td>
</tr>
<tr>
<td width="490">
<p>24000010</p>
<p>USD 1030 Gold 300000 EmeraldGem 900000 Topazgem 290000 CHF 280000 Gold 10000000 JPN 10000 Rubygem 10000000 KLM 3120010</p>
</td>
<td width="199">
<p>&lt;Gold&gt; $10300000</p>
<p>##Gold - 10300000</p>
<p>&lt;Gem&gt; $10290000</p>
<p>##Topazgem - 290000</p>
<p>##Rubygem - 10000000</p>
<p>&lt;Cash&gt; $3410010</p>
<p>##KLM - 3120010</p>
<p>##JPN - 10000</p>
<p>##CHF - 280000</p>
</td>
</tr>
<tr>
<td width="490">
<p>80345</p>
<p>RubyGem 70000 JAV 10960 Bau 60000 Gold 80000</p>
</td>
<td width="199">
<p>&lt;Gold&gt; $80000</p>
<p>##Gold - 80000</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>