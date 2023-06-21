﻿// (Проверка на анаграммы равные по длине, игнорируя пробелы)
 
string s1 = "Tom Marvolo Riddle";
string s2 = "I am Lord Voldemort";

Console.WriteLine("Проверка строк на анаграммы.");
Console.WriteLine("Проверим строки: '" + s1 + "' и '" + s2 + "'");

Console.WriteLine(IsAnagrams(s1, s2)? "Строки - анаграммы!" : "Строки не анаграммы.");


bool IsAnagrams(string inString1, string inString2){
    char[] chars1 = (inString1).Replace(" ","").ToLower().ToCharArray();
    char[] chars2 = (inString2).Replace(" ","").ToLower().ToCharArray();
    Array.Sort(chars1); string compareS1 = new String(chars1);
    Array.Sort(chars2); string compareS2 = new String(chars2);
    return Equals(compareS1, compareS2);
}
