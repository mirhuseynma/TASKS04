#region Verilmiş Arrayın elementlərinin cəmini ekrana çap edin
int[] num = [10, 20, 30, 40, 50];
int total = 0;
for (int i = 0; i<num.Length; i++)
{
    total += num[i];

}
Console.WriteLine(total);
#endregion

#region Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın
int[] art = [10, 20, 30, 40, 50, 9, 23, 52, 99];
int maxvalue = art[0];
//int minvalue = art[1];
for (int i = 0; i < art.Length; i++)
{
    if (maxvalue < art[i])
    {
        maxvalue = art[i];
    }
    //if (minvalue > art[i])
    //{
    //    minvalue = art[i];
    //}
}
Console.WriteLine(maxvalue);
//Console.WriteLine(minvalue);
#endregion

//#region Verilmiş Arrayın ilk və son elementlərinin cəmini tapın
//int[] need = [29, 32, 455, 232, 1223,232,323,1];
//int sum = need[0] + need[need.Length-1];
//Console.WriteLine(sum);
//#endregion

//#region Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın
//int numa = 5;
//bool isPower = true;
//while (numa>1)
//{
//    if (numa % 2 != 0)
//        isPower = false;
//        break;
//    numa /= 2;
//}
//if (numa ==  1)
//    Console.WriteLine($"{numa} ededi 2 nin quvvetidir");
//else if(!isPower)
//    Console.WriteLine($"{numa} ededi 2 nin quvveti deyil");
//else
//    Console.WriteLine($"{numa} ededi 2 nin quvvetidir");
//#endregion

//#region Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
//int n = 1;
//int count = 0;
//int nclone = n;
//while (n > 0)
//{
//    n /= 10;
//    count ++;
//}
//Console.WriteLine($"verilmis {nclone} ededi {count} mertebeden ibaretdir");
//#endregion

//#region Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm
////(meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)
//int[] m = [10, 20, 30, 40, 50,60];
//int a = 60;
//int counta = 0;
//bool enter = false;
//for(int i = 0; i < m.Length; i++)
//{
//    if (a == m[i])
//    {
//        enter = true;
//        counta += i;
//    }       
//}
//if (enter)
//    Console.WriteLine($"{a} ededi {counta} indeksinde yerlesir");
//else if (!enter)
//    Console.WriteLine($"{a} ededi siyahida yoxdur");
//#endregion

//#region Tam ədədlər ardıcıllığı verilir. Ardıcıllığın hər bir mənfi olmayan elementini 2 vahid artırmalı.
//int[] increase = [-10, 20, -30, 40, -50, 60];
//for(int i = 0; i < increase.Length; i++)
//{
//    if (increase[i] > 0) { 
//        increase[i] += 2;
//    }
//    Console.WriteLine(increase[i]);
//}
//#endregion

//#region Verilmiş array-da müəyyən bir elementin neçə dəfə təkrarlandığını tapın.
////Məsələn: [1, 2, 3, 2, 4, 2], axtarış: 2 → Çıxış: 3
//int[] list = [29, 32, 455, 232, 1223, 232, 323, 1,232];
//int c = 232;
//int again = 0;
//for(int i = 0; i < list.Length; i++)
//{
//    if (c == list[i]) 
//        again++;
//}
//Console.WriteLine($"{c} ededi listde {again} defe istifade olunub");
//#endregion

//#region Verilmiş array-ı tərsinə çap edin.
////Məsələn: [1, 2, 3, 4] → Çıxış: 4 3 2 1
//int[] numay = [10, 20, 30, 40, 50, 60];
//for(int i = numay.Length -1; i >=0; i--)
//{
//    Console.WriteLine(numay[i]);
//}
//#endregion

//#region Verilmiş massivin ən kiçik elementini çıxışa verən proqram yazın
//int[] ary = [-10, 20, -30, 40, -50, 60];
//int aryclone = ary[0];
//for(int i = 0; i<ary.Length; i++)
//{
//    if (ary[i] < aryclone)
//        aryclone = ary[i];

//}
//Console.WriteLine($"Listdeki en kicik {aryclone} ededidir.");
//#endregion
