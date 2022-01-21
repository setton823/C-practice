using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice6 : MonoBehaviour
{
    void Start()
    {
        int sum = 0;

        sum += Damage("西川", 100);

        sum += Damage("西川", 50);

        Debug.Log("合計のダメージは" + sum + "です。");
    }


    int Damage(string target, int damage)
    {
        Debug.Log(target + "は" + damage + "を受けました。");
        return damage;
    }
}
