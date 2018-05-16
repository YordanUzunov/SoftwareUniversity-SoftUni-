<h1>OOP Basics Exam &ndash; Dungeons and Code Wizards</h1>
<p>The time has come for your OOP Basics exam. It will be a perilous journey, but if you manage to keep a cool head, you&rsquo;ll be able to get through it with minimal damage.</p>
<h3>Overview</h3>
<p>In this exam, you need to build a Dungeons and Dragons-esque project, which has support for <strong>characters</strong>, <strong>items</strong> and <strong>inventories </strong>for storing each character&rsquo;s items. The project will consist of the <strong>entity classes </strong>and a <strong>controller class</strong>, which manages the <strong>interaction</strong> between the characters and items.</p>
<h2>Task 1: Structure (150 points)</h2>
<h3>Item&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h3>
<p>This is a <strong>base class</strong> for any <strong>items</strong> and it <strong>should not be able to be instantiated</strong>.</p>
<h4>Data</h4>
<p>Weight &ndash; an <strong>integer number</strong></p>
<h4>Behavior</h4>
<p>Each <strong>item</strong> has the following <strong>behavior</strong>:</p>
<h5>void AffectCharacter(Character character)</h5>
<p>For an item to affect a character, the character <strong>needs to</strong> <strong>be alive</strong>.</p>
<p>If not, <strong>throw</strong> an InvalidOperationException<strong> with the message </strong>&ldquo;<strong>Must be alive to perform this action!</strong>&rdquo;.</p>
<p><strong><em>Throw this exception everywhere a character needs to be alive to perform the action.</em></strong></p>
<h4>Constructor</h4>
<p>An <strong>item</strong> should take the following values upon initialization:</p>
<p>int weight</p>
<h3>HealthPotion</h3>
<p>The <strong>health potion</strong> always has a <strong>weight</strong> of<strong> 5</strong>.</p>
<h4>Behavior</h4>
<p>Each HealthPotion has the following <strong>behavior</strong>:</p>
<h5>void AffectCharacter(Character character)</h5>
<p>For an item to affect a character, the character <strong>needs to</strong> <strong>be alive</strong>.</p>
<p>The character&rsquo;s <strong>health</strong> gets <strong>increased</strong> by <strong>20 points</strong>.</p>
<h4>Constructor</h4>
<p>An <strong>item</strong> should be able to be instantiated <strong>without any parameters</strong>.</p>
<h3>PoisonPotion</h3>
<p>The <strong>poison potion</strong> always has a <strong>weight</strong> of<strong> 5</strong>.</p>
<h4>Behavior</h4>
<p>Each PoisonPotion has the following <strong>behavior</strong>:</p>
<h5>void AffectCharacter(Character character)</h5>
<p>For an item to affect a character, the character <strong>needs to</strong> <strong>be alive</strong>.</p>
<p>The character&rsquo;s <strong>health</strong> gets <strong>decreased</strong> by <strong>20 points</strong>. If the character&rsquo;s health <strong>drops to zero</strong>, the character <strong>dies </strong>(IsAlive <strong>&egrave; </strong>false).</p>
<h4>Constructor</h4>
<p>A PoisonPotion should be able to be instantiated <strong>without any parameters</strong>.</p>
<h3>ArmorRepairKit</h3>
<p>The armor repair kit always has a <strong>weight</strong> of<strong> 10</strong>.</p>
<h4>Behavior</h4>
<p>Each ArmorRepairKit has the following <strong>behavior</strong>:</p>
<h5>void AffectCharacter(Character character)</h5>
<p>For an item to affect a character, the character <strong>needs to</strong> <strong>be alive</strong>.</p>
<p>The character&rsquo;s <strong>armor</strong> restored up to the <strong>base armor</strong> value.</p>
<p>Example: Armor: 10, Base Armor: 100 &egrave; Armor: 100</p>
<h4>Constructor</h4>
<p>An ArmorRepairKit should be able to be instantiated <strong>without any parameters</strong>.</p>
<h3>Bag</h3>
<p>This is a <strong>base class</strong> for any <strong>bags</strong> and it <strong>should not be able to be instantiated</strong>.</p>
<h4>Data</h4>
<p>Capacity &ndash; an <strong>integer number</strong>. Default value: 100</p>
<p>Load &ndash; Calculated property. The <strong>sum of the weights</strong> of the <strong>items</strong> in the bag.</p>
<p>Items &ndash; <strong>Read-only collection</strong> of type Item</p>
<h4>Behavior</h4>
<p>Each <strong>bag</strong> has the following <strong>behavior</strong>:</p>
<h5>void AddItem(Item item)</h5>
<p>If the current load + the weight of the item attempted to be added is <strong>greater than </strong>the bag&rsquo;s <strong>capacity</strong>, throw an InvalidOperationException with the message &ldquo;Bag is full!&rdquo;</p>
<p>If the check passes, the <strong>item</strong> is added to the <strong>bag</strong>.</p>
<h5>Item GetItem(string name)</h5>
<p>If no items exist in the bag, throw an InvalidOperationException with the message &ldquo;Bag is empty!&rdquo;</p>
<p>If an item with that <strong>name</strong> <strong>doesn&rsquo;t exist </strong>in the bag, throw an ArgumentException with the message &ldquo;No item with name {name} in bag!&rdquo;</p>
<p>If both checks pass, the <strong>item</strong> is removed from the <strong>bag </strong>and <strong>returned </strong>to the <strong>caller</strong>.</p>
<h4>Constructor</h4>
<p>A <strong>Bag</strong> should take the following values upon initialization:</p>
<p>int capacity</p>
<h3>Backpack</h3>
<p>This is a <strong>type of bag </strong>with 100 capacity.</p>
<h3>Satchel</h3>
<p>This is a <strong>type of bag </strong>with 20 capacity.</p>
<h3>Character</h3>
<p>This is a <strong>base class</strong> for any <strong>characters</strong> and it <strong>should not be able to be instantiated</strong>.</p>
<h4>Data</h4>
<ul>
<li>Name &ndash; a <strong>string (cannot be null or whitespace)</strong>.
<ul>
<li><strong>Throw an ArgumentException with the message &ldquo;Name cannot be null or whitespace!&rdquo;</strong></li>
</ul>
</li>
<li><strong>BaseHealth</strong> &ndash; a <strong>floating-point number</strong></li>
<li>Health &ndash; a <strong>floating-point number </strong>(current health).
<ul>
<li>Health maxes out at <strong>BaseHealth</strong> and mins out at 0.</li>
</ul>
</li>
<li><strong>BaseArmor</strong> &ndash; a <strong>floating-point number</strong></li>
<li>Armor &ndash; a <strong>floating-point number </strong>(current armor)
<ul>
<li>Armor maxes out at <strong>BaseArmor</strong> and mins out at 0.</li>
</ul>
</li>
<li><strong>AbilityPoints</strong> &ndash; a <strong>floating-point number</strong></li>
<li>Bag &ndash; a parameter of type <strong>Bag</strong></li>
<li>Faction &ndash; a constant value with <strong>2 possible values</strong>: <strong>CSharp</strong> and <strong>Java</strong></li>
<li>IsAlive &ndash; boolean value (default value: True)</li>
<li>RestHealMultiplier &ndash; a <strong>floating-point number</strong> (default: <strong>2</strong>), <strong>could be overriden</strong></li>
</ul>
<h4>Behavior</h4>
<p>Each <strong>character</strong> has the following <strong>behavior</strong>:</p>
<h5>void TakeDamage(double hitPoints)</h5>
<p>For a character to take damage, they need to <strong>be alive</strong>.</p>
<p>The character takes damage equal to the <strong>hit points</strong>. Taking damage works like so:</p>
<p>The character&rsquo;s <strong>armor </strong>is <strong>reduced</strong> by the <strong>hit point amount</strong>, then if there are <strong>still hit points left</strong>, they take that amount of <strong>health damage</strong>.</p>
<p>If the character&rsquo;s <strong>health</strong> drops to <strong>zero</strong>, the character <strong>dies </strong>(IsAlive become <strong>false</strong>)</p>
<p>Example: Health: <strong>100</strong>, Armor: <strong>30</strong>, Hit Points: <strong>40</strong> &egrave; Health: <strong>90</strong>, Armor: <strong>0</strong></p>
<h5>void Rest()</h5>
<p>For a character to rest, they need to <strong>be alive</strong>.</p>
<p>The character&rsquo;s <strong>health</strong> increases by their BaseHealth, multiplied by their RestHealMultiplier</p>
<p>Example: Health: <strong>50</strong>, BaseHealth: <strong>100</strong>, RestHealMultiplier: <strong>0.2</strong> &egrave; Health: 50 + (100 * 0.2) &egrave; 70</p>
<h5>void UseItem(Item item)</h5>
<p>For a character to use an item, they need to be <strong>alive</strong>.</p>
<p>The item affects the character with the item effect.</p>
<h5>void UseItemOn(Item item, Character character)</h5>
<p>For a character to use an item on another character, <strong>both of them</strong> need to be <strong>alive</strong>.</p>
<p>The item affects the targeted character with the item effect.</p>
<h5>void GiveCharacterItem(Item item, Character character)</h5>
<p>For a character to give another character an item, <strong>both of them </strong>need to be <strong>alive</strong>.</p>
<p>The targeted character <strong>receives the item</strong>.</p>
<h5>void ReceiveItem(Item item)</h5>
<p>For a character to receive an item, they need to be <strong>alive</strong>.</p>
<p>The character puts the <strong>item</strong> into their <strong>bag</strong>.</p>
<h4>Constructor</h4>
<p>A <strong>character</strong> should take the following values upon initialization:</p>
<p>string name, double health, double armor, double abilityPoints, Bag bag, Faction faction</p>
<h3>IAttackable</h3>
<p>A <strong>contract</strong> for any class that <strong>implements it</strong>, that includes an &ldquo;Attack(Character character)&rdquo; method</p>
<h3>IHealable</h3>
<p>A <strong>contract</strong> for any class that <strong>implements it</strong>, that includes a &ldquo;Heal(Character character)&rdquo; method</p>
<h3>Warrior</h3>
<p>The <strong>Warrior</strong> is a special class, who can <strong>attack</strong> other characters.</p>
<h4>Data</h4>
<p>The Warrior class always has <strong>100 Base Health</strong>, <strong>50 Base Armor</strong>, <strong>40 Ability Points</strong>, and a <strong>Satchel</strong> as a bag.</p>
<h4>Constructor</h4>
<p>The <strong>Warrior </strong>only needs a <strong>name </strong>and a <strong>faction</strong> for initialization:</p>
<p>string name, Faction faction</p>
<h4>Behavior</h4>
<p>The warrior only has <strong>one special behavior</strong> (every other behavior is <strong>inherited</strong>):</p>
<h5>void Attack(Character character)</h5>
<p>For a character to attack another character, <strong>both of them need to be alive</strong>.</p>
<p>If the character they are trying to attack is the same character, throw an InvalidOperationException with the message &ldquo;Cannot attack self!&rdquo;</p>
<p>If the character the character is attacking is from the <strong>same faction</strong>, throw an ArgumentException with the message &ldquo;Friendly fire! Both characters are from {faction} faction!&rdquo;</p>
<p>If all of those checks pass, the <strong>receiving character takes damage</strong> with <strong>hit points</strong> equal to the <strong>attacking character&rsquo;s</strong> <strong>ability points</strong>.</p>
<h3>Cleric</h3>
<p>The <strong>Cleric</strong> is a special class, who can <strong>heal</strong> other characters.</p>
<h4>Data</h4>
<p>The Cleric class always has <strong>50 Base Health</strong>, <strong>25 Base Armor</strong>, <strong>40 Ability Points</strong>, and a <strong>Backpack</strong> as a bag.</p>
<p>The cleric&rsquo;s RestHealMultiplier is <strong>0.5</strong>.</p>
<h4>Constructor</h4>
<p>The <strong>Cleric </strong>only needs a <strong>name </strong>and a <strong>faction</strong> for initialization:</p>
<p>string name, Faction faction</p>
<h4>Behavior</h4>
<p>The cleric only has <strong>one special behavior</strong> (every other behavior is <strong>inherited</strong>):</p>
<h5>void Heal(Character character)</h5>
<p>For a character to heal another character, <strong>both of them need to be alive</strong>.</p>
<p>If the character the character is healing is from a <strong>different faction</strong>, throw an InvalidOperationException with the message &ldquo;Cannot heal enemy character!&rdquo;</p>
<p>If both of those checks pass, the <strong>receiving character&rsquo;s health increases by the healer&rsquo;s ability points</strong>.</p>
<h2>Task 2: Business Logic (200 points)</h2>
<h3>The Controller Class</h3>
<p>The business logic of the program should be concentrated around several <strong>commands</strong>. Implement a class called DungeonMaster, which will hold the <strong>main functionality</strong>.</p>
<p>The Dungeon Master keeps track of the <strong>character party</strong> and the <strong>item pool</strong> (the items in the game, which can be picked up). It also keeps track of the <strong>last survivor&rsquo;s consecutive rounds (explained below)</strong>.</p>
<p><strong><em>Note: The </em></strong><em>DungeonMaster</em><strong><em> class SHOULD NOT handle exceptions! The tests are designed to expect exceptions, not messages!</em></strong></p>
<p>The main functionality is represented by these <strong>public</strong> <strong>methods</strong>:</p>
<table width="0">
<tbody>
<tr>
<td width="304">
<p>DungeonMaster.cs</p>
</td>
</tr>
<tr>
<td width="304">
<p>public string JoinParty(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string AddItemToPool(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string PickUpItem(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string UseItem(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string UseItemOn(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string GiveCharacterItem(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string GetStats()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string Attack(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string Heal(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string EndTurn(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public bool IsGameOver()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p><strong>NOTE: DungeonMaster class </strong>methods are called from the outside so these methods <strong>must</strong> <strong>NOT</strong> receive the command parameter (the <strong>first argument</strong> from the input line) as part of the arguments!</p>
<p><strong>ALSO NOTE: The </strong>DungeonMaster <strong>class should not handle any exceptions. That should be the responsibility of the class, which reads the commands and passes them to the </strong>DungeonMaster<strong>. </strong></p>
<h3>Commands</h3>
<p>There are several commands that control the business logic of the application and you are supposed to build. <br /> They are stated below.</p>
<h4>JoinParty Command</h4>
<h5>Parameters</h5>
<ul>
<li>faction &ndash; a <strong>string</strong></li>
<li>characterType &ndash; <strong>string</strong></li>
<li>name &ndash; <strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p><strong>Creates a character</strong> and <strong>adds them</strong> to the <strong>party</strong>.</p>
<p>If the <strong>faction</strong> is invalid, throw an ArgumentException with the message &ldquo;Invalid faction "{faction}"!&rdquo;</p>
<p>If the <strong>character type </strong>is invalid, throw an ArgumentException with the message &ldquo;Invalid character type "{characterType}"!&rdquo;</p>
<p>Returns the <strong>string</strong> &ldquo;{name} joined the party!&rdquo;</p>
<h4>AddItemToPool Command</h4>
<h5>Parameters</h5>
<ul>
<li>itemName &ndash;<strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p><strong>Creates an item</strong> and <strong>adds it </strong>to the <strong>item pool</strong>.</p>
<p>If the <strong>item type</strong> is <strong>invalid</strong>, throw an ArgumentException with the message &ldquo;"Invalid item "{name}"!&rdquo;</p>
<p>Returns the <strong>string</strong> &ldquo;{itemName} added to pool.&rdquo;</p>
<h4>PickUpItem Command</h4>
<h5>Parameters</h5>
<ul>
<li>characterName &ndash; <strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p>Makes the character with the specified name <strong>pick up the last item in the item pool</strong>.</p>
<p>If the character doesn&rsquo;t exist in the <strong>party</strong>, throw an ArgumentException with the message &ldquo;Character {name} not found!&rdquo;</p>
<p>If there&rsquo;s <strong>no items left</strong> in the pool, throw an InvalidOperationException with the message &ldquo;No items left in pool!&rdquo;</p>
<p>Returns the <strong>string</strong> &ldquo;{characterName} picked up {itemName}!&rdquo;</p>
<h4>UseItem Command</h4>
<h5>Parameters</h5>
<ul>
<li>characterName &ndash; a <strong>string</strong></li>
<li>itemName &ndash; <strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p><strong>Makes the character</strong> with that name use an <strong>item with that name</strong> <strong>from their bag</strong>.</p>
<p>If the character doesn&rsquo;t exist in the <strong>party</strong>, throw an ArgumentException with the message &ldquo;Character {name} not found!&rdquo;</p>
<p>The rest of the exceptions should be processed by the called functionality (empty bag, etc.)</p>
<p>Returns the <strong>string</strong> &ldquo;{character.Name} used {itemName}.&rdquo;</p>
<h4>UseItemOn Command</h4>
<h5>Parameters</h5>
<ul>
<li>giverName &ndash; a <strong>string</strong></li>
<li>receiverName &ndash; <strong>string</strong></li>
<li>itemName &ndash; <strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p><strong>Makes the giver</strong> <strong>get</strong> an <strong>item with that name</strong> <strong>from their bag</strong> and <strong>uses it on the receiving character</strong>.</p>
<p>Process any edge cases (giver not found, receiver not found, item not found, etc.) in the same way as in the above commands.</p>
<p>Returns the <strong>string</strong> &ldquo;{giverName} used {itemName} on {receiverName}.&rdquo;</p>
<h4>GiveCharacterItem Command</h4>
<h5>Parameters</h5>
<ul>
<li>giverName &ndash; a <strong>string</strong></li>
<li>receiverName &ndash; <strong>string</strong></li>
<li>itemName &ndash; <strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p><strong>Makes the giver</strong> <strong>get</strong> an <strong>item with that name</strong> <strong>from their bag</strong> and <strong>gives it to the receiving character</strong>.</p>
<p>Process any edge cases (giver not found, receiver not found, item not found, etc.) in the same way as in the above commands.</p>
<p>Returns the <strong>string</strong> &ldquo;{giverName} gave {receiverName} {itemName}.&rdquo;</p>
<h4>GetStats Command</h4>
<h5>Parameters</h5>
<p>No parameters.</p>
<h5>Functionality</h5>
<p>Returns info about <strong>all characters</strong>, sorted by <strong>whether</strong> <strong>they are alive</strong> (<strong>descending</strong>), <strong>then by</strong> their <strong>health</strong> (<strong>descending</strong>)</p>
<p>The format of a single character is:</p>
<p>{name} - HP: {health}/{baseHealth}, AP: {armor}/{baseArmor}, Status: {Alive/Dead}</p>
<p>Returns the formatted character info for each character, <strong>separated by new lines</strong>.</p>
<h4>Attack Command</h4>
<h5>Parameters</h5>
<ul>
<li>attackerName &ndash; a <strong>string</strong></li>
<li>receiverName &ndash; <strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p>Makes the <strong>attacker</strong> <strong>attack</strong> the <strong>receiver</strong>.</p>
<p><strong><em>If any of the characters don&rsquo;t exist in the party, throw exceptions with messages just like the above commands.</em></strong></p>
<p>If the <strong>attacker cannot attack</strong>, throw an ArgumentException with the message &ldquo;{attacker.Name} cannot attack!&rdquo;</p>
<p>The command output is in the following format:</p>
<p>{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiverHealth}/{receiverBaseHealth} HP and {receiverArmor}/{receiverBaseArmor} AP left!</p>
<p>If the attacker ends up <strong>killing</strong> the receiver, add a <strong>new line</strong>, plus &ldquo;{receiver.Name} is dead!&rdquo; to the output.</p>
<p>Returns the<strong> formatted string</strong></p>
<h4>Heal Command</h4>
<h5>Parameters</h5>
<ul>
<li>healerName &ndash; a <strong>string</strong></li>
<li>healingReceiverName &ndash; <strong>string</strong></li>
</ul>
<h5>Functionality</h5>
<p>Makes the <strong>healer</strong> <strong>heal</strong> the <strong>healing</strong> <strong>receiver</strong>.</p>
<p>If any of the characters don&rsquo;t exist in the party, throw exceptions with messages just like the above commands.</p>
<p>If the <strong>healer cannot heal</strong>, throw an ArgumentException with the message &ldquo;{healerName} cannot heal!&rdquo;</p>
<p>The command <strong>output</strong> is in the following format:</p>
<p><strong>{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!</strong></p>
<p>Returns the<strong> formatted string</strong></p>
<h4>EndTurn Command</h4>
<h5>Parameters</h5>
<p>No parameters.</p>
<h5>Functionality</h5>
<p>Ends the turn. Several things happen when a turn ends.</p>
<p>First, each <strong>alive </strong>character <strong>rests</strong>. Then the line &ldquo;{character.Name} rests ({healthBeforeRest} =&gt; {currentHealth})&rdquo; is added to the output.</p>
<p>If there are <strong>one or zero</strong> <strong>alive</strong> characters left, the <strong>last survivor rounds </strong>are <strong>incremented by one</strong>.</p>
<p>Returns all the &ldquo;<strong>x rests&hellip;</strong>&rdquo; commands, separated by new lines.</p>
<h4>IsGameOver Command</h4>
<h5>Parameters</h5>
<p>No parameters.</p>
<h5>Functionality</h5>
<p>If the <strong>last survivor</strong> survives <strong>alone</strong> <strong>more than one round</strong>, the game is <strong>over</strong>.</p>
<p>The command returns whether the game is over or not (true/false)</p>
<h2>Task 3: Input / Output (100 points)</h2>
<h3>Input</h3>
<ul>
<li>You will receive commands <strong>until the game is over</strong> or <strong>until the command</strong> you read <strong>is</strong> <strong>null or empty</strong>.</li>
</ul>
<p>Below, you can see the <strong>format</strong> in which <strong>each command</strong> will be given in the input:</p>
<ul>
<li>JoinParty {Java/CSharp} {class} {name}</li>
<li>AddItemToPool {itemName}</li>
<li>PickUpItem {characterName}</li>
<li>UseItem {characterName} {itemName}</li>
<li>UseItemOn {giverName} {receiverName} {itemName}</li>
<li>GiveCharacterItem {giverName} {receiverName} {itemName}</li>
<li>GetStats</li>
<li>Attack {attackerName} {attackTargetName}</li>
<li>Heal {healerName} {healingTargetName}</li>
<li>EndTurn</li>
<li>IsGameOver</li>
</ul>
<h3>Output</h3>
<p>Print the output from each command when issued. When the game is over, print &ldquo;Final stats:&rdquo; and the output from the GetStats command.</p>
<p>If an exception is thrown during any of the commands&rsquo; execution, print:</p>
<ul>
<li>&ldquo;Parameter Error: &rdquo; plus the message of the exception if it&rsquo;s an ArgumentException</li>
<li>&ldquo;Invalid Operation: &rdquo; plus the message of the exception if it&rsquo;s an InvalidOperationException</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The commands will always be in the provided format.</li>
</ul>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="696">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>JoinParty CSharp Warrior Gosho</p>
<p>JoinParty Java Warrior Pesho</p>
<p>AddItemToPool HealthPotion</p>
<p>AddItemToPool ArmorRepairKit</p>
<p>AddItemToPool PoisonPotion</p>
<p>PickUpItem Gosho</p>
<p>EndTurn</p>
<p>JoinParty Java Cleric Ivan</p>
<p>Attack Gosho Pesho</p>
<p>Attack Gosho Pesho</p>
<p>EndTurn</p>
<p>Attack Gosho Pesho</p>
<p>Heal Ivan Pesho</p>
<p>EndTurn</p>
<p>Attack Gosho Ivan</p>
<p>Attack Gosho Ivan</p>
<p>Attack Gosho Pesho</p>
<p>Attack Gosho Pesho</p>
<p>Attack Gosho Pesho</p>
<p>EndTurn</p>
<p>EndTurn</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>Gosho joined the party!</p>
<p>Pesho joined the party!</p>
<p>HealthPotion added to pool.</p>
<p>ArmorRepairKit added to pool.</p>
<p>PoisonPotion added to pool.</p>
<p>Gosho picked up PoisonPotion!</p>
<p>Gosho rests (100 =&gt; 100)</p>
<p>Pesho rests (100 =&gt; 100)</p>
<p>Ivan joined the party!</p>
<p>Gosho attacks Pesho for 40 hit points! Pesho has 100/100 HP and 10/50 AP left!</p>
<p>Gosho attacks Pesho for 40 hit points! Pesho has 70/100 HP and 0/50 AP left!</p>
<p>Gosho rests (100 =&gt; 100)</p>
<p>Pesho rests (70 =&gt; 90)</p>
<p>Ivan rests (50 =&gt; 50)</p>
<p>Gosho attacks Pesho for 40 hit points! Pesho has 50/100 HP and 0/50 AP left!</p>
<p>Ivan heals Pesho for 40! Pesho has 90 health now!</p>
<p>Gosho rests (100 =&gt; 100)</p>
<p>Pesho rests (90 =&gt; 100)</p>
<p>Ivan rests (50 =&gt; 50)</p>
<p>Gosho attacks Ivan for 40 hit points! Ivan has 35/50 HP and 0/25 AP left!</p>
<p>Gosho attacks Ivan for 40 hit points! Ivan has 0/50 HP and 0/25 AP left!</p>
<p>Ivan is dead!</p>
<p>Gosho attacks Pesho for 40 hit points! Pesho has 60/100 HP and 0/50 AP left!</p>
<p>Gosho attacks Pesho for 40 hit points! Pesho has 20/100 HP and 0/50 AP left!</p>
<p>Gosho attacks Pesho for 40 hit points! Pesho has 0/100 HP and 0/50 AP left!</p>
<p>Pesho is dead!</p>
<p>Gosho rests (100 =&gt; 100)</p>
<p>Gosho rests (100 =&gt; 100)</p>
<p>Final stats:</p>
<p>Gosho - HP: 100/100, AP: 50/50, Status: Alive</p>
<p>Pesho - HP: 0/100, AP: 0/50, Status: Dead</p>
<p>Ivan - HP: 0/50, AP: 0/25, Status: Dead</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="696">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>JoinParty CSharp Warrior Gosho</p>
<p>JoinParty CSharp Warrior Pesho</p>
<p>AddItemToPool HealthPotion</p>
<p>AddItemToPool PoisonPotion</p>
<p>PickUpItem Pesho</p>
<p>PickUpItem Gosho</p>
<p>PickUpItem Pesho</p>
<p>UseItem Pesho HealthPotion</p>
<p>UseItem Pesho PoisonPotion</p>
<p>UseItemOn Gosho Pesho HealthPotion</p>
<p>AddItemToPool PoisonPotion</p>
<p>PickUpItem Gosho</p>
<p>GiveCharacterItem Gosho Pesho PoisonPotion</p>
<p>JoinParty Java Warrior Ivan</p>
<p>Attack Ivan Gosho</p>
<p>Attack Ivan Gosho</p>
<p>Attack Ivan Gosho</p>
<p>Attack Gosho Ivan</p>
<p>Attack Ivan Gosho</p>
<p>EndTurn</p>
<p>Attack Ivan Pesho</p>
<p>Attack Ivan Pesho</p>
<p>Attack Ivan Pesho</p>
<p>Attack Ivan Pesho</p>
<p>EndTurn</p>
<p>EndTurn</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>Gosho joined the party!</p>
<p>Pesho joined the party!</p>
<p>HealthPotion added to pool.</p>
<p>PoisonPotion added to pool.</p>
<p>Pesho picked up PoisonPotion!</p>
<p>Gosho picked up HealthPotion!</p>
<p>Invalid Operation: No items left in pool!</p>
<p>Invalid Operation: No item with name HealthPotion in bag!</p>
<p>Pesho used PoisonPotion.</p>
<p>Gosho used HealthPotion on Pesho.</p>
<p>PoisonPotion added to pool.</p>
<p>Gosho picked up PoisonPotion!</p>
<p>Gosho gave Pesho PoisonPotion.</p>
<p>Ivan joined the party!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 100/100 HP and 10/50 AP left!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 70/100 HP and 0/50 AP left!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 30/100 HP and 0/50 AP left!</p>
<p>Gosho attacks Ivan for 40 hit points! Ivan has 100/100 HP and 10/50 AP left!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 0/100 HP and 0/50 AP left!</p>
<p>Gosho is dead!</p>
<p>Pesho rests (100 =&gt; 100)</p>
<p>Ivan rests (100 =&gt; 100)</p>
<p>Ivan attacks Pesho for 40 hit points! Pesho has 100/100 HP and 10/50 AP left!</p>
<p>Ivan attacks Pesho for 40 hit points! Pesho has 70/100 HP and 0/50 AP left!</p>
<p>Ivan attacks Pesho for 40 hit points! Pesho has 30/100 HP and 0/50 AP left!</p>
<p>Ivan attacks Pesho for 40 hit points! Pesho has 0/100 HP and 0/50 AP left!</p>
<p>Pesho is dead!</p>
<p>Ivan rests (100 =&gt; 100)</p>
<p>Ivan rests (100 =&gt; 100)</p>
<p>Final stats:</p>
<p>Ivan - HP: 100/100, AP: 10/50, Status: Alive</p>
<p>Gosho - HP: 0/100, AP: 0/50, Status: Dead</p>
<p>Pesho - HP: 0/100, AP: 0/50, Status: Dead</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="696">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>JoinParty Java Warrior Gosho</p>
<p>JoinParty CSharp Warrior Ivan</p>
<p>Attack Gosho Gosho</p>
<p>PickUpItem Gosho</p>
<p>AddItemToPool InvalidItem</p>
<p>AddItemToPool HealthPotion</p>
<p>UseItem Gosho InvalidItem</p>
<p>UseItem Gosho HealthPotion</p>
<p>PickUpItem InvalidCharacter</p>
<p>Attack Ivan Ivan</p>
<p>Attack Pesho Ivan</p>
<p>Attack Ivan Pesho</p>
<p>Attack A B</p>
<p>Attack Ivan Gosho</p>
<p>Attack Ivan Gosho</p>
<p>Attack Ivan Gosho</p>
<p>Attack Ivan Gosho</p>
<p>EndTurn</p>
<p>EndTurn</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>Gosho joined the party!</p>
<p>Ivan joined the party!</p>
<p>Invalid Operation: Cannot attack self!</p>
<p>Invalid Operation: No items left in pool!</p>
<p>Parameter Error: Invalid item "InvalidItem"!</p>
<p>HealthPotion added to pool.</p>
<p>Invalid Operation: Bag is empty!</p>
<p>Invalid Operation: Bag is empty!</p>
<p>Parameter Error: Character InvalidCharacter not found!</p>
<p>Invalid Operation: Cannot attack self!</p>
<p>Parameter Error: Character Pesho not found!</p>
<p>Parameter Error: Character Pesho not found!</p>
<p>Parameter Error: Character A not found!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 100/100 HP and 10/50 AP left!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 70/100 HP and 0/50 AP left!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 30/100 HP and 0/50 AP left!</p>
<p>Ivan attacks Gosho for 40 hit points! Gosho has 0/100 HP and 0/50 AP left!</p>
<p>Gosho is dead!</p>
<p>Ivan rests (100 =&gt; 100)</p>
<p>Ivan rests (100 =&gt; 100)</p>
<p>Final stats:</p>
<p>Ivan - HP: 100/100, AP: 50/50, Status: Alive</p>
<p>Gosho - HP: 0/100, AP: 0/50, Status: Dead</p>
</td>
</tr>
</tbody>
</table>
<h2>Task 4: Bonus (50 points)</h2>
<h3>Factories</h3>
<p>You know that the keyword <strong>new</strong> is a bottleneck and we are trying to use it as little as possible. We even try to separate it in classes. These classes are called <strong>Factories</strong> and the naming convention for them is <strong>{TypeOfObject}Factory</strong>. You need to have <strong>two</strong> <strong>different</strong> <strong>factories</strong>, <strong>one for Characters and one for Items</strong>. This is a design pattern and you can read more about it. <a href="https://www.dotnetperls.com/factory">Factory Pattern</a>. The factories must contain a method (&ldquo;CreateCharacter/CreateItem&rdquo;), which instantiates objects of that type.</p>
<p>If you try to create a character with an invalid type, throw an ArgumentException with a message &ldquo;Invalid character type "{type}"!&rdquo;.</p>
<p>If you try to create a character with an invalid type, throw an ArgumentException with a message &ldquo;Invalid item type "{type}"!&rdquo;.</p>