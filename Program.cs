#region Task 1
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Dataflow;

string CheckEmail(string email) {

    if (email.Contains("@") && email.EndsWith(".com")){
        return email;

    }
    return string.Empty;
}
Console.WriteLine(CheckEmail("hero@gmail.com"));
Console.WriteLine("---------------------------------------------------");
#endregion
#region Task 2
string ReplaceWord(string sentence,string word,string newWord)
{
    return sentence.Replace(word, newWord);

}
Console.WriteLine(ReplaceWord("hero Sabah Akademyaya gedecek","Akademya","Code-Akademya"));
Console.WriteLine("---------------------------------------------------");

#endregion
#region Task 3
string UserName(string name,string surname)
{
    if(name.Length>=3 && surname.Length >= 3)
    {
        return name.Substring(0,3)+ surname.Substring(0,3);
    }
   else {   return string.Empty;}
}
Console.WriteLine(UserName("Melahir","Hasanov"));
Console.WriteLine("---------------------------------------------------");
#endregion
#region Task 4
int[] Printelement (int[] a)
{   
    Array.Sort(a);
    int [] b = new int[a.Length];
    int count = 1;
    b[0] = a[0];
    
    for (int i = a.Length-1; i >=1; i--)
    {
        if (a[i] != a[i-1])
        {
            b[count] = a[i];
            count++;
            
        }
       
            

        }
    Array.Resize(ref b, count);
    return b;

}
int[] result = Printelement([2, 2, 33,33, 4, 5]);
Console.WriteLine(string.Join(",", result));

#endregion
#region Task 5
int[] ResetMassiv(int[] a)
{
    int[] b=new int[a.Length];
    for(int i = 0; i < a.Length; i++)
    {
        if (a[i] < 0)
        {
            continue;
        }
        b[i] = a[i];

    }
    return b;



}
int[] result1 = ResetMassiv([2, 2, 33, 33, 4, 5,-2,-23]);
Console.WriteLine(string.Join(",", result1));
#endregion
#region Task 6
string CheckText(string text)
{
    text = text.ToLower();
    char[] arr = text.ToCharArray();
    Array.Reverse(arr);
    string reversed = new string(arr);
    return text = reversed;
}


#endregion
