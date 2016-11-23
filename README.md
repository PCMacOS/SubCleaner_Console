# SubCleaner_Console
Hello there!!<br>
This is a C# script to "clean" duplicate text sub from subtitles. It is a part from another project from me "SubCleaner".<br>
For example, at folder "Prototype subs for subcleaner" have 2 subs.<br>
First sub type is ".ass" (this is a 3D subtitle) so if we want to convert to 2D we have the second sub type ".str".<br>
The problem is at ".str" all text is duplicate so we won’t this script to "clean it" duplicates.<br>
<br>
<br>
~Example text from olld ".str":<br>
<br>
3<br>
00:00:39,085 --> 00:00:41,09<br>
Όταν ήμουν ξαπλωμένος στο<br>
Στρατιωτικό Νοσοκομείο...<br>
<br>
4<br>
00:00:39,085 --> 00:00:41,099<br>
Όταν ήμουν ξαπλωμένος στο<br>
Στρατιωτικό Νοσοκομείο...<br>
<br>
5<br>
00:00:42,038 --> 00:00:45,007<br>
...με μια μεγάλη τρύπα<br>
στο κέντρο της ζωής μου...<br>
<br>
6<br>
00:00:42,038 --> 00:00:45,007<br>
...με μια μεγάλη τρύπα<br>
στο κέντρο της ζωής μου...<br>
<br>
<br>
 ~Example text from new ".str":<br>
 <br>
 3<br>
00:00:39,085 --> 00:00:41,099<br>
Όταν ήμουν ξαπλωμένος στο<br>
Στρατιωτικό Νοσοκομείο...<br>
<br>
4<br>
...με μια μεγάλη τρύπα<br>
στο κέντρο της ζωής μου...<br>
