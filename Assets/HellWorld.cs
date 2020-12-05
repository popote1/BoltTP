using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;

   
public class HellWorld : MonoBehaviour
{
   
   public void DoAction(string Message)
   {
      Debug.Log("HelloWorld");
     Debug.Log(Message);
   }

   public string OutText ()
   {
       return "test";
   }

   public void OutMultipleText(out string text, out string text2 , out float Unnombre )
   {
       text = "bla1";
       text2 = "bla2";
       Unnombre = 3;
   }
}
