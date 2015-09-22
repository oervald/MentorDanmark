using UnityEngine;
using System.Collections;

//indholder stings til dansk text til appen.

public class DanishStrings : MonoBehaviour {
	string[] descriptionAnalystArray;
	string[] descriptionHolistiskArray;
	string[] descriptionVisualArray;
	string[] descriptionAuditivtArray;
	string[] descriptionTaktilArray;
	string[] descriptionKinestheticArray;
	
	public DanishStrings (){
		descriptionAnalystArray = new string[] {
			"1. Planlægge en rækkefølge for\n\topgaverne fra starten.",
			"2. Gå direkte i gang med opgaverne\n\t– én ad gangen.",
			"3. Have god orden og struktur i\n\ttingene – gerne konkrete\t\t\t\t\t\tanvisninger.",
			"4. Give tid til detaljerne."
		};
		descriptionHolistiskArray = new string[]{
			"1. Relatere opgaven til \n\tvirkeligheden.",
			"2. Give dig tid til at undersøge hele \t\t\topgaven/stoffet.",
			"3. Variere opgaverne. Du må gerne \t\t\tarbejde med flere på én gang.",
			"4. Følge din intuition."
		};
		descriptionVisualArray = new string []{
			"1. Trykte billeder og tekster.",
			"2. Grafer og illustrationer.",
			"3. Noter, mens du lærer.",
			"4. Indre billeder, mens du lærer"
		};
		descriptionAuditivtArray = new string []{
			"1. Lydbøger.",
			"2. At tale med andre om stoffet",
			"3. At bede om at få opgaven forklaret",
			"4. Små huskeregler og remser"
		};
		descriptionTaktilArray = new string[]{
			"1. At lave noter, illustrationer.",
			"2. At strege nøgleord ud i tekster.",
			"3. At bede bruge spil til at lærer\n\tstoffet.",
			"4. At sidde med noget i hånden, e.g.\n\ten stressbold"
		};
		descriptionKinestheticArray = new string[]{
			"1. Walk’n’talk, mens du arbejder.",
			"2. At lave illustrationer eller modeller\n\ti stor skala af det, du lærer.",
			"3. At stå op, mens du arbejder.",
			"4. Fysiske aktiviteter, e.g. \n\tværkstedsarbejde eller\n\teksperimenter "
		};
	}
	
	public string SubTitleThinkingStyle {get {return "Tænkestil";}}
	
	public string SubTitlePreferences {get {return "Læringspræferencer";}}
	
	public string SubTitleEnvironment {get {return "Læringsmiljø";}}
	
	public string EnvirLightOn{get {return ".\tSørg for at arbejde ved en god\n\tlampe eller tæt på vinduet";}}
	public string  EnvirLightOff{ get {return ".\tSørg for at sidde et sted hvor der\n\tikke er for meget lys";}}
	
	public string EnvirSoundOn{get {return ".\tSørg for at sidde et sted med\n\tbaggrundsstøj fra andre eller musik";}}
	public string EnvirSoundOff{get {return ".\tSørg for at sidde et sted for der er\n\troligt så du ikke bliver forstyret";}}
	
	public string EnvirTempHot{get {return ".\tSørg for der ikke er for koldt\n\tdet sted du læser";}}
	public string EnvirTempCold{get {return ".\tSørg for at sidde et køligt sted";}}
	
	public string EnvirConfertTable{get {return ".\tSørg for at sidde ved et godt bord";}}
	public string EnvirConfertSofa{get {return ".\tSid blødt og komfortabelt når du\n\tlæser";}}
	
	public string EnvirMovment{get {return ".\tSørg for at holde\n\tbevægelsespauser";}}
	
	
	public string TitleAnalyst {get {return "Du er primært analytikker";}}
	
	public string TitleAnalyst2Part1 {get {return "Du er ";}}
	public string TitleAnalyst2Part2  {get {return "% analytikker";}}
	
	public string DescpriptionAnalyst {get {return "Som analytiker foretrækker du at arbejde med én opgave ad gangen. Det er væsentligt, at der er system i arbejdet, og der er mulighed for at lægge vægt på detaljerne.Du søger faste rammer, når der skal læres, og du har derfor brug for at planlægge dit arbejde, så der er en god logik og struktur i rækkefølgen. Du kan lide at arbejde fokuseret og koncentreret uden afbrydelser og forstyrrelser og foretrækker også at komme hurtigt i gang med opgaverne.\n\nSom analytisk skal du sørge for at:";}}
	public string [] DescpriptionAnalystPart2 { get { return descriptionAnalystArray; } }

