using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cubeMov : MonoBehaviour
{
    public GameObject g1;
    public GameObject g2;

    // Start is called before the first frame update
    void Start()
    {
        var p2 = g2.transform.position;

        g1.transform.DOMove(p2, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
