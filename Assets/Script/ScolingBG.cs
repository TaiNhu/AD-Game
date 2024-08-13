using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scool : MonoBehaviour
{
    Renderer BgRenderer;
    [SerializeField]
    private float scrollSpeed;
    // Start is called before the first frame update
    void Start()
    {
        BgRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        BgRenderer.material.mainTextureOffset = new Vector2 (0,Time.time*-scrollSpeed);
    }
}
