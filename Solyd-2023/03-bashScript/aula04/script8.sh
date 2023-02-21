#!/bin/bash
#a=1

#while sleep 1
#do
#	date
#done

#for ((i=0;i<=10;i++))
#do
#	sleep 1
#	date
#done

#for i in {1..10}
#do
#	sleep 1
#	echo $i
#done


for i in $(cat ip.txt)
do
	echo $i
done

