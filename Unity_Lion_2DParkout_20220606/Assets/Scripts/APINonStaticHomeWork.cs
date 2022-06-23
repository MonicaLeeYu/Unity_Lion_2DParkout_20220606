using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APINonStaticHomeWork : MonoBehaviour
{
    /// <summary>
    /// 回家作業:C# 非靜態屬性與方法練習 2022.06.20
    /// </summary>
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private GameObject sphere;
    [SerializeField]
    private GameObject capsule;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private SphereCollider spherecollid;
    [SerializeField]
    private Transform capsuleTransf;
    [SerializeField]
    private Transform sphereRotate;
    [SerializeField]
    private Rigidbody capsuleRigbdy;

    // Start is called before the first frame update
    void Start()
    {
        print("攝影機深度 (Depth) = " + cam.depth);
        print("球體碰撞器半徑 = " + spherecollid.radius);

        cam.backgroundColor = Random.ColorHSV();
        print("攝影機的背景顏色指定為隨機顏色 = " + cam.backgroundColor);

        capsuleTransf.localScale = new Vector3(3, 2, 1);
        print("膠囊體尺寸改為 3, 2, 1 = " + capsuleTransf.localScale);

        //capsuleRigbdy = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //讓立方體看著球體旋轉
        sphereRotate.RotateAround(sphere.transform.position, Vector3.up, 100 * Time.deltaTime);//球體旋轉
        cube.transform.LookAt(sphere.transform.position, Vector3.right);//讓立方體看著球體
        
        //讓膠囊體往上產生推力
        capsuleRigbdy.AddForce(new Vector3(0, 3, 0));

    }
}
