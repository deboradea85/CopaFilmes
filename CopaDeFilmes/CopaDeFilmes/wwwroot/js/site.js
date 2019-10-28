function FilmeOnClick() {
    let selecionado = document.getElementById("filmesSelecionados");
    filmesSelecionados.textContent = ObterQtdFilmesSelecionados();
}

function ValidarFormOnSubmit() {
    if (ObterQtdFilmesSelecionados() == 8) {
        return true;
    } else {
        alert("É necessário selecionar 8 filmes para prosseguir");
        return false;
    }
}

function ObterQtdFilmesSelecionados() {
    return document.querySelectorAll("input[type='checkbox']:checked").length;
}