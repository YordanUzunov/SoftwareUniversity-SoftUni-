<h1>Exercises: Data Aggregation</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">"Databases Basics - MSSQL" course @ Software University.</a></p>
<p>Mr. Bodrog is a greedy small goblin who is in charge of <strong>Gringotts</strong> &ndash; the biggest wizard bank. His most precious possession is a small database of the deposits in the wizard&rsquo;s world. Taking money is his hobby. He wants your money as well but unfortunately you are not a wizard. The only magic you know is how to work with <strong>databases</strong>. That&rsquo;s how you got access to the precious data. Mr. Bodrog wants you to send him some reports otherwise he will send a pack of hungry werewolves after you. You don&rsquo;t want to confront pack of hungry werewolves, do you?</p>
<p>Before going on the next task make sure to download the <strong>Gringotts</strong> database.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Records&rsquo; Count</h2>
<p>Import the database and send the <strong>total count of records</strong> from the one and only table to Mr. Bodrog. Make sure nothing got lost.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="58">
<p><strong>Count</strong></p>
</td>
</tr>
<tr>
<td width="58">
<p>162</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Longest Magic Wand</h2>
<p>Select the <strong>size</strong> of the <strong>longest magic wand</strong>. Rename the new column appropriately.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="142">
<p><strong>LongestMagicWand</strong></p>
</td>
</tr>
<tr>
<td width="142">
<p>31</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Longest Magic Wand per Deposit Groups</h2>
<p>For wizards in <strong>each deposit group</strong> show the <strong>longest magic wand</strong>. Rename the new column appropriately.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="142">
<p><strong>LongestMagicWand</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Blue Phoenix</p>
</td>
<td width="142">
<p>31</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Smallest Deposit Group per Magic Wand Size</h2>
<p>Select the <strong>two deposit groups</strong> with the <strong>lowest average wand size</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="132">
<p><strong>DepositGroup</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Troll Chest</p>
</td>
</tr>
<tr>
<td width="132">
<p>Venomous Tongue</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deposits Sum</h2>
<p>Select <strong>all deposit groups</strong> and their <strong>total deposit sums</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>DepositGroup</strong></p>
</td>
<td width="95">
<p><strong>TotalSum</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Blue Phoenix</p>
</td>
<td width="95">
<p>819598.73</p>
</td>
</tr>
<tr>
<td width="104">
<p>Human Pride</p>
</td>
<td width="95">
<p>1041291.52</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deposits Sum for Ollivander Family</h2>
<p>Select <strong>all deposit groups</strong> and their <strong>total deposit sums</strong> but <strong>only for the wizards</strong> who have their magic wands <strong>crafted by Ollivander family</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="85">
<p><strong>TotalSum</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Blue Phoenix</p>
</td>
<td width="85">
<p>52968.96</p>
</td>
</tr>
<tr>
<td width="113">
<p>Human Pride</p>
</td>
<td width="85">
<p>188366.86</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deposits Filter</h2>
<p>Select <strong>all deposit groups</strong> and their total deposit sums but <strong>only for the wizards</strong> who have their magic wands <strong>crafted by Ollivander family</strong>. <strong>Filter</strong> total <strong>deposit amounts lower than 150000</strong>. Order by <strong>total deposit amount</strong> in <strong>descending </strong>order.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="85">
<p><strong>TotalSum</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Troll Chest</p>
</td>
<td width="85">
<p>126585.18</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Deposit Charge</h2>
<p>Create a query that selects:</p>
<ul>
<li><strong>Deposit group </strong></li>
<li><strong>Magic wand creator</strong></li>
<li>Minimum <strong>deposit charge</strong> for each group</li>
</ul>
<p>Select the data in <strong>ascending</strong> ordered by <strong>MagicWandCreator</strong> and <strong>DepositGroup</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepositGroup</strong></p>
</td>
<td width="142">
<p><strong>MagicWandCreator</strong></p>
</td>
<td width="132">
<p><strong>MinDepositCharge</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>Blue Phoenix</p>
</td>
<td width="142">
<p>Antioch Peverell</p>
</td>
<td width="132">
<p>30.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
<td width="132">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Age Groups</h2>
<p>Write down a query that creates 7 different groups based on their <strong>age</strong>.</p>
<p><strong>Age groups</strong> should be as follows:</p>
<ul>
<li>[0-10]</li>
<li>[11-20]</li>
<li>[21-30]</li>
<li>[31-40]</li>
<li>[41-50]</li>
<li>[51-60]</li>
<li>[61+]</li>
</ul>
<p>The query should return</p>
<ul>
<li><strong>Age groups</strong></li>
<li><strong>Count </strong>of wizards in it</li>
</ul>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>AgeGroup</strong></p>
</td>
<td width="104">
<p><strong>WizardCount</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>[11-20]</p>
</td>
<td width="104">
<p>21</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
<td width="104">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10.&nbsp;&nbsp; First Letter</h2>
<p>Write a query that returns <strong>all unique wizard first letters</strong> of their <strong>first names</strong> only if they have <strong>deposit of type Troll Chest</strong>. Order them <strong>alphabetically</strong>. Use GROUP BY for uniqueness.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="85">
<p><strong>FirstLetter</strong></p>
</td>
</tr>
<tr>
<td width="85">
<p>A</p>
</td>
</tr>
<tr>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 11.&nbsp;&nbsp; Average Interest</h2>
<p>Mr. Bodrog is highly interested in profitability. He wants to know the <strong>average interest</strong> of all <strong>deposit groups</strong> split by whether the deposit has <strong>expired or not</strong>. But that&rsquo;s not all. He wants you to select deposits with <strong>start date after</strong> 01/01/1985. Order the data <strong>descending</strong> by <strong>Deposit Group</strong> and <strong>ascending</strong> by <strong>Expiration Flag</strong>.</p>
<p>The output should consist of the following columns:</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="132">
<p><strong>DepositGroup</strong></p>
</td>
<td width="123">
<p><strong>IsDepositExpired</strong></p>
</td>
<td width="123">
<p><strong>AverageInterest</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Venomous Tongue</p>
</td>
<td width="123">
<p>0</p>
</td>
<td width="123">
<p>16.698947</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
<td width="123">
<p>&hellip;</p>
</td>
<td width="123">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12.&nbsp;&nbsp; * Rich Wizard, Poor Wizard</h2>
<p>Mr. Bodrog definitely likes his werewolves more than you. This is your last chance to survive! Give him some data to play his favorite game Rich Wizard, Poor Wizard. The rules are simple: You <strong>compare</strong> the <strong>deposits of every wizard</strong> with the <strong>wizard after him</strong>. If a wizard is the last one in the database, simply <strong>ignore it</strong>. In the end you have to <strong>sum</strong> the <strong>difference between the deposits</strong>.</p>
<table>
<tbody>
<tr>
<td width="111">
<p><strong>Host Wizard</strong></p>
</td>
<td width="112">
<p><strong>Host Wizard Deposit</strong></p>
</td>
<td width="111">
<p><strong>Guest Wizard</strong></p>
</td>
<td width="125">
<p><strong>Guest Wizard Deposit</strong></p>
</td>
<td width="106">
<p><strong>Difference</strong></p>
</td>
</tr>
<tr>
<td width="111">
<p>Harry</p>
</td>
<td width="112">
<p>10 000</p>
</td>
<td width="111">
<p>Tom</p>
</td>
<td width="125">
<p>12&nbsp;000</p>
</td>
<td width="106">
<p>-2000</p>
</td>
</tr>
<tr>
<td width="111">
<p>Tom</p>
</td>
<td width="112">
<p>12 000</p>
</td>
<td width="111">
<p>&hellip;</p>
</td>
<td width="125">
<p>&hellip;</p>
</td>
<td width="106">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<p>At the end your query should return a <strong>single value</strong>: the SUM of all differences.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>SumDifference</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>44393.97</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 13.&nbsp;&nbsp; Departments Total Salaries</h2>
<p>That&rsquo;s it! You no longer work for Mr. Bodrog. You have decided to find a proper job as an analyst in SoftUni. <br /> It&rsquo;s not a surprise that you will use the <strong>SoftUni</strong> database. Things get more exciting here!</p>
<p>Create a query that shows the <strong>total sum</strong> of <strong>salaries</strong> for <strong>each department</strong>. <strong>Order</strong> by <strong>DepartmentID</strong>.<br /> Your query should return:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<ul>
<li><strong>DepartmentID</strong></li>
</ul>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepartmentID</strong></p>
</td>
<td width="113">
<p><strong>TotalSalary</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>1</p>
</td>
<td width="113">
<p>241000.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 14.&nbsp;&nbsp; Employees Minimum Salaries</h2>
<p>Select the <strong>minimum salary</strong> from the <strong>employees</strong> for <strong>departments</strong> with <strong>ID</strong> (2, 5, 7) but <strong>only</strong> for those hired <strong>after </strong>01/01/2000.<br /> Your query should return:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<ul>
<li><strong>DepartmentID</strong></li>
</ul>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="113">
<p><strong>DepartmentID</strong></p>
</td>
<td width="113">
<p><strong>MinimumSalary</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>2</p>
</td>
<td width="113">
<p>25000.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>5</p>
</td>
<td width="113">
<p>12800.00</p>
</td>
</tr>
<tr>
<td width="113">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 15.&nbsp;&nbsp; Employees Average Salaries</h2>
<p>Select all <strong>employees</strong> who earn <strong>more than</strong> 30000 <strong>into a new table. </strong>Then <strong>delete</strong> all <strong>employees</strong> who have <strong>ManagerID = 42 </strong>(in the new table). Then <strong>increase the salaries</strong> of all employees with <strong>DepartmentID=1</strong> by 5000. Finally, select the <strong>average salaries</strong> in <strong>each department</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>DepartmentID</strong></p>
</td>
<td width="113">
<p><strong>AverageSalary</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>1</p>
</td>
<td width="113">
<p>45166.6666</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="113">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 16.&nbsp;&nbsp; Employees Maximum Salaries</h2>
<p>Find the <strong>max salary</strong> for <strong>each department</strong>. <strong>Filter</strong> those, which have <strong>max salaries</strong> <strong>NOT</strong> in the <strong>range</strong> 30000 &ndash; 70000.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>DepartmentID</strong></p>
</td>
<td width="85">
<p><strong>MaxSalary</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>2</p>
</td>
<td width="85">
<p>29800.00</p>
</td>
</tr>
<tr>
<td width="104">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 17.&nbsp;&nbsp; Employees Count Salaries</h2>
<p><strong>Count</strong> the salaries of all <strong>employees</strong> who don&rsquo;t have a <strong>manager</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="66">
<p><strong>Count</strong></p>
</td>
</tr>
<tr>
<td width="66">
<p>4</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 18.&nbsp;&nbsp; *3rd Highest Salary</h2>
<p>Find the <strong>third highest salary</strong> in <strong>each department</strong> if there is such.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="109">
<p><strong>DepartmentID</strong></p>
</td>
<td width="132">
<p><strong>ThirdHighestSalary</strong></p>
</td>
</tr>
<tr>
<td width="109">
<p>1</p>
</td>
<td width="132">
<p>36100.00</p>
</td>
</tr>
<tr>
<td width="109">
<p>&hellip;</p>
</td>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 19.&nbsp;&nbsp; **Salary Challenge</h2>
<p>Write a query that returns:</p>
<ul>
<li><strong>FirstName</strong></li>
<li><strong>LastName</strong></li>
<li><strong>DepartmentID</strong></li>
</ul>
<p>Select all <strong>employees</strong> who have salary<strong> higher than the average salary</strong> of their respective <strong>departments</strong>. Select <strong>only </strong>the first <strong>10 rows</strong>. <strong>Order</strong> by <strong>DepartmentID</strong>.</p>
<h3>Example:</h3>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>FirstName</strong></p>
</td>
<td width="90">
<p><strong>LastName</strong></p>
</td>
<td width="113">
<p><strong>DepartmentID</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>Roberto</p>
</td>
<td width="90">
<p>Tamburello</p>
</td>
<td width="113">
<p>1</p>
</td>
</tr>
<tr>
<td width="84">
<p>&hellip;</p>
</td>
<td width="90">
<p>&hellip;</p>
</td>
<td width="113">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>