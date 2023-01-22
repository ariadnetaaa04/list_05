using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    private int counter;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddOneToCounter();
            GameOver();
        }
       
    }
    private void AddOneToCounter()
    {
        counter++;
        Debug.Log($"{counter}");
    }
    private bool GameOver()
    {
        if (counter == 10)
        {
            Debug.Log("GAME OVER");
            return true;
        }
        return false;
    }
    

}
