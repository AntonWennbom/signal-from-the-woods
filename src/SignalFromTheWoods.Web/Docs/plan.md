# 🎯 Digital julkalender: "Signal från Skogen" – story, pussel och progressionsplan (Blazor WASM)

Retro sci-fi-pek-och-klick, 24 luckor. Spelaren är en radiooperatör med amnesi i en insnöad stuga i norra Sverige. Dag 24: UFO-signalerna leder till Bigfoot i tomteluva, som hela tiden varit operatörens hemliga partner.

## Teknisk ram (kort)
- Blazor WASM, statisk hosting. Canvas/SVG-scen för skrivbordet plus Razor-komponenter för UI och dialog.
- Upplåsning: `UnlockService` jämför dagens datum (1–24 dec) mot `maxDag`. Demoläge (query `?demo=1` eller dev-flagga) ger fri dagväljare. Progress sparas i localStorage.
- Varje dag är data: `DayDefinition` (minnestext, pusseltyp, nya objekt, bigfoot-ledtråd) plus en pusselkomponent `IPuzzle`. Återanvänd pusseltyper: Frekvens, Morse, Chiffer, Ljudmönster, Kabelkoppling, Arkad.
- Före 1 dec visas väntrumsskärmen.

## Väntrumsskärm (exakt text)
> **[ SIGNAL SAKNAS ]**
> *Insjön, norra Sverige. 23:47. Det snöar.*
> Någon har lämnat radion på. Den sprakar. Någon, eller något, försöker nå dig.
> Du kan inte komma ihåg vem du är. Det är kanske bäst så. Än så länge.
> Första luckan öppnas **1 december**.
> Tills dess: ta på dig raggsockorna, fyll på kaffet och lämna inte stugan.
> *(Och om du hör något stort utanför fönstret: det är säkert bara snön.)*
> `[ Söker frekvens... 88.1 ... 91.4 ... 101.0 ... ]`

Liten detalj: ett svagt, lågt "hrmmmm" spelas ibland under brusljudet.

## Akt I – Vakna (Dag 1–8): Stugan och grunderna
1. **Dag 1 – Kallt kaffe.** Minne: Du vaknar vid radion, kaffet kallt, namnlappen på jackan är sönderrivet ("Op. ___"). Pussel: Vrid knappen till den enda frekvens som inte är brus (tutorial i frekvensratt). Nytt: Basradio med ratt och lampa. Bigfoot: Ett lågt bröl döljs i bruset vid 66,6 MHz.
2. **Dag 2 – Anteckningsblocket.** Minne: Du minns att du skrev loggar varje natt. Pussel: Sätt ihop sönderrivna loggsidor (pusselbitar) till en läsbar mening. Nytt: Loggbok på bordet. Bigfoot: Kaffekoppen har en jättestor tumavtryck-fläck, och en av sidorna luktar "våt hund och tallbarr".
3. **Dag 3 – Tre korta, tre långa.** Minne: Ett larm, SOS-liknande, hörs i natt. Pussel: Avkoda en morsesignal med en morsetabell till "VAKNA". Nytt: Morsenyckel och tabell. Bigfoot: Morsen har en oväntad tryckfel-pip "UUH" varje gång.
4. **Dag 4 – Elen.** Minne: Du minns generatorn i skjulet och att du själv byggde den. Pussel: Kabelkoppling, koppla ihop färgkodade sladdar i rätt ordning. Nytt: Strömmätare, lampan på bordet tänds. Bigfoot: Sladdarna är nergnagda av något med stora tänder och en lång tråd brunt hår hänger i säkringen.
5. **Dag 5 – Julgransljuset.** Minne: En granne (en mystisk röst) bad dig sätta upp ljus i fönstret som "landningsljus". Pussel: Simon-liknande ljuspussel med julgransljus som matchar en tonsekvens. Nytt: Julgranslampor i fönstret. Bigfoot: Tonsekvensen är samma melodi som ett "Joulupukki"-tema, men dundrande lågt.
6. **Dag 6 – Fotspår.** Minne: Du minns att du loggat märkliga spår i snön för flera veckor sedan. Pussel: Matcha spårfoton mot djurkatalogen, eliminera tills ett återstår: "Okänd". Nytt: Fältkikare och djurkatalog. Bigfoot: Spåret är 47 cm. Katalogen kallar det "Mycket stor skogsmus (?)".
7. **Dag 7 – Frekvensbandet.** Minne: Du minns att radion kan lyssna på mer än ett band. Pussel: Dubbel frekvensratt, hitta två stationer och para ihop dem. Nytt: Bandomkopplare. Bigfoot: Ena stationen är en "radiopredikan" som egentligen är ett långsamt snarkande.
8. **Dag 8 – Första kontakten.** Minne: En röst svarar: "Operatör, är det du? Håll linjen öppen." Du minns att du har en uppdragsgivare. Pussel: Arkad #1, "Signalfångaren": fånga fallande ljudvågor med en antenn innan de når marken. Nytt: Headset. Bigfoot: Rösten kallar dig "kompis" och andas tungt mellan meningarna. Akt-slut: ljus över skogen.

