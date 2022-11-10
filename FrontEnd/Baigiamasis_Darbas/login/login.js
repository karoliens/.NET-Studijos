const loginFormSbmBtn = document.querySelector("#prisijungti");

console.log("labas");

function getName() {
  let x = document.forms["login"]["vardas"].value;
  console.log(x);
}

function getSurname() {
  let x = document.forms["login"]["pavarde"].value;
  console.log(x);
}

loginFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault();
  getName();
  getSurname();
});
