using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public GameObject player; // тут объект игрока
    private Vector3 offset;

    void Start()
    {
        player = GameObject.Find("Character");
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}