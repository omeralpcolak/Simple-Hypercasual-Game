using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class Knife : MonoBehaviour
{
    public GameObject knifeHandPosition;
    private float speed = 50f;
    
    //public bool knifePickedUp = true;



    


    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            /*knifePickedUp = true;
            transform.position = knifeHandPosition.transform.position;
            //this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 20f * speed);*/
            transform.DOMove(knifeHandPosition.transform.position,0f).OnComplete(delegate
            {
                this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30f * speed);
                //Destroy(gameObject,1f);
            });

        }
    }


    /*private void Update()
    {
        if (knifePickedUp == true)
        {
            //this.transform.position = knifeHandPosition.transform.position * Time.deltaTime;
            this.transform.localPosition = Vector3.Lerp(this.transform.localPosition, knifeHandPosition.transform.position,Time.deltaTime * 8f);
            
        }

        
    }

    //this.GetComponent<Rigidbody>().AddForce(Vector3.forward* 20f * speed);

    /*private void KnifeThrow()
    {
        if (knifePickedUp==false)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 20f * speed);
        }
    }*/
}
