using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplanabilir : MonoBehaviour
{
    bool toplandiMi;
    int index;
    public Toplayici toplayici;
    void Start()
    {
        toplandiMi = false;
    }


    void Update()
    {
        if (transform.parent != null)
        {
            if (toplandiMi == true)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
       
    }
    public bool GettoplandiMi()
    {
        return toplandiMi;
    }
    public void ToplandiYap()
    {
        toplandiMi = true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Engel"))
        {
            toplayici.yukseklikazalt();
            transform.parent = null;
            transform.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.transform.GetComponent<BoxCollider>().enabled = false;

        }
    }
}
