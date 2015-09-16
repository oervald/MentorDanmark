using UnityEngine;
using System.Collections;

public class TyskStrings : MonoBehaviour {


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
	
	
	public TyskStrings (string subTitleResult, string subTitleThinkingStyle, string subTitlePreferences, string subTitleEnvironment, string subTitleEnvirDescript, string titleAnalyst1, string titleAnalyst2Part1, string titleAnalyst2Part2, string descpriptionAnalyst, string titleHolistic1, string titleHolistic2Part1, string titleHolistic2Part2, string descpriptionHolistic, string titleVisual1, string titleVisual2Part1, string titleVisual2Part2, string descpriptionVisual, string titleAuditory1, string titleAuditory2Part1, string titleAuditory2Part2, string descpriptionAuditory, string titleTactile1, string titleTactile2Part1, string titleTactile2Part2, string descpriptionTactile, string titleKinesthetic1, string titleKinesthetic2Part1, string titleKinesthetic2Part2, string descpriptionKinesthetic, string btnTxtTagTest, string btnTxtTagOm)
	{
		this.subTitleResult = subTitleResult;
		this.subTitleThinkingStyle = subTitleThinkingStyle;
		this.subTitlePreferences = subTitlePreferences;
		this.subTitleEnvironment = subTitleEnvironment;
		this.subTitleEnvirDescript = subTitleEnvirDescript; 
		this.titleAnalyst1 = titleAnalyst1;
		this.titleAnalyst2Part1 = titleAnalyst2Part1;
		this.titleAnalyst2Part2 = titleAnalyst2Part2;
		this.descpriptionAnalyst = descpriptionAnalyst;
		this.titleHolistic1 = titleHolistic1;
		this.titleHolistic2Part1 = titleHolistic2Part1;
		this.titleHolistic2Part2 = titleHolistic2Part2;
		this.descpriptionHolistic = descpriptionHolistic;
		this.titleVisual1 = titleVisual1;
		this.titleVisual2Part1 = titleVisual2Part1;
		this.titleVisual2Part2 = titleVisual2Part2;
		this.descpriptionVisual = descpriptionVisual;
		this.titleAuditory1 = titleAuditory1;
		this.titleAuditory2Part1 = titleAuditory2Part1;
		this.titleAuditory2Part2 = titleAuditory2Part2;
		this.descpriptionAuditory = descpriptionAuditory;
		this.titleTactile1 = titleTactile1;
		this.titleTactile2Part1 = titleTactile2Part1;
		this.titleTactile2Part2 = titleTactile2Part2;
		this.descpriptionTactile = descpriptionTactile;
		this.titleKinesthetic1 = titleKinesthetic1;
		this.titleKinesthetic2Part1 = titleKinesthetic2Part1;
		this.titleKinesthetic2Part2 = titleKinesthetic2Part2;
		this.descpriptionKinesthetic = descpriptionKinesthetic;
		this.btnTxtTagTest = btnTxtTagTest;
		this.btnTxtTagOm = btnTxtTagOm;
	}
	
	
	string SubTitleResult {get {return "Ergebnisse des Lerntypentest";}}
	
	string SubTitleThinkingStyle {get {return " Denkstil";}}
	
	string SubTitlePreferences {get {return "Lehrtypen";}}
	
	string SubTitleEnvironment {get {return "Lehrumgebung";}}
	
	string SubTitleEnvirDescript {get {return "- Sorgen Sie dafür, dass Sie beim Lernen nah am Fenster sitzen und gutes Licht haben. -Sorgen Sie dafür, dass Sie auf Arbeit im schwachen Licht arbeiten.- Suchen Sie sich einen ruhigen Arbeitsplatz.- Finden Sie einen Arbeitsplatz, wo Sie von anderen Hintergrundgeräuschen und Musik umgeben sind. - Suchen Sie sich einen kühlen Arbeitsplatz. - Suchen Sie sich einen warmen Arbeitsplatz. -Sorgen Sie daür, dass Sie einen guten Schreibtisch haben. -Sorgen Sie dafür, dass Sie es sich auf Ihrer Couch oder einem anderen gemütlichen Ort bequem machen. -Denken Sie daran zwischendurch Pausen zu machen."; }}
	
	string TitleAnalyst {get {return "Sie sind ein analytischer Typ.";}}
	
