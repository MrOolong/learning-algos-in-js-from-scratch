function reverseWords(string) {
    // create array of all words in string
    var wordsArr = string.split(' ');
    // create empty array to push all our reversed words into
    var reverseWordsArr = [];

    wordsArr.forEach(word => {
        //build empty string for reversing words
        var reversedWord = '';
        for (var i = word.length -1; i >= 0; i--) {
            reversedWord += word[i];
        }
        reverseWordsArr.push(reversedWord);
    });

    return reverseWordsArr.join(' ');
}

reverseWords("this is a string of words");