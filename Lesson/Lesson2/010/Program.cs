﻿



//задача показывает номер индекса, если пользователь вводит число
int [] array = {1, 12, 31, 4, 18, 15, 16, 17, 18, };

int n = array.Length; //возвращает длину(кол-во эл-ов массива)
int find = 18; //польз-ль вводит число 18

int index = 0; //устанавл счетчик index в позицию 0

while (index < n) 
{
    if (array[index] ==find) //если array[index] совпал с find, алгоритм завершает работу
{
    Console.WriteLine(index);
    break; //если выполняется условие выше,то закончит его,т.е. если два одинак числа,то покажет только первое
}

    //index = index +1 
    index ++; //на каждом этапе надо увеличивать зн-е индекса
}