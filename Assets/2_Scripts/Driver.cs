
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 1f;
    [SerializeField] float moveSpeed = 0.02f;
    [SerializeField] float slowSpeedRatio = 0.5f;
    [SerializeField] float boostSpeedRatio = 1.5f;
    float slowSpeed;
    float boostSpeed;

    void Start()
    {
        slowSpeed = moveSpeed * slowSpeedRatio;
        boostSpeed = moveSpeed * boostSpeedRatio;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Boost"))
        {
            moveSpeed = boostSpeed;
            Debug.Log("Boost!!!!!!!!!!!!!!");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    private int ApplyDamage(int c, int d)
    {
        int er = c - d;
        return er;
    }


    private int Multiply(int a, int b)
    {
        int rv = a * b;
        return rv;
    }

    void Sayhello(string name)
    {
        Debug.Log("hello " + "Doyun!");
    }

    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
