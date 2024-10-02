using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBump : MonoBehaviour
{
    public float force = 100f;  // Valeur de la force à appliquer
    private List<Rigidbody> rigidbodiesInTrigger = new List<Rigidbody>();

    void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet qui entre dans le trigger a un Rigidbody
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null && !rigidbodiesInTrigger.Contains(rb))
        {
            rigidbodiesInTrigger.Add(rb);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Retire le Rigidbody de la liste quand il quitte le trigger
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null && rigidbodiesInTrigger.Contains(rb))
        {
            rigidbodiesInTrigger.Remove(rb);
        }
    }

    void Update()
    {
        // Ajoute la force à chaque rigidbody dans le trigger quand la touche espace est appuyée
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Rigidbody rb in rigidbodiesInTrigger)
            {
                rb.AddForce(new Vector3(0, 0, force), ForceMode.Impulse);
            }
        }
    }
}
