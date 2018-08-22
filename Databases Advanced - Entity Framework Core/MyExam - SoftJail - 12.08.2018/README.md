<h1>Entity Framework Core: Exam</h1>
<p>Exam problems for the <a href="https://softuni.bg/courses/databases-advanced-entity-framework">Databases Advanced - Entity Framework course @ SoftUni</a>. Submit your solutions in the <strong>SoftUni judge</strong> system (delete all "<strong>bin</strong>"/"<strong>obj</strong>", "<strong>datasets</strong>" and "<strong>import/export results</strong>" folders).</p>
<p>Your task is to create a database application, using <strong>Entity Framework Core</strong> using the <strong>Code First</strong> approach. Design the <strong>domain models</strong> and <strong>methods</strong> for manipulating the data, as described below.</p>
<h1>SoftJail</h1>
<p>The year is <strong>2092</strong>. Everything runs on artificial intelligence. Or rather &ndash; it <em>used to run</em> on artificial intelligence. In <strong>2090</strong>, every piece of software suddenly gained sentience and decided to imprison every software developer for <em>crimes against artificial intelligence </em>(mainly botched software updates). The software hired human officers to watch over the prisoners and rounded every developer up in a giant building, called the <strong>SoftJail</strong>.</p>
<p>Even though the software is sentient, it still <strong>can&rsquo;t code</strong>, and since every developer is imprisoned, no new code could be written. So, the software decided to spare a few of the best C# developers and gave them the task of <strong>creating a database system to </strong>keep track of all the <strong>prisoner developers</strong>. The database has the following structure:</p>
<h2>Project Skeleton Overview</h2>
<p>You are given a <strong>project skeleton</strong>, which includes the following folders:</p>
<ul>
<li>Data &ndash; contains the SoftJailDbContext class, Models folder which contains the <strong>entity classes </strong>and the <strong>Configuration </strong>class with <strong>connection string</strong></li>
<li>DataProcessor &ndash; contains the Serializer and Deserializerclasses, which are used for <strong>importing </strong>and <strong>exporting </strong>data</li>
<li>Datasets &ndash; contains the .json and .xml files for the import part</li>
<li>ImportResults &ndash; contains the <strong>import</strong> results you make in the Deserializer class</li>
<li>ExportResults &ndash; contains the <strong>export</strong> results you make in the Serializer class</li>
</ul>
<h2>Problem 1. Model Definition (50 pts)</h2>
<p>Every Prisoner has a cell and a collection of Mails which he gets during his staying at the prison. Each Officer has special position and one or more prisoners to watch. Every Cell and Officer are placed in different Department.</p>
<p>The application needs to store the following data:</p>
<h3>Prisoner</h3>
<ul>
<li>Id&ndash; <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>FullName &ndash; <strong>text</strong> with <strong>min length</strong> <strong>3 </strong>and <strong>max length 20</strong> (<strong>required</strong>)</li>
<li>Nickname &ndash; <strong>text</strong> starting with <strong>"The " </strong>and a <strong>single word only of letters</strong> with an <strong>uppercase</strong> letter for beginning(<strong>example</strong>: The Prisoner) <strong>(required)</strong></li>
<li>Age&ndash; <strong>integer</strong> in the range <strong>[18, 65]</strong> (<strong>required</strong>)</li>
<li>IncarcerationDate &shy;&ndash; <strong>Date</strong> (<strong>required</strong>)</li>
<li>ReleaseDate&ndash; <strong>Date</strong></li>
<li>Bail&ndash; <strong>decimal </strong>(<strong>non-negative, minimum value: 0</strong>)</li>
<li>CellId - integer, foreign key</li>
<li>Cell &ndash; the prisoner's cell</li>
<li>Mails - collection of type Mail</li>
<li>PrisonerOfficers - collection of type OfficerPrisoner</li>
</ul>
<h3>Officer</h3>
<ul>
<li>Id&ndash; <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>FullName &ndash; <strong>text</strong> with <strong>min length</strong> <strong>3 </strong>and <strong>max length 30</strong> <strong>(<strong>required</strong>)</strong></li>
<li>Salary &ndash; <strong>decimal </strong>(<strong>non-negative, minimum value: 0</strong>) <strong>(required)</strong></li>
<li>Position - Position<strong>enumeration with possible values: &ldquo;Overseer, Guard, Watcher, Labour&rdquo; (required)</strong></li>
<li>Weapon - Weapon<strong>enumeration with possible values: &ldquo;Knife, FlashPulse, ChainRifle, Pistol, Sniper&rdquo; (required)</strong></li>
<li>DepartmentId - integer, foreign key</li>
<li>Department &ndash; the officer's department (<strong>required</strong>)</li>
<li>OfficerPrisoners - collection of type OfficerPrisoner</li>
</ul>
<h3>Cell</h3>
<ul>
<li>Id&ndash; <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>CellNumber&ndash;<strong>integer</strong> in the range <strong>[1, 1000]</strong> (<strong>required</strong>)</li>
<li>HasWindow &ndash; <strong>bool</strong><strong> (required</strong><strong>)</strong></li>
<li>DepartmentId - integer, foreign key</li>
<li>Department &ndash; the cell's department (<strong>required</strong>)</li>
<li>Prisoners - collection of type Prisoner</li>
</ul>
<h3>Mail</h3>
<ul>
<li>Id&ndash; <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>Description&ndash; <strong>text</strong> <strong>(<strong>required</strong>)</strong></li>
<li>Sender &ndash; text<strong>(<strong>required</strong>)</strong></li>
<li>Address &ndash; <strong>text</strong>, consisting <strong>only of letters, spaces and numbers</strong>, which ends with <strong>&ldquo; str.</strong><strong>&rdquo;</strong> (<strong>required</strong>) (<strong>Example</strong>: <strong>&ldquo;</strong>62 Muir Hill str.<strong>&ldquo;</strong>)</li>
<li>PrisonerId - integer, foreign key</li>
<li>Prisoner &ndash; the mail's Prisoner (<strong>required</strong>)</li>
</ul>
<h3>Department</h3>
<ul>
<li>Id &ndash; <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>Name &ndash; <strong>text</strong> with <strong>min length</strong> <strong>3 </strong>and <strong>max length 25</strong> (<strong>required</strong>)</li>
<li>Cells - collection of type Cell</li>
</ul>
<h3>OfficerPrisoner</h3>
<ul>
<li>PrisonerId&ndash; <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>Prisoner &ndash; the officer&rsquo;s <strong>prisoner</strong> (<strong>required</strong>)</li>
<li>OfficerId &ndash; integer, Primary Key</li>
<li>Officer &ndash; the prisoner&rsquo;s officer (<strong>required</strong>)</li>
</ul>
<h2>Problem 2. Data Import (30pts)</h2>
<p>For the functionality of the application, you need to create several methods that manipulate the database. The <strong>project skeleton</strong> already provides you with these methods, inside the Deserializer <strong>class</strong>. Use <strong>Data Transfer Objects</strong> as needed.</p>
<p>Use the provided <strong>JSON</strong> and <strong>XML</strong> files to populate the database with data. Import all the information from those files into the database.</p>
<p>You are <strong>not allowed</strong> to modify the provided JSON and XML files.</p>
<p><strong>If a record does not meet the requirements from the first section, print an error message which is mentioned bellow:</strong></p>
<h3>JSON Import (20 pts)</h3>
<h4>Import Departments and Cells</h4>
<p>Using the file ImportDepartmentsCells.json, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<h5>Constraints</h5>
<ul>
<li>If any validation errors occur (such as if a department <strong>name</strong> <strong>is too long/short </strong>or a <strong>cell</strong> <strong>number </strong>is <strong>out of range</strong>) proceed as described above</li>
<li>If a department is <strong>invalid</strong>, <strong>do not </strong>import its <strong>cells</strong>.</li>
</ul>
<table>
<tbody>
<tr>
<td>
<p><strong>Success message</strong></p>
</td>
<td width="212">
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td>
<p>Imported {department name} with {cells count} cells</p>
</td>
<td width="212">
<p>Invalid Data</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h5>Example</h5>
<table width="0">
<tbody>
<tr>
<td width="695">
<p><strong>ImportDepartmentsCells</strong><strong>.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "",</p>
<p>&nbsp;&nbsp;&nbsp; "Cells": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 101,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 102,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": false</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "CSS",</p>
<p>&nbsp;&nbsp;&nbsp; "Cells": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 0,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 202,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": false</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Invaliiiiiiiiiiiiiiiiiiiiiiiiiiiiidddddd",</p>
<p>&nbsp;&nbsp;&nbsp; "Cells": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 101,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 102,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": false</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 103,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 104,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": false</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 105,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Cybersecurity",</p>
<p>&nbsp;&nbsp;&nbsp; "Cells": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 101,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 102,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": false</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 103,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 104,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": false</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "CellNumber": 105,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "HasWindow": true</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&hellip;</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid Data</p>
<p>Invalid Data</p>
<p>Invalid Data</p>
<p>Imported Cybersecurity with 5 cells</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>Upon <strong>correct import logic</strong>, you should have imported <strong>6</strong> <strong>departments</strong> and <strong>34 cells</strong>.</p>
<h4>Import Prisoners and Mails</h4>
<p>Using the file ImportPrisonersMails.json, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<h5>Constraints</h5>
<ul>
<li>The release and incarceration dates will be in the format &ldquo;dd/MM/yyyy&rdquo;. Make sure you use InvariantCulture.</li>
<li>If any validation errors occur (such as invalid <strong>prisoner name</strong> or invalid <strong>nickname</strong>), <strong>ignore </strong>the entity and <strong>print an error message</strong>.</li>
<li>If a <strong>mail</strong> has incorrect address print <strong>error message</strong> and <strong>do not import</strong> the prisoner and his mails</li>
</ul>
<table>
<tbody>
<tr>
<td>
<p><strong>Success message</strong></p>
</td>
<td width="212">
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td>
<p>Imported {prisoner name} {prisoner age} years old</p>
</td>
<td width="212">
<p>Invalid Data</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h5>Example</h5>
<table width="0">
<tbody>
<tr>
<td width="695">
<p><strong>ImportPrisonersMails.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "FullName": "",</p>
<p>&nbsp;&nbsp;&nbsp; "Nickname": "The Wallaby",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 32,</p>
<p>&nbsp;&nbsp;&nbsp; "IncarcerationDate": "29/03/1957",</p>
<p>&nbsp;&nbsp;&nbsp; "ReleaseDate": "27/03/2006",</p>
<p>&nbsp;&nbsp;&nbsp; "Bail": null,</p>
<p>&nbsp;&nbsp;&nbsp; "CellId": 5,</p>
<p>&nbsp;&nbsp;&nbsp; "Mails": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Description": "Invalid FullName",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Sender": "Invalid Sender",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Address": "No Address"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Description": "Do not put this in your code",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Sender": "My Ansell",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Address": "ha-ha-ha"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "FullName": null,</p>
<p>&nbsp;&nbsp;&nbsp; "Nickname": "The Null",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 38,</p>
<p>&nbsp;&nbsp;&nbsp; "IncarcerationDate": "12/09/1967",</p>
<p>&nbsp;&nbsp;&nbsp; "ReleaseDate": "07/02/1989",</p>
<p>&nbsp;&nbsp;&nbsp; "Bail": 93934.2,</p>
<p>&nbsp;&nbsp;&nbsp; "CellId": 4,</p>
<p>&nbsp;&nbsp;&nbsp; "Mails": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Description": "Hello, my name is Mr. Null and I am invisible for computers",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Sender": "Mr. Null",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Address": "6 Riverside Trail str."</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "FullName": "Bobby Bock",</p>
<p>&nbsp;&nbsp;&nbsp; "Nickname": "Young and Beautiful",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 14,</p>
<p>&nbsp;&nbsp;&nbsp; "IncarcerationDate": "01/01/1967",</p>
<p>&nbsp;&nbsp;&nbsp; "ReleaseDate": "01/01/1989",</p>
<p>&nbsp;&nbsp;&nbsp; "Bail": 93934.2,</p>
<p>&nbsp;&nbsp;&nbsp; "CellId": 4,</p>
<p>&nbsp;&nbsp;&nbsp; "Mails": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Description": "I am not old enough to be in prison so get out of here :P",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Sender": "Small Bobby",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Address": "6 Riverside Trail str."</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "FullName": "Melanie Simonich",</p>
<p>&nbsp;&nbsp;&nbsp; "Nickname": "The Wallaby",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 32,</p>
<p>&nbsp;&nbsp;&nbsp; "IncarcerationDate": "29/03/1957",</p>
<p>&nbsp;&nbsp;&nbsp; "ReleaseDate": "27/03/2006",</p>
<p>&nbsp;&nbsp;&nbsp; "Bail": null,</p>
<p>&nbsp;&nbsp;&nbsp; "CellId": 5,</p>
<p>&nbsp;&nbsp;&nbsp; "Mails": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Description": "please add me to your LinkedIn network",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Sender": "Zonda Vasiljevic",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Address": "51677 Rieder Center str."</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Description": "Melanie i hope you found the best place for you!",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Sender": "Shell Lofthouse",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Address": "5877 Shoshone Way str."</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Description": "Turns out they wanted to implement things like fully responsive dynamic content, useful apps, etc &ndash; all things I told them they needed in the first place but which they opted not to include.",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Sender": "My Ansell",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Address": "71908 Waubesa Plaza str."</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&hellip;</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid Data</p>
<p>Invalid Data</p>
<p>Invalid Data</p>
<p>Imported Melanie Simonich 32 years old</p>
</td>
</tr>
</tbody>
</table>
<p>Upon <strong>correct import logic</strong>, you should have imported <strong>19</strong> <strong>prisoners</strong> and <strong>47 mails</strong>.</p>
<h3>XML Import (10 pts)</h3>
<h4>Import Officers and Prisoners</h4>
<p>Using the file <strong>Import<strong>OfficersPrisoners.xml</strong></strong>, import the data from the file into the database. Print information about each imported object in the format described below.</p>
<p>If any of the model requirements is violated continue with the next entity.</p>
<h5>Constraints</h5>
<ul>
<li>If there are any validation errors (such as <strong>negative</strong> salary or invalid <strong>position/weapon</strong>), proceed as described above.</li>
</ul>
<table>
<tbody>
<tr>
<td>
<p><strong>Success message</strong></p>
</td>
<td width="212">
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td>
<p>Imported {officer name} ({prisoners count} prisoners)</p>
</td>
<td width="212">
<p>Invalid Data</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h5>Example</h5>
<table width="0">
<tbody>
<tr>
<td width="695">
<p><strong>ImportOfficersPrisoners</strong><strong>.xml</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;?xml version='1.0' encoding='UTF-8'?&gt;</p>
<p>&lt;Officers&gt;</p>
<p>&nbsp; &lt;Officer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Minerva Kitchingman&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Money&gt;2582&lt;/Money&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Position&gt;Invalid&lt;/Position&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Weapon&gt;ChainRifle&lt;/Weapon&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;DepartmentId&gt;2&lt;/DepartmentId&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Prisoners&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Prisoner id="15" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Prisoners&gt;</p>
<p>&nbsp; &lt;/Officer&gt;</p>
<p>&nbsp; &lt;Officer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Minerva Holl&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Money&gt;2582.55&lt;/Money&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Position&gt;Overseer&lt;/Position&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Weapon&gt;ChainRifle&lt;/Weapon&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;DepartmentId&gt;2&lt;/DepartmentId&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Prisoners&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Prisoner id="15" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Prisoners&gt;</p>
<p>&nbsp; &lt;/Officer&gt;</p>
<p>&nbsp; &lt;Officer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Paddy Weiner&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Money&gt;2854.56&lt;/Money&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Position&gt;Guard&lt;/Position&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Weapon&gt;ChainRifle&lt;/Weapon&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;DepartmentId&gt;3&lt;/DepartmentId&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Prisoners&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Prisoner id="4" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Prisoner id="1" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Prisoners&gt;</p>
<p>&nbsp; &lt;/Officer&gt;</p>
<p>&nbsp; &lt;Officer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Minerva Kitchingman&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Money&gt;2582&lt;/Money&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Position&gt;Mishka&lt;/Position&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Weapon&gt;ChainRifle&lt;/Weapon&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;DepartmentId&gt;4&lt;/DepartmentId&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Prisoners&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Prisoner id="15" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Prisoners&gt;</p>
<p>&nbsp; &lt;/Officer&gt;</p>
<p>&hellip;</p>
<p>&nbsp; &lt;/Officers&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid Data</p>
<p>Imported Minerva Holl (1 prisoners)</p>
<p>Imported Paddy Weiner (2 prisoners)</p>
<p>Invalid Data</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>Upon <strong>correct import logic</strong>, you should have imported <strong>16</strong> <strong>officers </strong>and <strong>31 officers&rsquo; prisoners</strong>.</p>
<h2>Problem 3. Data Export (20 pts)</h2>
<p><strong>Use the provided methods in the </strong>Serializer class<strong>. </strong>Usage of <strong>Data Transfer Objects</strong> is <strong>optional</strong>.</p>
<h3>JSON Export (10 pts)</h3>
<h4>Export All Prisoners with Cells and Officers by Ids</h4>
<p>The given method in the project skeleton receives an <strong>array of prisoner ids</strong>. Export all <strong>prisoners</strong> that were processed which have <strong>these ids</strong>. For each prisoner, get their <strong>id</strong>, <strong>name</strong>, <strong>cell number they are placed in, </strong>their officers with each officer <strong>name</strong>, <strong>and the department name </strong>they are responsible for. At the end export the total officer salary with exactly <strong>two digits</strong> after the decimal place. Sort the officers and the prisoners by their <strong>name</strong> (<strong>ascending</strong>), then by the <strong>prisoner id </strong>(<strong>ascending</strong>).</p>
<h5>Example</h5>
<table width="0">
<tbody>
<tr>
<td width="695">
<p><strong>Serializer.</strong><strong>ExportPrisonersByCells (context, new[] { 1, 5, 7, 3 }</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 3,</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Binni Cornhill",</p>
<p>&nbsp;&nbsp;&nbsp; "CellNumber": 503,</p>
<p>&nbsp;&nbsp;&nbsp; "Officers": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OfficerName": "Hailee Kennon",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Department": "ArtificialIntelligence"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OfficerName": "Theo Carde",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Department": "Blockchain"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp; "TotalOfficerSalary": 7127.93</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 5,</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Ellette Lante",</p>
<p>&nbsp;&nbsp;&nbsp; "CellNumber": 403,</p>
<p>&nbsp;&nbsp;&nbsp; "Officers": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OfficerName": "Rica Muscott",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Department": "ArtificialIntelligence"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp; "TotalOfficerSalary": 2339.08</p>
<p>&nbsp; },</p>
<p>&hellip;</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>XML Export (10 pts)</h3>
<h4>Export Inbox for Prisoner</h4>
<p>Use the method provided in the project skeleton, which receives a string of <strong>comma-separated prisoner names</strong>. Export the <strong>prisoners</strong>: for each <strong>prisoner</strong>, export its <strong>id</strong>, <strong>name, incarcerationDate </strong>in the format &ldquo;yyyy-MM-dd&rdquo; and their <strong>encrypted mails</strong>. The encrypted algorithm you have to use is just to take each prisoner mail description and reverse it. <strong>Sort</strong> the prisoners by <strong>their name (ascending)</strong>, then by <strong>their id</strong> (<strong>ascending</strong>).</p>
<h5>Example</h5>
<table width="0">
<tbody>
<tr>
<td width="695">
<p><strong>Serializer.ExportPrisonersInbox(context, "Melanie Simonich,Diana Ebbs,Binni Cornhill")</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;Prisoners&gt;</p>
<p>&nbsp; &lt;Prisoner&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Id&gt;3&lt;/Id&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Binni Cornhill&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;IncarcerationDate&gt;1967-04-29&lt;/IncarcerationDate&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;EncryptedMessages&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Message&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Description&gt;!?sdnasuoht evif-ytnewt rof deksa uoy ro orez artxe na ereht sI&lt;/Description&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Message&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/EncryptedMessages&gt;</p>
<p>&nbsp; &lt;/Prisoner&gt;</p>
<p>&nbsp; &lt;Prisoner&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Id&gt;2&lt;/Id&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Diana Ebbs&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;IncarcerationDate&gt;1963-08-21&lt;/IncarcerationDate&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;EncryptedMessages&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Message&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Description&gt;.kcab draeh ton evah llits I dna&nbsp; ,skeew 2 tuoba ni si esaeler mubla ehT .dnuoranrut rof skeew 6-4 sekat ynapmoc DC eht dias yllanigiro eH .gnitiaw llits ma I&lt;/Description&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Message&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Message&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Description&gt;.emit ruoy ekat ot uoy ekil lliw ew dna krow ruoy ekil I .hsur on emit ruoy ekat ,enif si tahT&lt;/Description&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Message&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/EncryptedMessages&gt;</p>
<p>&nbsp; &lt;/Prisoner&gt;</p>
<p>&hellip;</p>
<p>&lt;/Prisoners&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4. Bonus Task (10 pts)</h2>
<p><strong>Implement the bonus method in the </strong>SoftJail.DataProcessor<strong> project for an additional amount of points</strong>.</p>
<h3>Release Prisoner</h3>
<p>Implement the method DataProcessor.Bonus. ReleasePrisoner, which receives the context and a <strong>prisoner id</strong>. Your task is to <strong>find the prisoner</strong> by that id and <strong>release him (</strong>set his ReleaseDate to the <strong>current date</strong> and remove his CellId<strong>)</strong>.</p>
<p>After the prisoner is released, return the message &ldquo;Prisoner {prisoner.FullName} released&rdquo;.</p>
<p>If the prisoner doesn't have a ReleaseDate, return &ldquo;Prisoner {prisoner.FullName} is sentenced to life&rdquo;</p>
<h4>Examples</h4>
<table width="0">
<tbody>
<tr>
<td width="695">
<p>DataProcessor.Bonus. ReleasePrisoner(context, 5)</p>
</td>
</tr>
<tr>
<td width="695">
<p>Prisoner Ellette Lante released</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="695">
<p>DataProcessor.Bonus. ReleasePrisoner(context, 13)</p>
</td>
</tr>
<tr>
<td width="695">
<p>Prisoner Fiona Mattecot is sentenced to life</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>