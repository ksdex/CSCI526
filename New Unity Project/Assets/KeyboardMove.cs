using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
 private Vector3 m_camRot;
 private Transform m_camTransform;//摄像机Transform
 private Transform m_transform;//摄像机父物体Transform
 public float m_movSpeed=10;//移动系数
 public float m_rotateSpeed=1;//旋转系数
    // Start is called before the first frame update
    void Start()
    {
        m_camTransform = Camera.main.transform;
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // 定义3个值控制移动
        float xm = 0, ym = 0;
          
        //按键盘W向上移动
        if (Input.GetKey(KeyCode.W))
        {
         ym += m_movSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))//按键盘S向下移动
        {
         ym -= m_movSpeed * Time.deltaTime;
        }
          
        if (Input.GetKey(KeyCode.A))//按键盘A向左移动
        {
         xm -= m_movSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))//按键盘D向右移动
        {
         xm += m_movSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) && m_transform.position.y <= 3)
        {
         ym+=m_movSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F) && m_transform.position.y >= 1)
        {
         ym -= m_movSpeed * Time.deltaTime;
        }
        m_transform.Translate(new Vector2(xm,ym),Space.Self);
    }
}

