using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioOpcional03 : MonoBehaviour
{
    // Ejercicio03
    public int divisor = 3;

    // Ejercicio04
    public int[] intArray;

    // Ejercicio05
    public int numEnemies = 1;
    public GameObject enemySpherePrefab;
    private Vector3 randomPosition = new Vector3(0, 0, 0);

    // Ejercicio06
    public GameObject enemyCubePrefab;

    // Ejercicio07
    public GameObject cylinderPrefab;
    public Material[] matArray;

    // Ejercicio08
    public GameObject capsulePrefab;

    // Ejercicio09
    public GameObject[] gOArray;

    // Ejercicio10
    public string[] strArray;

    void Start()
    {
        // WHILE

        Ejercicio01While();
        // Ejercicio02While();
        // Ejercicio03While();
        // Ejercicio04While();
        // Ejercicio05While();
        // Ejercicio06While();
        // Ejercicio07While();
        // StartCoroutine(Ejercicio08While());
        // StartCoroutine(Ejercicio09While());
        // StartCoroutine(Ejercicio10While());

        // FOR

        // Ejercicio01For();
        // Ejercicio02For();
        // Ejercicio03For();
        // Ejercicio04For();
        // Ejercicio05For();
        // Ejercicio06For();
        // Ejercicio07For();
        // StartCoroutine(Ejercicio08For());
        // StartCoroutine(Ejercicio09For());
        // StartCoroutine(Ejercicio10For());
    }


    //////// FUNCIONES CON WHILE ////////

    // EJERCICIO 01
    private void Ejercicio01While()
    {
        int i = 0;

        while (i <= 100)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }

            i++;
        }
    }

    // EJERCICIO 02
    private void Ejercicio02While()
    {
        int i = 0;

        while (i < 20)
        {
            Debug.Log("Hola, holita, vecinito");

            i++;
        }
    }

    // EJERCICIO 03
    private void Ejercicio03While()
    {
        int i = 1;

        while (i <= 500)
        {
            if (i % divisor == 0)
            {
                Debug.Log(i);
            }

            i++;
        }
    }

    // EJERCICIO 04
    private void Ejercicio04While()
    {
        int i = 0;

        while (i < intArray.Length)
        {
            Debug.Log(intArray[i]);

            i++;
        }
    }

    // EJERCICIO 05
    private void Ejercicio05While()
    {
        int i = 0;

        while (i < numEnemies)
        {
            randomPosition.x = Random.Range(0, 11);
            randomPosition.y = Random.Range(0, 11);
            randomPosition.z = Random.Range(0, 11);

            Instantiate(enemySpherePrefab, randomPosition, enemySpherePrefab.transform.rotation);

            i++;
        }
    }

    // EJERCICIO 06
    private void Ejercicio06While()
    {
        int i = 0;

        while (i < numEnemies)
        {
            randomPosition.x = i + 1;
            randomPosition.y = i + 1;

            Instantiate(enemyCubePrefab, randomPosition, enemyCubePrefab.transform.rotation);

            i++;
        }
    }

    // EJERCICIO 07
    private void Ejercicio07While()
    {
        int i = 0;

        while (i < matArray.Length)
        {
            randomPosition.x = i * 2;

            GameObject cylinder = Instantiate(cylinderPrefab, randomPosition, cylinderPrefab.transform.rotation);

            cylinder.GetComponent<Renderer>().material = matArray[i];

            i++;
        }
    }

    // EJERCICIO 08
    private IEnumerator Ejercicio08While()
    {
        int i = 0;

        GameObject capsule = Instantiate(capsulePrefab, capsulePrefab.transform.position, capsulePrefab.transform.rotation);

        while (i < 10)
        {
            yield return new WaitForSeconds(1.5f);
            capsule.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

            i++;
        }
    }

    // EJERCICIO 09
    private IEnumerator Ejercicio09While()
    {
        int i = 0;

        while (i < gOArray.Length)
        {
            yield return new WaitForSeconds(2f);
            gOArray[i].SetActive(true);

            i++;
        }
    }

    // EJERCICIO 10
    private IEnumerator Ejercicio10While()
    {
        int i = 0;

        float waitSeconds = 0.5f;

        while (i < strArray.Length)
        {
            Debug.Log(strArray[i]);

            yield return new WaitForSeconds(waitSeconds);

            waitSeconds += 0.5f;

            i++;
        }
    }

    //////// FUNCIONES CON FOR ////////

    // EJERCICIO 01
    private void Ejercicio01For()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // EJERCICIO 02
    private void Ejercicio02For()
    {
        for (int i = 0; i < 20; i++)
        {
            Debug.Log("Hola, holita, vecinito");
        }
    }

    // EJERCICIO 03
    private void Ejercicio03For()
    {
        for (int i = 1; i <= 500; i++)
        {
            if (i % divisor == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // EJERCICIO 04
    private void Ejercicio04For()
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }
    }

    // EJERCICIO 05
    private void Ejercicio05For()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            randomPosition.x = Random.Range(0, 11);
            randomPosition.y = Random.Range(0, 11);
            randomPosition.z = Random.Range(0, 11);

            Instantiate(enemySpherePrefab, randomPosition, enemySpherePrefab.transform.rotation);
        }
    }

    // EJERCICIO 06
    private void Ejercicio06For()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            randomPosition.x = i + 1;
            randomPosition.y = i + 1;

            Instantiate(enemyCubePrefab, randomPosition, enemyCubePrefab.transform.rotation);
        }
    }

    // EJERCICIO 07
    private void Ejercicio07For()
    {
        for (int i = 0; i < matArray.Length; i++)
        {
            randomPosition.x = i * 2;

            GameObject cylinder = Instantiate(cylinderPrefab, randomPosition, cylinderPrefab.transform.rotation);

            cylinder.GetComponent<Renderer>().material = matArray[i];
        }
    }

    // EJERCICIO 08
    private IEnumerator Ejercicio08For()
    {
        GameObject capsule = Instantiate(capsulePrefab, capsulePrefab.transform.position, capsulePrefab.transform.rotation);

        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1.5f);
            capsule.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        }
    }

    // EJERCICIO 09
    private IEnumerator Ejercicio09For()
    {
        foreach (GameObject element in gOArray)
        {
            yield return new WaitForSeconds(2f);
            element.SetActive(true);
        }
    }

    // EJERCICIO 10
    private IEnumerator Ejercicio10For()
    {
        float waitSeconds = 0.5f;

        for (int i = 0; i < strArray.Length; i++)
        {
            Debug.Log(strArray[i]);

            yield return new WaitForSeconds(waitSeconds);

            waitSeconds += 0.5f;
        }
    }
}
