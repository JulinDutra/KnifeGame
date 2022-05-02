using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public GameObject player;
    public float distance = 30f;


    void Update()
    {
        transform.position = new Vector3(player.transform.position.x -3.5f, player.transform.position.y, transform.position.z);
    }
}
