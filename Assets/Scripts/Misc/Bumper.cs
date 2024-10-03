using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Bumper : MonoBehaviour
{
    public float force = 10f; // Force de propulsion à appliquer

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();

        if (ballRb != null)
        {
            // Calcule la direction du centre du bumper vers la balle
            Vector3 direction = (collision.transform.position - transform.position).normalized;

            // Annule toute composante sur l'axe Y (on veut uniquement une propulsion horizontale)
            direction.y = 0;

            // Applique la force dans la direction calculée
            ballRb.AddForce(direction * force, ForceMode.Impulse);
        }
    }
}
