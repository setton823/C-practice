using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice3 : MonoBehaviour
{
    void Start()
    {
        //  関数の使い方
        //  関数名();
        Call();
        Call1("Mike!");
        Call1("Jake!");
    }

    // 関数の作成 void 関数名()
    void Call()
    {
        Debug.Log("Hi, Mike!"); //関数の処理
    }

    // 引数あり関数の作成 void 関数名(引数)
    void Call1(string userName)
    {
        Debug.Log("Hi," + userName); //関数の処理
    }
}
