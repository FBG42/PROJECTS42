# Erros em tempo de compilação
# Erros em tempo de execução
# Erros de lógica


## Compilação
# prin("hello world")

# if True
#    print("Olá mundo")

## Execução
# def divisao(a, b):
#    try:
#       print(a / b)
#    # print(a * b)
#    except Exception as e:
#       print("Divisão inválida")
#       print(e)

# divisao(20, 0)


try:
   a = float(input("Digite o número A: "))
   b = float(input("Digite o número B: "))
   print(a/b)
except ValueError as error:
   print("Input inválido, digite apenas números")
except ZeroDivisionError as error:
   print("Não pode ser feita divisão por zero")
except Exception as error:
   print("Algum erro ocorreu")
   print(error)
finally:
   print("Fim do programa")
