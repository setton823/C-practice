using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice8 : MonoBehaviour
{
    int[] numbers1 = { 2, 4, 6 };

    int[] numbers2 = { 1, 2, 3 };

    void Start()
    {
        Debug.Log(Mean(numbers1));

        Debug.Log(Mean(numbers2));

    }

    
    int Mean(int[] numbers)
    {
        int sum = 0;

        int count = numbers.Length;

        for (int i = 0; i < count; i++)
        {
            sum += numbers[i];
        }

        return sum / count; //合計/個数
    }
}
