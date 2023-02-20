#!/bin/bash

echo "Digite r para Routes ou i para Interfaces de Rede:"
read entrada

if [ "$entrada" == "r" ]
then
route -n
elif [ "$entrada" == "i" ]
then
echo "Digite uma uma interface de rede:"
read interface
echo "Mostrando informações da interface de redee $interface"
ifconfig $interface
else
echo "Opção invalida"
fi

