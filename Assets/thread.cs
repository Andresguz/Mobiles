using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class thread : MonoBehaviour
{
    Thread thread1;
    SpriteRenderer sp;
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        thread1 = new Thread(() => ThreadMethod(1));
        thread1.Start();
    }

   void ThreadMethod(int n1)
    {
       //while (true)
        {
            n1++;
            //sp.color = Color.red;
            //sp.color = Color.blue;
            Debug.Log("f "+n1);
        }
    }
}
