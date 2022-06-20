using UnityEngine;

namespace MonicaLeeAPIStatic
{
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region �Ұ�m��
            //get
            print("�H����= " + Random.value);
            print("���oPI = " + Mathf.PI);
            print("���o�L���j = " + Mathf.Infinity);


            //set
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0.9f, -1.0f);
            Time.timeScale = 0.8f;

            float range = Random.Range(20.5f, 100.0f);
            print("RandomRange = " + range);

            int rangeInt = Random.Range(1, 3);
            print("RandomRangeInt = " + rangeInt);
            #endregion


            int allcamerascount = Camera.allCamerasCount;
            print("�Ҧ���v�� = " + allcamerascount);
            print("���ε{�������x = " + Application.platform);

            print("���z�ίv�{�ɭȳ]�w�� = " + Physics.sleepThreshold);

            Time.timeScale = 0.8f;
            print("�ɶ��j�p�]�w�� 0.8 (�C�ʧ@) = " + Time.timeScale);
            Mathf.Round(9.999f);
            print("��9.999�h�p���I(�|�ˤ��J) = " + Mathf.Round(9.999f));
            Mathf.Ceil(9.999f);
            print("��9.999�h�p���I(�L����i��) = " + Mathf.Ceil(9.999f));
            Mathf.Floor(9.999f);
            print("��9.999�h�p���I(�L����˥h) = " + Mathf.Floor(9.999f));

            float dist = Vector3.Distance(a, b);
            print("<color=red>���o���I���Z�� = " + dist + "</color>");

            Application.OpenURL("https://unity.com/"); //�}�ҳs�����}

        }
        private void Update()
        {
            #region �Ұ�m��
            int rangeInt = Random.Range(1, 3);
            print("RandomRangeInt = " + rangeInt);
            #endregion
            //print("�O�_��J���N�� = " + Input.anyKeyDown);
            //print("�C���g�L�ɶ� = " + Time.timeSinceLevelLoad);
            print("<color=lightblue>�O�_���U����(���w���ť���) = " + Input.GetKeyDown(KeyCode.Space) + "</color>");
        }
    }
}


