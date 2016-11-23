# SubCleaner_Console
Hello there!!
This is a C# script to "clean" duplicate text sub from subtitles. It is a part from another project from me "SubCleaner"
For example, at folder "Prototype subs for subcleaner" have 2 subs. 
First sub type is ".ass" (this is a 3D subtitle) so if we want to convert to 2D we have the second sub type ".str".
The problem is at ".str" all text is duplicate so we won’t this script to "clean it" duplicates.


~Example text from olld ".str":

3
00:00:39,085 --> 00:00:41,099
Όταν ήμουν ξαπλωμένος στο
Στρατιωτικό Νοσοκομείο...

4
00:00:39,085 --> 00:00:41,099
Όταν ήμουν ξαπλωμένος στο
Στρατιωτικό Νοσοκομείο...

5
00:00:42,038 --> 00:00:45,007
...με μια μεγάλη τρύπα
στο κέντρο της ζωής μου...

6
00:00:42,038 --> 00:00:45,007
...με μια μεγάλη τρύπα
στο κέντρο της ζωής μου...


 ~Example text from new ".str":
 
 3
00:00:39,085 --> 00:00:41,099
Όταν ήμουν ξαπλωμένος στο
Στρατιωτικό Νοσοκομείο...

4
...με μια μεγάλη τρύπα
στο κέντρο της ζωής μου...
