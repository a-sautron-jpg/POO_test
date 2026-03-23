using TP2_Heritage;
using UnityEditor;

public class Epee : Arme
{
    public void Attaquer()
    {
        base.Attaquer(PlayerCharacter.Cibles[0]);

    }
}