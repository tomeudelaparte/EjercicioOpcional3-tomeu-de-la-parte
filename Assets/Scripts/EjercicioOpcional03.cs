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
    private Vector3 randomPosition = new Vector3(0, 0, 0); // Reutilizo esta variable en varios ejercicios.

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
        // Index
        int i = 0;

        // Mientras Index sea menos igual a 100
        while (i <= 100)
        {
            // Si Index entre 2 da resto 0, imprime por consola el valor de Index
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 02
    private void Ejercicio02While()
    {
        // Index
        int i = 0;

        // Mientras Index sea menor a 20, imprime por consola el String
        while (i < 20)
        {
            Debug.Log("Hola, holita, vecinito");

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 03
    private void Ejercicio03While()
    {
        // Index
        int i = 1;

        // Mientras Index sea menor o igual a 500
        while (i <= 500)
        {
            // Si Index entre el divisor da resto 0, imprime por consola el valor de Index
            if (i % divisor == 0)
            {
                Debug.Log(i);
            }

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 04
    private void Ejercicio04While()
    {
        // Index
        int i = 0;

        // Mientras Index sea menor al tamaño de intArray, imprime por consola el valor de la posición del array
        while (i < intArray.Length)
        {
            Debug.Log(intArray[i]);

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 05
    private void Ejercicio05While()
    {
        // Index
        int i = 0;

        // Mientras Index sea menor a numEnemies
        while (i < numEnemies)
        {
            // Obtiene valores aleatorios en X, Y, Z entre 0 y 11
            randomPosition.x = Random.Range(0, 11);
            randomPosition.y = Random.Range(0, 11);
            randomPosition.z = Random.Range(0, 11);

            // Instancia el objeto enemySphere con una posición aleatoria
            Instantiate(enemySpherePrefab, randomPosition, enemySpherePrefab.transform.rotation);

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 06
    private void Ejercicio06While()
    {
        // Index
        int i = 0;

        // Mientras Index sea menor a numEnemies
        while (i < numEnemies)
        {
            // Obtiene valores en X, Y con Index + 1
            randomPosition.x = i + 1;
            randomPosition.y = i + 1;

            // Instancia el objeto enemyCube en la posición establecida en X e Y
            Instantiate(enemyCubePrefab, randomPosition, enemyCubePrefab.transform.rotation);

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 07
    private void Ejercicio07While()
    {
        // Index
        int i = 0;

        // Mientras Index sea menor al tamaño de matArray
        while (i < matArray.Length)
        {
            // Obtiene valor en X con Index * 2
            randomPosition.x = i * 2;

            // Instancia el objeto cylinder uno al lado del otro
            GameObject cylinder = Instantiate(cylinderPrefab, randomPosition, cylinderPrefab.transform.rotation);

            // Obtiene el material del objeto instanciado y lo cambia al valor de la posición en el array
            cylinder.GetComponent<Renderer>().material = matArray[i];

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 08
    private IEnumerator Ejercicio08While()
    {
        // Index
        int i = 0;

        // Instancia el objeto capsule y lo guarda en una variable
        GameObject capsule = Instantiate(capsulePrefab, capsulePrefab.transform.position, capsulePrefab.transform.rotation);

        // Mientras Index sea menor a 10
        while (i < 10)
        {
            // Espera 1.5 segundos
            yield return new WaitForSeconds(1.5f);

            // Aumenta la escala del objeto instanciado +0.2 en X, Y, Z
            capsule.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 09
    private IEnumerator Ejercicio09While()
    {
        // Index
        int i = 0;

        // Mientras Index sea menor al tamaño de gOArray
        while (i < gOArray.Length)
        {
            // Espera 2 segundos
            yield return new WaitForSeconds(2f);

            // Activa el objeto que corresponde a la posición en el array
            gOArray[i].SetActive(true);

            // Suma Index +1
            i++;
        }
    }

    // EJERCICIO 10
    private IEnumerator Ejercicio10While()
    {
        // Index
        int i = 0;

        // Tiempo de espera original
        float waitSeconds = 0.5f;

        // Mientras Index sea menor al tamaño de strArray
        while (i < strArray.Length)
        {
            // Imprime por consola el valor en la posición del array
            Debug.Log(strArray[i]);

            // Espera según el valor que indica waitSeconds
            yield return new WaitForSeconds(waitSeconds);

            // Suma al tiempo de espera en +0.5 segundos
            waitSeconds += 0.5f;

            // Suma Index +1
            i++;
        }
    }

    //////// FUNCIONES CON FOR ////////

    // EJERCICIO 01
    private void Ejercicio01For()
    {
        // En bucle si Index es menor o igual a 100 
        for (int i = 0; i <= 100; i++)
        {
            // Si Index entre 2 da resto 0, imprime por consola el valor de Index
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // EJERCICIO 02
    private void Ejercicio02For()
    {
        // En bucle si Index es menor a 20, mostrará el String por consola
        for (int i = 0; i < 20; i++)
        {
            Debug.Log("Hola, holita, vecinito");
        }
    }

    // EJERCICIO 03
    private void Ejercicio03For()
    {
        // En bucle si Index es menor o igual a 500
        for (int i = 1; i <= 500; i++)
        {
            // Si Index entre el divisor da resto 0, imprime por consola el valor de Index
            if (i % divisor == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // EJERCICIO 04
    private void Ejercicio04For()
    {
        // En bucle si Index es menor al tamaño de intArray, imprime por consola el valor de la posición del array
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }
    }

    // EJERCICIO 05
    private void Ejercicio05For()
    {
        // En bucle si Index es menor a numEnemies
        for (int i = 0; i < numEnemies; i++)
        {
            // Obtiene valores aleatorios en X, Y, Z entre 0 y 11
            randomPosition.x = Random.Range(0, 11);
            randomPosition.y = Random.Range(0, 11);
            randomPosition.z = Random.Range(0, 11);

            // Instancia el objeto enemySphere con una posición aleatoria
            Instantiate(enemySpherePrefab, randomPosition, enemySpherePrefab.transform.rotation);
        }
    }

    // EJERCICIO 06
    private void Ejercicio06For()
    {
        // En bucle si Index es menor a numEnemies
        for (int i = 0; i < numEnemies; i++)
        {
            // Obtiene valores en X, Y con Index + 1
            randomPosition.x = i + 1;
            randomPosition.y = i + 1;

            // Instancia el objeto enemyCube en la posición establecida en X e Y
            Instantiate(enemyCubePrefab, randomPosition, enemyCubePrefab.transform.rotation);
        }
    }

    // EJERCICIO 07
    private void Ejercicio07For()
    {
        // En bucle si Index es menor al tamaño de matArray
        for (int i = 0; i < matArray.Length; i++)
        {
            // Obtiene valor en X con Index * 2
            randomPosition.x = i * 2;

            // Instancia el objeto cylinder uno al lado del otro
            GameObject cylinder = Instantiate(cylinderPrefab, randomPosition, cylinderPrefab.transform.rotation);

            // Obtiene el material del objeto instanciado y lo cambia al valor de la posición en el array
            cylinder.GetComponent<Renderer>().material = matArray[i];
        }
    }

    // EJERCICIO 08
    private IEnumerator Ejercicio08For()
    {
        // Instancia el objeto capsule y lo guarda en una variable
        GameObject capsule = Instantiate(capsulePrefab, capsulePrefab.transform.position, capsulePrefab.transform.rotation);

        // En bucle si Index es menor a 10
        for (int i = 0; i < 10; i++)
        {
            // Espera 1.5 segundos
            yield return new WaitForSeconds(1.5f);

            // Aumenta la escala del objeto instanciado +0.2 en X, Y, Z
            capsule.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        }
    }

    // EJERCICIO 09
    private IEnumerator Ejercicio09For()
    {
        // Bucle que recorre cada elemento de gOArray
        foreach (GameObject element in gOArray)
        {
            // Espera 2 segundos
            yield return new WaitForSeconds(2f);

            // Activa el objeto correspondiente a la iteración
            element.SetActive(true);
        }
    }

    // EJERCICIO 10
    private IEnumerator Ejercicio10For()
    {
        // Tiempo de espera original
        float waitSeconds = 0.5f;

        // En bucle si Index es menor al tamaño de strArray
        for (int i = 0; i < strArray.Length; i++)
        {
            // Imprime por consola el valor en la posición del array
            Debug.Log(strArray[i]);

            // Espera según el valor que indica waitSeconds
            yield return new WaitForSeconds(waitSeconds);

            // Suma al tiempo de espera en +0.5 segundos
            waitSeconds += 0.5f;
        }
    }
}