	public string TitleHolistic1 {get {return "Du er primært holitisk";}}

	public string TitleHolistic2Part1 {get {	return "Du er ";}}
	
	public string TitleHolistic2Part2 {get {return "% holist";}}
	
	public string DescpriptionHolistic {get {return "Som holist lærer du bedst, når du har overblik over opgaven som helhed, og når du kan se et klart formål med den.Det er vigtigt, at du får indflydelse på arbejdsformen og dermed kan skabe egen struktur – som ikke nødvendigvis altid er logisk for andre.  Du har brug for pauser fra arbejdet, hvor du taler om noget andet eller går i gang med nye opgaver. Du behøver ikke færdiggøre opgaven, før du starter på en ny. Det er også vigtigt, at der er en god og hyggelig atmosfære omkring dig i læringssituationen.\n\n Som holist skal du sørge for at:";}}
	public string [] DescpriptionHolisticPart2 {get {return descriptionHolistiskArray;}}
	
	public string TitleVisual1 {get {	return " Du er primært visuel";}}
	
	public string TitleVisual2Part1 {get {return "Du er ";}}
	
	public string TitleVisual2Part2 {get {return "% visuel";}}
	
	public string DescpriptionVisual {get {return "Når du lærer bedst visuelt, skal indholdet vises. Det kan enten gøres via skriftlige instruktioner, tekstbøger og billeder.Når noget nyt og vanskeligt skal læres, har du som visuel brug for at skrive eller tegne noter.\n\nSom visuel bør du gøre brug af:";}}
	public string [] DescpriptionVisualPart2 {get {return descriptionVisualArray;}}
	
	public string TitleAuditory1 {get {return "Du er primært auditiv";}}
	
	public string TitleAuditory2Part1 {get {return "Du er ";}}
	
	public string TitleAuditory2Part2 {get {return "% auditiv";}}
	
	public string DescpriptionAuditory {get {return "Når du lærer bedst auditivt, betyder det, at du har brug for at få opgaven fortalt og forklaret mundtligt. Som auditiv foretrækker du at få læst opgaven højt og lytte til lydbøger, når det nye skal læres. Det er vigtigt for dig at få muligheden for at genfortælle og debattere indholdet og opgaven.\n\nSom auditiv bør du gøre brug af:";}}
	public string [] DescpriptionAuditoryPart2 {get {return descriptionAuditivtArray;}}
	
	public string TitleTactile1 {get {return "Du er primært taktil";}}
	
	public string TitleTactile2Part1 {get {return "Du er ";}}
	
	public string TitleTactile2Part2 {get {return "% taktil";}}
	
	public string DescpriptionTactile {get {return "Som taktil lærer du bedst, når du får lov til at bruge hænderne.Det er vigtigt, at du selv styrer blyanten og også har mulighed for at sidde med noget i hænderne, når der blot skal lyttes. Du foretrækker at løse praktiske opgaver med konkret materiale, e.g. spil. For nemmere at bevare koncentrationen, når du lærer, er det godt at skrive noter, lave illustrationer eller strege nøgleord under i teksten.\n\nSom taktil bør du gøre brug af:";}}
	public string [] descpriptionTactilePart2 {get {return descriptionTaktilArray;}}
	
	
	public string TitleKinesthetic1 {get {return "Du er primært kinæstetisk";}}
	
	public string TitleKinesthetic2Part1 {get {return "Du er ";}}
	
	public string TitleKinesthetic2Part2 {get {return "% kinæstetisk";}}
	
	public string DescpriptionKinesthetic {get {return  "Som kinæstiker, er det vigtigt, at have mulighed for at bruge sin krop, mens du lærer. Det er derfor vigtigt, at der er gode udfoldelsesmuligheder, der hvor læringen skal finde sted. Det er godt for dig at lave eksperimenter, bygge og modellere. Det er også en god idé at du benytter dig af drama og rollespil. Når der skal tages noter eller laves illustrationer, skal det gerne gøres i store formater.\n\nSom kinæstetiker bør du gøre brug af:";}}
	public string [] descpriptionKinestheticPart2{get {return descriptionKinestheticArray;}}
	
 	public string BtnTxtTagTest {get {return "Tag test";}}
	
	public string BtnTxtTagOm {get {return "Tag test om";}}

	public string QuestionTestSceenPart1 {get {return "Forestil dig, at du skal lære noget nyt eller vanskeligt. Tryk på de udsagn, der passer på dig";}}

	public string QuestionTestSceenPart2 {get {return "Sæt kryds ved det udsagn, der passer bedst på dig. Jeg koncentrerer mig bedst";}}
}