	string TitleAnalyst2Part1 {get {return "Sie sind ein";}}
	string TitleAnalyst2Part2  {get {return "analytischer Typ.";}}
	
	string DescpriptionAnalyst {get {return "Als Analyst bevorzugen Sie, wenn die Lernmaterialien möglichst gut strukturiert sind und wenn Sie eine Aufgaben nach der anderen erledigen. Sie brauchen eine feste Struktur beim Lernen, aus diesem Grund mögen Sie es Ihre Aufgaben vorher zu planen, so dass diese logisch und strukturiert aufgebaut sind. Sie bevorzugen es sich selbstständig mit den Lernproblemen, in einer ruhigen Umgebung, auseinanderzusetzen. Außerdem fangen Sie gerne schnell mit den Aufgaben an, ohne sie aufzuschieben. Sie sollten dafür sorgen, dass:  - Sie die Reihenfolge der Aufgaben von Anfang an planen.  - Sie sofort mit den Aufgaben anfangen- und jeweils eine nach der anderen bearbeiten.  - Sie eine „gute“ Ordnung und Struktur haben- mit konkreten Anleitungen.  - Sie sich Zeit nehmen, um auch Details zu berücksichtigen.";}}
	
	
	string TitleHolistic1 {get {return "Sie sind ein holistischer Typ";}}
	
	string TitleHolistic2Part1 {get {	return "Sie sin ein ";}}
	
	string TitleHolistic2Part2 {get {return "holistischer Typ";}}
	
	string DescpriptionHolistic {get {return "Als ganzheitlich denkender Typ lernen Sie am besten, wenn Sie sich einen Überblick über die Aufgaben verschaffen und Sie ein klares Ziel sehen. Es ist wichtig, dass Sie Ihre Arbeitsweise eigenständig bestimmen und die Aufgaben selbst strukturieren- die Struktur muss jedoch nicht unbedingt logisch sein für andere. Es ist zu empfehlen, dass Sie zwischendrin Pausen halten und über etwas anderes sprechen oder mit einer neuen Aufgaben beginnen, damit Sie so Ihre Konzentration verbessern. Sie müssen nicht unbedingt eine Aufgabe beenden, bevor Sie eine neue beginnen. Es ist wichtig, dass Sie in einer angenehmen und gemütlichen Lehrumgebung lernen. Als ganzheitlich denkender Typ ist es wichtig, dass:  - die Aufgaben einen Alltagsbezug haben. - Sie sich Zeit nehmen, um die Aufgaben zu lösen.  - Ihre Aufgaben varieren. Sie können verschiedene Aufgaben auf einmal bearbeiten.  - Sie Ihrer Intuition folgen.";}}
	
	
	string TitleVisual1 {get {	return " Sie sind ein visueller Typ";}}
	
	string TitleVisual2Part1 {get {return "Sie sind ein";}}
	
	string TitleVisual2Part2 {get {return "visueller Typ";}}
	
	string DescpriptionVisual {get {return "Sie lernen am besten, indem Sie die Informationen lesen oder die Bilder anschauen, zum Beispiel in Form von schriftlichen Anweisungen, Textbüchern oder Bildern. Wenn Sie etwas Neues lernen, dann schreiben oder zeichnen Sie oft Ihre Notizen auf, zum Beispiel in Form von Grafikken, Illustrationen oder Bilder. Es ist wichtig, dass Sie als visueller Typ Ihr Potential voll ausnutzen und die Lerninhalte und Informationen visualisieren. ";}}
	
	
	string TitleAuditory1 {get {return "Sie sind eine auditive Typ";}}
	
	string TitleAuditory2Part1 {get {return "Sie sind eine";}}
	
	string TitleAuditory2Part2 {get {return "auditive Typ";}}
	
	string DescpriptionAuditory {
		get {return "Sie lernen am leichtesten, wenn Sie die Inhalte hören (akustisches Lernen). Dass heißt das Sie sich die Inhalte am besten merken, wenn Ihnen vorgelesen oder erzählt wird. Aus diesem Grund diskutieren oder erzählen Sie gerne anderen von den Aufgaben. Als auditiver Lerntyp wird deshalb empfohlen, dass Sie sich Hörbücher anhören, mit anderen diskutieren oder andere darum bitten Ihnen die Aufgaben zu erklären. ";}}
	
	
	string TitleTactile1 {get {return "Sie sind ein taktiles Typ";}}
	
