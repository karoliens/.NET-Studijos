function arKeliamiejiMetai(metai) {
  if (metai / 4 && metai / 100 && metai / 400) {
    console.log("Keliamieji");
  } else {
    console.log("Nekeliamieji");
  }
}

arKeliamiejiMetai(2022);
