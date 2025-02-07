using TMPro; 
using UnityEngine;

public class MostrarTexto : MonoBehaviour
{
    public TextMeshProUGUI textoUI; 

    void Start()
    {
        textoUI.text = "Hola mundo";
    }
}
