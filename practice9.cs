using UnityEngine;
using System.Collections;

public class practice9 : MonoBehaviour
{
    int[] numbers = { 1, 1, 2, 2 };

    void Start()
    {
        Debug.Log(Mean(numbers));
    }

    float Mean(int[] numbers)
    {
        float sum = 0;
        int count = numbers.Length;
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / count;     // 合計/個数 
    }
}