## Akt II – Signalen (Dag 9–16): Ufona och uppdraget
9. **Dag 9 – Uppdraget.** Minne: Du är utsänd för att kartlägga "Besökarna". Pussel: Kryptochiffer, Caesar-skift med dekoderskiva. Nytt: Dekoderskiva. Bigfoot: Chiffern klartext slutar med "– B.F.".
10. **Dag 10 – Stjärnkartan.** Minne: Du minns att ufona alltid dyker upp på samma plats på himlen. Pussel: Dra radioteleskopet mot rätt stjärnbild utifrån koordinater. Nytt: Stjärnkarta på väggen. Bigfoot: En av stjärnbilderna liknar en stor lurvig figur ("Stora Luddet").
11. **Dag 11 – Pepparkaksmodulen.** Minne: Du minns en lyckad ombyggnad i köket. Pussel: Bygg en filterkrets (puzzle med komponenter) för att rensa brus. Nytt: Filterlåda (ser ut som pepparkaksburk). Bigfoot: Burken är tom och det ligger smulor i skogsbrynet utanför.
12. **Dag 12 – Kristallen.** Minne: Ett föremål föll från himlen: en kristall. Pussel: Resonanspussel, justera tre kristallfrekvenser så att de vibrerar i takt. Nytt: Kristallen på bordet. Bigfoot: Kristallen hade hårstrån i sig, och glöder starkare när något stort närmar sig.
13. **Dag 13 – Luciatåget.** Minne: Natten då ufona kom, hörde du sång. Pussel: Ljudpussel, separera luciasången från ufo-signalen med tre skjutreglage. Nytt: Equalizer. Bigfoot: Under sången hörs en djup basröst som sjunger lite falskt.
14. **Dag 14 – Ufo-språket.** Minne: Du har översatt delar av ufo-språket. Pussel: Symbolordbok, matcha symboler mot svenska ord. Nytt: Ordbok. Bigfoot: Symbolen för "vän" är en tass.
15. **Dag 15 – Stormen.** Minne: En snöstorm stängde in dig, och du förlorade minnet i en chock. Pussel: Arkad #2, "Snöröjaren": styr en plog och rensa antennen mellan snödrivor. Nytt: Snöskoter syns utanför. Bigfoot: Något har redan plogat en bred stig mot stugan.
16. **Dag 16 – Förräderi?** Minne: Du minns ett meddelande: "Lita inte på någon med päls." Pussel: Avlyssna två röster och avgör vem som ljuger (logikpussel i dialog). Nytt: Bandspelare. Bigfoot: Meddelandet var ironiskt: "pälsen" var din egen mössa. Akt-slut: kristallen blinkar, något närmar sig.

