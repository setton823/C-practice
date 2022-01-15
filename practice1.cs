using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice1 : MonoBehaviour
{
    //　宣言方法
    int[] a = { 10, 2, -2, -10 };
    int[] b = new int[] { 10, 2, -2, -10 };
    int[] c = new int[] { 10, 2, -2, -10 };

    void Start()
    {
        //取得
        int x = a[1];
        Debug.Log(x);   //Debug.Log(a[1]);でも可
        //変更
        a[1] = 7;
        Debug.Log(a[1]);
        //長さ
        Debug.Log(a.Length);

        //他のデータ型でも使える
        string[] names = { "西川", "ダニエル", "ラドクリフ",　"哲郎", "と申します。" };
        //for文との組み合わせ
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }
    }

    
}
