using UnityEngine;

public class GunScript : MonoBehaviour
{
    public Animator animator;

    public AudioSource audioSource;

    public float damage = 100f;
    public float range = 50f;
    public ParticleSystem muzzleFlash;
    public GameObject bulletImpact;
    public Camera fpsCam;

    public float ammo = 20f;
    private float fireRate = 0.5f;
    private float nextFire = 0f;



    void FixedUpdate()
    {
        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);

        if (info.IsName("Fire")){
            animator.SetBool("Fire", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Fire1") && Time.time > nextFire){
             animator.SetBool("Fire", true);
             nextFire = Time.time + fireRate;
             ShootGun();
          }  
    }

    void ShootGun()
    {
        audioSource.Play();
        muzzleFlash.Play();
        RaycastHit hit;
        ammo--;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){
            if(hit.transform.name != "FirstPersonPlayer"){
               if(hit.transform.name == "Enemy"){
                    Rigidbody rb = hit.transform.GetComponent<Rigidbody>();
                    rb.AddForceAtPosition(3000 * fpsCam.transform.forward, hit.point);
                    EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
                    enemyHealth.TakeDamage(damage);
                }
                    GameObject hitImpact = Instantiate(bulletImpact, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(hitImpact, 3f);
            }
            }



    }
}
