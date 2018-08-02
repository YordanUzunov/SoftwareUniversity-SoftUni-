<h1>Exercises: JSON Processing</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h1>Products Shop</h1>
<p>A products shop holds <strong>users</strong>, <strong>products</strong> and <strong>categories</strong> for the products. Users can <strong>sell</strong> and <strong>buy</strong> products.</p>
<ul>
<li>Users have an <strong>id</strong>, <strong>first</strong> <strong>name</strong> (optional) and <strong>last</strong> <strong>name</strong> (at least 3 characters) and <strong>age </strong>(optional).</li>
<li>Products have an <strong>id</strong>, <strong>name</strong> (at least 3 characters), <strong>price</strong>, <strong>buyerId </strong>(optional) and <strong>sellerId</strong> as IDs of users.</li>
<li>Categories have an <strong>id</strong> and <strong>name</strong> (from <strong>3</strong> to <strong>15</strong> characters)</li>
</ul>
<p>Using Entity Framework Code First create a database following the above description.</p>
<p>Configure the following relations in your EF models:</p>
<ul>
<li><strong>Users</strong> should have <strong>many products sold</strong> and <strong>many products bought</strong>.</li>
<li><strong>Products</strong> should have<strong> many categories</strong></li>
<li><strong>Categories</strong> should have <strong>many products</strong></li>
</ul>
<h2>1. Import data</h2>
<p><strong>Import</strong> the data from the provided files (<strong>users.json</strong>, <strong>products.json</strong>,<strong> categories.json</strong>).</p>
<p>Import the <strong>users</strong> first. When importing products, randomly <strong>select the buyer</strong> and <strong>seller</strong> from the existing users. Leave out some <strong>products</strong> that have <strong>not been sold</strong> (i.e. buyer is null).</p>
<p>Randomly <strong>generate categories</strong> for each product from the existing categories.</p>
<h2>2. Query and Export Data</h2>
<p>Write the below described queries and <strong>export</strong> the returned data to the specified <strong>format</strong>. Make sure that Entity Framework generates only a <strong>single query</strong> for each task.</p>
<p>Note that because of the random generation of the data output probably will be different.</p>
<h3>Query 1. Products In Range</h3>
<p>Get all products in a specified <strong>price range:</strong> &nbsp;500 to 1000 (inclusive). Order them by price (from lowest to highest). Select only the <strong>product name</strong>, <strong>price</strong> and the <strong>full name</strong> <strong>of the seller</strong>. Export the result to JSON.</p>
<table>
<tbody>
<tr>
<td width="301">
<p><strong>products-in-range.json</strong></p>
</td>
</tr>
<tr>
<td width="301">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "name": "TRAMADOL HYDROCHLORIDE",</p>
<p>&nbsp;&nbsp;&nbsp; "price": 516.48,</p>
<p>&nbsp;&nbsp;&nbsp; "seller": "Christine Gomez"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "name": "Allopurinol",</p>
<p>&nbsp;&nbsp;&nbsp; "price": 518.50,</p>
<p>&nbsp;&nbsp;&nbsp; "seller": "Kathy Gilbert"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "name": "Parsley",</p>
<p>&nbsp;&nbsp;&nbsp; "price": 519.06,</p>
<p>&nbsp;&nbsp;&nbsp; "seller": "Jacqueline Perez"</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 2. Successfully Sold Products</h3>
<p>Get all users who have <strong>at least 1 sold item</strong> with a <strong>buyer</strong>. Order them by <strong>last name</strong>, then by <strong>first name</strong>. Select the person's <strong>first</strong> and <strong>last name</strong>. For each of the <strong>sold products</strong> (products with buyers), select the product's <strong>name</strong>, <strong>price</strong> and the buyer's <strong>first</strong> and <strong>last name</strong>.</p>
<table>
<tbody>
<tr>
<td width="467">
<p><strong>users-sold-products</strong><strong>.json</strong></p>
</td>
</tr>
<tr>
<td width="467">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "firstName": "Carl",</p>
<p>&nbsp;&nbsp;&nbsp; "lastName": "Daniels",</p>
<p>&nbsp;&nbsp;&nbsp; "soldProducts": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name": "Peter Island Continous sunscreen kids",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price": 471.30,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "buyerFirstName": "Anna",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "buyerLastName": "Parker"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name": "Warfarin Sodium",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price": 1379.79,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "buyerFirstName": "Brandon",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "buyerLastName": "Fuller"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 3. Categories By Products Count</h3>
<p>Get <strong>all</strong> <strong>categories</strong>. Order them by the category&rsquo;s<strong> name</strong>. For each category select its <strong>name</strong>, the <strong>number of products</strong>, the <strong>average price of those products</strong> and the <strong>total revenue</strong> (total price sum) of those products (regardless if they have a buyer or not).</p>
<table>
<tbody>
<tr>
<td width="295">
<p><strong>categories-by-products.json</strong></p>
</td>
</tr>
<tr>
<td width="295">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "category": "Sports",</p>
<p>&nbsp;&nbsp;&nbsp; "productsCount": 49,</p>
<p>&nbsp;&nbsp;&nbsp; "averagePrice": 754.327755,</p>
<p>&nbsp;&nbsp;&nbsp; "totalRevenue": 36962.06</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "category": "Adult",</p>
<p>&nbsp;&nbsp;&nbsp; "productsCount": 46,</p>
<p>&nbsp;&nbsp;&nbsp; "averagePrice": 905.283478,</p>
<p>&nbsp;&nbsp;&nbsp; "totalRevenue": 41643.04</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 4. Users and Products</h3>
<p>Get all users who have <strong>at least 1 sold product</strong>. Order them by the <strong>number of sold products</strong> (from highest to lowest), then by <strong>last name</strong> (ascending). Select only their <strong>first</strong> and <strong>last name</strong>, <strong>age</strong> and for each product - <strong>name</strong> and <strong>price</strong>.</p>
<p>Export the results to <strong>JSON</strong>. Follow the format below to better understand how to structure your data.</p>
<table>
<tbody>
<tr>
<td width="566">
<p><strong>users-and-products.json</strong></p>
</td>
</tr>
<tr>
<td width="566">
<p>{</p>
<p>"usersCount":35,</p>
<p>"users":</p>
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "firstName":"Carl",</p>
<p>&nbsp;&nbsp;&nbsp; "lastName":"Daniels",</p>
<p>&nbsp;&nbsp;&nbsp; "age":59,</p>
<p>&nbsp;&nbsp;&nbsp; "soldProducts":</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "count":10,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "products":</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Finasteride",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":1374.01</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Peter Island Continous sunscreen kids",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":471.30</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Warfarin Sodium",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":1379.79</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Gilotrif",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":1454.77</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Cold and Cough",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":218.14</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "firstName": null,</p>
<p>&nbsp;&nbsp;&nbsp; "lastName": "Harris",</p>
<p>&nbsp;&nbsp;&nbsp; "age": 0,</p>
<p>&nbsp;&nbsp;&nbsp; "soldProducts":</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "count":9,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "products":</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Clarins Paris Skin Illusion &ndash; 114 cappuccino",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":811.42</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h1>Car Dealer</h1>
<h2>1. Setup Database</h2>
<p>A car dealer needs information about cars, their parts, parts suppliers, customers and sales.</p>
<ul>
<li><strong>Cars</strong> have <strong>make, model</strong>, travelled distance in kilometers</li>
<li><strong>Parts</strong> have <strong>name</strong>, <strong>price</strong> and <strong>quantity</strong></li>
<li>Part <strong>supplier</strong> have <strong>name</strong> and info whether he <strong>uses imported parts</strong></li>
<li><strong>Customer</strong> has <strong>name</strong>, <strong>date of birth</strong> and info whether he <strong>is young driver</strong> (Young driver is a driver that has <strong>less than 2 years</strong><strong> of experience</strong>. Those customers get <strong>additional 5% off</strong> for the sale.)</li>
<li><strong>Sale</strong> has <strong>car</strong>, <strong>customer </strong>and <strong>discount percentage</strong></li>
</ul>
<p>A <strong>price of a car</strong> is formed by <strong>total price of its parts</strong>.</p>
<p>Using Entity Framework Code First create a database following the above description.</p>
<p>Configure the following relations in your EF models:</p>
<ul>
<li>A <strong>car</strong> has <strong>many parts</strong> and <strong>one part</strong> can be placed <strong>in many cars</strong></li>
<li><strong>One supplier</strong> can supply <strong>many parts</strong> and each <strong>part </strong>can be delivered by <strong>only one supplier</strong></li>
<li>In <strong>one sale</strong>, only <strong>one car</strong> can be sold</li>
<li><strong>Each sale</strong> has <strong>one customer</strong> and <strong>a customer</strong> can buy <strong>many cars</strong></li>
</ul>
<h2>2. Import Data</h2>
<p>Import data from the provided files (<strong>suppliers.json, parts.json, cars.json, customers.json</strong>)</p>
<p>First import <strong>suppliers</strong>. When importing <strong>parts</strong> set to each part <strong>random supplier</strong> from already imported suppliers. Then, when importing cars add <strong>between 10 and 20 random parts</strong> to each car. Then import <strong>all customers</strong>. Finally, import <strong>sales records</strong> by <strong>random </strong>selecting a<strong> car, customer </strong>and the amount of<strong> discount to be applied </strong>(discounts can be 0%, 5%, 10%, 15%, 20%, 30%, 40% or 50%).</p>
<h2>3. Query and Export Data</h2>
<p>Write the below described queries and <strong>export</strong> the returned data to the specified <strong>format</strong>. Make sure that Entity Framework generates only a <strong>single query</strong> for each task.</p>
<h3>Query 1. Ordered Customers</h3>
<p>Get all <strong>customers</strong> ordered by their <strong>birth date ascending</strong>. If two customers are born on the same date <strong>first print those who are not young drivers</strong> (e.g. print experienced drivers first). <strong>Export </strong>the list of customers <strong>to JSON</strong> in the format provided below.</p>
<table>
<tbody>
<tr>
<td width="505">
<p><strong>ordered-customers.json</strong></p>
</td>
</tr>
<tr>
<td width="505">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 29,</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Louann Holzworth",</p>
<p>&nbsp;&nbsp;&nbsp; "BirthDate": " 1960-10-01T00:00:00",</p>
<p>&nbsp;&nbsp;&nbsp; "IsYoungDriver": false,</p>
<p>&nbsp;&nbsp;&nbsp; "Sales": [],</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 28,</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Donnetta Soliz",</p>
<p>&nbsp;&nbsp;&nbsp; "BirthDate": " 1963-10-01T00:00:00",</p>
<p>&nbsp;&nbsp;&nbsp; "IsYoungDriver": true,</p>
<p>&nbsp;&nbsp;&nbsp; "Sales": [],</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 2. Cars from make Toyota</h3>
<p>Get all <strong>cars</strong> from make <strong>Toyota</strong> and <strong>order them by model alphabetically</strong> and by <strong>travelled distance descending</strong>. <strong>Export</strong> the list of <strong>cars to JSON</strong> in the format provided below.</p>
<table>
<tbody>
<tr>
<td width="421">
<p><strong>toyota-cars.json</strong></p>
</td>
</tr>
<tr>
<td width="421">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 117,</p>
<p>&nbsp;&nbsp;&nbsp; "Make": "Toyota",</p>
<p>&nbsp;&nbsp;&nbsp; "Model": "Camry Hybrid",</p>
<p>&nbsp;&nbsp;&nbsp; "TravelledDistance": 954775807,</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 112,</p>
<p>&nbsp;&nbsp;&nbsp; "Make": "Toyota",</p>
<p>&nbsp;&nbsp;&nbsp; "Model": "Camry Hybrid",</p>
<p>&nbsp;&nbsp;&nbsp; "TravelledDistance": 92275807,</p>
<p>&nbsp; },</p>
<p>...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 3. Local Suppliers</h3>
<p>Get all suppliers that do not import parts from abroad. Get their id, name and the number of parts they can offer to supply. Export the list of suppliers to JSON in the format provided below.</p>
<table>
<tbody>
<tr>
<td width="421">
<p><strong>local-suppliers.json</strong></p>
</td>
</tr>
<tr>
<td width="421">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 2,</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Agway Inc.",</p>
<p>&nbsp;&nbsp;&nbsp; "PartsCount": 6</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Id": 4,</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Airgas, Inc.",</p>
<p>&nbsp;&nbsp;&nbsp; "PartsCount": 5</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 4. Cars with Their List of Parts</h3>
<p>Get all <strong>cars along with their list of parts</strong>. For the <strong>car</strong> get only <strong>make, model </strong>and <strong>travelled distance</strong> and for the <strong>parts</strong> get only <strong>name</strong> and <strong>price</strong>. <strong>Export</strong> the list of <strong>cars and their parts to JSON</strong> in the format provided below.</p>
<table>
<tbody>
<tr>
<td width="421">
<p><strong>cars-and-parts.json</strong></p>
</td>
</tr>
<tr>
<td width="421">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "car": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Make": "Opel",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Model": "Omega",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TravelledDistance": 2147483647,</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; "parts": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Front Left Side Outer door handle",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 999.99</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Gudgeon pin",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 44.99</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Oil pump",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 100.19</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Transmission pan",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 106.99</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "car": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Make": "Opel",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Model": "Astra",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TravelledDistance": 9223372036854775807</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; "parts": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Overflow tank",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 1200.99</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 5. Total Sales by Customer</h3>
<p>Get all customers that have bought at least 1 car and get their names, bought cars count and total spent money on cars. Order the result list by total spent money descending then by total bought cars again in descending order. Export the list of customers to JSON in the format provided below.</p>
<table>
<tbody>
<tr>
<td width="421">
<p><strong>customers-total-sales.json</strong></p>
</td>
</tr>
<tr>
<td width="421">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "fullName": "Hipolito Lamoreaux",</p>
<p>&nbsp;&nbsp;&nbsp; "boughtCars": 5,</p>
<p>&nbsp;&nbsp;&nbsp; "spentMoney": 8360.48</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "fullName": "Francis Mckim",</p>
<p>&nbsp;&nbsp;&nbsp; "boughtCars": 4,</p>
<p>&nbsp;&nbsp;&nbsp; "spentMoney": 7115.50</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "fullName": "Johnette Derryberry",</p>
<p>&nbsp;&nbsp;&nbsp; "boughtCars": 4,</p>
<p>&nbsp;&nbsp;&nbsp; "spentMoney": 5337.72</p>
<p>&nbsp; },</p>
<p>...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>Query 6. Sales with Applied Discount</h3>
<p>Get all <strong>sales</strong> with information about the <strong>car</strong>, <strong>customer</strong> and <strong>price</strong> of the sale <strong>with and without discount</strong>. <strong>Export</strong> the list of sales <strong>to JSON</strong> in the format provided below.</p>
<table>
<tbody>
<tr>
<td width="421">
<p><strong>sales-discounts.json</strong></p>
</td>
</tr>
<tr>
<td width="421">
<p>&nbsp;[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "car": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Make": "Peugeot",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Model": "405",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TravelledDistance": 92036854775807</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; "customerName": "Donnetta Soliz",</p>
<p>&nbsp;&nbsp;&nbsp; "Discount": 0.3,</p>
<p>&nbsp;&nbsp;&nbsp; "price": 1402.53,</p>
<p>&nbsp;&nbsp;&nbsp; "priceWithDiscount": 981.771</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "car": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Make": "Mercedes",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Model": "W124",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TravelledDistance": 2147647</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; "customerName": "Carri Knapik",</p>
<p>&nbsp;&nbsp;&nbsp; "Discount": 0.2,</p>
<p>&nbsp;&nbsp;&nbsp; "price": 254.96999999999997,</p>
<p>&nbsp;&nbsp;&nbsp; "priceWithDiscount": 203.97599999999997</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>