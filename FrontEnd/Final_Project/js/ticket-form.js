const registrationForm = document.querySelector("#new-ticket-form");
const registrationFormSbmBtn = document.querySelector("#ticket-submit-button");

const url = "https://localhost:7118/api/Client/clients";

function sendData() {
  let data = new FormData(registrationForm);
  let obj = {};

  console.log(data);

  data.forEach((value, key) => {
    obj[key] = value;
  });

  fetch("https://localhost:7118/api/Client/clients", {
    method: "post",
    body: JSON.stringify(obj),
  }).catch((error) => console.log(error));
}

registrationFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault();
  sendData();
});
