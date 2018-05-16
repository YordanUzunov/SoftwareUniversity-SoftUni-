<h1>Подготовка за изпит по "Програмиране за начинаещи"</h1>
<p>Задачи за тренировка за междинен изпит по <a href="https://softuni.bg/courses/programming-basics">&bdquo;Основи на програмирането&ldquo; @ СофтУни</a> (2 март 2016).</p>
<h2>1.&nbsp;&nbsp; Лице на триъгълник в равнината</h2>
<p><strong>Триъгълник в равнината</strong> е зададен чрез координатите на трите си върха. Първо е зададен <strong>върхът </strong>(<strong>x1</strong>, <strong>y</strong><strong>1</strong>). След това са зададени останалите два върха: (<strong>x2</strong>, <strong>y2</strong>) и (<strong>x3</strong>, <strong>y3</strong>), които <strong>лежат на обща хоризонтална права</strong> (т.е. имат еднакви <strong>Y</strong> координати). Напишете програма, която пресмята <strong>лицето на триъгълника</strong> по координатите на трите му върха.</p>
<h3>Вход</h3>
<p>От конзолата се четат <strong>6 цели числа</strong> (по едно на ред):<br /> x1, y1, x2, y2, x3, y3.</p>
<ul>
<li>Всички входни числа са в диапазона [<strong>-</strong><strong>1000</strong>&hellip;<strong>1000</strong>].</li>
<li>Гарантирано е, че y2 = y3.</li>
</ul>
<h3>Изход</h3>
<p><strong>Лицето на триъгълника</strong> да се отпечата на конзолата.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>Вход</strong></p>
</td>
<td width="58">
<p><strong>Изход</strong></p>
</td>
<td width="242">
<p><strong>Чертеж</strong></p>
</td>
<td width="352">
<p><strong>Обяснения</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>5</p>
<p>-2</p>
<p>6</p>
<p>1</p>
<p>1</p>
<p>1</p>
</td>
<td width="58">
<p>7.5</p>
</td>
<td width="242">&nbsp;</td>
<td width="352">
<p>Страната на триъгълника <strong>a</strong> = 6-1 = <strong>5</strong>.</p>
<p>Височината на триъгълника <strong>h</strong> = 1 - (-2) = <strong>3</strong>.</p>
<p>Лицето на триъгълника <strong>S</strong> = a * h / 2 = 5 * 3 / 2 = <strong>7.5</strong>.</p>
</td>
</tr>
<tr>
<td width="50">
<p>4</p>
<p>1</p>
<p>-1</p>
<p>-3</p>
<p>3</p>
<p>-3</p>
</td>
<td width="58">
<p>8</p>
</td>
<td width="242">&nbsp;</td>
<td width="352">
<p>Страната на триъгълника <strong>a</strong> = 3-(-1) = <strong>4</strong>.</p>
<p>Височината на триъгълника <strong>h</strong> = 1 - (-3) = <strong>4</strong>.</p>
<p>Лицето на триъгълника <strong>S</strong> = a * h / 2 = 4 * 4 / 2 = <strong>8</strong>.</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#0">https://judge.softuni.bg/Contests/Practice/Index/157#0</a>.</p>
<h2>2.&nbsp;&nbsp; Пренасяне на тухли</h2>
<p>Строителни работници трябва да пренесат общо x <strong>тухли</strong>. <strong>Работниците</strong> са w на брой и работят едновременно. Те превозват тухлите в колички, всяка с <strong>вместимост</strong> m тухли. Напишете програма, която прочита целите числа x, w и m и пресмята <strong>колко най-малко курса</strong> трябва да направят работниците за да превозят тухлите.</p>
<h3>Вход</h3>
<p>От конзолата се четат <strong>3 цели числа</strong> (по едно на ред):</p>
<ul>
<li><strong>Броят</strong> <strong>тухли</strong> x се чете от първия ред.</li>
<li><strong>Броят</strong> <strong>работници</strong> w се чете от втория ред.</li>
<li><strong>Вместимостта</strong> <strong>на количката</strong> m се чете от третия ред.</li>
</ul>
<p>Всички входни числа са цели и в диапазона [<strong>1</strong>&hellip;<strong>1000</strong>].</p>
<h3>Изход</h3>
<p>Да се отпечата на конзолата <strong>минималният брой курсове</strong>, необходими за превозване на тухлите.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>Вход</strong></p>
</td>
<td width="58">
<p><strong>Изход</strong></p>
</td>
<td width="587">
<p><strong>Обяснения</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>120</p>
<p>2</p>
<p>30</p>
</td>
<td width="58">
<p>2</p>
</td>
<td width="587">
<p>Имаме <strong>2</strong> работника, всеки вози по <strong>30</strong> тухли на курс. Общо работниците возят по <strong>60</strong> тухли на курс. За да превозят <strong>120</strong> тухли, са необходими точно <strong>2 курса</strong>.</p>
</td>
</tr>
<tr>
<td width="50">
<p>355</p>
<p>3</p>
<p>10</p>
</td>
<td width="58">
<p>12</p>
</td>
<td width="587">
<p>Имаме <strong>3</strong> работника, всеки вози по <strong>10</strong> тухли на курс. Общо работниците возят по <strong>30</strong> тухли на курс. За да превозят <strong>310</strong> тухли, са необходими <strong>12</strong> курса: <strong>11</strong> пълни курса превозват <strong>330</strong> тухли и последният <strong>12</strong>-ти курс пренася последните <strong>25</strong> тухли.</p>
</td>
</tr>
<tr>
<td width="50">
<p>5</p>
<p>12</p>
<p>30</p>
</td>
<td width="58">
<p>1</p>
</td>
<td width="587">
<p>Имаме <strong>5</strong> работника, всеки вози по <strong>30</strong> тухли на курс. Общо работниците возят по <strong>150</strong> тухли на курс. За да превозят <strong>5</strong> тухли, е достатъчен само <strong>1</strong> курс (макар и непълен, само с <strong>5</strong> тухли).</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#1">https://judge.softuni.bg/Contests/Practice/Index/157#1</a>.</p>
<h2>3.&nbsp;&nbsp; Точка върху отсечка</h2>
<p>Върху хоризонтална права е разположена <strong>хоризонтална отсечка</strong>, зададена с x координатите на двата си края: first и second. Точка е разположена върху същата хоризонтална права и е зададена с x координатата си. Напишете програма, проверява дали точката е <strong>вътре или вън от отсечката</strong> и изчислява <strong>разстоянието до по-близкия край </strong>на отсечката.</p>
<h3>Вход</h3>
<p>От конзолата се четат <strong>3 цели числа</strong> (по едно на ред):</p>
<ul>
<li>На първия ред стои числото first &ndash; единият край на отсечката.</li>
<li>На втория ред стои числото second &ndash; другият край на отсечката.</li>
<li>На третия ред стои числото point &ndash; местоположението на точката.</li>
</ul>
<p>Всички входни числа са цели и в диапазона [<strong>-1000</strong>&hellip;<strong>1000</strong>].</p>
<h3>Изход</h3>
<p>Резултатът да се отпечата на конзолата:</p>
<ul>
<li>На първия ред да се отпечата &ldquo;in&rdquo; или &ldquo;out&rdquo; &ndash; дали точката е върху отсечката или извън нея.</li>
<li>На втория ред да се отпечата разстоянието от точката от най-близкия край на отсечката.</li>
</ul>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>Вход</strong></p>
</td>
<td width="58">
<p><strong>Изход</strong></p>
</td>
<td width="587">
<p><strong>Визуализация</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>10</p>
<p>5</p>
<p>7</p>
</td>
<td width="58">
<p>in</p>
<p>2</p>
</td>
<td width="587">&nbsp;</td>
</tr>
<tr>
<td width="50">
<p>8</p>
<p>10</p>
<p>5</p>
</td>
<td width="58">
<p>out</p>
<p>3</p>
</td>
<td width="587">&nbsp;</td>
</tr>
<tr>
<td width="50">
<p>1</p>
<p>-2</p>
<p>3</p>
</td>
<td width="58">
<p>out</p>
<p>2</p>
</td>
<td width="587">&nbsp;</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#2">https://judge.softuni.bg/Contests/Practice/Index/157#2</a>.</p>
<h2>4.&nbsp;&nbsp; Точка във фигурата</h2>
<p>Да се напише програма, която проверява дали дадена точка (x, y) е <strong>вътре</strong> или <strong>извън</strong> следната фигура:</p>
<h3>Вход</h3>
<p>От конзолата се четат <strong>2 цели числа</strong> (по едно на ред): x и y.</p>
<p>Всички входни числа са цели и в диапазона [<strong>-1000</strong>&hellip;<strong>1000</strong>].</p>
<h3>Изход</h3>
<p>Да се отпечата на конзолата &ldquo;in&rdquo; или &ldquo;out&rdquo; &ndash; дали точката е <strong>вътре</strong> или <strong>извън</strong> фигурата (на контура е вътре).</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="58">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="58">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="62">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="21">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="62">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>8</p>
<p>-5</p>
</td>
<td width="58">
<p>in</p>
</td>
<td width="49">
<p>8</p>
<p>-5</p>
</td>
<td width="58">
<p>in</p>
</td>
<td width="49">
<p>8</p>
<p>-5</p>
</td>
<td width="62">
<p>in</p>
</td>
<td width="49">
<p>8</p>
<p>-5</p>
</td>
<td width="62">
<p>in</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#3">https://judge.softuni.bg/Contests/Practice/Index/157#3</a>.</p>
<h2>5.&nbsp;&nbsp; Дата след 5 дни</h2>
<p>Дадени са две числа d (ден) и m (месец), които формират <strong>дата</strong>. Да се напише програма, която отпечатва датата, която ще дойде <strong>след 5 дни</strong>. Например 5 дни след <strong>28.03</strong> е датата <strong>2.04</strong>. Приемаме, че месеци април, юни, септември и ноември имат по 30 дни, февруари има 28 дни, а останалите месеци имат по 31 дни. Месеците да се отпечатат с <strong>водеща нула</strong>, когато са едноцифрени (например 01, 08, 12).</p>
<h3>Вход</h3>
<p>Входът се чете от конзолата и се състои от два реда:</p>
<ul>
<li>На първия ред стои едно цяло число d в интервала [1&hellip;31] &ndash; ден. Номерът на деня не надвишава броя дни в съответния месец (например 28 за февруари).</li>
<li>На втория ред стои едно цяло число m в интервала [1&hellip;12] &ndash; месец. Месец 1 е януари, месец 2 е февруари, &hellip;, месец 12 е декември. Месецът може да съдържа водеща нула (например април може да бъде изписан като 4 или 04).</li>
</ul>
<h3>Изход</h3>
<p>Отпечатайте на конзолата един единствен ред, съдържащ дата след 5 дни във формат ден.месец. Месецът трябва да бъде двуцифрено число, с водеща нула ако е необходимо. Денят трябва да е без водеща нула.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="58">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="58">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="62">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="21">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="62">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>28</p>
<p>03</p>
</td>
<td width="58">
<p>2.04</p>
</td>
<td width="49">
<p>27</p>
<p>12</p>
</td>
<td width="58">
<p>1.01</p>
</td>
<td width="49">
<p>25</p>
<p>1</p>
</td>
<td width="62">
<p>30.01</p>
</td>
<td width="49">
<p>26</p>
<p>02</p>
</td>
<td width="62">
<p>3.03</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#4">https://judge.softuni.bg/Contests/Practice/Index/157#4</a>.</p>
<h2>6.&nbsp;&nbsp; Суми от 3 числа</h2>
<p>Дадени са <strong>3 цели числа</strong>. Да се напише програма, която проверява дали <strong>сумата на две от числата е равна на третото</strong>. Например, ако числата са <strong>3, 5 и 2</strong>, сумата на две от числата е равна на третото: <strong>2 + 3 = 5</strong>.</p>
<h3>Вход</h3>
<p>От конзолата се четат <strong>три цели числа</strong>, по едно на ред. Числата са в диапазона [1&hellip;1000].</p>
<h3>Изход</h3>
<ul>
<li>Да се отпечата на конзолата един ред, съдържащ решението на задачата във формат &ldquo;A + B = C&rdquo;, където A, B и C са измежду входните три числа и A &le; B.</li>
<li>Ако задачата няма решение, да се отпечата &bdquo;No&ldquo; на конзолата.</li>
</ul>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="92">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="92">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="62">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="21">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>3</p>
<p>5</p>
<p>2</p>
</td>
<td width="92">
<p>2 + 3 = 5</p>
</td>
<td width="49">
<p>2</p>
<p>2</p>
<p>4</p>
</td>
<td width="92">
<p>2 + 2 = 4</p>
</td>
<td width="49">
<p>1</p>
<p>1</p>
<p>5</p>
</td>
<td width="62">
<p>No</p>
</td>
<td width="49">
<p>2</p>
<p>6</p>
<p>3</p>
</td>
<td width="56">
<p>No</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#5">https://judge.softuni.bg/Contests/Practice/Index/157#5</a>.</p>
<h2>7.&nbsp;&nbsp; Суми през 3</h2>
<p>Дадени са <strong>n</strong> цели числа <strong>a</strong><strong><sub>1</sub></strong>, <strong>a</strong><strong><sub>2</sub></strong>, &hellip;, <strong>a<sub>n</sub></strong>. Да се пресметнат сумите:</p>
<ul>
<li><strong>sum<sub>1</sub></strong> = <strong>a<sub>1</sub></strong> + <strong>a<sub>4</sub></strong> + <strong>a<sub>7</sub></strong> + <strong>&hellip;</strong> (сумират се числата започвайки от първото със стъпка 3)</li>
<li><strong>sum<sub>2</sub></strong> = <strong>a<sub>2</sub></strong> + <strong>a<sub>5</sub></strong> + <strong>a<sub>8</sub></strong> + <strong>&hellip;</strong> (сумират се числата започвайки от второто със стъпка 3)</li>
<li><strong>sum<sub>3</sub></strong> = <strong>a<sub>3</sub></strong> + <strong>a<sub>6</sub></strong> + <strong>a<sub>9</sub></strong> + <strong>&hellip;</strong> (сумират се числата започвайки от третото със стъпка 3)</li>
</ul>
<h3>Вход</h3>
<p>Входните данни се четат от конзолата. На първия ред стои цяло число <strong>n</strong> (<strong>0</strong> &le; <strong>n</strong> &le; <strong>1000</strong>). На следващите <strong>n</strong> реда стоят <strong>n</strong> цели числа в интервала [<strong>-1000</strong>&hellip;<strong>1000</strong>]: <strong>a<sub>1</sub></strong>, <strong>a</strong><strong><sub>2</sub></strong>, &hellip;, <strong>a<sub>n</sub></strong>.</p>
<h3>Изход</h3>
<p>На конзолата трябва да се отпечатат 3 реда, съдържащи търсените 3 суми, във формат като в примерите.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="84">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="92">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="92">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p><strong>2</strong></p>
<p><strong>3</strong></p>
<p><strong>5</strong></p>
</td>
<td width="84">
<p><strong>sum1 = 3</strong></p>
<p><strong>sum2 = 5</strong></p>
<p><strong>sum3 = 0</strong></p>
</td>
<td width="49">
<p><strong>4</strong></p>
<p><strong>7</strong></p>
<p><strong>-2</strong></p>
<p><strong>6</strong></p>
<p><strong>12</strong></p>
</td>
<td width="92">
<p><strong>sum1 = 19</strong></p>
<p><strong>sum2 = -2</strong></p>
<p><strong>sum3 = 6</strong></p>
</td>
<td width="49">
<p><strong>5</strong></p>
<p><strong>3</strong></p>
<p><strong>5</strong></p>
<p><strong>2</strong></p>
<p><strong>7</strong></p>
<p><strong>8</strong></p>
</td>
<td width="92">
<p><strong>sum1 = 1</strong><strong>0</strong></p>
<p><strong>sum2 = </strong><strong>13</strong></p>
<p><strong>sum3 = </strong><strong>2</strong></p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#6">https://judge.softuni.bg/Contests/Practice/Index/157#6</a>.</p>
<h2>8.&nbsp;&nbsp; Поредица от нарастващи елементи</h2>
<p>Дадена е редица от <strong>n</strong> числа: <strong>a</strong><strong><sub>1</sub></strong>, <strong>a</strong><strong><sub>2</sub></strong>, &hellip;, <strong>a<sub>n</sub></strong>. Да се пресметне <strong>дължината на най-дългата нарастваща поредица</strong> от последователни елементи в редицата от числа.</p>
<h3>Вход</h3>
<p>Входните данни се четат от конзолата. На първия ред стои цяло число <strong>n</strong> (<strong>0</strong> &le; <strong>n</strong> &le; <strong>1000</strong>). На следващите <strong>n</strong> реда стоят <strong>n</strong> цели числа в интервала [<strong>-1000</strong>&hellip;<strong>1000</strong>]: <strong>a<sub>1</sub></strong>, <strong>a</strong><strong><sub>2</sub></strong>, &hellip;, <strong>a<sub>n</sub></strong>.</p>
<h3>Изход</h3>
<p>На конзолата трябва да се отпечата едно число &ndash; <strong>дължината</strong> на най-дългата нарастваща редица.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>3</p>
<p>5</p>
<p><strong>2</strong></p>
<p><strong>4</strong></p>
</td>
<td width="56">
<p>2</p>
</td>
<td width="49">
<p>4</p>
<p><strong>2</strong></p>
<p><strong>8</strong></p>
<p>7</p>
<p>6</p>
</td>
<td width="56">
<p>2</p>
</td>
<td width="49">
<p>4</p>
<p><strong>1</strong></p>
<p><strong>2</strong></p>
<p><strong>4</strong></p>
<p>4</p>
</td>
<td width="56">
<p>3</p>
</td>
<td width="49">
<p>4</p>
<p><strong>5</strong></p>
<p><strong>6</strong></p>
<p><strong>7</strong></p>
<p><strong>8</strong></p>
</td>
<td width="56">
<p>4</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#7">https://judge.softuni.bg/Contests/Practice/Index/157#7</a>.</p>
<h2>9.&nbsp;&nbsp; Перфектен диамант</h2>
<p>Да се напише програма, която прочита от конзолата цяло число n и чертае <strong>перфектен</strong> <strong>диамант</strong> с размер n като в примерите по-долу.</p>
<h3>Вход</h3>
<p>Входът е цяло число n в интервала [<strong>1</strong>&hellip;<strong>1000</strong>].</p>
<h3>Изход</h3>
<p>На конзолата трябва да се отпечата диамантът като в примерите.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="76">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="92">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>2</p>
</td>
<td width="56">
<p>&nbsp;*</p>
<p>*-*</p>
<p>&nbsp;*</p>
</td>
<td width="49">
<p>3</p>
</td>
<td width="56">
<p>&nbsp;&nbsp;*</p>
<p>&nbsp;*-*</p>
<p>*-*-*</p>
<p>&nbsp;*-*</p>
<p>&nbsp; *</p>
</td>
<td width="49">
<p>4</p>
</td>
<td width="76">
<p>&nbsp;&nbsp; *</p>
<p>&nbsp; *-*</p>
<p>&nbsp;*-*-*</p>
<p>*-*-*-*</p>
<p>&nbsp;*-*-*</p>
<p>&nbsp; *-*</p>
<p>&nbsp;&nbsp; *</p>
</td>
<td width="49">
<p>5</p>
</td>
<td width="92">
<p>&nbsp;&nbsp;&nbsp; *</p>
<p>&nbsp;&nbsp; *-*</p>
<p>&nbsp; *-*-*</p>
<p>&nbsp;*-*-*-*</p>
<p>*-*-*-*-*</p>
<p>&nbsp;*-*-*-*</p>
<p>&nbsp; *-*-*</p>
<p>&nbsp;&nbsp; *-*</p>
<p>&nbsp;&nbsp;&nbsp; *</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#8">https://judge.softuni.bg/Contests/Practice/Index/157#8</a>.</p>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Правоъгълник със звездички в центъра</h2>
<p>Да се напише програма, която прочита от конзолата цяло число n и чертае <strong>правоъгълник</strong> с размер n <strong>с две звездички в центъра</strong>, като в примерите по-долу.</p>
<h3>Вход</h3>
<p>Входът е цяло число n в интервала [<strong>2</strong>&hellip;<strong>1000</strong>].</p>
<h3>Изход</h3>
<p>На конзолата трябва да се отпечата диамантът като в примерите.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="68">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="84">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="100">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>2</p>
</td>
<td width="56">
<p>%%%%</p>
<p>%**%</p>
<p>%%%%</p>
</td>
<td width="49">
<p>3</p>
</td>
<td width="68">
<p>%%%%%%</p>
<p>%&nbsp;&nbsp;&nbsp; %</p>
<p>% ** %</p>
<p>%&nbsp;&nbsp;&nbsp; %</p>
<p>%%%%%%</p>
</td>
<td width="49">
<p>4</p>
</td>
<td width="84">
<p>%%%%%%%%</p>
<p>%&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;%</p>
<p>%&nbsp; **&nbsp; %</p>
<p>%&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; %</p>
<p>%%%%%%%%</p>
</td>
<td width="49">
<p>5</p>
</td>
<td width="100">
<p>%%%%%%%%%%</p>
<p>%&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; %</p>
<p>%&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; %</p>
<p>%&nbsp;&nbsp; **&nbsp;&nbsp; %</p>
<p>%&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; %</p>
<p>%&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; %</p>
<p>%%%%%%%%%%</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#9">https://judge.softuni.bg/Contests/Practice/Index/157#9</a>.</p>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Четворки нарастващи числа</h2>
<p>По дадена двойка числа <strong>a</strong> и <strong>b</strong> да се генерират всички четворки <strong>n<sub>1</sub></strong>, <strong>n<sub>2</sub></strong>, <strong>n<sub>3</sub></strong>, <strong>n<sub>4</sub></strong>, за които <strong>a</strong> &le; <strong>n<sub>1</sub></strong> &lt; <strong>n<sub>2</sub></strong> &lt; <strong>n<sub>3</sub></strong> &lt; <strong>n<sub>4</sub></strong> &le; <strong>b</strong>.</p>
<h3>Вход</h3>
<p>Входът съдържа две цели числа a и b в интервала [b&hellip;<strong>1000</strong>], по едно на ред.</p>
<h3>Изход</h3>
<p>Изходът съдържа всички търсени <strong>четворки числа</strong>, в нарастващ ред, по една на ред.</p>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="76">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="108">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="108">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>3</p>
<p>7</p>
</td>
<td width="76">
<p>3 4 5 6</p>
<p>3 4 5 7</p>
<p>3 4 6 7</p>
<p>3 5 6 7</p>
<p>4 5 6 7</p>
</td>
<td width="49">
<p>15</p>
<p>20</p>
</td>
<td width="108">
<p>15 16 17 18</p>
<p>15 16 17 19</p>
<p>15 16 17 20</p>
<p>15 16 18 19</p>
<p>15 16 18 20</p>
<p>15 16 19 20</p>
<p>15 17 18 19</p>
<p>15 17 18 20</p>
<p>15 17 19 20</p>
<p>15 18 19 20</p>
<p>16 17 18 19</p>
<p>16 17 18 20</p>
<p>16 17 19 20</p>
<p>16 18 19 20</p>
<p>17 18 19 20</p>
</td>
<td width="49">
<p>5</p>
<p>7</p>
</td>
<td width="56">
<p>No</p>
</td>
<td width="49">
<p>10</p>
<p>13</p>
</td>
<td width="108">
<p>10 11 12 13</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#10">https://judge.softuni.bg/Contests/Practice/Index/157#10</a>.</p>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Генериране на правоъгълници</h2>
<p>По дадено число n и <strong>минимална площ</strong> m да се генерират всички правоъгълници с цели координати в интервала [-n&hellip;n] с площ поне m. Генерираните правоъгълници да се отпечатат в следния формат:</p>
<table width="0">
<tbody>
<tr>
<td width="696">
<p>(left, top) (right, bottom) -&gt; area</p>
</td>
</tr>
</tbody>
</table>
<p>Правоъгълниците се задават чрез горния си ляв и долния си десен ъгъл. В сила са следните неравенства:</p>
<ul>
<li>-n &le; left &lt; right &le; n</li>
<li>-n &le; top &lt; bottom &le; n</li>
</ul>
<h3>Вход</h3>
<p>От конзолата се въвеждат две числа, по едно на ред:</p>
<ul>
<li>Цяло число n в интервала [<strong>1</strong>&hellip;<strong>100</strong>] &ndash; задава минималната и максималната координата на връх.</li>
<li>Цяло число m в интервала [<strong>0</strong>&hellip;<strong>50000</strong>] &ndash; задава минималната площ на генерираните правоъгълници.</li>
</ul>
<h3>Изход</h3>
<ul>
<li>На конзолата трябва да се отпечатат описаните правоъгълници във формат като в примерите по-долу.</li>
<li>Ако за числата n и m няма нито един правоъгълник, да се изведе &ldquo;No&rdquo;.</li>
<li>Редът на извеждане на правоъгълниците е без значение.</li>
</ul>
<h3>Примерен вход и изход</h3>
<table width="0">
<tbody>
<tr>
<td width="50">
<p><strong>вход</strong></p>
</td>
<td width="181">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="56">
<p><strong>изход</strong></p>
</td>
<td rowspan="2" width="26">
<p><strong>&nbsp;</strong></p>
</td>
<td width="49">
<p><strong>вход</strong></p>
</td>
<td width="189">
<p><strong>изход</strong></p>
</td>
</tr>
<tr>
<td width="50">
<p>1</p>
<p>2</p>
</td>
<td width="181">
<p>(-1, -1) (0, 1) -&gt; 2</p>
<p>(-1, -1) (1, 0) -&gt; 2</p>
<p>(-1, -1) (1, 1) -&gt; 4</p>
<p>(-1, 0) (1, 1) -&gt; 2</p>
<p>(0, -1) (1, 1) -&gt; 2</p>
</td>
<td width="49">
<p>2</p>
<p>17</p>
</td>
<td width="56">
<p>No</p>
</td>
<td width="49">
<p>3</p>
<p>36</p>
</td>
<td width="189">
<p>(-3, -3) (3, 3) -&gt; 36</p>
</td>
</tr>
</tbody>
</table>
<p>Тестване на решението: <a href="https://judge.softuni.bg/Contests/Practice/Index/157#11">https://judge.softuni.bg/Contests/Practice/Index/157#11</a>.</p>
