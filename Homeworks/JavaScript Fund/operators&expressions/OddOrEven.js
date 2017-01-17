'use strict';

function oddEven(a) {

    if (a % 2 === 0) {
        return 'even ' + a;
    } else {
        return 'odd ' + a;
    }
}

console.log(oddEven(12));