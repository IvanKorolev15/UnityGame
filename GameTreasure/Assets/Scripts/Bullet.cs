using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private void Awake()
    {
        Destroy(gameObject,5);
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);
    }
}
