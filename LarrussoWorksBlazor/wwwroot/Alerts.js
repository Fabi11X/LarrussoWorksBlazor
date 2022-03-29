function agregarUsuario() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Usuario agregado correctamente',
        showConfirmButton: false,
        timer: 1500
    })
}

function actualizarUsuario() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Usuario editado correctamente',
        showConfirmButton: false,
        timer: 1500
    })
}






function agregarEmpleo() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Empleo agregado correctamente',
        showConfirmButton: false,
        timer: 1500
    })
}

function agregarEmpresa() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Empresa agregada correctamente',
        showConfirmButton: false,
        timer: 1500
    })
}

function agregarCategoria() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Categoria agregada correctamente',
        showConfirmButton: false,
        timer: 1500
    })
}

function agregarAdministradores() {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Administrador agregado correctamente',
        showConfirmButton: false,
        timer: 1500
    })
}



function mensajeenviado() {
    let timerInterval
    Swal.fire({
        title: 'Tu mensaje se a enviado correctamente',
        html: 'Esta ventana se cerrara en <b></b> breve',
        timer: 1500,
        timerProgressBar: true,
        didOpen: () => {
            Swal.showLoading()
            const b = Swal.getHtmlContainer().querySelector('b')
            timerInterval = setInterval(() => {
                b.textContent = Swal.getTimerLeft()
            }, 100)
        },
        willClose: () => {
            clearInterval(timerInterval)
        }
    }).then((result) => {
        /* Read more about handling dismissals below */
        if (result.dismiss === Swal.DismissReason.timer) {
            console.log('I was closed by the timer')
        }
    })
}


function actualizarUsuario(){

}

