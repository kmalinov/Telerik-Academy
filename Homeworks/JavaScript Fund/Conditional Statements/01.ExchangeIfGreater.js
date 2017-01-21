function greater(args) {
    let a = +args[0];
    let b = +args[1];
    if (a > b) {
        console.log(b + ' ' + a);
    } else {
        console.log(a + ' ' + b);
    }
}


greater(['5', '2']);