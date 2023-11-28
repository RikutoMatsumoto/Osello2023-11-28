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

            //同じ色の駒で異なる駒を挟んだ時は、挟まれた駒がひっくり返される
            //③追加　一つもひっくり返らなければ、そこに駒は置けない。
            public static Boolean FlipPieces(Button Button0 = default(Button), Button Button1 = default(Button), Button Button2 = default(Button), Button Button3 = default(Button), Button Button4 = default(Button), Button Button5 = default(Button), Button Button6 = default(Button), Button Button7 = default(Button))
        {
            // ボタンが null の場合、デフォルト値として新しいボタンを作成する
            Button3 ??= new Button();
            Button4 ??= new Button();
            Button5 ??= new Button();
            Button6 ??= new Button();
            Button7 ??= new Button();

            Boolean Piece_Flip =false;          //ひっくり返すかどうかの変数


            //置いた駒の隣の駒がある且つ違う色の駒である
            //さらに2つ目以降の駒で同じ色の物がある場合は、挟まった駒を両端と同じ色に変換する。
            if (Button0.ForeColor != Button1.ForeColor && Button1.Text != "")
            {
                //2個隣の駒が空欄ではない且つ2個隣の駒の色が同じ場合は、中をひっくり返す
                if (Button2.Text != "" && Button2.ForeColor == Button0.ForeColor)
                {
                    Button1.ForeColor = Button0.ForeColor;

                    Piece_Flip = true;
                    return Piece_Flip;
                }
                //2個隣の駒が空欄ではない且つ2個隣の駒の色が違う場合は3個隣の確認
                else if (Button2.Text != "" && Button2.ForeColor != Button0.ForeColor)
                {
                    //３個隣の駒が空欄ではない且つ3個隣の駒の色が同じの場合は、中をひっくり返す  
                    if (Button3.Text != "" && Button3.ForeColor == Button0.ForeColor)
                    {
                        Button1.ForeColor = Button0.ForeColor;
                        Button2.ForeColor = Button0.ForeColor;

                        Piece_Flip = true;
                        return Piece_Flip;
                    }
                    //３個隣の駒が空欄ではない且つ3個隣の駒の色が違う場合は4個隣の確認
                    else if (Button3.Text != "" && Button3.ForeColor != Button0.ForeColor)
                    {
                        //4個隣の駒が空欄ではない且つ4個隣の駒の色が同じの場合は、中をひっくり返す  
                        if (Button4.Text != "" && Button4.ForeColor == Button0.ForeColor)
                        {
                            Button1.ForeColor = Button0.ForeColor;
                            Button2.ForeColor = Button0.ForeColor;
                            Button3.ForeColor = Button0.ForeColor;

                            Piece_Flip = true;
                            return Piece_Flip;
                        }
                        //4個隣の駒が空欄ではない且つ4個隣の駒の色が違う場合は5個隣の確認
                        else if (Button4.Text != "" && Button4.ForeColor != Button0.ForeColor)
                        {
                            //5個隣の駒が空欄ではない且つ5個隣の駒の色が同じの場合は、中をひっくり返す
                            if (Button5.Text != "" && Button5.ForeColor == Button0.ForeColor)
                            {
                                Button1.ForeColor = Button0.ForeColor;
                                Button2.ForeColor = Button0.ForeColor;
                                Button3.ForeColor = Button0.ForeColor;
                                Button4.ForeColor = Button0.ForeColor;

                                Piece_Flip = true;
                                return Piece_Flip;
                            }
                            //5個隣の駒が空欄ではない且つ5個隣の駒の色が違う場合は6個隣の確認
                            else if (Button5.Text != "" && Button5.ForeColor != Button0.ForeColor)
                            {
                                //6個隣の駒が空欄ではない且つ6個隣の駒の色が同じの場合は、中をひっくり返す
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
                                //6個隣の駒が空欄ではない且つ6個隣の駒の色が違う場合は7個隣の確認
                                else if (Button5.Text != "" && Button5.ForeColor != Button0.ForeColor)
                                {
                                    //7個隣の駒が空欄ではない且つ7個隣の駒の色が同じの場合は、中をひっくり返す
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

        //駒の置く場所があるのか確認
        //同じ色の駒で異なる駒を挟んだ時は、挟まれた駒がひっくり返される場所があるかどうかの確認
        //③追加　一つもひっくり返らなければ、そこに駒は置けない。
        public static Boolean FlipPieces_Look(Color Othello_Color,Button Button0 = default(Button), Button Button1 = default(Button), Button Button2 = default(Button), Button Button3 = default(Button), Button Button4 = default(Button), Button Button5 = default(Button), Button Button6 = default(Button), Button Button7 = default(Button))
        {
            // ボタンが null の場合、デフォルト値として新しいボタンを作成する
            Button0 ??= new Button();
            Button1 ??= new Button();
            Button2 ??= new Button();
            Button3 ??= new Button();
            Button4 ??= new Button();
            Button5 ??= new Button();
            Button6 ??= new Button();
            Button7 ??= new Button();


            //確認する駒の隣に駒がある且つ違う色の駒である
            //さらに2つ目以降の駒で同じ色の物がある場合は、挟まった駒を両端と同じ色に変換することができる。

            if (Button0.Text != "")
            {
                return false;
            }
           　
            if (Othello_Color != Button1.ForeColor && Button1.Text != "")
            {
                //2個隣の駒が空欄ではない且つ2個隣の駒の色が同じ場合は、中をひっくり返すことができる
                if (Button2.Text != "" && Button2.ForeColor == Othello_Color)
                {
                    return true;
                }
                //2個隣の駒が空欄ではない且つ2個隣の駒の色が違う場合は3個隣の確認
                else if (Button2.Text != "" && Button2.ForeColor != Othello_Color)
                {
                    //３個隣の駒が空欄ではない且つ3個隣の駒の色が同じの場合は、中をひっくり返すことができる  
                    if (Button3.Text != "" && Button3.ForeColor == Othello_Color)
                    {
                        return true;
                    }
                    //３個隣の駒が空欄ではない且つ3個隣の駒の色が違う場合は4個隣の確認
                    else if (Button3.Text != "" && Button3.ForeColor != Othello_Color)
                    {
                        //4個隣の駒が空欄ではない且つ4個隣の駒の色が同じの場合は、中をひっくり返すことができる  
                        if (Button4.Text != "" && Button4.ForeColor == Othello_Color)
                        {
                            return true;
                        }
                        //4個隣の駒が空欄ではない且つ4個隣の駒の色が違う場合は5個隣の確認
                        else if (Button4.Text != "" && Button4.ForeColor != Othello_Color)
                        {
                            //5個隣の駒が空欄ではない且つ5個隣の駒の色が同じの場合は、中をひっくり返すことができる
                            if (Button5.Text != "" && Button5.ForeColor == Othello_Color)
                            {
                                return true;
                            }
                            //5個隣の駒が空欄ではない且つ5個隣の駒の色が違う場合は6個隣の確認
                            else if (Button5.Text != "" && Button5.ForeColor != Othello_Color)
                            {
                                //6個隣の駒が空欄ではない且つ6個隣の駒の色が同じの場合は、中をひっくり返すことができる
                                if (Button6.Text != "" && Button6.ForeColor == Othello_Color)
                                {
                                    return true;
                                }
                                //6個隣の駒が空欄ではない且つ6個隣の駒の色が違う場合は7個隣の確認
                                else if (Button5.Text != "" && Button5.ForeColor != Othello_Color)
                                {
                                    //7個隣の駒が空欄ではない且つ7個隣の駒の色が同じの場合は、中をひっくり返すことができる
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