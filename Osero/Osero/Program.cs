using System.Security.Cryptography.X509Certificates;

namespace Osero
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

            //�����F�̋�ňقȂ������񂾎��́A���܂ꂽ��Ђ�����Ԃ����
            //�B�ǉ��@����Ђ�����Ԃ�Ȃ���΁A�����ɋ�͒u���Ȃ��B
            public static Boolean FlipPieces(Button Button0 = default(Button), Button Button1 = default(Button), Button Button2 = default(Button), Button Button3 = default(Button), Button Button4 = default(Button), Button Button5 = default(Button), Button Button6 = default(Button), Button Button7 = default(Button))
        {
            // �{�^���� null �̏ꍇ�A�f�t�H���g�l�Ƃ��ĐV�����{�^�����쐬����
            Button3 ??= new Button();
            Button4 ??= new Button();
            Button5 ??= new Button();
            Button6 ??= new Button();
            Button7 ??= new Button();

            Boolean Piece_Flip =false;          //�Ђ�����Ԃ����ǂ����̕ϐ�


            //�u������ׂ̗̋���銎�Ⴄ�F�̋�ł���
            //�����2�ڈȍ~�̋�œ����F�̕�������ꍇ�́A���܂�����𗼒[�Ɠ����F�ɕϊ�����B
            if (Button0.ForeColor != Button1.ForeColor && Button1.Text != "")
            {
                //2�ׂ̋�󗓂ł͂Ȃ�����2�ׂ̋�̐F�������ꍇ�́A�����Ђ�����Ԃ�
                if (Button2.Text != "" && Button2.ForeColor == Button0.ForeColor)
                {
                    Button1.ForeColor = Button0.ForeColor;

                    Piece_Flip = true;
                    return Piece_Flip;
                }
                //2�ׂ̋�󗓂ł͂Ȃ�����2�ׂ̋�̐F���Ⴄ�ꍇ��3�ׂ̊m�F
                else if (Button2.Text != "" && Button2.ForeColor != Button0.ForeColor)
                {
                    //�R�ׂ̋�󗓂ł͂Ȃ�����3�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ�  
                    if (Button3.Text != "" && Button3.ForeColor == Button0.ForeColor)
                    {
                        Button1.ForeColor = Button0.ForeColor;
                        Button2.ForeColor = Button0.ForeColor;

                        Piece_Flip = true;
                        return Piece_Flip;
                    }
                    //�R�ׂ̋�󗓂ł͂Ȃ�����3�ׂ̋�̐F���Ⴄ�ꍇ��4�ׂ̊m�F
                    else if (Button3.Text != "" && Button3.ForeColor != Button0.ForeColor)
                    {
                        //4�ׂ̋�󗓂ł͂Ȃ�����4�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ�  
                        if (Button4.Text != "" && Button4.ForeColor == Button0.ForeColor)
                        {
                            Button1.ForeColor = Button0.ForeColor;
                            Button2.ForeColor = Button0.ForeColor;
                            Button3.ForeColor = Button0.ForeColor;

                            Piece_Flip = true;
                            return Piece_Flip;
                        }
                        //4�ׂ̋�󗓂ł͂Ȃ�����4�ׂ̋�̐F���Ⴄ�ꍇ��5�ׂ̊m�F
                        else if (Button4.Text != "" && Button4.ForeColor != Button0.ForeColor)
                        {
                            //5�ׂ̋�󗓂ł͂Ȃ�����5�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ�
                            if (Button5.Text != "" && Button5.ForeColor == Button0.ForeColor)
                            {
                                Button1.ForeColor = Button0.ForeColor;
                                Button2.ForeColor = Button0.ForeColor;
                                Button3.ForeColor = Button0.ForeColor;
                                Button4.ForeColor = Button0.ForeColor;

                                Piece_Flip = true;
                                return Piece_Flip;
                            }
                            //5�ׂ̋�󗓂ł͂Ȃ�����5�ׂ̋�̐F���Ⴄ�ꍇ��6�ׂ̊m�F
                            else if (Button5.Text != "" && Button5.ForeColor != Button0.ForeColor)
                            {
                                //6�ׂ̋�󗓂ł͂Ȃ�����6�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ�
                                if (Button6.Text != "" && Button6.ForeColor == Button0.ForeColor)
                                {
                                    Button1.ForeColor = Button0.ForeColor;
                                    Button2.ForeColor = Button0.ForeColor;
                                    Button3.ForeColor = Button0.ForeColor;
                                    Button4.ForeColor = Button0.ForeColor;
                                    Button5.ForeColor = Button0.ForeColor;

                                    Piece_Flip = true;
                                    return Piece_Flip;
                                }
                                //6�ׂ̋�󗓂ł͂Ȃ�����6�ׂ̋�̐F���Ⴄ�ꍇ��7�ׂ̊m�F
                                else if (Button5.Text != "" && Button5.ForeColor != Button0.ForeColor)
                                {
                                    //7�ׂ̋�󗓂ł͂Ȃ�����7�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ�
                                    if (Button7.Text != "" && Button7.ForeColor == Button0.ForeColor)
                                    {
                                        Button1.ForeColor = Button0.ForeColor;
                                        Button2.ForeColor = Button0.ForeColor;
                                        Button3.ForeColor = Button0.ForeColor;
                                        Button4.ForeColor = Button0.ForeColor;
                                        Button5.ForeColor = Button0.ForeColor;
                                        Button6.ForeColor = Button0.ForeColor;

                                        Piece_Flip = true;
                                        return Piece_Flip;
                                    }
                                    else
                                    {
                                        return Piece_Flip;
                                    }
                                }
                                else
                                {
                                    return Piece_Flip;
                                }
                            } 
                            else
                            {
                                return Piece_Flip;
                            }
                        }
                        else
                        {
                            return Piece_Flip;
                        }
                    }
                    else
                    {
                        return Piece_Flip;
                    }
                }
                else
                {
                    return Piece_Flip;
                }
            }
            else
            {
                return Piece_Flip;
            }
        }

        //��̒u���ꏊ������̂��m�F
        //�����F�̋�ňقȂ������񂾎��́A���܂ꂽ��Ђ�����Ԃ����ꏊ�����邩�ǂ����̊m�F
        //�B�ǉ��@����Ђ�����Ԃ�Ȃ���΁A�����ɋ�͒u���Ȃ��B
        public static Boolean FlipPieces_Look(Color Othello_Color,Button Button0 = default(Button), Button Button1 = default(Button), Button Button2 = default(Button), Button Button3 = default(Button), Button Button4 = default(Button), Button Button5 = default(Button), Button Button6 = default(Button), Button Button7 = default(Button))
        {
            // �{�^���� null �̏ꍇ�A�f�t�H���g�l�Ƃ��ĐV�����{�^�����쐬����
            Button0 ??= new Button();
            Button1 ??= new Button();
            Button2 ??= new Button();
            Button3 ??= new Button();
            Button4 ??= new Button();
            Button5 ??= new Button();
            Button6 ??= new Button();
            Button7 ??= new Button();


            //�m�F�����ׂ̗ɋ���銎�Ⴄ�F�̋�ł���
            //�����2�ڈȍ~�̋�œ����F�̕�������ꍇ�́A���܂�����𗼒[�Ɠ����F�ɕϊ����邱�Ƃ��ł���B

            if (Button0.Text != "")
            {
                return false;
            }
           �@
            if (Othello_Color != Button1.ForeColor && Button1.Text != "")
            {
                //2�ׂ̋�󗓂ł͂Ȃ�����2�ׂ̋�̐F�������ꍇ�́A�����Ђ�����Ԃ����Ƃ��ł���
                if (Button2.Text != "" && Button2.ForeColor == Othello_Color)
                {
                    return true;
                }
                //2�ׂ̋�󗓂ł͂Ȃ�����2�ׂ̋�̐F���Ⴄ�ꍇ��3�ׂ̊m�F
                else if (Button2.Text != "" && Button2.ForeColor != Othello_Color)
                {
                    //�R�ׂ̋�󗓂ł͂Ȃ�����3�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ����Ƃ��ł���  
                    if (Button3.Text != "" && Button3.ForeColor == Othello_Color)
                    {
                        return true;
                    }
                    //�R�ׂ̋�󗓂ł͂Ȃ�����3�ׂ̋�̐F���Ⴄ�ꍇ��4�ׂ̊m�F
                    else if (Button3.Text != "" && Button3.ForeColor != Othello_Color)
                    {
                        //4�ׂ̋�󗓂ł͂Ȃ�����4�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ����Ƃ��ł���  
                        if (Button4.Text != "" && Button4.ForeColor == Othello_Color)
                        {
                            return true;
                        }
                        //4�ׂ̋�󗓂ł͂Ȃ�����4�ׂ̋�̐F���Ⴄ�ꍇ��5�ׂ̊m�F
                        else if (Button4.Text != "" && Button4.ForeColor != Othello_Color)
                        {
                            //5�ׂ̋�󗓂ł͂Ȃ�����5�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ����Ƃ��ł���
                            if (Button5.Text != "" && Button5.ForeColor == Othello_Color)
                            {
                                return true;
                            }
                            //5�ׂ̋�󗓂ł͂Ȃ�����5�ׂ̋�̐F���Ⴄ�ꍇ��6�ׂ̊m�F
                            else if (Button5.Text != "" && Button5.ForeColor != Othello_Color)
                            {
                                //6�ׂ̋�󗓂ł͂Ȃ�����6�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ����Ƃ��ł���
                                if (Button6.Text != "" && Button6.ForeColor == Othello_Color)
                                {
                                    return true;
                                }
                                //6�ׂ̋�󗓂ł͂Ȃ�����6�ׂ̋�̐F���Ⴄ�ꍇ��7�ׂ̊m�F
                                else if (Button5.Text != "" && Button5.ForeColor != Othello_Color)
                                {
                                    //7�ׂ̋�󗓂ł͂Ȃ�����7�ׂ̋�̐F�������̏ꍇ�́A�����Ђ�����Ԃ����Ƃ��ł���
                                    if (Button7.Text != "" && Button7.ForeColor == Othello_Color)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}