    using System;
    namespace Singleton.Database;
    public class Database
    {
        static Database instance;
        static List<Utente> listaUtenti;
        static List<Gruppo> listaGruppi;

        protected Database()
        {   
            initialize();
        }
        public static Database Instance()
        {

            if (instance == null)
            {
                instance = new Database();
                Console.WriteLine("Created");
            }
            else {
            Console.WriteLine("Already Created");
            }
            return instance;
        }


    
    private static void initialize(){
    //bovino ma no voglia 
    string[] linesUtenti = System.IO.File.ReadAllLines("Files/utenti.txt");
    listaUtenti=new List<Utente>();
    string[] linesGruppi = System.IO.File.ReadAllLines("Files/gruppi.txt");
    listaGruppi = new List<Gruppo>();

    foreach (string line in linesUtenti)
    {   
        Console.WriteLine(line);
        string[] credentials=line.Split(",");
        listaUtenti.Add(new Utente(credentials[0],credentials[1]));
    }

    foreach (string line in linesGruppi)
    {   
        Console.WriteLine(line);
        string[] groups=line.Split(",");
        listaGruppi.Add(new Gruppo(groups[0], Int32.Parse(groups[1])));
    } 
    }
    
    public List<Utente> getListaUtenti(){
    return listaUtenti;
    }
    public List<Gruppo> getListaGruppi(){
    return listaGruppi;
    }
    }