## Akt III – Avslöjandet (Dag 17–24)
17. **Dag 17 – Kartan.** Minne: Du hade ritat en karta över skogen. Pussel: Pussla ihop kartfragment och markera sändarplatsen. Nytt: Karta på väggen. Bigfoot: Sändaren ligger vid "Trollkullen", med kaffekopp-ringar på kartan.
18. **Dag 18 – Rymdgranen.** Minne: Du minns att du byggt en sändare av en julgran. Pussel: Bygg antennen, placera grenar/kulor för att få rätt resonans. Nytt: Julgransantenn. Bigfoot: En av kulorna är en tomteluva i storlek XXL.
19. **Dag 19 – Telefonen.** Minne: Du minns att du har ett gammalt telefonuttag och en särskild nummerserie. Pussel: Ring rätt nummer med riktnummer-ledtrådar. Nytt: Rotary-telefon. Bigfoot: Numret leder till "Tomtens Verkstad – Stora Skogen". Signal: tunga steg.
20. **Dag 20 – Inbrottet.** Minne: Du minns att någon bröt sig in i stugan i natt. Pussel: Hitta fem skillnader mellan stugan nu och förut. Nytt: Trasig dörr. Bigfoot: Dörren är sönderbruten inifrån och ut, och på hyllan ligger en ledsen lapp: "Förlåt. Hungrig."
21. **Dag 21 – Vintersolståndet.** Minne: Du minns att natten är den längsta och att signalen sändes på just den kvällen. Pussel: Synka tre klockor med solståndstiden. Nytt: Väggur. Bigfoot: Vid midnatt hörs ett "Ho ho ho" som låter som en slogs ur en tunna.
22. **Dag 22 – Hela bilden.** Minne: Ufona var en kamouflerad leverans: en julklapp åt hela skogen. Pussel: Arkad #3, "Paketfall": fånga paket med kranen. Nytt: Kran och paket. Bigfoot: Paketen är märkta "Till: Sasquatch".
23. **Dag 23 – Julafton i antågande.** Minne: Du minns hela uppdraget: du och en vän byggde detta för att leverera julen hit. Pussel: Slutlig frekvens: kombinera alla enheter och kalibrera hela radioanläggningen. Nytt: Hela bordet komplett och lysande. Bigfoot: Fönstret: en enorm siluett med tomteluva står vid skogsbrynet.
24. **Dag 24 – Bigfoot i tomteluva.** Minne: Allt återvänder: Bigfoot, kallad "B.F.", är din partner och uppdragsgivare. Ni har hållit världens mest hemliga jul. Pussel: Finalen: ställ in den sista frekvensen (66,6 MHz från dag 1) och säg hej. Nytt: Dörren öppnas, Bigfoot kliver in och räcker dig kaffe. Slutscen: "God jul, operatör." Eftertexter med bloopers och alla tidigare ledtrådar som en galleri-lista.

## Röd tråd för Bigfoot-ledtrådar
Frekvensen 66,6 MHz, tunga steg, hår, falsk sång, "B.F."-signaturen, 47 cm fotspår, tomteluva-detaljer. Samla dem i ett ledtrådsgalleri i slutet.

**Last Updated**: 2026-10-19 08:34:45

## 📝 Plan Steps
-  **Skapa projektet — Blazor WASM-lösning med scen, UI-komponenter och `UnlockService` (datum plus demoläge).**
-  **Modellera data — `DayDefinition` (24 st) från detta dokument, i JSON eller C#.**
-  **Bygg väntrumsskärm — med texten ovan, aktiv före 1 dec.**
-  **Implementera återanvändbara pusseltyper — Frekvens, Morse, Chiffer, Kabel, Ljud/EQ, Sortering/pussel, Logik.**
-  **Implementera tre arkadminispel — Signalfångaren (dag 8), Snöröjaren (dag 15), Paketfall (dag 22).**
-  **Bygg skrivbordsscenen — objekt som dyker upp per dag och stugans fönster/dörr med fotspår och siluett.**
-  **Lägg till ljud och pixel-art — brus, morse, Bigfoot-bröl, 16-bitars tillgångar.**
-  **Implementera ledtrådsgalleriet och slutscenen för dag 24.**
-  **Testa upplåsning — datum, demoläge och localStorage-progress.**
-  **Publicera — statisk hosting och portfolio-beskrivning.**

