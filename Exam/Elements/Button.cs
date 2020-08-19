using Exam.Common;
using Exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace Exam.Elements
{
    public class Button : IElement
    {
        public Button(int width,int height) : base()
        {
            this.Width = width;
            this.Height = height;
        }
        public Button()
        {
            Click += OnClick;
            MouseDown += OnMouseDown;
            MouseUp += OnMouseUp;
            MouseLeftDown += OnMouseLeftDown;
            MouseRigthDown += OnMouseRigthDown;
        }
        //Для начала можно описать свойства
        public double Position_X { get; set; }
        public double Position_Y { get; set; } 
        public double Width { get; set; } 
        public double Height { get; set; }
        public string Content { get; set; } = "Button";
        public string BackgroundColor { get; set; } = "#FFAEAEAE"; // цвет фона 
        public string ForegroundColor { get; set; } = "#000000"; //  цвет контента
        public double Opacity { get; set; } = 100;
        public bool IsVisible { get; set; } = true;
        public bool IsEnabled { get; set; } = true;
        public bool IsPressed { get; set; }

        //делегаты и события
        public delegate void EventHandler(params object[] args);
        public event EventHandler Click;

        public delegate void MouseEventHandler(params object[] args);
        public event MouseEventHandler MouseDown;
        public event MouseEventHandler MouseUp;
        public event MouseEventHandler MouseLeftDown;
        public event MouseEventHandler MouseRigthDown;

        //методы
        public void OnClick(params object[] args) { }
        public void OnMouseDown(params object[] args) { }
        public void OnMouseUp(params object[] args) { }
        public void OnMouseLeftDown(params object[] args) { }
        public void OnMouseRigthDown(params object[] args) { }
        public void OnDbClick(params object[] args) { }


    }
}
