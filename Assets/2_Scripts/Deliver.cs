using UnityEngine;

public class Deliver : MonoBehaviour
{
    bool hasChicken = false;
    [SerializeField] float destoryDelay = 1f;
    [SerializeField] Color noChinckenColor = new Color(1, 1, 1, 1);
    [SerializeField] Color hasChinckenColor = new Color(1, 0.5471423f, 1, 1);
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�ƾ�! ", gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Chicken") && !hasChicken)
        {
            Debug.Log("ġŲ �Ⱦ���");
            hasChicken = true;
            spriteRenderer.color = hasChinckenColor;
            Destroy(collision.gameObject, destoryDelay);
        }

        if (collision.gameObject.CompareTag("Customer") && hasChicken)
        {
            Debug.Log("ġŲ�� ��޵�");
            hasChicken = false;
            spriteRenderer.color = noChinckenColor;
        }

     
    }
}
