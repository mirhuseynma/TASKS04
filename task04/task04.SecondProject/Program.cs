#region faktorial nece hesablanir
int r = 15;
long fakt = 1;
for (int i = 1; i <= r; i++)
{
    fakt *= i;
}
if (fakt == 0)
    Console.WriteLine("0 ededinin faktoriali: 1");
Console.WriteLine($"{r} ededinin faktoriali: {fakt}");
#endregion

#region Ədədlər massivindəki bütün elementləri faktorialına yüksəldin (məs: {5, 4, 6} -> {120, 24, 720 })
int[] arrays = { 5, 4, 6 };
for (int i = 0; i < arrays.Length; i++)
{
    int factorial = 1;
    if (arrays[i] == 0)
    {
        factorial = 1;
    }
    else
    {
        for (int j = 1; j <= arrays[i]; j++)
        {
            factorial *= j;
        }
    }
    Console.WriteLine($"{arrays[i]} ededinin faktoriali: {factorial}");
}
#endregion

//#region Ədədlər massivində massivdə olan ən kiçik ədədi çıxardın (məs: {7, 12, 5, 8} -> {7, 12, 8})
//int[] num = { 7, 12, 5, 8 };
//int[] newray = new int[num.Length-1];
//int minIndex = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] > minIndex)
//        minIndex = i;
//        //Console.WriteLine(minIndex);
//        for (int j = 0; j < num.Length; j++)
//        {
//            if (j == minIndex)
//                continue;
//            newray[minIndex] = num[j];
//            minIndex++;
//        }
//                for (int k = 0;k < newray.Length; k++)
//                {
//                    Console.WriteLine(newray[k]);
//                }
//}
//#endregion

#region  Verilmiş stringdə yalnız 1 dəfə işlənmiş ilk simvolu çıxışa ver. (məs: "kərtənkələ" -> 'r')
string word = "kertenkele";
for (int i = 0; i < word.Length; i++)
{
    char wordAgain = word[i];
    int aGain = 0;
    for (int j = 0; j < word.Length; j++)
    {
        if (wordAgain == word[j])
            aGain++;
    }
    if (aGain == 1)
        Console.WriteLine($"{word} stringinde '{wordAgain}' 1 defe istifade olununb");
}
#endregion

#region N və M ədədi veriləcək. o aralıqda olan polindrom ədədləri tapıb çıxışa verən proqram  məs: 121, 343, 77, 2552)
int n = 10;
int m = 80;   
Console.WriteLine($"{n} ve {m} arasinda olan polindrom ededler:  ");

for (int i = n;i <= m; i++)
{
    int esas = i;
    int tersI = 0;
    int qaliq;
    while(esas > 0)
    {
        qaliq = esas % 10;
        tersI = (tersI * 10) + qaliq;
        esas /= 10;
    }
    if(i == tersI)
    {    
        Console.WriteLine(i);
    }
}
#endregion

#region Verilmiş stringdə ən çox təkrarlanan simvolu və neçə dəfə təkrarlandığını çıxışa verən proqram
string worda = "kertenkele";
char wordagain = word[0];
int again = 0;
for (int i = 0; i < word.Length; i++)
{
    char nowChar = worda[i];
    int now = 0;
    for (int j = 0; j < word.Length; j++)
    {
        if (nowChar == word[j])
            now++;
    }
    if (now > again)
    {
        again = now;
        wordagain = nowChar;
    }
        //Console.WriteLine($"{worda} stringinde '{wordagain}' 1 defe istifade olununb");
}
Console.WriteLine($"en cox istifida edilen: {wordagain}, istifade edilib: {again} defe");
#endregion

#region Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 
string name = "Mirhuseyn";
string nameters = default;
for(int i = name.Length - 1; i >= 0; i--)
{
    nameters += name[i];
}  
Console.WriteLine(nameters);
#endregion





