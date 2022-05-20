function hello(){
    var nome = document.getElementById('cliente').value
    if (nome === ""){
        alert("Erro! Digite seus dados.")
    }
    else{
        alert("Olá " + nome + ", Seja bem vindo!" );
    }
    
}