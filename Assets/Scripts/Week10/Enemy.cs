using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;

    public float attackSpeed;
    public float attackTimer;

    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created0
   protected virtual void Start()
    {
        //Player = FindAnyObjectByType<Player>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (Vector3.Distance(this.transform.position, Player.transform.position) < attackRange)
        {
            Attack();   
        }
    }
    public virtual void Attack()
    {
        //Player.TakeDamage(attackDamage);
    }
}
