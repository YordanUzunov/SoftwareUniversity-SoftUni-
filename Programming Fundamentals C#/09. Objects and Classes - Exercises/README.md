<h1>Exercises: Objects and Classes</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/programming-fundamentals">&ldquo;Programming Fundamentals&rdquo; course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/210/Objects-and-Classes-Exercises">https://judge.softuni.bg/Contests/210/Objects-and-Classes-Exercises</a>.</p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Count Working Days</h2>
<p>Write a program that <strong>reads two dates </strong>in format dd-MM-yyyy and prints the <strong>number of working days</strong> between these two dates <strong>inclusive</strong>. Non-working days are:</p>
<ul>
<li>All days that are <strong>Saturday</strong> or <strong>Sunday</strong>.</li>
<li>All days that are <strong>official holidays</strong> in Bulgaria:
<ul>
<li>New Year Eve (<strong>1 Jan</strong>)</li>
<li>Liberation Day (<strong>3 March</strong>)</li>
<li>Worker&rsquo;s day (<strong>1 May</strong>)</li>
<li>Saint George&rsquo;s Day (<strong>6 May</strong>)</li>
<li>Saints Cyril and Methodius Day (<strong>24 May</strong>)</li>
<li>Unification Day (<strong>6 Sept</strong>)</li>
<li>Independence Day (<strong>22 Sept</strong>)</li>
<li>National Awakening Day (<strong>1 Nov</strong>)</li>
<li>Christmas (<strong>24</strong>, <strong>25</strong> and <strong>26 Dec</strong>)</li>
</ul>
</li>
</ul>
<p>All days not mentioned above are <strong>working </strong>and should count.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="100">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="100">
<p>11-04-2016</p>
<p>14-04-2016</p>
</td>
<td width="62">
<p>4</p>
</td>
</tr>
<tr>
<td width="100">
<p>11-04-2016</p>
<p>22-04-2016</p>
</td>
<td width="62">
<p>10</p>
</td>
</tr>
<tr>
<td width="100">
<p>20-12-2015</p>
<p>31-12-2015</p>
</td>
<td width="62">
<p>7</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read <strong>start date</strong> and <strong>end date</strong> from Console.</li>
<li><strong>Create</strong> two objects of type DateTime &ndash; startDate and endDate.</li>
<li>Create an <strong>array of type </strong>DateTime and add <strong>all official holidays</strong> in it.</li>
<li>Loop from startDate to endDate. Add <strong>1 day</strong> at each iteration.</li>
<li>Get the <strong>current da</strong>y in the loop and check whether is <strong>Saturday</strong>, <strong>Sunday</strong> or it is <strong>contained</strong> <strong>in the holidays array</strong>. If it is not, increment the workingDaysCounter.</li>
</ul>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Advertisement Message</h2>
<p>Write a program that <strong>generate random fake advertisement message</strong> to extol some product. The messages must consist of 4 parts: <strong>laudatory</strong> <strong>phrase</strong> + <strong>event</strong> + <strong>author</strong> + <strong>city</strong>. Use the following predefined parts:</p>
<ul>
<li><strong>Phrases</strong> &ndash; {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can&rsquo;t live without this product."}</li>
<li><strong>Events</strong> &ndash; {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}</li>
<li><strong>Authors</strong> &ndash; {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}</li>
<li><strong>Cities</strong> &ndash; {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}</li>
</ul>
<p>The format of the output message is: <strong>{phrase} {event} {author} &ndash; {city}</strong>.</p>
<p>As an input, you take the <strong>number of messages</strong> to be generated. Print each random message at a separate line.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="608">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>3</p>
</td>
<td width="608">
<p>Such a great product. Now I feel good. Elena &ndash; Ruse</p>
<p>Excelent product. Makes miracles. I am happy of the results! Katya &ndash; Varna</p>
<p>Best product of its category. That makes miracles. Eva - Sofia</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Hold the phrases, events, authors and towns in 4 string<strong> arrays</strong>.</li>
<li>Create a Random object and <strong>generate</strong> <strong>4 random numbers</strong> each in the following ranges:
<ul>
<li>phraseIndex &egrave; &shy;(0, phrases.Length)</li>
<li>eventIndex &egrave; (0, events.Length)</li>
<li>authorIndex &egrave; (0, authors.Length)</li>
<li>townIndex &egrave; (0, towns.Length)</li>
</ul>
</li>
<li>Get one<strong> random element </strong>from each of the four arrays and <strong>compose a message</strong> in the required format.</li>
</ul>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Intersection of Circles</h2>
<p>Create class Circle with properties Center and Radius. The center is a point with coordinates X and Y (make a class Point). Write a method bool Intersect(Circle c1, Circle c2) that tells whether the two given circles <strong>intersect or not</strong>. Write a program that tells if two circles intersect.</p>
<p>The input lines will be in format: <strong>{X} {Y} {Radius}</strong>. Print as output &ldquo;Yes&rdquo; or &ldquo;No&rdquo;.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="286">
<p><strong>Visualization</strong></p>
</td>
</tr>
<tr>
<td width="60">
<p>4 4 2</p>
<p>8 8 1</p>
</td>
<td width="62">
<p>No</p>
</td>
<td width="286">&nbsp;</td>
</tr>
<tr>
<td width="60">
<p>3 3 2</p>
<p>4 3 6</p>
</td>
<td width="62">
<p>Yes</p>
</td>
<td width="286">&nbsp;</td>
</tr>
<tr>
<td width="60">
<p>1 1 4</p>
<p>4 2 5</p>
</td>
<td width="62">
<p>Yes</p>
</td>
<td width="286">&nbsp;</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Calculate d =<strong> distance between the circle centers</strong>.</li>
<li>If the d&le;r1+r2 (the sum of radiuses<strong>) </strong><strong>&agrave; </strong>the circles<strong> intersect</strong> (or one of the circles is inside the other or the circles have one common point when d = r1 + r2).</li>
<li>If the d&gt;r1+r2<strong>&agrave; </strong>the circles do <strong>not intersect</strong> (they have not common shared point).</li>
</ul>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Average Grades</h2>
<p>Define a class Student, which holds the following information about students: <strong>name</strong>, <strong>list of grades</strong> and <strong>average grade</strong> (calculated property, read-only). A single grade will be in range [2&hellip;6], e.g. 3.25 or 5.50.</p>
<p>Read a <strong>list of students</strong> and print the students that have <strong>average grade &ge; 5.00</strong> ordered <strong>by name</strong> (ascending), then by <strong>average</strong> <strong>grade </strong>(descending). Print the student name and the calculated average grade.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>3</p>
<p>Ivan 3</p>
<p>Todor 5 5 6</p>
<p>Diana 6 5.50</p>
</td>
<td width="165">
<p>Diana -&gt; 5.75</p>
<p>Todor -&gt; 5.33</p>
</td>
</tr>
<tr>
<td width="205">
<p>6</p>
<p>Petar 3 5 4 3 2 5 6 2 6</p>
<p>Mitko 6 6 5 6 5 6</p>
<p>Gosho 6 6 6 6 6 6</p>
<p>Ani 6 5 6 5 6 5 6 5</p>
<p>Iva 4 5 4 3 4 5 2 2 4</p>
<p>Ani 5.50 5.25 6.00</p>
</td>
<td width="165">
<p>Ani -&gt; 5.58</p>
<p>Ani -&gt; 5.50</p>
<p>Gosho -&gt; 6.00</p>
<p>Mitko -&gt; 5.67</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create class Student with properties Name (string), Grades (double[]), and property AverageGrade (calculated by LINQ as Average(), read-only).</li>
<li>Make a <strong>list of students</strong> and <strong>filter with LINQ </strong>all students that has average grade &gt;= 00.</li>
<li>Print the filtered students <strong>ordered by name</strong> in ascending order, then by <strong>average grade</strong> in descending order.</li>
</ul>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Book Library</h2>
<p>To model a <strong>book library</strong>, define classes to hold a <strong>book</strong> and a <strong>library</strong>.</p>
<p>The library must have a <strong>name</strong> and a <strong>list of books</strong>. The books must contain the <strong>title</strong>, <strong>author</strong>,<strong> publisher</strong>,<strong> release date </strong>(in dd.MM.yyyy format),<strong> ISBN-number </strong>and<strong> price. </strong></p>
<p>Read a <strong>list of books</strong>, add them to the library and print the <strong>total sum of prices by author</strong>, ordered <strong>descending by price</strong> and <strong>then by author&rsquo;s name lexicographically</strong>.</p>
<p>Books in the input will be in format <strong>{title} {author} {publisher} {release date} {ISBN} {price}</strong>.</p>
<p>The total prices must be printed <strong>formatted to the second decimal place</strong>.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="439">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="439">
<p>5</p>
<p>LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</p>
<p>Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25</p>
<p>HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50</p>
<p>HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00</p>
<p>AC OBowden PenguinBooks 20.11.2009 0395082555 14.00</p>
</td>
<td width="165">
<p>Tolkien -&gt; 40.25</p>
<p>JKRowling -&gt; 35.50</p>
<p>OBowden -&gt; 14.00</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Create classes Book and Library with all the mentioned above properties:</li>
<li><strong>Create</strong> an object of type Library.</li>
<li><strong>Read the input</strong> and create a Book object for each book in the input.</li>
<li>Create a <strong>LINQ</strong> query that will <strong>sum the prices by author</strong>, <strong>order the results</strong> as requested.</li>
<li><strong>Print</strong> the results.</li>
</ul>
<h2>6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Book Library Modification</h2>
<p>Use the classes from the previous problem and make a program that <strong>read a list of books</strong> and <strong>print all titles</strong> <strong>released after given date</strong> ordered <strong>by date</strong> and then <strong>by</strong> <strong>title lexicographically</strong>. The date is given in the format &ldquo;dd.MM.yyyy&rdquo; at the last line in the input.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="447">
<p><strong>Input</strong></p>
</td>
<td width="165">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="447">
<p>5</p>
<p>LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00</p>
<p>Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25</p>
<p>HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50</p>
<p>HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00</p>
<p>AC OBowden PenguinBooks 20.11.2009 0395082555 14.00</p>
<p>30.07.1954</p>
</td>
<td width="165">
<p>HP1 -&gt; 26.06.1997</p>
<p>HP7 -&gt; 21.07.2007</p>
<p>AC -&gt; 20.11.2009</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Andrey and Billiard</h2>
<p>Andrey is the guy who gives us food and drinks at the game bar. He likes to play <strong>billiard</strong>. Since you are nice guy you want to help him play more of his favorite game. You decide to create a program which will help him to take orders faster and generate billing information.</p>
<p>First you will receive an integer - the <strong>amount</strong> of entities with prices (separated by &ldquo;-&rdquo;). Then you will receive a <strong>list</strong> of <strong>clients</strong>. For every customer, you will receive <strong>what</strong> to buy and <strong>how much</strong>. When you receive the command &ldquo;end of clients&rdquo; you should <strong>display information</strong> about every <strong>client</strong> as described below. After that, print how much total money were <strong>spent</strong> while Andrey was playing billiard.</p>
<h3>Constraints</h3>
<ul>
<li>If an entity is added more than once you should <strong>override</strong> the <strong>previous price</strong>.</li>
<li>If a buyer tries to buy an entity that <strong>does not exist</strong> - you should <strong>ignore</strong> that line.</li>
<li>Buyers should be <strong>ordered</strong> by their <strong>name</strong> in <strong>ascending order</strong>.</li>
<li>All <strong>floating-point</strong> digits must be rounded to <strong>2 digits</strong> after the decimal separator.</li>
<li>In the end, <strong>every</strong> buyer&rsquo;s respective <strong>bill</strong> should be <strong>summed</strong>.</li>
<li>The <strong>quantities</strong> will be <strong>integers</strong>. The <strong>prices</strong> will be <strong>floating-point</strong></li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="301">
<p><strong>Input</strong></p>
</td>
<td width="209">
<p><strong>Output</strong></p>
</td>
<td width="184">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="301">
<p>4</p>
<p>Cola-1.25</p>
<p>Sandwich-2.30</p>
<p>Bira-0.01</p>
<p>Bira-2</p>
<p>Toshko-Bira,3</p>
<p>Mira-Sandwich,1</p>
<p>Marto-Kola,2</p>
<p>end of clients</p>
</td>
<td width="209">
<p>Mira</p>
<p>-- Sandwich - 1</p>
<p>Bill: 2.30</p>
<p>Toshko</p>
<p>-- Bira - 3</p>
<p>Bill: 6.00</p>
<p>Total bill: 8.30</p>
</td>
<td width="184">
<p>Bira's price <strong>is</strong> <strong>overwritten</strong>.</p>
<p>Since there is no entity named "Kola"- we should <strong>ignore</strong> that line.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Create</strong> a Dictionary&lt;<strong>string, decimal</strong>&gt; as our <strong>shop</strong> that will contain the <strong>price</strong> for every <strong>entity</strong> in it.</li>
<li>Create class Customer. Every customer should have a <strong>name</strong>, a Dictionary&lt;string, int&gt;, which holds every <strong>bought product</strong> with its <strong>quantity </strong>(something like a ShopList) and a <strong>Bill</strong></li>
<li>Save all customers that their wanted item is <strong>actually in the shop </strong>into a <strong>list</strong>. For every customer go through his &ldquo;shop list&rdquo; and <strong>add</strong> &ldquo;<strong>price*quantity&rdquo;</strong> to his Bill.</li>
<li>For printing every customer, you can iterate through every object:</li>
</ul>
<p><strong>Print</strong> the results.</p>
<h2>8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mentor Group</h2>
<p>You are mentor of a group. You have done your job well and now you have to generate a report about your group's activity. You will be given usernames and dates ("<strong><em>dd/MM/yyyy</em></strong>"), dates (<strong>if any</strong>) are separated with comma, until you receive command "<strong>end of dates</strong>". After that you will receive user and some comment (separated with dash). You can add comment for every user who is <strong>in</strong> your group (if <strong>not</strong> ignore the line). Adding comment/date to same user more than once should <strong>append</strong> to that user the comment/date. Upon receiving command "<strong>end of comments</strong>" you should generate report in format:</p>
<table>
<tbody>
<tr>
<td width="148">
<p>{user}</p>
<p>Comments:</p>
<p>- {firstComment} &hellip;</p>
<p>Dates attended:</p>
<p>-- {firstDate}</p>
<p>-- {secondDate}</p>
</td>
</tr>
</tbody>
</table>
<p>Users should be printed ordered by name (ascending). For every user, their dates should be sorted again in ascending order. Input will be valid and in the format described - you should <strong>not check</strong> it explicitly!</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="280">
<p><strong>Input</strong></p>
</td>
<td width="230">
<p><strong>Output</strong></p>
</td>
<td width="184">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="280">
<p>nakov 22/08/2016,20/08/2016</p>
<p>simeon10 22/08/2016</p>
<p>end of dates</p>
<p>nakov-Excellent algorithmetic thinking.</p>
<p>Gesh4o-Total noob.</p>
<p>end of comments</p>
</td>
<td width="230">
<p>nakov</p>
<p>Comments:</p>
<p>- Excellent algorithmetic thinking.</p>
<p>Dates attended:</p>
<p>-- 20/08/2016</p>
<p>-- 22/08/2016</p>
<p>simeon10</p>
<p>Comments:</p>
<p>Dates attended:</p>
<p>-- 22/08/2016</p>
</td>
<td width="184">
<p>Not that simeon10 has no comments but we still leave the comments section. User Gesh4o does not have attendancy date so he is not registered in your group therefore he is not a part from the report.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Create</strong> a class <strong>Student</strong> with List&lt;string&gt; for comments and List&lt;DateTime&gt; for attendance dates and a name.</li>
<li>You can save all students into a <strong>list</strong> or you can save every student in a <strong>dictionary</strong> where the <strong>key</strong> will be the student&rsquo;s <strong>name</strong> and the <strong>value</strong> will be the <strong>student object</strong></li>
</ul>
<h2>9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Teamwork projects</h2>
<p>It's time for teamwork projects and you are responsible for making the teams. First you will receive an integer - the <strong>count</strong> of the teams you will have to <strong>register</strong>. You will be given a <strong>user</strong> and a <strong>team</strong> (separated with &ldquo;-&rdquo;).&nbsp; The user is the <strong>creator</strong> of that team.</p>
<p>For every newly created team you should <strong>print</strong> a message: "Team {team Name} has been created by {user}!".</p>
<p>Next you will receive user with team (separated with "<em>-&gt;</em>") which means that the user wants to <strong>join</strong> that <strong>team</strong>. Upon receiving the command: &ldquo;end of assignment&rdquo;, you should print <strong>every team</strong>, <strong>ordered</strong> by the <strong>count</strong> of its <strong>members</strong> (<strong>descending</strong>) and then by <strong>name</strong> (<strong>ascending</strong>). For each team, you have to print its members <strong>sorted</strong> by name (<strong>ascending</strong>). However, there are several <strong>rules</strong>:</p>
<ul>
<li>If user tries to <strong>create</strong> a team more than once a message should be displayed:
<ul>
<li>"Team {teamName} was already created!<em>"</em></li>
</ul>
</li>
<li>Creator of a team cannot <strong>create</strong> another team - message should be thrown:
<ul>
<li>"{user} cannot create another team!"</li>
</ul>
</li>
<li>If user tries to <strong>join</strong> currently non-existing team a message should be displayed:
<ul>
<li>"Team {teamName} does not exist!<em>"</em></li>
</ul>
</li>
<li>Member of a team cannot <strong>join</strong> another team - message should be thrown:
<ul>
<li>"Member {user} cannot join team {team Name}!"</li>
</ul>
</li>
<li>In the <strong>end </strong>(<em>after teams' report</em>) teams with <strong>zero</strong> members (with <strong>only a creator</strong>) should <strong>disband</strong>. Every <strong>valid</strong> team should be printed ordered by <strong>name</strong> (ascending) in this format:</li>
</ul>
<table>
<tbody>
<tr>
<td width="120">
<p>"{teamName}:</p>
<p>- {creator}</p>
<p>-- {member}&hellip;"</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="197">
<p><strong>Input</strong></p>
</td>
<td width="395">
<p><strong>Output</strong></p>
</td>
<td width="102">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="197">
<p>2</p>
<p>Didi-PowerPuffsCoders</p>
<p>Toni-Toni is the best</p>
<p>Petq-&gt;PowerPuffsCoders</p>
<p>Toni-&gt;Toni is the best</p>
<p>end of assignment</p>
<p><strong>&nbsp;</strong></p>
</td>
<td width="395">
<p>Team PowerPuffsCoders has been created by Didi!</p>
<p>Team Toni is the best has been created by Toni!</p>
<p>Member Toni cannot join team Toni is the best!</p>
<p>PowerPuffsCoders</p>
<p>- Didi</p>
<p>-- Petq</p>
<p>Teams to disband:</p>
<p>Toni is the best</p>
<p>&nbsp;</p>
</td>
<td width="102">
<p>Toni created a team in which he tried later to join. So message was shown. Since there is no one other who is trying to join his team the team have to <strong>disband</strong>.</p>
</td>
</tr>
<tr>
<td width="197">
<p>3</p>
<p>Tatyana-CloneClub</p>
<p>Helena-CloneClub</p>
<p>Trifon-AiNaBira</p>
<p>Pesho-&gt;aiNaBira</p>
<p>Pesho-&gt;AiNaBira</p>
<p>Tatyana-&gt;Leda</p>
<p>PeshO-&gt;AiNaBira</p>
<p>Cossima-&gt;CloneClub</p>
<p>end of assignment</p>
</td>
<td width="395">
<p>Team CloneClub has been created by Tatyana!</p>
<p>Team CloneClub was already created!</p>
<p>Team AiNaBira has been created by Trifon!</p>
<p>Team aiNaBira does not exist!</p>
<p>Team Leda does not exist!</p>
<p>AiNaBira</p>
<p>- Trifon</p>
<p>-- Pesho</p>
<p>-- PeshO</p>
<p>CloneClub</p>
<p>- Tatyana</p>
<p>-- Cossima</p>
<p>Teams to disband:</p>
</td>
<td width="102">
<p>Note that when you join a team you should check <strong>first</strong> if it exists, <strong>then</strong> check if the user is already in a team:</p>
<p>&nbsp;</p>
<p>Tatyana has created CloneClub, then she tries to join a non-existing team &ndash; so message for non-existing team is shown.</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li><strong>Create</strong> a class <strong>Team</strong> with name, List&lt;<strong>string</strong>&gt; for members and again name but his time for the creator.</li>
<li>Based on this you can have a List&lt;Team&gt; where you can safely <strong>check</strong> for every condition described above.</li>
<li><strong>After</strong> populating the teams, you can <strong>filter</strong> them into two <strong>separate</strong> collections (one for the teams with only a creator in it and another for the rest)</li>
</ul>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Student Groups</h2>
<p>At the Software University, we often organize programming courses for beginners in different towns. We usually run a <strong>registration form</strong> and after the registration finishes, we distribute the <strong>students</strong> into <strong>study groups</strong>. Groups have different sizes in each town.</p>
<p>You are given a report holding the <strong>registrations for each town</strong> and the <strong>lab capacity</strong> (seats count) for each town. It comes in the following format:</p>
<ul>
<li><strong>Town name</strong> =&gt; <strong>X</strong> seats (where <strong>X</strong> is the capacity of the training lab in this town).
<ul>
<li><strong>Student name</strong> | <strong>student email</strong> | <strong>registration</strong> <strong>date</strong> (in format day-month-year). The month name is given as 3 letters in English, e.g. &ldquo;May&rdquo;, &ldquo;Aug&rdquo; or &ldquo;Nov&rdquo;.</li>
<li>The next student come after the first, etc.</li>
</ul>
</li>
<li>Then the next town and its students come, etc.</li>
<li>The input ends by a line holding &ldquo;<strong>End</strong>&rdquo;.</li>
</ul>
<p>The <strong>input</strong> comes in the following structure:</p>
<table width="0">
<tbody>
<tr>
<td width="612">
<p>Town1 =&gt; X seats</p>
<p>Student1 Name | student1_email@somewhere.com | day-month-year</p>
<p>Student2 Name | student2_email@somewhere.com | day-month-year</p>
<p>Student3 Name | student3_email@somewhere.com | day-month-year</p>
<p>&hellip;</p>
<p>Town2 =&gt; X seats</p>
<p>Student1 Name | student1_email@somewhere.com | day-month-year</p>
<p>Student2 Name | student2_email@somewhere.com | day-month-year</p>
<p>&hellip;</p>
<p>End</p>
</td>
</tr>
</tbody>
</table>
<p>Your task is to <strong>create </strong>and<strong> print the study groups</strong> for each town as follows:</p>
<ul>
<li>For <strong>each town</strong> create and print one or several <strong>study groups</strong> (depends of the number or registered students and the capacity of the lab in this town).</li>
<li>For each town <strong>order the students</strong> by registration date (ascending), then by name (ascending) then by email (ascending), then fill them into groups. If the students are less or equal to the lab capacity, create only one group. When the students are more than the lab capacity, distribute them in multiple groups.</li>
<li>Print all <strong>groups ordered by town</strong> (ascending) in the following format:
<ul>
<li><strong>Created G groups and T towns:</strong></li>
<li><strong>Town1 =&gt; email1, email2, &hellip;</strong></li>
<li><strong>Town1 =&gt; email1, email2, &hellip;</strong></li>
<li>&hellip;</li>
<li><strong>Town2 =&gt; email1, email2, &hellip;</strong></li>
<li>&hellip;</li>
</ul>
</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="692">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="692">
<p><strong>Plovdiv</strong> =&gt; <strong>5</strong> seats</p>
<p>Ani Kirilova&nbsp;&nbsp; |ani88@abv.bg&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |27-May-2016</p>
<p>Todor Nikolov &nbsp;| tod92@mente.org &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 28-May-2016</p>
<p>Kiril Stoyanov | &nbsp;kirtak@gmail.com &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 27-May-2016</p>
<p>Stefka Petrova | &nbsp;&nbsp;st96@abv.bg&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 26-May-2016</p>
<p>Ani Kirilova&nbsp;&nbsp; | &nbsp;&nbsp;&nbsp;&nbsp;ani.k@yahoo.co.uk&nbsp;&nbsp; | 27-May-2016</p>
<p>Ivan Ivanov &nbsp;&nbsp;&nbsp;| &nbsp;ivan.i.ivanov@gmail.com| 27-May-2016</p>
<p><strong>Veliko Tarnovo</strong> =&gt; <strong>3</strong> seats</p>
<p>Petya Stoyanova | stoyanova_p@abv.bg &nbsp;&nbsp;&nbsp;| 27-May-2016</p>
<p>Stoyan Kirilov &nbsp;| 100yan@gmail.com &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 24-May-2016</p>
<p>Didi Miteva &nbsp;&nbsp;&nbsp;&nbsp;| miteva_d@yahoo.co.uk &nbsp;| 28-May-2016</p>
<p>Kiril Nikolov &nbsp;&nbsp;| kiro@kiro.net &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 25-May-2016</p>
<p>Ivan Stefanov &nbsp;&nbsp;| ivan.stef86@gmail.com | 27-May-2016</p>
<p>Maria Kirova &nbsp;&nbsp;&nbsp;| maria.k@abv.bg &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 26-May-2016</p>
<p><strong>Varna</strong> =&gt; <strong>2</strong> seats</p>
<p>Ivan Ivanov &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| ivan.ivanov96@gmail.com| 29-May-2016</p>
<p>Stoyan Petrov &nbsp;&nbsp;&nbsp;| sto.sto.sto@gmail.com&nbsp; | 27-May-2016</p>
<p>Ivan Ivanov &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| vankata@mail.bg &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 1-Jun-2016</p>
<p>Kiril Anev &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| anev_k@yahoo.co.uk &nbsp;&nbsp;&nbsp;&nbsp;| 27-May-2016</p>
<p>Ivan Ivanov &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| vanyo98@abv.bg &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 29-May-2016</p>
<p>Petya Vladimirova|pete98@abv.bg &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| 20-May-2016</p>
<p>Ivan Ivanov &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;| ivan.94.ivan@gmail.com | 29-May-2016</p>
<p><strong>End</strong></p>
</td>
</tr>
<tr>
<td width="692">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="692">
<p>Created <strong>8</strong> groups in <strong>3</strong> towns:</p>
<p>Plovdiv =&gt; st96@abv.bg, ani.k@yahoo.co.uk, ani88@abv.bg, ivan.i.ivanov@gmail.com, kirtak@gmail.com</p>
<p>Plovdiv =&gt; tod92@mente.org</p>
<p>Varna =&gt; pete98@abv.bg, anev_k@yahoo.co.uk</p>
<p>Varna =&gt; sto.sto.sto@gmail.com, ivan.94.ivan@gmail.com</p>
<p>Varna =&gt; ivan.ivanov96@gmail.com, vanyo98@abv.bg</p>
<p>Varna =&gt; vankata@mail.bg</p>
<p>Veliko Tarnovo =&gt; 100yan@gmail.com, kiro@kiro.net, maria.k@abv.bg</p>
<p>Veliko Tarnovo =&gt; ivan.stef86@gmail.com, stoyanova_p@abv.bg, miteva_d@yahoo.co.uk</p>
</td>
</tr>
<tr>
<td width="692">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="692">
<p><strong>Plovdiv (group 1 &ndash; 5/5 students)</strong></p>
<p>Stefka Petrova | st96@abv.bg | 26-May-2016</p>
<p>Ani Kirilova | ani.k@yahoo.co.uk | 27-May-2016</p>
<p>Ani Kirilova | ani88@abv.bg | 27-May-2016</p>
<p>Ivan Ivanov | ivan.i.ivanov@gmail.com | 27-May-2016</p>
<p>Kiril Stoyanov | kirtak@gmail.com | 27-May-2016</p>
<p><strong>Plovdiv (group 2 &ndash; 1/5 students)</strong></p>
<p>Todor Nikolov | tod92@mente.org | 28-May-2016</p>
<p><strong>Varna (group 1 &ndash; 2/2 students)</strong></p>
<p>Petya Vladimirova | pete98@abv.bg | 20-May-2016</p>
<p>Kiril Anev | anev_k@yahoo.co.uk | 27-May-2016</p>
<p><strong>Varna (group 2 &ndash; 2/2 students)</strong></p>
<p>Stoyan Petrov | sto.sto.sto@gmail.com | 27-May-2016</p>
<p>Ivan Ivanov | ivan.94.ivan@gmail.com | 29-May-2016</p>
<p><strong>Varna (group 3 &ndash; 2/2 students)</strong></p>
<p>Ivan Ivanov | ivan.ivanov96@gmail.com | 29-May-2016</p>
<p>Ivan Ivanov | vanyo98@abv.bg | 29-May-2016</p>
<p><strong>Varna (group 4 &ndash; 1/2 students)</strong></p>
<p>Ivan Ivanov | vankata@mail.bg | 1-Jun-2016</p>
<p><strong>Veliko Tarnovo (group 1 &ndash; 3/3 students)</strong></p>
<p>Stoyan Kirilov | 100yan@gmail.com | 24-May-2016</p>
<p>Kiril Nikolov | kiro@kiro.net | 25-May-2016</p>
<p>Maria Kirova | maria.k@abv.bg | 26-May-2016</p>
<p><strong>Veliko Tarnovo (group 2 &ndash; 3/3 students)</strong></p>
<p>Ivan Stefanov | ivan.stef86@gmail.com | 27-May-2016</p>
<p>Petya Stoyanova | stoyanova_p@abv.bg | 27-May-2016</p>
<p>Didi Miteva | miteva_d@yahoo.co.uk | 28-May-2016</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>First, create the <strong>classes</strong> to hold the <strong>students</strong>, <strong>towns</strong> and <strong>groups</strong>.</p>
<h4>Creating Classes Student, Town and Group</h4>
<p>The class Student will hold the information about a student: name, email and date of registration.</p>
<p>The class Town will hold the information about a town holding a list of registered students.</p>
<p>The class Groups will hold the information about a group holding a subset of the students for certain town.</p>
<h4>Read the Input</h4>
<p>The next step is to <strong>read and parse the input</strong> to list of towns, each holding a list of students. Write a method to read the input from the console:</p>
<p>In a loop, read a text line inputLine from the console, until &ldquo;<strong>End</strong>&rdquo; is reached.</p>
<p>For each input line check whether the input line contains &ldquo;<strong>=&gt;</strong>&rdquo;.</p>
<ul>
<li>If yes &agrave; inputLine holds a <strong>town</strong>, e.g. &ldquo;Plovdiv =&gt; 5 seats&rdquo;.
<ul>
<li>Create a new Town</li>
<li>Parse the town <strong>name</strong> and <strong>seats count</strong> from the input line and put them in the town.</li>
<li>Assign an empty student list for the new town:<br /> Students = new List&lt;Student&gt;().</li>
<li>Add the new town to the list of towns.</li>
</ul>
</li>
<li>If no &agrave; inputLine holds a <strong>student</strong>, e.g. &ldquo;Ani Kirilova | ani.k@yahoo.co.uk | 27-May-2016&rdquo;.
<ul>
<li>Create a new Student</li>
<li>Parse the student <strong>name</strong>, <strong>email</strong> and <strong>date</strong> from the input line and put them in the student.</li>
<li>Append the new student to the list of students for the last town in the towns list.</li>
</ul>
</li>
</ul>
<h4>Distribute the Students into Groups</h4>
<p>Now, solve the essential part of the problem: for each town, create <strong>one or several groups</strong> and distribute the students between them.</p>
<p>Start from an empty method that takes as <strong>input</strong> a <strong>list of towns</strong> and produces as <strong>output</strong> a <strong>list of groups</strong>:</p>
<p>How to distribute the students?</p>
<p>In a <strong>loop</strong> go through the <strong>towns, sorted by name</strong>.</p>
<ul>
<li>For each town <strong>order the students</strong> by registration date, name and email.</li>
<li>For each town put the first SeatsCount students in the first group, the next Town.SeatsCount students in the second group, etc.</li>
</ul>
<p>You may use code like this or write it yourself:</p>
<h4>Print the Groups</h4>
<p>Once the students are distributed into groups, <strong>printing the output</strong> is the easiest part of this problem.</p>
<ul>
<li>Print the <strong>total count of groups</strong> and total <strong>count of towns </strong>(distinct town names).</li>
<li>Loop through the <strong>groups, sorted by town name</strong>.</li>
<li>For each group <strong>print</strong> its <strong>name</strong> and the <strong>emails</strong> of its students, joined by &ldquo;, &rdquo;.</li>
</ul>
