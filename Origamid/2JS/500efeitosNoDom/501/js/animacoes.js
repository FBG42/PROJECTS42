// Navegação em Tab nas fotos dos animais
function initTabNav() {
  const tabMenu = document.querySelectorAll("[data-js='tabmenu'] li");
  const tabContent = document.querySelectorAll('[data-js="tabcontent"] section');

  console.log(tabMenu)

  if (tabMenu.length && tabContent.length) {
    tabContent[0].classList.add("ativo");

    function activeTab(index) {
      tabContent.forEach((section) => {
        section.classList.remove("ativo", tabContent[index].dataset.anime);
      });
      console.log();
      tabContent[index].classList.add("ativo", tabContent[index].dataset.anime);
    }

    tabMenu.forEach((itemMenu, index) => {
      itemMenu.addEventListener("click", () => {
        activeTab(index);
      });
    });
  }
}
initTabNav();

// Navegação em Accordion nas perguntas e respostas
function initAccordion() {
  const accordionList = document.querySelectorAll('[data-js="accordion"] dt');
  const activeClass = "ativo";

  if (accordionList.length) {
    accordionList[0].classList.add(activeClass);
    accordionList[0].nextElementSibling.classList.add(activeClass);

    accordionList.forEach((item) => {
      item.addEventListener("click", activeAccordion);
    });

    function activeAccordion() {
      this.classList.toggle(activeClass);
      this.nextElementSibling.classList.toggle(activeClass);
    }
  }
}
initAccordion();

// Scroll suave
function initScrollSuave() {
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
initScrollSuave();

// Anima as sections durante o scroll da página
function initAnimacaoScroll() {
  const sections = document.querySelectorAll('[data-js="scroll"]');

  if (sections.length) {
    const windowMetade = window.innerHeight * 0.6;

    window.addEventListener("scroll", animaScroll);

    function animaScroll() {
      sections.forEach((section) => {
        const sectionTop = section.getBoundingClientRect().top;
        const isSectionVisible = sectionTop - windowMetade < 0;

        if (isSectionVisible) {
          section.classList.add("ativo");
        }
      });
    }

    animaScroll();
  }
}
initAnimacaoScroll();
