using UnityEngine;

public class BuscadorDistancias : MonoBehaviour {
  void Start() {
    GameObject objetoCubo = GameObject.FindWithTag("CubeTag");
    GameObject objetoCilindro = GameObject.FindWithTag("Cylinder");
    if (objetoCubo != null && objetoCilindro != null)  {
      Vector3 posicionEsfera = transform.position;
      float distanciaCubo = Vector3.Distance(posicionEsfera, objetoCubo.transform.position);
      float distanciaCilindro = Vector3.Distance(posicionEsfera, objetoCilindro.transform.position);
      Debug.Log("Distancia al cubo: " + distanciaCubo);
      Debug.Log("Distancia al Cilindro:" + distanciaCilindro);
    } else {
      Debug.Log("No se encontró el cubo o el cilindro.");
    }
  }
}