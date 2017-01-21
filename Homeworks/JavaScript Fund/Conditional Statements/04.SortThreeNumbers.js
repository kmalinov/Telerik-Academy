function BiggesOfThree(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];

    if (a >= b && a >= c) {
        if (b >= c) {
            console.log(a + ' ' + b + ' ' + c);
        } else {
            console.log(a + ' ' + c + ' ' + b);
        }

    } else if (b >= a && b >= c) {
        if (a >= c) {
            console.log(b + ' ' + a + ' ' + c);
        } else {
            console.log(b + ' ' + c + ' ' + a);
        }
    } else if (c >= b && c >= a) {
        if (b >= a) {
            console.log(c + ' ' + b + ' ' + a);
        } else {
            console.log(c + ' ' + a + ' ' + b);
        }

    }

}

BiggesOfThree(['10', '30', '20']);