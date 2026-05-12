// ============================================
// Program #296 — HangmanGame
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Hangman with random word selection, lives, and letter guesses.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_296_HangmanGame
    {
        static void Main(string[] args)
        {
            string[] words = { "computer", "algorithm", "namespace", "variable", "inheritance" };
            string word = words[new Random().Next(words.Length)];
            var guessed = new System.Collections.Generic.HashSet<char>();
            int lives = 6;

            while (lives > 0)
            {
                bool completed = true;
                Console.Write("Word: ");
                foreach (char ch in word)
                {
                    if (guessed.Contains(ch)) Console.Write(ch + " ");
                    else { Console.Write("_ "); completed = false; }
                }
                Console.WriteLine($" | Lives: {lives}");
                if (completed) { Console.WriteLine("You won Hangman!"); return; }

                Console.Write("Guess letter: ");
                string s = (Console.ReadLine() ?? "").Trim().ToLower();
                if (s.Length != 1 || !char.IsLetter(s[0])) { Console.WriteLine("Enter one letter."); continue; }
                char g = s[0];
                if (!guessed.Add(g)) { Console.WriteLine("Already guessed."); continue; }
                if (word.IndexOf(g) < 0) { lives--; Console.WriteLine("Wrong guess."); }
                else Console.WriteLine("Good guess.");
            }
            Console.WriteLine($"You lost. Word was: {word}");
        }
    }
}
