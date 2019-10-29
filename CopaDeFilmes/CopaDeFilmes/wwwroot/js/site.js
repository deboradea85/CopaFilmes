function FilmeOnClick() {
    $('#msgAlert').hide();
    let selecionado = document.getElementById("filmesSelecionados");
    filmesSelecionados.textContent = ObterQtdFilmesSelecionados();
}

function ValidarFormOnSubmit() {
    if (ObterQtdFilmesSelecionados() == 8) {
        return true;
    } else {
        $('#msgAlert').show();
        return false;
    }
}

function ObterQtdFilmesSelecionados() {
    return document.querySelectorAll("input[type='checkbox']:checked").length;
}
