using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;//因重新遊戲，所以增加引用場景管理API

namespace MonicaLee
{
    /// <summary>
    /// 管理結束畫面
    /// 過關與失敗
    /// </summary>
   

    public class ManageFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// 遊戲結束標題文字內容
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;
            InvokeRepeating("FadeIn", 0, 0.2f);
        }
        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            groupFinal.alpha += 0.1f;
            print("淡入~"); 

            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
                

                CancelInvoke("FadeIn");
            }
        }
        /// <summary>
        /// 離開遊戲
        /// </summary>
        //1.定義公開方法
        //2.Button On Click設定腳本的公開方法
        public void Quit()
        {
            print("離開遊戲");

            Application.Quit();
        }
        /// <summary>
        /// 重新遊戲
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("遊戲場景");
        }

    }
}

