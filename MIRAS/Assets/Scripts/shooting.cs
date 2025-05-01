using UnityEngine;
using UnityEngine.InputSystem;

public class bullet : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public Camera cam;
    private Vector2 mousePos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnAttack(collision);
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector2 shootDir = mousePos - (Vector2)firePoint.position;
        shootDir.Normalize();
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootDir * bulletForce, ForceMode2D.Impulse);
    }

    void OnAttack(Collider2D collision)
    {
        if (collision.GetComponent<lavuk>() != null)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
