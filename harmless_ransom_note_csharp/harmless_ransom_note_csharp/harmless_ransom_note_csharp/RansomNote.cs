using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmless_ransom_note_csharp
{
    class RansomNote
    {
        public Boolean MakeRansomNote(string NoteText, string MagazineText)
        {
            // abc
            string[] noteArr = NoteText.Split(' ');
            string[] magazineArr = MagazineText.Split(' ');
            //need to make magazine object
            var magazineObj = "";

            foreach (string word in magazineArr)
            {
                if (!magazineObj[word]) magazineObj[word] = 0;
                magazineObj[word]++;
            }

            bool noteIsPossible = true;
            foreach (var word in noteArr)
            {
                if (magazineObj[word])
                {
                    magazineObj[word]--;
                    if (magazineObj[word] < 0) noteIsPossible = false;
                }
                else noteIsPossible = false;
            }
            return noteIsPossible
        }
    }
}
