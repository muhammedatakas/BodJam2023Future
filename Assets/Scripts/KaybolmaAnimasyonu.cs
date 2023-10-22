using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KaybolmaAnimasyonu : MonoBehaviour
{
    private SpriteRenderer spriteRendererr;
    private float kaybolmaSure = 1f; // Kaybolma süresi (örneðin 1 saniye)

    void Start()
    {
        spriteRendererr = GetComponent<SpriteRenderer>();
        // Kaybolma animasyonunu baþlat
        StartCoroutine(Kaybolmaanimasyonu());
    }

    IEnumerator Kaybolmaanimasyonu()
    {
        float zaman = 0f;
        while (zaman < kaybolmaSure)
        {
            // Zamanla alpha deðerini azaltarak kaybolma efektini oluþtur
            spriteRendererr.color = new Color(spriteRendererr.color.r, spriteRendererr.color.g, spriteRendererr.color.b, Mathf.Lerp(1f, 0f, zaman / kaybolmaSure));
            zaman += Time.deltaTime;
            yield return null;
        }
        // Nesneyi yok et veya istediðiniz bir iþlemi gerçekleþtirin
        Destroy(gameObject);
    }
}
