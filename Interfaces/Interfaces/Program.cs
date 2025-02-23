#region Using directives
using System;
using System.IO;
using System.Text;
#endregion

namespace ExtendedAndCombineInterface
{
    interface IStorable
    {
        void Read();
        void Write(object obj);
        int Status { get; set; }
    }

    interface ICompressible
    {
        void Compress();
        void Decompress();
    }

    interface ILoggedCompresible : ICompressible
    {
        void LogSavedBytes();
    }

    interface IStorableCompresible : ILoggedCompresible, IStorable
    {
        void LogOriginalSize();
    }

    interface IEncrytable
    {
        void Encrypt();
        void Decrypt();
    }

    public class Document : IStorableCompresible, IEncrytable
    {
        private int status = 0;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string content;
        private byte[] encryptedContent;
        private byte[] compressedContent;

        public Document(string s)
        {
            Console.WriteLine("Tworzenie dokumentu: {0}", s);
            content = s;
        }

        public void Read()
        {
            Console.WriteLine("Odczyt dokumentu: {0}", content);
        }

        public void Write(object obj)
        {
            if (obj is string)
            {
                content = obj as string;
                Console.WriteLine("Zapisano treść dokumentu: {0}", content);
            }
            else
            {
                Console.WriteLine("Błąd: Można zapisać tylko tekst.");
            }
        }

        public void Compress()
        {
            Console.WriteLine("Kompresowanie dokumentu...");
            // Symulacja kompresji poprzez prostą konwersję tekstu do tablicy bajtów
            compressedContent = Encoding.UTF8.GetBytes(content);
            Console.WriteLine("Dokument skompresowany (symulacja).");
        }

        public void Decompress()
        {
            Console.WriteLine("Dekompresowanie dokumentu...");
            // Symulacja dekompresji poprzez przekształcenie bajtów z powrotem w tekst
            content = Encoding.UTF8.GetString(compressedContent);
            Console.WriteLine("Dokument zdekompresowany (symulacja).");
        }

        public void LogSavedBytes()
        {
            if (compressedContent != null)
            {
                Console.WriteLine("Zapisane bajty po kompresji: {0}", compressedContent.Length);
            }
            else
            {
                Console.WriteLine("Brak danych skompresowanych.");
            }
        }

        public void LogOriginalSize()
        {
            Console.WriteLine("Oryginalny rozmiar dokumentu: {0} bajtów", Encoding.UTF8.GetByteCount(content));
        }

        public void Encrypt()
        {
            Console.WriteLine("Szyfrowanie dokumentu...");
            // Symulacja szyfrowania przez proste zamienianie znaków na ich kody ASCII
            encryptedContent = Encoding.UTF8.GetBytes(content);
            for (int i = 0; i < encryptedContent.Length; i++)
            {
                encryptedContent[i] ^= 0xAA; // Prosty algorytm XOR
            }
            Console.WriteLine("Dokument zaszyfrowany.");
        }

        public void Decrypt()
        {
            Console.WriteLine("Deszyfrowanie dokumentu...");
            for (int i = 0; i < encryptedContent.Length; i++)
            {
                encryptedContent[i] ^= 0xAA; // Prosty algorytm XOR
            }
            content = Encoding.UTF8.GetString(encryptedContent);
            Console.WriteLine("Dokument deszyfrowany.");
        }
    }

    public class CompresibleDocument : Document, IStorable
    {
        public CompresibleDocument(string s)
            : base(s)
        { }

        public new void Decompress()
        {
            Console.WriteLine("Wyodrębnianie danych z dokumentu compressible...");
            base.Decompress();
        }
    }

    public class Tester
    {
        static void Main(string[] args)
        {
            // Tworzenie dokumentu
            Document doc = new Document("Dokument tekstowy");

            // Sprawdzanie interfejsu IStorable
            IStorable storableDoc = doc as IStorable;
            if (storableDoc != null)
            {
                storableDoc.Read();
                storableDoc.Write("Nowy tekst dokumentu");
                storableDoc.Read();
            }

            // Kompresja
            ICompressible compressibleDoc = doc as ICompressible;
            if (compressibleDoc != null)
            {
                compressibleDoc.Compress();
                compressibleDoc.Decompress();
            }

            // Logowanie bajtów po kompresji
            ILoggedCompresible loggedCompressibleDoc = doc as ILoggedCompresible;
            if (loggedCompressibleDoc != null)
            {
                loggedCompressibleDoc.LogSavedBytes();
            }

            // Logowanie oryginalnego rozmiaru
            IStorableCompresible storableCompressibleDoc = doc as IStorableCompresible;
            if (storableCompressibleDoc != null)
            {
                storableCompressibleDoc.LogOriginalSize();
            }

            // Szyfrowanie i deszyfrowanie
            IEncrytable encrytableDoc = doc as IEncrytable;
            if (encrytableDoc != null)
            {
                encrytableDoc.Encrypt();
                encrytableDoc.Decrypt();
            }

            // Praca z tablicą dokumentów
            Document[] docArr = new Document[2];
            docArr[0] = new Document("Dokument tekstowy");
            docArr[1] = new CompresibleDocument("Dokument tekstowy typu Compressible");

            foreach (Document document in docArr)
            {
                Console.WriteLine("Dokument: {0}", document);
            }
        }
    }
}
