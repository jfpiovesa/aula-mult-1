using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletMannager : MonoBehaviour
{
    public float bulletSpeed = 1000f;
    Rigidbody bulletRb;

    public float bulletTimeLife = 1.5f;
    float bulleTimeCount = 0f;



    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody>();
        bulletRb.AddForce(transform.forward * bulletSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(bulleTimeCount >= bulletTimeLife)
        {
            Destroy(this.gameObject);
        }
        bulleTimeCount += Time.deltaTime;

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Player1>().HealthManager(-10f);
         
        }
    }


}
