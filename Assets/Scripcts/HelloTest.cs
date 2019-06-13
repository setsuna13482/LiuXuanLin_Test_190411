using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloTest : MonoBehaviour
{
    public int myInt;
    private string myStr;
    public Vector3 myVec;
    private int[] myArray = new int[100];


    void Start()
    {
        myStr = "Hello Unity";
        for (int i = 0; i <100; i++)
        {
            myArray[i] = i + 1;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(Sum1to100());
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(myVec,0.5f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(myVec, transform.position);
    }

    private int Sum1to100()
    {
        int result = 0;
        for (int i = 0; i < 100; i++)
        {
            result += myArray[i];
        }
        return result;
    }
}
