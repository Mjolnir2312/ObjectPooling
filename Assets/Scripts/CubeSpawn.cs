using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    ObjectPooling objectPooling;

    private void Start()
    {
        objectPooling = ObjectPooling.Instance;
    }

    private void FixedUpdate()
    {
        objectPooling.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
