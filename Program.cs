using System.Collections;


IEnumerable exampleArray = new int[]{850, 2, 3};

IEnumerator enumerator = exampleArray.GetEnumerator();

while(enumerator.MoveNext()){

Console.WriteLine(enumerator.MoveNext());
Console.WriteLine(enumerator.Current);
}

enumerator.Reset(); //Use of this function??

//The foreach loop is the exact same as the above

foreach(var Current in exampleArray)
{
    Console.WriteLine(Current);
}