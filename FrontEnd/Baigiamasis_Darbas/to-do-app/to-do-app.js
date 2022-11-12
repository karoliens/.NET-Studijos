const addFormBtn = document.querySelector("#addForm");

// Create a break line element
const br = document.createElement("br");
function addForm() {
  // Create a form dynamically
  const form = document.createElement("form");
  //form.setAttribute("method", "post");
  //form.setAttribute("action", "submit.php");
  form.setAttribute("id", "form");

  // Create an input element for Type
  const type = document.createElement("input");
  type.setAttribute("type", "text");
  type.setAttribute("name", "type");
  type.setAttribute("placeholder", "Type");
  type.setAttribute("id", "type");

  // Create an input element for Content
  const content = document.createElement("input");
  content.setAttribute("type", "text");
  content.setAttribute("name", "content");
  content.setAttribute("placeholder", "Content");
  content.setAttribute("id", "content");

  // Create an input element for End Date
  const endDate = document.createElement("input");
  endDate.setAttribute("type", "text");
  endDate.setAttribute("name", "endDate");
  endDate.setAttribute("placeholder", "End Date");
  endDate.setAttribute("id", "endDate");

  // Create an input element for Name
  const name = document.createElement("input");
  name.setAttribute("type", "text");
  name.setAttribute("name", "name");
  name.setAttribute("placeholder", "Name");
  name.setAttribute("id", "name");

  // Create the buttons
  const submitBtn = document.createElement("input");
  submitBtn.setAttribute("type", "button");
  submitBtn.setAttribute("value", "Submit");
  submitBtn.setAttribute("id", "submitBtn");

  const editBtn = document.createElement("input");
  editBtn.setAttribute("type", "submit");
  editBtn.setAttribute("value", "Edit");
  editBtn.setAttribute("id", "editBtn");

  const deleteBtn = document.createElement("input");
  deleteBtn.setAttribute("type", "submit");
  deleteBtn.setAttribute("value", "Delete");
  deleteBtn.setAttribute("id", "deleteBtn");

  // Append the Type input to the form
  form.appendChild(type);

  // Inserting a line break
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the Content input to the form
  form.appendChild(content);
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the End Date input to the form
  form.appendChild(endDate);
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the End Date input to the form
  form.appendChild(name);
  form.appendChild(br.cloneNode());
  form.appendChild(br.cloneNode());

  // Append the buttons to the form
  form.appendChild(submitBtn);
  form.appendChild(editBtn);
  form.appendChild(deleteBtn);

  document.getElementsByTagName("body")[0].appendChild(form);
}

addFormBtn.addEventListener(
  "click",
  (e) => {
    e.preventDefault();
    addForm();
  },
  { once: true }
);

const form = document.querySelector("#form");
const formSbmBtn = document.querySelector("#submitBtn");

function sendData() {
  let data = new FormData(form);
  let obj = {};

  obj["15612"] = "timeValue";

  console.log(data);

  // #1 iteracija -> obj {name: 'asd'}
  // #2 iteracija -> obj {type: 'asd'}
  data.forEach((value, key) => {
    console.log(`${key}(Key): ${value}(Value)`);
    obj[key] = value;
  });

  fetch("https://testapi.io/api/karoliens/resource/ToDoAppDB", {
    method: "post",
    headers: {
      Accept: "application/json, text/plain, */*",
      "Content-Type": "application/json",
    },
    // Naudojame JSON.stringify, nes objekte neturim .json() metodo
    body: JSON.stringify(obj),
  })
    .then((obj) => console.log(obj.json()))
    .catch((error) => console.log(error));
}

formSbmBtn.addEventListener("click", (e) => {
  e.preventDefault(); // Breaks manual refresh after submit
  sendData();
});
