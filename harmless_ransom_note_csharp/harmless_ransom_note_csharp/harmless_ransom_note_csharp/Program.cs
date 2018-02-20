using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmless_ransom_note_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RansomNote ransomNote1 = new RansomNote();
            ransomNote1.MakeRansomNote("this is a secret note for you from a secret admirer", "puerto rico is a place of great wonder and excitement it has many secret waterfall locations that I am an admirer of you must hike quite a distance to find the secret places as they are far from populated areas but it is worth the effort a tip I have for you is to go early in the morning when it is not so hot out also note that you must wear hiking boots this is one of the best places I have ever visited");
        }
    }
}
