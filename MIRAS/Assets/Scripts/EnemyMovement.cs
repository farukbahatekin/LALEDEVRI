using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float Speed;
    private Animator animator;

    int NextPosIndex;
    Transform NextPos;

    private void Start()
    {
        NextPos = Positions[0];
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        if(transform.position== NextPos.position)
        {
            NextPosIndex++;
            if(NextPosIndex>=Positions.Length)
            {
                NextPosIndex = 0;

            }

            NextPos = Positions[NextPosIndex];
        }
        else
        {
            Vector3 direction = (NextPos.position - transform.position);
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, Speed * Time.deltaTime);

            if (direction.x > 0 && direction.y > 0)
            {
                animator.Play("enemy_up");
            }
            else if (direction.x > 0)
            {
                animator.Play("enemy_right");
            }
            else if (direction.x < 0 && direction.y > 0)
            {
                animator.Play("enemy_left");
            }
            else if (direction.y < 0 && direction.x < 0)
            {
                animator.Play("enemey_down");
            }

            transform.position =Vector3.MoveTowards(transform.position, NextPos.position, Speed*Time.deltaTime);
        }
    }


}
