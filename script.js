// Dark and Light Mode

let themeButton = document.getElementById("themeButton");

themeButton.onclick = function () {

    document.body.classList.toggle("dark");

    if (document.body.classList.contains("dark")) {
        themeButton.innerHTML = "☀️";
    } else {
        themeButton.innerHTML = "🌙";
    }

};


// Say Hello Button

function sayHello() {

    let name = prompt("What is your name?");

    if (name != null && name != "") {

        document.getElementById("greeting").innerHTML =
            "Hello " + name + "! 👋 Welcome to my portfolio.";

    } else {

        document.getElementById("greeting").innerHTML =
            "Hello! 👋 Welcome to my portfolio.";

    }

}


// Project Buttons

function projectMessage(projectName) {

    alert(
        "You selected the " +
        projectName +
        " project! 🚀"
    );

}


// Contact Form

let contactForm = document.getElementById("contactForm");

contactForm.onsubmit = function (event) {

    event.preventDefault();

    let name = document.getElementById("name").value;
    let email = document.getElementById("email").value;
    let message = document.getElementById("message").value;

    if (name == "" || email == "" || message == "") {

        alert("Please fill in all the fields.");

    } else {

        alert(
            "Thank you, " +
            name +
            "! Your message has been submitted."
        );

        contactForm.reset();

    }

};