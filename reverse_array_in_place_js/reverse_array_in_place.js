function reverseArrayInPlace(arr) {
// reverse arr
// for loop to iterate through array - only half of array length
    for (var i = 0; i < arr.length / 2; i++) {
        //use a temp variable to switch elements in the array
        var tempVar = arr[i];
        arr[i] = arr[arr.length - 1 - i];
        arr[arr.length - 1 - i] = tempVar;
    }

    return arr;
}

reverseArrayInPlace(["hello", "hi", "hey"]);