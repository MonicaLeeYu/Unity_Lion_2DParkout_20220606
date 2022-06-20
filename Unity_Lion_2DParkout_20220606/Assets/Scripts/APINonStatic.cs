using UnityEngine; //刪除不必要的using
namespace MonicaLeeNonStatic //增加命名空間
{
    /// <summary>
    /// API 非靜態屬性與方法
    /// 與靜態最大的不同即是需要一個實體物件且此物件一定會存在於場景上
    /// </summary>
    public class APINonStatic : MonoBehaviour //把這個區塊內容清空，再拖拉到命名空間裡面
    {
        //1.定義欄位:GameObject資料型態為類別
        //2.使用非靜態API語法定義欄位名稱turtle
        //3.確定Unity上的屬性面板非空值None，把忍者龜拖拉到turtle
        [SerializeField] //序列化
        private GameObject turtle;

        private void Start()
        {
            //使用非靜態屬性Start
            //1.取得
            //語法 :
            //欄位名稱,非靜態屬性

            print("忍者龜的啟動狀態 =" + turtle.activeInHierarchy);
            print("忍者龜的圖層 =" + turtle.layer);

            //2.設定非靜態屬性，可以篩選藍色的方塊
            //語法 :
            //欄位名稱,非靜態屬性 = (指定)值;

            //turtle.activeInHierarchy = false; //官方網站未註明read only,但測試結果卻是read only
            turtle.layer = 4; //指定值只能是Layer裡面已存在的選項，執行時忍者龜的Layer會變成water
            turtle.tag = "Player"; //指定字串只能是Tag裡面已存在的選項，注意大小寫，執行時忍者龜的tag會變成Player

            //3.設定非靜態方法，可以篩選紫色的立方塊
            //語法 :
            //欄位名稱,非靜態方法 (對應的引數);
            turtle.SetActive(false); //執行時忍者龜的勾勾會被取消

        }

    }
}


