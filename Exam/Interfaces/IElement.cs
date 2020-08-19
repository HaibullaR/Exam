using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Interfaces
{
    interface IElement
    {
        double Position_X { get; set; }
        double Position_Y { get; set; }
        double Width { get; set; }
        double Height { get; set; }
        bool IsEnabled { get; set; }
        bool IsVisible { get; set; }

    }
}
