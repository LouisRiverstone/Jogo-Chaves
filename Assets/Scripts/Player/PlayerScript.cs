using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    Animator animator;
    public GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Moviment();
    }

    void Moviment()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position += new Vector3(h, 0, v) * Time.fixedDeltaTime * speed;
        animator.SetFloat("Blend", h+v/2 > 0 ? h+v/2 : (h+v/2) * -1);
        float myAngle = Mathf.Atan2 (Input.GetAxis ("Horizontal"),Input.GetAxis ("Vertical")) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,myAngle,0);
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Pickuble"){
            Destroy(other.gameObject);
            gc.subtractCount();
        }
    }
}
