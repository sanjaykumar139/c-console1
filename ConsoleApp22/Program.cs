using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace ConsoleApp22
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");

            string strCountry = "512:'Oman','4':'Afghanistan','516':'Namibia','8':'Albania','520':'Nauru','10':'Antarctica','12':'Algeria','524':'Nepal','16':'American Samoa','528':'Netherlands','531':'Curacao','20':'Andorra','533':'Aruba','534':'Sint Maarten (Dutch part)','535':'Bonaire, Saint Eustatius and S','24':'Angola','28':'Antigua and Barbuda','540':'New Caledonia','31':'Azerbaijan','32':'Argentina','36':'Australia','548':'Vanuatu','40':'Austria','554':'New Zealand','558':'Nicaragua','48':'Bahrain','50':'Bangladesh','562':'Niger','51':'Armenia','52':'Barbados','566':'Nigeria','56':'Bermuda','570':'Niue','574':'Norfolk Island','64':'Bhutan','578':'Norway','68':'Bolivia, Plurinational State o','580':'Northern Mariana Islands','581':'United States Minor Outlying I','70':'Bosnia and Herzegovina','583':'Micronesia, Federated States o','72':'Botswana','584':'Marshall Islands','585':'Palau','74':'Bouvet Island','586':'Pakistan','76':'Brazil','591':'Panama','84':'Belize','86':'British Indian Ocean Territory','598':'Papua New Guinea','600':'Paraguay','90':'Solomon Islands','92':'Virgin Islands, British','604':'Peru','96':'Brunei Darussalam','608':'Philippines','100':'Bulgaria','612':'Pitcairn','104':'Myanmar','616':'Poland','108':'Burundi','620':'Portugal','112':'Belarus','624':'Guinea-Bissau','626':'Timor-Leste','116':'Cambodia','630':'Puerto Rico','120':'Cameroon','634':'Qatar','124':'Canada','638':'Reunion','642':'Romania','643':'Russian Federation','132':'Cape Verde','646':'Rwanda','136':'Cayman Islands','140':'Central African Republic','652':'Saint Barthelemy','654':'Saint Helena, Ascension and Tr','144':'Sri Lanka','659':'Saint Kitts and Nevis','148':'Chad','660':'Anguilla','662':'Saint Lucia','663':'Saint Martin (French part)','152':'Chile','666':'Saint Pierre and Miquelon','156':'China','158':'Taiwan, Province of China','670':'Saint Vincent and the Grenadin','162':'Christmas Island','674':'San Marino','166':'Cocos (Keeling) Islands','678':'Sao Tome and Principe','170':'Colombia','682':'Saudi Arabia','174':'Comoros','686':'Senegal','175':'Mayotte','688':'Serbia','178':'Congo','690':'Seychelles','180':'Congo, the Democratic Republic','694':'Sierra Leone','184':'Cook Islands','188':'Costa Rica','702':'Singapore','191':'Croatia','703':'Slovakia','192':'Cuba','704':'Viet Nam','705':'Slovenia','706':'Somalia','196':'Cyprus','710':'South Africa','203':'Czech Republic','204':'Benin','716':'Zimbabwe','208':'Denmark','212':'Dominica','724':'Spain','214':'Dominican Republic','218':'Ecuador','732':'Western Sahara','222':'El Salvador','736':'Sudan','226':'Equatorial Guinea','740':'Suriname','231':'Ethiopia','232':'Eritrea','744':'Svalbard and Jan Mayen','233':'Estonia','234':'Faroe Islands','748':'Swaziland','238':'Falkland Islands (Malvinas)','239':'South Georgia and the South Sa','752':'Sweden','242':'Fiji','756':'Switzerland','246':'Finland','248':'Aland Islands','760':'Syrian Arab Republic','250':'France','762':'Tajikistan','764':'Thailand','254':'French Guiana','768':'Togo','258':'French Polynesia','260':'French Southern Territories','772':'Tokelau','262':'Djibouti','776':'Tonga','266':'Gabon','268':'Georgia','780':'Trinidad and Tobago','270':'Gambia','784':'United Arab Emirates','275':'Palestinian Territory, Occupie','276':'Germany','788':'Tunisia','792':'Turkey','795':'Turkmenistan','796':'Turks and Caicos Islands','798':'Tuvalu','288':'Ghana','800':'Uganda','292':'Gibraltar','804':'Ukraine','807':'Macedonia, the former Yugoslav','296':'Kiribati','300':'Greece','304':'Greenland','818':'Egypt','308':'Grenada','312':'Guadeloupe','826':'United Kingdom','316':'Guam','831':'Guernsey','320':'Guatemala','832':'Jersey','833':'Isle of Man','834':'Tanzania, United Republic of','324':'Guinea','328':'Guyana','840':'United States','332':'Haiti','334':'Heard Island and McDonald Isla','336':'Holy See (Vatican City State)','850':'Virgin Islands, U.S.','340':'Honduras','854':'Burkina Faso','344':'Hong Kong','858':'Uruguay','348':'Hungary','860':'Uzbekistan','862':'Venezuela, Bolivarian Republic','352':'Iceland','356':'India','360':'Indonesia','364':'Iran, Islamic Republic of','876':'Wallis and Futuna','368':'Iraq','882':'Samoa','372':'Ireland','887':'Yemen','376':'Israel','380':'Italy','894':'Zambia','384':'Cote d'Ivoire','388':'Jamaica','392':'Japan','398':'Kazakhstan','400':'Jordan','404':'Kenya','408':'Korea, Democratic People's Rep','410':'Korea, Republic of','414':'Kuwait','417':'Kyrgyzstan','418':'Lao People's Democratic Republ','422':'Lebanon','426':'Lesotho','428':'Latvia','430':'Liberia','434':'Libyan Arab Jamahiriya','438':'Liechtenstein','440':'Lithuania','442':'Luxembourg','446':'Macao','450':'Madagascar','454':'Malawi','458':'Malaysia','462':'Maldives','466':'Mali','470':'Malta','474':'Martinique','478':'Mauritania','480':'Mauritius','484':'Mexico','492':'Monaco','496':'Mongolia','498':'Moldova, Republic of','499':'Montenegro','500':'Montserrat','504':'Morocco','508':'Mozambique'},'status':'success'}";

            strCountry = strCountry.TrimStart('{').TrimEnd('}');

            string[] strCollection = strCountry.Split(',');

            Dictionary<int, string> CountryDic = new Dictionary<int, string>();



            foreach (var ab in strCollection)
            {

                string[] strCollection2 = ab.Split(':');
                CountryDic.Add(Convert.ToInt32(strCollection2[0]), strCollection2[1]);

                Console.WriteLine(ab);
            }
            Console.ReadLine();
        
        }
    }
}
