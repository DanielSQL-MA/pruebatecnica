const opcionventasxarticulos = document.getElementById('opcionventasxarticulos')
const opcionventasglobales = document.getElementById('opcionventasglobales')
const opcionarticulotop = document.getElementById('opcionarticulotop')
const opcionstock = document.getElementById('opcionstock')
const opcionnotificaciones = document.getElementById('opcionnotificaciones')

const contentventasxarticulos = document.getElementById('contentventasxarticulos')
const contentventasglobales = document.getElementById('contentventasglobales')
const contentarticulotop = document.getElementById('contentarticulotop')
const contentstock = document.getElementById('contentstock')
const contentnotificaciones = document.getElementById('contentnotificaciones')

let chose = 1

const changeOption = () => {
    chose == 1 ? (
        opcionventasxarticulos.classList.value = 'opcion option-active',
        contentventasxarticulos.classList.value = 'content content-active'
    )
        : (
            opcionventasxarticulos.classList.value = 'opcion',
            contentventasxarticulos.classList.value = 'content'
        )

    chose == 2 ? (
        opcionventasglobales.classList.value = 'opcion option-active',
        contentventasglobales.classList.value = 'content content-active'
    )
        : (
            opcionventasglobales.classList.value = 'opcion',
            contentventasglobales.classList.value = 'content'
        )
    chose == 3 ? (
        opcionarticulotop.classList.value = 'opcion option-active',
        contentarticulotop.classList.value = 'content content-active'
    )
        : (
            opcionarticulotop.classList.value = 'opcion',
            contentarticulotop.classList.value = 'content'
        )
    chose == 4 ? (
        opcionstock.classList.value = 'opcion option-active',
        contentstock.classList.value = 'content content-active'
    )
        : (
            opcionstock.classList.value = 'opcion',
            contentstock.classList.value = 'content'
        )

    chose == 5 ? (
        opcionnotificaciones.classList.value = 'opcion option-active',
        contentnotificaciones.classList.value = 'content content-active'
    )
        : (
            opcionnotificaciones.classList.value = 'opcion',
            contentnotificaciones.classList.value = 'content'
        )
}
opcionventasxarticulos.addEventListener('click', () => {
    chose = 1
    changeOption()
})

opcionventasglobales.addEventListener('click', () => {
    chose = 2
    changeOption()
})

opcionarticulotop.addEventListener('click', () => {
    chose = 3
    changeOption()
})

opcionstock.addEventListener('click', () => {
    chose = 4
    changeOption()
})

opcionnotificaciones.addEventListener('click', () => {
    chose = 5
    changeOption()
})