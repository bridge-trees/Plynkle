using UnityEngine;

public class Launcher : MonoBehaviour
{
   public GameObject ProjectilePrefab;
   public Transform ProjecileSpawnPoint;
   public void Launch(Vector2 aimDirection)
   {
      // create a ball at the cannon
      GameObject projectileObject = Instantiate(ProjectilePrefab, ProjecileSpawnPoint.position, Quaternion.identity);
      // start the ball moving forward
      LaunchProjectile(projectileObject, aimDirection);
   }

   private void LaunchProjectile(GameObject projectileObject, Vector2 aimDirection)
   {
      Rigidbody2D projectileRigidbody = projectileObject.GetComponent<Rigidbody2D>();
      // add force
      projectileRigidbody.AddForce(aimDirection * 5f, ForceMode2D.Impulse);
   }
}
