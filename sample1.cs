using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// sample1クラスでEnemyの関数を実行する
public class sample1 : MonoBehaviour
{
    public Enemy enemy;  // enemyの窓口

    int hp;

    void Attack()
    {
        Debug.Log("攻撃");
    }

    void Heal()
    {
        Debug.Log("回復");
    }

    void Start()
    {
        enemy.Attack();
        enemy.Heal();
    }

}
