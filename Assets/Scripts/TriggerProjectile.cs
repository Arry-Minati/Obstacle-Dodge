using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectile;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            foreach (GameObject obj in projectile)
            {
                obj.SetActive(true);
                Destroy(gameObject);
            }
            
        }
    }
}
