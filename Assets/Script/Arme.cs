using TP2_Heritage;
using UnityEditor;
using UnityEngine;

public class Arme
{
    // -- Les propriétés --

    // Qu'est-ce ce qu'une arme
    //Nom, Degat
    string name;
    int degat;


    public string Name { get => name; set => name = value; }

    public void setName(string valeur) 
    { 
        Name = valeur; 
    }

    public string getName()
    {
        return Name;
    }

    public int getDegat()
    {
        return degat;
    }

    public void setName(int valeur)
    {
        degat = valeur;
    }

    // -- Le fontionnement de ma classe --
    // Que peux faire une arme

    public void Attaquer(GameObject Monster)
    {
        Monster.GetComponent<Enemi>().TakeDamage(degat);
    }


}