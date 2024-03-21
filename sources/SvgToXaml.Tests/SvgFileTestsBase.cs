using System.Diagnostics;
using System.Reflection;
using System.Windows.Controls;
using DustInTheWind.SvgToXaml.Conversion;
using DustInTheWind.SvgToXaml.Svg;
using DustInTheWind.SvgToXaml.Tests.Utils;

namespace DustInTheWind.SvgToXaml.Tests;

public class SvgFileTestsBase
{
    protected void TestConvertSvgFile(string resourceFileName, Action<Canvas> callBack)
    {
        Type callerType = GetCallerType();

        string svg = TestResources.ReadTextFile(resourceFileName, callerType);
        SvgDocument svgDocument = SvgDocument.Parse(svg);
        
        StaEnvironment.Run(() =>
        {
            Canvas canvas = svgDocument.Content.ToXaml();

            callBack?.Invoke(canvas);
        });
    }

    private static Type GetCallerType()
    {
        StackFrame stackFrame = new(2, false);
        MethodBase caller = stackFrame.GetMethod();

        return caller.DeclaringType;
    }
}