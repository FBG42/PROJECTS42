#!/bin/bash
echo "Digite uma inferface de rede"
read interface
echo "Mostrando informações da interface de rede $interface"
ifconfig $interface
