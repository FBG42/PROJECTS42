// Navegação em Tab nas fotos dos animais
export default function initTabNav() {
    const tabMenu = document.querySelectorAll("[data-js='tabmenu'] li");
    const tabContent = document.querySelectorAll('[data-js="tabcontent"] section');
  
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
  
  