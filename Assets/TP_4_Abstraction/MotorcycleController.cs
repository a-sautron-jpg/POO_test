using UnityEngine;

public class MotorcycleController : Vehicle
{
    private float motorcycleLeanAngle;

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
            speed += acceleration * 1.2f * moveInput * Time.deltaTime; // Les motos accélèrent plus vite
                                                                       // Logique spécifique à la moto
            ApplyMotorcycleLean(turnInput);
        }
        else if (moveInput < 0)
        {
            speed -= brakeForce * 0.8f * Mathf.Abs(moveInput) * Time.deltaTime;
        }

        // Limiter la vitesse maximale
        speed = Mathf.Clamp(speed, 0, maxSpeed);

        transform.Rotate(0, turnInput * handling * speed * 0.15f * Time.deltaTime, 0);

        // Déplacement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }

    void ApplyMotorcycleLean(float turnInput)
    {
        // Simuler l'inclinaison d'une moto dans les virages
        float targetLean = -turnInput * motorcycleLeanAngle;
        Vector3 currentRotation = transform.localEulerAngles;
        currentRotation.z = Mathf.LerpAngle(currentRotation.z, targetLean, Time.deltaTime * 2.0f);
        transform.localEulerAngles = currentRotation;
    }
}
