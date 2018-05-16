<p>Problem 4 &ndash; Hospital</p>
<p>Your task will be to prepare an electronic register for a hospital. In the hospital we have different departments:</p>
<ul>
<li>Cardiology</li>
<li><a href="https://en.wikipedia.org/wiki/Oncology">Oncology</a></li>
<li><a href="https://en.wikipedia.org/wiki/Emergency_department">Emergency department</a></li>
<li></li>
</ul>
<p>Each department has <strong>20 </strong>rooms for patients and <strong>each room</strong> <strong>has 3 beds</strong>. When a new patient goes in the hospital, he/she is placed on the first free bed in the department. If there are no free beds, the patient should go in another hospital. Of course, in every hospital there are doctors. Each doctor can have patients in a different department. You will receive information about patients in the format <strong>{Department} {Doctor} {Patient}</strong></p>
<p>After the "Output" command you will receive some other commands with what kind of output you need to print. The commands are:</p>
<ul>
<li><strong>{Department} </strong>&ndash; You need to <strong>print all patients</strong> in this department in the <strong>order of receiving</strong></li>
<li><strong>{Department} {Room} </strong>&ndash; You need to <strong>print all patients</strong> in this room in <strong>alphabetical order</strong></li>
<li><strong>{Doctor} </strong>&ndash; you need to <strong>print all patients</strong> for this doctor in <strong>alphabetical order</strong></li>
</ul>
<p>The program ends when you receive command "End".</p>
<h3>Input</h3>
<p>On the first lines you will receive info for the hospital, department, doctors and patients in the following format:</p>
<p><strong>{Department} {Doctor} {Patient}</strong></p>
<p>When you read the "<strong>Output</strong>" line you will get one or more commands telling you what you need to print</p>
<p>Read commands for printing, &lsquo;till you reach the command "<strong>End</strong>"</p>
<h3>Output</h3>
<ul>
<li><strong>{Department} </strong>&ndash; print all patients in this department in order of receiving on new line</li>
<li><strong>{Department} {Room} </strong>&ndash; print all patients in this room in alphabetical order each on new line</li>
<li><strong>{Doctor} </strong>&ndash; print all patients that are healed from doctor in alphabetical order on new line</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>{Department} </strong>&ndash; single word with length <strong>1 &lt; n &lt; 100</strong></li>
<li><strong>{Doctor} </strong>&ndash; name and surname, both with length <strong>1 &lt; n &lt; 20</strong></li>
<li><strong>{Patient}</strong> &ndash; unique name with length <strong>1 &lt; n &lt; 20</strong></li>
<li><strong>{Room} </strong>&ndash; integer <strong>1 &lt;= n &lt;= 20</strong></li>
<li>Time limit: 0.3 sec. Memory limit: 16 MB.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="0">
<tbody>
<tr>
<td width="285">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="285">
<p>Cardiology Petar Petrov Ventsi</p>
<p>Oncology Ivaylo Kenov Valio</p>
<p>Emergency Mariq Mircheva Simo</p>
<p>Cardiology Genka Shikerova Simon</p>
<p>Emergency Ivaylo Kenov NuPogodi</p>
<p>Cardiology Gosho Goshov Esmeralda</p>
<p>Oncology Gosho Goshov Cleopatra</p>
<p>Output</p>
<p>Cardiology</p>
<p>End</p>
</td>
<td width="92">
<p>Ventsi</p>
<p>Simon</p>
<p>Esmeralda</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="285">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="285">
<p>Cardiology Petar Petrov Ventsi</p>
<p>Oncology Ivaylo Kenov Valio</p>
<p>Emergency Mariq Mircheva Simo</p>
<p>Cardiology Genka Shikerova Simon</p>
<p>Emergency Ivaylo Kenov NuPogodi</p>
<p>Cardiology Gosho Goshov Esmeralda</p>
<p>Oncology Gosho Goshov Cleopatra</p>
<p>Output</p>
<p>Cardiology 1</p>
<p>End</p>
</td>
<td width="92">
<p>Esmeralda</p>
<p>Simon</p>
<p>Ventsi</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td width="285">
<p><strong>Input</strong></p>
</td>
<td width="84">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="285">
<p>Cardiology Petar Petrov Ventsi</p>
<p>Oncology Ivaylo Kenov Valio</p>
<p>Emergency Mariq Mircheva Simo</p>
<p>Cardiology Genka Shikerova Simon</p>
<p>Emergency Ivaylo Kenov NuPogodi</p>
<p>Cardiology Gosho Goshov Esmeralda</p>
<p>Oncology Gosho Goshov Cleopatra</p>
<p>Output</p>
<p>Ivaylo Kenov</p>
<p>End</p>
</td>
<td width="84">
<p>NuPogodi</p>
<p>Valio</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>