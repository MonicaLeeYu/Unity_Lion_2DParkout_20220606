using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;//�]���s�C���A�ҥH�W�[�ޥγ����޲zAPI

namespace MonicaLee
{
    /// <summary>
    /// �޲z�����e��
    /// �L���P����
    /// </summary>
   

    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// �C���������D��r���e
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;
            InvokeRepeating("FadeIn", 0, 0.2f);
        }
        /// <summary>
        /// �H�J
        /// </summary>
        private void FadeIn()
        {
            groupFinal.alpha += 0.1f;
            print("�H�J~"); 

            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                

                CancelInvoke("FadeIn");
            }
        }
        /// <summary>
        /// ���}�C��
        /// </summary>
        //1.�w�q���}��k
        //2.Button On Click�]�w�}�������}��k
        public void Quit()
        {
            print("���}�C��");

            Application.Quit();
        }
        /// <summary>
        /// ���s�C��
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("�C������");
        }

    }
}

