# CoViD
 C# model for the spread of COVID-19, implemented without any SIR equations.

<!DOCTYPE html>
<!-- saved from url=(0069)https://www.codeproject.com/script/Articles/ViewHtml.aspx?aid=5306075 -->
<html><head><meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

<link rel="stylesheet" type="text/css" href="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Main.css">
<!--<base href="https://www.codeproject.com/KB/Articles/">--><base href=".">
</head>
<body data-new-gr-c-s-check-loaded="14.1018.0" data-gr-ext-installed="" style="padding:40px 40px 40px 40px;background-color:#eee;color:green;">
<!--
HTML for article "CoViD Spread Simulation (no SIR equations)" by CodeErgoSum
URL: https://www.codeproject.com/KB/Articles/5306075.aspx
Copyright 2021 by CodeErgoSum
All formatting, additions, and alterations Copyright © CodeProject, 1999-2021
-->




<hr class="Divider subdue">
<div>




<!-- Start Article -->
<span id="ArticleContent">


<ul class="download">
	<li><a href="https://github.com/coGit-ergo-sum/CoViD/blob/main/Setup/Debug/Setup.msi">Download setup - 779.2 KB</a></li></ul>

<p><em><strong>Note</strong>: Unzip this file and choose one between the two files to set up the application: the '<strong>exe</strong>' or the '<strong>msi</strong>'.</em></p>

<p><em><strong>Note</strong>: The development of this application is still in progress, and it is not possible to change the configuration of the parameters for the viruses, the region, and the person '.</em></p>

<ul class="download">
	<li><a href="https://github.com/coGit-ergo-sum/CoViD/blob/main/GUI/Images/New/2021-06-25.1.CoViD.zip">Download source code - 2.7 MB</a></li></ul>

<p><em><strong>Note</strong>: Download this zip file, only if you want to have a quick look at the source code of this project. For more structured actions, refer to the GitHub repository, where there is always an updated version of all the code.</em></p>

<!--ul class="download">
	<li><a href="https://github.com/coGit-ergo-sum/CoViD" target="_blank">Download from GitHub </a></li></ul-->

<h2>Forewords</h2>

<p>This project is not meant to be a substitute for the SIR model. The goal is to develop a tool that can give a <strong>computational representation</strong> for the spread of the disease. The hope for this project is that it could become an effective complement to other well-established solutions.</p>

<h2>Introduction</h2>

<p>The SIR model is a very powerful tool (no doubt), but it was developed a century ago when scientific paradigms were different. Looking today at SIR with a critical eye, it immediately appears that it suffers from some approximations that limit its ability to represent reality.</p>

<p>That means:</p>

<ul>
	<li>SIR is a linear model, and nature is anything but linear.
	<p>(<em>Let me suggest this video: <a href="https://www.youtube.com/watch?v=R6NnCOs20GQ">The secret life of chaos</a> from Professor Jim Al-Khalili, BBC 4</em>)</p>

	<iframe style="width:560px; height:315px" src="./Article Source_files/R6NnCOs20GQ.html" allowfullscreen="true"></iframe>
	</li>	<li>The 'R' in 'SIR' stands for 'Recovered', and it doesn't matter if the person is healed or has died!</li>	<li>The SIR model doesn't have the dependency on 'time'. (SIR can 'predict' how S I and R will evolve, but not when it will happen. See the chapter "The tab SIR")</li>	<li>The spread of a disease can have waves (Covid has had at least 3 waves). The SIR model cannot have waves. It always results in an exponential evolution of the disease. In nature, all the <a href="https://en.wikipedia.org/wiki/Oscillation" target="_blank">"systems" that can have "waves"</a> have always two elements, each one acting "against" the other. (<em>In my personal opinion, this is the evidence that the SIR model is an over-simplified model, and it lacks a fundamental component capable of introducing the oscillatory nature that many epidemics have shown.</em>)</li></ul>

<p>After a century, SIR is squeezed like a lemon, but its limitations still remain. Perhaps, new ways to tackle the same problem will lead to new solutions. So, I believe, there is enough room to think about other, complementary models.</p>

<p>My try was to develop a C# application, to model the reality defining:</p>

<ul>
	<li><code>region</code> (a selected surface, for example, a city;)</li>	<li><code>people</code> that move over the region</li>	<li><code>disease</code> (CoViD for example)</li></ul>

<p>A disease contaminates an area (a red dot in the right GUI panel) when someone moves over the area (a dot in the left GUI panel) becomes infected and after a short latency, becomes ill. The infected person, sneezing or touching, contaminates other points in the region. After a while, the person recovers as well as the area stops being contaminated.</p>

