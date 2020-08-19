using Exam.Elements;
using System;
using System.Text.Json.Serialization;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button(500,500);
            btn.Content = "Кнопка";
            btn.Position_X = 10;
            btn.Position_Y = 10;
            btn.Opacity = 70;
            btn.OnClick();
        }
    }
}
