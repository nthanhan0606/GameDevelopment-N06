using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    public Vector3 bulletSpawnOffset = new(0, 0, 1f);

    private float lastBulletTime;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        Vector3 spawnPosition = transform.position + transform.TransformDirection(bulletSpawnOffset);
        Instantiate(bulletPrefabs, spawnPosition, transform.rotation);
    }
}