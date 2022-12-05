AGENDA = {}


# AGENDA['fabricio'] = {
#    'telefone': '51 999994242',
#    'email': 'fabricio@solyd.com',
#    'endereco': 'Av. 42',
# }

# AGENDA['jose'] = {
#    'telefone': '51 999994343',
#    'email': 'jose@solyd.com',
#    'endereco': 'Av. 43',
# }


def mostrar_contatos():
   if AGENDA:
      for contato in AGENDA: 
         buscar_contato(contato)
   else: 
      print("\n>>>> Agenda vazia\n")

def buscar_contato(contato):
   try:
      print('-------------------------------------------')
      print(f"Nome: {contato}")
      print(f"Telefone: {AGENDA[contato]['telefone']}")
      print(f"Email: {AGENDA[contato]['email']}")
      print(f"Endereço: {AGENDA[contato]['endereco']}")
      print('-------------------------------------------')
   except KeyError:
      print("\nContato inexistente\n")
   except Exception as error:
      print("\n>>>> Um Erro inesperado ocorreu\n")
      print(error)

def incluir_editar_contato(contato):
   telefone = input("Digite o telefone do contato: ")
   email = input("Digite o email do contato: ")
   endereco = input("Digite o nome do endereço: ")
   
   AGENDA[contato] = {
      'telefone': telefone,
      'email': email,
      'endereco': endereco,
   }
   print(f"\n>>>> Contato {contato} foi adicionado/editado com sucesso\n")


def excluir_contato(contato):
   try:
      AGENDA.pop(contato)
      print(f"\n>>>> Contato {contato} excluido com sucesso\n")
   except KeyError:
      print("\nContato inexistente\n")
   except Exception as error:
      print("\n>>>> Um Erro inesperado ocorreu\n")
      print(error)

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
      contato = input("Digite o nome do contato: ")
      buscar_contato(contato)

   elif opcao == "3":
      contato = input("Digite o nome do contato: ")

      try:
         AGENDA[contato]
         print()
         print(">>>> Contato já existente")
         print()
      except KeyError:
         incluir_editar_contato(contato)

   elif opcao == "4":
      contato = input("Digite o nome do contato: ")

      try:
         AGENDA[contato]
         print(f"\n>>>> Editando contato: {contato}\n")
         incluir_editar_contato(contato)
      except KeyError:
         print("\n>>>> Contato inexistente\n")

   elif opcao == "5":
      contato = input("Digite o contato que deseja excluir: ")
      excluir_contato(contato)

   elif opcao == "0":
      print("\n>>>>> Fechando programa.\n")
      break

   else:
      print("\n>>>>> Opção inválida.\n")

imprimir_menu()
