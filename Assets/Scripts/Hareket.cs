using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    [SerializeField]
    private float ileriGitmeHizi;
    [SerializeField]
    private float sagaSolaGitmeHizi;
    void Start()
    {
        
    }

    void Update()
    {
        float yatayeksen = Input.GetAxis("Horizontal") * sagaSolaGitmeHizi * Time.deltaTime;
        this.transform.Translate(yatayeksen, 0, ileriGitmeHizi * Time.deltaTime);
    }
}
