const url = "https://localhost:7118/api/Ticket/tickets";

const submitBtn = document.querySelector("#ticket-submit");

submitBtn.addEventListener("click", (e) => {
  e.preventDefault();
  sendData();
});

function sendData() {
  const form = document.querySelector("#survey-form");

  let data = new FormData(form);
  let obj = {};

  data.forEach((value, key) => {
    console.log(`${key}(Key): ${value}(Value)`);
    obj[key] = value;
  });

  fetch(url, {
    method: "post",
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },

    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))
    .catch((error) => console.log(error));
}
