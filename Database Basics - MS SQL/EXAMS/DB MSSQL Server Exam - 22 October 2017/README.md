<h1>Database Basics MS SQL Exam &ndash; 22 Oct 2017</h1>
<p>Exam problems for the <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">&ldquo;Database Basics&rdquo; course @ SoftUni</a>.</p>
<p>Submit your solutions in the SoftUni Judge system at <a href="https://judge.softuni.bg/Contests/819">https://judge.softuni.bg/Contests/819</a></p>
<h1>Report Service</h1>
<p><em>--Mrs. F.Y, the city&rsquo;s mayor, came up with the idea to create an online platform where all the citizens can report about different problems and a special organization will work to resolve all the incoming reports. This organization has a few departments each of which is responsible for a set of problem&rsquo;s categories in which users can submit a report. In each department there are employees who get assigned to a report. Of course</em><em>, this huge platform needs a reliable database to store and process the information and Mrs. Y has asked for the best specialist in this area. That&rsquo;s why you got chosen! Congratulations and good luck! </em></p>
<h1>Section 1. DDL (30 pts)</h1>
<p>You have been given the E/R Diagram of the Report Service:</p>
<p>Crеate a database called <strong>ReportService</strong>. You need to create <strong>6 tables</strong>:</p>
<ul>
<li><strong>Users</strong> &ndash; contains information about the people who submit reports</li>
<li><strong>Reports</strong> - contains information about the submitted problems</li>
<li><strong>Employees</strong> &ndash; contains information about the people employees who work on reports</li>
<li><strong>Departments</strong> &ndash; contains information about the departments</li>
<li><strong>Categories</strong> &ndash; contains information about categories inside the departments.</li>
<li><strong>Status </strong>- contains information about the possible statuses of a report</li>
</ul>
<p>&nbsp;</p>
<p><strong>Users</strong></p>
<table width="0">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="212">
<p><strong>Data Type</strong></p>
</td>
<td width="358">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="212">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="358">
<p>Unique table <strong>identificator</strong>, <strong>Identity</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Username</p>
</td>
<td width="212">
<p><strong>String</strong> up to 30 symbols, Unicode</p>
</td>
<td width="358">
<p><strong>NULL</strong> is <strong>not</strong> allowed, <strong>Unique</strong> values only</p>
</td>
</tr>
<tr>
<td width="125">
<p>Password</p>
</td>
<td width="212">
<p><strong>String</strong> up to 50 symbols, Unicode</p>
</td>
<td width="358">
<p><strong>NULL</strong> is <strong>not</strong> allowed</p>
</td>
</tr>
<tr>
<td width="125">
<p>Name</p>
</td>
<td width="212">
<p><strong>String</strong> up to <strong>50</strong> symbols, Unicode</p>
</td>
<td width="358">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Gender</p>
</td>
<td width="212">
<p><strong>Character</strong> with <strong>exactly</strong> <strong>1</strong> symbol</p>
</td>
<td width="358">
<p>Could be: '<strong><em>M</em></strong>' or '<strong><em>F</em>'</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>BirthDate</p>
</td>
<td width="212">
<p>DateTime</p>
</td>
<td width="358">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Age</p>
</td>
<td width="212">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="358">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Email</p>
</td>
<td width="212">
<p><strong>String</strong> up to <strong>50</strong> symbols, Unicode</p>
</td>
<td width="358">
<p><strong>NULL</strong> is <strong>not</strong> allowed</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Departments</strong></p>
<table width="0">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="264">
<p><strong>Data Type</strong></p>
</td>
<td width="307">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="264">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="307">
<p>Unique table <strong>identificator</strong>, <strong>Identity</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Name</p>
</td>
<td width="264">
<p><strong>String</strong> up to <strong>50</strong> symbols, Unicode</p>
</td>
<td width="307">
<p><strong>NULL</strong> is <strong>not</strong> allowed</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Employees</strong></p>
<table width="0">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="302">
<p><strong>Data Type</strong></p>
</td>
<td width="269">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="302">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="269">
<p>Unique table identificator, <strong>Identity</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>FirstName</p>
</td>
<td width="302">
<p><strong>String</strong> up to <strong>25</strong> symbols, Unicode</p>
</td>
<td width="269">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>LastName</p>
</td>
<td width="302">
<p><strong>String</strong> up to <strong>25</strong> symbols, Unicode</p>
</td>
<td width="269">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Gender</p>
</td>
<td width="302">
<p><strong>Character</strong> with <strong>exactly</strong> 1 symbol</p>
</td>
<td width="269">
<p>Could be: '<strong><em>M</em></strong>' or '<strong><em>F</em></strong>'</p>
</td>
</tr>
<tr>
<td width="125">
<p>BirthDate</p>
</td>
<td width="302">
<p>DateTime</p>
</td>
<td width="269">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Age</p>
</td>
<td width="302">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="269">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>DepartmentId</p>
</td>
<td width="302">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="269">
<p><strong>NULL</strong> is <strong>not</strong> allowed, Relationship with table Departments</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Categories</strong></p>
<table width="0">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="264">
<p><strong>Data Type</strong></p>
</td>
<td width="307">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="264">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="307">
<p>Unique table <strong>identificator</strong>, <strong>Identity</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Name</p>
</td>
<td width="264">
<p><strong>String</strong> up to <strong>50</strong> symbols</p>
</td>
<td width="307">
<p><strong>NULL</strong> is <strong>not</strong> allowed</p>
</td>
</tr>
<tr>
<td width="125">
<p>DepartmentId</p>
</td>
<td width="264">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="307">
<p>Relationship with table Departments</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Status</strong></p>
<table width="0">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="264">
<p><strong>Data Type</strong></p>
</td>
<td width="307">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="264">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="307">
<p>Unique table identificator, <strong>Identity</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Label</p>
</td>
<td width="264">
<p><strong>String</strong> up to <strong>30</strong> symbols</p>
</td>
<td width="307">
<p><strong>NULL</strong> is <strong>not</strong> allowed</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Reports</strong></p>
<table width="0">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="247">
<p><strong>Data Type</strong></p>
</td>
<td width="324">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="247">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="324">
<p>Unique table identificator, <strong>Identity</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>CategoryId</p>
</td>
<td width="247">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="324">
<p><strong>NULL</strong> is <strong>not</strong> allowed, Relationship with table Categories</p>
</td>
</tr>
<tr>
<td width="125">
<p>StatusId</p>
</td>
<td width="247">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="324">
<p><strong>NULL</strong> is <strong>not</strong> allowed, Relationship with table Status</p>
</td>
</tr>
<tr>
<td width="125">
<p>OpenDate</p>
</td>
<td width="247">
<p>DateTime</p>
</td>
<td width="324">
<p><strong>NULL</strong> is <strong>not</strong> allowed</p>
</td>
</tr>
<tr>
<td width="125">
<p>CloseDate</p>
</td>
<td width="247">
<p>DateTime</p>
</td>
<td width="324">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Description</p>
</td>
<td width="247">
<p><strong>String</strong> up to <strong>200</strong> symbols</p>
</td>
<td width="324">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>UserId</p>
</td>
<td width="247">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="324">
<p><strong>NULL</strong> is <strong>not</strong> allowed, Relationship with table Users</p>
</td>
</tr>
<tr>
<td width="125">
<p>EmployeeId</p>
</td>
<td width="247">
<p><strong>Integer</strong> from <strong>0</strong> to <strong>2,147,483,647</strong></p>
</td>
<td width="324">
<p>Relationship with table Employees</p>
</td>
</tr>
</tbody>
</table>
<h2>1.&nbsp;&nbsp; Database design</h2>
<p>Submit all of yours <strong>create</strong> <strong>statements</strong> to Judge (only creation of tables).</p>
<h1>Section 2. DML (10 pts)</h1>
<p><strong><u>Before you start you have to import &ldquo;DataSet</u></strong><strong><u>-ReportService.sql&rdquo;. If you have created the structure correctly the data should be successfully inserted.</u></strong></p>
<p>In this section, you have to do some data manipulations:</p>
<h2>2.&nbsp;&nbsp; Insert</h2>
<p>Let&rsquo;s <strong>insert</strong> some sample data into the database. Write a query to add the following records into the corresponding tables. All Id&rsquo;s should be auto-generated. Replace names that relate to other tables with the appropriate ID (look them up manually, there is no need to perform table joins).</p>
<p><strong>Emlpoyees</strong></p>
<table width="0">
<tbody>
<tr>
<td width="144">
<p><strong>FirstName</strong></p>
</td>
<td width="150">
<p><strong>LastName</strong></p>
</td>
<td width="72">
<p><strong>Gender</strong></p>
</td>
<td width="176">
<p><strong>Birthdate</strong></p>
</td>
<td width="148">
<p><strong>Department Id</strong></p>
</td>
</tr>
<tr>
<td width="144">
<p>Marlo</p>
</td>
<td width="150">
<p>O&rsquo;Malley</p>
</td>
<td width="72">
<p>M</p>
</td>
<td width="176">
<p>9/21/1958</p>
</td>
<td width="148">
<p>Infrastructure</p>
</td>
</tr>
<tr>
<td width="144">
<p>Niki</p>
</td>
<td width="150">
<p>Stanaghan</p>
</td>
<td width="72">
<p>F</p>
</td>
<td width="176">
<p>11/26/1969</p>
</td>
<td width="148">
<p>Emergency</p>
</td>
</tr>
<tr>
<td width="144">
<p>Ayrton</p>
</td>
<td width="150">
<p>Senna</p>
</td>
<td width="72">
<p>M</p>
</td>
<td width="176">
<p>03/21/1960&nbsp;</p>
</td>
<td width="148">
<p>Event Management</p>
</td>
</tr>
<tr>
<td width="144">
<p>Ronnie</p>
</td>
<td width="150">
<p>Peterson</p>
</td>
<td width="72">
<p>M</p>
</td>
<td width="176">
<p>02/14/1944</p>
</td>
<td width="148">
<p>Event Management</p>
</td>
</tr>
<tr>
<td width="144">
<p>Giovanna</p>
</td>
<td width="150">
<p>Amati</p>
</td>
<td width="72">
<p>F</p>
</td>
<td width="176">
<p>07/20/1959</p>
</td>
<td width="148">
<p>Roads Maintenance</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Reports</strong></p>
<table width="0">
<tbody>
<tr>
<td width="108">
<p><strong>CategoryId</strong></p>
</td>
<td width="83">
<p><strong>StatusId</strong></p>
</td>
<td width="85">
<p><strong>OpenDate</strong></p>
</td>
<td width="85">
<p><strong>CloseDate</strong></p>
</td>
<td width="187">
<p><strong>Description</strong></p>
</td>
<td width="54">
<p><strong>UserId</strong></p>
</td>
<td width="87">
<p><strong>EmployeeId</strong></p>
</td>
</tr>
<tr>
<td width="108">
<p>Snow Removal</p>
</td>
<td width="83">
<p>waiting</p>
</td>
<td width="85">
<p>04/13/2017</p>
</td>
<td width="85">
<p>&nbsp;</p>
</td>
<td width="187">
<p>Stuck Road on Str.133</p>
</td>
<td width="54">
<p>6</p>
</td>
<td width="87">
<p>2</p>
</td>
</tr>
<tr>
<td width="108">
<p>Sports Events</p>
</td>
<td width="83">
<p>completed</p>
</td>
<td width="85">
<p>09/05/2015</p>
</td>
<td width="85">
<p>12/06/2015</p>
</td>
<td width="187">
<p>Charity trail running</p>
</td>
<td width="54">
<p>3</p>
</td>
<td width="87">
<p>5</p>
</td>
</tr>
<tr>
<td width="108">
<p>Dangerous Building</p>
</td>
<td width="83">
<p>in progress</p>
</td>
<td width="85">
<p>09/07/2015</p>
</td>
<td width="85">
<p>&nbsp;</p>
</td>
<td width="187">
<p>Falling bricks on Str.58</p>
</td>
<td width="54">
<p>5</p>
</td>
<td width="87">
<p>2</p>
</td>
</tr>
<tr>
<td width="108">
<p>Streetlight</p>
</td>
<td width="83">
<p>completed</p>
</td>
<td width="85">
<p>07/03/2017</p>
</td>
<td width="85">
<p>07/06/2017</p>
</td>
<td width="187">
<p>Cut off streetlight on Str.11</p>
</td>
<td width="54">
<p>1</p>
</td>
<td width="87">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<h2>3.&nbsp;&nbsp; Update</h2>
<p>Switch <strong>all report&rsquo;s</strong> <strong>status</strong> to &ldquo;<strong>in progress</strong>&rdquo; where it is <strong>currently</strong> &ldquo;<strong>waiting</strong>&rdquo; for the &ldquo;<strong>Streetlight</strong>&rdquo; <strong>category</strong> (look up the category ID and status ID&rsquo;s manually, there is no need to use table joins).</p>
<h2>4.&nbsp;&nbsp; Delete</h2>
<p>Delete <strong>all reports</strong> who have a <strong>status</strong> &ldquo;<strong>blocked</strong>&rdquo;.</p>
<h1>Section 3. Querying (40 pts)</h1>
<p><strong><u>You need to start with a fresh dataset, so recreate your DB and import the sample data again (DataSet_ReportService.sql). </u></strong></p>
<p><strong><u>If not specified the ordering will be ascending.</u></strong></p>
<h2>5.&nbsp;&nbsp; Users by Age</h2>
<p>Select all <strong>Usernames</strong> with their <strong>age</strong> ordered by <strong>age</strong> (<strong>ascending</strong>) then by <strong>username</strong> (<strong>descending</strong>).</p>
<p>Required columns:</p>
<ul>
<li>Username</li>
<li>Age</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="174">
<p><strong>Username</strong></p>
</td>
<td width="161">
<p><strong>Age</strong></p>
</td>
</tr>
<tr>
<td width="174">
<p>5omarkwelleyc</p>
</td>
<td width="161">
<p>19</p>
</td>
</tr>
<tr>
<td width="174">
<p>bkaasg</p>
</td>
<td width="161">
<p>21</p>
</td>
</tr>
<tr>
<td width="174">
<p>dfinicj5</p>
</td>
<td width="161">
<p>24</p>
</td>
</tr>
<tr>
<td width="174">
<p>&hellip;</p>
</td>
<td width="161">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Unassigned Reports</h2>
<p>Find all <strong>reports</strong> that <strong>don&rsquo;t </strong>have an <strong>assigned employee</strong>. <strong>Order</strong> the results by <strong>open date</strong> in <strong>ascending</strong> order, then by <strong>description </strong>(<strong>ascending</strong>).</p>
<p>Required columns:</p>
<ul>
<li>Description</li>
<li>OpenDate</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="322">
<p><strong>Description</strong></p>
</td>
<td width="181">
<p><strong>OpenDate</strong></p>
</td>
</tr>
<tr>
<td width="322">
<p>Art exhibition on July 24</p>
</td>
<td width="181">
<p>2014-12-17 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="322">
<p>Stuck Road on Str.133</p>
</td>
<td width="181">
<p>2015-06-20 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="322">
<p>Burned facade on Str.560</p>
</td>
<td width="181">
<p>2015-08-26 00:00:00.000</p>
</td>
</tr>
<tr>
<td width="322">
<p>&hellip;</p>
</td>
<td width="181">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Employees &amp; Reports</h2>
<p>Select <strong>only employees</strong> who <strong>have</strong> an <strong>assigned</strong> <strong>report</strong> and show <strong>all reports</strong> of <strong>each </strong>found<strong> employee</strong>. Show the open date column in the format &ldquo;<strong>yyyy-MM-dd</strong>&rdquo;. Order them by <strong>employee id</strong> (ascending) <strong>then</strong> by <strong>open date </strong>(ascending) and then by <strong>report Id</strong> (again ascending).</p>
<p>Required columns:</p>
<ul>
<li>FirstName</li>
<li>LastName</li>
<li>Description</li>
<li>OpenDate</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="86">
<p><strong>FirstName</strong></p>
</td>
<td width="205">
<p><strong>LastName</strong></p>
</td>
<td width="245">
<p><strong>Description</strong></p>
</td>
<td width="101">
<p><strong>OpenDate</strong></p>
</td>
</tr>
<tr>
<td width="86">
<p>Marlo</p>
</td>
<td width="205">
<p>O'Malley</p>
</td>
<td width="245">
<p>Fallen streetlight columns on Str.14</p>
</td>
<td width="101">
<p>2017-09-12</p>
</td>
</tr>
<tr>
<td width="86">
<p>Gregory</p>
</td>
<td width="205">
<p>Stithe</p>
</td>
<td width="245">
<p>Stuck Road on Str.14</p>
</td>
<td width="101">
<p>2017-04-13</p>
</td>
</tr>
<tr>
<td width="86">
<p>Humphrey</p>
</td>
<td width="205">
<p>Tamblyn</p>
</td>
<td width="245">
<p>Burned facade on Str.793</p>
</td>
<td width="101">
<p>2016-07-20</p>
</td>
</tr>
<tr>
<td width="86">
<p>&hellip;</p>
</td>
<td width="205">
<p>&hellip;</p>
</td>
<td width="245">
<p>&hellip;</p>
</td>
<td width="101">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Most reported Category</h2>
<p>Select <strong>ALL categories</strong> and <strong>order</strong> them <strong>by</strong> the number of<strong> reports</strong> <strong>per category</strong> in <strong>descending</strong> order and then <strong>alphabetically</strong> by name.</p>
<p>Required columns:</p>
<ul>
<li>CategoryName</li>
<li>ReportsNumber</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="132">
<p><strong>CategoryName</strong></p>
</td>
<td width="114">
<p><strong>ReportsNumber</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Recycling</p>
</td>
<td width="114">
<p>8</p>
</td>
</tr>
<tr>
<td width="132">
<p>Snow Removal</p>
</td>
<td width="114">
<p>5</p>
</td>
</tr>
<tr>
<td width="132">
<p>Streetlight</p>
</td>
<td width="114">
<p>4</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
<td width="114">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Employees in Category</h2>
<p>Select <strong>ALL categories</strong> and the number of employees in each category and <strong>order</strong> them <strong>alphabetically</strong> by category name.</p>
<p>Required columns:</p>
<ul>
<li>CategoryName</li>
<li>Employees Number</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="132">
<p><strong>CategoryName</strong></p>
</td>
<td width="138">
<p><strong>Employees Number</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Animal in Danger</p>
</td>
<td width="138">
<p>3</p>
</td>
</tr>
<tr>
<td width="132">
<p>Art Events</p>
</td>
<td width="138">
<p>5</p>
</td>
</tr>
<tr>
<td width="132">
<p>Dangerous Building</p>
</td>
<td width="138">
<p>1</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Users per Employee</h2>
<p>Select <strong>all</strong> <strong>employees</strong> and show how many <strong>unique</strong> users each of them have served to.</p>
<p>Required columns:</p>
<ul>
<li>Employee&rsquo;s name - Full name consisting of FirstName and LastName and a space between them</li>
<li>User&rsquo;s number</li>
</ul>
<p>Order by Users Number <strong>descending</strong> and then by Name <strong>ascending</strong>.</p>
<p>&nbsp;</p>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="144">
<p><strong>Name</strong></p>
</td>
<td width="102">
<p><strong>Users Number</strong></p>
</td>
</tr>
<tr>
<td width="144">
<p>Bron Ledur</p>
</td>
<td width="102">
<p>3</p>
</td>
</tr>
<tr>
<td width="144">
<p>Adelind Benns</p>
</td>
<td width="102">
<p>2</p>
</td>
</tr>
<tr>
<td width="144">
<p>Dick Wentworth</p>
</td>
<td width="102">
<p>2</p>
</td>
</tr>
<tr>
<td width="144">
<p>&hellip;</p>
</td>
<td width="102">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Emergency Patrol</h2>
<p>Select <strong>all</strong> <strong>reports</strong> which <strong>satisfy</strong> <strong>all</strong> the following criteria:</p>
<ul>
<li>are <strong>not</strong> <strong>closed</strong> yet (they don&rsquo;t have a CloseDate)</li>
<li>the <strong>description</strong> is longer than <strong>20 symbols</strong> and the word &ldquo;<strong>str&rdquo; is mentioned anywhere</strong></li>
<li>are <strong>assigned</strong> to one of the <strong>following</strong> <strong>departments</strong>: &ldquo;Infrastructure&rdquo;, &ldquo;Emergency&rdquo;, &ldquo;Roads Maintenance&rdquo;</li>
</ul>
<p><strong>Order</strong> the results by<strong> OpenDate </strong>(ascending), <strong>then</strong> by <strong>Reporter&rsquo;s Email </strong>(ascending) and then by <strong>Report Id</strong> (ascending).</p>
<p>Required columns:</p>
<ul>
<li>OpenDate</li>
<li>Description</li>
<li>Reporter Email</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="186">
<p><strong>OpenDate</strong></p>
</td>
<td width="276">
<p><strong>Description</strong></p>
</td>
<td width="210">
<p><strong>Reporter Email</strong></p>
</td>
</tr>
<tr>
<td width="186">
<p>2015-06-20 00:00:00.000</p>
</td>
<td width="276">
<p>Stuck Road on Str.133</p>
</td>
<td width="210">
<p>bkaasg@g.co</p>
</td>
</tr>
<tr>
<td width="186">
<p>2015-08-26 00:00:00.000</p>
</td>
<td width="276">
<p>Burned facade on Str.560</p>
</td>
<td width="210">
<p>dpennid@arizona.edu</p>
</td>
</tr>
<tr>
<td width="186">
<p>2015-11-17 00:00:00.000</p>
</td>
<td width="276">
<p>Gigantic crater ?n Str.19</p>
</td>
<td width="210">
<p>ealpine0@squarespace.com</p>
</td>
</tr>
<tr>
<td width="186">
<p>&hellip;</p>
</td>
<td width="276">
<p>&hellip;</p>
</td>
<td width="210">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Birthday Report</h2>
<p>Select <strong>all categories</strong> in which users have <strong>submitted</strong> a <strong>report</strong> on <strong>their birthday</strong>. Order them by name <strong>alphabetically.</strong></p>
<p>Required columns:</p>
<ul>
<li>Category Name</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="139">
<p><strong>Category Name</strong></p>
</td>
</tr>
<tr>
<td width="139">
<p>Dangerous Trees</p>
</td>
</tr>
<tr>
<td width="139">
<p>Homeless Elders</p>
</td>
</tr>
<tr>
<td width="139">
<p>Snow Removal</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Numbers Coincidence</h2>
<p>Select all<strong> unique usernames</strong> which:</p>
<ul>
<li><strong>starts</strong> with a <strong>digit</strong> and have reported in a <strong>category</strong> with <strong>id equal</strong> to the <strong>digit</strong></li>
</ul>
<p><strong><u>OR</u></strong></p>
<ul>
<li><strong>ends</strong> with a <strong>digit</strong> and have reported in a <strong>category</strong> with <strong>id equal</strong> to the <strong>digit</strong></li>
</ul>
<p>Required columns:</p>
<ul>
<li>Username</li>
</ul>
<p>Order them <strong>alphabetically</strong>.</p>
<p>&nbsp;</p>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="226">
<p><strong>Username</strong></p>
</td>
</tr>
<tr>
<td width="226">
<p>1qiskowf</p>
</td>
</tr>
<tr>
<td width="226">
<p>5omarkwelleyc</p>
</td>
</tr>
<tr>
<td width="226">
<p>fdenrico3</p>
</td>
</tr>
<tr>
<td width="226">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Open/Closed Statistics</h2>
<p>Select <strong>all</strong> <strong>employees </strong>who have<strong> at</strong> <strong>least</strong> <strong>one</strong> assigned closed<strong> or </strong>open report <strong>through</strong> year <strong>2016 </strong>and <strong>their total sum</strong>. Open reports don&rsquo;t have a <strong>CloseDate</strong>. Reports that have been <strong>opened before</strong> 2016 but were <strong>closed in</strong> 2016 are counted as <strong>closed only</strong>! Order by <strong>Name</strong> (ascending), and then by employee Id</p>
<p>Required columns:</p>
<ul>
<li>Name - name - Full name consisting of FirstName and LastName and a space between them</li>
<li>Closed /Open reports number</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="226">
<p><strong>Name</strong></p>
</td>
<td width="246">
<p><strong>Closed Open Reports</strong></p>
</td>
</tr>
<tr>
<td width="226">
<p>Dick Wentworth</p>
</td>
<td width="246">
<p>1/1</p>
</td>
</tr>
<tr>
<td width="226">
<p>Eldon Gaze</p>
</td>
<td width="246">
<p>0/1</p>
</td>
</tr>
<tr>
<td width="226">
<p>Hewet Juschke</p>
</td>
<td width="246">
<p>0/1</p>
</td>
</tr>
<tr>
<td width="226">
<p>&hellip;</p>
</td>
<td width="246">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Average Closing Time</h2>
<p>Select <strong>all</strong> <strong>departments</strong> that have been reported in and <strong>the average time </strong>for<strong> closing </strong>a <strong>report </strong>for each department rounded to the closest integer part<strong>.</strong> If there is <strong>no information</strong> (e.g. none closed reports) about any <strong>department</strong> fill in the Average Duration column &ldquo;<strong>no info</strong>&rdquo;.</p>
<p>Required columns:</p>
<ul>
<li>Department Name</li>
<li>Average Duration - in days</li>
</ul>
<p>Order them by department name.</p>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="226">
<p><strong>Department Name</strong></p>
</td>
<td width="246">
<p><strong>Average Duration</strong></p>
</td>
</tr>
<tr>
<td width="226">
<p>Aged Care</p>
</td>
<td width="246">
<p>no info</p>
</td>
</tr>
<tr>
<td width="226">
<p>Animals Care</p>
</td>
<td width="246">
<p>17</p>
</td>
</tr>
<tr>
<td width="226">
<p>Emergency</p>
</td>
<td width="246">
<p>no info</p>
</td>
</tr>
<tr>
<td width="226">
<p>&hellip;</p>
</td>
<td width="246">
<p>&hellip;.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Favorite Categories</h2>
<p>Select <strong>all</strong> <strong>departments</strong> with <strong>their categories</strong> where <strong>users</strong> have <strong>submitted</strong> a <strong>report</strong>. Show the <strong>distribution</strong> of reports <strong>among</strong> the <strong>categories</strong> of each department in <strong>percentages </strong>without decimal part.</p>
<p>Required columns:</p>
<ul>
<li>Department Name</li>
<li>Category Name</li>
<li>Percentage</li>
</ul>
<p>Order them by <strong>department</strong> name, then by <strong>category</strong> name and <strong>then</strong> by <strong>percentage</strong> (all in <strong>ascending</strong> order).</p>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="221">
<p><strong>Department Name</strong></p>
</td>
<td width="238">
<p><strong>Category Name</strong></p>
</td>
<td width="236">
<p><strong>Percentage</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>Aged Care</p>
</td>
<td width="238">
<p>Homeless Elders</p>
</td>
<td width="236">
<p>100</p>
</td>
</tr>
<tr>
<td width="221">
<p>Animals Care</p>
</td>
<td width="238">
<p>Animal in Danger</p>
</td>
<td width="236">
<p>75</p>
</td>
</tr>
<tr>
<td width="221">
<p>Animals Care</p>
</td>
<td width="238">
<p>Street animal</p>
</td>
<td width="236">
<p>25</p>
</td>
</tr>
<tr>
<td width="221">
<p>&hellip;</p>
</td>
<td width="238">
<p>&hellip;</p>
</td>
<td width="236">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h1>Section 4. Programmability (14 pts)</h1>
<h2>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee&rsquo;s Load</h2>
<p>Create a <strong>user defined function</strong> with the name <strong>udf_GetReportsCount(@employeeId, @statusId)</strong> that receives an <strong>employee&rsquo;s Id</strong> and a <strong>status Id </strong>returns the sum of the reports he is assigned to with the given status.</p>
<p>Parameters:</p>
<ul>
<li>Employee&rsquo;s Id</li>
<li>Status Id</li>
</ul>
<h3>Example usage:</h3>
<table width="0">
<tbody>
<tr>
<td colspan="5" width="656">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td colspan="5" width="656">
<p><strong>SELECT</strong> <strong>Id,</strong> <strong>FirstName, Lastname, dbo.udf_GetReportsCount(Id, 2) AS ReportsCount</strong></p>
<p><strong>FROM</strong> <strong>Employees</strong></p>
<p><strong>ORDER</strong> <strong>BY</strong> <strong>Id</strong></p>
</td>
</tr>
<tr>
<td width="224">
<p><strong>Id</strong></p>
</td>
<td width="107">
<p><strong>FirstName</strong></p>
</td>
<td width="119">
<p><strong>LastName</strong></p>
</td>
<td width="206">
<p><strong>ReportsCount</strong></p>
</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="224">
<p>1</p>
</td>
<td width="107">
<p>Marlo</p>
</td>
<td width="119">
<p>O'Malley</p>
</td>
<td width="206">
<p>0</p>
</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="224">
<p>2</p>
</td>
<td width="107">
<p>Nolan</p>
</td>
<td width="119">
<p>Meneyer</p>
</td>
<td width="206">
<p>0</p>
</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="224">
<p>3</p>
</td>
<td width="107">
<p>Tarah</p>
</td>
<td width="119">
<p>McWaters</p>
</td>
<td width="206">
<p>0</p>
</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="224">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
<td width="119">
<p>&hellip;</p>
</td>
<td width="206">
<p>&hellip;</p>
</td>
<td width="1">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Assign Employee</h2>
<p>Create a <strong>user defined stored procedure </strong>with the name <strong>usp_AssignEmployeeToReport(@employeeId, @reportId)</strong> that receives an <strong>em</strong><strong>ployee&rsquo;s Id</strong> and a <strong>report&rsquo;s Id </strong>and assigns the employee to the report <strong>only if</strong> the department of the employee and the department of the report&rsquo;s category are the same. If the assigning is not successful <strong>rollback</strong> any changes and throw an <strong>exception</strong> with message: &ldquo;Employee doesn't belong to the appropriate department!&rdquo;.</p>
<p>Parameters:</p>
<ul>
<li>Employee&rsquo;s Id</li>
<li>Report&rsquo;s Id</li>
</ul>
<h3>Example usage:</h3>
<table width="0">
<tbody>
<tr>
<td width="678">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p><strong>EXEC</strong><strong> usp_AssignEmployeeToReport 17, 2;</strong></p>
<p><strong>SELECT</strong><strong> EmployeeId FROM Reports WHERE id = 2</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p><strong>Response</strong></p>
</td>
</tr>
<tr>
<td width="678">
<p>17</p>
</td>
</tr>
</tbody>
</table>
<h2>19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Close Reports</h2>
<p>Create a <strong>trigger</strong> which changes the StatusId to &ldquo;<strong>completed</strong>&rdquo; of each report after a <strong>CloseDate</strong> is <strong>entered </strong>for the report.</p>
<h3>Example usage:</h3>
<table width="0">
<tbody>
<tr>
<td width="696">
<p><strong>Query</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>UPDATE</strong><strong> Reports</strong></p>
<p><strong>SET</strong><strong> CloseDate = GETDATE()</strong></p>
<p><strong>WHERE</strong><strong> EmployeeId = 5;</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Response</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>(1 row affected)</p>
<p>&nbsp;</p>
<p>(1 row affected)</p>
</td>
</tr>
</tbody>
</table>
<h1>Section 5. Bonus (10 pts)</h1>
<h2>20.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Categories Revision</h2>
<p>Select <strong>all categories</strong> which have <strong>reports</strong> with <strong>status</strong> &ldquo;<strong>waiting</strong>&rdquo; or &ldquo;<strong>in</strong> <strong>progress</strong>&rdquo; and show their <strong>total number</strong> in the column &ldquo;<strong>Reports Number</strong>&rdquo;. In the <strong>third</strong> <strong>column</strong> fill the <strong>main</strong> status <strong>type</strong> of&nbsp; reports for the category (e.g. <strong>2</strong> reports with status &ldquo;<strong>waiting</strong>&rdquo; and <strong>3</strong> reports with status &ldquo;<strong>in progress</strong>&rdquo; <strong>result</strong> <strong>in</strong> value &ldquo;<strong>in progress</strong>&rdquo;). If they are equal just fill in &ldquo;<strong>equal</strong>&rdquo;. Order by category <strong>Name</strong>, then by <strong>Reports Number</strong> and then by <strong>Main Status.</strong></p>
<p>Required columns:</p>
<ul>
<li>Category Name</li>
<li>Reports Number</li>
<li>Main Status</li>
</ul>
<h3>Example:</h3>
<table width="0">
<tbody>
<tr>
<td width="141">
<p><strong>Category Name</strong></p>
</td>
<td width="158">
<p><strong>Reports Number</strong></p>
</td>
<td width="197">
<p><strong>Main Status</strong></p>
</td>
</tr>
<tr>
<td width="141">
<p>Animal in Danger</p>
</td>
<td width="158">
<p>1</p>
</td>
<td width="197">
<p>in progress</p>
</td>
</tr>
<tr>
<td width="141">
<p>Art Events</p>
</td>
<td width="158">
<p>2</p>
</td>
<td width="197">
<p>equal</p>
</td>
</tr>
<tr>
<td width="141">
<p>Dangerous Building</p>
</td>
<td width="158">
<p>1</p>
</td>
<td width="197">
<p>waiting</p>
</td>
</tr>
<tr>
<td width="141">
<p>&hellip;</p>
</td>
<td width="158">
<p>&hellip;</p>
</td>
<td width="197">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>