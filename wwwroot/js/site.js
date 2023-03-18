

function isChecked(checkboxField, field) {
  if (document.getElementById(checkboxField).checked == true) {
    for (let i = 0; i < field.length; i++) {
      document.getElementById(field[i]).disabled = false;
      document.getElementById(field[i]).hidden = false;
      document.getElementById(field[i]).required = true;
    }

  } else {
    for (let i = 0; i < field.length; i++) {
      document.getElementById(field[i]).disabled = true;
      document.getElementById(field[i]).hidden = true;
      document.getElementById(field[i]).required = false;
    }
  }


}

function searchInTables(campo, tabela) {
  var input, filter, found, table, tr, td, i, j;
  input = document.getElementById(campo);
  filter = input.value.toUpperCase();
  table = document.getElementById(tabela);
  tr = table.getElementsByTagName("tr");
  for (i = 0; i < tr.length; i++) {
    td = tr[i].getElementsByTagName("td");
    for (j = 0; j < td.length; j++) {
      if (td[j].innerHTML.toUpperCase().indexOf(filter) > -1) {
        found = true;
      }
    }
    if (found) {
      tr[i].style.display = "";
      found = false;
    } else {
      tr[i].style.display = "none";
    }
  }
}


function toEmpy(){
  document.getElementById("ViewBag").innerHTML = "";
}
function isEmpy(field, valor, info) {
  document.getElementById("ViewBag").innerHTML = "";
  if (valor.value.length < 1) {
    document.getElementById(field).innerHTML = "<font color='red'>" + info + "</font>";
    return false;
  }
  else {
    document.getElementById(field).innerHTML = "";
    return true;

  }
}