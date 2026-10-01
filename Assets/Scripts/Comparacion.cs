using UnityEngine;

public class CalculadoraVectores : MonoBehaviour {
  public Vector3 vectorA;
  public Vector3 vectorB;

  public float magnitudA;
  public float magnitudB;
  public float angulo;
  public float distancia;
  public string vectorMasAlto;

  void Start() {
    magnitudA = vectorA.magnitude;
    magnitudB = vectorB.magnitude;
    angulo = Vector3.Angle(vectorA, vectorB);
    distancia = Vector3.Distance(vectorA, vectorB);
    Debug.Log("Magnitud del primero: " + magnitudA);
    Debug.Log("Magnitud del segundo: " + magnitudB);
    Debug.Log("Ángulo que forman: " + angulo);
    Debug.Log("Distancia entre ellos: " + distancia);
    if (vectorA.y > vectorB.y) {
        vectorMasAlto = "vectorA por encima de vectorB";
    } else if (vectorA.y < vectorB.y) {
        vectorMasAlto = "vectorB por encima de vectorA";
    } else {
        vectorMasAlto = "Se encuentran a la misma altura";
    }

    Debug.Log(vectorMasAlto);
  }
}