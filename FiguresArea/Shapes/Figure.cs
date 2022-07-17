using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.Shapes;

abstract public class Figure
{
    protected string name;

    protected Figure(string name)
    {
        this.name = name;
    }
    protected Figure()
    {
        this.name = "";
    }

    public abstract double GetSquare();

    public virtual string GetInfo()
    {
        return $"Форма - {name}\nПлощадь - {GetSquare()}";
    }
}

