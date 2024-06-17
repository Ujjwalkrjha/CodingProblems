using System.Collections;

string[] sArray = { "a", "a", "b", "b", "c" };
var sList = new ArrayList();

for (int i = 0; i < sArray.Length; i++)
{
    if (sList.Contains(sArray[i])==false)
    {
        sList.Add(sArray[i]);
    }
}

for (int i=0; i < sList.Count; i++)
{
    Console.WriteLine(sList[i]);
}