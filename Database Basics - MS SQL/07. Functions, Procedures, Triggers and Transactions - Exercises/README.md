<h1>Exercises: Database Programmability and Transactions</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/databases-basics-ms-sql-server">"Databases Basics - MSSQL" course @ Software University.</a></p>
<h1>Section I. Functions and Procedures</h1>
<h2>Part 1. Queries for SoftUni Database</h2>
<h3>Problem 1. Employees with Salary Above 35000</h3>
<p>Create stored procedure <strong>usp_GetEmployeesSalaryAbove35000</strong> that returns <strong>all employees&rsquo; first and last names</strong> for whose <strong>salary is above 35000</strong>.</p>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Roberto</p>
</td>
<td width="95">
<p>Tamburello</p>
</td>
</tr>
<tr>
<td width="92">
<p>David</p>
</td>
<td width="95">
<p>Bradley</p>
</td>
</tr>
<tr>
<td width="92">
<p>Terri</p>
</td>
<td width="95">
<p>Duffy</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 2. Employees with Salary Above Number</h3>
<p>Create stored procedure <strong>usp_GetEmployeesSalaryAboveNumber</strong> that <strong>accept a number </strong>(of type <strong>DECIMAL</strong><strong>(18,4)</strong>) as parameter and returns<strong> all employees&rsquo; first and last names</strong> whose salary is <strong>above or equal</strong> to the given number.</p>
<h4>Example</h4>
<p>Supplied number for that example is 48100.</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Terri</p>
</td>
<td width="95">
<p>Duffy</p>
</td>
</tr>
<tr>
<td width="92">
<p>Jean</p>
</td>
<td width="95">
<p>Trenary</p>
</td>
</tr>
<tr>
<td width="92">
<p>Ken</p>
</td>
<td width="95">
<p>Sanchez</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 3. Town Names Starting With</h3>
<p>Write a stored procedure <strong>usp_GetTownsStartingWith</strong> that <strong>accept string as parameter</strong> and returns <strong>all town names starting with that string. </strong></p>
<h4>Example</h4>
<p>Here is the list of all towns <strong>starting with &ldquo;b&rdquo;.</strong></p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Town</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Bellevue</p>
</td>
</tr>
<tr>
<td width="92">
<p>Bothell</p>
</td>
</tr>
<tr>
<td width="92">
<p>Bordeaux</p>
</td>
</tr>
<tr>
<td width="92">
<p>Berlin</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 4. Employees from Town</h3>
<p>Write a stored procedure <strong>usp_GetEmployeesFromTown</strong> that accepts <strong>town name</strong> as parameter and return the <strong>employees&rsquo; first and last name that live in the given town. </strong></p>
<h4>Example</h4>
<p>Here it is a list of employees<strong> living in Sofia.</strong></p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Svetlin</p>
</td>
<td width="95">
<p>Nakov</p>
</td>
</tr>
<tr>
<td width="92">
<p>Martin</p>
</td>
<td width="95">
<p>Kulov</p>
</td>
</tr>
<tr>
<td width="92">
<p>George</p>
</td>
<td width="95">
<p>Denchev</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 5. Salary Level Function</h3>
<p>Write a function <strong>ufn_GetSalaryLevel(@salary DECIMAL</strong><strong>(18,4)</strong><strong>)</strong> that receives <strong>salary of an employee </strong>and returns the <strong>level of the salary</strong>.</p>
<ul>
<li>If salary is <strong>&lt; 30000</strong> return <strong>&ldquo;Low&rdquo;</strong></li>
<li>If salary is <strong>between 30000 and 50000 (inclusive)</strong> return<strong> &ldquo;Average&rdquo;</strong></li>
<li>If salary is <strong>&gt; 50000</strong> return<strong> &ldquo;High&rdquo;</strong></li>
</ul>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Salary</strong></p>
</td>
<td width="95">
<p><strong>Salary Level</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>13500.00</p>
</td>
<td width="95">
<p>Low</p>
</td>
</tr>
<tr>
<td width="92">
<p>43300.00</p>
</td>
<td width="95">
<p>Average</p>
</td>
</tr>
<tr>
<td width="92">
<p>125500.00</p>
</td>
<td width="95">
<p>High</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 6. Employees by Salary Level</h3>
<p>Write a stored procedure<strong> usp_EmployeesBySalaryLevel</strong> that receive as <strong>parameter</strong> <strong>level of salary</strong> (low, average or high) and print the <strong>names of all employees </strong>that have given level of salary. You should use the function - &ldquo;<strong>dbo.ufn_GetSalaryLevel</strong><strong>(@Salary)</strong>&rdquo;, which was part of the previous task, inside your &ldquo;<strong>CREATE PROCEDURE &hellip;</strong>&rdquo; query.</p>
<h4>Example</h4>
<p>Here is the list of all employees with high salary.</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Terri</p>
</td>
<td width="95">
<p>Duffy</p>
</td>
</tr>
<tr>
<td width="92">
<p>Jean</p>
</td>
<td width="95">
<p>Trenary</p>
</td>
</tr>
<tr>
<td width="92">
<p>Ken</p>
</td>
<td width="95">
<p>Sanchez</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 7. Define Function</h3>
<p>Define a function <strong>ufn_IsWordComprised(@setOfLetters, @word)</strong> that returns <strong>true</strong> or <strong>false</strong> depending on that if the word is a comprised of the given set of letters.</p>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>SetOfLetters</strong></p>
</td>
<td width="52">
<p><strong>Word</strong></p>
</td>
<td width="55">
<p><strong>Result</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>oistmiahf</p>
</td>
<td width="52">
<p>Sofia</p>
</td>
<td width="55">
<p>1</p>
</td>
</tr>
<tr>
<td width="92">
<p>oistmiahf</p>
</td>
<td width="52">
<p>halves</p>
</td>
<td width="55">
<p>0</p>
</td>
</tr>
<tr>
<td width="92">
<p>bobr</p>
</td>
<td width="52">
<p>Rob</p>
</td>
<td width="55">
<p>1</p>
</td>
</tr>
<tr>
<td width="92">
<p>pppp</p>
</td>
<td width="52">
<p>Guy</p>
</td>
<td width="55">
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 8. * Delete Employees and Departments</h3>
<p>Write a <strong>procedure </strong>with the name <strong>usp_DeleteEmployeesFromDepartment</strong> <strong>(</strong><strong>@departmentId</strong> INT<strong>) which </strong><strong>deletes all Employees</strong> from a <strong>given</strong> <strong>department</strong>. <strong>Delete these departments </strong>from the<strong> Departments table </strong>too. <strong>Finally</strong><strong> SELECT </strong>the <strong>number</strong> of <strong>employees</strong> from the <strong>given department</strong>. If the delete statements are correct the select query should return 0.</p>
<p>After completing that exercise restore your database to revert all changes.</p>
<h4>Hint:</h4>
<p>You may set <strong>ManagerID</strong> column in Departments table to <strong>nullable</strong> (using query "ALTER TABLE &hellip;").</p>
<h2>Part 2. Queries for Bank Database</h2>
<h3>Problem 9. Find Full Name</h3>
<p>You are given a database schema with tables <strong>AccountHolders(Id (PK), FirstName, LastName, SSN)</strong> and <strong>Accounts(Id (PK), AccountHolderId (FK), Balance)</strong>.&nbsp; Write a stored procedure <strong>usp_GetHoldersFullName</strong> that selects the full names of all people.</p>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="132">
<p><strong>Full Name</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>Susan Cane</p>
</td>
</tr>
<tr>
<td width="132">
<p>Kim Novac</p>
</td>
</tr>
<tr>
<td width="132">
<p>Jimmy Henderson</p>
</td>
</tr>
<tr>
<td width="132">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 10. People with Balance Higher Than</h3>
<p>Your task is to create a stored procedure <strong>usp_GetHoldersWithBalanceHigherThan</strong> that accepts a <strong>number as a parameter</strong> and returns all <strong>people who have more money in total of all their accounts than the supplied number</strong>.</p>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Susan</p>
</td>
<td width="95">
<p>Cane</p>
</td>
</tr>
<tr>
<td width="92">
<p>Petar</p>
</td>
<td width="95">
<p>Kirilov</p>
</td>
</tr>
<tr>
<td width="92">
<p>&hellip;</p>
</td>
<td width="95">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 11. Future Value Function</h3>
<p>Your task is to create a function <strong>ufn_CalculateFutureValue</strong> that accepts as parameters &ndash; <strong>sum (decimal)</strong>, <strong>yearly interest rate (float)</strong> and <strong>number of years(int)</strong>. It should calculate and return the future value of the initial sum rounded to the <strong>fourth digit</strong> after the decimal delimiter. Using the following formula:</p>
<ul>
<li><strong>I </strong>&ndash; Initial sum</li>
<li><strong>R</strong> &ndash; Yearly interest rate</li>
<li><strong>T</strong> &ndash; Number of years</li>
</ul>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="329">
<p><strong>Input</strong></p>
</td>
<td width="87">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="329">
<p><strong>Initial sum:</strong> 1000</p>
<p><strong>Yearly Interest rate:</strong> 10%</p>
<p><strong>years:</strong> 5</p>
<p>ufn_CalculateFutureValue(1000, 0.1, 5)</p>
</td>
<td width="87">
<p>1610.5100</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 12. Calculating Interest</h3>
<p>Your task is to create a stored procedure <strong>usp_CalculateFutureValueForAccount</strong> that uses the function from the previous problem to give an interest to a person's account <strong>for 5 years</strong>, along with information about his/her <strong>account id, first name, last name and current balance</strong> as it is shown in the example below. It should take the <strong>AccountId</strong> and the <strong>interest rate</strong> as parameters. Again you are provided with &ldquo;<strong>dbo.ufn_CalculateFutureValue</strong>&rdquo; function which was part of the previous task.</p>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Account Id</strong></p>
</td>
<td width="95">
<p><strong>First Name</strong></p>
</td>
<td width="95">
<p><strong>Last Name</strong></p>
</td>
<td width="113">
<p><strong>Current Balance</strong></p>
</td>
<td width="132">
<p><strong>Balance in 5 years</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1</p>
</td>
<td width="95">
<p>Susan</p>
</td>
<td width="95">
<p>Cane</p>
</td>
<td width="113">
<p>123.12</p>
</td>
<td width="132">
<p>198.286</p>
</td>
</tr>
</tbody>
</table>
<p>*Note: for the example above interest rate is 0.1</p>
<h2>Part 3. Queries for Diablo Database</h2>
<p>You are given a <strong>database "Diablo"</strong> holding users, games, items, characters and statistics available as SQL script. Your task is to write some stored procedures, views and other server-side database objects and write some SQL queries for displaying data from the database.</p>
<p><strong>Important:</strong> start with a <strong>clean copy of the "Diablo" database</strong> <strong>on each problem</strong>. Just execute the SQL script again.</p>
<h3>Problem 13. *Scalar Function: Cash in User Games Odd Rows</h3>
<p>Create a <strong>function</strong> <strong>u</strong><strong>fn_CashInUsersGames </strong>that <strong>sums the cash of odd rows</strong>. Rows must be ordered by cash in descending order. The function should take a <strong>game name</strong> as a <strong>parameter</strong> and<strong> return the result as table</strong>. Submit <strong>only your function</strong> <strong>in</strong>.</p>
<p>Execute the function over the following game names, ordered exactly like: &ldquo;<strong>Lily Stargazer</strong>&rdquo;, &ldquo;<strong>Love in a mist</strong>&rdquo;.</p>
<h4>Output</h4>
<table>
<tbody>
<tr>
<td width="83">
<p><strong>SumCash</strong></p>
</td>
</tr>
<tr>
<td width="83">
<p>5515.00</p>
</td>
</tr>
<tr>
<td width="83">
<p>7266.00</p>
</td>
</tr>
<tr>
<td width="83">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h4>Hint</h4>
<p>Use <strong>ROW_NUMBER</strong> to get the rankings of all rows based on order criteria.</p>
<h1>Section II. Triggers and Transactions</h1>
<h2>Part 1. Queries for Bank Database</h2>
<h3>Problem 14. Create Table Logs</h3>
<p>Create a table &ndash; <strong>Logs</strong> (LogId, AccountId, OldSum, NewSum). Add a <strong>trigger</strong> to the Accounts table that <strong>enters</strong> a new entry into the <strong>Logs</strong> table every time the sum <strong>on</strong> an <strong>account</strong> <strong>changes</strong>. Submit <strong>only</strong> the <strong>query</strong> that <strong>creates</strong> the <strong>trigger</strong>.</p>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="55">
<p><strong>LogId</strong></p>
</td>
<td width="83">
<p><strong>AccountId</strong></p>
</td>
<td width="70">
<p><strong>OldSum</strong></p>
</td>
<td width="76">
<p><strong>NewSum</strong></p>
</td>
</tr>
<tr>
<td width="55">
<p>1</p>
</td>
<td width="83">
<p>1</p>
</td>
<td width="70">
<p>123.12</p>
</td>
<td width="76">
<p>113.12</p>
</td>
</tr>
<tr>
<td width="55">
<p>&hellip;</p>
</td>
<td width="83">
<p>&hellip;</p>
</td>
<td width="70">
<p>&hellip;</p>
</td>
<td width="76">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 15. Create Table Emails</h3>
<p>Create another table &ndash; <strong>NotificationEmails</strong>(Id, Recipient, Subject, Body). Add a <strong>trigger</strong> to logs table and <strong>create new email whenever new record is inserted in logs table. </strong>The following data is required to be filled for each email:</p>
<ul>
<li><strong>Recipient</strong> &ndash; AccountId</li>
<li><strong>Subject</strong> &ndash; &ldquo;Balance change for account: <strong>{AccountId}</strong>&rdquo;</li>
<li><strong>Body</strong> - &ldquo;On <strong>{date}</strong> your balance was changed from <strong>{old}</strong> to <strong>{new}.</strong>&rdquo;</li>
</ul>
<p><strong>Submit</strong> your query <strong>only</strong> for the <strong>trigger</strong> action.</p>
<h4>Example</h4>
<table>
<tbody>
<tr>
<td width="32">
<p><strong>Id</strong></p>
</td>
<td width="78">
<p><strong>Recipient</strong></p>
</td>
<td width="176">
<p><strong>Subject</strong></p>
</td>
<td width="277">
<p><strong>Body</strong></p>
</td>
</tr>
<tr>
<td width="32">
<p>1</p>
</td>
<td width="78">
<p>1</p>
</td>
<td width="176">
<p>Balance change for account: 1</p>
</td>
<td width="277">
<p>On Sep 12 2016 2:09PM your balance was changed from 113.12 to 103.12.</p>
</td>
</tr>
<tr>
<td width="32">
<p>&hellip;</p>
</td>
<td width="78">
<p>&hellip;</p>
</td>
<td width="176">
<p>&hellip;</p>
</td>
<td width="277">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 16. Deposit Money</h3>
<p>Add stored procedure <strong>usp_DepositMoney</strong> (<strong>AccountId</strong>, <strong>MoneyAmount</strong>) that deposits money to an existing account. Make sure to guarantee valid positive MoneyAmount with precision up to <strong>fourth sign after decimal point</strong>. The procedure should produce exact results working with the specified precision.</p>
<h4>Example</h4>
<p>Here is the result for <strong>AccountId = 1 </strong>and <strong>MoneyAmount = 10</strong><strong>.</strong></p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>AccountId</strong></p>
</td>
<td width="135">
<p><strong>AccountHolderId</strong></p>
</td>
<td width="95">
<p><strong>Balance</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1</p>
</td>
<td width="135">
<p>1</p>
</td>
<td width="95">
<p>133.1200</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 17. Withdraw Money</h3>
<p>Add stored procedure <strong>usp_WithdrawMoney</strong> (<strong>AccountId</strong>, <strong>MoneyAmount</strong>) that withdraws money from an existing account. Make sure to guarantee valid positive MoneyAmount with precision up to <strong>fourth sign after decimal point</strong>. The procedure should produce exact results working with the specified precision.</p>
<h4>Example</h4>
<p>Here is the result for <strong>AccountId = 5 </strong>and <strong>MoneyAmount = 25</strong><strong>.</strong></p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>AccountId</strong></p>
</td>
<td width="135">
<p><strong>AccountHolderId</strong></p>
</td>
<td width="95">
<p><strong>Balance</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>5</p>
</td>
<td width="135">
<p>11</p>
</td>
<td width="95">
<p>36496.2000</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 18. Money Transfer</h3>
<p>Write stored procedure <strong>usp_TransferMoney</strong>(SenderId, ReceiverId, Amount) that <strong>transfers money from one account to another</strong>. Make sure to guarantee valid positive MoneyAmount with precision up to <strong>fourth sign after decimal point</strong>. Make sure that the whole procedure <strong>passes without errors </strong>and <strong>if error occurs make</strong> <strong>no change in the database.</strong> You can use both: &ldquo;<strong>usp_DepositMoney</strong>&rdquo;, &ldquo;<strong>usp_WithdrawMoney</strong>&rdquo; (look at previous two problems about those procedures).</p>
<h4>Example</h4>
<p>Here is the result for SenderId<strong> = 5, </strong>ReceiverId = 1 and <strong>MoneyAmount = 5000</strong><strong>.</strong></p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>AccountId</strong></p>
</td>
<td width="135">
<p><strong>AccountHolderId</strong></p>
</td>
<td width="95">
<p><strong>Balance</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1</p>
</td>
<td width="135">
<p>1</p>
</td>
<td width="95">
<p>5123.12</p>
</td>
</tr>
<tr>
<td width="92">
<p>5</p>
</td>
<td width="135">
<p>11</p>
</td>
<td width="95">
<p>31521.2000</p>
</td>
</tr>
</tbody>
</table>
<h2>Part 2. Queries for Diablo Database</h2>
<p>You are given a <strong>database "Diablo"</strong> holding users, games, items, characters and statistics available as SQL script. Your task is to write some stored procedures, views and other server-side database objects and write some SQL queries for displaying data from the database.</p>
<p><strong>Important:</strong> start with a <strong>clean copy of the "Diablo" database</strong> <strong>on each problem</strong>. Just execute the SQL script again.</p>
<h3>Problem 19. Trigger</h3>
<ol>
<li>Users <strong>should not</strong> be allowed to buy items with <strong>higher level</strong> than <strong>their</strong> <strong>level</strong>. Create a <strong>trigger</strong> that <strong>restricts</strong> The trigger should prevent <strong>inserting items</strong> that are above specified level while allowing all others to be inserted.</li>
<li>Add bonus cash of <strong>50000</strong> to users: <strong>baleremuda, loosenoise, inguinalself, buildingdeltoid, monoxidecos </strong>in the game<strong> &ldquo;Bali&rdquo;.</strong></li>
<li>There are two groups of <strong>items</strong> that you must buy for the above users. The first are items with <strong>id between 251 and 299 including</strong>. Second group are items with <strong>id between 501 and 539 including.<br /> Take</strong> off <strong>cash</strong> from each user <strong>for</strong> the bought <strong>items</strong>.</li>
<li>Select all users in the current game (&ldquo;Bali&rdquo;) with their items. Display <strong>username</strong>, <strong>game name</strong>, <strong>cash</strong> and <strong>item name</strong>. Sort the result by username alphabetically, then by item name alphabetically.</li>
</ol>
<h4>Output</h4>
<table width="0">
<tbody>
<tr>
<td width="119">
<p><strong>Username</strong></p>
</td>
<td width="66">
<p><strong>Name</strong></p>
</td>
<td width="85">
<p><strong>Cash</strong></p>
</td>
<td width="142">
<p><strong>Item Name</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>baleremuda</p>
</td>
<td width="66">
<p>Bali</p>
</td>
<td width="85">
<p>41153.00</p>
</td>
<td width="142">
<p>Iron Wolves Doctrine</p>
</td>
</tr>
<tr>
<td width="119">
<p>baleremuda</p>
</td>
<td width="66">
<p>Bali</p>
</td>
<td width="85">
<p>41153.00</p>
</td>
<td width="142">
<p>Irontoe Mudsputters</p>
</td>
</tr>
<tr>
<td width="119">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="119">
<p>buildingdeltoid</p>
</td>
<td width="66">
<p>Bali</p>
</td>
<td width="85">
<p>38800.00</p>
</td>
<td width="142">
<p>Alabaster Gloves</p>
</td>
</tr>
<tr>
<td width="119">
<p>&hellip;</p>
</td>
<td width="66">
<p>&hellip;</p>
</td>
<td width="85">
<p>&hellip;</p>
</td>
<td width="142">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>Problem 20. *Massive Shopping</h3>
<ol>
<li>User <strong>Stamat </strong>in<strong> Safflower </strong>game wants to buy some items. He likes all items <strong>from Level 11 to 12</strong> as well as all items <strong>from Level 19 to 21.</strong> As it is a bulk operation you have to <strong>use transactions. </strong></li>
<li>A transaction is the operation of taking out the cash from the user in the current game as well as adding up the items.</li>
<li>Write transactions for each level range. If anything goes wrong turn back the changes inside of the transaction.</li>
<li>Extract all of <strong>Stamat</strong>&rsquo;s item names in the given game sorted by name alphabetically</li>
</ol>
<h4>Output</h4>
<table width="0">
<tbody>
<tr>
<td width="161">
<p><strong>Item Name</strong></p>
</td>
</tr>
<tr>
<td width="161">
<p>Akarats Awakening</p>
</td>
</tr>
<tr>
<td width="161">
<p>Amulets</p>
</td>
</tr>
<tr>
<td width="161">
<p>Angelic Shard</p>
</td>
</tr>
<tr>
<td width="161">
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Part 3. Queries for SoftUni Database</h2>
<h3>Problem 21. Employees with Three Projects</h3>
<p>Create a procedure <strong>usp_AssignProject(@emloyeeId, @projectID)</strong> that <strong>assigns</strong> <strong>projects</strong> to employee. If the employee has more than <strong>3</strong> project throw <strong>exception</strong> and <strong>rollback</strong> the changes. The exception message must be: "<strong>The employee has too many projects!</strong>" with Severity = 16, State = 1.</p>
<h3>Problem 22. Delete Employees</h3>
<p>Create a table Deleted_Employees(EmployeeId PK, FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary) that will hold information about fired(deleted) employees from the <strong>Employees</strong> table. Add a trigger to <strong>Employees</strong> table that inserts the corresponding information about the deleted records in Deleted_Employees.</p>
<p>&nbsp;</p>