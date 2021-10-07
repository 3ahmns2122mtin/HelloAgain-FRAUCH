using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("HelloWorld");
        Debug.Log("HelloWorld");
        PrintMyMsg("FRAUCH");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PrintMyMsg(string name)
    {
        Debug.Log("erste Methode" + name);
    }
}
