var url = `https://localhost:7234/Login`,
    formulario = document.getElementById("form-login"),
    txtCorreoLogin = document.getElementById("txtCorreoLogin"),
    txtPasswordLogin = document.getElementById("txtPasswordLogin");

formulario.addEventListener("submit", function (e) {
    e.preventDefault();

    if (formulario.checkValidity()) {
        const InputUser = {
            Email: txtCorreoLogin.value,
            Password: txtPasswordLogin.value,
        }

        


        fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(InputUser)
        })
            .then(response => {
                if (response.status === 401) {
                    alert("No se pudo encontrar el usuario")
                    return null; // Devuelve null para que puedas manejarlo en el siguiente then
                } else {
                    return response.json();
                }
            })
            .then(data => {

                if (data == null) {
                    console.log(null);
                } else {
                    sessionStorage.clear();
                    sessionStorage.setItem("token1", data.id);
                    sessionStorage.setItem("token2", data.name)
                    window.location.replace("./Home.html");

                }
            })
            .catch(error => {
                // Maneja errores de red u otros errores
                alert("No se pudo encontrar el usuario")
                txtPasswordLogin.value = '';
                console.error('Ocurrió un error:', error);
            });
    }

});