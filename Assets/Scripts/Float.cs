using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    [SerializeField] private GameObject battery;
    private float yInitial; // Nesnenin baþlangýç yüksekliði
    private float floatHeight = 0.3f; // Salýnýmýn zirve noktasý
    private float floatSpeed = 0.6f; // Salýným hýzý
    private bool floatingUpward = true; // Nesnenin yukarý mý aþaðý mý hareket ettiðini belirten flag

    // Start is called before the first frame update
    void Start()
    {
        yInitial = battery.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Salýným hýzýný hesapla
        float deltaHeight = floatSpeed * Time.deltaTime;

        // Yön deðiþtirme kontrolü
        if (floatingUpward)
        {
            battery.transform.position += new Vector3(0f, deltaHeight, 0f);
        }
        else
        {
            battery.transform.position -= new Vector3(0f, deltaHeight, 0f);
        }

        // Zirveye ulaþýldýðýnda yönü tersine çevir
        if (battery.transform.position.y >= yInitial + floatHeight)
        {
            floatingUpward = false;
        }
        else if (battery.transform.position.y <= yInitial - floatHeight)
        {
            floatingUpward = true;
        }
    }
}
