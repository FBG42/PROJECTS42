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


def ler_detalhes_contato():
   telefone = input("Digite o telefone do contato: ")
   email = input("Digite o email do contato: ")
   endereco = input("Digite o nome do endereço: ")
   return telefone, email, endereco


def incluir_editar_contato(contato, telefone, email, endereco):
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


def exportar_contatos():
   try:
      with open('agenda.csv', 'w') as file:
         file.write('nome, telefone, email, endereço\n')
         for contato in AGENDA:
            telefone = AGENDA[contato]['telefone']
            email = AGENDA[contato]['email']
            endereco = AGENDA[contato]['endereco']
            file.write(f'{contato}, {telefone}, {email}, {endereco}\n')
      print('\n>>>> Agenda exportada com sucesso\n')
   except Exception as error:
      print(f"\n>>>> Algum erro ocorreu ao exportar contatos\n")
      print(error)


def importar_contatos(file_name):
   try:
      with open(file_name, 'r') as file:
         linhas = file.readlines()
         for linha in linhas:
            detalhes = linha.strip().split(',')
            nome = detalhes[0]
            telefone = detalhes[1]
            email = detalhes[2]
            endereco = detalhes[3]

            incluir_editar_contato(nome, telefone, email, endereco)
   except FileNotFoundError:
      print('\n>>>> Arquivo não encontrado\n')
   except Exception as error:
      print('>>>> Algum erro inesperado ocorreu')
      print(error)


def imprimir_menu():
   print('-------------------------------------------')
   print(" 1 - Mostrar todos os contatos da agenda")
   print(" 2 - Buscar contato")
   print(" 3 - Incluir contato")
   print(" 4 - Editar contato")
   print(" 5 - Excluir contato")
   print(" 6 - Exportar contatos para CSV")
   print(" 7 - Importar contatos em CSV")
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
         telefone, email, endereco = ler_detalhes_contato()
         incluir_editar_contato(contato, telefone, email, endereco)

   elif opcao == "4":
      contato = input("Digite o nome do contato: ")

      try:
         AGENDA[contato]
         print(f"\n>>>> Editando contato: {contato}\n")
         telefone, email, endereco = ler_detalhes_contato()
         incluir_editar_contato(contato, telefone, email, endereco)
      except KeyError:
         print("\n>>>> Contato inexistente\n")

   elif opcao == "5":
      contato = input("Digite o contato que deseja excluir: ")
      excluir_contato(contato)

   elif opcao == "6":
      exportar_contatos()

   elif opcao == "7":
      file_name = input('Digite o nome do arquivo a ser importado: ')
      importar_contatos(file_name)

   elif opcao == "0":
      print("\n>>>>> Fechando programa.\n")
      break

   else:
      print("\n>>>>> Opção inválida.\n")

imprimir_menu()
