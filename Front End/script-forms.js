const btnIniciarSesion = document.getElementById("btnIniciarSesion"),
        btnRegistrarse = document.getElementById("btnRegistrarse"),
        formRegister = document.querySelector(".container2"),
        formLogin  = document.querySelector(".container");
        formLogin.classList.remove("hide");

        btnRegistrarse.addEventListener("click", e =>{
            formLogin.classList.add("hide");
            limpiar();
            setTimeout(() => {
                formRegister.classList.remove("hide");
              }, 10); // Pequeño retraso para activar la transición
        });
        
        btnIniciarSesion.addEventListener("click", e =>{
            formRegister.classList.add("hide");
            limpiar();
            setTimeout(() => {
                formLogin.classList.remove("hide");
              }, 10); // Pequeño retraso para activar la transición
        }) 


        function limpiar()
        {
          let txtUsuario1  = document.getElementById("txtUsuario"),
              txtPassword1 = document.getElementById("txtPasswordRegister"),
              txtCorreo1  = document.getElementById("txtCorreoRegister"),
              txtCorreoLogin1 = document.getElementById("txtCorreoLogin"),
              txtPasswordLogin1 = document.getElementById("txtPasswordLogin");

              txtCorreo1.value = '';
              txtPassword1.value = '';
              txtUsuario1.value = '';
              txtCorreoLogin1.value = '';
              txtPasswordLogin1.value = '';

        }