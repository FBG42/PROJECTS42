# try:
#    arquivo = open('./emails.txt')
# except FileNotFoundError:
#    print('\nArquivo não encontrado\n')
# except Exception as error:
#    print(f'\nOcorreu o erro {error}\n')
# finally:
#    arquivo.close()

try:
   with open('emails.txt') as arquivo:
      print(arquivo.readlines())
except FileNotFoundError:
   print('\nO arquivo não existe\n')