	string TitleTactile2Part1 {get {return "Sie sind ein";}}
	
	string TitleTactile2Part2 {get {return "taktiles Typ";}}
	
	string DescpriptionTactile {get {return "Als motorischer Typ lernt man am besten durch Be-Greifen, praktisches Tun und Ausprobieren. Es ist wichtig, dass Sie beim Lernen immer in Bewegung sind und zum Beispiel einen Bleistift in der Hand haben, wenn Sie jemanden zuhören. Sie bevorzugen sich den Lerninhalt spielerisch beizubringen. Um Ihre Konzentration beim Lernen zu bewahren, ist es am besten wenn Sie Notizen oder Illustrationen machen oder Passagen im Text unterstreichen, die Sie für wichtig halten. Als motorischer Typ ist es zu empfehlen, wenn Sie:  - Notizen oder Illustrationen machen.  - wichtige Schlüsselwörter im Text unterstreichen.  - spielerisch sich den Lerninhalt beibringen.  - oder etwas in den Händen halten beim Lernen.";}}
	
	
	
	string TitleKinesthetic1 {get {return "Sie sind ein kinästhetischer Typ";}}
	
	string TitleKinesthetic2Part1 {get {return "Sie sind ein";}}
	
	string TitleKinesthetic2Part2 {get {return "kinästhetischer Typ";}}
	
	string DescpriptionKinesthetic {get {return  "Als kinästhetischer Lerntyp empfehlen wir, dass Sie sich bewegen, während sie lernen. Es kann von Vorteil sein, wenn Sie verschiedene Lernmöglichkeiten, zum Beispiel Experimente machen, modellieren oder bauen. Ihr Interesse wird durch Gestik und Pantomime, zum Beispiel in Form von Rollenspielen oder Dramen, geweckt. Als kinästhetischer Lerntyp kann es hilfreich sein, wenn Sie verschiedene Lehrmittel wie zum Beispiel:  - beim Arbeiten sich bewegen.  - Illustrationen oder Modelle machen.  - beim Arbeiten stehen. - oder körperlich arbeiten, zum Beispiel in der Werkstatt arbeiten oder Experimente machen. ";}}
	
	
	string BtnTxtTagTest {get {return this.btnTxtTagTest;}}
	
	string BtnTxtTagOm {get {return this.btnTxtTagOm;}}
	
	
	public override string ToString ()
	{
		return string.Format ("[DanishStrings: SubTitleResult={0}, SubTitleThinkingStyle={1}, SubTitlePreferences={2}, SubTitleEnvironment={3}, subTitleEnvirDescript={4}, TitleAnalyst={5}, TitleAnalyst2Part1={6}, TitleAnalyst2Part2={7}, DescpriptionAnalyst={8}, TitleHolistic1={9}, TitleHolistic2Part1={10}, TitleHolistic2Part2={11}, DescpriptionHolistic={12}, TitleVisual1={13}, TitleVisual2Part1={14}, TitleVisual2Part2={15}, DescpriptionVisual={16}, TitleAuditory1={17}, TitleAuditory2Part1={18}, TitleAuditory2Part2={19}, DescpriptionAuditory={20}, TitleTactile1={21}, TitleTactile2Part1={22}, TitleTactile2Part2={23}, DescpriptionTactile={24}, TitleKinesthetic1={25}, TitleKinesthetic2Part1={26}, TitleKinesthetic2Part2={27}, DescpriptionKinesthetic={28}, BtnTxtTagTest={29}, BtnTxtTagOm={30}]", SubTitleResult, SubTitleThinkingStyle, SubTitlePreferences, SubTitleEnvironment, subTitleEnvirDescript, TitleAnalyst, TitleAnalyst2Part1, TitleAnalyst2Part2, DescpriptionAnalyst, TitleHolistic1, TitleHolistic2Part1, TitleHolistic2Part2, DescpriptionHolistic, TitleVisual1, TitleVisual2Part1, TitleVisual2Part2, DescpriptionVisual, TitleAuditory1, TitleAuditory2Part1, TitleAuditory2Part2, DescpriptionAuditory, TitleTactile1, TitleTactile2Part1, TitleTactile2Part2, DescpriptionTactile, TitleKinesthetic1, TitleKinesthetic2Part1, TitleKinesthetic2Part2, DescpriptionKinesthetic, BtnTxtTagTest, BtnTxtTagOm);
	}
	
	
	
}

