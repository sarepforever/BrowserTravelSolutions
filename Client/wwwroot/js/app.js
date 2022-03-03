function showModal(id) {
    $("#" + id).modal("show")
};
function hideModal(id, idAbrir = "") {
    $("#" + id).modal("hide")
    if (idAbrir != "")
        $("#" + idAbrir).modal("show")
};
