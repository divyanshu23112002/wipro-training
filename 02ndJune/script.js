document.getElementById("studentForm").addEventListener("submit", function(e) {
  e.preventDefault();

  const name = document.getElementById("name").value;
  const studentClass = document.getElementById("class").value;
  const roll = document.getElementById("roll").value;

  if (name && studentClass && roll) {
    const table = document.getElementById("studentTableBody");

    const row = document.createElement("tr");

    row.innerHTML = `
      <td>${name}</td>
      <td>${studentClass}</td>
      <td>${roll}</td>
    `;

    table.appendChild(row);

    // Clear the form
    document.getElementById("studentForm").reset();
  }
});