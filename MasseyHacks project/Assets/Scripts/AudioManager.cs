using UnityEngine;

public class AudioManager : MonoBehaviour {

    // Use this for initialization
    CharacterController cc;

    void Start () {
        cc = GetComponent<CharacterController>();
     }
 
    void Update () {
        if (cc.isGrounded == true && cc.velocity.magnitude > 0f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.5f, 1);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1);
            GetComponent<AudioSource>().Play();
        }
    }
}
