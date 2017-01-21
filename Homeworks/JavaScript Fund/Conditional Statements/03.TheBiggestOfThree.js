function BiggestOfTrhree(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];

    if (a > b && a > c) {
        console.log(a);
    } else if (b > a && b > c) {
        console.log(b);

    } else {
        console.log(c);
    }



}
BiggestOfTrhree(['0', '-2.5', '5']);