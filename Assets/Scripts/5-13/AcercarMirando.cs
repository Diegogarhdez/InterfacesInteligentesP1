using UnityEngine;

public class AcercarMirando : MonoBehaviour {
  public float speed = 5f;
  public Transform objetivoEsfera;

  void Update() {
    transform.LookAt(objetivoEsfera);
    Debug.DrawRay(transform.position, transform.forward * 5f, Color.green);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
  }
}