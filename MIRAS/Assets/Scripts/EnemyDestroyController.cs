using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyController : MonoBehaviour
{
    public void DestroyEnemy(float delay)
    {
        if (gameObject.TryGetComponent<lavuk>(out lavuk lavuk))
        {

            Destroy(gameObject);
        }

        Destroy(gameObject);
    }
}