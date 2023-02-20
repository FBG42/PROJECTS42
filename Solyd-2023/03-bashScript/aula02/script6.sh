#!/bin/bash

echo "Qual sua nota da prova?"
read nota

if [ "$nota" -gt 70 ]
then
echo "Aprovado"
else
echo "Reprovado"
fi
