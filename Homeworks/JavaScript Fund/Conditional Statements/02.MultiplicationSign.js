function multiplicationsign(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    if (a * b * c > 0) {
        return "+";

    } else if (a * b * c < 0) {
        return '-';
    } else {
        return '0';
    }

}

console.log(multiplicationsign(['5', '2', '2']));