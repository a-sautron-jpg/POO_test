using UnityEngine;

public class Weapon : MonoBehaviour 
{

    protected string currentWeapon;
    public void SwitchWeapon(string weaponName)
    {
        currentWeapon = weaponName;

        Debug.Log("Switched to " + currentWeapon);
    }
}
