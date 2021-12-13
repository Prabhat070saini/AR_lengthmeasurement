using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputstring : MonoBehaviour
{
    // Start is called before the first frame update
   private string input;
   public void ReadStringInput(string s)
       {
           input =s;
           Debug.Log(input);
       }
   
}
