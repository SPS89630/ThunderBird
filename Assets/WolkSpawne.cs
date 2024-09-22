using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolkSpawne : MonoBehaviour
{
    public GameObject Wolk;
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(Wolk, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }

}
