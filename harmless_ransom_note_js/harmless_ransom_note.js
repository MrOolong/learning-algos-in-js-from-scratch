function harmlessRansomNote(noteText, MagazineText) {
    var noteArr = noteText.split(' ');
    var magazineArr = MagazineText.split(' ');
    var magazineObj = {};

    // loop through the magazine object to see if the words exist. If words exist, count them
    // linear time complexity O(n) + O(m) or O(n + m)
    // O(m)
    magazineArr.forEach(word => {
        if (!magazineObj[word]) magazineObj[word] = 0;
        magazineObj[word]++;
    });

    var noteIsPossible = true;
    // O(n)
    noteArr.forEach(word => {
        if (magazineObj[word]) {
            magazineObj[word]--;
            if (magazineObj[word] < 0) noteIsPossible = false;
        }
        else noteIsPossible = false;
    });

    return noteIsPossible;
    //console.log(magazineObj);
}

harmlessRansomNote('this is a secret note for you from a secret admirer',
 'puerto rico is a place of great wonder and excitement it has many secret waterfall locations that I am an admirer of you must hike quite a distance to find the secret places as they are far from populated areas but it is worth the effort a tip I have for you is to go early in the morning when it is not so hot out also note that you must wear hiking boots this is one of the best places I have ever visited');