using System;
using System.Runtime.CompilerServices;



    internal class Program
    { static void Main(string[] args)
    {
        //inserimento dati Contribuenti
        Console.WriteLine("inserisci nome");
        string nome = Console.ReadLine();

        Console.WriteLine("inserisci cognome");
        string cognome = Console.ReadLine();

        Console.WriteLine("inserisci datanNascita");
        string dataNascita = Console.ReadLine();

        Console.WriteLine("inserisci codiceFiscale");
        string codiceFiscale = Console.ReadLine();

        Console.WriteLine("inserisci sesso");
        char sesso = Char.Parse(Console.ReadLine());

        Console.WriteLine("inserisci comuneResidenza");
        string comuneResidenza = Console.ReadLine();

        Console.WriteLine("redditoAnnuale");
        decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

        //creazione istanza Contribuente

        Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

        Console.WriteLine($"===================================================\r\nCALCOLO DELL'IMPOSTA DA VERSARE:\r\n\r\nContribuente: {contribuente.Nome} {contribuente.Cognome},\r\nnato il {contribuente.DataNascita} ({contribuente.Sesso}),\r\nresidente in {contribuente.ComuneResidenza},\r\ncodice fiscale: {contribuente.CodiceFiscale}\r\n\r\nReddito dichiarato: {contribuente.RedditoAnnuale}\r\n\r\nIMPOSTA DA VERSARE: € {contribuente.CalcoloImposta()}");



    }
    
}
    /* +--Contribuente--------------------+
    | Nome, Cognome, DataNascita,      |
    | CodiceFiscale, Sesso,            |
    | ComuneRedsidenza, RedditoAnnuale |
    +----------------------------------+ */
    public class Contribuente
            {
                public string Nome { get; set; }
                public string Cognome { get; set; }
                public string DataNascita { get; set; }
                public string CodiceFiscale { get; set; }
                public char Sesso { get; set; }
                public string ComuneResidenza { get; set; }
                public decimal RedditoAnnuale { get; set; }
            //costruttore inizializza dati
            public Contribuente (string nome, string cognome, string dataNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
            {Nome = nome; Cognome = cognome; DataNascita = dataNascita; CodiceFiscale = codiceFiscale; Sesso = sesso; ComuneResidenza = comuneResidenza; RedditoAnnuale = redditoAnnuale; }

            //calcolo l imposta 
             public decimal CalcoloImposta()
            {
                decimal imposta = 0;
                decimal redditoAnnuale = RedditoAnnuale;
                if (redditoAnnuale <= 15000)
                {
                    imposta = redditoAnnuale * 0.23m;
                }
                else if (redditoAnnuale <= 28000)
                { imposta = 3450m + (redditoAnnuale - 15000m) * 0.27m; }
               
                else if (redditoAnnuale <= 55000)
                {
                    imposta = 6960m + (redditoAnnuale - 28000) * 0.38m; }
                
                else if (redditoAnnuale <= 75000 )
                {
                    imposta = 17220m + (redditoAnnuale - 55000m) * 0.41m;
                }
                 else
                {
                    imposta = 25420m + (redditoAnnuale - 75000m) * 0.43m;
                }  
                return imposta; 
                }
            }
                
        
                
            
            

            
    