<p>To let the model better adhere to reality, there are also other entities that act like 'accumulation points': schools, hospitals, and offices. Other factors are not yet implemented. For example, the vital dynamics; Immunity is not forever (as supposed here); vaccination campaigns.</p>

<p>The evolution of the virus into an infected body is an array of values.</p>

<p>One first result of this approach shows that the disease's spread is tightly correlated with the topology, instead of the characteristics of the virus.</p>

<p>The model allows for the parametrization of most of the key factors affecting the spread of the disease. On the one hand, that makes the model very powerful, being able to represent many possible dynamics. On the other hand, all this versatility can be disorienting.</p>

<h2>Background</h2>

<p>The project is developed in C#. The solution is a 'DESKTOP' application, developed using Visual Studio Community 2019 ver 16.4.5.</p>

<p>The architecture is simple. Sometimes algorithms are not. All the code is widely commented on. A help file is on the way: a CHM file produced with Sandcastle.</p>

<h2>The Graphical Interface</h2>

<h3>Form: <strong>Spread</strong></h3>

<p>This is the main form. It should be intuitive; in any case, moving the mouse over every label will show a tooltip. The image shows a snapshot of a running simulation. The '<strong>Toolstrip</strong>' at the top of the page provides all the needed functionalities.</p>

<p><img height="30px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/ToolStrip.PNG?raw=true" width="218px"></p>

<ul>
	<li>A <strong>Settings</strong> page</li>	<li><strong>Snapshots</strong> of the form</li>	<li>Run a <strong>new simulation</strong></li>	<li><strong>Restart</strong> the current simulation</li>	<li><strong>Stop/start</strong> the current simulation</li></ul>

<p>The tab <b>Region</b></p>

<p>This tab contains two panels. Both of them represent the propagation of CoViD over a given region. The two diagrams should overlap into a single diagram, but that would make the graphics too confusing. So:</p>

<p>The <strong>left panel</strong> shows the people living in the region. Each dot is a person. Different colors represent different health conditions. When a person became ill (pink dots) starts to be contagious. A contagious person, sneezing and touching, contaminate the areas of the region where he moves. Other people moving in the same contaminated area get infected.</p>

<p>The <strong>right panel</strong> shows the same region, but in this case, red dots show the evolution of the contamination.</p>

<p><img src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Form.Spread.1.png?raw=true" style="width: 640px; height: 406px"></p>

<p>The tab <b>SIR</b></p>

<p>This diagram shows the data grouped following the same criteria adopted for the S.I.R model. The result is the evolution of the <strong>S</strong>usceptible, <strong>I</strong>nfected, and <strong>R</strong>ecovered.<br>
That proves the correctness of the new model and (much more important) proves the new model can show better dynamics than the SIR.</p>

<p><em>About the note in the introduction: this diagram is coherent with the SIR diagrams from the SIR model. In fact, the green and the blue function never decrease, and shrinking time (not always of the same amount) will produce the classic SIR representation.</em></p>

<p><img src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/2021-06-24.11-37-05.Form.tabSIR.png?raw=true" style="height: 405px; width: 640px"></p>

<p>The tab <b>Delta SIR</b></p>

<p>This is another important diagram. It shows the gap between the S.I.R model and the 'reality (at least the reality as it is 'implemented' in this application).</p>

<p>The <a href="https://en.wikipedia.org/wiki/Compartmental_models_in_epidemiology" target="_blank">S.I.R. equations</a> [wikipedia] are the solutions of the following system of differential equations:</p>

<p><img src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/SIREquations1.png?raw=true" style="width: 517px; height: 57px"></p>

<p>This system is solved by exponential function just because <strong>ß and γ are supposed constant</strong>. We can revert the first and the last equation to get the expressions for ß and γ</p>

<p><img height="52px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/BetaGamma.gif" width="300px"></p>

<p>(<em>where N = S + I + R</em>)</p>

<p>Since:</p>

<ul>
	<li>each iteration of this application provides the evolution for the values S, I, and R (over time)</li>	<li>dS and dR are the increments of S and R between two consecutive iteration</li>	<li>we can set dt = 1 (or any other constant value. the only effect is to strech the y-axes)</li></ul>

<p>Hence, we have all the data to evaluate ß and γ. So in the below diagram:</p>

<ul>
	<li>ß is the red function</li>	<li>γ is the green function</li></ul>

