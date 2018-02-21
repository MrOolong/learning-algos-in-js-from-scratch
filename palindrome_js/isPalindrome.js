function isPalindrome(string) {
    // make all input lowercase using toLowerCase method
    string = string.toLowerCase();
    // split string into character array
    var charactersArr = string.split('');
    // define valid characters to use against the input
    var validCharacters = 'abcdefghijklmnopqrstuvwxyz'.split('');
    
    // create array
    var lettersArr = [];
    charactersArr.forEach(char => {
        if (validCharacters.indexOf(char) > -1) lettersArr.push(char);
    });

    if (lettersArr.join('') === lettersArr.reverse().join('')) return true;
    else return false;
}

console.log(isPalindrome("Madam I'm Adam"));