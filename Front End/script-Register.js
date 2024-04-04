
var formRegister1 = document.getElementById("form-register"),
    urlApiRegister = `https://localhost:7234/Register`,
    txtUsuario = document.getElementById("txtUsuario"),
    txtPassword = document.getElementById("txtPasswordRegister"),
    txtCorreo = document.getElementById("txtCorreoRegister"),
    selectNivelAcc = document.getElementById("selectNivelAcc");

formRegister1.addEventListener("submit", function (i) {
    i.preventDefault();
    if (formRegister1.checkValidity()) {
        let nuevoUsuario = {
            Name: txtUsuario.value,
            Email: txtCorreo.value,
            Password: txtPassword.value
         };

        fetch(urlApiRegister, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(nuevoUsuario)
        })
            .then(response => response.json())
            .then(data =>{
                sessionStorage.clear();
                sessionStorage.setItem("token1", data.id);
                sessionStorage.setItem("token2", data.name)
                window.location.replace("./Home.html");

            })
            .catch(error => {
                console.log(error)
                alert("Ha ocurrido un error.");

            });

    };

});


