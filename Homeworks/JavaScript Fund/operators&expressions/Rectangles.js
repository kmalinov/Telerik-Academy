//Description: Implement a javascript function that takes an argument array as a parameter and calculates rectangle’s area and perimeter by given 
//width and height. The width and height will both be passed in the argument array.


function solve(args) {
    let a = +args[0],
        b = +args[1];
    let perim = 2 * a + 2 * b;
    let area = a * b;

    console.log(area.toFixed(2) + " " + perim.toFixed(2));



}

solve(4, 7);