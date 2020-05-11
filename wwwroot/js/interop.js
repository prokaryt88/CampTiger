function mySearch() {
  var key, clean, table, tr, td, i, txt;
  key = document.getElementById("searchKey");
  clean = key.value.toUpperCase();
  table = document.getElementById("list");
  tr = table.getElementsByTagName("tr");
  for (i = 1; i < tr.length; i++) {
    td = tr[i].getElementsByTagName("td")[0];
    if (td) {
      txt = td.textContent || td.innerText;
      if (txt.toUpperCase().indexOf(clean) > -1) {
        tr[i].style.display = "";
      } else {
        tr[i].style.display = "none";
      }
    }       
  }
}