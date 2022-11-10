function isAllowedToDrink(age) {
  if (age >= 18) {
    alert("Allowed");
  } else {
    if (confirm("Press a button!") == true) {
      alert("Allowed");
    } else {
      alert("Not allowed");
    }
  }
}

isAllowedToDrink(40);
