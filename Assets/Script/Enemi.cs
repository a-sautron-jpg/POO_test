using UnityEngine;

namespace TP2_Heritage
{
    public class Enemi : MonoBehaviour
    {
        protected int health;
        protected int damage;
        protected float speed;
        protected float detectionRange;
        public Transform player;
        
        protected void Start() 
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        
        protected virtual void Update() 
        {
            if (Vector3.Distance(transform.position, player.position) < detectionRange) 
            {
                Vector3 direction = (player.position - transform.position).normalized;
                transform.position += direction * speed * Time.deltaTime;
            }
        }
        
        public void TakeDamage(int amount) 
        {
            health -= amount;
            if (health <= 0) 
            {
                Die();
            }
        }
        
        protected void Die() 
        {
            Destroy(gameObject);
        }
        
        protected void OnCollisionEnter(Collision collision) 
        {
            if (collision.gameObject.CompareTag("Player")) 
            {
                PlayerCharacter player = collision.gameObject.GetComponent<PlayerCharacter>();   
                if (player != null) 
                {
                    player.TakeDamage(damage);
                }
            }
        }
    }
}