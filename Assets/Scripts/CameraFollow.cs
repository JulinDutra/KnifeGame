using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public GameObject player;
    public float distance = 30f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.Abs(player.transform.position.x) - 0.63f, this.transform.position.y, this.transform.position.z);
    }
}
