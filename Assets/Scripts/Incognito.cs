using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Incognito : MonoBehaviour
{
    public static bool isLoading;
    private float timer;
    public float XBorderMin, XBorderMax;
    public AudioSource audioJump;
    public AudioSource audioHit;

    public AudioSource audioEnemyKill;

    public AudioSource audioFullHealth;

    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float jumpForce = 300f;

    private Rigidbody2D myBody;

    private Animator animator;

    private SpriteRenderer sr;
    
    private AudioSource jumpAudio;

    private Vector2 tempPos;

    private float tempFlip;

    private Vector3 startingPos;
    public Vector3 StartingPos
    {
        get
        {
            return this.startingPos;
        }
        set
        {
            startingPos = value;
        }
    }

    public static Vector3 startingPosition;

    private bool isGrounded;

    public GameObject attackPoint;

    public float radius;

    public LayerMask enemies;

    //private float borderRightX = -13, borderLeftX = 57;

    public GameObject gunFire;
    private float gunTimer;
    private float gunTimer2;
    private bool gunActive;
    private bool gunActive2;
    public AudioSource gunSound;

    public static int numOfBullets;

    private GameObject bulletUI;
    public Text bulletQuantity;

    public GameObject flyBullet;
    public Transform flyBulletPos;
    public static bool canMove;

    private float shootTimer;
    private bool shootBool;



    void Awake()
    { 
        shootTimer = 2f;
        shootBool = false;
        canMove = true;
        bulletUI = GameObject.Find("BulletQ");
        bulletQuantity = bulletUI.GetComponent<Text>();
        numOfBullets = 0;
        isLoading = true;
        myBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        jumpAudio = GetComponent<AudioSource>();
        tempPos = transform.position;
        startingPos = transform.position;
        startingPosition = transform.position;
        isGrounded = false;
        tempFlip = transform.localScale.x;
        gunFire = GameObject.Find("GunFire");
        gunFire.SetActive(false);
        gunTimer = 0.1f;
        gunTimer2 = 0.5f;
        gunActive = false;
        gunActive2 = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isLoading == false){
            IncognitoMovement();
            IncognitoJump();
            IncognitoHit();
            IncognitoShoot();
            BulletControl();
        }
    }

    void BulletControl(){
        
        bulletQuantity.text = numOfBullets.ToString();
        if(gunActive == true){
            gunTimer -= Time.deltaTime;
            if(gunTimer < 0.1f){
                gunFire.SetActive(true);
                gunSound.Play();
                // Instantiate(flyBullet, flyBulletPos.position, Quaternion.identity);
                if(gunTimer < 0f){
                    gunTimer = 0.1f;
                    gunActive = false;
                    gunFire.SetActive(false);
                    //gunSound.Stop();
                }
            }
        }
        if(gunActive2 == true){
            gunTimer2 -= Time.deltaTime;
            if(gunTimer2 < 0f){
                gunTimer2 = 0.5f;
                gunActive2 = false;
            }
        }
    }

    void IncognitoMovement(){
        if(canMove == true){
            if(Input.GetKeyDown(KeyCode.RightArrow) && tempFlip == -0.5f){
                transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow) && tempFlip == 0.5f){
                transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
            }
            if(Input.GetAxisRaw("Horizontal") > 0){
                if(transform.position.x < XBorderMax){
                    tempPos = transform.position;
                    tempPos.x += speed * Time.deltaTime;
                    transform.position = tempPos;
                }
                else{
                    transform.position = transform.position;
                }
                //sr.flipX = false;
                tempFlip = 0.5f;
                transform.localScale = new Vector3(tempFlip, transform.localScale.y, transform.localScale.z);
                animator.SetBool("RunParam", true);
            }
            else if(Input.GetAxisRaw("Horizontal") < 0){
                if(transform.position.x > XBorderMin){
                    tempPos = transform.position;
                    tempPos.x -= speed * Time.deltaTime;
                    transform.position = tempPos;
                }
                else{
                    transform.position = transform.position;
                }
                //sr.flipX = true;
                tempFlip = -0.5f;
                transform.localScale = new Vector3(tempFlip, transform.localScale.y, transform.localScale.z);
                animator.SetBool("RunParam", true);
            }
            else {
                animator.SetBool("RunParam", false);
            }
        }
    }

    void IncognitoJump(){
        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true){
            myBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("JumpParam", true);
            audioJump.Play();
            isGrounded = false;
        }
        else {
            animator.SetBool("JumpParam", false);
        }
    }

    void IncognitoHit(){
        if(Input.GetKeyDown(KeyCode.Space)){
            animator.SetBool("HitParam", true);
            audioHit.Play();
            Collider2D[] enemy = Physics2D.OverlapCircleAll(attackPoint.transform.position, radius, enemies);

            foreach(Collider2D enemyGameobject in enemy){
                Debug.Log("Attacked");
                BossHealth.newHealth -= 0.5f;
                Destroy(enemyGameobject.gameObject, 0.3f);
                audioEnemyKill.Play();
            }
        }
        else {
            animator.SetBool("HitParam", false);
        }
    }

    void IncognitoShoot(){
        if(Input.GetKeyDown(KeyCode.DownArrow) && gunActive2 == false && numOfBullets > 0){
            animator.SetBool("ShootParam", true);
            gunActive = true;
            gunActive2 = true;
            numOfBullets -= 1;
            Instantiate(flyBullet, flyBulletPos.position, Quaternion.identity);
        }
        else {
            animator.SetBool("ShootParam", false);
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Ground"){
            isGrounded = true;
        }
        if(other.gameObject.name == "Underground1"){
            transform.position = startingPosition;
            Health.incognitoHealth -= 1;
        }
        if(other.gameObject.name == "Finish"){
            Debug.Log("Mission Completed");
            if(SceneManager.GetActiveScene().name == "Level1")
            Achieve.score1 = Coin.incognitoScore;
            if(SceneManager.GetActiveScene().name == "Level2")
            Achieve.score2 = Coin.incognitoScore;
            if(SceneManager.GetActiveScene().name == "Level3")
            Achieve.score3 = Coin.incognitoScore;
            if(SceneManager.GetActiveScene().name == "Level4")
            Achieve.score4 = Coin.incognitoScore;
            if(SceneManager.GetActiveScene().name == "Level5")
            Achieve.score5 = Coin.incognitoScore;
            if(SceneManager.GetActiveScene().name == "Level6")
            Achieve.score6 = Coin.incognitoScore;
            if(SceneManager.GetActiveScene().name == "Level7")
            Achieve.score7 = Coin.incognitoScore;
            if(SceneManager.GetActiveScene().name == "Level8")
            Achieve.score8 = Coin.incognitoScore;
            if(Coin.incognitoScore != 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            NewHealth.newHealth = 5;
            Coin.incognitoScore = 0;
        }
        if(other.gameObject.tag == "Enemy"){
            transform.position = startingPos;
            NewHealth.newHealth -= 0.5f;
        }
        if(other.gameObject.tag == "Mummy"){
            transform.position = startingPos;
            NewHealth.newHealth -= 0.5f;
        }
        if(other.gameObject.tag == "SmallEnemy"){
            transform.position = startingPos;
            NewHealth.newHealth -= 1f;
        }
        if(other.gameObject.tag == "Jumper"){
            animator.SetBool("JumpParam", true);
            audioJump.Play();
            myBody.velocity = new Vector2(0,10);
            isGrounded = false;
        }
        if(other.gameObject.tag == "Slider"){
            myBody.velocity = new Vector2(5,-5);
            isGrounded = false;
        }
        if(other.gameObject.name == "Lift"){
            animator.Play("Idle");
        }
        if(other.gameObject.name == "Plat10"){
            //Vector2 slideRight = new Vector2(100, 0);
            //Vector2 slideLeft = new Vector2(-100, 0);
            if(Input.GetAxisRaw("Horizontal") > 0 || transform.localScale.x == 0.5f)
            myBody.velocity = new Vector2(2, myBody.velocity.y);
            //myBody.AddForce(slideRight, ForceMode2D.Force);
            if(Input.GetAxisRaw("Horizontal") < 0  || transform.localScale.x == -0.5f)
            myBody.velocity = new Vector2(-2, myBody.velocity.y);
            //myBody.AddForce(slideLeft, ForceMode2D.Force);
        }
    }
    void OnCollisionStay2D(Collision2D other){
        if(other.gameObject.name == "Plat10"){
            //Vector2 slideRight = new Vector2(100, 0);
            //Vector2 slideLeft = new Vector2(-100, 0);
            if(Input.GetAxisRaw("Horizontal") > 0)
            myBody.velocity = new Vector2(2, myBody.velocity.y);
            //myBody.AddForce(slideRight, ForceMode2D.Force);
            if(Input.GetAxisRaw("Horizontal") < 0)
            myBody.velocity = new Vector2(-2, myBody.velocity.y);
            //myBody.AddForce(slideLeft, ForceMode2D.Force);
        }
    }
    void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.name == "Plat10"){
            myBody.velocity = new Vector2(0, myBody.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "AddHeart" && NewHealth.newHealth == 5f){
            audioFullHealth.Play();
        }
        if(other.gameObject.tag == "Enemy"){
            
            transform.position = startingPosition;
            NewHealth.newHealth -= 0.5f;
        }
        if(other.gameObject.tag == "Mummy"){
            transform.position = startingPos;
            NewHealth.newHealth -= 0.5f;
        }
        if(other.gameObject.tag == "SmallEnemy"){
            transform.position = startingPos;
            NewHealth.newHealth -= 1f;
        }
        if(other.gameObject.tag == "Boss"){
            transform.position = startingPos;
            NewHealth.newHealth -= 1f;
        }
    }

    private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(attackPoint.transform.position, radius);
    }
 
}
