using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{

    [Header("BulletTypes")]
    //Header("Bullet Types")]
    public GameObject regularBullet;
    public GameObject fatBullet;
    public GameObject pulsingBullet;

    public BulletManager bulletManager;



    public GameObject createBullet(BulletType type)
    {
        GameObject tempBullet = new GameObject();
        switch (type)
        {

            case BulletType.REGULAR:
                Instantiate(regularBullet);
                break;
            case BulletType.FAT:
                Instantiate(fatBullet);
                break;
            case BulletType.PULSING:
                Instantiate(pulsingBullet);
                break;
        }
        tempBullet.transform.parent = transform;

        return tempBullet;
    }
}

