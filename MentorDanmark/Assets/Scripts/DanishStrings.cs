using UnityEngine;
using System.Collections;

//indholder stings til dansk text til appen.

public class DanishStrings : MonoBehaviour {
	
	
	public DanishStrings (){
	}
	
	public string SubTitleResult {get {return "Læringsstilstest Resultater";}}
	
	public string SubTitleThinkingStyle {get {return "Tænkestil";}}
	
	public string SubTitlePreferences {get {return "Læringspræferencer";}}
	
	public string SubTitleEnvironment {get {return "Læringsmiljø";}}
	
	public string EnvirLightOn{get {return "- Sørg for at arbejde ved en god lampe eller tæt på vinduet";}}
	public string  EnvirLightOff{ get {return "";}}
	
	public string EnvirSoundOn{get {return "- Sørg for at sidde et sted med baggrundsstøj fra andre eller musik";}}
	public string EnvirSoundOff{get {return "";}}
	
	public string EnvirTempHot{get {return "";}}
	public string EnvirTempCold{get {return "- Sørg for at sidde et køligt sted";}}
	
	public string EnvirConfertTable{get {return "- Sørg for at sidde ved et godt bord";}}
	public string EnvirConfertSofa{get {return "";}}
	
	public string EnvirMovment{get {return "- Sørg for at holde bevægelsespauser";}}
	
	
	public string TitleAnalyst {get {return "Du er primært analytikker";}}
	
	public string TitleAnalyst2Part1 {get {return "Du er ";}}
	public string TitleAnalyst2Part2  {get {return "% analytikker";}}
	
	public string DescpriptionAnalyst {get {return "Som analytiker foretrækker du at arbejde med én opgave ad gangen. Det er væsentligt, at der er system i arbejdet, og der er mulighed for at lægge vægt på detaljerne.Du søger faste rammer, når der skal læres, og du har derfor brug for at planlægge dit arbejde, så der er en god logik og struktur i rækkefølgen. Du kan lide at arbejde fokuseret og koncentreret uden afbrydelser og forstyrrelser og foretrækker også at komme hurtigt i gang med opgaverne.Du skal derfor sørge for at: \n-Planlægge en rækkefølge for opgaverne fra starten \n-Gå direkte i gang med opgaverne – én ad gangen \n-Have god orden og struktur i tingene – gerne konkrete anvisninger \n-Give tid til detaljerne";}}
	
	
	public string TitleHolistic1 {get {return "Du er primært holitisk";}}
	
	public string TitleHolistic2Part1 {get {	return "Du er ";}}
	
	public string TitleHolistic2Part2 {get {return "% holist";}}
	
	public string DescpriptionHolistic {get {return "Som holist lærer du bedst, når du har overblik over opgaven som helhed, og når du kan se et klart formål med den.Det er vigtigt, at du får indflydelse på arbejdsformen og dermed kan skabe egen struktur – som ikke nødvendigvis altid er logisk for andre.  Du har brug for pauser fra arbejdet, hvor du taler om noget andet eller går i gang med nye opgaver. Du behøver ikke færdiggøre opgaven, før du starter på en ny. Det er også vigtigt, at der er en god og hyggelig atmosfære omkring dig i læringssituationen.Som holist skal du derfor sørge for at:\n-Relatere opgaven til virkeligheden\n-Give dig tid til at undersøge hele opgaven/stoffet\n-Variere opgaverne. Du må gerne arbejde med flere på én gang\n-Følge din intuition";}}
	
	
	public string TitleVisual1 {get {	return " Du er primært visuel";}}
	
	public string TitleVisual2Part1 {get {return "Du er ";}}
	
	public string TitleVisual2Part2 {get {return "% visuel";}}
	
	public string DescpriptionVisual {get {return "Når du lærer bedst visuelt, skal indholdet vises. Det kan enten gøres via skriftlige instruktioner, tekstbøger og billeder.Når noget nyt og vanskeligt skal læres, har du som visuel brug for at skrive eller tegne noter.Det er derfor vigtigt, at du som visuel, gør brug af:\n-Trykte billeder og tekster \n-Grafer og illustrationer\n-Noter, mens du lærer\n-Indre billeder, mens du lærer";}}
	
	
	public string TitleAuditory1 {get {return "Du er primært auditiv";}}
	
	public string TitleAuditory2Part1 {get {return "Du er ";}}
	
	public string TitleAuditory2Part2 {get {return "% auditiv";}}
	
	public string DescpriptionAuditory {
		get {return "Når du lærer bedst auditivt, betyder det, at du har brug for at få opgaven fortalt og forklaret mundtligt. Som auditiv foretrækker du at få læst opgaven højt og lytte til lydbøger, når det nye skal læres. Det er vigtigt for dig at få muligheden for at genfortælle og debattere indholdet og opgaven.Det er derfor vigtigt, at du som auditiv, gør brug af:\n-Lydbøger\n-At tale med andre om stoffet\n-At bede om at få opgaven forklaret\n-Små huskeregler og remser";}}
	
	
	public string TitleTactile1 {get {return "Du er primært taktil";}}
	
	public string TitleTactile2Part1 {get {return "Du er ";}}
	
	public string TitleTactile2Part2 {get {return "% taktil";}}
	
	public string DescpriptionTactile {get {return "Som taktil lærer du bedst, når du får lov til at bruge hænderne.Det er vigtigt, at du selv styrer blyanten og også har mulighed for at sidde med noget i hænderne, når der blot skal lyttes. Du foretrækker at løse praktiske opgaver med konkret materiale, e.g. spil. For nemmere at bevare koncentrationen, når du lærer, er det godt at skrive noter, lave illustrationer eller strege nøgleord under i teksten.Det er derfor vigtigt, at du som taktil, gør brug af:\n-At lave noter, illustrationer\n-At strege nøgleord ud i tekster\n-At bede bruge spil til at lærer stoffet\n-At sidde med noget i hånden, e.g. en stressbold";}}
	
	
	
	public string TitleKinesthetic1 {get {return "Du er primært kinæstetisk";}}
	
	public string TitleKinesthetic2Part1 {get {return "Du er ";}}
	
	public string TitleKinesthetic2Part2 {get {return "% kinæstetisk";}}
	
	public string DescpriptionKinesthetic {get {return  "Som kinæstiker, er det vigtigt, at have mulighed for at bruge sin krop, mens du lærer. Det er derfor vigtigt, at der er gode udfoldelsesmuligheder, der hvor læringen skal finde sted. Det er godt for dig at lave eksperimenter, bygge og modellere. Det er også en god idé at du benytter dig af drama og rollespil. Når der skal tages noter eller laves illustrationer, skal det gerne gøres i store formater.Det er derfor vigtigt, at du som kinæstetiker, gør brug af:\n-Walk’n’talk, mens du arbejder\n-At lave illustrationer eller modeller i stor skala af det, du lærer\n-At stå op, mens du arbejder\n-Fysiske aktiviteter, e.g. værkstedsarbejde eller eksperimenter ";}}
	
	
 	public string BtnTxtTagTest {get {return "Tag test";}}
	
	public string BtnTxtTagOm {get {return "Tag test om";}}
	
}




