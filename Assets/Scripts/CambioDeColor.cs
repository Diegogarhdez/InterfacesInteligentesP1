using UnityEngine;

public class CambiadorDeColor : MonoBehaviour {
  private float[] vectorColor = new float[3];
  public int framesDeEspera = 120;
  private int contadorFrames = 0;

  void Start() {
    for (int i = 0; i < 3; i++) {
      vectorColor[i] = Random.Range(0f, 1f);
    }
    AplicarColor();
  }

  void Update() {
    contadorFrames++;
    if (contadorFrames >= framesDeEspera) {
      int posicionAleatoria = Random.Range(0, 3);
      vectorColor[posicionAleatoria] = Random.Range(0f, 1f);
      AplicarColor();
      contadorFrames = 0;
    }
  }

  void AplicarColor() {
    Color nuevoColor = new Color(vectorColor[0], vectorColor[1], vectorColor[2]);
    GetComponent<Renderer>().material.color = nuevoColor;
  }
}