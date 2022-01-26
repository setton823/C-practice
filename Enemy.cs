using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// publicがついていると、他のクラスから取得や実行ができる

public class Enemy : MonoBehaviour
{
    public int hp;

    int at;

    public void Attack()
    {
        Debug.Log("Enemyの攻撃");
    }

    public void Heal()
    {
        Debug.Log("Enemyの回復");
    }
}
