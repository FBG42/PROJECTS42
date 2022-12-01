AGENDA = {}


AGENDA['fabricio'] = {
   'telefone': '51 999994242',
   'email': 'fabricio@solyd.com',
   'endereco': 'Av. 42',
}

AGENDA['jose'] = {
   'telefone': '51 999994343',
   'email': 'jose@solyd.com',
   'endereco': 'Av. 43',
}


def mostrar_contatos():
   for contato in AGENDA: 
      buscar_contato(contato)

def buscar_contato(contato):
   print(f"Nome: {contato}")
   print(f"Telefone: {AGENDA[contato]['telefone']}")
   print(f"Email: {AGENDA[contato]['email']}")
   print(f"Endereço: {AGENDA[contato]['endereco']}")
   print('-------------------------------------------')


def incluir_editar_contato(contato, telefone, email, endereco):
   AGENDA[contato] = {
      'telefone': telefone,
      'email': email,
      'endereco': endereco,
   }
   print()
   print(f">>>> Contato {contato} foi adicionado/editado com sucesso")
   print()


def excluir_contato(contato):
   AGENDA.pop(contato)
   print()
   print(f">>>> Contato {contato} excluido com sucesso")
   print()


def imprimir_menu():
   print('-------------------------------------------')
   print(" 1 - Mostrar todos os contatos da agenda")
   print(" 2 - Buscar contato")
   print(" 3 - Incluir contato")
   print(" 4 - Editar contato")
   print(" 5 - Excluir contato")
   print(" 0 - Fechar agenda")
   print('-------------------------------------------')

while True:
   imprimir_menu()

   opcao = input("Escolha uma opção: ")
   if opcao == "1":
      mostrar_contatos()
   elif opcao == "2":
      contato = input("Digite o nome do contato")
      buscar_contato(contato)
   elif opcao == "3" or opcao == "4":
      contato = input("Digite o nome do contato: ")
      telefone = input("Digite o telefone do contato: ")
      email = input("Digite o email do contato: ")
      endereco = input("Digite o nome do endereço: ")
      incluir_editar_contato(contato, telefone, email, endereco)
   elif opcao == "5":
      contato = input("Digite o contato que deseja excluir: ")
      excluir_contato(contato)
   elif opcao == "0":
      print(">>>>> Fechando programa.")
      break
   else:
      print(">>>>> Opção inválida.")

imprimir_menu()
