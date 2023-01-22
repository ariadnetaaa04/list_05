using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    public int[] elements;
    // Start is called before the first frame update
    void Start()
    { 
        //I've put the name of my Array with the index value I want to know.
        Debug.Log($"First element={elements[0]}");
        Debug.Log($"Third element={elements[2]}");
        Debug.Log($"Fifth element={elements[4]}");
    }
}
