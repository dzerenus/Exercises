using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12;

public class Simplex
{
    double[] f;
    List<Variable> vars;
    double result;

    public Simplex(
        (double x1, double x2, double x3, double f) d1,
        (double x1, double x2, double x3, double f) d2,
        (double x1, double x2, double x3, double f) d3,
        double x1Mul, double x2Mul, double x3Mul
        )
    {
        vars = new();

        vars.Add(new Variable("x1", x1Mul, new double[] { d1.x1, d2.x1, d3.x1 }));
        vars.Add(new Variable("x2", x2Mul, new double[] { d1.x2, d2.x2, d3.x2 }));
        vars.Add(new Variable("x3", x3Mul, new double[] { d1.x3, d2.x3, d3.x3 }));

        vars.Add(new Variable("y1", 0, new double[] { 1, 0, 0 }) { IsBasis = true });
        vars.Add(new Variable("y2", 0, new double[] { 0, 1, 0 }) { IsBasis = true });
        vars.Add(new Variable("y3", 0, new double[] { 0, 0, 1 }) { IsBasis = true });

        f = new double[] { d1.f, d2.f, d3.f };

        for (int i = 0; i < 4; i++)
        {
            result = GetBResult();
            foreach (var v in vars) SetMark(v);

            Console.WriteLine($"#{i + 1} ----------------------");

            var not = vars.FindLast(x => x.Mark < 0);
            if (not is null) return;

            var index = GetMasterIndex(not);
            Replace(index, not);
            ReCalculate(not, index);

            foreach (var v in vars) Console.WriteLine($"{v.Name} - {v.Values[2]}");
        }


        //result = GetBResult();


        //var basises = vars.FindAll(o => o.IsBasis);
        //foreach (var b in basises) Console.WriteLine($"{b.Name} - {b.Multiplier}");
        //foreach (var b in f) Console.WriteLine($"{b}");

        //Console.WriteLine(result);



        //foreach (var v in vars)
        //{
        //    SetMark(v);
        //    Console.WriteLine($"{v.Name} - {v.Mark}");
        //}

    }

    double GetBResult()
    {
        double result = 0;
        var basises = vars.FindAll(o => o.IsBasis);

        for (int i = 0; i < basises.Count; i++)
            result += basises[i].Multiplier * f[i];

        return result;
    }

    void SetMark(in Variable column)
    {
        column.Mark = 0;
        var basises = vars.FindAll(o => o.IsBasis);

        for (int i = 0; i < basises.Count; i++)
            column.Mark += basises[i].Multiplier * column.Values[i];

        column.Mark -= column.Multiplier;
    }

    int GetMasterIndex(in Variable col)
    {
        double min = double.MaxValue;
        int resIndex = 0;

        for (int i = 0; i < col.Values.Length; i++)
        {
            var val = Math.Abs(f[i] / col.Values[i]);
            if (val > min) continue;
            min = val;
            resIndex = i;
        }

        return resIndex;
    }

    void Replace(int index, in Variable col)
    {
        var basises = vars.FindAll(o => o.IsBasis);
        foreach (var b in basises)
            if (b.Values[index] == 1) b.IsBasis = false;

        col.IsBasis = true;
    }

    void ReCalculate(in Variable col, int index)
    {
        var main = col.Values[index];

        var nonbasises = vars.FindAll(o => !o.IsBasis);
        nonbasises.Add(col);

        f[index] /= main;
        foreach (var b in nonbasises)
            b.Values[index] /= main;

        for (int i = 0; i < col.Values.Length; i++)
        {
            if (i == index) continue;
            var mul = col.Values[i] * -1;
            f[i] += f[index] * mul;

            foreach (var nb in nonbasises)
            {
                nb.Values[i] += nb.Values[index] * mul;
            }
        }

    }
}
