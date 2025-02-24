using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private float _xspeed;
    private float _yspeed;

    public float speed = 3;

    private string ImputX = "Horizontal";
    private string ImputY = "Vertical";
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _xspeed = Input.GetAxis(ImputX);
        _yspeed = Input.GetAxis(ImputY);

        _rigidbody2D.velocity = new Vector2(_xspeed, _yspeed) * speed;
    }

}
