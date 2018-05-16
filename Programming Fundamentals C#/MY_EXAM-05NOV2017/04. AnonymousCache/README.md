<p><em></em></p>
<h1>Problem 4. Anonymous Cache</h1>
<p>The Anonymous are storing data on their dataservers about their activities. The CIA has higher the greatest hacker in the world &ndash; You. Your job is to extract their data and send it to the CIA. It won&rsquo;t be an easy task, Get Ready!</p>
<p>You will receive <strong>several input lines</strong> in one of the following formats:</p>
<ul>
<li>{dataSet}</li>
<li>{dataKey} -&gt; {dataSize} | {dataSet}</li>
</ul>
<p>The dataSet and dataKey are both strings. The dataSize is an <strong>integer</strong>. The dataSets hold dataKeys and their dataSizes.</p>
<p>If you receive only a dataSet you should <strong>add</strong> it. If you receive a dataKey and a dataSize, you should add them to the <strong>given</strong> dataSet.</p>
<p>And here&rsquo;s where the fun begins. If you receive a dataKey and a dataSize, but the given dataSet <strong>does NOT exist</strong>, you should <strong>STORE</strong> those <strong>keys</strong> and <strong>values</strong> in a cache. When the corresponding dataSet is <strong>added</strong>, you should <strong>check</strong> if the cache holds any <strong>keys</strong> and <strong>values</strong> referenced to it, and you should <strong>add</strong> them to the dataSet.</p>
<p>You should end your program when you receive the command &ldquo;thetinggoesskrra&rdquo;.&nbsp; At that point you should extract the dataSet from the data with the <strong>HIGHEST</strong> dataSize (<strong>SUM</strong> of all its dataSizes), and you should print it.</p>
<p><strong>NOTE</strong>: Elements in the cache, <strong>should be CONSIDERED NON-EXISTANT</strong>. You should <strong>NOT</strong> count them in the <strong>final output</strong>.</p>
<p>In case there are <strong>NO</strong> dataSets in the data, you <strong>should</strong> <strong>NOT</strong> <strong>do anything</strong>.</p>
<h3>Input</h3>
<ul>
<li>The input comes in the form of commands in one of the formats specified above.</li>
<li>The input ends when you receive the command &ldquo;thetinggoesskrra&rdquo;.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you must print the dataSet with the <strong>HIGHEST</strong> <strong>SUM</strong> of all dataSizes.</li>
<li>The output format is:</li>
</ul>
<p>Data Set: {dataSet}, Total Size: {sumOfAllDataSizes}</p>
<p>$.{dataKey1}</p>
<p>$.{dataKey2}</p>
<p>...</p>
<ul>
<li>In case there are <strong>NO</strong> dataSets in the data, print <strong>nothing</strong>.</li>
</ul>
<h3>Constrains</h3>
<ul>
<li>The dataSet and dataKey are <strong>both strings</strong> which may contain <strong>ANY ASCII</strong> character except &lsquo; &rsquo;, &lsquo;-&rsquo;, &lsquo;&gt;&rsquo;, &lsquo;|&rsquo;.</li>
<li>The dataSize is a <strong>valid integer</strong> in <strong>range [0, 1.000.000.000]</strong>.</li>
<li>There will be <strong>NO invalid input lines</strong>.</li>
<li>There will be <strong>NO</strong> dataSets with <strong>EQUAL SUMMED </strong>dataSize.</li>
<li>There will be <strong>NO DUPLICATE</strong></li>
<li>Allowed working <strong>time/memory</strong>: <strong>100ms / 16MB</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="340">
<p><strong>Input</strong></p>
</td>
<td width="354">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="340">
<p>Users</p>
<p>BankAccounts</p>
<p>ADDB444 -&gt; 23111 | BankAccounts</p>
<p>Students -&gt; 2000 | Users</p>
<p>Workers -&gt; 24233 | Users</p>
<p>thetinggoesskrra</p>
</td>
<td width="354">
<p>Data Set: Users, Total Size: 26233</p>
<p>$.Students</p>
<p>$.Workers</p>
</td>
</tr>
<tr>
<td width="340">
<p>Cars</p>
<p>Car1 -&gt; 233333 | Cars</p>
<p>Car23 -&gt; 266666 | Cars</p>
<p>Warehouse2 -&gt; 10000 | Buildings</p>
<p>Warehouse3 -&gt; 480000 | Buildings</p>
<p>Warehouse5 -&gt; 100000 | Buildings</p>
<p>Buildings</p>
<p>thetinggoesskrra</p>
</td>
<td width="354">
<p>Data Set: Buildings, Total Size: 590000</p>
<p>$.Warehouse2</p>
<p>$.Warehouse3</p>
<p>$.Warehouse5</p>
</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>
<p><em>...Why the Gunpowder treason</em></p>
<p><em>Should ever be forgot!...</em></p>
<p><em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>V</strong></em></p>