using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APINonStaticHomeWork : MonoBehaviour
{
    /// <summary>
    /// �^�a�@�~:C# �D�R�A�ݩʻP��k�m�� 2022.06.20
    /// </summary>
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private GameObject cube2;
    [SerializeField]
    private GameObject sphere;
    [SerializeField]
    private GameObject sphere2;
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
    [SerializeField]
    private Transform cube2Rotate;

    // Start is called before the first frame update
    void Start()
    {
        print("��v���`�� (Depth) = " + cam.depth);
        print("�y��I�����b�| = " + spherecollid.radius);

        cam.backgroundColor = Random.ColorHSV();
        print("��v�����I���C����w���H���C�� = " + cam.backgroundColor);

        capsuleTransf.localScale = new Vector3(3, 2, 1);
        print("���n��ؤo�אּ 3, 2, 1 = " + capsuleTransf.localScale);

        //capsuleRigbdy = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //���ߤ���ݵ۲y�����
        sphereRotate.RotateAround(sphere.transform.position, Vector3.up, 100 * Time.deltaTime);//�y�����
        cube.transform.LookAt(sphere.transform.position, Vector3.right);//���ߤ���ݵ۲y��

        /*���ߤ���ݵ۲y���¶�۲y�����
        cube2.transform.LookAt(sphere2.transform.position, Vector3.left);//���ߤ���ݵ۲y��
        cube2Rotate.RotateAround(sphere2.transform.position, Vector3.back, 10 * Time.deltaTime);//�ߤ���¶�۲y����
        */

        //�����n�驹�W���ͱ��O
        capsuleRigbdy.AddForce(new Vector3(0, 3, 0));

    }
}
