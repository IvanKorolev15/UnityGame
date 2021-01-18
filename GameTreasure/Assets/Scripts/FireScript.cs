using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    private bool fire = false;
    [SerializeField] private GameObject bullet = null;
    [SerializeField] private Transform bulletStartPosition = null;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {            
            fire = true;
        }
    }

    private void FixedUpdate()
    {
        if (fire)
        {
            Fire();
        }
    }
    private void Fire()
    {
        fire = false;
        var bul = Instantiate(bullet,bulletStartPosition.position, Quaternion.identity);
    }
}
