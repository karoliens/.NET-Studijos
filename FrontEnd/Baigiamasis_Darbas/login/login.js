const loginFormSbmBtn = document.querySelector("#login");

function getName() {
  let name = document.forms["login-form"]["name"].value;
  return name;
}

function getSurname() {
  let surname = document.forms["login-form"]["surname"].value;
  return surname;
}

function addNameAndSurnameToHtml() {
  const paragraph = document.createElement("p");
  const text = document.createTextNode(
    "Šiuo metu prisijungęs" + " " + getName() + " " + getSurname()
  );

  paragraph.appendChild(text);

  const element = document.getElementById("body");

  element.appendChild(paragraph);
}

loginFormSbmBtn.addEventListener(
  "click",
  (e) => {
    e.preventDefault();
    lookForUser();
    addNameAndSurnameToHtml();
  },
  { once: true }
);

const url = "https://testapi.io/api/karoliens/resource/RegisteredUsers";

const lookForUser = () => {
  fetch(url).then((obj) => obj.json()).then(userData => console.log(userData);
    for (const user of userData.data) 
    {        
      if (user.name === getName() &&        
user.surname === getSurname())
}
  

  )
};
