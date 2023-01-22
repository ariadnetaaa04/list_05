using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    public float num1;
    public float num2;
    public float num3;
    // Start is called before the first frame update
    void Start()
    {//It calls de function
        ArithmeticMean(num1, num2, num3);
    }

    private float ArithmeticMean(float one, float two, float three)
    {
        //This will display the result on the console.
        Debug.Log($"The arithmetic mean of {one}, {two} and {three} is {(one+two+three)/3}");

        return (one + two + three) / 3;
    }
}
