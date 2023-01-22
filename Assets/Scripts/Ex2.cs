using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public string username;
    public string password;
    // Start is called before the first frame update
    void Start()
    {
        Login(username, password);
    }
    private bool Login(string username, string password)
    {
        if (username == "admin" && password == "abccba")
        {
            Debug.Log($"Login Successful");
            return true;
        }
        Debug.Log($"Wrong password/username, please try it again.");
        return false;
    }
}
