using UnityEngine;
using System.Collections;

public class Norwegian : MonoBehaviour {

	private string subTitleResult; 
	private string subTitleThinkingStyle; 
	private string subTitlePreferences;
	private string subTitleEnvironment;
	private string subTitleEnvirDescript; 
	
	private string titleAnalyst1;
	private string titleAnalyst2Part1;
	private string titleAnalyst2Part2;
	private string descpriptionAnalyst; 
	
	private string titleHolistic1; 
	private string titleHolistic2Part1;
	private string titleHolistic2Part2;
	private string descpriptionHolistic; 
	
	
	private string titleVisual1; 
	private string titleVisual2Part1; 
	private string titleVisual2Part2; 
	private string descpriptionVisual; 
	
	
	private string titleAuditory1; 
	private string titleAuditory2Part1;
	private string titleAuditory2Part2;
	private string descpriptionAuditory; 
	
	
	private string titleTactile1; 
	private string titleTactile2Part1;
	private string titleTactile2Part2;
	private string descpriptionTactile; 
	
	private string titleKinesthetic1;
	private string titleKinesthetic2Part1; 
	private string titleKinesthetic2Part2;
	private string descpriptionKinesthetic; 
	
	private string btnTxtTagTest; 
	private string btnTxtTagOm; 
	
	
	public Norwegian(){}
	
	
	string SubTitleResult {get {return "Læringsstilstest Resultater";}}
	
	string SubTitleThinkingStyle {get {return "Tenkerstil";}}
	
	string SubTitlePreferences {get {return "Læringspreferences";}}
	
	string SubTitleEnvironment {get {return "Læringsmiljø";}}
	
	string SubTitleEnvirDescript {get {return "Sørg for å jobbe ved en god lampe eller i nærheten av et vindu.- Sørg for å arbeide et sted med svak belysning. - Sørg for å sette deg på et rolig sted. - Sørg for å sitte et sted med bakgrunnsstøy fra andre eller musikk. - Sørg for å sitte et kjølig sted. - Sørg for å sitte et lunt sted. - Sørg for å sitte ved et godt bord. - Sørg for å sitte behagelig i en sofa el. lign. - Sørg for at holde bevegelsespauser. "; }}
	

	string TitleAnalyst {get {return "Du er primært analytikker";}}
	string TitleAnalyst2Part1 {get {return "Du er";}}
	string TitleAnalyst2Part2  {get {return "analytikker";}}
	string DescpriptionAnalyst {get {return "Du foretrekker å komme raskt i gang med oppgaven og å jobbe med én oppgave om gangen. Det er vesentlig at det er system i arbeidet og at det er muligheter for å legge vekt på detaljer. En analytiker søker faste rammer når det skal skje læring og trenger derfor å planlegge arbeidet sitt slik at det er struktur og logikk i rekkefølgen som oppgavene utføres i. Analytikere liker å jobbe fokuserte og konsentrerte uten avbrytelser og forstyrrelser.Som analytiker bør du derfor sørge for å: -Starte arbeidet med å planlegge rekkefølgen på oppgavene. -Gå direkte i gang med oppgavene. – én av gangen. -Ha god orden og struktur. – gjerne konkrete henvisninger. -Sett av tid til detaljer.";}}
	
	
	string TitleHolistic1 {get {return "Du er primært holist";}}
	
	string TitleHolistic2Part1 {get {	return "Du er ";}}
	
	string TitleHolistic2Part2 {get {return "holist";}}
	
	string DescpriptionHolistic {get {return "Som holist lærer man best ved å ha oversikt over oppgaven som helhet og når man ser et klart formål med den. Det er viktig å ha innflytelse på arbeidsformen for kunne skape en egen struktur som ikke nødvendigvis alltid er logisk for andre. Holister trenger pauser fra arbeidet hvor man snakker om noe annet eller gjør andre oppgaver. De trenger ikke å gjøre oppgaven ferdig før de starter på en ny. Det er i tillegg viktig med en god og hyggelig atmosfære i læringssituasjonen. Som holist bør du derfor sørge for å: - Relatere oppgaven til virkeligheten. -Ta deg tid til å sette deg inn i hele oppgaven/stoffet. -Variere oppgavene. Du må gjerne jobbe med flere oppgaver på én gang. -Følge din intuisjon";}}
	
	
	string TitleVisual1 {get {	return " Du er primært visuell";}}
	
	string TitleVisual2Part1 {get {return "Du er";}}
	
	string TitleVisual2Part2 {get {return "visuell";}}
	
	string DescpriptionVisual {get {return "Når man lærer best visuelt skal oppgaven/stoffet vises frem. Det kan enten gjøres via skriftlige instruksjoner, tekstbøker og bilder. Når det skal læres noe nytt og vanskelig, har man som visuell behov for å skrive eller tegne notater til stoffet. Det er derfor viktig at du som visuell bruker: - Trykte bilder og tekster. - Grafer og illustrasjoner. - Noter, mens du lærer. - Indre bilder, mens du lærer. ";}}
	
	
	string TitleAuditory1 {get {return "Du er primært auditiv";}}
	
