function WideOnly() {
    const screenWidth = window.innerWidth;
    const screenHeight = window.innerHeight;

    const wideOnlyElements = document.querySelectorAll('[tag="WideOnly"]');

    wideOnlyElements.forEach(element => {
        if (screenHeight > screenWidth) {
            element.style.display = 'none';
        } else {
            element.style.display = '';
        }
    });
}
WideOnly();

window.addEventListener('resize', WideOnly);