﻿using C_18_01_Capstone.Main.DataAccessLayer;
using System.Collections.Generic;

namespace C_18_01_Capstone.Main.DataContext
{
    public class DbInitializer
    {
        public void InitializeCountriesTable()
        {
            DataAccess<Country> dataAccess = new DataAccess<Country>();

            List<Country> countries = new List<Country>
            {
                // This collection built from Wikipedia entry on ISO3166-1 on 9th Feb 2016
                
                new Country{ Name="Afghanistan", CountryIsoCode2="AF",CountryIsoCode3= "AFG"},
                new Country{ Name="Åland Islands", CountryIsoCode2="AX", CountryIsoCode3 ="ALA"},
                new Country{ Name="Albania", CountryIsoCode2="AL", CountryIsoCode3="ALB" },
                new Country{ Name="Algeria", CountryIsoCode2 = "DZ", CountryIsoCode3="DZA" },
                new Country{ Name="American Samoa",CountryIsoCode2 = "AS", CountryIsoCode3="ASM" },
                new Country{ Name="Andorra", CountryIsoCode2 = "AD",CountryIsoCode3= "AND" },
                new Country{ Name="Angola", CountryIsoCode2 ="AO",CountryIsoCode3 = "AGO" },
                new Country{ Name="Anguilla", CountryIsoCode2 = "AI", CountryIsoCode3="AIA" },
                new Country{ Name = "Antarctica", CountryIsoCode2 = "AQ", CountryIsoCode3 = "ATA" },
                new Country{ Name = "Antigua and Barbuda", CountryIsoCode2 = "AG", CountryIsoCode3 = "ATG" },
                new Country{ Name="Argentina" ,CountryIsoCode2 = "AR",CountryIsoCode3="ARG"},
                new Country{ Name="Armenia",CountryIsoCode2=  "AM",CountryIsoCode3="ARM"},
                new Country{ Name="Aruba" ,CountryIsoCode2= "AW",CountryIsoCode3="ABW" },
                new Country{ Name="Australia" ,CountryIsoCode2= "AU",CountryIsoCode3 = "AUS"    },
                new Country{ Name="Austria" ,CountryIsoCode2= "AT" ,CountryIsoCode3 = "AUT"    },
                new Country{ Name="Azerbaijan" ,CountryIsoCode2= "AZ"  ,CountryIsoCode3 ="AZE"    },
                new Country{ Name="Bahamas" ,CountryIsoCode2= "BS",CountryIsoCode3 ="BHS"    },
                new Country{ Name="Bahrain" ,CountryIsoCode2= "BH",CountryIsoCode3 ="BHR"    },
                new Country{ Name="Bangladesh" ,CountryIsoCode2= "BD",CountryIsoCode3 ="BGD"    },
                new Country{ Name="Barbados" ,CountryIsoCode2= "BB",CountryIsoCode3 ="BRB"    },
                new Country{ Name="Belarus" ,CountryIsoCode2= "BY",CountryIsoCode3 ="BLR"     },
                new Country{ Name="Belgium" ,CountryIsoCode2= "BE",CountryIsoCode3 =  "BEL"    },
                new Country{ Name="Belize" ,CountryIsoCode2= "BZ" ,CountryIsoCode3 = "BLZ"    },
                new Country{ Name="Benin" ,CountryIsoCode2= "BJ"  ,CountryIsoCode3 ="BEN"     },
                new Country{ Name="Bermuda" ,CountryIsoCode2= "BM" ,CountryIsoCode3 = "BMU"    },
                new Country{ Name="Bhutan" ,CountryIsoCode2= "BT"  ,CountryIsoCode3 ="BTN"    },
                new Country{ Name="Bolivia (Plurinational State of}, " ,CountryIsoCode2= "BO",CountryIsoCode3 =  "BOL"    },
                new Country{ Name="Bonaire  Sint Eustatius and Saba" ,CountryIsoCode2= "BQ"  ,CountryIsoCode3 ="BES"     },
                new Country{ Name="Bosnia and Herzegovina" ,CountryIsoCode2= "BA" ,CountryIsoCode3 = "BIH"    },
                new Country{ Name="Botswana" ,CountryIsoCode2= "BW"  ,CountryIsoCode3 ="BWA"    },
                new Country{ Name="Bouvet Island"  ,CountryIsoCode2="BV" ,CountryIsoCode3 = "BVT"    },
                new Country{ Name="Brazil"  ,CountryIsoCode2="BR" ,CountryIsoCode3 = "BRA"    },
                new Country{ Name="British Indian Ocean Territory"  ,CountryIsoCode2="IO"  ,CountryIsoCode3 ="IOT"    },
                new Country{ Name="Brunei Darussalam" ,CountryIsoCode2= "BN" ,CountryIsoCode3 = "BRN"    },
                new Country{ Name="Bulgaria" ,CountryIsoCode2= "BG" ,CountryIsoCode3 = "BGR"     },
                new Country{ Name="Burkina Faso"  ,CountryIsoCode2="BF"  ,CountryIsoCode3 ="BFA"     },
                new Country{ Name="Burundi"  ,CountryIsoCode2="BI" ,CountryIsoCode3 = "BDI"     },
                new Country{ Name="Cabo Verde" ,CountryIsoCode2= "CV" ,CountryIsoCode3 = "CPV"     },
                new Country{ Name="Cambodia",CountryIsoCode2=  "KH" ,CountryIsoCode3 = "KHM"     },
                new Country{ Name="Cameroon" ,CountryIsoCode2= "CM" ,CountryIsoCode3 = "CMR"     },
                new Country{ Name="Canada"  ,CountryIsoCode2="CA" ,CountryIsoCode3 = "CAN"     },
                new Country{ Name="Cayman Islands" ,CountryIsoCode2= "KY" ,CountryIsoCode3 = "CYM"     },
                new Country{ Name="Central African Republic" ,CountryIsoCode2= "CF" ,CountryIsoCode3 = "CAF"     },
                new Country{ Name="Chad" ,CountryIsoCode2= "TD",CountryIsoCode3 ="TCD"     },
                new Country{ Name="Chile" ,CountryIsoCode2= "CL",CountryIsoCode3 ="CHL"     },
                new Country{ Name="China" ,CountryIsoCode2= "CN",CountryIsoCode3 ="CHN"     },
                new Country{ Name="Christmas Island"  ,CountryIsoCode2="CX",CountryIsoCode3 ="CXR"     },
                new Country{ Name="Cocos (Keeling},  Islands"  ,CountryIsoCode2="CC",CountryIsoCode3 ="CCK"     },
                new Country{ Name="Colombia" ,CountryIsoCode2= "CO"  ,CountryIsoCode3 ="COL"     },
                new Country{ Name="Comoros" ,CountryIsoCode2= "KM" ,CountryIsoCode3 = "COM"     },
                new Country{ Name="Congo" ,CountryIsoCode2= "CG" ,CountryIsoCode3 = "COG"     },
                new Country{ Name="Congo (Democratic Republic of the}, ",CountryIsoCode2=  "CD" ,CountryIsoCode3 = "COD"     },
                new Country{ Name="Cook Islands" ,CountryIsoCode2= "CK",CountryIsoCode3 =  "COK"     },
                new Country{ Name="Costa Rica" ,CountryIsoCode2= "CR" ,CountryIsoCode3 = "CRI"     },
                new Country{ Name="C?te d'Ivoire" ,CountryIsoCode2= "CI",CountryIsoCode3 ="CIV"     },
                new Country{ Name="Croatia" ,CountryIsoCode2= "HR",CountryIsoCode3 ="HRV"     },
                new Country{ Name="Cuba" ,CountryIsoCode2= "CU",CountryIsoCode3 ="CUB"     },
                new Country{ Name="Cura?ao" ,CountryIsoCode2= "CW",CountryIsoCode3 ="CUW"     },
                new Country{ Name="Cyprus" ,CountryIsoCode2= "CY",CountryIsoCode3 ="CYP"     },
                new Country{ Name="Czech Republic" ,CountryIsoCode2= "CZ",CountryIsoCode3 ="CZE"     },
                new Country{ Name="Denmark" ,CountryIsoCode2= "DK",CountryIsoCode3 ="DNK"     },
                new Country{ Name="Djibouti",CountryIsoCode2=  "DJ",CountryIsoCode3 ="DJI"     },
                new Country{ Name="Dominica",CountryIsoCode2=  "DM",CountryIsoCode3 ="DMA"     },
                new Country{ Name="Dominican Republic" ,CountryIsoCode2= "DO",CountryIsoCode3 ="DOM"     },
                new Country{ Name="Ecuador",CountryIsoCode2=  "EC",CountryIsoCode3 ="ECU"     },
                new Country{ Name="Egypt"  ,CountryIsoCode2="EG",CountryIsoCode3 ="EGY"     },
                new Country{ Name="El Salvador"  ,CountryIsoCode2="SV",CountryIsoCode3 ="SLV"     },
                new Country{ Name="Equatorial Guinea" ,CountryIsoCode2= "GQ",CountryIsoCode3 ="GNQ"     },
                new Country{ Name="Eritrea" ,CountryIsoCode2= "ER",CountryIsoCode3 ="ERI"     },
                new Country{ Name="Estonia" ,CountryIsoCode2= "EE",CountryIsoCode3 ="EST"     },
                new Country{ Name="Ethiopia",CountryIsoCode2=  "ET",CountryIsoCode3 ="ETH"     },
                new Country{ Name="Falkland Islands (Malvinas}, " ,CountryIsoCode2= "FK",CountryIsoCode3 ="FLK"     },
                new Country{ Name="Faroe Islands" ,CountryIsoCode2= "FO",CountryIsoCode3 ="FRO"     },
                new Country{ Name="Fiji" ,CountryIsoCode2= "FJ",CountryIsoCode3 ="FJI"     },
                new Country{ Name="Finland" ,CountryIsoCode2= "FI",CountryIsoCode3 ="FIN"     },
                new Country{ Name="France" ,CountryIsoCode2= "FR" ,CountryIsoCode3 = "FRA"     },
                new Country{ Name="French Guiana" ,CountryIsoCode2= "GF",CountryIsoCode3 ="GUF"     },
                new Country{ Name="French Polynesia" ,CountryIsoCode2= "PF",CountryIsoCode3 ="PYF"     },
                new Country{ Name="French Southern Territories" ,CountryIsoCode2= "TF",CountryIsoCode3 ="ATF"     },
                new Country{ Name="Gabon" ,CountryIsoCode2= "GA"  ,CountryIsoCode3 ="GAB"     },
                new Country{ Name="Gambia"  ,CountryIsoCode2="GM" ,CountryIsoCode3 = "GMB"     },
                new Country{ Name="Georgia" ,CountryIsoCode2= "GE",CountryIsoCode3 =  "GEO"     },
                new Country{ Name="Germany" ,CountryIsoCode2= "DE",CountryIsoCode3 =  "DEU"     },
                new Country{ Name="Ghana" ,CountryIsoCode2= "GH"  ,CountryIsoCode3 ="GHA"     },
                new Country{ Name="Gibraltar" ,CountryIsoCode2= "GI",CountryIsoCode3 =  "GIB"     },
                new Country{ Name="Greece",CountryIsoCode2=  "GR" ,CountryIsoCode3 = "GRC"     },
                new Country{ Name="Greenland" ,CountryIsoCode2= "GL" ,CountryIsoCode3 = "GRL"     },
                new Country{ Name="Grenada" ,CountryIsoCode2= "GD" ,CountryIsoCode3 = "GRD"     },
                new Country{ Name="Guadeloupe" ,CountryIsoCode2= "GP" ,CountryIsoCode3 = "GLP"     },
                new Country{ Name="Guam" ,CountryIsoCode2= "GU" ,CountryIsoCode3 = "GUM"     },
                new Country{ Name="Guatemala" ,CountryIsoCode2= "GT" ,CountryIsoCode3 = "GTM"     },
                new Country{ Name="Guernsey" ,CountryIsoCode2= "GG" ,CountryIsoCode3 = "GGY"     },
                new Country{ Name="Guinea" ,CountryIsoCode2= "GN" ,CountryIsoCode3 = "GIN"     },
                new Country{ Name="Guinea-Bissau" ,CountryIsoCode2= "GW" ,CountryIsoCode3 = "GNB"     },
                new Country{ Name="Guyana",CountryIsoCode2=  "GY" ,CountryIsoCode3 = "GUY"     },
                new Country{ Name="Haiti" ,CountryIsoCode2= "HT" ,CountryIsoCode3 = "HTI"     },
                new Country{ Name="Heard Island and McDonald Islands" ,CountryIsoCode2= "HM" ,CountryIsoCode3 = "HMD"     },
                new Country{ Name="Holy See" ,CountryIsoCode2= "VA" ,CountryIsoCode3 = "VAT"     },
                new Country{ Name="Honduras" ,CountryIsoCode2= "HN" ,CountryIsoCode3 = "HND"     },
                new Country{ Name="Hong Kong"  ,CountryIsoCode2="HK" ,CountryIsoCode3 = "HKG"     },
                new Country{ Name="Hungary" ,CountryIsoCode2= "HU" ,CountryIsoCode3 = "HUN"     },
                new Country{ Name="Iceland" ,CountryIsoCode2= "IS" ,CountryIsoCode3 = "ISL"     },
                new Country{ Name="India",CountryIsoCode2=  "IN" ,CountryIsoCode3 = "IND"     },
                new Country{ Name="Indonesia" ,CountryIsoCode2= "ID" ,CountryIsoCode3 = "IDN"     },
                new Country{ Name="Iran (Islamic Republic of}, "  ,CountryIsoCode2="IR" ,CountryIsoCode3 = "IRN"     },
                new Country{ Name="Iraq" ,CountryIsoCode2= "IQ" ,CountryIsoCode3 = "IRQ"     },
                new Country{ Name="Ireland" ,CountryIsoCode2= "IE" ,CountryIsoCode3 = "IRL"     },
                new Country{ Name="Isle of Man" ,CountryIsoCode2= "IM" ,CountryIsoCode3 = "IMN"     },
                new Country{ Name="Israel" ,CountryIsoCode2= "IL" ,CountryIsoCode3 = "ISR"     },
                new Country{ Name="Italy" ,CountryIsoCode2= "IT" ,CountryIsoCode3 = "ITA"     },
                new Country{ Name="Jamaica" ,CountryIsoCode2= "JM",CountryIsoCode3 ="JAM"     },
                new Country{ Name="Japan" ,CountryIsoCode2= "JP" ,CountryIsoCode3 = "JPN"     },
                new Country{ Name="Jersey" ,CountryIsoCode2= "JE" ,CountryIsoCode3 = "JEY"     },
                new Country{ Name="Jordan" ,CountryIsoCode2= "JO" ,CountryIsoCode3 = "JOR"     },
                new Country{ Name="Kazakhstan" ,CountryIsoCode2= "KZ" ,CountryIsoCode3 = "KAZ"     },
                new Country{ Name="Kenya" ,CountryIsoCode2= "KE" ,CountryIsoCode3 = "KEN"     },
                new Country{ Name="Kiribati"  ,CountryIsoCode2="KI" ,CountryIsoCode3 = "KIR"     },
                new Country{ Name="Korea (Democratic People's Republic of) ",CountryIsoCode2=  "KP",CountryIsoCode3 =  "PRK"     },
                new Country{ Name="Korea (Republic of) ",CountryIsoCode2=  "KR" ,CountryIsoCode3 = "KOR"     },
                new Country{ Name="Kuwait" ,CountryIsoCode2= "KW" ,CountryIsoCode3 = "KWT"     },
                new Country{ Name="Kyrgyzstan",CountryIsoCode2=  "KG",CountryIsoCode3 =  "KGZ"     },
                new Country{ Name="Lao People's Democratic Republic" ,CountryIsoCode2= "LA",CountryIsoCode3 =  "LAO"     },
                new Country{ Name="Latvia" ,CountryIsoCode2= "LV" ,CountryIsoCode3 = "LVA"     },
                new Country{ Name="Lebanon" ,CountryIsoCode2= "LB" ,CountryIsoCode3 = "LBN"     },
                new Country{ Name="Lesotho" ,CountryIsoCode2= "LS" ,CountryIsoCode3 = "LSO"     },
                new Country{ Name="Liberia" ,CountryIsoCode2= "LR" ,CountryIsoCode3 = "LBR"     },
                new Country{ Name="Libya" ,CountryIsoCode2= "LY" ,CountryIsoCode3 = "LBY"     },
                new Country{ Name="Liechtenstein" ,CountryIsoCode2= "LI" ,CountryIsoCode3 = "LIE"     },
                new Country{ Name="Lithuania"  ,CountryIsoCode2="LT",CountryIsoCode3 =  "LTU"     },
                new Country{ Name="Luxembourg" ,CountryIsoCode2= "LU" ,CountryIsoCode3 = "LUX"     },
                new Country{ Name="Macao" ,CountryIsoCode2= "MO" ,CountryIsoCode3 = "MAC"     },
                new Country{ Name="Macedonia (the former Yugoslav Republic of) ",CountryIsoCode2=  "MK" ,CountryIsoCode3 = "MKD"     },
                new Country{ Name="Madagascar" ,CountryIsoCode2= "MG" ,CountryIsoCode3 = "MDG"     },
                new Country{ Name="Malawi" ,CountryIsoCode2= "MW" ,CountryIsoCode3 = "MWI"     },
                new Country{ Name="Malaysia" ,CountryIsoCode2= "MY" ,CountryIsoCode3 = "MYS"     },
                new Country{ Name="Maldives" ,CountryIsoCode2= "MV" ,CountryIsoCode3 = "MDV"     },
                new Country{ Name="Mali" ,CountryIsoCode2= "ML" ,CountryIsoCode3 = "MLI"     },
                new Country{ Name="Malta"  ,CountryIsoCode2="MT"  ,CountryIsoCode3 ="MLT"     },
                new Country{ Name="Marshall Islands" ,CountryIsoCode2= "MH" ,CountryIsoCode3 = "MHL"     },
                new Country{ Name="Martinique" ,CountryIsoCode2= "MQ" ,CountryIsoCode3 = "MTQ"     },
                new Country{ Name="Mauritania" ,CountryIsoCode2= "MR" ,CountryIsoCode3 = "MRT"     },
                new Country{ Name="Mauritius",CountryIsoCode2=  "MU" ,CountryIsoCode3 = "MUS"     },
                new Country{ Name="Mayotte" ,CountryIsoCode2= "YT" ,CountryIsoCode3 = "MYT"     },
                new Country{ Name="Mexico",CountryIsoCode2=  "MX" ,CountryIsoCode3 = "MEX"     },
                new Country{ Name="Micronesia (Federated States of) " ,CountryIsoCode2= "FM" ,CountryIsoCode3 = "FSM"     },
                new Country{ Name="Moldova (Republic of) " ,CountryIsoCode2="MD",CountryIsoCode3 =  "MDA"     },
                new Country{ Name="Monaco" ,CountryIsoCode2= "MC" ,CountryIsoCode3 = "MCO"     },
                new Country{ Name="Mongolia" ,CountryIsoCode2= "MN" ,CountryIsoCode3 = "MNG"     },
                new Country{ Name="Montenegro"  ,CountryIsoCode2="ME" ,CountryIsoCode3 = "MNE"     },
                new Country{ Name="Montserrat" ,CountryIsoCode2= "MS" ,CountryIsoCode3 = "MSR"     },
                new Country{ Name="Morocco" ,CountryIsoCode2= "MA" ,CountryIsoCode3 = "MAR"     },
                new Country{ Name="Mozambique" ,CountryIsoCode2= "MZ",CountryIsoCode3 =  "MOZ"     },
                new Country{ Name="Myanmar" ,CountryIsoCode2= "MM" ,CountryIsoCode3 = "MMR"     },
                new Country{ Name="Namibia" ,CountryIsoCode2= "NA" ,CountryIsoCode3 = "NAM"     },
                new Country{ Name="Nauru" ,CountryIsoCode2= "NR" ,CountryIsoCode3 = "NRU"     },
                new Country{ Name="Nepal" ,CountryIsoCode2= "NP" ,CountryIsoCode3 = "NPL"     },
                new Country{ Name="Netherlands" ,CountryIsoCode2= "NL" ,CountryIsoCode3 = "NLD"     },
                new Country{ Name="New Caledonia"  ,CountryIsoCode2="NC" ,CountryIsoCode3 = "NCL"     },
                new Country{ Name="New Zealand,CountryIsoCode2=" ,CountryIsoCode2= "NZ",CountryIsoCode3 =  "NZL"     },
                new Country{ Name="Nicaragua" ,CountryIsoCode2= "NI" ,CountryIsoCode3 = "NIC"     },
                new Country{ Name="Niger" ,CountryIsoCode2= "NE" ,CountryIsoCode3 = "NER"     },
                new Country{ Name="Nigeria"  ,CountryIsoCode2="NG" ,CountryIsoCode3 = "NGA"     },
                new Country{ Name="Niue"  ,CountryIsoCode2="NU" ,CountryIsoCode3 = "NIU"     },
                new Country{ Name="Norfolk Island"  ,CountryIsoCode2="NF",CountryIsoCode3 =  "NFK"     },
                new Country{ Name="Northern Mariana Islands" ,CountryIsoCode2= "MP" ,CountryIsoCode3 = "MNP"     },
                new Country{ Name="Norway"  ,CountryIsoCode2="NO" ,CountryIsoCode3 = "NOR"     },
                new Country{ Name="Oman" ,CountryIsoCode2= "OM" ,CountryIsoCode3 = "OMN"     },
                new Country{ Name="Pakistan" ,CountryIsoCode2= "PK" ,CountryIsoCode3 = "PAK"     },
                new Country{ Name="Palau"  ,CountryIsoCode2="PW" ,CountryIsoCode3 = "PLW"     },
                new Country{ Name="Palestine  State of" ,CountryIsoCode2= "PS" ,CountryIsoCode3 = "PSE"     },
                new Country{ Name="Panama" ,CountryIsoCode2= "PA" ,CountryIsoCode3 = "PAN"     },
                new Country{ Name="Papua New Guinea",CountryIsoCode2=  "PG" ,CountryIsoCode3 = "PNG"     },
                new Country{ Name="Paraguay" ,CountryIsoCode2= "PY" ,CountryIsoCode3 = "PRY"     },
                new Country{ Name="Peru"  ,CountryIsoCode2="PE",CountryIsoCode3 =  "PER"     },
                new Country{ Name="Philippines"  ,CountryIsoCode2="PH" ,CountryIsoCode3 = "PHL"     },
                new Country{ Name="Pitcairn" ,CountryIsoCode2= "PN" ,CountryIsoCode3 = "PCN"     },
                new Country{ Name="Poland" ,CountryIsoCode2= "PL" ,CountryIsoCode3 = "POL"     },
                new Country{ Name="Portugal",CountryIsoCode2="PT" ,CountryIsoCode3 = "PRT"     },
                new Country{ Name="Puerto Rico",CountryIsoCode2="PR" ,CountryIsoCode3 = "PRI"     },
                new Country{ Name="Qatar",CountryIsoCode2="QA" ,CountryIsoCode3 = "QAT"     },
                new Country{ Name="R?union",CountryIsoCode2="RE"  ,CountryIsoCode3 ="REU"     },
                new Country{ Name="Romania",CountryIsoCode2="RO" ,CountryIsoCode3 = "ROU"     },
                new Country{ Name="Russian Federation",CountryIsoCode2="RU" ,CountryIsoCode3 = "RUS"     },
                new Country{ Name="Rwanda",CountryIsoCode2="RW" ,CountryIsoCode3 = "RWA"     },
                new Country{ Name="Saint Barth?lemy",CountryIsoCode2="BL" ,CountryIsoCode3 = "BLM"     },
                new Country{ Name="Saint Helena  Ascension and Tristan da Cunha",CountryIsoCode2="SH" ,CountryIsoCode3 = "SHN"     },
                new Country{ Name="Saint Kitts and Nevis",CountryIsoCode2="KN" ,CountryIsoCode3 = "KNA"     },
                new Country{ Name="Saint Lucia",CountryIsoCode2="LC" ,CountryIsoCode3 = "LCA"     },
                new Country{ Name="Saint Martin (French part}, ",CountryIsoCode2="MF" ,CountryIsoCode3 = "MAF"     },
                new Country{ Name="Saint Pierre and Miquelon",CountryIsoCode2="PM",CountryIsoCode3 =  "SPM"     },
                new Country{ Name="Saint Vincent and the Grenadines",CountryIsoCode2="VC" ,CountryIsoCode3 = "VCT"     },
                new Country{ Name="Samoa",CountryIsoCode2="WS" ,CountryIsoCode3 = "WSM"     },
                new Country{ Name="San Marino",CountryIsoCode2="SM" ,CountryIsoCode3 = "SMR"     },
                new Country{ Name="Sao Tome and Principe",CountryIsoCode2="ST" ,CountryIsoCode3 = "STP"     },
                new Country{ Name="Saudi Arabia",CountryIsoCode2="SA" ,CountryIsoCode3 = "SAU"     },
                new Country{ Name="Senegal",CountryIsoCode2="SN",CountryIsoCode3 =  "SEN"     },
                new Country{ Name="Serbia",CountryIsoCode2="RS" ,CountryIsoCode3 = "SRB"     },
                new Country{ Name="Seychelles",CountryIsoCode2="SC" ,CountryIsoCode3 = "SYC"     },
                new Country{ Name="Sierra Leone",CountryIsoCode2="SL" ,CountryIsoCode3 = "SLE"     },
                new Country{ Name="Singapore" ,CountryIsoCode2= "SG",CountryIsoCode3 =  "SGP"     },
                new Country{ Name="Sint Maarten (Dutch part}, ",CountryIsoCode2="SX" ,CountryIsoCode3 = "SXM"     },
                new Country{ Name="Slovakia",CountryIsoCode2="SK" ,CountryIsoCode3 = "SVK"     },
                new Country{ Name="Slovenia",CountryIsoCode2="SI" ,CountryIsoCode3 = "SVN"     },
                new Country{ Name="Solomon Islands",CountryIsoCode2="SB" ,CountryIsoCode3 = "SLB"    },
                new Country{ Name="Somalia",CountryIsoCode2="SO" ,CountryIsoCode3 = "SOM"     },
                new Country{ Name="South Africa",CountryIsoCode2="ZA" ,CountryIsoCode3 = "ZAF"     },
                new Country{ Name="South Georgia and the South Sandwich Islands",CountryIsoCode2="GS" ,CountryIsoCode3 = "SGS"     },
                new Country{ Name="South Sudan",CountryIsoCode2="SS" ,CountryIsoCode3 = "SSD"     },
                new Country{ Name="Spain" ,CountryIsoCode2= "ES" ,CountryIsoCode3 = "ESP"     },
                new Country{ Name="Sri Lanka" ,CountryIsoCode2= "LK"  ,CountryIsoCode3 ="LKA"     },
                new Country{ Name="Sudan"  ,CountryIsoCode2="SD" ,CountryIsoCode3 = "SDN"     },
                new Country{ Name="Suriname",CountryIsoCode2=  "SR" ,CountryIsoCode3 = "SUR"     },
                new Country{ Name="Svalbard and Jan Mayen" ,CountryIsoCode2= "SJ" ,CountryIsoCode3 = "SJM"     },
                new Country{ Name="Swaziland"  ,CountryIsoCode2="SZ" ,CountryIsoCode3 = "SWZ"     },
                new Country{ Name="Sweden"  ,CountryIsoCode2="SE",CountryIsoCode3 =  "SWE"     },
                new Country{ Name="Switzerland" ,CountryIsoCode2= "CH" ,CountryIsoCode3 = "CHE"     },
                new Country{ Name="Syrian Arab Republic" ,CountryIsoCode2= "SY"  ,CountryIsoCode3 ="SYR"     },
                new Country{ Name="Taiwan  Province of China[a]" ,CountryIsoCode2= "TW",CountryIsoCode3 =  "TWN"     },
                new Country{ Name="Tajikistan" ,CountryIsoCode2= "TJ" ,CountryIsoCode3 = "TJK"     },
                new Country{ Name="Tanzania  United Republic of" ,CountryIsoCode2= "TZ" ,CountryIsoCode3 = "TZA"     },
                new Country{ Name="Thailand" ,CountryIsoCode2= "TH" ,CountryIsoCode3 = "THA"     },
                new Country{ Name="Timor-Leste" ,CountryIsoCode2= "TL" ,CountryIsoCode3 = "TLS"     },
                new Country{ Name="Togo" ,CountryIsoCode2= "TG" ,CountryIsoCode3 = "TGO"     },
                new Country{ Name="Tokelau" ,CountryIsoCode2= "TK"  ,CountryIsoCode3 ="TKL"     },
                new Country{ Name="Tonga" ,CountryIsoCode2= "TO" ,CountryIsoCode3 = "TON"     },
                new Country{ Name="Trinidad and Tobago" ,CountryIsoCode2= "TT" ,CountryIsoCode3 = "TTO"     },
                new Country{ Name="Tunisia"  ,CountryIsoCode2="TN" ,CountryIsoCode3 = "TUN"     },
                new Country{ Name="Turkey" ,CountryIsoCode2= "TR",CountryIsoCode3 =  "TUR"     },
                new Country{ Name="Turkmenistan" ,CountryIsoCode2= "TM" ,CountryIsoCode3 = "TKM"     },
                new Country{ Name="Turks and Caicos Islands" ,CountryIsoCode2= "TC" ,CountryIsoCode3 = "TCA"     },
                new Country{ Name="Tuvalu" ,CountryIsoCode2= "TV" ,CountryIsoCode3 = "TUV"     },
                new Country{ Name="Uganda" ,CountryIsoCode2= "UG" ,CountryIsoCode3 = "UGA"     },
                new Country{ Name="Ukraine",CountryIsoCode2=  "UA"  ,CountryIsoCode3 ="UKR"     },
                new Country{ Name="United Arab Emirates" ,CountryIsoCode2= "AE" ,CountryIsoCode3 = "ARE"     },
                new Country{ Name="United Kingdom of Great Britain and Northern Ireland"  ,CountryIsoCode2="GB" ,CountryIsoCode3 = "GBR"     },
                new Country{ Name="United States of America"  ,CountryIsoCode2="US" ,CountryIsoCode3 = "USA"     },
                new Country{ Name="United States Minor Outlying Islands" ,CountryIsoCode2= "UM" ,CountryIsoCode3 = "UMI"     },
                new Country{ Name="Uruguay",CountryIsoCode2=  "UY",CountryIsoCode3 =  "URY"     },
                new Country{ Name="Uzbekistan" ,CountryIsoCode2= "UZ" ,CountryIsoCode3 = "UZB"     },
                new Country{ Name="Vanuatu" ,CountryIsoCode2= "VU" ,CountryIsoCode3 = "VUT"     },
                new Country{ Name="Venezuela (Bolivarian Republic of}, " ,CountryIsoCode2= "VE"  ,CountryIsoCode3 ="VEN"     },
                new Country{ Name="Viet Nam" ,CountryIsoCode2= "VN",CountryIsoCode3 =  "VNM"     },
                new Country{ Name="Virgin Islands (British}, "  ,CountryIsoCode2="VG" ,CountryIsoCode3 = "VGB"    },
                new Country{ Name="Virgin Islands (U.S.}, " ,CountryIsoCode2= "VI" ,CountryIsoCode3 = "VIR"},
                new Country{ Name="Wallis and Futuna"  ,CountryIsoCode2="WF",CountryIsoCode3 =  "WLF"},
                new Country{ Name="Western Sahara" ,CountryIsoCode2= "EH",CountryIsoCode3 =  "ESH"},
                new Country{ Name="Yemen" ,CountryIsoCode2= "YE",CountryIsoCode3 =  "YEM"},
                new Country{ Name="Zambia" ,CountryIsoCode2= "ZM" ,CountryIsoCode3 = "ZMB"},
                new Country{ Name= "Zimbabwe" ,CountryIsoCode2= "ZW" ,CountryIsoCode3 = "ZWE"}
            };

            dataAccess.AddRange(countries);
        }
    }
}
