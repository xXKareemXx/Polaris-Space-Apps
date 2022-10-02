using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class projectile_controller : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int bullet_amount = 100;
    public TextMeshProUGUI bullet_value_textholder;


    // Update is called once per frame
    void Update()
    {
        bullet_value_textholder.text = bullet_amount.ToString();

    }

    public void shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, this.transform.position, transform.rotation, transform);
        bullet_amount--;
        Destroy(bullet, 1.5f);
    }
}
