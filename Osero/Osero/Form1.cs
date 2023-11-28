namespace Osero
{

    public partial class Form1 : Form
    {

        //�I�Z���Ɏg�p����F
        public const string OTHELLO_COLOR1 = "Black";
        public const string OTHELLO_COLOR2 = "White";

        //�e�R�}�̖��O
        readonly Button PIECE_1A;
        readonly Button PIECE_1B;
        readonly Button PIECE_1C;
        readonly Button PIECE_1D;
        readonly Button PIECE_1E;
        readonly Button PIECE_1F;
        readonly Button PIECE_1G;
        readonly Button PIECE_1H;
        readonly Button PIECE_2A;
        readonly Button PIECE_2B;
        readonly Button PIECE_2C;
        readonly Button PIECE_2D;
        readonly Button PIECE_2E;
        readonly Button PIECE_2F;
        readonly Button PIECE_2G;
        readonly Button PIECE_2H;
        readonly Button PIECE_3A;
        readonly Button PIECE_3B;
        readonly Button PIECE_3C;
        readonly Button PIECE_3D;
        readonly Button PIECE_3E;
        readonly Button PIECE_3F;
        readonly Button PIECE_3G;
        readonly Button PIECE_3H;
        readonly Button PIECE_4A;
        readonly Button PIECE_4B;
        readonly Button PIECE_4C;
        readonly Button PIECE_4D;
        readonly Button PIECE_4E;
        readonly Button PIECE_4F;
        readonly Button PIECE_4G;
        readonly Button PIECE_4H;
        readonly Button PIECE_5A;
        readonly Button PIECE_5B;
        readonly Button PIECE_5C;
        readonly Button PIECE_5D;
        readonly Button PIECE_5E;
        readonly Button PIECE_5F;
        readonly Button PIECE_5G;
        readonly Button PIECE_5H;
        readonly Button PIECE_6A;
        readonly Button PIECE_6B;
        readonly Button PIECE_6C;
        readonly Button PIECE_6D;
        readonly Button PIECE_6E;
        readonly Button PIECE_6F;
        readonly Button PIECE_6G;
        readonly Button PIECE_6H;
        readonly Button PIECE_7A;
        readonly Button PIECE_7B;
        readonly Button PIECE_7C;
        readonly Button PIECE_7D;
        readonly Button PIECE_7E;
        readonly Button PIECE_7F;
        readonly Button PIECE_7G;
        readonly Button PIECE_7H;
        readonly Button PIECE_8A;
        readonly Button PIECE_8B;
        readonly Button PIECE_8C;
        readonly Button PIECE_8D;
        readonly Button PIECE_8E;
        readonly Button PIECE_8F;
        readonly Button PIECE_8G;
        readonly Button PIECE_8H;


        public static string Othello_Turn = "Black_Turn"; //�I�Z���̏��ԁ@�����l�́A��
        Boolean Exisitng_Check;             //��u���Ă��邩�̃`�F�b�N

        public Form1()
        {
            InitializeComponent();
            PIECE_1A = button1a;
            PIECE_1B = button1b;
            PIECE_1C = button1c;
            PIECE_1D = button1d;
            PIECE_1E = button1e;
            PIECE_1F = button1f;
            PIECE_1G = button1g;
            PIECE_1H = button1h;
            PIECE_2A = button2a;
            PIECE_2B = button2b;
            PIECE_2C = button2c;
            PIECE_2D = button2d;
            PIECE_2E = button2e;
            PIECE_2F = button2f;
            PIECE_2G = button2g;
            PIECE_2H = button2h;
            PIECE_3A = button3a;
            PIECE_3B = button3b;
            PIECE_3C = button3c;
            PIECE_3D = button3d;
            PIECE_3E = button3e;
            PIECE_3F = button3f;
            PIECE_3G = button3g;
            PIECE_3H = button3h;
            PIECE_4A = button4a;
            PIECE_4B = button4b;
            PIECE_4C = button4c;
            PIECE_4D = button4d;
            PIECE_4E = button4e;
            PIECE_4F = button4f;
            PIECE_4G = button4g;
            PIECE_4H = button4h;
            PIECE_5A = button5a;
            PIECE_5B = button5b;
            PIECE_5C = button5c;
            PIECE_5D = button5d;
            PIECE_5E = button5e;
            PIECE_5F = button5f;
            PIECE_5G = button5g;
            PIECE_5H = button5h;
            PIECE_6A = button6a;
            PIECE_6B = button6b;
            PIECE_6C = button6c;
            PIECE_6D = button6d;
            PIECE_6E = button6e;
            PIECE_6F = button6f;
            PIECE_6G = button6g;
            PIECE_6H = button6h;
            PIECE_7A = button7a;
            PIECE_7B = button7b;
            PIECE_7C = button7c;
            PIECE_7D = button7d;
            PIECE_7E = button7e;
            PIECE_7F = button7f;
            PIECE_7G = button7g;
            PIECE_7H = button7h;
            PIECE_8A = button8a;
            PIECE_8B = button8b;
            PIECE_8C = button8c;
            PIECE_8D = button8d;
            PIECE_8E = button8e;
            PIECE_8F = button8f;
            PIECE_8G = button8g;
            PIECE_8H = button8h;

        }

        //���������݂ɍs���֐�
        //����ɂ���ꍇ�́A�Ђ�����Ԃ�Ȃ��悤�ɂ��Ă���B
        public void Turn_Change(Button btn)
        {
            //���ɋ�u���Ă���ꍇ�́A�I��
            if (btn.Text != "")
            {
                Exisitng_Check = true;
                return;
            }
            if (Othello_Turn == "Black_Turn")
            {
                //�t�H���g�����ɕύX
                btn.ForeColor = Color.FromName(OTHELLO_COLOR1);
                //�e�L�X�g�ύX
                btn.Text = "��";
                Othello_Turn = "White_Turn";
                Exisitng_Check = false;
            }
            else
            {
                //�t�H���g�𔒂ɕύX
                btn.ForeColor = Color.FromName(OTHELLO_COLOR2);
                //�e�L�X�g�ύX
                btn.Text = "��";
                Othello_Turn = "Black_Turn";
                Exisitng_Check = false;
            }
        }

        //�󗓂̋���邩�ǂ������`�F�b�N(�ȒP�ɕ\�������@�͂Ȃ����H�j
        //�Ȃ���΃Q�[���I�� ������Ԃփ��Z�b�g
        public void Empty_Check()
        {
            if (PIECE_1A.Text == "")
            {
                return;
            }
            else if (PIECE_1B.Text == "")
            {
                return;
            }
            else if (PIECE_1C.Text == "")
            {
                return;
            }
            else if (PIECE_1D.Text == "")
            {
                return;
            }
            else if (PIECE_1E.Text == "")
            {
                return;
            }
            else if (PIECE_1F.Text == "")
            {
                return;
            }
            else if (PIECE_1G.Text == "")
            {
                return;
            }
            else if (PIECE_1H.Text == "")
            {
                return;
            }
            else if (PIECE_2A.Text == "")
            {
                return;
            }
            else if (PIECE_2B.Text == "")
            {
                return;
            }
            else if (PIECE_2C.Text == "")
            {
                return;
            }
            else if (PIECE_2D.Text == "")
            {
                return;
            }
            else if (PIECE_2E.Text == "")
            {
                return;
            }
            else if (PIECE_2F.Text == "")
            {
                return;
            }
            else if (PIECE_2G.Text == "")
            {
                return;
            }
            else if (PIECE_2H.Text == "")
            {
                return;
            }
            else if (PIECE_3A.Text == "")
            {
                return;
            }
            else if (PIECE_3B.Text == "")
            {
                return;
            }
            else if (PIECE_3C.Text == "")
            {
                return;
            }
            else if (PIECE_3D.Text == "")
            {
                return;
            }
            else if (PIECE_3E.Text == "")
            {
                return;
            }
            else if (PIECE_3F.Text == "")
            {
                return;
            }
            else if (PIECE_3G.Text == "")
            {
                return;
            }
            else if (PIECE_3H.Text == "")
            {
                return;
            }
            else if (PIECE_4A.Text == "")
            {
                return;
            }
            else if (PIECE_4B.Text == "")
            {
                return;
            }
            else if (PIECE_4C.Text == "")
            {
                return;
            }
            else if (PIECE_4F.Text == "")
            {
                return;
            }
            else if (PIECE_4G.Text == "")
            {
                return;
            }
            else if (PIECE_4H.Text == "")
            {
                return;
            }
            else if (PIECE_5A.Text == "")
            {
                return;
            }
            else if (PIECE_5B.Text == "")
            {
                return;
            }
            else if (PIECE_5C.Text == "")
            {
                return;
            }
            else if (PIECE_5F.Text == "")
            {
                return;
            }
            else if (PIECE_5G.Text == "")
            {
                return;
            }
            else if (PIECE_5H.Text == "")
            {
                return;
            }
            else if (PIECE_6A.Text == "")
            {
                return;
            }
            else if (PIECE_6B.Text == "")
            {
                return;
            }
            else if (PIECE_6C.Text == "")
            {
                return;
            }
            else if (PIECE_6D.Text == "")
            {
                return;
            }
            else if (PIECE_6E.Text == "")
            {
                return;
            }
            else if (PIECE_6F.Text == "")
            {
                return;
            }
            else if (PIECE_6G.Text == "")
            {
                return;
            }
            else if (PIECE_6H.Text == "")
            {
                return;
            }
            else if (PIECE_7A.Text == "")
            {
                return;
            }
            else if (PIECE_7B.Text == "")
            {
                return;
            }
            else if (PIECE_7C.Text == "")
            {
                return;
            }
            else if (PIECE_7D.Text == "")
            {
                return;
            }
            else if (PIECE_7E.Text == "")
            {
                return;
            }
            else if (PIECE_7F.Text == "")
            {
                return;
            }
            else if (PIECE_7G.Text == "")
            {
                return;
            }
            else if (PIECE_7H.Text == "")
            {
                return;
            }
            else if (PIECE_8A.Text == "")
            {
                return;
            }
            else if (PIECE_8B.Text == "")
            {
                return;
            }
            else if (PIECE_8C.Text == "")
            {
                return;
            }
            else if (PIECE_8D.Text == "")
            {
                return;
            }
            else if (PIECE_8E.Text == "")
            {
                return;
            }
            else if (PIECE_8F.Text == "")
            {
                return;
            }
            else if (PIECE_8G.Text == "")
            {
                return;
            }
            else if (PIECE_8H.Text == "")
            {
                return;
            }

            //�Q�[���I���A���ʏW�v
            result();

            //���ʉ�ʂ֑J��
            this.Enabled = false;
            result form = new result(Black_Point, White_Point);
            form.ShowDialog();
            this.Enabled = true;

            //���Z�b�g
            Game_Finish();



        }

        //�Q�[���I���֐�
        public void Game_Finish()
        {

            //���Z�b�g
            button4d.ForeColor = Color.FromName(OTHELLO_COLOR1);
            button4e.ForeColor = Color.FromName(OTHELLO_COLOR2);
            button5d.ForeColor = Color.FromName(OTHELLO_COLOR2);
            button5e.ForeColor = Color.FromName(OTHELLO_COLOR1);

            Othello_Turn = "Black_Turn";

            PIECE_1A.Text = "";
            PIECE_1B.Text = "";
            PIECE_1C.Text = "";
            PIECE_1D.Text = "";
            PIECE_1E.Text = "";
            PIECE_1F.Text = "";
            PIECE_1G.Text = "";
            PIECE_1H.Text = "";
            PIECE_2A.Text = "";
            PIECE_2B.Text = "";
            PIECE_2C.Text = "";
            PIECE_2D.Text = "";
            PIECE_2E.Text = "";
            PIECE_2F.Text = "";
            PIECE_2G.Text = "";
            PIECE_2H.Text = "";
            PIECE_3A.Text = "";
            PIECE_3B.Text = "";
            PIECE_3C.Text = "";
            PIECE_3D.Text = "";
            PIECE_3E.Text = "";
            PIECE_3F.Text = "";
            PIECE_3G.Text = "";
            PIECE_3H.Text = "";
            PIECE_4A.Text = "";
            PIECE_4B.Text = "";
            PIECE_4C.Text = "";
            PIECE_4F.Text = "";
            PIECE_4G.Text = "";
            PIECE_4H.Text = "";
            PIECE_5A.Text = "";
            PIECE_5B.Text = "";
            PIECE_5C.Text = "";
            PIECE_5F.Text = "";
            PIECE_5G.Text = "";
            PIECE_5H.Text = "";
            PIECE_6A.Text = "";
            PIECE_6B.Text = "";
            PIECE_6C.Text = "";
            PIECE_6D.Text = "";
            PIECE_6E.Text = "";
            PIECE_6F.Text = "";
            PIECE_6G.Text = "";
            PIECE_6H.Text = "";
            PIECE_7A.Text = "";
            PIECE_7B.Text = "";
            PIECE_7C.Text = "";
            PIECE_7D.Text = "";
            PIECE_7E.Text = "";
            PIECE_7F.Text = "";
            PIECE_7G.Text = "";
            PIECE_7H.Text = "";
            PIECE_8A.Text = "";
            PIECE_8B.Text = "";
            PIECE_8C.Text = "";
            PIECE_8D.Text = "";
            PIECE_8E.Text = "";
            PIECE_8F.Text = "";
            PIECE_8G.Text = "";
            PIECE_8H.Text = "";
        }

        //���ʏW�v�֐�
        public int Black_Point;
        public int White_Point;


        public void result()
        {
            MessageBox.Show(
           "�Q�[�����I�����܂����B",
           "���m�点",
           MessageBoxButtons.OK
            );

            Black_Point = 0;
            White_Point = 0;

            //1A
            if (PIECE_1A.Text != "" && PIECE_1A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1A.Text != "" && PIECE_1A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //1B
            if (PIECE_1B.Text != "" && PIECE_1B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1B.Text != "" && PIECE_1B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //1C
            if (PIECE_1C.Text != "" && PIECE_1C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1C.Text != "" && PIECE_1C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //1D
            if (PIECE_1D.Text != "" && PIECE_1D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1D.Text != "" && PIECE_1D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //1E
            if (PIECE_1E.Text != "" && PIECE_1E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1E.Text != "" && PIECE_1E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //1F
            if (PIECE_1F.Text != "" && PIECE_1F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1F.Text != "" && PIECE_1F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //1G
            if (PIECE_1G.Text != "" && PIECE_1G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1G.Text != "" && PIECE_1G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //1H
            if (PIECE_1H.Text != "" && PIECE_1H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_1H.Text != "" && PIECE_1H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2A
            if (PIECE_2A.Text != "" && PIECE_2A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2A.Text != "" && PIECE_2A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2B
            if (PIECE_2B.Text != "" && PIECE_2B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2B.Text != "" && PIECE_2B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2C
            if (PIECE_2C.Text != "" && PIECE_2C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2C.Text != "" && PIECE_2C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2D
            if (PIECE_2D.Text != "" && PIECE_2D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2D.Text != "" && PIECE_2D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2E
            if (PIECE_2E.Text != "" && PIECE_2E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2E.Text != "" && PIECE_2E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2F
            if (PIECE_2F.Text != "" && PIECE_2F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2F.Text != "" && PIECE_2F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2G
            if (PIECE_2G.Text != "" && PIECE_2G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2G.Text != "" && PIECE_2G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //2H
            if (PIECE_2H.Text != "" && PIECE_2H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_2H.Text != "" && PIECE_2H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3A
            if (PIECE_3A.Text != "" && PIECE_3A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3A.Text != "" && PIECE_3A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3B
            if (PIECE_3B.Text != "" && PIECE_3B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3B.Text != "" && PIECE_3B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3C
            if (PIECE_3C.Text != "" && PIECE_3C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3C.Text != "" && PIECE_3C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3D
            if (PIECE_3D.Text != "" && PIECE_3D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3D.Text != "" && PIECE_3D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3E
            if (PIECE_3E.Text != "" && PIECE_3E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3E.Text != "" && PIECE_3E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3F
            if (PIECE_3F.Text != "" && PIECE_3F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3F.Text != "" && PIECE_3F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3G
            if (PIECE_3G.Text != "" && PIECE_3G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3G.Text != "" && PIECE_3G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //3H
            if (PIECE_3H.Text != "" && PIECE_3H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_3H.Text != "" && PIECE_3H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4A
            if (PIECE_4A.Text != "" && PIECE_4A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4A.Text != "" && PIECE_4A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4B
            if (PIECE_4B.Text != "" && PIECE_4B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4B.Text != "" && PIECE_4B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4C
            if (PIECE_4C.Text != "" && PIECE_4C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4C.Text != "" && PIECE_4C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4D
            if (PIECE_4D.Text != "" && PIECE_4D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4D.Text != "" && PIECE_4D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4E
            if (PIECE_4E.Text != "" && PIECE_4E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4E.Text != "" && PIECE_4E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4F
            if (PIECE_4F.Text != "" && PIECE_4F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4F.Text != "" && PIECE_4F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4G
            if (PIECE_4G.Text != "" && PIECE_4G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4G.Text != "" && PIECE_4G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //4H
            if (PIECE_4H.Text != "" && PIECE_4H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_4H.Text != "" && PIECE_4H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5A
            if (PIECE_5A.Text != "" && PIECE_5A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5A.Text != "" && PIECE_5A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5B
            if (PIECE_5B.Text != "" && PIECE_5B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5B.Text != "" && PIECE_5B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5C
            if (PIECE_5C.Text != "" && PIECE_5C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5C.Text != "" && PIECE_5C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5D
            if (PIECE_5D.Text != "" && PIECE_5D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5D.Text != "" && PIECE_5D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5E
            if (PIECE_5E.Text != "" && PIECE_5E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5E.Text != "" && PIECE_5E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5F
            if (PIECE_5F.Text != "" && PIECE_5F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5F.Text != "" && PIECE_5F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5G
            if (PIECE_5G.Text != "" && PIECE_5G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5G.Text != "" && PIECE_5G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //5H
            if (PIECE_5H.Text != "" && PIECE_5H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_5H.Text != "" && PIECE_5H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6A
            if (PIECE_6A.Text != "" && PIECE_6A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6A.Text != "" && PIECE_6A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6B
            if (PIECE_6B.Text != "" && PIECE_6B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6B.Text != "" && PIECE_6B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6C
            if (PIECE_6C.Text != "" && PIECE_6C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6C.Text != "" && PIECE_6C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6D
            if (PIECE_6D.Text != "" && PIECE_6D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6D.Text != "" && PIECE_6D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6E
            if (PIECE_6E.Text != "" && PIECE_6E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6E.Text != "" && PIECE_6E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6F
            if (PIECE_6F.Text != "" && PIECE_6F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6F.Text != "" && PIECE_6F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6G
            if (PIECE_6G.Text != "" && PIECE_6G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6G.Text != "" && PIECE_6G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //6H
            if (PIECE_6H.Text != "" && PIECE_6H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_6H.Text != "" && PIECE_6H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7A
            if (PIECE_7A.Text != "" && PIECE_7A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7A.Text != "" && PIECE_7A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7B
            if (PIECE_7B.Text != "" && PIECE_7B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7B.Text != "" && PIECE_7B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7C
            if (PIECE_7C.Text != "" && PIECE_7C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7C.Text != "" && PIECE_7C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7D
            if (PIECE_7D.Text != "" && PIECE_7D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7D.Text != "" && PIECE_7D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7E
            if (PIECE_7E.Text != "" && PIECE_7E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7E.Text != "" && PIECE_7E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7F
            if (PIECE_7F.Text != "" && PIECE_7F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7F.Text != "" && PIECE_7F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7G
            if (PIECE_7G.Text != "" && PIECE_7G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7G.Text != "" && PIECE_7G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //7H
            if (PIECE_7H.Text != "" && PIECE_7H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_7H.Text != "" && PIECE_7H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8A
            if (PIECE_8A.Text != "" && PIECE_8A.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8A.Text != "" && PIECE_8A.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8B
            if (PIECE_8B.Text != "" && PIECE_8B.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8B.Text != "" && PIECE_8B.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8C
            if (PIECE_8C.Text != "" && PIECE_8C.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8C.Text != "" && PIECE_8C.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8D
            if (PIECE_8D.Text != "" && PIECE_8D.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8D.Text != "" && PIECE_8D.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8E
            if (PIECE_8E.Text != "" && PIECE_8E.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8E.Text != "" && PIECE_8E.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8F
            if (PIECE_8F.Text != "" && PIECE_8F.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8F.Text != "" && PIECE_8F.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8G
            if (PIECE_8G.Text != "" && PIECE_8G.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8G.Text != "" && PIECE_8G.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }
            //8H
            if (PIECE_8H.Text != "" && PIECE_8H.ForeColor == Color.FromName(OTHELLO_COLOR1))
            { Black_Point++; }
            else if (PIECE_8H.Text != "" && PIECE_8H.ForeColor == Color.FromName(OTHELLO_COLOR2))
            { White_Point++; }


            //�f�o�b�O�p
            //MessageBox.Show(
            //    "��" + Black_Point + Environment.NewLine + "��" + White_Point,
            //    "���m�点",
            //    MessageBoxButtons.OK
            //);
        }

        //�Ђ�����Ԃ��Ȃ��ꍇ�́A���ɖ߂��֐�
        public void Piece_Return(Button btn)
        {
            btn.Text = "";

            if (Othello_Turn == "Black_Turn")
            {
                Othello_Turn = "White_Turn";
            }
            else
            {
                Othello_Turn = "Black_Turn";
            }
        }


        //�N���b�N����ƁA�����ƌ��݂ɐF���ς��B

        Boolean Piece_Put = false;
        private void button1a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1A, PIECE_1B, PIECE_1C, PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1A, PIECE_2A, PIECE_3A, PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1A, PIECE_2B, PIECE_3C, PIECE_4D, PIECE_5E, PIECE_6F, PIECE_7G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1A);
                }

                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();

            }


        }

        private void button1b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1B, PIECE_1C, PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1B, PIECE_2B, PIECE_3B, PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1B, PIECE_2C, PIECE_3D, PIECE_4E, PIECE_5F, PIECE_6G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button1c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1C);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1C, PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1C, PIECE_2C, PIECE_3C, PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1C, PIECE_1B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_1C, PIECE_2D, PIECE_3E, PIECE_4F, PIECE_5G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_1C, PIECE_2B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }
                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button1d_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1D);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1D, PIECE_2D, PIECE_3D, PIECE_4D, PIECE_5D, PIECE_6D, PIECE_7D, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_1D, PIECE_2E, PIECE_3F, PIECE_4G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_1D, PIECE_2C, PIECE_3B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1D);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }
        private void button1e_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1E);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1E, PIECE_2E, PIECE_3E, PIECE_4E, PIECE_5E, PIECE_6E, PIECE_7E, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_1E, PIECE_2F, PIECE_3G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_1E, PIECE_2D, PIECE_3C, PIECE_4B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1E);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button1f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1F, PIECE_1G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1F, PIECE_2F, PIECE_3F, PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1F, PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_1F, PIECE_2G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }


                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_1F, PIECE_2E, PIECE_3D, PIECE_4C, PIECE_5B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button1g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1G, PIECE_2G, PIECE_3G, PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1G, PIECE_1F, PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1G, PIECE_2F, PIECE_3E, PIECE_4D, PIECE_5C, PIECE_6B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button1h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_1H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_1H, PIECE_2H, PIECE_3H, PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }
                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_1H, PIECE_1G, PIECE_1F, PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_1H, PIECE_2G, PIECE_3F, PIECE_4E, PIECE_5D, PIECE_6C, PIECE_7B, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_1H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2A, PIECE_2B, PIECE_2C, PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2A, PIECE_3A, PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2A, PIECE_3B, PIECE_4C, PIECE_5D, PIECE_6E, PIECE_7F, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }
                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2A);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2B, PIECE_2C, PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }
                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2B, PIECE_3B, PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }
                //�E�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2B, PIECE_3C, PIECE_4D, PIECE_5E, PIECE_6F, PIECE_7G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }
                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2C);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2C, PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2C, PIECE_3C, PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2C, PIECE_2B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_2C, PIECE_3D, PIECE_4E, PIECE_5F, PIECE_6G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_2C, PIECE_3B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2d_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2D);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2D, PIECE_3D, PIECE_4D, PIECE_5D, PIECE_6D, PIECE_7D, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_2D, PIECE_3E, PIECE_4F, PIECE_5G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }
                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_2D, PIECE_3C, PIECE_4B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2D);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2e_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2E);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2E, PIECE_3E, PIECE_4E, PIECE_5E, PIECE_6E, PIECE_7E, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_2E, PIECE_3F, PIECE_4G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_2E, PIECE_3D, PIECE_4C, PIECE_5B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2E);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�E�����ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2F, PIECE_2G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2F, PIECE_3F, PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2F, PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_2F, PIECE_3G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_2F, PIECE_3E, PIECE_4D, PIECE_5C, PIECE_6B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2G, PIECE_3G, PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2G, PIECE_2F, PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2G, PIECE_3F, PIECE_4E, PIECE_5D, PIECE_6C, PIECE_7B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button2h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_2H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //�������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_2H, PIECE_3H, PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_2H, PIECE_2G, PIECE_2F, PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_2H, PIECE_3G, PIECE_4F, PIECE_5E, PIECE_6D, PIECE_7C, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_2H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3A, PIECE_2A, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3A, PIECE_3B, PIECE_3C, PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3A, PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3A, PIECE_2B, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3A, PIECE_4B, PIECE_5C, PIECE_6D, PIECE_7E, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }


                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3A);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3B, PIECE_2B, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3B, PIECE_3C, PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3B, PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3B, PIECE_2C, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3B, PIECE_4C, PIECE_5D, PIECE_6E, PIECE_7F, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3C);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3C, PIECE_2C, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3C, PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3C, PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3C, PIECE_3B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3C, PIECE_2D, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_3C, PIECE_4D, PIECE_5E, PIECE_6F, PIECE_7G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_3C, PIECE_4B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_3C, PIECE_2B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3d_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3D);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3D, PIECE_2D, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3D, PIECE_4D, PIECE_5D, PIECE_6D, PIECE_7D, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3D, PIECE_2E, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_3D, PIECE_4E, PIECE_5F, PIECE_6G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_3D, PIECE_4C, PIECE_5B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_3D, PIECE_2C, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3D);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3e_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3E);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3E, PIECE_2E, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3E, PIECE_4E, PIECE_5E, PIECE_6E, PIECE_7E, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3E, PIECE_2F, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_3E, PIECE_4F, PIECE_5G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_3E, PIECE_4D, PIECE_5C, PIECE_6B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_3E, PIECE_2D, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3E);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3F, PIECE_2F, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3F, PIECE_3G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3F, PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3F, PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3F, PIECE_2G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }


                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_3F, PIECE_4G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_3F, PIECE_4E, PIECE_5D, PIECE_6C, PIECE_7B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_3F, PIECE_2E, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3G, PIECE_2G, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3G, PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3G, PIECE_3F, PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3G, PIECE_4F, PIECE_5E, PIECE_6D, PIECE_7C, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3G, PIECE_2F, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button3h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_3H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_3H, PIECE_2H, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_3H, PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_3H, PIECE_3G, PIECE_3F, PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_3H, PIECE_4G, PIECE_5F, PIECE_6E, PIECE_7D, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_3H, PIECE_2G, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_3H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button4a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_4A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_4A, PIECE_4B, PIECE_4C, PIECE_4D, PIECE_4E, PIECE_4F, PIECE_4G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_4A, PIECE_3B, PIECE_2C, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }


                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_4A, PIECE_5B, PIECE_6C, PIECE_7D, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_4A);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button4b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_4B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_4B, PIECE_4C, PIECE_4D, PIECE_4E, PIECE_4F, PIECE_4G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_4B, PIECE_3C, PIECE_2D, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_4B, PIECE_5C, PIECE_6D, PIECE_7E, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_4B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button4c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_4C);

            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_4C, PIECE_4D, PIECE_4E, PIECE_4F, PIECE_4G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_4C, PIECE_4B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_4C, PIECE_3D, PIECE_2E, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_4C, PIECE_5D, PIECE_6E, PIECE_7F, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_4C, PIECE_5B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_4C, PIECE_3B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_4C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button4f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_4F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_4F, PIECE_4G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_4F, PIECE_4E, PIECE_4D, PIECE_4C, PIECE_4B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_4F, PIECE_3G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_4F, PIECE_5G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_4F, PIECE_5E, PIECE_6D, PIECE_7C, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_4F, PIECE_3E, PIECE_2D, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_4F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button4g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_4G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_4G, PIECE_4F, PIECE_4E, PIECE_4D, PIECE_4C, PIECE_4B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_4G, PIECE_5F, PIECE_6E, PIECE_7D, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_4G, PIECE_3F, PIECE_2E, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_4G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button4h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_4H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_4H, PIECE_4G, PIECE_4F, PIECE_4E, PIECE_4D, PIECE_4C, PIECE_4B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_4H, PIECE_5G, PIECE_6F, PIECE_7E, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_4H, PIECE_3G, PIECE_2F, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_4H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button5a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_5A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_5A, PIECE_5B, PIECE_5C, PIECE_5D, PIECE_5E, PIECE_5F, PIECE_5G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_5A, PIECE_4B, PIECE_3C, PIECE_2D, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_5A, PIECE_6B, PIECE_7C, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_5A);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button5b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_5B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_5B, PIECE_5C, PIECE_5D, PIECE_5E, PIECE_5F, PIECE_5G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_5B, PIECE_4C, PIECE_3D, PIECE_2E, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_5B, PIECE_6C, PIECE_7D, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_5B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button5c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_5C);

            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_5C, PIECE_5D, PIECE_5E, PIECE_5F, PIECE_5G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_5C, PIECE_5B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_5C, PIECE_4D, PIECE_3E, PIECE_2F, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }


                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_5C, PIECE_6D, PIECE_7E, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_5C, PIECE_6B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_5C, PIECE_4B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_5C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }


        private void button5f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_5F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_5F, PIECE_5G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_5F, PIECE_5E, PIECE_5D, PIECE_5C, PIECE_5B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_5F, PIECE_4G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_5F, PIECE_6G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_5F, PIECE_6E, PIECE_7D, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_5F, PIECE_4E, PIECE_3D, PIECE_2C, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_5F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button5g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_5G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_5G, PIECE_5F, PIECE_5E, PIECE_5D, PIECE_5C, PIECE_5B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_5G, PIECE_6F, PIECE_7E, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_5G, PIECE_4F, PIECE_3E, PIECE_2D, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_5G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button5h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_5H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_5H, PIECE_5G, PIECE_5F, PIECE_5E, PIECE_5D, PIECE_5C, PIECE_5B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_5H, PIECE_6G, PIECE_7F, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_5H, PIECE_4G, PIECE_3F, PIECE_2E, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_5H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6A, PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6A, PIECE_6B, PIECE_6C, PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6A, PIECE_7A, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6A, PIECE_5B, PIECE_4C, PIECE_3D, PIECE_2E, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6A, PIECE_7B, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6A);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6B, PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6B, PIECE_6C, PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6B, PIECE_7B, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6B, PIECE_5C, PIECE_4D, PIECE_3E, PIECE_2F, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6B, PIECE_7C, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6C);

            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6C, PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6C, PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6C, PIECE_7C, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6C, PIECE_6B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6C, PIECE_5D, PIECE_4E, PIECE_3F, PIECE_2G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_6C, PIECE_7D, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_6C, PIECE_7B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_6C, PIECE_5B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6d_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6D);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6D, PIECE_5D, PIECE_4D, PIECE_3D, PIECE_2D, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6D, PIECE_7D, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6D, PIECE_5E, PIECE_4F, PIECE_3G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_6D, PIECE_7E, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_6D, PIECE_7C, PIECE_8B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_6D, PIECE_5C, PIECE_4B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6D);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6e_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6E);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6E, PIECE_5E, PIECE_4E, PIECE_3E, PIECE_2E, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6E, PIECE_7E, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }


                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6E, PIECE_5F, PIECE_4G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_6E, PIECE_7F, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_6E, PIECE_7D, PIECE_8C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_6E, PIECE_5D, PIECE_4C, PIECE_3B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6E);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6F, PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6F, PIECE_6G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6F, PIECE_7F, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6F, PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6F, PIECE_5G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�E�������ւ̏���
                var Piece_Flip5 = Program.FlipPieces(PIECE_6F, PIECE_7G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip5 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip6 = Program.FlipPieces(PIECE_6F, PIECE_7E, PIECE_8D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip6 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip7 = Program.FlipPieces(PIECE_6F, PIECE_5E, PIECE_4D, PIECE_3C, PIECE_2B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip7 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6G, PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6G, PIECE_7G, PIECE_8G);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6G, PIECE_6F, PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6G, PIECE_7F, PIECE_8E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }


                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6G, PIECE_5F, PIECE_4E, PIECE_3D, PIECE_2C, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button6h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_6H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_6H, PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_6H, PIECE_7H, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_6H, PIECE_6G, PIECE_6F, PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //���������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_6H, PIECE_7G, PIECE_8F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_6H, PIECE_5G, PIECE_4F, PIECE_3E, PIECE_2D, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_6H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7A, PIECE_6A, PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7A, PIECE_7B, PIECE_7C, PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7A, PIECE_6B, PIECE_5C, PIECE_4D, PIECE_3E, PIECE_2F, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7A);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7B, PIECE_6B, PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7B, PIECE_7C, PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7B, PIECE_6C, PIECE_5D, PIECE_4E, PIECE_3F, PIECE_2G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7C);

            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7C, PIECE_6C, PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7C, PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7C, PIECE_7B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_7C, PIECE_6D, PIECE_5E, PIECE_4F, PIECE_3G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_7C, PIECE_6B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7d_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7D);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7D, PIECE_6D, PIECE_5D, PIECE_4D, PIECE_3D, PIECE_2D, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_7D, PIECE_6E, PIECE_5F, PIECE_4G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_7D, PIECE_6C, PIECE_5B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7D);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7e_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7E);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7E, PIECE_6E, PIECE_5E, PIECE_4E, PIECE_3E, PIECE_2E, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_7E, PIECE_6F, PIECE_5G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_7E, PIECE_6D, PIECE_5C, PIECE_4B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7E);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7F, PIECE_6F, PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7F, PIECE_7G, PIECE_7H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7F, PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_7F, PIECE_6G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_7F, PIECE_6E, PIECE_5D, PIECE_4C, PIECE_3B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7G, PIECE_6G, PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7G, PIECE_7F, PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7G, PIECE_6F, PIECE_5E, PIECE_4D, PIECE_3C, PIECE_2B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button7h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_7H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_7H, PIECE_6H, PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_7H, PIECE_7G, PIECE_7F, PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_7H, PIECE_6G, PIECE_5F, PIECE_4E, PIECE_3D, PIECE_2C, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_7H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8a_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8A);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8A, PIECE_7A, PIECE_6A, PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8A, PIECE_8B, PIECE_8C, PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8A, PIECE_7B, PIECE_6C, PIECE_5D, PIECE_4E, PIECE_3F, PIECE_2G, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8A);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8b_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8B);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8B, PIECE_7B, PIECE_6B, PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8B, PIECE_8C, PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8B, PIECE_7C, PIECE_6D, PIECE_5E, PIECE_4F, PIECE_3G, PIECE_2H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8B);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8c_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8C);

            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8C, PIECE_7C, PIECE_6C, PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8C, PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8C, PIECE_8B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_8C, PIECE_7D, PIECE_6E, PIECE_5F, PIECE_4G, PIECE_3H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }


                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_8C, PIECE_7B, PIECE_6A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8C);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8d_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8D);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8D, PIECE_7D, PIECE_6D, PIECE_5D, PIECE_4D, PIECE_3D, PIECE_2D, PIECE_1D);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_8D, PIECE_7E, PIECE_6F, PIECE_5G, PIECE_4H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_8D, PIECE_7C, PIECE_6B, PIECE_5A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }


                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8D);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8e_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8E);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8E, PIECE_7E, PIECE_6E, PIECE_5E, PIECE_4E, PIECE_3E, PIECE_2E, PIECE_1E);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_8E, PIECE_7F, PIECE_6G, PIECE_5H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_8E, PIECE_7D, PIECE_6C, PIECE_5B, PIECE_4A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }


                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8E);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8f_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8F);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8F, PIECE_7F, PIECE_6F, PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�E�����ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8F, PIECE_8G, PIECE_8H);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8F, PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }


                //�E������ւ̏���
                var Piece_Flip3 = Program.FlipPieces(PIECE_8F, PIECE_7G, PIECE_6H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip3 == true)
                {
                    Piece_Put = true;
                }


                //��������ւ̏���
                var Piece_Flip4 = Program.FlipPieces(PIECE_8F, PIECE_7E, PIECE_6D, PIECE_5C, PIECE_4B, PIECE_3A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip4 == true)
                {
                    Piece_Put = true;
                }


                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8F);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8g_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8G);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8G, PIECE_7G, PIECE_6G, PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8G, PIECE_8F, PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8G, PIECE_7F, PIECE_6E, PIECE_5D, PIECE_4C, PIECE_3B, PIECE_2A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8G);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        private void button8h_Click(object sender, EventArgs e)
        {
            //���u��
            Turn_Change(PIECE_8H);

            //�����̋�łȂ���Ύ��s
            if (Exisitng_Check == false)
            {
                //������ւ̏���
                var Piece_Flip = Program.FlipPieces(PIECE_8H, PIECE_7H, PIECE_6H, PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip == true)
                {
                    Piece_Put = true;
                }

                //�������ւ̏���
                var Piece_Flip1 = Program.FlipPieces(PIECE_8H, PIECE_8G, PIECE_8F, PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A);
                //���u�����ǂ����̃`�F�b�N     
                if (Piece_Flip1 == true)
                {
                    Piece_Put = true;
                }

                //��������ւ̏���
                var Piece_Flip2 = Program.FlipPieces(PIECE_8H, PIECE_7G, PIECE_6F, PIECE_5E, PIECE_4D, PIECE_3C, PIECE_2B, PIECE_1A);
                //���u�����ǂ����̃`�F�b�N
                if (Piece_Flip2 == true)
                {
                    Piece_Put = true;
                }

                //�����A�s�[�X���Ђ�����Ԃ��Ȃ���΁A��͒u���Ȃ�
                if (Piece_Put == false)
                {
                    Piece_Return(PIECE_8H);
                }
                Piece_Put = false;

                //�I���`�F�b�N
                Empty_Check();

                //���̋�u����ꏊ������̂��m�F
                Pice_PutPlac();
            }
        }

        //�u���ꏊ�����邩�̊m�F�P�ӏ��ł������OK

        public Color Othello_Color; //���̃^�[���̃I�Z���̐F
        public int Count;            //�I�Z���u���ꏊ�m�F�p
        public Boolean Pice_PutPlac()
        {
            //�F�̔c��
            if (Othello_Turn == "Black_Turn")
            {
                Othello_Color = Color.FromName(OTHELLO_COLOR1);
            }
            else
            {
                Othello_Color = Color.FromName(OTHELLO_COLOR2);
            }

            //�m�F�񐔃��Z�b�g
            Count = 0;
            //���A���J��Ԃ�����Q�[���I��
            for (int look_putplace = 1; look_putplace <= 2; look_putplace++)
            {
                //1A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1A, PIECE_1B, PIECE_1C, PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1A, PIECE_2A, PIECE_3A, PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1A, PIECE_2B, PIECE_3C, PIECE_4D, PIECE_5E, PIECE_6F, PIECE_7G, PIECE_8H)) { break; }
                //1B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1B, PIECE_1C, PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1B, PIECE_2B, PIECE_3B, PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1B, PIECE_2C, PIECE_3D, PIECE_4E, PIECE_5F, PIECE_6G, PIECE_7H)) { break; }
                //1C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1C, PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1C, PIECE_2C, PIECE_3C, PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1C, PIECE_1B, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1C, PIECE_2D, PIECE_3E, PIECE_4F, PIECE_5G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1C, PIECE_2B, PIECE_3A)) { break; }
                //1D
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1D, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1D, PIECE_2D, PIECE_3D, PIECE_4D, PIECE_5D, PIECE_6D, PIECE_7D, PIECE_8D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1D, PIECE_2E, PIECE_3F, PIECE_4G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1D, PIECE_2C, PIECE_3B, PIECE_4A)) { break; }
                //1E
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1E, PIECE_1F, PIECE_1G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1E, PIECE_2E, PIECE_3E, PIECE_4E, PIECE_5E, PIECE_6E, PIECE_7E, PIECE_8E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1E, PIECE_2F, PIECE_3G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1E, PIECE_2D, PIECE_3C, PIECE_4B, PIECE_5A)) { break; }
                //1F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1F, PIECE_1G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1F, PIECE_2F, PIECE_3F, PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1F, PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1F, PIECE_2G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1F, PIECE_2E, PIECE_3D, PIECE_4C, PIECE_5B, PIECE_6A)) { break; }
                //1G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1G, PIECE_2G, PIECE_3G, PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1G, PIECE_1F, PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1G, PIECE_2F, PIECE_3E, PIECE_4D, PIECE_5C, PIECE_6B, PIECE_7A)) { break; }
                //1H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1H, PIECE_2H, PIECE_3H, PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1H, PIECE_1G, PIECE_1F, PIECE_1E, PIECE_1D, PIECE_1C, PIECE_1B, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_1H, PIECE_2G, PIECE_3F, PIECE_4E, PIECE_5D, PIECE_6C, PIECE_7B, PIECE_8H)) { break; }
                //2A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2A, PIECE_2B, PIECE_2C, PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2A, PIECE_3A, PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2A, PIECE_3B, PIECE_4C, PIECE_5D, PIECE_6E, PIECE_7F, PIECE_8G)) { break; }
                //2B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2B, PIECE_2C, PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2B, PIECE_3B, PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2B, PIECE_3C, PIECE_4D, PIECE_5E, PIECE_6F, PIECE_7G, PIECE_8H)) { break; }
                //2C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2C, PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2C, PIECE_3C, PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2C, PIECE_2B, PIECE_2A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2C, PIECE_3D, PIECE_4E, PIECE_5F, PIECE_6G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2C, PIECE_3B, PIECE_4A)) { break; }
                //2D
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2D, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2D, PIECE_3D, PIECE_4D, PIECE_5D, PIECE_6D, PIECE_7D, PIECE_8D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2D, PIECE_3E, PIECE_4F, PIECE_5G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2D, PIECE_3C, PIECE_4B, PIECE_5A)) { break; }
                //2E
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2E, PIECE_2F, PIECE_2G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2E, PIECE_3E, PIECE_4E, PIECE_5E, PIECE_6E, PIECE_7E, PIECE_8E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2E, PIECE_3F, PIECE_4G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2E, PIECE_3D, PIECE_4C, PIECE_5B, PIECE_6A)) { break; }
                //2F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2F, PIECE_2G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2F, PIECE_3F, PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2F, PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2F, PIECE_3G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2F, PIECE_3E, PIECE_4D, PIECE_5C, PIECE_6B, PIECE_7A)) { break; }
                //2G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2G, PIECE_3G, PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2G, PIECE_2F, PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2G, PIECE_3F, PIECE_4E, PIECE_5D, PIECE_6C, PIECE_7B, PIECE_8A)) { break; }
                //2H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2H, PIECE_3H, PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2H, PIECE_2G, PIECE_2F, PIECE_2E, PIECE_2D, PIECE_2C, PIECE_2B, PIECE_2A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_2H, PIECE_3G, PIECE_4F, PIECE_5E, PIECE_6D, PIECE_7C, PIECE_8B)) { break; }
                //3A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3A, PIECE_2A, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3A, PIECE_3B, PIECE_3C, PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3A, PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3A, PIECE_2B, PIECE_1C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3A, PIECE_4B, PIECE_5C, PIECE_6D, PIECE_7E, PIECE_8F)) { break; }
                //3B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3B, PIECE_2B, PIECE_1B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3B, PIECE_3C, PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3B, PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3B, PIECE_2C, PIECE_1D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3B, PIECE_4C, PIECE_5D, PIECE_6E, PIECE_7F, PIECE_8G)) { break; }
                //3C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_2C, PIECE_1C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_3B, PIECE_3A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_2D, PIECE_1E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_4D, PIECE_5E, PIECE_6F, PIECE_7G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_4B, PIECE_5A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3C, PIECE_2B, PIECE_1A)) { break; }
                //3D
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_2D, PIECE_1D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_4D, PIECE_5D, PIECE_6D, PIECE_7D, PIECE_8D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_2E, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_4E, PIECE_5F, PIECE_6G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_4C, PIECE_5B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3D, PIECE_2C, PIECE_1B)) { break; }
                //3E
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_2E, PIECE_1E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_3F, PIECE_3G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_4E, PIECE_5E, PIECE_6E, PIECE_7E, PIECE_8E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_2F, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_4F, PIECE_5G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_4D, PIECE_5C, PIECE_6B, PIECE_7A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3E, PIECE_2D, PIECE_1C)) { break; }
                //3F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_2F, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_3G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_2G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_4G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_4E, PIECE_5D, PIECE_6C, PIECE_7B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3F, PIECE_2E, PIECE_1D)) { break; }
                //3G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3G, PIECE_2G, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3G, PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3G, PIECE_3F, PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3G, PIECE_4F, PIECE_5E, PIECE_6D, PIECE_7C, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3G, PIECE_2F, PIECE_1E)) { break; }
                //3H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3H, PIECE_2H, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3H, PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3H, PIECE_3G, PIECE_3F, PIECE_3E, PIECE_3D, PIECE_3C, PIECE_3B, PIECE_3A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3H, PIECE_4G, PIECE_5F, PIECE_6E, PIECE_7D, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_3H, PIECE_2G, PIECE_1F)) { break; }
                //4A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4A, PIECE_4B, PIECE_4C, PIECE_4D, PIECE_4E, PIECE_4F, PIECE_4G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4A, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4A, PIECE_3B, PIECE_2C, PIECE_1D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4A, PIECE_5B, PIECE_6C, PIECE_7D, PIECE_8E)) { break; }
                //4B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4B, PIECE_4C, PIECE_4D, PIECE_4E, PIECE_4F, PIECE_4G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4B, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4B, PIECE_3C, PIECE_2D, PIECE_1E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4B, PIECE_5C, PIECE_6D, PIECE_7E, PIECE_8F)) { break; }
                //4C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_4D, PIECE_4E, PIECE_4F, PIECE_4G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_4B, PIECE_4A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_3D, PIECE_2E, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_5D, PIECE_6E, PIECE_7F, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_5B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4C, PIECE_3B, PIECE_2A)) { break; }
                //4F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_4G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_4E, PIECE_4D, PIECE_4C, PIECE_4B, PIECE_4A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_3G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_5G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_5E, PIECE_6D, PIECE_7C, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4F, PIECE_3E, PIECE_2D, PIECE_1C)) { break; }
                //4G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4G, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4G, PIECE_4F, PIECE_4E, PIECE_4D, PIECE_4C, PIECE_4B, PIECE_4A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4G, PIECE_5F, PIECE_6E, PIECE_7D, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4G, PIECE_3F, PIECE_2E, PIECE_1D)) { break; }
                //4H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4H, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4H, PIECE_4G, PIECE_4F, PIECE_4E, PIECE_4D, PIECE_4C, PIECE_4B, PIECE_4A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4H, PIECE_5G, PIECE_6F, PIECE_7E, PIECE_8D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_4H, PIECE_3G, PIECE_2F, PIECE_1E)) { break; }
                //5A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5A, PIECE_5B, PIECE_5C, PIECE_5D, PIECE_5E, PIECE_5F, PIECE_5G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5A, PIECE_6A, PIECE_7A, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5A, PIECE_4B, PIECE_3C, PIECE_2D, PIECE_1E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5A, PIECE_6B, PIECE_7C, PIECE_8D)) { break; }
                //5B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5B, PIECE_5C, PIECE_5D, PIECE_5E, PIECE_5F, PIECE_5G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5B, PIECE_6B, PIECE_7B, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5B, PIECE_4C, PIECE_3D, PIECE_2E, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5B, PIECE_6C, PIECE_7D, PIECE_8E)) { break; }
                //5C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5C, PIECE_5D, PIECE_5E, PIECE_5F, PIECE_5G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5C, PIECE_6C, PIECE_7C, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5C, PIECE_5B, PIECE_5A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5C, PIECE_4D, PIECE_3E, PIECE_2F, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5C, PIECE_6D, PIECE_7E, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5C, PIECE_4B, PIECE_3A)) { break; }
                //5F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_5G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_6F, PIECE_7F, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_5E, PIECE_5D, PIECE_5C, PIECE_5B, PIECE_5A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_4G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_6G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_6E, PIECE_7D, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5F, PIECE_4E, PIECE_3D, PIECE_2C, PIECE_1B)) { break; }
                //5G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5G, PIECE_6G, PIECE_7G, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5G, PIECE_5F, PIECE_5E, PIECE_5D, PIECE_5C, PIECE_5B, PIECE_5A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5G, PIECE_6F, PIECE_7E, PIECE_8D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5G, PIECE_4F, PIECE_3E, PIECE_2D, PIECE_1C)) { break; }
                //5H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5H, PIECE_6H, PIECE_7H, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5H, PIECE_5G, PIECE_5F, PIECE_5E, PIECE_5D, PIECE_5C, PIECE_5B, PIECE_5A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5H, PIECE_6G, PIECE_7F, PIECE_8E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_5H, PIECE_4G, PIECE_3F, PIECE_2E, PIECE_1D)) { break; }
                //6A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6A, PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6A, PIECE_6B, PIECE_6C, PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6A, PIECE_7A, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6A, PIECE_5B, PIECE_4C, PIECE_3D, PIECE_2E, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6A, PIECE_7B, PIECE_8C)) { break; }
                //6B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6B, PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6B, PIECE_6C, PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6B, PIECE_7B, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6B, PIECE_5C, PIECE_4D, PIECE_3E, PIECE_2F, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6B, PIECE_7C, PIECE_8D)) { break; }
                //6C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_7C, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_6B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_5D, PIECE_4E, PIECE_3F, PIECE_2G, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_7D, PIECE_8E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_7B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6C, PIECE_5B, PIECE_4A)) { break; }
                //6D
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_5D, PIECE_4D, PIECE_3D, PIECE_2D, PIECE_1D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_7D, PIECE_8D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_5E, PIECE_4F, PIECE_3G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_7E, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_7C, PIECE_8B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6D, PIECE_5C, PIECE_4B, PIECE_3A)) { break; }
                //6E
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_5E, PIECE_4E, PIECE_3E, PIECE_2E, PIECE_1E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_6F, PIECE_6G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_7E, PIECE_8E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_5F, PIECE_4G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_7F, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_7D, PIECE_8C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6E, PIECE_5D, PIECE_4C, PIECE_3B, PIECE_2A)) { break; }
                //6F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_6G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_7F, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_5G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_7G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_7E, PIECE_8D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6F, PIECE_5E, PIECE_4D, PIECE_3C, PIECE_2B, PIECE_1A)) { break; }
                //6G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6G, PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6G, PIECE_7G, PIECE_8G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6G, PIECE_6F, PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6G, PIECE_7F, PIECE_8E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6G, PIECE_5F, PIECE_4E, PIECE_3D, PIECE_2C, PIECE_1B)) { break; }
                //6H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6H, PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6H, PIECE_7H, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6H, PIECE_6G, PIECE_6F, PIECE_6E, PIECE_6D, PIECE_6C, PIECE_6B, PIECE_6A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6H, PIECE_7G, PIECE_8F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_6H, PIECE_5G, PIECE_4F, PIECE_3E, PIECE_2D, PIECE_1C)) { break; }
                //7A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7A, PIECE_6A, PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7A, PIECE_7B, PIECE_7C, PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7A, PIECE_6B, PIECE_5C, PIECE_4D, PIECE_3E, PIECE_2F, PIECE_1G)) { break; }
                //7B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7B, PIECE_6B, PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7B, PIECE_7C, PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7B, PIECE_6C, PIECE_5D, PIECE_4E, PIECE_3F, PIECE_2G, PIECE_1H)) { break; }
                //7C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7C, PIECE_6C, PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7C, PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7C, PIECE_7B, PIECE_7A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7C, PIECE_6D, PIECE_5E, PIECE_4F, PIECE_3G, PIECE_2H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7C, PIECE_6B, PIECE_3A)) { break; }
                //7D
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7D, PIECE_6D, PIECE_5D, PIECE_4D, PIECE_3D, PIECE_2D, PIECE_1D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7D, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7D, PIECE_6E, PIECE_5F, PIECE_4G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7D, PIECE_6C, PIECE_5B, PIECE_4A)) { break; }
                //7E
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7E, PIECE_6E, PIECE_5E, PIECE_4E, PIECE_3E, PIECE_2E, PIECE_1E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7E, PIECE_7F, PIECE_7G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7E, PIECE_6F, PIECE_5G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7E, PIECE_6D, PIECE_5C, PIECE_4B, PIECE_3A)) { break; }
                //7F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7F, PIECE_6F, PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7F, PIECE_7G, PIECE_7H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7F, PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7F, PIECE_6G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7F, PIECE_6E, PIECE_5D, PIECE_4C, PIECE_3B, PIECE_2A)) { break; }
                //7G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7G, PIECE_6G, PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7G, PIECE_7F, PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7G, PIECE_6F, PIECE_5E, PIECE_4D, PIECE_3C, PIECE_2B, PIECE_1A)) { break; }
                //7H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7H, PIECE_6H, PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7H, PIECE_7G, PIECE_7F, PIECE_7E, PIECE_7D, PIECE_7C, PIECE_7B, PIECE_7A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_7H, PIECE_6G, PIECE_5F, PIECE_4E, PIECE_3D, PIECE_2C, PIECE_1B)) { break; }
                //8A
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8A, PIECE_7A, PIECE_6A, PIECE_5A, PIECE_4A, PIECE_3A, PIECE_2A, PIECE_1A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8A, PIECE_8B, PIECE_8C, PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8A, PIECE_7B, PIECE_6C, PIECE_5D, PIECE_4E, PIECE_3F, PIECE_2G, PIECE_1H)) { break; }
                //8B
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8B, PIECE_7B, PIECE_6B, PIECE_5B, PIECE_4B, PIECE_3B, PIECE_2B, PIECE_1B)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8B, PIECE_8C, PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8B, PIECE_7C, PIECE_6D, PIECE_5E, PIECE_4F, PIECE_3G, PIECE_2H)) { break; }
                //8C
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8C, PIECE_7C, PIECE_6C, PIECE_5C, PIECE_4C, PIECE_3C, PIECE_2C, PIECE_1C)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8C, PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8C, PIECE_8B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8C, PIECE_7D, PIECE_6E, PIECE_5F, PIECE_4G, PIECE_3H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8C, PIECE_7B, PIECE_6A)) { break; }
                //8D
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8D, PIECE_7D, PIECE_6D, PIECE_5D, PIECE_4D, PIECE_3D, PIECE_2D, PIECE_1D)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8D, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8D, PIECE_7E, PIECE_6F, PIECE_5G, PIECE_4H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8D, PIECE_7C, PIECE_6B, PIECE_5A)) { break; }
                //8E
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8E, PIECE_7E, PIECE_6E, PIECE_5E, PIECE_4E, PIECE_3E, PIECE_2E, PIECE_1E)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8E, PIECE_8F, PIECE_8G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8E, PIECE_7F, PIECE_6G, PIECE_5H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8E, PIECE_7D, PIECE_6C, PIECE_5B, PIECE_4A)) { break; }
                //8F
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8F, PIECE_7F, PIECE_6F, PIECE_5F, PIECE_4F, PIECE_3F, PIECE_2F, PIECE_1F)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8F, PIECE_8G, PIECE_8H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8F, PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8F, PIECE_7G, PIECE_6H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8F, PIECE_7E, PIECE_6D, PIECE_5C, PIECE_4B, PIECE_3A)) { break; }
                //8G
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8G, PIECE_7G, PIECE_6G, PIECE_5G, PIECE_4G, PIECE_3G, PIECE_2G, PIECE_1G)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8G, PIECE_8F, PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8G, PIECE_7F, PIECE_6E, PIECE_5D, PIECE_4C, PIECE_3B, PIECE_2A)) { break; }
                //8H
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8H, PIECE_7H, PIECE_6H, PIECE_5H, PIECE_4H, PIECE_3H, PIECE_2H, PIECE_1H)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8H, PIECE_8G, PIECE_8F, PIECE_8E, PIECE_8D, PIECE_8C, PIECE_8B, PIECE_8A)) { break; }
                if (true == Program.FlipPieces_Look(Othello_Color, PIECE_8H, PIECE_7G, PIECE_6F, PIECE_5E, PIECE_4D, PIECE_3C, PIECE_2B, PIECE_1A)) { break; }


                //�F�̓���ւ�(�A���ł̏ꍇ�́A�Q�[���I��
                if (Othello_Turn == "Black_Turn")
                {
                    Othello_Color = Color.FromName(OTHELLO_COLOR2);
                    Othello_Turn = "White_Turn";
                }
                else
                {
                    Othello_Color = Color.FromName(OTHELLO_COLOR1);
                    Othello_Turn = "Black_Turn";
                }

                //���ڂł���΃Q�[���I��
                if (Count == 1)
                {
                    //�Q�[���I���A���ʏW�v
                    result();

                    //���ʉ�ʂ֑J��
                    result form = new result(Black_Point, White_Point);
                    form.ShowDialog();

                    //���Z�b�g
                    Game_Finish();
                }

                //�񐔂̃J�E���g
                Count = 1;
            }
            return true;
        }

    }
}