using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Esqueleto;

    void Update()
    {
        if (Esqueleto != null)
        {
            Vector3 position = transform.position;
            position.x = Esqueleto.position.x;
            transform.position = position;
        }
    }
}