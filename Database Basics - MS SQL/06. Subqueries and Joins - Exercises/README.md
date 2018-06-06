<h1>Exercises: Joins, Subqueries, CTE and Indices</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">"Databases Basics - MSSQL" course @ Software University.</a> For problems from 1 to 11 (inclusively) use "<strong>SoftUni</strong>" database and for the other problems &ndash; "<strong>Geography</strong>".</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee Address</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeId</strong></li>
<li><strong>JobTitle</strong></li>
<li><strong>AddressId</strong></li>
<li><strong>AddressText</strong></li>
</ul>
<p>Return the <strong>first 5</strong> rows <strong>sorted</strong> by <strong>AddressId</strong> in <strong>ascending</strong> order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="94">
<p><strong>EmployeeId</strong></p>
</td>
<td width="186">
<p><strong>JobTitle</strong></p>
</td>
<td width="76">
<p><strong>AddressId</strong></p>
</td>
<td width="132">
<p><strong>AddressText</strong></p>
</td>
</tr>
<tr>
<td width="94">
<p>142</p>
</td>
<td width="186">
<p>Production Technician</p>
</td>
<td width="76">
<p>1</p>
</td>
<td width="132">
<p>108 Lakeside Court</p>
</td>
</tr>
<tr>
<td width="94">
<p>30</p>
</td>
<td width="186">
<p>Human Resources Manager</p>
</td>
<td width="76">
<p>2</p>
</td>
<td width="132">
<p>1341 Prospect St</p>
</td>
</tr>
<tr>
<td width="94">
<p>&hellip;</p>
</td>
<td width="186">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Addresses with Towns</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>FirstName</strong></li>
<li><strong>LastName</strong></li>
<li><strong>Town</strong></li>
<li><strong>AddressText</strong></li>
</ul>
<p><strong>Sorted</strong> by <strong>FirstName</strong> in <strong>ascending</strong> order then by <strong>LastName</strong>. Select <strong>first 50</strong> employees.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>FirstName</strong></p>
</td>
<td width="82">
<p><strong>LastName</strong></p>
</td>
<td width="103">
<p><strong>Town</strong></p>
</td>
<td width="134">
<p><strong>AddressText</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>A.Scott</p>
</td>
<td width="82">
<p>Wright</p>
</td>
<td width="103">
<p>Newport Hills</p>
</td>
<td width="134">
<p>1400 Gate Drive</p>
</td>
</tr>
<tr>
<td width="84">
<p>Alan</p>
</td>
<td width="82">
<p>Brewer</p>
</td>
<td width="103">
<p>Kenmore</p>
</td>
<td width="134">
<p>8192 Seagull Court</p>
</td>
</tr>
<tr>
<td width="84">
<p>&hellip;</p>
</td>
<td width="82">
<p>&hellip;</p>
</td>
<td width="103">
<p>&hellip;</p>
</td>
<td width="134">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sales Employee</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeID</strong></li>
<li><strong>FirstName</strong></li>
<li><strong>LastName</strong></li>
<li><strong>DepartmentName</strong></li>
</ul>
<p><strong>Sorted</strong> by <strong>EmployeeID</strong> in <strong>ascending</strong> order. Select only <strong>employees</strong> from &ldquo;<strong>Sales</strong>&rdquo; department.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="82">
<p><strong>FirstName</strong></p>
</td>
<td width="103">
<p><strong>LastName</strong></p>
</td>
<td width="132">
<p><strong>DepartmentName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>268</p>
</td>
<td width="82">
<p>Stephen</p>
</td>
<td width="103">
<p>Jiang</p>
</td>
<td width="132">
<p>Sales</p>
</td>
</tr>
<tr>
<td width="95">
<p>273</p>
</td>
<td width="82">
<p>Brian</p>
</td>
<td width="103">
<p>Welcker</p>
</td>
<td width="132">
<p>Sales</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="82">
<p>&hellip;</p>
</td>
<td width="103">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee Departments</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeID</strong></li>
<li><strong>FirstName</strong></li>
<li><strong>Salary</strong></li>
<li><strong>DepartmentName</strong></li>
</ul>
<p>Filter only <strong>employees</strong> with <strong>salary higher than 15000</strong>. Return the <strong>first 5</strong> rows <strong>sorted</strong> by <strong>DepartmentID</strong> in <strong>ascending</strong> order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="95">
<p><strong>Salary</strong></p>
</td>
<td width="151">
<p><strong>DepartmentName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>3&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="95">
<p>Roberto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="95">
<p>43300.00</p>
</td>
<td width="151">
<p>Engineering</p>
</td>
</tr>
<tr>
<td width="95">
<p>9</p>
</td>
<td width="95">
<p>Gail</p>
</td>
<td width="95">
<p>32700.00</p>
</td>
<td width="151">
<p>Engineering</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="151">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees Without Project</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeID</strong></li>
<li><strong>FirstName</strong></li>
</ul>
<p>Filter only <strong>employees</strong> <strong>without</strong> a <strong>project</strong>. Return the<strong> first 3</strong> rows <strong>sorted</strong> by <strong>EmployeeID</strong> in <strong>ascending</strong> order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>2</p>
</td>
<td width="95">
<p>Kevin</p>
</td>
</tr>
<tr>
<td width="95">
<p>6</p>
</td>
<td width="95">
<p>David</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees Hired After</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>FirstName</strong></li>
<li><strong>LastName</strong></li>
<li><strong>HireDate</strong></li>
<li><strong>DeptName</strong></li>
</ul>
<p>Filter only <strong>employees</strong> <strong>hired after 1.1.1999</strong> and are from either <strong>"Sales"</strong> or <strong>"Finance"</strong> departments, s<strong>orted</strong> by <strong>HireDate</strong> (<strong>ascending</strong>).</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>FirstName</strong></p>
</td>
<td width="82">
<p><strong>LastName</strong></p>
</td>
<td width="146">
<p><strong>HireDate</strong></p>
</td>
<td width="92">
<p><strong>DeptName</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>Debora&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
<td width="82">
<p>Poe</p>
</td>
<td width="146">
<p>2001-01-19 00:00:00</p>
</td>
<td width="92">
<p>Finance</p>
</td>
</tr>
<tr>
<td width="101">
<p>Wendy</p>
</td>
<td width="82">
<p>Kahn</p>
</td>
<td width="146">
<p>2001-01-26 00:00:00</p>
</td>
<td width="92">
<p>Finance</p>
</td>
</tr>
<tr>
<td width="101">
<p>&hellip;</p>
</td>
<td width="82">
<p>&hellip;</p>
</td>
<td width="146">
<p>&hellip;</p>
</td>
<td width="92">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employees with Project</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeID</strong></li>
<li><strong>FirstName</strong></li>
<li><strong>ProjectName</strong></li>
</ul>
<p>Filter only <strong>employees</strong> <strong>with</strong> a <strong>project</strong> which has <strong>started after 13.08.2002</strong> and it is still <strong>ongoing</strong> (no end date). Return the <strong>first 5</strong> rows <strong>sorted</strong> by <strong>EmployeeID</strong> in <strong>ascending</strong> order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="124">
<p><strong>ProjectName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>1</p>
</td>
<td width="95">
<p>Guy</p>
</td>
<td width="124">
<p>Racing Socks</p>
</td>
</tr>
<tr>
<td width="95">
<p>1</p>
</td>
<td width="95">
<p>Guy</p>
</td>
<td width="124">
<p>Road Bottle Cage</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="124">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee 24</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeID</strong></li>
<li><strong>FirstName</strong></li>
<li><strong>ProjectName</strong></li>
</ul>
<p>Filter all the <strong>projects</strong> of <strong>employee</strong> with <strong>Id 24</strong>. If the project has <strong>started during or</strong> <strong>after</strong> <strong>2005</strong> the <strong>returned</strong> value should be <strong>NULL</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="95">
<p><strong>ProjectName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>24</p>
</td>
<td width="95">
<p>David</p>
</td>
<td width="95">
<p>NULL</p>
</td>
</tr>
<tr>
<td width="95">
<p>24</p>
</td>
<td width="95">
<p>David</p>
</td>
<td width="95">
<p>Road-650</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee Manager</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeID</strong></li>
<li><strong>FirstName</strong></li>
<li><strong>ManagerID</strong></li>
<li><strong>ManagerName</strong></li>
</ul>
<p>Filter all <strong>employees</strong> with a <strong>manager</strong> who has <strong>ID</strong> equals to <strong>3 or 7</strong>. Return all the rows, <strong>sorted</strong> by <strong>EmployeeID</strong> in <strong>ascending</strong> order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="95">
<p><strong>FirstName</strong></p>
</td>
<td width="95">
<p><strong>ManagerID</strong></p>
</td>
<td width="113">
<p><strong>ManagerName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>4</p>
</td>
<td width="95">
<p>Rob</p>
</td>
<td width="95">
<p>3</p>
</td>
<td width="113">
<p>Roberto</p>
</td>
</tr>
<tr>
<td width="95">
<p>9</p>
</td>
<td width="95">
<p>Gail</p>
</td>
<td width="95">
<p>3</p>
</td>
<td width="113">
<p>Roberto</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10.&nbsp;&nbsp; Employee Summary</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>EmployeeID</strong></li>
<li><strong>EmployeeName</strong></li>
<li><strong>ManagerName</strong></li>
<li><strong>DepartmentName</strong></li>
</ul>
<p>Show <strong>first 50 employees</strong> with their <strong>managers</strong> and the <strong>departments</strong> they are in (show the departments of the employees). <strong>Order</strong> by <strong>EmployeeID</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="95">
<p><strong>EmployeeID</strong></p>
</td>
<td width="142">
<p><strong>EmployeeName</strong></p>
</td>
<td width="113">
<p><strong>ManagerName</strong></p>
</td>
<td width="132">
<p><strong>DepartmentName</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>1</p>
</td>
<td width="142">
<p>Guy Gilbert</p>
</td>
<td width="113">
<p>Jo Brown</p>
</td>
<td width="132">
<p>Production</p>
</td>
</tr>
<tr>
<td width="95">
<p>2</p>
</td>
<td width="142">
<p>Kevin Brown</p>
</td>
<td width="113">
<p>David Bradley</p>
</td>
<td width="132">
<p>Marketing</p>
</td>
</tr>
<tr>
<td width="95">
<p>3</p>
</td>
<td width="142">
<p>Roberto Tamburello</p>
</td>
<td width="113">
<p>Terri Duffy</p>
</td>
<td width="132">
<p>Engineering</p>
</td>
</tr>
<tr>
<td width="95">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 11.&nbsp;&nbsp; Min Average Salary</h2>
<p>Write a query that <strong>returns</strong> the value of the <strong>lowest</strong> <strong>average</strong> <strong>salary</strong> of all <strong>departments</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="133">
<p><strong>MinAverageSalary</strong></p>
</td>
</tr>
<tr>
<td width="133">
<p>10866.6666</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12.&nbsp;&nbsp; Highest Peaks in Bulgaria</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>CountryCode</strong></li>
<li><strong>MountainRange</strong></li>
<li><strong>PeakName</strong></li>
<li><strong>Elevation</strong></li>
</ul>
<p>Filter all <strong>peaks</strong> in <strong>Bulgaria</strong> with <strong>elevation</strong> <strong>over</strong> <strong>2835</strong>. <strong>Return</strong> all the rows <strong>sorted</strong> by <strong>elevation</strong> in <strong>descending</strong> order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>CountryCode</strong></p>
</td>
<td width="123">
<p><strong>MountainRange</strong></p>
</td>
<td width="95">
<p><strong>PeakName</strong></p>
</td>
<td width="76">
<p><strong>Elevation</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>BG</p>
</td>
<td width="123">
<p>Rila</p>
</td>
<td width="95">
<p>Musala</p>
</td>
<td width="76">
<p>2925</p>
</td>
</tr>
<tr>
<td width="101">
<p>BG</p>
</td>
<td width="123">
<p>Pirin</p>
</td>
<td width="95">
<p>Vihren</p>
</td>
<td width="76">
<p>2914</p>
</td>
</tr>
<tr>
<td width="101">
<p>&hellip;</p>
</td>
<td width="123">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 13.&nbsp;&nbsp; Count Mountain Ranges</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>CountryCode</strong></li>
<li><strong>MountainRanges</strong></li>
</ul>
<p>Filter the <strong>count</strong> of the <strong>mountain</strong> <strong>ranges</strong> in the <strong>United</strong> <strong>States</strong>, <strong>Russia</strong> and <strong>Bulgaria</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>CountryCode</strong></p>
</td>
<td width="126">
<p><strong>MountainRanges</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>BG</p>
</td>
<td width="126">
<p>6</p>
</td>
</tr>
<tr>
<td width="101">
<p>RU</p>
</td>
<td width="126">
<p>1</p>
</td>
</tr>
<tr>
<td width="101">
<p>&hellip;</p>
</td>
<td width="126">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 14.&nbsp;&nbsp; Countries with Rivers</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>CountryName</strong></li>
<li><strong>RiverName</strong></li>
</ul>
<p>Find the <strong>first</strong> <strong>5</strong> <strong>countries</strong> with or without <strong>rivers</strong> in <strong>Africa</strong>. <strong>Sort</strong> them by <strong>CountryName</strong> in <strong>ascending</strong> order.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="107">
<p><strong>CountryName</strong></p>
</td>
<td width="89">
<p><strong>RiverName</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>Algeria</p>
</td>
<td width="89">
<p>Niger</p>
</td>
</tr>
<tr>
<td width="107">
<p>Angola</p>
</td>
<td width="89">
<p>Congo</p>
</td>
</tr>
<tr>
<td width="107">
<p>Benin</p>
</td>
<td width="89">
<p>Niger</p>
</td>
</tr>
<tr>
<td width="107">
<p>Botswana</p>
</td>
<td width="89">
<p>NULL</p>
</td>
</tr>
<tr>
<td width="107">
<p>Burkina Faso</p>
</td>
<td width="89">
<p>Niger</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 15.&nbsp;&nbsp; *Continents and Currencies</h2>
<p>Write a query that selects:</p>
<ul>
<li><strong>ContinentCode</strong></li>
<li><strong>CurrencyCode</strong></li>
<li><strong>CurrencyUsage</strong></li>
</ul>
<p>Find all <strong>continents</strong> and their <strong>most</strong> <strong>used</strong> <strong>currency</strong>. Filter any <strong>currency</strong> that is used in <strong>only</strong> <strong>one</strong> <strong>country</strong>. <strong>Sort</strong> your results by <strong>ContinentCode</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>ContinentCode</strong></p>
</td>
<td width="104">
<p><strong>CurrencyCode</strong></p>
</td>
<td width="113">
<p><strong>CurrencyUsage</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>AF</p>
</td>
<td width="104">
<p>XOF</p>
</td>
<td width="113">
<p>8</p>
</td>
</tr>
<tr>
<td width="113">
<p>AS</p>
</td>
<td width="104">
<p>AUD</p>
</td>
<td width="113">
<p>2</p>
</td>
</tr>
<tr>
<td width="113">
<p>AS</p>
</td>
<td width="104">
<p>ILS</p>
</td>
<td width="113">
<p>2</p>
</td>
</tr>
<tr>
<td width="113">
<p>EU</p>
</td>
<td width="104">
<p>EUR</p>
</td>
<td width="113">
<p>26</p>
</td>
</tr>
<tr>
<td width="113">
<p>NA</p>
</td>
<td width="104">
<p>XCD</p>
</td>
<td width="113">
<p>8</p>
</td>
</tr>
<tr>
<td width="113">
<p>OC</p>
</td>
<td width="104">
<p>USD</p>
</td>
<td width="113">
<p>8</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 16.&nbsp;&nbsp; Countries without any Mountains</h2>
<p>Write a query that selects <strong>CountryCode</strong><strong>.</strong> Find all the <strong>count</strong> of all <strong>countries,</strong> which <strong>don&rsquo;t</strong> <strong>have</strong> a <strong>mountain</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="101">
<p><strong>CountryCode</strong></p>
</td>
</tr>
<tr>
<td width="101">
<p>231</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 17.&nbsp;&nbsp; Highest Peak and Longest River by Country</h2>
<p>For each country, find the elevation of <strong>the highest peak</strong> and <strong>the length of the longest river</strong>, <strong>sorted</strong> by the <strong>highest peak elevation</strong> (from highest to lowest), then by the <strong>longest river length</strong> (from longest to smallest), then by <strong>country name</strong> (alphabetically). Display <strong>NULL</strong> when no data is available in some of the columns. Limit only the <strong>first 5</strong> rows.</p>
<table>
<tbody>
<tr>
<td width="107">
<p><strong>CountryName</strong></p>
</td>
<td width="147">
<p><strong>HighestPeakElevation</strong></p>
</td>
<td width="134">
<p><strong>LongestRiverLength</strong></p>
</td>
</tr>
<tr>
<td width="107">
<p>China</p>
</td>
<td width="147">
<p>8848</p>
</td>
<td width="134">
<p>6300</p>
</td>
</tr>
<tr>
<td width="107">
<p>India</p>
</td>
<td width="147">
<p>8848</p>
</td>
<td width="134">
<p>3180</p>
</td>
</tr>
<tr>
<td width="107">
<p>Nepal</p>
</td>
<td width="147">
<p>8848</p>
</td>
<td width="134">
<p>2948</p>
</td>
</tr>
<tr>
<td width="107">
<p>Pakistan</p>
</td>
<td width="147">
<p>8611</p>
</td>
<td width="134">
<p>3180</p>
</td>
</tr>
<tr>
<td width="107">
<p>Argentina</p>
</td>
<td width="147">
<p>6962</p>
</td>
<td width="134">
<p>4880</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 18.&nbsp;&nbsp; * Highest Peak Name and Elevation by Country</h2>
<p>For each country, find the <strong>name </strong>and <strong>elevation</strong> of <strong>the highest peak</strong>, along with its <strong>mountain</strong>. When no peaks are available in some country, display elevation<strong> 0</strong>, "<strong>(no highest peak)</strong>" as <strong>peak name</strong> and "<strong>(no mountain)</strong>" as <strong>mountain name</strong>. When <strong>multiple peaks</strong> in some country have the <strong>same elevation</strong>, display <strong>all of them</strong>. <strong>Sort</strong> the results by <strong>country name alphabetically</strong>, then by <strong>highest peak name alphabetically</strong>. Limit only the <strong>first 5</strong> rows.</p>
<table>
<tbody>
<tr>
<td width="102">
<p><strong>Country</strong></p>
</td>
<td width="138">
<p><strong>Highest Peak Name</strong></p>
</td>
<td width="157">
<p><strong>Highest Peak Elevation</strong></p>
</td>
<td width="107">
<p><strong>Mountain</strong></p>
</td>
</tr>
<tr>
<td width="102">
<p>Afghanistan</p>
</td>
<td width="138">
<p>(no highest peak)</p>
</td>
<td width="157">
<p>0</p>
</td>
<td width="107">
<p>(no mountain)</p>
</td>
</tr>
<tr>
<td width="102">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
<td width="157">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="102">
<p>Argentina</p>
</td>
<td width="138">
<p>Aconcagua</p>
</td>
<td width="157">
<p>6962</p>
</td>
<td width="107">
<p>Andes</p>
</td>
</tr>
<tr>
<td width="102">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
<td width="157">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="102">
<p>Bulgaria</p>
</td>
<td width="138">
<p>Musala</p>
</td>
<td width="157">
<p>2925</p>
</td>
<td width="107">
<p>Rila</p>
</td>
</tr>
<tr>
<td width="102">
<p>Burkina Faso</p>
</td>
<td width="138">
<p>(no highest peak)</p>
</td>
<td width="157">
<p>0</p>
</td>
<td width="107">
<p>(no mountain)</p>
</td>
</tr>
<tr>
<td width="102">
<p>&hellip;</p>
</td>
<td width="138">
<p>&hellip;</p>
</td>
<td width="157">
<p>&hellip;</p>
</td>
<td width="107">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="102">
<p>United States</p>
</td>
<td width="138">
<p>Mount McKinley</p>
</td>
<td width="157">
<p>6194</p>
</td>
<td width="107">
<p>Alaska Range</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