	string TitleAuditory2Part1 {get {return "Du er";}}
	
	string TitleAuditory2Part2 {get {return "auditiv";}}
	
	string DescpriptionAuditory {get {return "Når man lærer best auditivt betyr det at man har behov for å få oppgaven fortalt og forklart muntlig. Som auditiv foretrekker man at få lest oppgaven høyt og å høre på lydbøker når man skal lære nytt stoff. Det er viktig for den auditive å få mulighet til å gjenfortelle og diskutere stoffet. Som auditiv er det nyttig for deg å: - Lytte til Lydbøker. - Snakke med andre om stoffet. -Bed om å få oppgaven forklart muntlig. -Lag deg små huskeregler (gjerne på rim).";}}
	
	
	string TitleTactile1 {get {return "Du er primært taktil";}}
	
	string TitleTactile2Part1 {get {return "Du er";}}
	
	string TitleTactile2Part2 {get {return "taktil";}}
	
	string DescpriptionTactile {get {return "Taktile lærer best når de får lov til å bruke hendene. Det er viktig at den taktile selv får styre blyanten, og har mulighet til å sitte med noe p hendende når det bare skal lyttes. Taktile foretrekker å løse praktiske oppgaver med konkret materiale, for eksempel spill. For å lettere bevare konsentrasjonen når man lærer kan det fungere godt å skrive notater, lage illustrasjoner eller understrekke nøkkelord i teksten. Som taktil er det nyttig for deg å: -Lage notater og illustrasjoner. - Streke under ord i teksten. - Bruke spill eller lignende for å lære nytt stoff. - Ha gjerne noe i hånden når du lytter, f.eks. en stressball. ";}}
	
	
	
	string TitleKinesthetic1 {get {return "Du er primært Kinestetisk";}}
	
	string TitleKinesthetic2Part1 {get {return "Du er";}}
	
	string TitleKinesthetic2Part2 {get {return "Kinestetisk";}}
	
	string DescpriptionKinesthetic {get {return  "Som kinestetisk er det viktig å ha mulighet til å bruke kroppen mens man lærer. Det er derfor viktig at det er gode utfoldelsesmuligheter der hvor læringen skal finne sted. Det er nyttig for kinestetiskere å gjøre eksperimenter, bygge og modellere. Det er også en god idé å benytte seg av teater og rollespill for læring. Når det skal tas notater eller lages illustrasjoner bør det gjøres i store formater. For deg som er kinestetisk er det nyttig å: - Bevege deg rundt mens du snakker høyt om det du jobber med. - ";}}
	
	
	string BtnTxtTagTest {get {return this.btnTxtTagTest;}}
	
	string BtnTxtTagOm {get {return this.btnTxtTagOm;}}
	
	
	public override string ToString ()
	{
		return string.Format ("[DanishStrings: SubTitleResult={0}, SubTitleThinkingStyle={1}, SubTitlePreferences={2}, SubTitleEnvironment={3}, subTitleEnvirDescript={4}, TitleAnalyst={5}, TitleAnalyst2Part1={6}, TitleAnalyst2Part2={7}, DescpriptionAnalyst={8}, TitleHolistic1={9}, TitleHolistic2Part1={10}, TitleHolistic2Part2={11}, DescpriptionHolistic={12}, TitleVisual1={13}, TitleVisual2Part1={14}, TitleVisual2Part2={15}, DescpriptionVisual={16}, TitleAuditory1={17}, TitleAuditory2Part1={18}, TitleAuditory2Part2={19}, DescpriptionAuditory={20}, TitleTactile1={21}, TitleTactile2Part1={22}, TitleTactile2Part2={23}, DescpriptionTactile={24}, TitleKinesthetic1={25}, TitleKinesthetic2Part1={26}, TitleKinesthetic2Part2={27}, DescpriptionKinesthetic={28}, BtnTxtTagTest={29}, BtnTxtTagOm={30}]", SubTitleResult, SubTitleThinkingStyle, SubTitlePreferences, SubTitleEnvironment, subTitleEnvirDescript, TitleAnalyst, TitleAnalyst2Part1, TitleAnalyst2Part2, DescpriptionAnalyst, TitleHolistic1, TitleHolistic2Part1, TitleHolistic2Part2, DescpriptionHolistic, TitleVisual1, TitleVisual2Part1, TitleVisual2Part2, DescpriptionVisual, TitleAuditory1, TitleAuditory2Part1, TitleAuditory2Part2, DescpriptionAuditory, TitleTactile1, TitleTactile2Part1, TitleTactile2Part2, DescpriptionTactile, TitleKinesthetic1, TitleKinesthetic2Part1, TitleKinesthetic2Part2, DescpriptionKinesthetic, BtnTxtTagTest, BtnTxtTagOm);
	}
	

}
