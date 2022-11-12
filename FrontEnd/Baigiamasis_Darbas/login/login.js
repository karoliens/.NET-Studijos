const loginFormSbmBtn = document.querySelector("#login");

function getName() {
  let x = document.forms["login"]["name"].value;
  console.log(x);
}

function getSurname() {
  let x = document.forms["login"]["surname"].value;
  console.log(x);
}

function validateNameAndSurname() {}

loginFormSbmBtn.addEventListener("click", (e) => {
  e.preventDefault();
  getName();
  getSurname();
});

const url = "https://testapi.io/api/karoliens/resource/RegisteredUsers";
const options = {
  method: "get",
  headers: {
    Accept: "application/json",
    "Content-Type": "application/json",
  },
};

const response = {};

function loadData() {
  fetch(url, options)
    .then((response) => response.json())
    .then((a) => {
      console.log(a);
      //const animalEle = document.getElementById('animal-text');
      //let htmlAnimal = '';

      a.data.forEach((element) => {
        console.log(element);
        //let htmlElement = `<p>${element.name}</p>
        //<p>${element.type}</p>
        //<p>${element.legs}</p>`;
        //htmlAnimal += htmlElement;
      });

      //animalEle.innerHTML = htmlAnimal;
    });
}

loadData();
