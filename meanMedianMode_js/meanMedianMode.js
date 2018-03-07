function getMean(array) {
    var sum = 0;

    array.forEach(num => {
        sum += num;
    });

    var mean = sum / array.length;
    return mean;
}

function getMedian(array) {
    array.sort(function(a,b) {return a - b});
    var median;
    if (array.length % 2 !== 0) {
        median = array[Math.floor(array.length / 2)];
    }
    else {
        var mid1 = array[(array.length / 2) - 1];
        var mid2 = array[array.length / 2];
        median = (mid1 + mid2) / 2;
    }
}

function getMode(array) {
    
}

function meanMedianMode(array) {
    return {
        mean: getMean(array),
        median: getMedian(array),
        mode: getMode(array)
        };
    }
}