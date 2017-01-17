function PrimeCheck(N) {
    let a = +N[0];
    if (a > 1 && a / a == 1 && a % a == 0 && a / 1 == a && a % 2 != 0 && a % 3 != 0) {
        console.log(true);


    } else if (a == 2 || a == 3) {
        console.log(true);
    } else {
        console.log(false);
    }


}

PrimeCheck(['101']);