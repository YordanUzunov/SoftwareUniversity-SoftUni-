<h1>Exercises: Regular Expressions (RegEx)</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/programming-fundamentals">"Programming Fundamentals" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/430/Regex-Exercise">Judge</a>.</p>
<h2>1. Extract Emails</h2>
<p>Write a program to <strong>extract all email addresses from a given text</strong>. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format &lt;user&gt;@&lt;host&gt;, where:</p>
<ul>
<li><strong>&lt;user&gt; </strong>is a sequence of <strong>letters</strong> and <strong>digits</strong>, where '.', '-' and '_' can appear between them.
<ul>
<li>Examples of valid users: "<strong>stephan</strong>", "<strong>mike03</strong>", "<strong>johnson</strong>", "<strong>st_steward</strong>", "<strong>softuni-bulgaria</strong>", "<strong>12345</strong>".</li>
<li>Examples of invalid users: ''<strong>--123</strong>", "<strong>.....</strong>", "<strong>nakov_-</strong>", "<strong>_steve</strong>", "<strong>.info</strong>".</li>
</ul>
</li>
<li><strong>&lt;host&gt; </strong>is a sequence of at least two words, separated by dots '<strong>.</strong>'. Each word is sequence of letters and can have hyphens '<strong>-</strong>' between the letters.
<ul>
<li>Examples of hosts: "<strong>bg</strong>", "<strong>software-university.com</strong>", "<strong>intoprogramming.info</strong>", "<strong>mail.softuni.org</strong>".</li>
<li>Examples of invalid hosts: "<strong>helloworld</strong>", "<strong>.unknown.soft.</strong>", "<strong>invalid-host-</strong>", "<strong>invalid-</strong>".</li>
</ul>
</li>
<li>Examples of <strong>valid emails</strong>: <strong>info@softuni-bulgaria.org</strong>, <strong>kiki@hotmail.co.uk</strong>, <strong>no-reply@github.com</strong>, <strong>peterson@mail.uu.net</strong>, <strong>info-bg@software-university.software.academy</strong>.</li>
<li>Examples of <strong>invalid emails</strong>: <strong>--123@gmail.com</strong>, <strong>&hellip;@mail.bg</strong>, <strong>.info@info.info</strong>, <strong>_steve@yahoo.cn</strong>, <strong>mike@helloworld</strong>, <strong>mike@.unknown.soft</strong><strong>.</strong>, <strong>johnson@invalid-</strong>.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="502">
<p><strong>Input</strong></p>
</td>
<td width="222">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="502">
<p>Please contact us at: support@github.com.</p>
</td>
<td width="222">
<p>support@github.com</p>
</td>
</tr>
<tr>
<td width="502">
<p>Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.</p>
</td>
<td width="222">
<p>s.miller@mit.edu</p>
<p>j.hopking@york.ac.uk</p>
</td>
</tr>
<tr>
<td width="502">
<p>Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. &ndash;- steve.parker@softuni.de.</p>
</td>
<td width="222">
<p>steve.parker@softuni.de</p>
</td>
</tr>
</tbody>
</table>
<h2>2. Extract Sentences by Keyword</h2>
<p>Write a program that extracts <strong>all sentences</strong> that <strong>contain</strong> a particular <strong>word</strong> from a string (case-sensitive).</p>
<ul>
<li>Assume that the <strong>sentences</strong> are <strong>separated</strong> from each other by the character "." or "!" or "?".</li>
<li>The <strong>words</strong> are separated by a <strong>non-letter character</strong>.</li>
<li>Note that a <strong>substring</strong> is different than a <strong>word</strong>. The sentence &ldquo;I am a fan of Mo<strong>to</strong>rhead&rdquo; does not contain the word &ldquo;<strong>to</strong>&rdquo;. It contains the <strong>substring</strong> &ldquo;<strong>to</strong>&rdquo;, which is <strong>not</strong> what we need.</li>
<li>Print the result text <strong>without</strong> the separators between the sentences ("." or "!" or "?").</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="701">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="701">
<p><strong>to</strong></p>
<p>Welcome <strong>to</strong> SoftUni! You will learn programming, algorithms, problem solving and software technologies. You need <strong>to</strong> allocate for study 20-30 hours weekly. Good luck! I am fan of Motorhead. To be or not <strong>to</strong> be - that is the question. TO DO OR NOT?</p>
</td>
</tr>
<tr>
<td width="701">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="701">
<p>Welcome <strong>to</strong> SoftUni</p>
<p>You need <strong>to</strong> allocate for study 20-30 hours weekly</p>
<p>To be or not <strong>to</strong> be - that is the question</p>
</td>
</tr>
</tbody>
</table>
<h2>3. Camera View</h2>
<p>You are an amateur photographer and you want to calculate what will be seen in your pictures.</p>
<p>On the <strong>first</strong> line, you will receive an <strong>array of integers</strong> with exactly <strong>two</strong> elements:</p>
<p><strong>First</strong> element &ndash; <strong>m</strong> will be the elements, which you have to skip. The <strong>second element</strong> &ndash; <strong>n</strong> will be the elements, which you have to <strong>take</strong>.</p>
<p>On the <strong>next</strong> line, you will receive a <strong>string</strong>, in which every camera will be marked with "<strong>|&lt;</strong>". Skip the next <strong>m </strong>elements <strong>immediately</strong> after the camera and <strong>take</strong> the next <strong>n </strong>elements.</p>
<p>If you encounter <strong>new</strong> camera in the <strong>view</strong> &egrave; <strong>stop</strong> the current <strong>camera</strong> and <strong>start</strong> <strong>new</strong> <strong>view</strong> with the newly found.</p>
<h3>Output</h3>
<p>Print <strong>all</strong> the taken <strong>views</strong> separated with ", ".</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="498">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="498">
<p>9 7</p>
<p>GreatBigSea|&lt;uglyStuffHawaii|&lt;boriiiingKilauea</p>
</td>
<td width="198">
<p>Hawaii, Kilauea</p>
</td>
</tr>
<tr>
<td width="498">
<p>0 5</p>
<p>|&gt;invalid|&lt;beach|noMoreCameras</p>
</td>
<td width="198">
<p>beach</p>
</td>
</tr>
</tbody>
</table>
<h2>4. Weather</h2>
<p>You have to make a weather forecast about the weather depending on <strong>strings</strong>, which you receive from the <strong>console</strong>. Every string consists of <strong>data</strong> about the <strong>city</strong>, <strong>average temperature</strong> and <strong>weather type</strong>. You will receive strings <strong>until</strong> you receive the command &ldquo;end&rdquo;.</p>
<p>Every <strong>valid</strong> weather forecast <strong>consists</strong> of:</p>
<ul>
<li><strong>Two</strong> <strong>Latin</strong> <strong>capital</strong> <strong>letters</strong>, which represent the code of the <strong>city</strong></li>
<li><strong>Immediately</strong> followed by a <strong>floating-point</strong> number, which will represent the <strong>average temperature</strong>. Numbers <strong>without </strong>a floating point are <strong>not</strong> considered <strong>valid</strong>.</li>
<li>Followed by the<strong> type</strong> of weather, which will consist of <strong>uppercase</strong> and <strong>lowercase</strong> <strong>Latin</strong> <strong>letters</strong>, starts <strong>immediately</strong> <strong>after</strong> the <strong>temperature</strong> and <strong>ends</strong> at the <strong>first</strong> occurrence of the sign &lsquo;|&rsquo;</li>
</ul>
<p>If you receive input, which does <strong>not</strong> follow the rules above &ndash; <strong>ignore</strong> it.</p>
<p>If you receive a <strong>new</strong> <strong>temperature</strong> and/or type of weather for a city, which <strong>already exists</strong> &ndash; <strong>rewrite</strong> the previous values.</p>
<p>At the end, <strong>print</strong> the <strong>temperature </strong>and <strong>weather type</strong> for <strong>every</strong> city. <strong>Order</strong> the <strong>cities</strong> by <strong>average</strong> <strong>temperature</strong> in <strong>ascending</strong> <strong>order</strong>.</p>
<h3>Input</h3>
<p>You will receive strings until you receive the command &ldquo;end&rdquo;.</p>
<h3>Output</h3>
<p>Print <strong>all</strong> cities ordered by <strong>average</strong> <strong>temperature</strong> in <strong>ascending</strong> order. Use the following <strong>format</strong>:</p>
<p>&ldquo;{nameOfTheCity} =&gt; {averageTemperature} =&gt; {typeOfWeather}&rdquo;</p>
<p><strong>Format</strong> the temperature to the <strong>2<sup>nd</sup> decimal place</strong>.</p>
<h3>Constraints</h3>
<ul>
<li>The average temperature will be in the interval <strong>[0.00&hellip;50.00]</strong></li>
<li>The <strong>floating-point</strong> numbers will have at most <strong>2</strong> digits after the floating point.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="228">
<p><strong>Input</strong></p>
</td>
<td width="188">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="228">
<p>PB23.41Rainy|ASDASD</p>
<p>SDASCA20.21sUNNY|SDASD</p>
<p>asdaCA22.5rainy|sada</p>
<p>CA23.41cloydy</p>
<p>end</p>
</td>
<td width="188">
<p>CA =&gt; 22.50 =&gt; rainy</p>
<p>PB =&gt; 23.41 =&gt; Rainy</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="228">
<p><strong>Input</strong></p>
</td>
<td width="188">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="228">
<p>invalidKA31.41|sunny|</p>
<p>validCA12.41Rainy|absad</p>
<p>gfASFasASPA31.21cloudy|asd</p>
<p>YA21.51sunny|</p>
<p>sadL21.41rainy|adas</p>
<p>end</p>
</td>
<td width="188">
<p>CA =&gt; 12.41 =&gt; Rainy</p>
<p>YA =&gt; 21.51 =&gt; sunny</p>
<p>PA =&gt; 31.21 =&gt; cloudy</p>
</td>
</tr>
</tbody>
</table>
<h2>5. Key Replacer</h2>
<p>You will be given a <strong>key</strong> <strong>string</strong> and a <strong>text</strong> <strong>string</strong>. The key string will contain a <strong>start</strong> <strong>key</strong> and an <strong>end</strong> <strong>key</strong>.</p>
<p>The <strong>start</strong> <strong>key</strong> starts at the <strong>beginning</strong> of the <strong>string</strong> and <strong>ends</strong> at the <strong>first</strong> occurrence of one of the symbols &ndash; &ldquo;|&rdquo;, &ldquo;&lt;&rdquo; or &ldquo;\&rdquo;. The <strong>end</strong> <strong>key</strong> starts at the <strong>last</strong> occurrence of <strong>one</strong> of <strong>these</strong> <strong>symbols</strong> and <strong>ends</strong> when the <strong>string</strong> <strong>ends</strong>. Both keys can contain <strong>only</strong> <strong>Latin</strong> <strong>alphabet</strong> <strong>letters</strong>.</p>
<p>When you extract <strong>both</strong> keys search for them in the text string and extract every string, which is <strong>between</strong> them. <strong>Concatenate</strong> all <strong>collected</strong> <strong>strings</strong> and <strong>print</strong> the <strong>result</strong>. If the result string is <strong>empty</strong> print &ldquo;Empty result&rdquo;.</p>
<h3>Input</h3>
<p>The input will be read from the <strong>console</strong>. The <strong>first</strong> line will hold the <strong>keys</strong> <strong>string</strong> and the <strong>second</strong> line will hold the <strong>text</strong> to search.</p>
<h3>Output</h3>
<p>Print the <strong>concatenated</strong> <strong>message</strong>, if such exists or "<strong>Empty result</strong>", if it does not.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="503">
<p><strong>Input</strong></p>
</td>
<td width="186">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="503">
<p>start&lt;213asfaas|end</p>
<p>saaastarthelloendsdarstartFromTheOtherenddvsefdsfstartSideend</p>
</td>
<td width="186">
<p>helloFromTheOtherSide</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="496">
<p><strong>Input</strong></p>
</td>
<td width="193">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="496">
<p>A|safafasfsadf|B</p>
<p>NoMEssageABhereYeyAB</p>
</td>
<td width="193">
<p>Empty result</p>
</td>
</tr>
</tbody>
</table>
<h2>6. * Valid Usernames</h2>
<p>You are part of the back-end development team of the next Facebook.</p>
<p>You are given a<strong> line of usernames</strong>, <strong>separated</strong> by one of the following symbols: &ldquo; &rdquo;, &ldquo;/&rdquo;, &ldquo;\&rdquo;, &ldquo;(&ldquo;, &ldquo;)&rdquo;<strong>.</strong></p>
<p>First you have to export all <strong>valid </strong>usernames. A valid username <strong>starts with a letter</strong> and can only contain <strong>letters</strong>, <strong>digits </strong>and underscores &ldquo;_&rdquo;. It cannot be <strong>less than 3 or more than 25 symbols</strong> long.</p>
<p>Your task is to <strong>sum</strong> the length of <strong>every</strong> <strong>2 consecutive</strong> <strong>valid </strong>usernames and print the 2 valid usernames with <strong>biggest</strong> <strong>sum</strong> of their <strong>lengths, </strong>on the console, each on a separate line.</p>
<h3>Input</h3>
<p>The input comes from the console. One line will hold all the data. It will hold <strong>usernames, </strong>divided by the symbols: &ldquo; &ldquo;, &ldquo;/&rdquo;, &ldquo;\&rdquo;, &ldquo;(&ldquo;, &ldquo;)&rdquo;.</p>
<p>The input data will <strong>always be valid</strong> and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print the 2 <strong>consecutive</strong> <strong>valid usernames</strong> with the <strong>biggest</strong> <strong>sum</strong> of their lengths on the console, each on a separate line.</p>
<p>If there are <strong>2 or more couples</strong> of usernames with the same sum of their lengths, print the <strong>left most</strong>.</p>
<h3>Constraints</h3>
<ul>
<li>The input line will hold characters in the range [0 &hellip; 9999].</li>
<li>The usernames should <strong>start with a letter</strong> and can contain <strong>only letters, digits and </strong>&ldquo;_&rdquo;.</li>
<li>The username cannot be <strong>less than 3 or</strong> <strong>more than 25 symbols</strong> long.</li>
</ul>
<ul>
<li>Time limit: 0.5 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="405">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="405">
<p>ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref</p>
</td>
<td width="189">
<p>wfsdg</p>
<p>ds2c_vbg</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="406">
<p><strong>Input</strong></p>
</td>
<td width="188">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="406">
<p>min23/ace hahah21 (&nbsp;&nbsp;&nbsp; sasa&nbsp; )&nbsp; att3454/a/a2/abc</p>
</td>
<td width="188">
<p>hahah21</p>
<p>sasa</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="406">
<p><strong>Input</strong></p>
</td>
<td width="188">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="406">
<p>chico/ gosho \ sapunerka (3sas) mazut&nbsp; lelQ_Van4e</p>
</td>
<td width="188">
<p>mazut</p>
<p>lelQ_Van4e</p>
</td>
</tr>
</tbody>
</table>
<h2>7. * Query Mess</h2>
<p><strong>Ivancho</strong> participates in a team <strong>project</strong> with colleagues at <strong>SoftUni</strong>.&nbsp; They have to develop <strong>an application</strong>, but something <em>mysterious</em> happened &ndash; at the last moment all team members&hellip; disappeared!&nbsp; And guess what? He is left <strong>alone</strong> to finish the project.&nbsp; All that is left to do is to parse the input data and store it in a special way, but Ivancho has no idea how to do that! Can you help him?</p>
<h3>Input</h3>
<p>The input comes from the console on a variable number of lines and ends when the keyword "END" is received.&nbsp;</p>
<p>For each row of the input, the query string contains <strong>field=value</strong> pairs. Within each pair, the field name and value are separated by an equals sign, '='. The series of pairs are separated by an ampersand, '&amp;'. The <strong>question mark</strong> is used as a separator and is <strong>not</strong> part of the query string. A URL query string may contain another URL as value. The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p><strong>For each input line, print</strong> on the console a line containing the <strong>processed string as follows</strong>:&nbsp; key=[value]nextkey=[another value] ... etc.</p>
<p><strong>Multiple whitespace</strong> characters should be reduced to one inside value/key names, but there shouldn&rsquo;t be any whitespaces before/after extracted <strong>keys</strong> and <strong>values</strong>. If a key <strong>already exists</strong>, the value is added with comma and space after other values of the existing key in the current string.&nbsp; See the <strong>examples</strong> below.&nbsp;</p>
<h3>Constraints</h3>
<ul>
<li><strong>SPACE</strong> is encoded as '+' or "%20". Letters (A-Z&nbsp;and a-z), numbers (0-9), the characters '*', '-', '.', '_' and <em>other non-special symbols</em> are left as-is.</li>
<li>Allowed working time: 0.1 seconds. Allowed memory: 16</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="678">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>login=student&amp;password=student</p>
<p>END</p>
</td>
</tr>
<tr>
<td width="678">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>login=[student]password=[student]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="678">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>field=value1&amp;field=value2&amp;field=value3</p>
<p>http://example.com/over/there?name=ferret</p>
<p>END</p>
</td>
</tr>
<tr>
<td width="678">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>field=[value1, value2, value3]</p>
<p>name=[ferret]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="678">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>foo=%20foo&amp;value=+val&amp;foo+=5+%20+203</p>
<p>foo=poo%20&amp;value=valley&amp;dog=wow+</p>
<p>url=https://softuni.bg/trainings/coursesinstances/details/1070</p>
<p>https://softuni.bg/trainings.asp?trainer=nakov&amp;course=oop&amp;course=php</p>
<p>END</p>
</td>
</tr>
<tr>
<td width="678">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>foo=[foo, 5 203]value=[val]</p>
<p>foo=[poo]value=[valley]dog=[wow]</p>
<p>url=[https://softuni.bg/trainings/coursesinstances/details/1070]</p>
<p>trainer=[nakov]course=[oop, php]</p>
</td>
</tr>
</tbody>
</table>
<h2>8. *Use Your Chains, Buddy</h2>
<p><strong>This problem is from the JavaScript Basics Exam (9 January 2015). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/56#2"><strong>here</strong></a><strong>.</strong></p>
<p>You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut. You need to get there by car. But there is so much snow that you need to use car chains. In order to put them on the wheels correctly, you need to read the manual. But it is encrypted&hellip;</p>
<p>As input you will receive <strong>an HTML document</strong> as a <strong>single string</strong>. You need to get the text from <strong>all the &lt;p&gt; tags </strong>and replace all characters which are <strong>not small letters and numbers</strong> with a space <strong>" "</strong>. After that you must decrypt the text &ndash; all letters <strong>from a to m</strong> are <strong>converted</strong> to letters <strong>from n to z</strong> (a &agrave; n; b &agrave; o; &hellip; m &agrave; z). The letters <strong>from n to z</strong> are <strong>converted</strong> to letters <strong>from a to m</strong> (n &agrave; a; o &agrave; b; &hellip; z &agrave; m). All <strong>multiple</strong> spaces should then be replaced by only <strong>one space</strong>.</p>
<p>For example, if we have <strong>"&lt;div&gt;Santa&lt;/div&gt;&lt;p&gt;znahny # grkg ()&amp;^^^&amp;12&lt;/p&gt;"</strong> we extract <strong>"znahny # grkg ()&amp;^^^&amp;12"</strong>. Every <strong>character</strong> that is <strong>not a small letter or a number</strong> is replaced with a space (<strong>"znahny grkg&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 12"</strong>). We convert each small letter as described above (<strong>"znahny grkg&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 12" </strong><strong>&agrave; "manual text&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 12"</strong>) and replace all multiple spaces with only <strong>one space</strong> (<strong>"manual text 12"</strong>). Finally, we concatenate the decrypted text from all <strong>&lt;p&gt;&lt;/p&gt;</strong> tags (in this case, it's only one). And there you go &ndash; you have the manual ready to read!</p>
<h3>Input</h3>
<p>The input is read from the console and consists of just one line &ndash; the <strong>string</strong> with the <strong>HTML document</strong>.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p><strong>Print</strong> on a single line the decrypted text of the manual. See the given <strong>examples</strong> below.</p>
<h3>Constraints</h3>
<ul>
<li>Allowed working time: 0.2 seconds. Allowed memory: 16</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="576">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="576">
<p>&lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;hello&lt;/h1&gt;&lt;p&gt;<strong>znahny!@#%&amp;&amp;&amp;&amp;****</strong>&lt;/p&gt;&lt;div&gt;&lt;button&gt;dsad&lt;/button&gt;&lt;/div&gt;&lt;p&gt;<strong>grkg^^^^%%%)))([]12</strong>&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;</p>
</td>
</tr>
<tr>
<td width="576">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="576">
<p>manual text 12</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="854">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="854">
<p>&lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;Intro&lt;/h1&gt;&lt;ul&gt;&lt;li&gt;Item01&lt;/li&gt;&lt;li&gt;Item02&lt;/li&gt;&lt;li&gt;Item03&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;<strong>jura qevivat va jrg fyvccrel fabjl</strong>&lt;/p&gt;&lt;div&gt;&lt;button&gt;Click me, baby!&lt;/button&gt;&lt;/div&gt;&lt;p&gt; <strong>pbaqvgvbaf fabj&nbsp; qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx</strong> &lt;/p&gt;&lt;span&gt;This manual is false, do not trust it! The illuminati wrote it down to trick you!&lt;/span&gt;&lt;p&gt;<strong>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</strong>&lt;/p&gt;&lt;p&gt;<strong> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</strong>&lt;/p&gt;&lt;/body&gt;</p>
</td>
</tr>
<tr>
<td width="854">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="854">
<p>when driving in wet slippery snowy conditions snow chains are absolutely essential for safe handling although snow chains may look intimidating the basic idea is really simple fit them over your tires drive forward slowly and tighten them up in cold wet conditions this is easier said than done but if you put on your tires</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
