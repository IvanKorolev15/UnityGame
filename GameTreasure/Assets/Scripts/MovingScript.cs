using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction;
    public int hp = 100;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        direction.y = Input.GetAxis("Jump");
    }

    private void FixedUpdate()
    {
        var _speed = direction * speed * Time.deltaTime;
        transform.Translate(_speed);
        
        direction = Vector3.zero;
    }
}
