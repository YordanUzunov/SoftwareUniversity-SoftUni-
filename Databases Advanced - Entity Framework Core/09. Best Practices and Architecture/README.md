<h1>Exercises: Advanced Querying</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h1>BookShop System</h1>
<p>For the following tasks, use the <a href="http://svn.softuni.org/admin/svn/csharp-databases/2017-Sept/DB-Advanced-EF-Core/06.%20DB-Advanced-EF-Core-Advanced-Querying/BookShop.zip">BookShop</a> database. You can download the complete project or create it yourself in <strong>task 0</strong>, but you should still use the pre-defined Seed() method from the project to have the same <strong>sample</strong> data.</p>
<h2>0.&nbsp;&nbsp; Book Shop Database</h2>
<p>You must create a <strong>database</strong> for a <strong>book</strong> <strong>shop</strong> <strong>system</strong>. It should look like this:</p>
<h3>Constraints</h3>
<ul>
<li>
<h1>Exercises: Best Practices and Architecture</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h1>Best Practices and Architecture</h1>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Photo Share System</h2>
<p>You are given a project <a href="http://svn.softuni.org/admin/svn/DB-Fundamentals/DB-Advanced-EntityFramework/Feb-2017/08.%20DB-Advanced-EntityFramework-Best%20Practices-and-Architecture/08.%20DB-Advanced-EntityFramework-Best-Practices-and-Architecture-PhotoShare-Skeleton.zip">skeleton</a> of a <strong>Photo Sharing System</strong>. Take a look at it to get more familiar with that project. &nbsp;The database is modeled by code first approach and the models are fine (in other words there is nothing to modify in PhotoShare.Models project).</p>
<p>But the other projects PhotoShare.Client and PhotoShare.Service are poorly written. Your task is to <strong>improve the architecture of the project.</strong> Seed some data in the database.</p>
<p>Then <strong>implement the missing commands</strong> by the hints given in each command class and <strong>fix any bugs</strong> in the already implemented code.</p>
<h3>System functionality</h3>
<p>The photo share system contains the following commands:</p>
<ul>
<li><strong>Register</strong><strong>User &lt;username&gt; &lt;password&gt; &lt;repeat-password&gt; &lt;email&gt;<br /> </strong>Registers a new user.</li>
</ul>
<table>
<tbody>
<tr>
<td width="120">
<p><strong>Case</strong></p>
</td>
<td width="224">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="120">
<p>Success</p>
</td>
<td width="224">
<p>User [username] was registered successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="120">
<p>Passwords do not match</p>
</td>
<td width="224">
<p>Passwords do not match!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="120">
<p>Username is taken</p>
</td>
<td width="224">
<p>Username [username] is already taken!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<p>Any other validation is already implemented and it should stay as is.</p>
<ul>
<li><strong>AddTown &lt;town Name&gt; &lt;country Name&gt;</strong></li>
</ul>
<p>Adds new&nbsp; town. Town names must be unique.</p>
<table>
<tbody>
<tr>
<td width="119">
<p><strong>Case</strong></p>
</td>
<td width="241">
<p><strong>Message</strong></p>
</td>
<td width="158">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>Success</p>
</td>
<td width="241">
<p>Town [town] was added successfully!</p>
</td>
<td width="158">
<p>None</p>
</td>
</tr>
<tr>
<td width="119">
<p>Town already exists</p>
</td>
<td width="241">
<p>Town [town] was already added!</p>
</td>
<td width="158">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<p>Any other validation is already implemented and it should stay as is.</p>
<ul>
<li><strong>ModifyUser &lt;username&gt; &lt;property&gt; &lt;new value&gt;<br /> </strong>Modifies current user.</li>
</ul>
<table>
<tbody>
<tr>
<td width="117">
<p><strong>Case</strong></p>
</td>
<td width="245">
<p><strong>Message</strong></p>
</td>
<td width="156">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="117">
<p>Success</p>
</td>
<td width="245">
<p>User [user] [property] is [value].</p>
</td>
<td width="156">
<p>None</p>
</td>
</tr>
<tr>
<td width="117">
<p>User does not exist</p>
</td>
<td width="245">
<p>User [username] not found!</p>
</td>
<td width="156">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="117">
<p>Property not found</p>
</td>
<td width="245">
<p>Property [property] not supported!</p>
</td>
<td width="156">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="117">
<p>Value not valid for that property</p>
</td>
<td width="245">
<p>Value [value] not valid.</p>
<p>[DetailedMessage]</p>
</td>
<td width="156">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>The above command may be executed in the following formats:</p>
<p>ModifyUser &lt;username&gt; Password &lt;NewPassword&gt;</p>
<ul>
<li>Password must contain at least one lowercase letter and digit. If not:
<ul>
<li>Detailed Message - &ldquo;Invalid Password&rdquo;</li>
</ul>
</li>
</ul>
<p>ModifyUser &lt;username&gt; BornTown &lt;newBornTownName&gt;</p>
<ul>
<li>Town must exist in database. If not:
<ul>
<li>Detailed Message &ndash; &ldquo;Town [town] not found!&rdquo;</li>
</ul>
</li>
</ul>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ModifyUser &lt;username&gt; CurrentTown &lt;newCurrentTownName&gt;</p>
<ul>
<li>Town must exist in database. If not:
<ul>
<li>Detailed Message &ndash; &ldquo;Town [town] not found!&rdquo;</li>
</ul>
</li>
</ul>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Any other format different than from all the above formats is invalid.</p>
<ul>
<li><strong>DeleteUser &lt;username&gt;<br /> </strong>Deletes a user.</li>
</ul>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>Case</strong></p>
</td>
<td width="230">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>Success</p>
</td>
<td width="230">
<p>User [username] was deleted successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="114">
<p>User does not exist</p>
</td>
<td width="230">
<p>User [username] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="114">
<p>User is already deleted</p>
</td>
<td width="230">
<p>User [username] is already deleted!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AddTag &lt;tag&gt;<br /> </strong>Adds a tag. Tag names should be unique.</li>
</ul>
<table>
<tbody>
<tr>
<td width="119">
<p><strong>Case</strong></p>
</td>
<td width="241">
<p><strong>Message</strong></p>
</td>
<td width="158">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="119">
<p>Success</p>
</td>
<td width="241">
<p>Tag [tag] was added successfully!</p>
</td>
<td width="158">
<p>None</p>
</td>
</tr>
<tr>
<td width="119">
<p>Tag already exists</p>
</td>
<td width="241">
<p>Tag [tag] exists!</p>
</td>
<td width="158">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<p>Tag validation is already implemented and should stay as is.</p>
<ul>
<li><strong>CreateAlbum &lt;username&gt; &lt;albumTitle&gt; &lt;BgColor&gt; &lt;tag1&gt; &lt;tag2&gt;...&lt;tagN&gt;<br /> </strong>Adds an album. Album names should be unique.</li>
</ul>
<table>
<tbody>
<tr>
<td width="127">
<p><strong>Case</strong></p>
</td>
<td width="234">
<p><strong>Message</strong></p>
</td>
<td width="157">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="127">
<p>Success</p>
</td>
<td width="234">
<p>Album [Album] successfully created!</p>
</td>
<td width="157">
<p>None</p>
</td>
</tr>
<tr>
<td width="127">
<p>User does not exist</p>
</td>
<td width="234">
<p>User [username] not found!</p>
</td>
<td width="157">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="127">
<p>Album does exist</p>
</td>
<td width="234">
<p>Album [album] exists!</p>
</td>
<td width="157">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="127">
<p>Background color does not exist</p>
</td>
<td width="234">
<p>Color [color] not found!</p>
</td>
<td width="157">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="127">
<p>If any tag is not found in database</p>
</td>
<td width="234">
<p>Invalid tags!</p>
</td>
<td width="157">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AddTagTo &lt;album&gt; &lt;tag&gt;<br /> </strong>Adds a tag.</li>
</ul>
<table>
<tbody>
<tr>
<td width="121">
<p><strong>Case</strong></p>
</td>
<td width="238">
<p><strong>Message</strong></p>
</td>
<td width="159">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="121">
<p>Success</p>
</td>
<td width="238">
<p>Tag [tag] added to [album]!</p>
</td>
<td width="159">
<p>None</p>
</td>
</tr>
<tr>
<td width="121">
<p>Album or tag does not exist</p>
</td>
<td width="238">
<p>Either tag or album do not exist!</p>
</td>
<td width="159">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AddFriend &lt;username1&gt; &lt;username2&gt;<br /> </strong>The first user adds the second one as a <a href="http://orig13.deviantart.net/006e/f/2013/297/c/6/lol_amumu_by_enzanblues456-d6rnrta.jpg">friend</a>. :)</li>
</ul>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>Case</strong></p>
</td>
<td width="230">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>Success</p>
</td>
<td width="230">
<p>Friend [username2] added to [username1]</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="114">
<p>Any of the users do not exist.</p>
</td>
<td width="230">
<p>[user*] not found!<br /> <em>*Pick the first not existing possible user</em></p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="114">
<p>They are already friends</p>
</td>
<td width="230">
<p>[username2] is already a friend to [username1]</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AcceptFriend &lt;username1&gt; &lt;username2&gt;<br /> <br /> </strong></li>
</ul>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>Case</strong></p>
</td>
<td width="230">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>Success</p>
</td>
<td width="230">
<p>[username1] accepted [username2] as a friend</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="114">
<p>Any of the users do not exist.</p>
</td>
<td width="230">
<p>[user*] not found!<br /> <em>*Pick the first not existing possible user</em></p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="114">
<p>They are already friends</p>
</td>
<td width="230">
<p>[username2] is already a friend to [username1]</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="114">
<p>There is no such friend request</p>
</td>
<td width="230">
<p>[username2] has not added [username1] as a friend</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>ListFriends &lt;username&gt;<br /> </strong>List usernames of all friends for given user sorted alphabetically.</li>
</ul>
<table>
<tbody>
<tr>
<td width="118">
<p><strong>Case</strong></p>
</td>
<td width="242">
<p><strong>Message</strong></p>
</td>
<td width="158">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="118">
<p>Success</p>
</td>
<td width="242">
<p>Friends:</p>
<p>-[username1]</p>
<p>&hellip;</p>
<p>-[usernameN]</p>
</td>
<td width="158">
<p>None</p>
</td>
</tr>
<tr>
<td width="118">
<p>User does not have any friends.</p>
</td>
<td width="242">
<p>No friends for this user. :(</p>
</td>
<td width="158">
<p>None</p>
</td>
</tr>
<tr>
<td width="118">
<p>User does not exist</p>
</td>
<td width="242">
<p>User [user] not found!</p>
</td>
<td width="158">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>ShareAlbum &lt;albumId&gt; &lt;username&gt; &lt;permission&gt;<br /> </strong>Makes specified user to be part of given album.</li>
</ul>
<table width="0">
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="352">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="352">
<p>Username [user] added to album [album] ([permission])</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Album does not exist</p>
</td>
<td width="352">
<p>Album [albumId] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not exist</p>
</td>
<td width="352">
<p>User [user] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Permission not valid</p>
</td>
<td width="352">
<p>Permission must be either &ldquo;Owner&rdquo; or &ldquo;Viewer&rdquo;!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>UploadPicture &lt;albumName&gt; &lt;pictureTitle&gt; &lt;pictureFilePath&gt;<br /> </strong>Creates picture and atteches it to specified album</li>
</ul>
<table>
<tbody>
<tr>
<td width="121">
<p><strong>Case</strong></p>
</td>
<td width="238">
<p><strong>Message</strong></p>
</td>
<td width="159">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="121">
<p>Success</p>
</td>
<td width="238">
<p>Picture [picture] added to [album]!</p>
</td>
<td width="159">
<p>None</p>
</td>
</tr>
<tr>
<td width="121">
<p>Album does not exist</p>
</td>
<td width="238">
<p>Album [Album] not found!</p>
</td>
<td width="159">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Exit<br /> </strong>Exits application.</li>
</ul>
<table>
<tbody>
<tr>
<td width="125">
<p><strong>Case</strong></p>
</td>
<td width="251">
<p><strong>Message</strong></p>
</td>
<td width="142">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Success</p>
</td>
<td width="251">
<p>Good Bye!</p>
</td>
<td width="142">
<p>None</p>
</td>
</tr>
</tbody>
</table>
<p>If command is <strong>NOT</strong> in format specified above (either command name is wrong or input arguments count) throw InvalidOperationException with message: &ldquo;Command &lt;CommandName&gt; not valid!&rdquo;.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="448">
<p><strong>Input</strong></p>
</td>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="448">
<p>RegisterUser admin abc123 abc123 user@softuni.bg</p>
<p>ModifyUser admin BornTown Sofia</p>
<p>AddTown Sofia Bulgaria</p>
<p>ModifyUser admin BornTown Sofia</p>
<p>UploadPicture Nature Vitosha C://Pictures/Vitosha.png</p>
<p>CreateAlbum admin Nature Magenta nature</p>
<p>AddTag nature</p>
<p>CreateAlbum admin Nature Magenta nature</p>
<p>UploadPicture Nature Vitosha C://Pictures/Vitosha.png</p>
<p>Exit</p>
<p>&nbsp;</p>
</td>
<td width="310">
<p>User admin was registered successfully!</p>
<p>Value Sofia not valid!<br /> Town Sofia not found!</p>
<p>Town Sofia was added successfully!</p>
<p>User admin BornTown is Sofia.</p>
<p>Album Nature not found!</p>
<p>Invalid tags!</p>
<p>Tag #nature was added successfully!</p>
<p>Album Nature successfully created!</p>
<p>Picture Vitosha added to Nature!</p>
<p>Good Bye!</p>
</td>
</tr>
<tr>
<td width="448">
<p>RegisterUser peter pan123 pan123 peter@pan.com</p>
<p>RegisterUser peter aaa a123 pesho@pan.com</p>
<p>RegisterUser capt hook123 hook123 capitan@hook.com</p>
<p>AddFriend peterr capp</p>
<p>AddFriend peter capp</p>
<p>AddFriend peter capt</p>
<p>RegisterUser jack jack123 jack123 jack@j.com</p>
<p>AddFriend peter jack</p>
<p>AcceptFriend jack peter</p>
<p>AcceptFriend capt peter</p>
<p>PrintFriendsList peter</p>
<p>RegisterUser user</p>
<p>Exit</p>
</td>
<td width="310">
<p>User peter was registered successfully!</p>
<p>Username peter is already taken!</p>
<p>User capt was registered successfully!</p>
<p>User peterr not found!</p>
<p>User capp not found!</p>
<p>Friend peter added to capt!</p>
<p>User jack was registered successfully!</p>
<p>Friend peter added to jack!</p>
<p>Friend jack accepted peter as friend</p>
<p>Friend capt accepted peter as friend</p>
<p>Friends</p>
<p>-capt</p>
<p>-jack</p>
<p>Command RegisterUser not valid!</p>
<p>Good Bye!</p>
</td>
</tr>
<tr>
<td width="448">
<p>RegisterUser tomCat tom123 tom123 tom@t.com</p>
<p>RegisterUser jerry jerry123 jerry123 jerry@j.com</p>
<p>RegisterUser butch butch123 butch123 butch@b.com</p>
<p>AddTag #cartoon</p>
<p>CreateAlbum tomCat Tom&amp;Jerry Blue cartoon</p>
<p>ShareAlbum 1 jerry Owner</p>
<p>AddTag #childhood</p>
<p>AddTagTo Tom&amp;Jerry childhood</p>
<p>Exit</p>
</td>
<td width="310">
<p>User tom was registered successfully!</p>
<p>User jerry was registered successfully!</p>
<p>User jerry was registered successfully!</p>
<p>Tag #cartoon was added successfully!</p>
<p>Album Tom&amp;Jerry successfully created!</p>
<p>Username jerry added to album Tom&amp;Jerry (Owner)</p>
<p>Tag #childhood was added successfully!</p>
<p>Tag #childhood added to Tom&amp;Jerry!</p>
<p>Good Bye!</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Extend Photo Share System</h2>
<p>Extend the <strong>Photo Share System</strong> by implementing two more commands:</p>
<ul>
<li><strong>Login &lt;username&gt; &lt;password&gt;</strong><strong><br /> </strong>Logs a user into the system and keep a reference to it until the &ldquo;Logout&rdquo; command is called.</li>
</ul>
<table>
<tbody>
<tr>
<td width="123">
<p><strong>Case</strong></p>
</td>
<td width="238">
<p><strong>Message</strong></p>
</td>
<td width="157">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="123">
<p>Success</p>
</td>
<td width="238">
<p>User [username] successfully logged in!</p>
</td>
<td width="157">
<p>None</p>
</td>
</tr>
<tr>
<td width="123">
<p>Either user does not exist or password does not match</p>
</td>
<td width="238">
<p>Invalid username or password!</p>
</td>
<td width="157">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="123">
<p>User has logged in already</p>
</td>
<td width="238">
<p>You should logout first!</p>
</td>
<td width="157">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Logout</strong><strong><br /> </strong>Logs out a user from the system.</li>
</ul>
<table>
<tbody>
<tr>
<td width="115">
<p><strong>Case</strong></p>
</td>
<td width="229">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="115">
<p>Success</p>
</td>
<td width="229">
<p>User [username] successfully logged out!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="115">
<p>There is no user logged in.</p>
</td>
<td width="229">
<p>You should log in first in order to logout.</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Modify all commands accordingly</strong>.</p>
<p>Logged user can:</p>
<ul>
<li>Modify his own profile</li>
<li>Add friends to himself</li>
<li>Add tag</li>
<li>Add town</li>
<li>Create an album (only if he is owner of the album)</li>
<li>Share an album (only if he is owner of the album)</li>
<li>Upload picture (only if he is owner of the album that picture is uploaded to)</li>
<li>Add tag to album (only if he is owner of the album)</li>
<li>Delete user (can delete only himself/herself)</li>
<li>List friends of any user</li>
<li>Logout</li>
</ul>
<p>Non-logged user can:</p>
<ul>
<li>List friends of any user</li>
<li>Register</li>
<li>Login</li>
</ul>
<p>If any of these rules are violated print: &ldquo;Invalid credentials!&rdquo; and throw InvalidOperationException.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="414">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="414">
<p>RegisterUser thor tor123 tor123 tor@t.com</p>
<p>Login thor tor1234</p>
<p>Login thor tor123</p>
<p>Login thor tor123</p>
<p>AddTag thunder</p>
<p>RegisterUser loki loki123 loki123 loki@l.com</p>
<p>Logout</p>
<p>RegisterUser loki loki123 loki123 loki@l.com</p>
<p>Login loki loki123</p>
<p>Exit</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
<td width="312">
<p>User thor was registered successfully!</p>
<p>Invalid username or password!<br /> User thor successfully logged in!</p>
<p>Invalid Credentials!</p>
<p>Tag #thunder was added successfully!</p>
<p>Invalid Credentials!</p>
<p>User tor successfully logged out!</p>
<p>User loki was registered successfully! <br /> User loki successfully logged in!</p>
<p>Good Bye!</p>
</td>
</tr>
<tr>
<td width="414">
<p>AddTown Asgard Asgard</p>
<p>RegisterUser loki loki123 loki123 loki@l.com</p>
<p>RegisterUser thor tor123 tor123 tor@t.com</p>
<p>Login thor tor123</p>
<p>AddTown Asgard Asgard</p>
<p>ModifyUser thor CurrentTown Asgard</p>
<p>ModifyUser loki CurrentTown Asgard</p>
<p>MakeFriends thor loki</p>
<p>MakeFriends loki thor</p>
<p>CreateAlbum thor TalesOfAsgard Black</p>
<p>CreateAlbum loki FalseGod Black</p>
<p>ShareAlbum 1 loki Viewer</p>
<p>UploadPicture TalesOfAsgard Thor D:\\images\thor.png</p>
<p>AddTag thunder</p>
<p>AddTagTo TalesOfAsgard thunder</p>
<p>ListFriends thor</p>
<p>ListFriends loki</p>
<p>DeleteUser thor</p>
<p>DeleteUser loki</p>
<p>Logout</p>
<p>RegisterUser odin odin123 odin123 odin@d.com</p>
<p>Login loki loki123</p>
<p>ShareAlbum 1 odin Owner</p>
<p>UploadPicture TalesOfAsgard Loki D:\\images\loki.png</p>
<p>AddTag #destruction</p>
<p>AddTagTo TalesOfAsgard #destruction</p>
<p>Exit</p>
</td>
<td width="312">
<p>Invalid credentials!</p>
<p>User loki was registered successfully!</p>
<p>User thor was registered successfully!</p>
<p>User thor successfully logged in!</p>
<p>Town Asgard was added successfully!</p>
<p>User thor CurrentTown is Asgard.</p>
<p>Invalid credentials!</p>
<p>Friend loki added to thor!</p>
<p>Invalid credentials!</p>
<p>Album TalesOfAsgard successfully created!</p>
<p>Invalid credentials!</p>
<p>User loki added to album TalesOfAsgard(Viewer)</p>
<p>Picture Thor added to TalesOfAsgard!</p>
<p>Tag #thunder was added successfully!</p>
<p>Tag #thunder added to TalesOfAsgard!</p>
<p>Friends:</p>
<p>-loki</p>
<p>No friends for this user. :(</p>
<p>User thor was deleted successfully!</p>
<p>Invalid credentials!</p>
<p>User thor successfully logged out!</p>
<p>User odin was registered successfully!</p>
<p>User loki successfully logged in!</p>
<p>Invalid credentials!</p>
<p>Invalid credentials!</p>
<p>Tag #destruction was added successfully!</p>
<p>Invalid credentials!</p>
<p>Good Bye!</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; *Bus Tickets System</h2>
<p>Your task is to design a database for <strong>Bus Tickets System</strong> using the <strong>code first </strong>approach. The database should keep information about:</p>
<ul>
<li><strong>bus companies</strong> - name, nationality, rating</li>
<li><strong>tickets </strong>- price, seat, customer, trip</li>
<li><strong>customers</strong> - first name, last name, date of birth, gender, home town</li>
<li><strong>trips</strong> - departure time, arrival time, status, origin bus station, destination bus station, bus company</li>
<li><strong>bus stations</strong> - name, town</li>
<li><strong>towns </strong>- name, country</li>
<li><strong>reviews </strong>- content, grade, bus station, customer, date and time of publishing</li>
<li><strong>bank accounts</strong> - account number, balance, customer</li>
</ul>
<p>Each ticket is bought from a customer for a certain trip. A customer has only one home town. Every trip has an origin and a destination, a bus station and it is organized by only one bus company. A bus station is located in only one town and one town can have many bus stations in it. Reviews are written for a certain bus company and a bus company can have many reviews. One customer can write many reviews but a single review can be written only by one customer. Bank account can be owned by one customer and each customer can own only one bank account.</p>
<p>Gender can be only male, female or not specified. The status of the trip can be departed, arrived, delayed or cancelled. Grade of a review can any be a floating-point number in range [1, 10].</p>
<p>When database is up and running <strong>seed</strong> it with some <strong>sample records in each table</strong>.</p>
<p>Now let&rsquo;s <strong>make a command line application</strong> that would <strong>use that database and provide the following functionalities</strong>:</p>
<ul>
<li><strong>print information for trips for a given bus station &ndash; </strong>Print a list of arrivals and departures buses for given bus station id in the format provided below</li>
<li><strong>buy ticket &ndash; </strong>Insert new ticket and reduce the balance from customers&rsquo; bank account. Consider managing all cases such as the customer does not have enough money in his/her bank account.</li>
<li><strong>publish review &ndash; </strong>insert new review from given user into the database</li>
<li><strong>print reviews &ndash; </strong>print a list of reviews for a given bus company in the format provided below</li>
</ul>
<table width="0">
<tbody>
<tr>
<td width="310">
<p><strong>Command</strong></p>
</td>
<td width="390">
<p><strong>Successful Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>print-info {Bus Station ID}</p>
</td>
<td width="390">
<p>{Bus Station Name}, {Town}</p>
<p>Arrivals:</p>
<p>From {origin station} | Arrive at: {Arrival Time} | Status: {status}</p>
<p>Departures:</p>
<p>To {destination station} | Depart at: {Departure Time} | Status {status}</p>
</td>
</tr>
<tr>
<td width="310">
<p>buy-ticket {customer ID} {Trip ID} {Price} {Seat}</p>
</td>
<td width="390">
<p>Customer {Full Name} bought ticket for trip {Trip ID} for {Price} on seat {Seat}</p>
</td>
</tr>
<tr>
<td width="310">
<p>publish-review {Customer ID} {Grade} {Bus Company Name} {Content}</p>
</td>
<td width="390">
<p>Customer {Full Name} published review for company {Company Name}</p>
</td>
</tr>
<tr>
<td width="310">
<p>print-reviews {Bus Company ID}</p>
</td>
<td width="390">
<p>{Id} {Grade} {Date and Time}</p>
<p>{Customer Full Name}</p>
<p>{Content}</p>
</td>
</tr>
</tbody>
</table>
<p>The application should <strong>receive and execute unlimited number of commands</strong> until the <strong>&ldquo;exit&rdquo;</strong> command is received.</p>
<p>Use all of the <strong>best practices</strong> you know to design and write your application.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="265">
<p><strong>Input</strong></p>
</td>
<td width="445">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="265">
<p>print-info 1</p>
<p>exit</p>
<p>&nbsp;</p>
</td>
<td width="445">
<p>Sofia Central Station, Sofia</p>
<p>Arrivals:</p>
<p>From: Burgas | Arrive at: 14:30 | Status: Departed</p>
<p>From: Svishtov | Arrive at: 07:30 | Status: Arrived</p>
<p>From: V.Tarnovo | Arrive at: 14:30 | Status: Departed</p>
<p>Departures:</p>
<p>To: Varna | Depart at: 14:40 | Status: Delayed</p>
<p>To: Plovdiv | Depart at: 15:30 | Status: Cancelled</p>
</td>
</tr>
<tr>
<td width="265">
<p>buy-ticket 2 323 14.20 A4</p>
<p>buy-ticket 3 333 -12.00 B8</p>
<p>buy-ticket 9 874 6.90 A1</p>
<p>exit</p>
</td>
<td width="445">
<p>Customer John Doe bought ticket for trip 323 for $14.20 on seat A4</p>
<p>Invalid price</p>
<p>Insufficient amount of money for customer Harry Potter with bank account number BGR33133235</p>
</td>
</tr>
<tr>
<td width="265">
<p>publish-review 2 10 BusTrip2000 Excellent trip! Look forward to travel again.</p>
<p>publish-review 3 2 BusCompany2001 Awful and dirty bus. Cannot recommend it to anyone.</p>
<p>exit</p>
</td>
<td width="445">
<p>John Doe&rsquo;s review was succesfully published</p>
<p>Chuck Norris&rsquo; review was successfully published</p>
</td>
</tr>
<tr>
<td width="265">
<p>publish-review 2 8.5 BusTrip2000 Would recommend it but the driver needs to stop smoking while driving.</p>
<p>print-reviews 1</p>
<p>exit</p>
</td>
<td width="445">
<p>John Doe&rsquo;s review was succesfully published</p>
<p>1 10 2016/11/15 10:46:18</p>
<p>John Doe</p>
<p>Excellent trip! Look forward to travel again.</p>
<p>2 8.5 2016/11/18 12:20:00</p>
<p>John Doe</p>
<p>Would recommend it but the driver needs to stop smoking while driving.</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; **Extend Bus Tickets System</h2>
<p>Implement one additional command <strong>change-trip-status</strong>. That command would change the status of a given trip</p>
<table width="0">
<tbody>
<tr>
<td width="321">
<p><strong>Command</strong></p>
</td>
<td width="378">
<p><strong>Successful Output</strong></p>
</td>
</tr>
<tr>
<td width="321">
<p>change-trip-status {Trip Id} {New Status}</p>
</td>
<td width="378">
<p>Trip from {Origin Bus Station Town} to {Destination Bus Station Town} on {Trip Departure Date and Time}</p>
<p>Status changed from {Old Status} to {New Status}</p>
</td>
</tr>
</tbody>
</table>
<p>Add a <strong>new table to the database</strong> to keep information about <strong>arrived trips</strong> (actual arrival time, origin bus station, destination bus station, passengers count).</p>
<p>In case a <strong>trip status is changed to Arrived, automatically add new record</strong> in the <strong>arrived trips table</strong> with the required information.</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="236">
<p><strong>Input</strong></p>
</td>
<td width="474">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="236">
<p>change-trip-status 2 Departed</p>
<p>change-trip-status 3 Cancelled</p>
<p>change-trip-status 134 Arrived</p>
<p>exit</p>
<p>&nbsp;</p>
</td>
<td width="474">
<p>Trip from Burgas to Sofia on 2016/11/15 10:45:00</p>
<p>Status changed from Cancelled to Departed</p>
<p>Trip from Sofia to Varna on 2016/11/15 10:00:00</p>
<p>Status changed from Delayed to Cancelled</p>
<p>Trip from Plovdiv to Varna on 2016/11/14 15:30:00</p>
<p>Status changed from Departed to Arrived</p>
<p>On 2016/11/14 22:32:43 - 34 passengers arrived at Varna from Plovdiv</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
StartUp &ndash; for your <strong>StartUp</strong> class
<h1>Exercises: C# Auto Mapping Objects</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Employees Mapping</h2>
<p>Create a simple database with one table &ndash; Employees. Each employee should have properties: <strong>first name</strong>, <strong>last name</strong>, <strong>salary</strong>, <strong>birthday</strong> and <strong>address</strong>. Only <strong>first</strong> <strong>name</strong>, <strong>last</strong> <strong>name</strong> and <strong>salary</strong> are <strong>required</strong>.</p>
<p>Create <strong>EmployeeDto</strong> class that will keep synthesized information about instances of Employee class (only <strong>id</strong>, <strong>first name</strong>, <strong>last name</strong> and <strong>salary</strong>).</p>
<p>Create a console app for your database, which uses the <strong>Automapper</strong> package and the <strong>EmployeeDto</strong> class to <strong>transfer</strong> <strong>data</strong> from and back to the database. You should have the following commands:</p>
<ul>
<li><strong>AddEmployee</strong> &lt;<strong>firstName</strong>&gt; &lt;<strong>lastName</strong>&gt; &lt;<strong>salary</strong>&gt; &ndash; adds a new Employee to the database</li>
<li><strong>SetBirthday &lt;employeeId&gt; &lt;date:</strong> "dd-MM-yyyy"<strong>&gt; </strong>&ndash; sets the birthday of the employee to the given date</li>
<li><strong>SetAddress</strong> &lt;<strong>employeeId</strong>&gt; &lt;<strong>address</strong>&gt; &ndash; sets the address of the employee to the given string</li>
<li><strong>EmployeeInfo</strong> &lt;<strong>employeeId</strong>&gt; &ndash; prints on the console the information for an employee in the format "ID: {employeeId} - {firstName} {lastName} - ${salary:f2}"</li>
<li><strong>EmployeePersonalInfo &lt;employeeId&gt; </strong>&ndash; prints all the information for an employee in the following format:</li>
</ul>
<table width="0">
<tbody>
<tr>
<td width="272">
<p>ID: 1 - Pesho Ivanov - $1000:00</p>
<p>Birthday: 15-04-1976</p>
<p>Address: Sofia, ul. Vitosha 15</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Exit</strong> &ndash; closes the application</li>
</ul>
<h4>Bonus</h4>
<p>Only use <strong>DTOs</strong> in your application. Use a <strong>service</strong> to connect to the <strong>database</strong>.</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Manager Mapping</h2>
<p>Add to the <strong>Employee</strong> model information about their <strong>manager</strong> and a list of <strong>employees</strong> that they <strong>manage</strong>. It is <strong>possible</strong> for an employee to have <strong>no</strong> <strong>manager</strong>. Create another data transfer object, which treats employees as managers:</p>
<ul>
<li><strong>ManagerDto</strong> &ndash; first name, last name, list of EmployeeDtos that he/she is in charge of and their count</li>
</ul>
<p>Add the following commands to your console application:</p>
<ul>
<li><strong>SetManager</strong> &lt;<strong>employeeId</strong>&gt; &lt;<strong>managerId</strong>&gt; &ndash; sets the second employee to be a manager of the first employee</li>
<li><strong>ManagerInfo</strong> &lt;<strong>employeeId</strong>&gt; &ndash; prints on the console information about a manager in the following format:</li>
</ul>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="262">
<p><strong>Sample output</strong></p>
</td>
</tr>
<tr>
<td width="262">
<p>Steve Jobbsen | Employees: 2</p>
<p>&nbsp;&nbsp;&nbsp; - Stephen Bjorn - $4300.00</p>
<p>&nbsp;&nbsp;&nbsp; - Kirilyc Lefi - $4400.00</p>
</td>
</tr>
<tr>
<td width="262">
<p>Carl Kormac | Employees: 14</p>
<p>&nbsp;&nbsp;&nbsp; - Jurgen Straus - $1000.45</p>
<p>&nbsp;&nbsp;&nbsp; - Moni Kozinac - $2030.99</p>
<p>&nbsp;&nbsp;&nbsp; - Kopp Spidok - $2000.21</p>
<p>&nbsp;&nbsp;&nbsp; - &hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Projection</h2>
<p>Add a few employees to your database with their birthdays. Create a command "<strong>ListEmployeesOlderThan</strong> &lt;<strong>age</strong>&gt;" which lists all employees older than given age and their managers. Order them <strong>by salary descending. </strong>Add the necessary DTOs and commands to your application.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="410">
<p><strong>Sample output</strong></p>
</td>
</tr>
<tr>
<td width="410">
<p>Steve Jobbsen - $6000.20 - Manager: [no manager]</p>
<p>Kirilyc Lefi - $4400.00 - Manager: Jobbsen</p>
<p>Stephen Bjorn - $4300.00 - Manager: Jobbsen</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
Data &ndash; for your DbContext</li>
<li>Models &ndash; for your models</li>
</ul>
<p>Your <strong>models</strong> should be:</p>
<ul>
<li>BookShopContext &ndash; your DbContext</li>
<li>Author:
<ul>
<li>AuthorId</li>
<li>FirstName (up to 50 characters, unicode, not required)</li>
<li>LastName (up to 50 characters, unicode)</li>
</ul>
</li>
<li>Book:
<ul>
<li>BookId</li>
<li>Title (up to 50 characters, unicode)</li>
<li>Description (up to 1000 characters, unicode)</li>
<li>ReleaseDate (not required)</li>
<li>Copies (an integer)</li>
<li>Price</li>
<li>EditionType &ndash; enum (Normal, Promo, Gold)</li>
<li>AgeRestriction &ndash; enum (Minor, Teen, Adult)</li>
<li>Author</li>
<li>BookCategories</li>
</ul>
</li>
<li>Category:
<ul>
<li>CategoryId</li>
<li>Name (up to 50 characters, unicode)</li>
<li>CategoryBooks</li>
</ul>
</li>
<li>BookCategory &ndash; mapping class</li>
</ul>
<p>For the following tasks, you will be creating methods that accept a BookShopContext as a parameter and use it to run some queries. Create those methods inside your <strong>StartUp</strong> class and upload your whole solution to <strong>Judge</strong>.</p>
<h2>1.&nbsp;&nbsp; Age Restriction</h2>
<p>Create a <strong>method GetBooksByAgeRestriction</strong>(BookShopContext context, <strong>string</strong> <strong>command</strong>), that returns in a <strong>single</strong> <strong>string </strong>all book <strong>titles</strong>, each on a <strong>new line, </strong>that have<strong> age</strong> <strong>restriction</strong>, equal to the <strong>given</strong> <strong>command</strong>. Order the titles <strong>alphabetically</strong>.</p>
<p>Read <strong>input</strong> from the console in your <strong>main</strong> <strong>method</strong>, and call your <strong>method</strong> with the <strong>necessary</strong> <strong>arguments</strong>. Print the <strong>returned</strong> <strong>string</strong> to the console. <strong>Ignore</strong> casing of the input.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="286">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>miNor</p>
</td>
<td width="286">
<p>A Confederacy of Dunces</p>
<p>A Farewell to Arms</p>
<p>A Handful of Dust</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="64">
<p>teEN</p>
</td>
<td width="286">
<p>A Passage to India</p>
<p>A Scanner Darkly</p>
<p>A Swiftly Tilting Planet</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Golden Books</h2>
<p>Just like in task 1, write a method <strong>GetGoldenBooks</strong>(BookShopContext context), that returns in a <strong>single</strong> string <strong>titles of the golden edition books</strong> that have <strong>less than 5000 copies</strong>, each on a<strong> new line</strong>. Order them by <strong>book</strong> <strong>id</strong> ascending.</p>
<p>Call the <strong>GetGoldenBooks()</strong> method in your <strong>Main()</strong> and print the returned string to the console.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="313">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="313">
<p>Lilies of the Field</p>
<p>Look Homeward</p>
<p>The Mirror Crack'd from Side to Side</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Books by Price</h2>
<p>Write a <strong>GetBooksByPrice</strong>(BookShopContext context) method that returns in a single string all <strong>titles and prices</strong> <strong>of books</strong> with <strong>price higher than 40</strong>, each on a <strong>new</strong> <strong>row</strong> in the <strong>format</strong> given below. Order them by <strong>price</strong> descending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="284">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="284">
<p>O Pioneers! - $49.90</p>
<p>That Hideous Strength - $48.63</p>
<p>A Handful of Dust - $48.63</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Not Released In</h2>
<p>Write a <strong>GetBooksNotRealeasedIn</strong>(BookShopContext context<strong>, int year</strong>) method that returns in a <strong>single</strong> string all <strong>titles of books</strong> that are <strong>NOT released</strong> on a given year. Order them by <strong>book</strong> <strong>id</strong> ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="286">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>2000</p>
</td>
<td width="286">
<p>Absalom</p>
<p>Nectar in a Sieve</p>
<p>Nine Coaches Waiting</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="64">
<p>1998</p>
</td>
<td width="286">
<p>The Needle's Eye</p>
<p>No Country for Old Men</p>
<p>No Highway</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Book Titles by Category</h2>
<p>Write a <strong>GetBooksByCategory</strong>(BookShopContext context, string input) method that <strong>selects</strong> and <strong>returns </strong>in a single string the<strong> titles of books</strong> by a given <strong>list of categories</strong>. The list of <strong>categories</strong> will be given in a single line separated with one or more spaces. Ignore casing. Order by <strong>title</strong> alphabetically.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>horror mystery drama</p>
</td>
<td width="246">
<p>A Fanatic Heart</p>
<p>A Farewell to Arms</p>
<p>A Glass of Blessings</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Released Before Date</h2>
<p>Write a <strong>GetBooksReleasedBefore</strong>(BookShopContext context, string date) method that <strong>returns the title, edition type and price </strong>of all books that are <strong>released before a given date</strong>. The date will be a string <strong>in format dd-MM-yyyy</strong>.</p>
<p>Return all of the rows in a <strong>single</strong> string, ordered by <strong>release</strong> <strong>date</strong> <strong>descending</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="91">
<p><strong>Input</strong></p>
</td>
<td width="467">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="91">
<p>12-04-1992</p>
</td>
<td width="467">
<p>If I Forget Thee Jerusalem - Gold - $33.21</p>
<p>Oh! To be in England - Normal - $46.67</p>
<p>The Monkey's Raincoat - Normal - $46.93</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="91">
<p>30-12-1989</p>
</td>
<td width="467">
<p>A Fanatic Heart - Normal - $9.41</p>
<p>The Curious Incident of the Dog in the Night-Time - Normal - $23.41</p>
<p>The Other Side of Silence - Gold - $46.26</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Author Search</h2>
<p>Write a <strong>GetAuthorNamesEndingIn</strong>(BookShopContext context, string input) method that returns the <strong>full</strong> <strong>names</strong> of <strong>authors</strong>, whose <strong>first</strong> <strong>name</strong> ends with a <strong>given</strong> <strong>string</strong>.</p>
<p>Return all <strong>names</strong> in a <strong>single</strong> <strong>string</strong>, each on a <strong>new</strong> <strong>row</strong>, ordered alphabetically.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="191">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>e</p>
</td>
<td width="191">
<p>George Powell</p>
<p>Jane Ortiz</p>
</td>
</tr>
<tr>
<td width="64">
<p>dy</p>
</td>
<td width="191">
<p>Randy Morales</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Book Search</h2>
<p>Write a <strong>GetBookTitlesContaining</strong>(BookShopContext context, string input) method that returns the <strong>titles</strong> of <strong>book</strong>, which contain a <strong>given</strong> <strong>string</strong>. Ignore casing.</p>
<p>Return all <strong>titles</strong> in a <strong>single</strong> <strong>string</strong>, each on a <strong>new</strong> <strong>row</strong>, ordered alphabetically.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="229">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>sK</p>
</td>
<td width="229">
<p>A Catskill Eagle</p>
<p>The Daffodil Sky</p>
<p>The Skull Beneath the Skin</p>
</td>
</tr>
<tr>
<td width="64">
<p>WOR</p>
</td>
<td width="229">
<p>Great Work of Time</p>
<p>Terrible Swift Sword</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Book Search by Author</h2>
<p>Write a <strong>GetBooksByAuthor</strong>(BookShopContext context, string input) method that <strong>returns all titles of books and their authors&rsquo; names </strong>for books, which are written by authors whose last names<strong> start with the given string</strong>.</p>
<p>Return a single string with each title on a new row. <strong>Ignore</strong> casing. Order by <strong>book</strong> <strong>id</strong> ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="63">
<p><strong>Input</strong></p>
</td>
<td width="495">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="63">
<p>R</p>
</td>
<td width="495">
<p>The Heart Is Deceitful Above All Things (Bozhidara Rysinova)</p>
<p>His Dark Materials (Bozhidara Rysinova)</p>
<p>The Heart Is a Lonely Hunter (Bozhidara Rysinova)</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="63">
<p>po</p>
</td>
<td width="495">
<p>Postern of Fate (Stanko Popov)</p>
<p>Precious Bane (Stanko Popov)</p>
<p>The Proper Study (Stanko Popov)</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp; Count Books</h2>
<p>Write a <strong>CountBooks</strong>(BookShopContext context, int lengthCheck) method that <strong>returns the number of books, </strong>which have a <strong>title longer than the number</strong> given as an input.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="63">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
<td width="429">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="63">
<p>12</p>
</td>
<td width="66">
<p>169</p>
</td>
<td width="429">
<p>There are 169 books with longer title than 12 symbols</p>
</td>
</tr>
<tr>
<td width="63">
<p>40</p>
</td>
<td width="66">
<p>2</p>
</td>
<td width="429">
<p>There are 2 books with longer title than 40 symbols</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp; Total Book Copies</h2>
<p>Write a method <strong>CountCopiesByAuthor</strong>(BookShopContext context) that <strong>returns</strong> the <strong>total number of book copies</strong> <strong>for each author</strong>. Order the results <strong>descending by total book copies</strong>.</p>
<p>Return all results in a <strong>single</strong> <strong>string</strong>, each on a <strong>new</strong> <strong>line</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="208">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="208">
<p>Stanko Popov - 117778</p>
<p>Lyubov Ivanova - 107391</p>
<p>Jane Ortiz &ndash; 103673</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp; Profit by Category</h2>
<p>Write a method <strong>GetTotalProfitByCategory</strong>(BookShopContext context) that <strong>returns</strong> the <strong>total profit of all books by category</strong>. Profit for a book can be calculated by multiplying its <strong>number of copies</strong> by the <strong>price per single book</strong>. Order the results by <strong>descending by total profit</strong> for category and <strong>ascending by category name</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="264">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="264">
<p>Art $6428917.79</p>
<p>Fantasy $5291439.71</p>
<p>Adventure $5153920.77</p>
<p>Children's $4809746.22</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp; Most Recent Books</h2>
<p>Get the most recent books by categories in a <strong>GetMostRecentBooks</strong>(BookShopContext context) method. The <strong>categories</strong> should be ordered by <strong>total</strong> <strong>book count</strong>. Only take the <strong>top 3</strong> most recent books from each category - ordered by <strong>release date</strong> (descending). <strong>Select</strong> and <strong>print</strong> the <strong>category name</strong>, and for each <strong>book</strong> &ndash; its <strong>title</strong> and <strong>release year</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="434">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="434">
<p>--Action</p>
<p>Brandy of the Damned (2015)</p>
<p>Bonjour Tristesse (2013)</p>
<p>By Grand Central Station I Sat Down and Wept (2010)</p>
<p>--Adventure</p>
<p>The Cricket on the Hearth (2013)</p>
<p>Dance Dance Dance (2002)</p>
<p>Cover Her Face (2000)</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>14.&nbsp;&nbsp; Increase Prices</h2>
<p>Write a method <strong>IncreasePrices</strong>(BookShopContext context) that <strong>increases the prices of all books</strong> <strong>released before 2010 by 5</strong>.</p>
<h2>15.&nbsp;&nbsp; Remove Books</h2>
<p>Write a method <strong>RemoveBooks</strong>(BookShopContext context) that <strong>removes from the database</strong> those <strong>books</strong>, which have less than <strong>4200 copies</strong>. Return an <strong>int</strong> - the <strong>number of books that were deleted</strong> from the database.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="201">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="201">
<p>34 books were deleted</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>