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
      Accept: "application/json, text/plain, */*",
      "Content-Type": "application/json",
    },
    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))
    .catch((error) => console.log(error));
}

registrationFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault();
  sendData();
  //openToDoAppWindow();
});

function openToDoAppWindow() {
  window.open(
    "file:///C:/Users/Karolis/source/repos/.NET-Studijos/FrontEnd/Baigiamasis_Darbas/to-do-app/to-do-app.html",
    "_blank"
  );
}
