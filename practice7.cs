using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice7 : MonoBehaviour
{
    int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    int[] numbers2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    void Start()
    {
        ShowArrayValueLog(numbers1);

        ShowArrayValueLog(numbers2);    
    }


    void ShowArrayValueLog(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
        
    }
}
