<h1>OOP Basics Exam Retake &ndash; Storage Master</h1>
<p>After the perilous journey of the OOP Basics exam&rsquo;s battles and magical potions, it&rsquo;s time to drop back down to the real world for a second &ndash; to the exciting world of <em>~retail warehouse management~</em>&hellip;</p>
<h3>Overview</h3>
<p>In this exam, you need to build a <strong>warehouse management</strong> project, which has support for <strong>products</strong>, <strong>storage </strong>for storing products, and <strong>vehicles </strong>for <strong>transporting</strong> products from one storage to another. The project will consist of <strong>entity classes </strong>and a <strong>controller class</strong>, which manages the <strong>interaction</strong> between the <strong>storage</strong>, <strong>vehicles</strong> and <strong>products</strong>.</p>
<h3>Setup</h3>
<p>To set up your project, create a new Visual Studio project with the name &ldquo;StorageMaster&rdquo;. The project must have a StartUp class with the namespace &ldquo;StorageMaster&rdquo;. You are free to use any namespaces you want, <strong>as long as you have a class, called </strong>StartUp<strong> in the </strong>StorageMaster<strong> namespace</strong>. <strong>Not following this rule will lead to your code not compiling in the Judge system</strong>.</p>
<h2>Task 1: Structure (150 points)</h2>
<p>There are 3 types of entities in the application: <strong>Products</strong>, <strong>Storage</strong> and <strong>Vehicles</strong>:</p>
<h3>Products</h3>
<p>The Product is a <strong>base class</strong> for any <strong>products</strong> and it <strong>should not be able to be instantiated</strong>.</p>
<h4>Data</h4>
<ul>
<li>Price &ndash; <strong>double</strong>
<ul>
<li>If a <strong>negative price</strong> is entered, throw an InvalidOperationException with the message &ldquo;Price cannot be negative!&rdquo;</li>
</ul>
</li>
<li>Weight &ndash; <strong>double</strong></li>
</ul>
<h4>Constructor</h4>
<p>A <strong>product</strong> should take the following values upon initialization:</p>
<p>double price, double weight</p>
<h4>Child Classes</h4>
<p>There are several concrete types of <strong>products</strong>:</p>
<ul>
<li>Gpu &ndash; always has <strong>7</strong> weight</li>
<li>HardDrive &ndash; always has <strong>1</strong> weight</li>
<li>Ram &ndash; always has <strong>1</strong> weight</li>
<li>SolidStateDrive &ndash; always has <strong>2</strong> weight</li>
</ul>
<p>Each type of product <strong>only receives its </strong>price<strong> upon initialization</strong>.</p>
<h3>Vehicles</h3>
<p>The Vehicle is a <strong>base class</strong> for any <strong>vehicles</strong> and it <strong>should not be able to be instantiated</strong>.</p>
<h4>Data</h4>
<ul>
<li>Capacity &ndash; <strong>int</strong></li>
<li>Trunk &ndash; IReadOnlyCollection of <strong>Products</strong></li>
<li>IsFull &ndash; <strong>bool</strong>
<ul>
<li>Returns true if the <strong>sum</strong> of the <strong>products&rsquo; weights</strong> is <strong>equal to or larger</strong> <strong>than</strong> the vehicle capacity<strong> (calculated property)</strong></li>
</ul>
</li>
<li>IsEmpty &ndash; <strong>bool</strong>
<ul>
<li>Returns true if the <strong>vehicle </strong>doesn&rsquo;t have<strong> any products in the trunk (calculated property)</strong></li>
</ul>
</li>
</ul>
<h4>Constructor</h4>
<p>A <strong>vehicle</strong> should take the following values upon initialization:</p>
<p>int capacity</p>
<h4>Behavior</h4>
<h5>void LoadProduct(Product product)</h5>
<p>If the vehicle is <strong>already full</strong>, throw an InvalidOperationException with the message "Vehicle is full!".</p>
<p>If this check <strong>passes</strong>, the <strong>product</strong> is <strong>added </strong>to the vehicle&rsquo;s trunk.</p>
<h5>Product Unload()</h5>
<p>If the vehicle&rsquo;s <strong>trunk</strong> is <strong>empty</strong>, throw an InvalidOperationException with the message "No products left in vehicle!".</p>
<p>If this check <strong>passes</strong>, the <strong>last</strong> <strong>product</strong> in the trunk is <strong>removed </strong>from the <strong>vehicle&rsquo;s trunk</strong> and <strong>returned </strong>to the caller.</p>
<h4>Child Classes</h4>
<p>There are several concrete types of <strong>products</strong>:</p>
<ul>
<li>Van &ndash; always has <strong>2</strong> capacity</li>
<li>Truck &ndash; always has <strong>5</strong> capacity</li>
<li>Semi &ndash; always has <strong>10</strong> capacity</li>
</ul>
<p>Concrete vehicles <strong>don&rsquo;t receive </strong>anything upon initialization.</p>
<h3>Storage</h3>
<p>The Storage is a <strong>base class</strong> for any <strong>storage</strong> and it <strong>should not be able to be instantiated</strong>.</p>
<p>The <strong>storage</strong> is a building, which holds <strong>products</strong>. It also has a <strong>garage</strong> of vehicles with a <strong>fixed length</strong>. The <strong>length </strong>is determined by the <strong>garage slots </strong>of the storage.</p>
<h4>Data</h4>
<ul>
<li>Name &ndash; <strong>string</strong></li>
<li>Capacity &ndash; <strong>int </strong>&ndash; the<strong> maximum weight of products</strong> the storage can handle</li>
<li>GarageSlots &ndash; <strong>int &ndash; </strong>the number of<strong> garage slots</strong> the storage&rsquo;s <strong>garage</strong> has</li>
<li>IsFull &ndash; <strong>bool</strong>
<ul>
<li>Returns true if the <strong>sum</strong> of the <strong>products&rsquo; weights</strong> is <strong>equal to or larger</strong> <strong>than</strong> the storage capacity<strong> (calculated property)</strong></li>
</ul>
</li>
<li>Garage &ndash; IReadOnlyCollection of <strong>vehicles</strong>
<ul>
<li><strong>Read-only</strong> representation of the <strong>garage array</strong>.</li>
</ul>
</li>
<li>Products &ndash; IReadOnlyCollection of <strong>products</strong>
<ul>
<li><strong>Read-only</strong> representation of the <strong>products in storage</strong>.</li>
</ul>
</li>
</ul>
<h4>Constructor</h4>
<p>A <strong>storage</strong> should take the following values upon initialization:</p>
<p>string name, int capacity, int garageSlots, IEnumerable&lt;Vehicle&gt; vehicles</p>
<h4>Behavior</h4>
<h5>Vehicle GetVehicle(int garageSlot)</h5>
<p>If the provided garage slot number is <strong>equal to or larger than the garage slots</strong>, throw an InvalidOperationException with the message "Invalid garage slot!".</p>
<p>If the garage slot is empty, throw an InvalidOperationException with the message "No vehicle in this garage slot!"</p>
<p>The method <strong>returns</strong> the retrieved <strong>vehicle</strong>.</p>
<h5>int SendVehicleTo(int garageSlot, Storage deliveryLocation)</h5>
<p>Gets the <strong>vehicle</strong> from the specified <strong>garage slot </strong>(and delegates the validation of the garage slot to the GetVehicle method).</p>
<p>Then, the method checks if there are <strong>any free garage slots</strong>. <strong>A free garage slot is denoted by a </strong>null<strong> value</strong>.</p>
<p>If there is no free garage slot, throw an InvalidOperationException with the message "No room in garage!".</p>
<p>Then, the garage slot in the source storage is <strong>freed </strong>and the vehicle is added to the <strong>first free garage slot</strong>.</p>
<p>The method <strong>returns</strong> the <strong>garage slot</strong> the vehicle was <strong>assigned</strong> when it was transferred.</p>
<h5>int UnloadVehicle(int garageSlot)</h5>
<p>If the storage is <strong>full</strong>, <strong>throw an </strong>InvalidOperationException with the message "Storage is full!".</p>
<p>Gets the <strong>vehicle</strong> from the specified <strong>garage slot </strong>(and delegates the validation of the garage slot to the GetVehicle method).</p>
<p>Then, until the <strong>vehicle</strong> <strong>empties</strong>, or the <strong>storage</strong> <strong>fills up</strong>, the vehicle&rsquo;s products are <strong>unpacked </strong>and are <strong>added to the storage&rsquo;s products</strong>.</p>
<p>The method <strong>returns</strong> the <strong>number of unloaded products</strong>.</p>
<h4>Child Classes</h4>
<p>There are several concrete types of <strong>storages </strong>and <strong>each of them has a default set of vehicles</strong>:</p>
<ul>
<li>AutomatedWarehouse &ndash; always has <strong>1</strong> capacity and <strong>2 </strong>garage slots
<ul>
<li>Default vehicles: <strong>1 Truck</strong></li>
</ul>
</li>
<li>DistributionCenter &ndash; always has <strong>2</strong> capacity and <strong>5 </strong>garage slots
<ul>
<li>Default vehicles: <strong>3 Vans</strong></li>
</ul>
</li>
<li>Warehouse &ndash; always has <strong>10</strong> capacity and <strong>10 </strong>garage slots
<ul>
<li>Default vehicles: <strong>3 Semi trucks</strong></li>
</ul>
</li>
</ul>
<p>Each type of storage <strong>receives a name upon initialization</strong>.</p>
<h2>Task 2: Business Logic (200 points)</h2>
<h3>The Controller Class</h3>
<p>The business logic of the program should be concentrated around several <strong>commands</strong>. Implement a class called StorageMaster, which will hold the <strong>main functionality</strong>.</p>
<p>The Storage Master keeps track of the <strong>storage registry</strong> and the <strong>products pool</strong> (the products in the main storage). It also keeps track of the <strong>current vehicle (explained below)</strong>.</p>
<p><strong><em>Note: The </em></strong><em>StorageMaster</em><strong><em> class SHOULD NOT handle exceptions! The tests are designed to expect exceptions, not messages!</em></strong></p>
<p>The main functionality is represented by these <strong>public</strong> <strong>methods</strong>:</p>
<table width="0">
<tbody>
<tr>
<td width="695">
<p>StorageMaster.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>public string AddProduct(string type, double price)</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;</p>
<p>public string RegisterStorage(string type, string name)</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string SelectVehicle(string storageName, int garageSlot)</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string LoadVehicle(IEnumerable&lt;string&gt; productNames)</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string UnloadVehicle(string storageName, int garageSlot)</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string GetStorageStatus(string storageName)</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
<p>&nbsp;</p>
<p>public string GetSummary()</p>
<p>{</p>
<p>&nbsp; throw new <strong>NotImplementedException</strong>();</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p><strong>NOTE: The </strong>StorageMaster <strong>class should not handle any exceptions. That should be the responsibility of the class, which reads the commands and passes them to the </strong>StorageMaster<strong>. </strong></p>
<h3>Commands</h3>
<p>There are several commands that control the business logic of the application and you are supposed to build. <br /> They are stated below.</p>
<h4>AddProduct Command</h4>
<h5>Parameters</h5>
<ul>
<li>type &ndash; string</li>
<li>price &ndash; double</li>
</ul>
<h5>Functionality</h5>
<p><strong>Creates a product</strong> and <strong>adds it</strong> to the <strong>product pool</strong>.</p>
<p>If the product&rsquo;s type is invalid, throw an InvalidOperationException with the message "Invalid product type!"</p>
<p>Returns "Added {type} to pool".</p>
<h4>RegisterStorage Command</h4>
<h5>Parameters</h5>
<ul>
<li>type &ndash; string</li>
<li>name &ndash; string</li>
</ul>
<h5>Functionality</h5>
<p><strong>Creates a storage </strong>and <strong>adds it</strong> to the <strong>storage registry</strong>.</p>
<p>If the storage&rsquo;s type is invalid, throw an InvalidOperationException with the message "Invalid storage type!"</p>
<p>Returns "Registered {storageName}".</p>
<h4>SelectVehicle Command</h4>
<h5>Parameters</h5>
<ul>
<li>storageName &ndash; string</li>
<li>garageSlot &ndash; int</li>
</ul>
<h5>Functionality</h5>
<p>Sets the <strong>current vehicle </strong>to the vehicle in <strong>that</strong> <strong>storage&rsquo;s garage slot</strong>. The current vehicle is the vehicle, which the <strong>LoadVehicle </strong>method will interact with.</p>
<p>Returns "Selected {vehicleType}".</p>
<h4>LoadVehicle Command</h4>
<h5>Parameters</h5>
<ul>
<li>productNames &ndash; IEnumerable&lt;string&gt;</li>
</ul>
<h5>Functionality</h5>
<p>Loads the <strong>current vehicle </strong>with <strong>as many of the provided product types as possible </strong>without filling up the vehicle.</p>
<p>The method goes through<strong> each</strong> of the <strong>product names</strong> and performs the <strong>following</strong> <strong>operations</strong>:</p>
<p>If there are <strong>no items </strong>in the <strong>product pool </strong>with that name, throw an InvalidOperationException with the message "{name} is out of stock!".</p>
<p>If there are, the <strong>last product with that name</strong> <strong>in the pool </strong>is removed from the pool<strong> and loaded in the vehicle</strong>.</p>
<p>Returns "Loaded {loadedProductsCount}/{productCount} products into {vehicleType}".</p>
<p>Note: The productCount is just the <strong>number of products</strong> the command <strong>received</strong> as a <strong>parameter</strong>.</p>
<h4>SendVehicleTo Command</h4>
<h5>Parameters</h5>
<ul>
<li>sourceName &ndash; string</li>
<li>garageSlot &ndash; int</li>
<li>destinationName &ndash; string</li>
</ul>
<h5>Functionality</h5>
<p>If either the source storage or the destination storages don&rsquo;t exist, throw an <strong>InvalidOperationException </strong>with the message "Invalid source storage!" or "Invalid destination storage!"</p>
<p>Then, the method <strong>gets the vehicle </strong>from the storage at the provided garage slot and <strong>sends </strong>it to the <strong>destination storage</strong>.</p>
<p><strong>Returns</strong> "Sent {vehicleType} to {destinationName} (slot {destinationGarageSlot})".</p>
<h4>UnloadVehicle Command</h4>
<h5>Parameters</h5>
<ul>
<li>storageName &ndash; string</li>
<li>garageSlot &ndash; int</li>
</ul>
<h5>Functionality</h5>
<p>The method <strong>gets the vehicle</strong> in the storage&rsquo;s <strong>garage slot</strong>. Then, the vehicle is <strong>unloaded </strong>at the storage.</p>
<p>The method returns "Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}".</p>
<h4>GetStorageStatus Command</h4>
<h5>Parameters</h5>
<ul>
<li>storageName &ndash; string</li>
</ul>
<h5>Functionality</h5>
<p>The method <strong>gets the storage</strong> with that name from the <strong>storage registry</strong> and performs some aggregation on it:</p>
<p>The storage&rsquo;s <strong>products </strong>are <strong>counted</strong>, <strong>grouped by name</strong>, sorted by the <strong>product count</strong> (<strong>descending</strong>), then by <strong>product</strong> <strong>name</strong> (<strong>ascending</strong>).</p>
<p>Then, every vehicle&rsquo;s <strong>name</strong> in the garage is retrieved. If there is no vehicle in that garage, put &ldquo;empty&rdquo; in its garage slot.</p>
<p>The command produces <strong>two lines</strong>:</p>
<p>The first line is the <strong>stock format</strong>: &ldquo;Stock ({0}/{1}): [{2}]&rdquo;. The first parameter is the <strong>sum of the products&rsquo; weight</strong>, the second parameter is the <strong>storage&rsquo;s capacity</strong>. The third parameter is the <strong>stock info</strong>, described above, separated by commas.</p>
<p>The second line is the garage format: &ldquo;Garage: [{0}]&rdquo;. The <strong>only parameter</strong> is the vehicle names (and empty garage slots), separated by a pipe character &ldquo;|&rdquo;.</p>
<p>The method returns these two lines, separated by a <strong>new line</strong>.</p>
<p>For examples, check the sample input in the I/O section.</p>
<h4>GetSummary Command</h4>
<h5>Functionality</h5>
<p>The method gets all the storages in the storage registry, ordered by the sum of their products&rsquo; price (descending). For each one, a string is produced in the following format:</p>
<table>
<tbody>
<tr>
<td width="270">
<p>{storageName}:</p>
<p>Storage worth: ${totalMoney:F2}</p>
</td>
</tr>
</tbody>
</table>
<p>The method returns all the <strong>formatted</strong> <strong>storage strings</strong>, separated by <strong>new lines</strong>.</p>
<h2>Task 3: Input / Output (100 points)</h2>
<h3>Input</h3>
<ul>
<li>You will receive commands <strong>until you receive &ldquo;END&rdquo; </strong>as a command.</li>
</ul>
<p>Below, you can see the <strong>format</strong> in which <strong>each command</strong> will be given in the input:</p>
<ul>
<li>AddProduct {type} {price}</li>
<li>RegisterStorage {type} {name}</li>
<li>SelectVehicle {storageName} {garageSlot}</li>
<li>LoadVehicle {productName1} {productName2} {productNameN}</li>
<li>SendVehicleTo {sourceName} {sourceGarageSlot} {destinationName}</li>
<li>UnloadVehicle {storageName} {garageSlot}</li>
<li>GetStorageStatus {storageName}</li>
</ul>
<h3>Output</h3>
<p>Print the output from each command when issued. When the end command is received, print the output from the GetSummary command.</p>
<p>If an InvalidOperationException is thrown during any of the commands&rsquo; execution, print:</p>
<ul>
<li>"Error:" plus the message of the exception</li>
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
<p>RegisterStorage DistributionCenter SofiaDistribution</p>
<p>RegisterStorage Warehouse AmazonWarehouse</p>
<p>AddProduct Gpu 1200</p>
<p>AddProduct SolidStateDrive 205</p>
<p>AddProduct HardDrive 70</p>
<p>AddProduct HardDrive 120</p>
<p>SelectVehicle SofiaDistribution 0</p>
<p>LoadVehicle HardDrive Gpu</p>
<p>SendVehicleTo SofiaDistribution 0 AmazonWarehouse</p>
<p>UnloadVehicle AmazonWarehouse 3</p>
<p>END</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>Registered SofiaDistribution</p>
<p>Registered AmazonWarehouse</p>
<p>Added Gpu to pool</p>
<p>Added SolidStateDrive to pool</p>
<p>Added HardDrive to pool</p>
<p>Added HardDrive to pool</p>
<p>Selected Van</p>
<p>Loaded 2/2 products into Van</p>
<p>Sent Van to AmazonWarehouse (slot 3)</p>
<p>Unloaded 2/2 products at AmazonWarehouse</p>
<p>AmazonWarehouse:</p>
<p>Storage worth: $1320.00</p>
<p>SofiaDistribution:</p>
<p>Storage worth: $0.00</p>
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
<p>AddProduct HardDrive -20</p>
<p>RegisterStorage InvalidStorage LoshHackerStorage</p>
<p>RegisterStorage Warehouse GoodHackerStorage</p>
<p>SelectVehicle GoodHackerStorage 0</p>
<p>LoadVehicle HardDrive</p>
<p>SendVehicleTo LoshHackerStorage 0 GoodHackerStorage</p>
<p>SendVehicleTo GoodHackerStorage 0 LoshHackerStorage</p>
<p>END</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>Error: Price cannot be negative!</p>
<p>Error: Invalid storage type!</p>
<p>Registered GoodHackerStorage</p>
<p>Selected Semi</p>
<p>Error: HardDrive is out of stock!</p>
<p>Error: Invalid source storage!</p>
<p>Error: Invalid destination storage!</p>
<p>GoodHackerStorage:</p>
<p>Storage worth: $0.00</p>
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
<p>RegisterStorage DistributionCenter AmazonDistribution</p>
<p>RegisterStorage Warehouse AmazonWarehouse</p>
<p>AddProduct HardDrive 80</p>
<p>AddProduct HardDrive 70</p>
<p>AddProduct HardDrive 120</p>
<p>AddProduct Gpu 800</p>
<p>SelectVehicle AmazonDistribution 0</p>
<p>LoadVehicle SolidStateDrive</p>
<p>LoadVehicle HardDrive Gpu HardDrive</p>
<p>SendVehicleTo AmazonDistribution 0 AmazonWarehouse</p>
<p>GetStorageStatus AmazonWarehouse</p>
<p>UnloadVehicle AmazonWarehouse 3</p>
<p>GetStorageStatus AmazonWarehouse</p>
<p>END</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>Registered AmazonDistribution</p>
<p>Registered AmazonWarehouse</p>
<p>Added HardDrive to pool</p>
<p>Added HardDrive to pool</p>
<p>Added HardDrive to pool</p>
<p>Added Gpu to pool</p>
<p>Selected Van</p>
<p>Error: SolidStateDrive is out of stock!</p>
<p>Loaded 3/3 products into Van</p>
<p>Sent Van to AmazonWarehouse (slot 3)</p>
<p>Stock (0/10): []</p>
<p>Garage: [Semi|Semi|Semi|Van|empty|empty|empty|empty|empty|empty]</p>
<p>Unloaded 3/3 products at AmazonWarehouse</p>
<p>Stock (2.7/10): [HardDrive (2), Gpu (1)]</p>
<p>Garage: [Semi|Semi|Semi|Van|empty|empty|empty|empty|empty|empty]</p>
<p>AmazonWarehouse:</p>
<p>Storage worth: $990.00</p>
<p>AmazonDistribution:</p>
<p>Storage worth: $0.00</p>
</td>
</tr>
</tbody>
</table>
<h2>Task 4: Bonus (50 points)</h2>
<h3>Factories</h3>
<p>You know that the keyword <strong>new</strong> is a bottleneck and we are trying to use it as little as possible. We even try to separate it in classes. These classes are called <strong>Factories</strong> and the naming convention for them is <strong>{TypeOfObject}Factory</strong>.</p>
<p>You need to implement <strong>three</strong> <strong>different</strong> <strong>factories</strong>, <strong>one for Products (</strong>ProductFactory<strong>), one for Storage (</strong>StorageFactory<strong>), and one for Vehicles (</strong>VehicleFactory<strong>)</strong>. This is a design pattern and you can read more about it. <a href="https://www.dotnetperls.com/factory">Factory Pattern</a>. The factories must contain a method (&ldquo;CreateProduct/CreateStorage/CreateVehicle&rdquo;), which instantiates objects of that type.</p>
<p>If you try to create a <strong>product/storage/vehicle</strong> with an invalid type, throw an InvalidOperationException with a message &ldquo;Invalid product/storage/vehicle type!&rdquo;.</p>
<p>No static factories are allowed!</p>