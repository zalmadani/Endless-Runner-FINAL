using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject Player;
    Renderer rend;

    float playerStartPos;
    public float speed;

    void Start()
    {
        Player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        playerStartPos = Player.transform.position.x;
    }
    void Update()
    {
        float offset = (Player.transform.position.x - playerStartPos) * speed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}
