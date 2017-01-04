'use strict';


//function DivideBySevenAndFive(numberDiv) {
//   let a = numberDiv % 7 === 0 && numberDiv % 5 === 0;
//   if (a) {
//      console.log(a + " " + numberDiv);

//   } else {
//       console.log(a + " " + numberDiv);
//   }



//}
function DivideBySevenAndFive(numberDiv) {
    let a = numberDiv % 7 === 0 && numberDiv % 5 === 0;
    if (a) {
        console.log(a, Number(numberDiv));

    } else {
        console.log(a, Number(numberDiv));
    }



}

DivideBySevenAndFive(356);