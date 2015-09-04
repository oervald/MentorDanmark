using UnityEngine;
using System.Collections;

//indholder stings til dansk text til appen.

public class DanishStrings : MonoBehaviour {

	public DanishStrings (){
	}

	public string SubTitleResult {get {return "Læringsstilstest Resultater";}}
	
	public string SubTitleThinkingStyle {get {return "Tænkestil";}}
	
	string SubTitlePreferences {get {return "Læringspræferencer";}}
	
	string SubTitleEnvironment {get {return "Læringsmiljø";}}

	string EnvirLightLight{get {return "- Sørg for at arbejde ved en god lampe eller tæt på vinduet";}}
	string EnvirLightDark{get {return "";}}

	string EnvirSoundOn{get {return "- Sørg for at sidde et sted med baggrundsstøj fra andre eller musik";}}
	string EnvirSoundOff{get {return "";}}

	string EnvirTempHot{get {return "";}}
	string EnvirTempCold{get {return "- Sørg for at sidde et køligt sted";}}

	string EnvirConfertTable{get {return "- Sørg for at sidde ved et godt bord";}}
	string EnvirConfertSofa{get {return "";}}

	string EnvirMovment{get {return "- Sørg for at holde bevægelsespauser";}}

	string TitleAnalyst {get {return "Du er primært analytikker";}}
	
	string TitleAnalyst2Part1 {get {return "Du er";}}
	string TitleAnalyst2Part2  {get {return "analytikker";}}
	
	string DescpriptionAnalyst {get {return "Som analytiker foretrækker du at arbejde med én opgave ad gangen. Det er væsentligt, at der er system i arbejdet, og der er mulighed for at lægge vægt på detaljerne.Du søger faste rammer, når der skal læres, og du har derfor brug for at planlægge dit arbejde, så der er en god logik og struktur i rækkefølgen. Du kan lide at arbejde fokuseret og koncentreret uden afbrydelser og forstyrrelser og foretrækker også at komme hurtigt i gang med opgaverne.Du skal derfor sørge for at:-	Planlægge en rækkefølge for opgaverne fra starten-	Gå direkte i gang med opgaverne – én ad gangen-	Have god orden og struktur i tingene – gerne konkrete anvisninger-	Give tid til detaljerne";}}
	
	
	string TitleHolistic1 {get {return "Du er primært holitisk";}}
	
	string TitleHolistic2Part1 {get {	return "Du er ";}}
	
	string TitleHolistic2Part2 {get {return "holist";}}
	
	string DescpriptionHolistic {get {return "Som holist lærer du bedst, når du har overblik over opgaven som helhed, og når du kan se et klart formål med den.Det er vigtigt, at du får indflydelse på arbejdsformen og dermed kan skabe egen struktur – som ikke nødvendigvis altid er logisk for andre.  Du har brug for pauser fra arbejdet, hvor du taler om noget andet eller går i gang med nye opgaver.                Du behøver ikke færdiggøre opgaven, før du starter på en ny. Det er også vigtigt, at der er en god og hyggelig atmosfære omkring dig i læringssituationen.Som holist skal du derfor sørge for at:-	Relatere opgaven til virkeligheden-	Give dig tid til at undersøge hele opgaven/stoffet-	Variere opgaverne. Du må gerne arbejde med flere på én gang-	Følge din intuition";}}
	
	
	string TitleVisual1 {get {	return " Du er primært visuel";}}
	
	string TitleVisual2Part1 {get {return "Du er";}}
	
	string TitleVisual2Part2 {get {return "visuel";}}
	
	string DescpriptionVisual {get {return "Når du lærer bedst visuelt, skal indholdet vises. Det kan enten gøres via skriftlige instruktioner, tekstbøger og billeder.Når noget nyt og vanskeligt skal læres, har du som visuel brug for at skrive eller tegne noter.Det er derfor vigtigt, at du som visuel, gør brug af:-	Trykte billeder og tekster-	Grafer og illustrationer-	Noter, mens du lærer-	Indre billeder, mens du lærer";}}
	
	
	string TitleAuditory1 {get {return "Du er primært auditiv";}}
	
	string TitleAuditory2Part1 {get {return "Du er";}}
	
	string TitleAuditory2Part2 {get {return "auditiv";}}
	
	string DescpriptionAuditory {
		get {return "Når du lærer bedst auditivt, betyder det, at du har brug for at få opgaven fortalt og forklaret mundtligt. Som auditiv foretrækker du at få læst opgaven højt og lytte til lydbøger, når det nye skal læres. Det er vigtigt for dig at få muligheden for at genfortælle og debattere indholdet og opgaven.Det er derfor vigtigt, at du som auditiv, gør brug af:-	Lydbøger-	At tale med andre om stoffet-	At bede om at få opgaven forklaret-	Små huskeregler og -remser";}}
	
	
	string TitleTactile1 {get {return "Du er primært taktil";}}
	
	string TitleTactile2Part1 {get {return "Du er";}}
	
	string TitleTactile2Part2 {get {return "taktil";}}
	
	string DescpriptionTactile {get {return "Som taktil lærer du bedst, når du får lov til at bruge hænderne.Det er vigtigt, at du selv styrer blyanten og også har mulighed for at sidde med noget i hænderne, når der blot skal lyttes. Du foretrækker at løse praktiske opgaver med konkret materiale, e.g. spil. For nemmere at bevare koncentrationen, når du lærer, er det godt at skrive noter, lave illustrationer eller strege nøgleord under i teksten.Det er derfor vigtigt, at du som taktil, gør brug af:-	At lave noter, illustrationer-	At strege nøgleord ud i tekster-	At bede bruge spil til at lærer stoffet-	At sidde med noget i hånden, e.g. en stressbold";}}
	
	
	
	string TitleKinesthetic1 {get {return "Du er primært kinæstetisk";}}
	
	string TitleKinesthetic2Part1 {get {return "Du er";}}
	
	string TitleKinesthetic2Part2 {get {return "kinæstetisk";}}
	
	string DescpriptionKinesthetic {get {return  "Som kinæstiker, er det vigtigt, at have mulighed for at bruge sin krop, mens du lærer. Det er derfor vigtigt, at der er gode udfoldelsesmuligheder, der hvor læringen skal finde sted. Det er godt for dig at lave eksperimenter, bygge og modellere. Det er også en god idé at du benytter dig af drama og rollespil. Når der skal tages noter eller laves illustrationer, skal det gerne gøres i store formater.Det er derfor vigtigt, at du som kinæstetiker, gør brug af:-	Walk’n’talk, mens du arbejder-	At lave illustrationer eller modeller i stor skala af det, du lærer-	At stå op, mens du arbejder-	Fysiske aktiviteter, e.g. værkstedsarbejde eller eksperimenter ";}}


	string BtnTxtTagTest {get {return "Tag test";}}

	string BtnTxtTagOm {get {return "Tag test om";}}

}


