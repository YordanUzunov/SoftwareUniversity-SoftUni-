<h1>Exercises: Table Relations</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1436/databases-basics-mssql-september-2016">"Databases Basics - MSSQL" course @ Software University.</a></p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; One-To-One Relationship</h2>
<p>Create two tables as follows. Use appropriate data types.</p>
<table>
<tbody>
<tr>
<td colspan="4" width="319">
<p><strong>Persons</strong></p>
</td>
<td width="34">
<p><strong>&nbsp;</strong></p>
</td>
<td colspan="2" width="211">
<p><strong>Passports</strong></p>
</td>
</tr>
<tr>
<td width="80">
<p><strong>PersonID</strong></p>
</td>
<td width="84">
<p><strong>FirstName</strong></p>
</td>
<td width="73">
<p><strong>Salary</strong></p>
</td>
<td width="82">
<p><strong>PassportID</strong></p>
</td>
<td width="34">
<p><strong>&nbsp;</strong></p>
</td>
<td width="82">
<p><strong>PassportID</strong></p>
</td>
<td width="128">
<p><strong>PassportNumber</strong></p>
</td>
</tr>
<tr>
<td width="80">
<p>1&nbsp;</p>
</td>
<td width="84">
<p>Roberto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="73">
<p>43300.00</p>
</td>
<td width="82">
<p>102</p>
</td>
<td width="34">
<p>&nbsp;</p>
</td>
<td width="82">
<p>101</p>
</td>
<td width="128">
<p>N34FG21B</p>
</td>
</tr>
<tr>
<td width="80">
<p>2</p>
</td>
<td width="84">
<p>Tom</p>
</td>
<td width="73">
<p>56100.00</p>
</td>
<td width="82">
<p>103</p>
</td>
<td width="34">
<p>&nbsp;</p>
</td>
<td width="82">
<p>102</p>
</td>
<td width="128">
<p>K65LO4R7</p>
</td>
</tr>
<tr>
<td width="80">
<p>3</p>
</td>
<td width="84">
<p>Yana</p>
</td>
<td width="73">
<p>60200.00</p>
</td>
<td width="82">
<p>101</p>
</td>
<td width="34">
<p>&nbsp;</p>
</td>
<td width="82">
<p>103</p>
</td>
<td width="128">
<p>ZE657QP2</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Insert </strong>the data from the example above.</p>
<p>Alter the <strong>customers</strong> table and make <strong>PersonID </strong>a <strong>primary key</strong>. Create a <strong>foreign key</strong> between <strong>Persons</strong> and <strong>Passports </strong>by using <strong>PassportID</strong> column.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; One-To-Many Relationship</h2>
<p>Create two tables as follows. Use appropriate data types.</p>
<table>
<tbody>
<tr>
<td colspan="3" width="253">
<p><strong>Models</strong></p>
</td>
<td width="21">
<p><strong>&nbsp;</strong></p>
</td>
<td colspan="3" width="286">
<p><strong>Manufacturers</strong></p>
</td>
</tr>
<tr>
<td width="73">
<p><strong>ModelID</strong></p>
</td>
<td width="66">
<p><strong>Name</strong></p>
</td>
<td width="113">
<p><strong>ManufacturerID</strong></p>
</td>
<td width="21">
<p><strong>&nbsp;</strong></p>
</td>
<td width="119">
<p><strong>ManufacturerID</strong></p>
</td>
<td width="58">
<p><strong>Name</strong></p>
</td>
<td width="109">
<p><strong>EstablishedOn</strong></p>
</td>
</tr>
<tr>
<td width="73">
<p>101</p>
</td>
<td width="66">
<p>X1</p>
</td>
<td width="113">
<p>1</p>
</td>
<td width="21">
<p>&nbsp;</p>
</td>
<td width="119">
<p>1&nbsp;</p>
</td>
<td width="58">
<p>BMW</p>
</td>
<td width="109">
<p>07/03/1916</p>
</td>
</tr>
<tr>
<td width="73">
<p>102</p>
</td>
<td width="66">
<p>i6</p>
</td>
<td width="113">
<p>1</p>
</td>
<td width="21">
<p>&nbsp;</p>
</td>
<td width="119">
<p>2</p>
</td>
<td width="58">
<p>Tesla</p>
</td>
<td width="109">
<p>01/01/2003</p>
</td>
</tr>
<tr>
<td width="73">
<p>103</p>
</td>
<td width="66">
<p>Model S</p>
</td>
<td width="113">
<p>2</p>
</td>
<td width="21">
<p>&nbsp;</p>
</td>
<td width="119">
<p>3</p>
</td>
<td width="58">
<p>Lada</p>
</td>
<td width="109">
<p>01/05/1966</p>
</td>
</tr>
<tr>
<td width="73">
<p>104</p>
</td>
<td width="66">
<p>Model X</p>
</td>
<td width="113">
<p>2</p>
</td>
<td width="21">
<p>&nbsp;</p>
</td>
<td colspan="3" width="286">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="73">
<p>105</p>
</td>
<td width="66">
<p>Model 3</p>
</td>
<td width="113">
<p>2</p>
</td>
<td width="21">
<p>&nbsp;</p>
</td>
<td colspan="3" width="286">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="73">
<p>106</p>
</td>
<td width="66">
<p>Nova</p>
</td>
<td width="113">
<p>3</p>
</td>
<td width="21">
<p>&nbsp;</p>
</td>
<td colspan="3" width="286">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Insert</strong> the data from the example above. Add <strong>primary keys </strong>and <strong>foreign keys</strong>.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Many-To-Many Relationship</h2>
<p>Create three tables as follows. Use appropriate data types.</p>
<table>
<tbody>
<tr>
<td colspan="2" width="142">
<p><strong>Students</strong></p>
</td>
<td rowspan="8" width="27">
<p><strong>&nbsp;</strong></p>
</td>
<td colspan="2" width="156">
<p><strong>Exams</strong></p>
</td>
<td rowspan="8" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td colspan="2" width="151">
<p><strong>StudentsExams</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p><strong>StudentID</strong></p>
</td>
<td width="57">
<p><strong>Name</strong></p>
</td>
<td width="68">
<p><strong>ExamID</strong></p>
</td>
<td width="88">
<p><strong>Name</strong></p>
</td>
<td width="83">
<p><strong>StudentID</strong></p>
</td>
<td width="68">
<p><strong>ExamID</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>1&nbsp;</p>
</td>
<td width="57">
<p>Mila&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="68">
<p>101</p>
</td>
<td width="88">
<p>SpringMVC</p>
</td>
<td width="83">
<p>1</p>
</td>
<td width="68">
<p>101</p>
</td>
</tr>
<tr>
<td width="85">
<p>2</p>
</td>
<td width="57">
<p>Toni</p>
</td>
<td width="68">
<p>102</p>
</td>
<td width="88">
<p>Neo4j</p>
</td>
<td width="83">
<p>1</p>
</td>
<td width="68">
<p>102</p>
</td>
</tr>
<tr>
<td width="85">
<p>3</p>
</td>
<td width="57">
<p>Ron</p>
</td>
<td width="68">
<p>103</p>
</td>
<td width="88">
<p>Oracle 11g</p>
</td>
<td width="83">
<p>2</p>
</td>
<td width="68">
<p>101</p>
</td>
</tr>
<tr>
<td colspan="2" rowspan="3" width="142">
<p>&nbsp;</p>
</td>
<td colspan="2" rowspan="3" width="156">
<p>&nbsp;</p>
</td>
<td width="83">
<p>3</p>
</td>
<td width="68">
<p>103</p>
</td>
</tr>
<tr>
<td width="83">
<p>2</p>
</td>
<td width="68">
<p>102</p>
</td>
</tr>
<tr>
<td width="83">
<p>2</p>
</td>
<td width="68">
<p>103</p>
</td>
</tr>
</tbody>
</table>
<p>Insert the data from the example above.<br /> Add <strong>primary keys</strong> and <strong>foreign keys</strong>. Have in mind that table <strong>StudentsExams</strong> should have a <strong>composite primary key</strong>.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Self-Referencing</h2>
<p>Create a single table as follows. Use appropriate data types.</p>
<table>
<tbody>
<tr>
<td colspan="3" width="312">
<p><strong>Teachers</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p><strong>TeacherID</strong></p>
</td>
<td width="95">
<p><strong>Name</strong></p>
</td>
<td width="123">
<p><strong>ManagerID</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>101</p>
</td>
<td width="95">
<p>John</p>
</td>
<td width="123">
<p>NULL</p>
</td>
</tr>
<tr>
<td width="95">
<p>102</p>
</td>
<td width="95">
<p>Maya</p>
</td>
<td width="123">
<p>106</p>
</td>
</tr>
<tr>
<td width="95">
<p>103</p>
</td>
<td width="95">
<p>Silvia</p>
</td>
<td width="123">
<p>106</p>
</td>
</tr>
<tr>
<td width="95">
<p>104</p>
</td>
<td width="95">
<p>Ted</p>
</td>
<td width="123">
<p>105</p>
</td>
</tr>
<tr>
<td width="95">
<p>105</p>
</td>
<td width="95">
<p>Mark</p>
</td>
<td width="123">
<p>101</p>
</td>
</tr>
<tr>
<td width="95">
<p>106</p>
</td>
<td width="95">
<p>Greta</p>
</td>
<td width="123">
<p>101</p>
</td>
</tr>
</tbody>
</table>
<p>Insert the data from the example above. Add <strong>primary keys</strong> and <strong>foreign keys</strong>. The <strong>foreign key</strong> should be between <strong>ManagerId</strong> and <strong>TeacherId</strong>.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Online Store Database</h2>
<p>Create a new database and design the following structure:</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; University Database</h2>
<p>Create a new database and design the following structure:</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SoftUni Design</h2>
<p>Create an <strong>E/R Diagram</strong> of the SoftUni Database. There are some <strong>special relations</strong> you should <strong>check out</strong>: Employees are <strong>self-referenced</strong> (ManagerID) and Departments have <strong>One-to-One</strong> with the Employees (ManagerID) while the Employees have <strong>One-to-Many</strong> (DepartmentID). You might find it interesting how it looks on the diagram. J</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Geography Design</h2>
<p>Create an <strong>E/R Diagram</strong> of the Geography Database.</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Peaks in Rila</h2>
<p>Display <strong>all peaks</strong> for <strong>"Rila"</strong> mountain. Include:</p>
<ul>
<li><strong>MountainRange</strong></li>
<li><strong>PeakName</strong></li>
<li><strong>Elevation</strong></li>
</ul>
<p>Peaks should be <strong>sorted</strong> by <strong>elevation descending</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="120">
<p><strong>MountainRange</strong></p>
</td>
<td width="105">
<p><strong>PeakName</strong></p>
</td>
<td width="88">
<p><strong>Elevation</strong></p>
</td>
</tr>
<tr>
<td width="120">
<p>Rila</p>
</td>
<td width="105">
<p>Musala</p>
</td>
<td width="88">
<p>2925</p>
</td>
</tr>
<tr>
<td width="120">
<p>&hellip;</p>
</td>
<td width="105">
<p>&hellip;</p>
</td>
<td width="88">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>