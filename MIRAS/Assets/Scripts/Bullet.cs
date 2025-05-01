using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hiteffect;

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);

        if(collision.gameObject.TryGetComponent<lavuk>(out lavuk lavuk))
        {
            
            Destroy(collision.gameObject);
        }

        Destroy(gameObject );
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
