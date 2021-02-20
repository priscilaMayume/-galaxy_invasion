using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBlack : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Vector2 _direction;

    private Rigidbody2D _rb2dbody;


    // Start is called before the first frame update
    void Start()
    {
        _rb2dbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame

    void Update() {
        if (transform.position.y <= 0){
            _direction.x = 1;
        }
    }
    void FixedUpdate()
    {
        _rb2dbody.MovePosition(_rb2dbody.position +(_direction*_speed*Time.deltaTime));
    }
    void OnBecameInvisible() {

        Destroy(this.gameObject);
        
    }
}