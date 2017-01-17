'use strict';

function nameA(args) {
    let a = +args[0];
    let b = +args[1];
    console.log((a * b).toFixed(2) + ' ' + ((a + b) * 2).toFixed(2));
}

nameA(['6', '5']);