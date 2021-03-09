using System.Collections.Generic; 
public static class Kata
    {
        // You could also try a switch case with default to english
        // This method approach should also work instead of using 
        // a dictionary. Only using it here cause I've been using python 
        // recently and wanted to see if I could do something similar in C#
        
        public static string Greet(string language)
        {
            var DataList = new Dictionary<string, string> {
              {"english", "Welcome"},
              {"czech", "Vitejte"},
              {"danish", "Velkomst"},
              {"dutch", "Welkom"},
              {"estonian", "Tere tulemast"},
              {"finnish", "Tervetuloa"},
              {"flemish", "Welgekomen"},
              {"french", "Bienvenue"},
              {"german", "Willkommen"},
              {"irish", "Failte"},
              {"italian", "Benvenuto"},
              {"latvian", "Gaidits"},
              {"lithuanian", "Laukiamas"},
              {"polish", "Witamy"},
              {"spanish", "Bienvenido"},
              {"swedish", "Valkommen"},
              {"welsh", "Croeso"} };
          
          foreach(var item in DataList.Keys) {
            if (language == item) {
              return DataList[item];
            }
          }
          return DataList["english"];
        }
    }
