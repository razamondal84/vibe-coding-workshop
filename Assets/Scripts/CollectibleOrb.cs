using UnityEngine;

public class CollectibleOrb : MonoBehaviour
{
    public GameObject particlePrefab;
    public AudioClip collectSound;

    void Update()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.AddScore(1);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Instantiate(particlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
