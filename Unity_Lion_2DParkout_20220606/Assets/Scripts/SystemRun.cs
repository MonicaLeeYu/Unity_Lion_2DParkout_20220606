using UnityEngine; //�ޥ�unity�����R�W�Ŷ�(API)

namespace MonicaLee
{
    /*C#�q�H�U���Ź��ܦ����骫��A�B�J�p�U
     * 1. �I������W���C�����⪫��(Game Object�Ǧ�u�����)
     * 2. �bInspector�̤U���I��Add Component�N��C#�}���W��SystemRun���b�Ӫ����ܦ�����
     */
    /// <summary>
    /// �]�B�{��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����
        /*��� Field : �O�s��k 
         * private float speedRun = 3.5f;�o�ˤ@��N�O�@�����
         * �y�k : �׹��� ��쪺������� ���ۭq�W��(�Ǧ�) =���w �w�]��);
         * �׹��� : �������}�M�p�H
         * ���}public: ��ܦb���O�A���\��L���O�s��
         * �p�Hprivate: ����ܦb���O�A�����\��L���O�s��(�ʸ�)
         */

        /*[]���A������Attritube�ݩʡA�ε��ѵ��B�~�\��
         * SerializeField�ǦC�����:�N�p�H�����ܦb���O�W�A�i�H�W�[���Ѽ��D�B���ܡB�d��
         * Header���D : �i�H�ϥΤ��� ("�]�B�t��")
         * Tooltip���� : �i�H�ϥΤ���("����Ԫ��t���]�B�t��")
         * Range�d�� : �ȭ��ƭ��������(0,100)
         */
        [SerializeField, Header("�]�B�t��"), Tooltip("����Ԫ��t���]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region �\��:��@�Өt�Ϊ�������k
        /// <summary>
        /// �]�B�\��
        /// </summary>
        //��kMethod, �ߺD�H�j�g�}�Y�R�W
        //�y�k : �׹��� �Ǧ^���A ��k�W��(�Ѽ�){�{��}
        private void Run()
        {
            print("�]�B��~");
            //�ݩ�.��k velocity ���w new�@�ӤG���y��
            rig.velocity = new Vector2(speedRun, rig.velocity.y); //()���i�H�������ȡA�]�i�H�����ݩʭn�վ㪽���b���O�W�վ�Y�i
        }
        #endregion

        #region �ƥ�:�{���J�f
        /* Awake�@�w�n���bStart���e
         * �B�b�C������C���ɷ|����@��
         * �bAni�i�H�ݨ�Ԫ��t(Animator)�MRig�̬ݨ�Ԫ��t(Rigidbody 2D)
         */
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();//�]�i�H�b�ݩʭ��O�����ԤJ
        }
        /* �}�l�ƥ�: ����C���ɷ|����@��
         * ��l�Ƴ]�w�A�Ҧp:��l�ƥͩR�ȩΪ�l�ƫe���ȵ���
         */
        private void Start()
        {
            //print("WELCOME TO MONICA GAME WORLD");//��play�|�b�̤U�誺����O���
        }
        /* ������OConsole�Ԩ�Inspector�U��A��ܪ��T�����ӷ|�`�`�ݭn�Ѧ�
         * ��s�ƥ�:�j���C�����60�� 60FPS Frame per second
         */
        private void Update()
        {
            //print("<Color=yellow> �ƥ���椤�ó]�w�����C�� </Color>");
            //�I�s��k���y�k : ��k�W��(�������޼�);
            Run();

        }

        #endregion

    }
}