<p><img src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/2021-06-25.12-34-04.Form.tabDSIR.png?raw=true" style="height: 405px; width: 640px"></p>

<p>The image shows that from the point of view of this model, <strong>ß and γ are not constant</strong> at all. To think them to be constants could be acceptable in a small round of any given point. Instead, the resulting exponential is used to represent the whole evolution and that is truly a very big approximation.</p>

<p>(<em>The development of this diagram is still in progress and must be analyzed carefully because some strange result appears: both values ß and γ have a strange overflow, and the green diagram seems to be a multi-valued function.</em>)</p>

<p>The tab <b>Contaminated points</b></p>

<p>This diagram shows the evolution of the number of contaminated points in the region.</p>

<p><img src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/2021-06-25.12-55-59.Form.tabContaminated.png?raw=true" style="width: 640px; height: 405px"></p>

<p>The tab <b>Performances</b></p>

<p>This diagram shows the evolution of the computational power needed to run the model.</p>

<p><img src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/2021-06-25.01-00-34.Form.tabPerformances.png?raw=true" style="width: 640px; height: 405px"></p>

<h3>Form: <strong>Settings</strong></h3>

<p>The <strong>first button</strong> (the gear) of the '<strong>toolStrip</strong>' opens the Settings dialog:</p>

<p><img height="30px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/ToolStrip.PNG?raw=true" width="218px"></p>

<p><img height="533px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Form.Settings.png?raw=true" width="568px"></p>

<p>That shows two sets of settings. The <strong>first tab</strong>: contains the 'up-down' controls are used to set:</p>

<ul>
	<li><strong>People</strong>: How many people live in the region</li>	<li><strong>Radius</strong>: The radius of a region in meter</li>	<li><strong>Steps</strong>: The distribution of people over the region</li>	<li><strong>Ticks</strong>: The number of unity of time the simulation lasts</li>	<li><strong>Isolation level</strong>: The percentage of people segregate at home against people allowed to move</li></ul>

<p>It is not easy to explain what the '<strong>Steps</strong>' button does. Maybe the inner code will help:</p>

<p>(<em>File 'Extension.Random.cs' line 13, Project 'Tools'</em>)</p>

<pre class="lang-csharp" data-language="cs" data-allowshrink="True" datacollapse="False">/// <span class="code-summarycomment">&lt;summary&gt;
</span>/// Returns a non-negative random integer between 'min' and 'max'.
/// <span class="code-summarycomment">&lt;/summary&gt;
</span>/// <span class="code-summarycomment">&lt; param name="rnd"&gt; The current instance of the 'System.Random' object.&lt;/param&gt;
</span>/// <span class="code-summarycomment">&lt;param name="min"&gt;The min value for the resulting value.&lt;/param&gt;
</span>/// <span class="code-summarycomment">&lt;param name="max"&gt;The max value for the resulting value.&lt;/param&gt;
</span>/// <span class="code-summarycomment">&lt;param name="iterations"&gt;Set the distribution 1:
</span>///        Linear (omogeneous) 2: Triangular; ... Gaussian<span class="code-summarycomment">&lt;/param&gt;
</span>/// <span class="code-summarycomment">&lt;returns&gt; A  random value between min and max with a specified distribution.
</span>/// <span class="code-summarycomment">&lt;/returns&gt;
</span>public static int Next(this System.Random rnd, int min, int max, byte iterations)
{
    int tot = 0;
    for (byte i = 0; i &lt; iterations; i++)
    {
        tot += rnd.Next(min, max);
    }
    return tot/iterations;
}
</pre>

<p>The 'extension method' '<code>Next</code>' of the object '<code>System.Random</code>' creates a random number:</p>

<p>If '<code>iterations = 1</code>', the distribution is homogeneous (linear), the same distribution as when a single die is rolled.<br>
If '<code>iterations = 2</code>', the distribution is triangular, the same distribution when two dies are rolled.<br>
If '<code>iterations = 3</code>', the distribution is parabolic, the same distribution when three dies are rolled.<br>
...<br>
When infinite dice are rolled, the distribution of the result is a Gaussian.</p>

<p>So, since '<code>Steps</code>' is the value provided to the parameter 'Iteration' of the method '<code>Next</code>', Steps controls the distribution of people around the center of the region.</p>

<p>The <strong>second tab</strong> simply shows the settings for the forms as they are stored in the INI file.</p>

<p>The menu File opens the file INI directly into your default text editor:</p>

<p><img height="113px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Settings.File.png?raw=true" width="204px"></p>

