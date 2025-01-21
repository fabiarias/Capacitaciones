// El principal objetivo de este desafío es fortalecer tus habilidades en lógica de programación. Aquí deberás desarrollar la lógica para resolver el problema.
let misAmigos = [];

/* Tareas
    -Capturar la informacion del campo de texto
    -Validar que el campo no este vacio
    -Actualizar la lista de amigos monstrando el arreglo en un elemento <ul>
    -Limpiar el campo de texto

*/

//Funcion que me permite agregar los nombres ingresados en la caja de texco a un arreglo
function agregarAmigo() {
    let input = document.getElementById('amigo');
    let amigo = input.value;
    if (amigo === '') {
        alert('Debes ingresar un nombre');
    } else {
        misAmigos.push(amigo);
        actualizarLista();
        input.value = '';
    }
}

//Funcion que me permite actualizar la lista de amigos en el DOM por medio de listas
function actualizarLista() {
    let lista = document.getElementById('listaAmigos');
    lista.innerHTML = '';
    for (let i = 0; i < misAmigos.length; i++) {
        let item = document.createElement('li');
        item.textContent = misAmigos[i];
        lista.appendChild(item);
    }
}

/* Tareas
    -Validar que existan registros en la lista de amigos
    -Generar un indice aleatorio para seleccionar un amigo
    -Obtener el nombre del amigo seleccionado
    -Mostrar el nombre del amigo seleccionado en una lista
*/
function sortearAmigo() {
    if (misAmigos.length === 0) {
        alert('No hay amigos para seleccionar');
    } else {
        let indice = Math.floor(Math.random() * misAmigos.length);
        let amigoSeleccionado = misAmigos[indice];
        let lista = document.getElementById('resultado');
        lista.innerHTML = '';
        let item = document.createElement('li');
        item.textContent = amigoSeleccionado;
        lista.appendChild(item);
    }
}
