using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer4 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, 1);
    public GameObject camera1;
    public GameObject camera2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // adding offest to the camera so it follows behind and not the exact position
        transform.position = player.transform.position + offset;
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
    }
}
