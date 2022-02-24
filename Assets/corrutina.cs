using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corrutina : MonoBehaviour
{
    SpriteRenderer sp;
    //[SerializeField]

        
        void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        StartCoroutine(camColor(1f));
       
    }

    void Update()
    {
        
    }
    IEnumerator camColor(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        sp.color = Color.red;
        yield return new WaitForSeconds(tiempo);
        sp.color = Color.blue;
        yield return new WaitForSeconds(tiempo);
        sp.color = Color.yellow;
        yield return new WaitForSeconds(tiempo);
        sp.color = Color.white;
        yield return new WaitForSeconds(tiempo);
        sp.color = Color.magenta;
    }
}
