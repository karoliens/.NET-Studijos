const registrationForm = document.querySelector("#registration-form");
const registrationFormSbmBtn = document.querySelector("#register");

function sendData() {
  let data = new FormData(registrationForm);
  let obj = {};

  console.log(data);

  data.forEach((value, key) => {
    obj[key] = value;
  });

  fetch("https://testapi.io/api/karoliens/resource/RegisteredUsers", {
    method: "post",
    headers: {
      "Accept": "application/json",
      "Content-Type": "application/json",
    },
    body: JSON.stringify(obj),
  })
    .then(openToDoAppWindow())
    .catch((error) => console.log(error));
}

function checkIfFormIsCompleted() {
  if (document.getElementById("name").value === "") {
    console.log("Name is not entered");
  } else if (document.getElementById("surname").value === "") {
    console.log("Surname is not entered");
  } else if (document.getElementById("mail").value === "") {
    console.log("Email is not entered");
    return false;
  } else {
    return true;
  }
}

registrationFormSbmBtn.addEventListener("click", (e) => {
  if (checkIfFormIsCompleted() === true) {
    e.preventDefault();
    sendData();
  }
});

function openToDoAppWindow() {
  window.open("../to-do-app/to-do-app.html", "_self");
}
