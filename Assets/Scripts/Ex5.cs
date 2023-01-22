using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public int[] elements;
    // Start is called before the first frame update
    private void Start()
    { //if there is less than 5 arrays, there will be some missing
        if (elements.Length < 5)
        {
            Debug.Log("Missing elements");
        }
        else
        {
            //I've put the name of my Array with the index value I want to know.
            Debug.Log($"First element={elements[0]}");
            Debug.Log($"Third element={elements[2]}");
            Debug.Log($"Fifth element={elements[4]}"); 
            
        }
      
    }
}
