try:
   with open('nomes.txt', 'a') as arquivo:
      arquivo.write("\nGuilherme Junqueira")
except Exception as error:
   print('\nAlgum erro ocorreu\n')
   print(f'\n{error}\n')


'''
'r' - abre para ler
'w' - abre para escrever / arquivo é sobrescrito
'a' - abre para escrever / novo conteudo é adicionado ao final do arquivo
'+' - adicionar 
'b'
'''