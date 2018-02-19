function harmlessRansomNote(noteText, MagazineText) {
    var noteArr = noteText.split(' ');
    var magazineArr = MagazineText.split(' ');
    var magazineObj = {};

    // loop through the magazine object to see if the words exist. If words exist, count them
    magazineArr.forEach(word => {
        if (!magazineObj[word]) magazineObj[word] = 0;
        magazineObj[word]++;
    });

    var noteIsPossible = true;
    noteArr.forEach(word => {
        if (magazineObj[word]) {
            magazineObj[word]--;
            if (magazineObj[wprd] < 0) noteIsPossible = false;
        }
        else noteIsPossible = false;
    });

    return noteIsPossible;
    //console.log(magazineObj);
}

harmlessRansomNote('', 'this is all the magazine text in the magazine');