function isPasswordValid(username, password) {
  if (password.length < 8 || password === username || password.includes(" ")) {
    console.log("Not valid");
  } else {
    console.log("Valid");
  }
}

let username = prompt("Enter username");
let password = prompt("Enter password");
isPasswordValid(username, password);
