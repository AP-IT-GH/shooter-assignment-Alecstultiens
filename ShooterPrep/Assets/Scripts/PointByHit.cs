using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointByHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            ScoreManager.instance.AddPoint();
        }
    }
}
