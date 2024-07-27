using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WeightedChanceParam
{
    public Action Func { get; }
    public double Ratio { get; }

    public WeightedChanceParam(Action func, double ratio)
    {
        Func = func;
        Ratio = ratio;
    }
}

public class WeightedChanceExecutor
{
    public WeightedChanceParam[] Parameters { get; }
    private Random random;

    public double RatioSum
    {
        get { return Parameters.Sum(p => p.Ratio); }
    }

    public WeightedChanceExecutor(params WeightedChanceParam[] parameters)
    {
        Parameters = parameters;
        random = new Random();
    }

    public void Execute()
    {
        double numericValue = random.NextDouble() * RatioSum;
        foreach (var parameter in Parameters)
        {
            numericValue -= parameter.Ratio;
            if (!(numericValue <= 0))
                continue;

            parameter.Func();
            return;
        }
    }
}