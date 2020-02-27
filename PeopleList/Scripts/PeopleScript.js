window.addEventListener("DOMContentLoaded", function () {


    let btn = document.querySelector("#Add");
    btn.addEventListener("click", (event) => {
        event.preventDefault();
        btn.style.background = "red";
        let div = document.querySelector(".container");
        let inputs = div.childNodes;
        let flag = 0;
        inputs.forEach((elem) => {
            try {
                if (elem.classList.contains('form-control')) {
                    console.log(elem.value);
                    if (elem.value == "") {
                        flag = 1;
                    }
                }
            } catch{ }
        });
        if (flag == 0) {
           
        }

    });
    function onComplete(result) {
        alert(result);
    }
    function onError(error) {
        alert(error.message);
    }
});