<p>Using an INI file is a very old technique, but it works quite well, and please note how easy it is to store the location and size of the loading form:</p>

<pre class="lang-csharp" data-language="cs" data-allowshrink="True" datacollapse="False">Program.INIGUI.Write(this.Name, "Location", this.Location);
Program.INIGUI.Write(this.Name, "Size", this.Size);
</pre>

<p>The <strong>second button</strong> (the camera) takes snapshots of the application: the whole form or only the diagram.</p>

<p>The <strong>last three green buttons</strong> control the computation of the model.</p>

<h2>Class Diagrams</h2>

<h3>Class <strong>Grid</strong></h3>

<p>It is a square region made of points. (<em>Simulates the place where people live and where the epidemic spreads.</em>) Analyzing the grid means to loop over a matrix. To avoid this, there is the field "<code>contaminated</code>", a list of points referencing contaminated points over the grid. Experience shows this list is always a small fraction of the grid, and that makes this solution strategically acceptable for preserving performance.</p>

<p><img height="743px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Grid.png?raw=true" width="259px"></p>

<p>Another key concept is '<code>Ticks</code>', a unity of time (20 minutes, more or less) based on the dynamics of the virus and designed to take a limited number of '<code>Ticks</code>' to describe the full evolution of a virus.</p>

<h3>Class <strong>Person</strong></h3>

<p>Fundamentally, a person moves over a region, can be infected and recovers. <code>Person.<b>Viruses</b></code> is the number of viruses in the body of the person. (<em>Should be regarded as the number of "unities" of viruses in the body of the person.</em>). <code>Person.<b>Locations</b></code> (list of points) the coordinates of the key points reached by the person. The person moves from one location to another with many 'steps' along a segment joining two consecutive locations. (The full movement is a broken line starting from the first location -usually home- to the last location.)</p>

<p><img height="1033px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Person.png?raw=true" width="307px"></p>

<h3>Class <strong>Population</strong></h3>

<p>This class is merely a container for statistical data.</p>

<p><img height="402px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Popolation.png?raw=true" width="235px"></p>

<p>The last class is '<code>Virus</code>', it is empty. That's because it is not important to model how the viruses evolve. What we care about is the final result: an array of the number of viruses (in a person) as a function of time.</p>

<h2>Points of Interest</h2>

<p>Many questions were raised while writing this project:</p>

<ul>
	<li>Theoretically, an infection can start even if a single virus attacks a body. Is that true?</li>	<li>There are viruses that are very lethal, CoViD19 seems to be lethal mainly for elderly people. Should we count the death of a sick and old person the same as the death of a young and strong person? Is that ethically correct? Is that analytically correct?</li>	<li>Which can be a model of a disease capable of killing (only) a sick person? A proposed solution is to count the number of lost residual days of life, instead of the life itself.</li>	<li>Is the model implemented in this project good enough? Are there any other factors that must be taken into account?</li></ul>

<p>Out of these questions, there are a couple of 'Points of interest': One is The 'Watcher'.</p>

<p><img src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/watcher.png" style="width: 640px; height: 400px"></p>

<p>A simple application designed to keep watching a folder to back up any changes. It is a simple tool that saved my life many times (I mean, professional life ;-) Anytime a debug session starts a history of all the changes is stored, providing a kind of much more effective '<strong>CTRL-Z</strong>'.</p>

<p>The other is the '<strong>Tool</strong>' project: a collection of functionalities and extension methods to make the life of the developer much easier. Between all of them, I like this:</p>

<p><img height="450px" src="https://github.com/coGit-ergo-sum/CoViD/blob/main/CodeProject/Article%20Source_files/Extension.String.PNG" width="361px"></p>

<p>In particular, the method '<code>isNull</code>' and its complementary '<code>isNotNull</code>'. Why? Think a little about them. They are absurd: you can write:</p>

<pre class="lang-csharp" data-language="cs" data-allowshrink="True" datacollapse="False">var x = someString.IsNotNull();

var y = someOtherString.IsNull();</pre>

<p>Without throwing any 'null reference' exception (<em>that just because 'extension methods' are only a syntactical convention to call static methods</em>).</p>

<h2>History</h2>

<ul>
	<li>April-June 2020: I developed this application during the first lockdown</li>	<li>22<sup>nd</sup> May, 2021: Initial version. It took one year to take the decision to publish this work.</li>	<li>28<sup>th</sup> May, 2021: Published a second version.</li>	<li>25<sup>th</sup> June, 2021: Published the current version</li></ul>


</span>
<!-- End Article -->




</div> 


</body></html>
