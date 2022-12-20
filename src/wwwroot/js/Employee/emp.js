console.log("hello");

let inputs = document.querySelectorAll("input");

for (var i = 0; i < 3; i++) {
   

    if (i < 2) {
        inputs[i].addEventListener("keydown", (e) => {
            console.log(e);

            if (e.keyCode > 95 && e.keyCode <= 105) {
                e.preventDefault();
                alert(e.keyCode);
            }
        });

    }
    else {
        inputs[i].addEventListener("keydown", (e) => {
            console.log(e);

            if (e.keyCode > 65 && e.keyCode <= 90) {
                e.preventDefault();
                alert(e.keyCode);
            }
        });
    }
}


//--? Extera Work
//inputs.forEach((item) => {
//    item.addEventListener("keydown", (e) => {
//        console.log(e);

//        if (e.keyCode > 95 && e.keyCode <= 105) {
//            e.preventDefault();
//            alert(e.keyCode);
//        }
//    })
//});

console.log(inputs[2].parentElement.children[0].innerHTML)
console.log(inputs);