function Trapezoids(N) {
    let a = +N[0],
        b = +N[1],
        h = +N[2];

    console.log((((a + b) * h) / 2).toFixed(7));

}

Trapezoids(['2', '1', '33']);