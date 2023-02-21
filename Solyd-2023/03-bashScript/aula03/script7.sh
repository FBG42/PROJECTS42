#!/bin/bash

if [ "$1" == "r" ]
then
route -n
elif [ "$1" == "i" ]
then
echo "Digite uma uma interface de rede:"
echo "Mostrando informações da interface de redee $interface"
ifconfig $2
else
echo "Usage: ./script7.sh r|i wlp6s0"
fi

