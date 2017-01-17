function PointInACircle(param) {
    let x = +param[0];
    let y = +param[1];
    let R = 2;
    if (x * x + y * y <= 4) {
        console.log('yes' + ' ' + Math.sqrt((x * x) + (y * y)).toFixed(2));

    } else {
        console.log('no' + ' ' + Math.sqrt((x * x) + (y * y)).toFixed(2));

    }


}
PointInACircle(['0.2', '-0.8']);