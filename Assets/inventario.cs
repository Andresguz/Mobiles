using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{
    public GameObject ammo;
    public GameObject inven;
    void Start()
    {
        
    }

    public void ver()
    {
        ammo.SetActive(true);
        inven.SetActive(true);
    }
}
