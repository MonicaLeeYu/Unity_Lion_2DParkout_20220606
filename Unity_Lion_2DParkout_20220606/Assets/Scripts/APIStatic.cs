using UnityEngine;

namespace MonicaLeeAPIStatic
{
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            #region �Ұ�m��
            //get
            print("�H����= "+ Random.value);
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
            print("allcamerascount = " + allcamerascount);
            print("���ε{�������x" + Application.platform);

        }
        private void Update()
        {
            #region �Ұ�m��
            int rangeInt = Random.Range(1, 3);
            print("RandomRangeInt = " + rangeInt);
            #endregion
        }
    }
}


