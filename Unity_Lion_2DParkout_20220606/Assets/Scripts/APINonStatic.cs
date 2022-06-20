using UnityEngine; //�R�������n��using
namespace MonicaLeeNonStatic //�W�[�R�W�Ŷ�
{
    /// <summary>
    /// API �D�R�A�ݩʻP��k
    /// �P�R�A�̤j�����P�Y�O�ݭn�@�ӹ��骫��B������@�w�|�s�b������W
    /// </summary>
    public class APINonStatic : MonoBehaviour //��o�Ӱ϶����e�M�šA�A��Ԩ�R�W�Ŷ��̭�
    {
        //1.�w�q���:GameObject��ƫ��A�����O
        //2.�ϥΫD�R�AAPI�y�k�w�q���W��turtle
        //3.�T�wUnity�W���ݩʭ��O�D�ŭ�None�A��Ԫ��t��Ԩ�turtle
        [SerializeField] //�ǦC��
        private GameObject turtle;

        private void Start()
        {
            //�ϥΫD�R�A�ݩ�Start
            //1.���o
            //�y�k :
            //���W��,�D�R�A�ݩ�

            print("�Ԫ��t���Ұʪ��A =" + turtle.activeInHierarchy);
            print("�Ԫ��t���ϼh =" + turtle.layer);

            //2.�]�w�D�R�A�ݩʡA�i�H�z���Ŧ⪺���
            //�y�k :
            //���W��,�D�R�A�ݩ� = (���w)��;

            //turtle.activeInHierarchy = false; //�x�����������read only,�����յ��G�o�Oread only
            turtle.layer = 4; //���w�ȥu��OLayer�̭��w�s�b���ﶵ�A����ɧԪ��t��Layer�|�ܦ�water
            turtle.tag = "Player"; //���w�r��u��OTag�̭��w�s�b���ﶵ�A�`�N�j�p�g�A����ɧԪ��t��tag�|�ܦ�Player

            //3.�]�w�D�R�A��k�A�i�H�z�ﵵ�⪺�ߤ��
            //�y�k :
            //���W��,�D�R�A��k (�������޼�);
            turtle.SetActive(false); //����ɧԪ��t���Ĥķ|�Q����

        }

    }
}


