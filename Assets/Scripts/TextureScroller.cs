using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float Speed = .5f;
    Renderer _renderer;
    float _offset;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        // Increase offset based on time
        _offset += Time.deltaTime * Speed;
        // Keep offset between 0 and 1
        if (_offset > 1)
            _offset -= 1;
        // Apply the offset to the material
        _renderer.material.mainTextureOffset = new Vector2(0, _offset);
    }
}
