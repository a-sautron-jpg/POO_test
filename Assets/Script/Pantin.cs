using UnityEngine;

public class Pantin : MonoBehaviour
{
    Arme faux;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(faux.getName());
        faux.setName("L'aileron des Enfers");
        faux.Name = "Boom";
        
        Arme eppe = new Arme();

        Debug.Log("finit");

        ArmeMelee epee2 = new ArmeMelee();

        epee2.setName("Atchoum");
        epee2.Attaquer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
