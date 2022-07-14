// Scroll suave
export default function initScrollSuave() {
    const linksInternos = document.querySelectorAll('[data-js="menu"] a[href^="#"]');
  
    linksInternos.forEach((link) => {
      link.addEventListener("click", scrollToSection);
    });
  
    function scrollToSection(event) {
      event.preventDefault();
      const href = event.currentTarget.getAttribute("href");
      const section = document.querySelector(href);
  
      section.scrollIntoView({
        behavior: "smooth",
        block: "start",
      });
  
      //  form alternativa
      //   const top = section.offsetTop;
      //   window.scrollTo({
      //       top: top,
      //       behavior: 'smooth',
      //   })
    }
  }

  