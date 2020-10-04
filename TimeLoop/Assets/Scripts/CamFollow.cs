using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform playerObject;
    [SerializeField] private float smoothValue;

    private void Update()
    {
        SmoothFollow();
    }

    private void SmoothFollow()
    {
        Vector3 smoothRef = Vector3.zero;
        Vector3 targetPos = new Vector3(playerObject.position.x, playerObject.position.y, this.transform.position.z);
        this.transform.position = Vector3.SmoothDamp(this.transform.position, targetPos, ref smoothRef, smoothValue);

    }
}
