namespace ILA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Worüber willst du ein Witz hören! Entweder über das Fach Englisch, Deutsch, Informatik, Mathe, Französisch oder Sport. ");
            string eingabeWitz = Console.ReadLine();
            string witz = GetWitz(eingabeWitz);

            if (witz != null)
            {
                Console.Write("Hier ist ihr Witz: ");
                Console.WriteLine(witz);
            }
            else
            {
                Console.WriteLine("Ungültig");
            }
            
            static string GetWitz (string eingabeWitz) 
            {
                switch (eingabeWitz.ToLower()) 
                {
                    case "deutsch":
                        return "Warum war das Komma im Deutschunterricht gestresst? Weil es die ganze Zeit dazwischen stand!";
                    case "englisch":
                        return "Warum war der englische Buchstabe 'G' so freundlich? Weil er 'Hi' sagte!";
                    case "informatik":
                        return "Was sagt ein Infomatiker, wenn er auf die Welt kommt? Hallo Welt";
                    case "mathe":
                        return "Was macht ein Mathematiker im Garten? Wurzeln ziehen.";
                    case "französisch":
                        return "Warum hat das Französischbuch schlechte Laune? Weil es immer Akzente setzen muss!";
                    case "sport":
                        return "Ich hab mir einen Bumerang gekauft. Für ein Frisbee braucht man Freunde";
                    default:
                        return null; 
                }
                
                
                
            }
        }
    }
}