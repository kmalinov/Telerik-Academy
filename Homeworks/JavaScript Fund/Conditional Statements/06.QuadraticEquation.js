function QuadraticEquation(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    let d = b * b - 4 * (a * c);
    if (d > 0) {
        let x1 = (-b + Math.sqrt(d)) / (2 * a);
        let x2 = (-b - Math.sqrt(d)) / (2 * a);
        console.log('x1=' + x1.toFixed(2) + '; ' + 'x2=' + x2.toFixed(2));

    } else if (d === 0) {
        x1 = -b / (2 * a);
        console.log('x1=x2=' + x1.toFixed(2));

    } else {
        console.log('no real roots');
    }









}


QuadraticEquation(['-0.5', '4', '-8']);