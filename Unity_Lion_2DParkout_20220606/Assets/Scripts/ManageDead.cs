
using UnityEngine;

namespace MonicaLee
{
    /// <summary>
    /// 管理死亡 
    /// </summary>
    public class ManageDead : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者龜";
        [SerializeField, Header("結束管理器")]
        private ManageFinal manageFinal;
        [SerializeField, Header("CM攝影機控制物件")]
        private GameObject goCM;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains(nameTarget))
            {
                manageFinal.stringTitle = "挑戰失敗! 人生是沒有那麼容易的...  哈哈哈...";
                manageFinal.enabled = true;
                goCM.SetActive(false);
            }
        }

        



    }
}

