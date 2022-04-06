using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBallController : MonoBehaviour
{
    [SerializeField] float ballPoints = 1f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
