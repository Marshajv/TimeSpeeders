using UnityEngine;
using System.Collections;

public class xAxisScrollingText : MonoBehaviour {
    public float scrollSpeed;
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset,0));
    }
}
