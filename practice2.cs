using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice2 : MonoBehaviour
{
    void Start()
    {
        //宣言
        List<int> numberList = new List<int>(); 
        List<int> nList = new List<int>() { 10, 2, 3, 7, -10 };
        List<string> nameList = new List<string>() { "おはよう", "こんにちは", "こんばんわ", "おやすみ" };

        //取得
        Debug.Log(nList[3]);
        Debug.Log(nameList[2]);
        //代入
        nList[0] = 100;
        Debug.Log(nList[0]);
        Debug.Log(numberList.Count);
        Debug.Log(nList.Count);
        Debug.Log(nameList.Count);
        for (int i = 0; i < nList.Count; i++)
        {
            Debug.Log(nList[i]);
        }

        //4を追加
        nList.Add(4);
        for (int i = 0; i < nList.Count; i++)
        {
            Debug.Log(nList[i]);
        }

        //1番目を削除
        nList.RemoveAt(1);
        for (int i = 0; i < nList.Count; i++)
        {
            Debug.Log(nList[i]);
        }

        //値3を削除
        nList.Remove(3);
        for (int i = 0; i < nList.Count; i++)
        {
            Debug.Log(nList[i]);
        }

    }
}
