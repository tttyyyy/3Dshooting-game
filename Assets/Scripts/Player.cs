using UnityEngine;

public enum PlayerAnimationState
{
    walk = 6,idle = 1,run = 10,run_L = 11,run_R = 12
}



public class Player : MonoBehaviour
{
    Animator animator;
    public float speed;//速度
    public float rotspeed = 10;//rot速度

    public PlayerAnimationState playeranimationstate;

    private void Start()
    {
        animator = GetComponent<Animator>();  
    }
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
       
        Quaternion rot = transform.rotation;
        Vector3 rotEuler = rot.eulerAngles;
        rotEuler.y += h;
        transform.rotation = Quaternion.Euler(rotEuler);


        //transform.Translate(transform.forward * Time.deltaTime * speed * v);
        transform.position += (transform.forward * Time.deltaTime * speed * v);


        //transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * speed);
        //transform.LookAt(new Vector3(h, 0, v) + transform.position);  
        if (h < 0)
        {
            playeranimationstate = PlayerAnimationState.run_L;
        }
        if (h > 0)
        {
            playeranimationstate = PlayerAnimationState.run_R;
        }
        if (v > 0)
        {
            playeranimationstate = PlayerAnimationState.run;
        }
       
        if(h == 0 && v == 0)
        {

            playeranimationstate = PlayerAnimationState.idle;
        }
        animator.SetInteger("animation", (int)playeranimationstate);
        //switch (playeranimationstate)
        //{
        //    case PlayerAnimationState.walk:
        //        animator.SetInteger("animation", 6);
        //        break;
        //    case PlayerAnimationState.idle:
        //        animator.SetInteger("animation", 1);
        //        break;
        //    case PlayerAnimationState.run:
        //        animator.SetInteger("animation", 10);
        //        break;
        //    default:
        //        break;
        //}

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                switch (hitInfo.collider.tag)
                {
                    case "Cube1":
                        UIManager.Instance.ShowDesPanel("Cube1");
                        break;
                    case "Cube2":
                        UIManager.Instance.ShowDesPanel("Cube2");
                        break;
                    case "Cube3":
                        UIManager.Instance.ShowDesPanel("Cube3");
                        break;
                    case "Cube4":
                        UIManager.Instance.ShowDesPanel("Cube4");
                        break;
                    case "Cube5":
                        UIManager.Instance.ShowDesPanel("Cube5");
                        break;
                }
            }
        }
    }
}
