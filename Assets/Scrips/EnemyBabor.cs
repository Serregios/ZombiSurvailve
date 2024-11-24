using UnityEngine;

public class EnemyBabor : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerHp>())
        {
            other.GetComponent<PlayerHp>().TakeDamage(damage);
        }
    }
}
