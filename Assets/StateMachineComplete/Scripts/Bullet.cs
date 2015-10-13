using UnityEngine;
using System.Collections;

namespace StateMachineSample
{
    public class Bullet : MonoBehaviour
    {
        public ParticleSystem explosionPrefab;

        private float speed = 50f;
        private float force = 500f;

        private void Start()
        {
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }

        private void OnCollisionEnter(Collision collision)
        {
            Vector3 contactPoint = collision.contacts[0].point;
            Instantiate(explosionPrefab, contactPoint, Quaternion.identity);

            if (collision.rigidbody != null)
            {
                collision.rigidbody.AddForce(transform.forward * force);
            }

            if (collision.gameObject.tag == "Enemy")
            {
                collision.gameObject.GetComponent<Enemy>().TakeDamage();
            }

            Destroy(gameObject);
        }
    }
}
