using UnityEngine;

public class AirplaneController : Vehicle
{
    private float airplaneLift;

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
            speed += acceleration * 0.8f * moveInput * Time.deltaTime;
            // Logique spécifique à l'avion
            ApplyAirplaneLift();
        }
        else if (moveInput < 0)
        {
            speed -= brakeForce * 0.4f * Mathf.Abs(moveInput) * Time.deltaTime;
        }

        // Limiter la vitesse maximale
        speed = Mathf.Clamp(speed, 0, maxSpeed);

        transform.Rotate(turnInput * handling * 0.5f * Time.deltaTime,
                            moveInput * handling * 0.3f * Time.deltaTime,
                            -turnInput * handling * Time.deltaTime);

        // Déplacement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


    }

    void ApplyAirplaneLift()
    {
        // Simuler la portance d'un avion
        if (speed > maxSpeed * 0.3f)
        {
            float liftForce = airplaneLift * (speed / maxSpeed);
            transform.Translate(Vector3.up * liftForce * Time.deltaTime, Space.World);
        }
    }
}
