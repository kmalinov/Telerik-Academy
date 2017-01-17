function thirdDigit(a) {
    let b = a[0]

    let c = b.length;

    if (b[c - 3] == 7) {
        console.log(true + ' ' + 'LOVE');

    } else if (c < 3) {
        console.log(false + " " + '0');

    } else {
        console.log(false + ' ' + b[c - 3]);
    }
}

thirdDigit(['1720'])