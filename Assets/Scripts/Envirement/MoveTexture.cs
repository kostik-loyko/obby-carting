using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float speedTexture;
    [SerializeField] Material material;
    [SerializeField] Material material1;

    private void FixedUpdate()
    {
        material.mainTextureOffset = new Vector2(Time.time * speedTexture * Time.deltaTime, 0f);
        material1.mainTextureOffset = new Vector2(Time.time * speedTexture * Time.deltaTime, 0f);
        Vector3 pos = rb.position;
        rb.position += Vector3.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}
