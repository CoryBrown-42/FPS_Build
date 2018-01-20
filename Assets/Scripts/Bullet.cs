using UnityEngine;

public class  Bullet : MonoBehaviour
{
	public float maxSpeed = 25f;
	public Rigidbody bullet;

	void Update()
	{
			bullet.velocity = transform.forward * maxSpeed;
			Physics.IgnoreCollision(bullet.GetComponent<Collider>(), GetComponent<Collider>());
	}
    void OnCollisionExit(Collision col)
    {

        Destroy(gameObject);

        if (col.gameObject.tag == "Untagged")
        {
            Destroy(gameObject);
        }
    }
}
