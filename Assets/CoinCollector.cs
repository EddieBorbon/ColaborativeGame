using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    // Variable para almacenar la cantidad de monedas recolectadas
    public int coinsCollected = 0;

    // Método que se ejecuta cuando el jugador entra en contacto con otro collider
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto tiene la etiqueta "Coin"
        if (other.CompareTag("Coin"))
        {
            // Incrementa la cantidad de monedas recolectadas
            coinsCollected++;

            // Imprime en consola la cantidad de monedas recolectadas
            Debug.Log("Monedas recolectadas: " + coinsCollected);

            // Destruye el objeto con la etiqueta "Coin"
            Destroy(other.gameObject);
        }
    }
}