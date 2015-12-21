using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Euro2016Venues
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> _venueDetails;
        public MainPage()
        {
            this.InitializeComponent();
            venueInformation();
            pvtVenues.SelectedIndex = 0;
        }//MainPage()

        //Enter the information for each venue
        private void venueInformation()
        {
            if (_venueDetails != null)
            {
                return;
            }//if (_venueDetails != null)
            _venueDetails = new List<string>();            
            //Bordeaux
            _venueDetails.Add("Stade de Bordeaux, Bordeaux \n\n 11/06 17.00 Gr B Wales v Slovakia \n 14/06 17.00 Gr F Austria v Hungary \n 18/06 14.00 Gr E Belgium v Rep of Ireland \n 21/06 20.00 Gr D Croatia v Spain \n 02/07 20.00 QF3: Winner M 5 v Winner M 6 \n\nCreated by the architects behind Munich's Allianz Arena and Beijing's 'Bird Nest' Olympic stadium, the 42,000-capacity Stade de Bourdeaux has steep stands, with upper tiers at a 35° angle - the maximum allowed in France.\nThe 184m euro(£130m) stadium's stanchions are designed to resemble pine trees in the nearby Landes forest - claimed to be the biggest planted forest in Europe, and marshland until the 19th century. \n'You feel vibrations - it's normal' \nSome fans were unnerved by structural movement during Bordeaux's first game at their new home in May 2015. A stadium official explained: \"It's a metallic stadium - when people jump in rhythmical fashion you feel vibrations.It's normal.\" \nBordeaux had previously played at the Stade Chaban - Delmas - a venue at the 1938 and 1998 World Cups. \nAnd another thing...\nThe city was under English rule from 1152 - 1453 but was reclaimed during the Hundred Years' War. Bordeaux is now best known for wine - the region produces 750 million bottles a year.\n\nAddress: Cours Jules Ladoumegue, 33300 Bordeaux");
            //Lens
            _venueDetails.Add("Stade Bollaert-Delelis, Lens \n\n 11/06 14.00 Gr A Albania v Switzerland \n 16/06 14.00 Gr B England v Wales \n 21/06 20.00 Gr D Czech Republic v Turkey \n 25/06 20.00 M2: Winner D v 3rd B/E/F \n\nThe 38,000-capacity Stade Bollaert-Delelis was originally oval but rectangular stands were added in the 1970s - giving it an English-style look.The scene of Laurent Blanc's golden goal for France against Paraguay at the 1998 World Cup, it was also used at Euro '84, but needed a 70m euro(£50m) upgrade for Euro 2016, and was shut for renovation last season.\nSlag heaps and chips\nFor a long time Lens had a reputation as a grim, unfashionable city plagued by high unemployment, and best known for its red-brick terraces, slag heaps, football and love of chips. \nBut regeneration is under way, with the 150m euro(£109m) Louvre - Lens Museum - an outpost of Paris' celebrated art gallery - opening in 2012 on the site of a disused colliery.\nAnd another thing...\nLens' entire population would not fill the Stade Bollaert-Delelis, yet the city's team attract crowds of 25, 000 - despite dropping out of the top flight in 2015. \n\nAddress: Avenue Alfred Maës, 62300 Lens");
            //Lille
            _venueDetails.Add("Stade Pierre Mauroy, Lille \n\n 12/06 20.00 Gr C Germany v Ukraine \n 15/06 14.00 Gr B Russia v Slovakia \n 19/06 20.00 Gr A Switzerland v France \n 22/06 20.00 Gr E Italy v Rep of Ireland \n 26/06 17.00 M5: Winner C v 3rd A/B/F \n 01/07 20.00 QF2: Winner M3 v Winner M4 \n\nNamed after a former French prime minster and mayor of Lille, the 50,000-capacity Stade Pierre Mauroy is home to the city's top-flight club but has also hosted rugby union, basketball and tennis - including the 2014 Davis Cup final. \nA clever design feature allows the northern half of the pitch to be raised several metres in the air and slid directly over the southern half.That reveals a compact 'showcase' level with room for temporary seating -ideal for focusing attention on a smaller area such as tennis court or musical stage.The unused half of the stadium is then curtained off to create a better atmosphere. \nThe stadium's roof can open or close in 30 minutes, is 31 metres high and was built using 7,400 tonnes of steel. \nAnd another thing...\nLille claims to host Europe's biggest flea market - La Grande Braderie de Lille - which dates back to the 12th century. Held in September, it attracts over two million visitors. \n\nAddress: 261 Boulevard de Tournai, 59650 Villeneuve d’Ascq");
            //Lyon
            _venueDetails.Add("Stade de Lyon, Lyon \n\n 13/06 20.00 Gr E Belgium v Italy \n 16/06 17.00 Gr C Ukraine v Northern Ireland \n 19/06 20.00 Gr A Romania v Albania \n 22/06 17.00 Gr F Hungary v Portugal \n 27/06 14.00 M7: Winner A v 3rd C/D/E \n 06/07 20.00 SF1: Winner QF1 v Winner QF2 \n\nA site was chosen for Lyon's new home in 2007 but legal action from opponents of construction meant building on the 59,000-capacity Stade de Lyon only began in earnest in 2013. The venue will open on 9 January, when Lyon host Troyes. \nThe stadium is the centrepiece of a 50 - hectare complex which includes a new training ground and hotels.Its most distinctive feature is its roof, which overhangs the stadium like a giant umbrella, providing shelter to fans immediately outside. \nFirst - time buyers \nIt is the first major stadium privately owned by a French football club - the rest rent.Inspired by Arsenal's financial success at Emirates Stadium, Lyon expect the 405m euro (£294m) cost of their home to be returned via higher match-day revenue. \nAnnual income is forecast to rise by between 40m and 50m euros(£29 - 36m).But in the meantime they have cut spending on players, becoming increasingly reliant on their strong academy.\nAnd another thing...\nLyon is the birthplace of cinema.The Lumiere brothers, Auguste and Louis, invented the cinematograph  camera - projector there in 1894.That no doubt influenced the decision to christen Lyon's new home the Stade des Lumieres (which literally means the Stadium of Lights). But as naming rights will be sold to sponsors, at Euro 2016 it will be simply the Stade de Lyon. \n\nAddress: 353 Avenue Jean Jaurès, 69007 Lyon");
            //Marseille
            _venueDetails.Add("Stade Velodrome, Marseille \n\n 11/06 20.00 Gr B England v Russia \n 15/06 20.00 Gr A France v Albania \n 18/06 17.00 Gr F Iceland v Hungary \n 21/06 17.00 Gr C Ukraine v Poland \n 30/06 20.00 QF1: Winner M1 v Winner M2 \n07/07 20.00 SF2: Winner QF3 v Winner QF4 \n\nBuilt for the 1938 World Cup, Marseille's Stade Velodrome originally featured a cycling track, which was removed in 1985. Capacity was expanded to 67,000 for the 1998 World Cup by adopting distinctive round stands - three of which were uncovered, exposing supporters to the powerful mistral winds that blow in off the Mediterranean. \nThe new Velodrome's undulating roof solves that problem while retaining the stadium's unique look.The end result is impressive - but costly. \nAs the club did not contribute to the 267m euro(£193m) project, the heavily indebted city council requested a five - fold increase on Marseille's 1.5m euro annual rent. A compromise was eventually agreed in 2014. \nAnd another thing...\nThe stadium's north stand, the Virage Nord Patrice de Peretti, is named after a Marseille Ultra who watched the club's games shirtless whatever the weather - including a game in Berlin when the temperature was - 12C. \n\nAddress: 3 Boulevard Michelet, 13008 Marseille");
            //Nice
            _venueDetails.Add("Stade de Nice, Nice \n\n 12/06 17.00 Gr C Poland v Northern Ireland \n 17/06 20.00 Gr D Spain v Turkey \n 22/06 20.00 Gr E Sweden v Belgium \n 27/06 20.00 M8: Runner-up B v Runner-up F \n\nNice had been looking for a replacement for their antiquated stadium - the Stade du Ray - since the turn of the century. Plans for a new ground were abandoned in 2002 and 2006 but Euro 2016 gave the project impetus, and work began in 2011. \nLocated to the west of Nice, three miles from the city's airport, the 36,000-capacity Stade de Nice is a multi-event arena designed to host rugby, tennis, motorsport and concerts as well as football. The stadium also hosts France's national museum of sport. \nUsually known as the Allianz Riviera for sponsorship reasons, during Euro 2016 it will instead simply be the Stade de Nice.\nAnd another thing...\nThe stadium's east stand is named after legendary Italian politician and general Giuseppe Garibaldi, who was born and raised in Nice and played a key role in the \"Risorgimento\" - the union of Italy's various states into a single political entity. \nHe was none too happy when his hometown was handed to the French as part of a pre - unification treaty. \n\nAddress: Boulevard des Jardiniers , 06206 Nice");
            //Paris
            _venueDetails.Add("Parc des Princes, Paris \n\n 12/06 14.00 Gr D Turkey v Croatia \n 15/06 17.00 Gr A Romania v Switzerland \n 18/06 20.00 Gr F Portugal v Austria \n 21/06 17.00 Gr C N. Ireland v Germany \n 25/06 17.00 M3: Winner B v 3rd A/C/D \n\nAt 48,000 seats, the Parc des Princes may be smaller than the other Euro 2016 venue in the French capital, the Stade de France, but it boasts more history. It staged the first European Cup final in 1956 - won by Real Madrid - and France's win against Spain in the Euro '84 final. \nConstructed in 1897, it was completely rebuilt in 1932 and again in 1972 - when the cycling track was removed and the stadium redesigned around an underground ring - road.Recently formed Paris St - Germain became tenants in 1974. \nPSG's Qatari owners bankrolled a 75m euro (£54m) facelift prior to Euro 2016 and the club want further expansion to seat 60,000 fans  - but the proximity of the ring-road may prove problematic. \nAnd another thing...\nThe stadium's name can be traced back to the 18th century, when the area and surrounding forest was used by French royalty for hunting. \n\nAddress: 24 Rue du Commandant Guilbaud, 75781 Paris Cedex 16");
            //Saint-Denis
            _venueDetails.Add("Stade de France, Saint-Denis, Paris\n\n 10/06 20.00 Gr A France v Romania \n 13/06 17.00 Gr E Rep of Ireland v Sweden \n 16/06 20.00 Gr C Germany v Poland \n 22/06 17.00 G F Iceland v Austria \n 27/06 17.00 M6: Winner E v Runner - up D \n 03/07 20.00 QF4: Winner M7 v Winner M8 \n 10/07 20.00 Final Winner SF1 v Winner SF2 \n\nThe Stade de France was the only new stadium built for the 1998 World Cup, at which it hosted nine games - including France's 3-0 victory over Brazil in the final. \nIt took over from the Parc des Princes as the home of France's national football and rugby union sides and has a distinctive elliptical roof, which appears to float above the stadium - despite weighing more than the Eiffel Tower. \nIt was the venue for November's friendly international between France and Germany, when three suicide bombers detonated devices outside the stadium. \nFrench sports minister Patrick Kanner praised stadium officials for their calm response to the explosions.Nonetheless, security will be enhanced at the Stade de France and all other Euro 2016 venues as a result of the Paris attacks. \nAnd another thing...\nIt is the only stadium to have hosted both the football and rugby union World Cup finals, in 1998 and 2007 respectively. \n\nAddress: Stade de France, 93216 Saint-Denis");
            //Saint-Etienne
            _venueDetails.Add("Stade Geoffroy Guichard, Saint-Etienne \n\n 14/06 20.00 Group F Portugal v Iceland \n 17/06 17.00 Gr D Czech Republic v Croatia \n 20/06 20.00 Gr B Slovakia v England \n 25/06 14.00 M1 Runner-up A v Runner-up C \n\nSaint-Etienne's Stade Geoffroy Guichard was initially selected only as a reserve venue (along with Toulouse) for Euro 2016 before organisers decided that both were needed to cope with the tournament's expanded format.Capacity has increased from 35, 600 to 42, 000, with seats installed in the four corners, although three of those sections are single - tiered.\nWelcome to Green Hell\nSaint - Etienne fans are renowned for the atmosphere generated at their home - which has been dubbed \"Le Chaudron\"(The Cauldron) and \"L'enfer Vert\"(Green Hell). \nThe stadium is named after the businessman who purchased the site.It hosted matches at Euro '84 and the 1998 World Cup - where it staged England's last - 16 exit to Argentina. \nAnd another thing...\nWith 10 top - flight titles, Saint - Etienne are the most successful side in French football - although their last championship came in 1981(in Michel Platini's penultimate season with them). \n\nAddress: 14 Rue Paul et Pierre Guichard, Saint-Étienne");
            //Toulouse
            _venueDetails.Add("Stadium de Toulouse, Toulouse \n\n13/06 14.00 Gr D Spain v Czech Republic \n 17/06 14.00 Gr E Italy v Sweden \n 20/06 20.00 Gr B Russia v Wales \n 26/06 20.00 M4: Winner F v Runner - up E \n\nToulouse is France's fourth biggest city but lies in the country's rugby heartland. The city's football side won their only honour - the French Cup - in 1957, but the rugby club boast 19 domestic championships and four European titles, both record hauls. \nMini - Wembley \nBuilt on an island in the river Garonne, the Stadium de Toulouse - sometimes referred to as the Stade Municipal - was built for the 1938 World Cup, and was initially described as \"mini-Wembley\" because of its resemblance to the London venue. \nIt was not used at Euro '84 but was revamped for France '98, hosting six games - including England's loss to Romania.Capacity was cut by 2, 000 prior to Euro 2016 in order to meet Uefa requirements for wider seats. \nAnd another thing...\nToulouse has a proud history of aviation, with supersonic passenger jet Concorde making its first test flight there in 1969. \n\nAddress: 1 Allée Gabriel Biénès, 31028 Toulouse");
            //Credits for images
            _venueDetails.Add("App created as part of college course work. \nStadia information and images from BBC Sport. \nAll other images from google images");

            int i;
            TextBlock curr;
            for (i = 0; i <= 10; i++)
            {
                curr = (TextBlock)pvtVenues.FindName("tblVenues" + i.ToString());
                if (curr != null)
                {
                    curr.Text = _venueDetails[i];
                }//if (curr != null)
            }//for (i = 0; i <= 10; i++)
        }//venueInformation
    }//MainPage : Page
}//Euro2016Venues
