using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice4 : MonoBehaviour
{
    void Start()
    {
        string Name = GetName("tarou", 3);
        Debug.Log(Name);
    }

    //何も返さないならvoid/ string型を返すので string 関数名()
    string GetName(string userName, int age)
    {
        return "tanaka" + userName + age + "才";
    }
}