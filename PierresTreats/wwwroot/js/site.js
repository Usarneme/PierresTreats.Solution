$(".delete-association").on("click", async function() {
  const url = `/delete_association/${this.id}`
  const result = await fetch(url, { method: "POST" })
  if (result.ok) {
    $(`#${this.id}`).parent().remove()
  } else {
    alert("Error deleting association. Please try again later.")
  }
})
