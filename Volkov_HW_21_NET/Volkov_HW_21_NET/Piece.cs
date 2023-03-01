using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_21_NET
{
    internal class Piece : IDisposable
    {
        string namepiece;
        string NS;
        string genre;
        int year;

        public Piece()
        {
            namepiece= string.Empty;
            NS = string.Empty;
            genre = string.Empty;
            year = 0;
        }

        public Piece(string namepiece, string nS, string genre, int year)
        {
            this.namepiece = namepiece;
            NS = nS;
            this.genre = genre;
            this.year = year;
        }

        public override string ToString()
        {
            return $"Name piece -> {namepiece}\nName surname -> {NS}\nGenre -> {genre}\nYear -> {year}";
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        ~Piece()
        {
            Console.WriteLine("Finalize");
        }
    }
}
