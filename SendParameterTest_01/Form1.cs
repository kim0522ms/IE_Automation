using System;
using System.Windows.Forms;
using System.Threading;
using SHDocVw;

namespace SendParameterTest_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 브라우저 객체 생성
            InternetExplorer ie = new InternetExplorer();
            ie.Visible = true;

            // 접근할 URL
            dynamic url = "http://www.google.co.kr";

            // 해당 URL 탐색(브라우저 실행)
            ie.Navigate2(ref url);

            // 브라우저가 Busy 상태(켜지고 있을 때)일 경우 켜질때까지 기다림
            while(ie.Busy)
            {
                Thread.Sleep(1000);
            }
   
            // 브라우저 객체가 표시하고 있는 HTML페이지를 로드
            mshtml.HTMLDocument page = ie.Document;

            // 로드한 HTML페이지에 있는 Element중
            // 1. q라는 id를 가진 Element를 획득 (getElementById("q")
            // 2. 해당 Element의 value 값을 test1234로 변경 ( .setAttribute("value", "test1234) );
            page.getElementById("q").setAttribute("value", "ㅋㅋㅋㅋㅋ");
        }

    }
}
