const imgs = document.querySelectorAll('img')

imgs.forEach(function(item) {
    console.log(item, 'Function')
});

imgs.forEach((item) => {
 console.log(item, 'Arrow function extended')
});

imgs.forEach((item) =>console.log(item, 'Arrow function resumed'));