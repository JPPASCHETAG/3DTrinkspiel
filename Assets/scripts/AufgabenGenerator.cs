using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AufgabenGenerator{

    private List<Aufgabe> list = new List<Aufgabe>();

    public AufgabenGenerator(){

        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der mit etwas geprahlt hat, das er selbst nicht getan hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der betrunken Auto gefahren ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der 'Ich liebe dich' gesagt hat, nur um Sex zu haben.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der seine Nachbarn ausspioniert hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der an seiner Heterosexualität gezweifelt hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der etwas gestohlen hat, das einen höheren Wert als 10 Dollar hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der ein Lied von Justin Bieber wirklich mochte.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der auf etwas gewettet hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der einen Handstand mit einer Hand gemacht hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der den Freund oder die Freundin eines Ex-Freundes in den sozialen Medien gestalkt hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der einen Freund angelogen hat, um ein größeres übel zu vermeiden.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der aus dem Unterricht geflohen ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der eine offene Beziehung hatte.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der bei einem Test betrogen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der die falsche Person an die Hand genommen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der sich über das Internet in jemanden verliebt hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der bei diesem Spiel gelogen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der ein 'Ich liebe dich' gesagt hat, ohne es zu fühlen.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der aus einer Bar rausgeworfen wurde.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der Kaugummi unter einen Schreibtisch geklebt hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der Bilder in Unterwäsche gemacht hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der einen Kuss verweigert hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der untreu gewesen ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der meine Eltern über einen Kater angelogen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der auf die Toilette gegangen ist und sich dann nicht die Hände gewaschen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der einen gleichgeschlechtlichen Menschen geküsst hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der am nächsten Tag betrunken aufgewacht ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der sich heute noch betrinken will.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der seinen besten Freund geküsst hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der Marihuana geraucht hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der Essen gegessen hat, das auf den Boden gefallen ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der jemanden geküsst hat, ohne ihn/sie zu kennen.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der eine Oben-ohne-Frau am Strand gesehen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der einen Freund mit Vorzügen hatte.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der sich auf der Straße geprügelt hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der im Bus eingeschlafen ist, und an seiner Station vorbeigefahren ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der in seinen Lehrer verliebt war.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der beraubt wurde.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, für den schon einmal ein Liebeslied gesungen wurde.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der sich auf eine Party geschlichen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der in einem Aufzug stecken geblieben ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der illegal etwas über die Grenze mitgenommen hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, dem Handschellen angelegt wurden.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der im Kino eingeschlafen ist.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der in der Öffentlichkeit in seiner Nase gebohrt hat.",1));
        list.Add(new Aufgabe("Ich hab noch nie","Es trinkt jeder, der an einer Talentshow teilgenommen hat.",1));
        list.Add(new Aufgabe("Frage","Welchen Film hat sich SPIELER zuletzt angesehen?",1));
        list.Add(new Aufgabe("Frage","Geht SPIELER lieber ins Kino oder auf das Sofa zu Hause um Filme sehen?",1));
        list.Add(new Aufgabe("Frage","Welches Plattform benutzt SPIELER am liebsten, um sich seine Zeit zu vertreiben?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingsfilm?",1));
        list.Add(new Aufgabe("Frage","Lacht SPIELER bei Family Guy?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingssorte Sandwich?",1));
        list.Add(new Aufgabe("Frage","Hat SPIELER in den letzten 3 Monaten ein gutes Buch gelesen?",1));
        list.Add(new Aufgabe("Frage","Tanzt SPIELER auf Ausflügen oder Partys?",1));
        list.Add(new Aufgabe("Frage","Schaut SPIELER die Nachrichten?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingsauto?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Traumberuf?",1));
        list.Add(new Aufgabe("Frage","An welchem Ort wäre SPIELER jetzt am liebsten?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingsjahreszeit?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingsgetränk?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingstier?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingsessen?",1));
        list.Add(new Aufgabe("Frage","Kocht SPIELER gerne?",1));
        list.Add(new Aufgabe("Frage","Wo würde SPIELER gerne leben?",1));
        list.Add(new Aufgabe("Frage","Wo wäre SPIELER perfekter Urlaub?",1));
        list.Add(new Aufgabe("Frage","Welche historische Person würde SPIELER gerne interviewen?",1));
        list.Add(new Aufgabe("Frage","Welche Superkraft würden SPIELER gerne haben?",1));
        list.Add(new Aufgabe("Frage","Wie würde SPIELER gerne in der Zukunft sein?",1));
        list.Add(new Aufgabe("Frage","Wenn SPIELER ein Tier wären, was würde SPIELER sein?",1));
        list.Add(new Aufgabe("Frage","Was ist das Verrückteste, was SPIELER je getan hat?",1));
        list.Add(new Aufgabe("Frage","Wenn SPIELER im Lotto gewinnen würde? Was würden SPIELER als erstes kaufen?",1));
        list.Add(new Aufgabe("Frage","In welchem Jahr war SPIELER am glücklichsten und warum?",1));
        list.Add(new Aufgabe("Frage","Mag SPIELER Brownies und Schokolade?",1));
        list.Add(new Aufgabe("Frage","Bevorzugt SPIELER Regen- oder Schneetage?",1));
        list.Add(new Aufgabe("Frage","Wann hat SPIELER Geburtstag?",1));
        list.Add(new Aufgabe("Frage","Würde SPIELER sich mit Extremsportarten beschäftigen, zum Beispiel mit Bungeejumping?",1));
        list.Add(new Aufgabe("Frage","Hat SPIELER ein Talent, das SPIELER nicht nutzt?",1));
        list.Add(new Aufgabe("Frage","Was sind SPIELER zukünftigen Karrierepläne?",1));
        list.Add(new Aufgabe("Frage","Was ist SPIELER Lieblingsphrase?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du es vorziehen, dass die Auserirdischen, die den ersten Kontakt mit uns herstellen, roboterhaft oder organisch sind?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber die Fähigkeit zu lesen oder die Fähigkeit zu sprechen verlieren?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber mit deiner Handfäche genau die Temperatur, oder das Gewicht messen können?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber mit Fell oder mit Schuppen bedeckt?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber ein Jahr im Gefängnis sitzen oder ein Jahr Lebenszeit verlieren?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber immer 10 Minuten zu spät oder immer 20 Minuten zu früh sein?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Hättest du lieber eine echte Freikarte oder einen Schlüssel, der jede Tür öffnet?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber die Geschichte jedes Gegenstandes, den du berührt hast, kennen oder mit Tieren sprechen können?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber mit einer 10 und schlechter Persönlichkeit oder einer 6 mit erstaunlicher Persönlichkeit verheiratet sein?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber in der Lage, mit Landtieren, fliegenden Tieren oder Tieren, die unter Wasser leben, zu sprechen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du es vorziehen, dass alle Ampeln, an die du dich näherst, grün werden oder dass du nie wieder in der Schlange anstehen musst?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber den Rest deines Lebens mit einem Segelboot oder einem Wohnmobil als Zuhause verbringen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber auf alle Getränke außer Wasser verzichten oder auf alles verzichten, was im Ofen gekocht wurde?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber 10 Minuten in deine eigene Zukunft oder 10 Minuten in die Zukunft von jemand anderem sehen können?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber Angestellter oder Selbstständiger sein?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber der erste Mensch, der einen Planeten erforscht, oder würdest du lieber der Erfinder eines Medikaments sein, das eine tödliche Krankheit heilt?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber mit allem, was du jetzt weißt, in das Alter von 5 zurückgehen oder jetzt alles wissen, was dein zukünftiges Ich lernen wird?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber in der Lage, Tiere (aber nicht Menschen) oder Elektronik mit deinem Verstand zu steuern?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber unbegrenzte internationale Erste-Klasse-Tickets haben oder nie für Essen in Restaurants bezahlen müssen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber sehen, was sich hinter jeder geschlossenen Tür befindet, oder die Kombination aller Tresore beim ersten Versuch erraten können?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber ein durchschnittlicher Mensch in der Gegenwart oder ein König eines großen Landes vor 2500 Jahren?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber in der Lage sein, allem auszuweichen, egal wie schnell es sich bewegt, oder in der Lage sein, drei beliebige Fragen zu stellen und diese genau beantworten zu lassen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber gezwungen, jedes Mal zu tanzen, wenn du Musik hörst, oder wärst du lieber gezwungen bei jedem Lied das du hörst mitzusingen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Möchtest du lieber, dass alle deine Kleider perfekt passen oder dass du das bequemste Kissen, die bequemsten Decken und Laken hast, die es gibt?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du es vorziehen, dass 5% der Bevölkerung Telepathie oder 5% der Bevölkerung Telekinese haben? du bist nicht Teil der 5%, die Telepathie oder Telekinese haben.",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber eine unwichtige Figur aus dem letzten Film, den du gesehen hast, oder eine unwichtige Figur aus dem letzten Buch, das du gelesen hast?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber jede Woche in eine neue Stadt ziehen oder die Stadt, in der du geboren bist, niemals verlassen können?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber völlig verrückt sein und wissen, dass du verrückt bist, oder völlig verrückt sein und glauben, du seist zurechnungsfähig?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber ein Jahr lang mit kleinem Budget um die Welt reisen oder ein Jahr lang nur in einem Land bleiben, aber im Luxus leben?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber plötzlich zum Senator gewählt werden oder plötzlich CEO eines großfen Unternehmens werden? (du wirst nicht mehr Wissen darüber haben, wie du beide Jobs ausüben kannst, als du es jetzt tust)",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber in der virtuellen Realität leben, in der Ihr alle allmächtig seid, oder in der realen Welt leben und überall hingehen können, aber nicht in der Lage seien, mit irgendjemandem oder irgendetwas zu interagieren?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du es vorziehen, dass das, was du denkst, über deinem Kopf erscheint, damit jeder es sehen kann, oder dass absolut alles, was du tust, live gestreamt wird, damit jeder es sehen kann?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber nur die wenigen Filme mit einem Wert von 95-100% auf Rotten Tomatoes sehen können oder nur die meisten Filme mit einem Wert von 94% und weniger auf Rotten Tomatoes?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber jedes Jahr als neuer Mensch aufwachen und das ganze Jahr über die volle Kontrolle über sie haben oder einmal pro Woche einen Tag in einem Fremden verbringen, ohne irgendeine Kontrolle über sie zu haben?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber wissen, wie überdurchschnittlich oder unterdurchschnittlich du bei allem bist, oder wissen, wie überdurchschnittlich oder unterdurchschnittlich die Menschen bei einer Fähigkeit/Talent sind, nur indem du sie ansiehst?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber leben, bis du 200 Jahre alt sind, aber die ganze Zeit so aussehen, als wärst du 200, obwohl du gesund bist, oder so aussehen, als wärst du 25, bis du im Alter von 65 Jahren stirbst?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wärst du lieber ein umgekehrter Zentaur oder eine umgekehrte Meerjungfrau/Mann?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wäre dir ein Esel oder eine Giraffe als einziges Transportmittel lieber?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber nur eine Gabel (kein Löffel) oder nur einen Löffel (keine Gabel) benutzen können?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du es vorziehen, dass jedes Hemd, das du jemals trägst, irgendwie juckt oder dass du nur einlagiges Toilettenpapier verwenden kannst?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Hättest du lieber essbare Spaghettihaare, die jede Nacht nachwachsen, oder Ahornsirup schwitzen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber jedes Wort, das du ließft, laut vorlesen oder alles, was du sagst, laut singen müssen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber jeden Tag ein Hochzeitskleid/ein Tuxedo tragen oder lieber jeden Tag einen Badeanzug tragen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber nicht in der Lage sein, deinen Körper bei Regen zu bewegen oder nicht in der Lage sein, sich bei Sonnenschein zu bewegen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du es vorziehen, dass alle Hunde versuchen, dich anzugreifen, wenn sie dich sehen, oder dass alle Vögel versuchen, dich anzugreifen, wenn sie dich sehen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber gezwungen sein, jedem, den du triffst, ein High Five zu geben, oder wärst du lieber gezwungen, jedem, der ein grünes Hemd trägt, einen Unterhosenzieher zu geben?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber eine Haut haben, die ihre Farbe aufgrund Ihrer Emotionen ändert oder Tätowierungen am ganzen Körper haben, die das darstellen, was du gestern getan hast?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du eher zufällig jedes Mal, wenn du furzt, an einen anderen Ort auf der Erde (zu Land, nicht zu Wasser) teleportieren, jedes Mal, wenn du niest, eine Zeitreise von +/- 20 Jahren unternehmen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wäre es dir lieber, es gäbe einen ewigen Wasserballonkrieg in deiner Stadt oder eine ewige Lebensmittelschlacht?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber jedes Mal, wenn du ein ernstes Gespräch führen, laut furzen oder nach jedem Kuss rülpsen müssen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber doppelt so stark werden, wenn dir beide Finger in den Ohren stecken, oder doppelt so schnell kriechen, wie du laufen kannst?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Möchtest du lieber, dass alles was du zeichnest real wird, aber dauerhaft schlecht zeichnen können, oder fliegen können, aber nur so schnell wie du laufen kannst?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Wäre es dir lieber, wenn bei jedem Niesen sofort dreißfig Schmetterlinge aus dem Nichts auftauchten oder wenn bei jedem Husten ein sehr wütendes Eichhörnchen aus dem Nichts auftauchte?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber jedes Mal, wenn du ein Geburtstagslied hörst, unkontrolliert eine Minute lang kotzen oder jedes Mal, wenn du einen Vogel siehst (auch auf Bildern oder in einem Video), Kopfschmerzen bekommen, die den Rest des Tages andauern?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber von allen gefürchtet oder von allen geliebt werden?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdet ihr lieber euren gesamten Besitz verkaufen oder eines eurer Organe verkaufen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber in den Geschichtsbüchern berüchtigt sein oder nach Ihrem Tod vergessen werden?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber als Fliege wiedergeboren werden oder nach Ihrem Tod einfach aufhören zu existieren?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber nie wütend werden oder nie neidisch sein?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber eine schrecklich korrupte Regierung oder keine Regierung haben?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber von deinen Eltern oder deinen Freunden hoch geschätzt werden?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber in 20 Jahren ohne Reue oder in 50 Jahren mit viel Reue sterben?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du dich lieber 500 Jahre in die Zukunft oder 500 Jahre in die Vergangenheit transportieren lassen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du deinen Körper lieber der Wissenschaft oder deine Organe lieber Menschen spenden, die sie brauchen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber berühmt sein, wenn du lebst, und vergessen werden, wenn du stirbst, oder unbekannt sein, wenn du lebst, aber nach deinem Tod berühmt sein?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber für etwas, das du nicht getan hast, für 4 Jahre ins Gefängnis gehen oder mit etwas Schrecklichem davonkommen, das du getan hast, aber immer in der Angst leben, gefasst zu werden?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber in der Wildnis fernab der Zivilisation und ohne menschlichen Kontakt leben oder als Obdachloser auf den Straßfen einer Stadt leben?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber alle Erinnerungen von der Geburt bis heute verlieren oder die Fähigkeit verlieren, neue Langzeiterinnerungen zu schaffen?",1));
        list.Add(new Aufgabe("Würdest du lieber...","Würdest du lieber immer 5 Minuten in die Zukunft sehen können oder immer 100 Jahre in die Vergangenheit  sehen können?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten viele Brüder und Schwestern haben?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer hört am ehesten klassische Musik?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer geht am ehesten sehr oft ins Museum?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer raucht am ehesten Gras?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am wahrscheinlichsten reich?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten arm?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer war wahrscheinlich schon immer der Herzensbrecher?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten in einer Großstadt leben?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer sieht sich am ehesten romantische Filme an?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer ist am ehesten in einem Chor?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer geht am ehesten zu Justin Biebers Konzert?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten der Beste in Mathematik sein?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer gibt am ehesten sein ganzes Geld für wohltätige Zwecke aus?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten eine Drama-Königin sein?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer heiratet am ehesten eine Berühmtheit?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten immer glücklich sein?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer hält am ehesten den Atem so lange wie möglich an?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer hat am ehesten die meisten Piercings?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer tut in der Öffentlichkeit am ehesten seltsame Dinge?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer schaut sich am ehesten p*rn an, sobald er aufwacht?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer hat am ehesten seltsame Phobien?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer heiratet am ehesten zuerst?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten einen Nobelpreis gewinnen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer bringt am ehesten jemanden versehentlich um?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer stirbt am ehesten an einer Dummheit?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird sich am ehesten vor seinem heimlichen/bekannten Schwarm in Verlegenheit bringen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer gerät am ehesten in einen Kampf?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten bei einem einfachen Test durchfallen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten zum Multimillionär?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten gegen eine Wand schlagen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer trifft am ehesten auf einen Geist?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten verhaftet, wenn er nackt herumläuft?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer spricht am ehesten mit Tieren?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer schläft am ehesten im Unterricht ein?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer isst am ehesten mit offenem Mund?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer weint am ehesten wegen eines traurigen Films?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer hat am ehesten zwei Freundinnen auf einmal?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer stirbt am ehesten als Erster bei einer Zombie-Apokalypse?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer macht sich am ehesten über kleine Dinge Sorgen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer macht am ehesten den Bungee-Sprung?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten ein berühmter Schauspieler/Schauspielerin?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten keinen Computer haben?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer hat am ehesten einen Teilzeitjob?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer war höchstwahrscheinlich noch nie verliebt?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer raucht am ehesten?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer nimmt am ehesten Drogen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer verliebt sich am ehesten in seinen besten Freund?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer ist am ehesten ein Stand-up-Comedian?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer geht am ehesten zum Militär?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten ein Weltreisender sein?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten ein Supermodel sein?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten ein Kind adoptieren?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten im Lotto gewinnen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten die Welt regieren?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten eine Weltreise unternehmen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten eine Olympische Medaille gewinnen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten Lehrer an einer High School werden?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten einen Oscar gewinnen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten einen Weltrekord brechen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten etwas Nützliches erfinden?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten in einem Werbespot auftreten?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten Präsident der Vereinigten Staaten von Amerika werden?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten einen Bestseller schreiben?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten einen Weltkrieg auslösen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer duscht am ehesten eine Woche lang nicht?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer zieht am ehesten in ein anderes Land?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer verdient am ehesten eine Million Dollar?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten der netteste Mensch der Welt werden?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer hat mit hoher Wahrscheinlichkeit als erster einen Mann oder ein Mädchen geküsst?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer tritt am ehesten in einer Reality-Show auf?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer kümmert sich am ehesten um die anderen, wenn sie krank sind?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten etwas ändern?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer lacht am ehesten im falschen Moment?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer weint am ehesten an einem öffentlichen Ort?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer macht am ehesten die plastische Operation?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer heiratet am ehesten ohne Liebe?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer wird am ehesten in einem Zoo leben?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer liest am ehesten jedes Buch in einer Schulbibliothek?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer läuft am ehesten weg, um sich dem Zirkus anzuschließen?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer gibt am ehesten sein ganzes Geld für etwas Dummes aus?",1));
        list.Add(new Aufgabe("Wer würde eher?","Wer vergisst am ehesten wichtige Geburtstage?",1));


    }

    public Aufgabe getRandomAufgabe(){

        int aufgabenTyp = UnityEngine.Random.Range(1, 4);

        if(aufgabenTyp < 1 || aufgabenTyp > 3){
            aufgabenTyp = 2;
        }

        switch(aufgabenTyp){
            case 1:
                int rnd = UnityEngine.Random.Range(0, list.Count);
                return list[rnd];
            case 2:
                double schluck = UnityEngine.Random.Range(1, 10);
                if(GameSettings.getdrinkMode() == 1)
				{
                    schluck = 0.5 * schluck;
				}
                if (GameSettings.getdrinkMode() == 2)
                {
                    schluck = 2 * schluck;
                }

                string msg = "Du musst trinken! \n Trinke " + schluck + " Schluck.";
                return new Aufgabe("Trink!",msg,1);
            case 3:
                return new Aufgabe("Spiel","Minispiele werden noch implementiert...",1);
            default:
                return new Aufgabe("Trink!","Trink 3 Schluck",1);
        }
    }

}


public class Aufgabe{

    private string Titel;
    private string message;
    private int schluck;

    public Aufgabe(string titel, string mesg, int schl){
        Titel = titel;
        message = mesg;
        schluck = schl;
    }

    public string getTitel(){
        return Titel;
    }

    public string getMessage(){
        return message;
    }

    public int getSchluck(){
        return schluck;
    }


}