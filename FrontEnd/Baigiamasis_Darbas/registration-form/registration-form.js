const registrationForm = document.querySelector("#registration-form");
const registrationFormSbmBtn = document.querySelector("#registruotis");

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
      "Accept": "application/json, text/plain, */*",
      "Content-Type": "application/json",
    },
    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))
    .catch((klaida) => console.log(klaida));
}

registrationFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault();
  sendData();
});