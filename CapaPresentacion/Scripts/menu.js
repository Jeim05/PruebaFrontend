const boton = document.getElementById('menu-hamburguesa')
const menu = document.getElementById('menu')

boton.addEventListener('click', () => {
    boton.classList.toggle('close')
    menu.classList.toggle('show')
})

menu.addEventListener('click', e => {
    if (e.target.id === 'menu') {
        menu.classList.remove('show')
        boton.classList.remove('close')
    }
})