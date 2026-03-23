using UnityEngine;

public class CarController : Vehicle
{
    private float carTraction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        // Gérer l'accélération et le freinage
        if (moveInput > 0)
        {
            speed += acceleration * moveInput * Time.deltaTime;
            // Logique spécifique à la voiture
            ApplyCarTraction();
        }
        else if (moveInput < 0)
        {
            speed -= brakeForce * Mathf.Abs(moveInput) * Time.deltaTime;
        }

        // Limiter la vitesse maximale
        speed = Mathf.Clamp(speed, 0, maxSpeed);

        transform.Rotate(0, turnInput * handling * speed * 0.1f * Time.deltaTime, 0);

        // Déplacement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }


    void ApplyCarTraction()
    {
        // Simuler la traction d'une voiture
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 1.0f))
        {
            float surfaceFactor = 1.0f;
            if (hit.collider.CompareTag("Dirt")) surfaceFactor = 0.7f;
            if (hit.collider.CompareTag("Ice")) surfaceFactor = 0.3f;
            speed *= (1.0f - (1.0f - carTraction) * (1.0f - surfaceFactor));
        }
    }
}
