<h1>Problem 1. SoftUni Coffee Orders</h1>
<p>At SoftUni we are placing <strong>N</strong> orders of coffee at a time, one order each month. Write a program to calculate the price for each order and the total price based on the following formula:</p>
<p>price = (daysInMonth * capsulesCount) * pricePerCapsule</p>
<p>* <strong>Hint</strong>: the DateTime class may come in handy to calculate the days in certain month.</p>
<h3>Input / Constraints</h3>
<ul>
<li>The first line holds an integer <strong>N</strong> &ndash; the count of orders the shop will receive.</li>
<li>For each order the next lines hold the following information:
<ul>
<li><strong>Price</strong> per capsule &ndash; floating-point number in range<strong> [0&hellip;79,228,162,514,264,337,593,543,950,335]</strong>.</li>
<li>Order <strong>date</strong> &ndash; in the following format: {d/M/yyyy}, e.g. 25/11/2016, 7/03/2016, 1/1/2020.</li>
<li><strong>Capsules</strong> count &ndash; integer in range<strong> [0&hellip;2,147,483,647]</strong>.</li>
</ul>
</li>
</ul>
<p>The input will be in the described format, there is no need to check it explicitly.</p>
<h3>Output</h3>
<p>The output should consist of <strong>N + 1</strong> lines. For <strong>each order</strong> you must print a single line in the following format:</p>
<ul>
<li>The price for the coffee is: ${price}</li>
</ul>
<p>On the last line you need to print the <strong>total price</strong> in the following format:</p>
<ul>
<li>Total: ${totalPrice}</li>
</ul>
<p>The <strong>price must be rounded</strong> to 2 decimal places.</p>
<p>The <strong>total price</strong> will always be within the range<strong> [0&hellip;79,228,162,514,264,337,593,543,950,335]</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="98">
<p><strong>Input</strong></p>
</td>
<td width="293">
<p><strong>Output</strong></p>
</td>
<td width="287">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="98">
<p>1</p>
<p>1.53</p>
<p>06/06/2016</p>
<p>8</p>
</td>
<td width="293">
<p>The price for the coffee is: $367.20</p>
<p>Total: $367.20</p>
</td>
<td width="287">
<p>We are given only one order. Then we&nbsp; use the formulas:</p>
<p><strong>orderPrice</strong> = 30 (days in June 2016) * 8 * 1.53 = 367.20</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="98">
<p><strong>Input</strong></p>
</td>
<td width="293">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="98">
<p>2</p>
<p>4.99</p>
<p>6/07/2016</p>
<p>3</p>
<p>0.35</p>
<p>03/01/2013</p>
<p>5</p>
</td>
<td width="293">
<p>The price for the coffee is: $464.07</p>
<p>The price for the coffee is: $54.25</p>
<p>Total: $518.32</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>