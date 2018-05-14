<h1>Lab: Reflection and Attributes</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/csharp-oop-advanced-high-quality-code">"CSharp OOP Advanced" course @ SoftUni.</a></p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/710/Reflection-and-Attributes-Lab">Judge</a></p>
<h1>Part I: Reflection</h1>
<h2>1.&nbsp;&nbsp; Stealer</h2>
<p>Add the Hacker class from the box below to your project.</p>
<table>
<tbody>
<tr>
<td width="502">
<p><strong>Hacker.cs</strong></p>
</td>
</tr>
<tr>
<td width="502">
<p>public class Hacker</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; public string username = "securityGod82";</p>
<p>&nbsp;&nbsp;&nbsp; private string password = "mySuperSecretPassw0rd";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; public string Password</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; get =&gt; this.password;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; set =&gt; this.password = value;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; private int Id { get; set; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; public double BankAccountBalance { get; private set; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; public void DownloadAllBankAccountsInTheWorld()</p>
<p>&nbsp;&nbsp;&nbsp; {&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>There is one really nasty hacker but not so wise though. He is trying to steal a big amount of money and transfer it to his own account. The police is after him but they need a proffessional&hellip; Correct - this is you!</p>
<p>You have the information that this hacker is keeping some of his info in private fields. Create a new class named <strong>Spy </strong>and add inside a method called - <strong>StealFieldInfo </strong>which receives:</p>
<ul>
<li>stirng - name of the class to investigate</li>
<li>array of string - names of the filds to investigate</li>
</ul>
<p>After finding the fields you must print on the console:</p>
<p>&ldquo;Class under investigation: <strong>{nameOfTheClass}</strong>&rdquo;</p>
<p>On the next lines print info about each field in the current format:</p>
<p>&ldquo;<strong>{filedName} </strong>= <strong>{fieldValue}</strong>&rdquo;</p>
<p>Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class!</strong></p>
<p>In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>Class under investigation: Hacker</p>
<p>username = securityGod82</p>
<p>password = mySuperSecretPassw0rd</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<h2>2.&nbsp;&nbsp; High Quality Mistakes</h2>
<p>You are already expert of <strong>High Quality Code</strong>, so you know what kind of <strong>access modifiers</strong> must be set to members of class. You should have noticed our hacker is not familiar with these concepts.</p>
<p>Create a method inside your Spy class called - AnalyzeAcessModifiers(string className). Check all <strong>fields and methods access modifiers</strong>. Print on console all <strong>mistakes</strong> in format:</p>
<ul>
<li>Fields
<ul>
<li><strong>{fieldName} must be private!</strong></li>
</ul>
</li>
<li>Getters
<ul>
<li><strong>{methodName} have to be public!</strong></li>
</ul>
</li>
<li>Setters
<ul>
<li><strong>{methodName} have to be private!</strong></li>
</ul>
</li>
</ul>
<p>Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class!</strong></p>
<p>In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>username must be private!</p>
<p>get_Id have to be public!</p>
<p>set_Password have to be private!</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<h2>3.&nbsp;&nbsp; Mission Private Impossible</h2>
<p>It&rsquo;s time to see what this hacker you are dealing with aims to do.&nbsp; Create a method inside your Spy class called - RevealPrivateMethods(stirng className). Print all private methods in the following format:</p>
<p>All Private Methods of Class: <strong>{className}</strong><br /> Base Class: <strong>{baseClassName}</strong><br /> On the next lines print found method&rsquo;s names each on new line<br /> Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class!</strong><br /> In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>All Private Methods of Class: Hacker</p>
<p>Base Class: Object</p>
<p>get_Id</p>
<p>set_Id</p>
<p>set_BankAccountBalance</p>
<p>Finalize</p>
<p>MemberwiseClone</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<h2>4.&nbsp;&nbsp; Collector</h2>
<p>Using reflection to get all "Hacker" methods. Then prepare algorithm that will recognize, which methods are getters and setters.</p>
<p>Print to console each getter on new line in format:<br /> <strong>{name} will return {Return Type}</strong></p>
<p>Then print all setters in format:<br /> <strong>{name} will set field of {Parameter Type}</strong></p>
<p>Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class!</strong></p>
<p>In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="520">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="520">
<p>get_Password will return System.String</p>
<p>get_Id will return System.Int32</p>
<p>get_BankAccountBalance will return System.Double</p>
<p>set_Password will set field of System.String</p>
<p>set_Id will set field of System.Int32</p>
<p>set_BankAccountBalance will set field of System.Double</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<h1>Part II: Attributes</h1>
<h2>5.&nbsp;&nbsp; Create Attribute</h2>
<p>Create attribute SoftUni with a string element called <strong>name</strong>, that<strong>:</strong></p>
<ul>
<li>Can be used over classes and methods</li>
<li>Allow multiple attributes of same type</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>[SoftUni("Ventsi")]</p>
<p>class StartUp</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; [SoftUni("Gosho")]</p>
<p>&nbsp;&nbsp;&nbsp; static void Main(string[] args)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
}</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Coding Tracker</h2>
<p>Create a class <strong>Tracker</strong> with a method:</p>
<ul>
<li>static void printMethodsByAuthor()</li>
</ul>
<h3>&nbsp;Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>[SoftUni("Ventsi")]</p>
<p>class StartUp</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; [SoftUni("Gosho")]</p>
<p>&nbsp;&nbsp;&nbsp; static void Main(string[] args)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var tracker = new Tracker();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tracker.PrintMethodsByAuthor();</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
}</td>
</tr>
</tbody>
</table>
