using System;
using System.Reflection;
using JasperFx.Core.Reflection;

namespace Marten.Linq.Parsing.Methods;

internal class StringEquals: StringComparisonParser
{
    public StringEquals(): base(
        ReflectionHelper.GetMethod<string>(s => s.Equals(string.Empty)),
        ReflectionHelper.GetMethod<string>(s => s.Equals(string.Empty, StringComparison.CurrentCulture)),
        ReflectionHelper.GetMethod(() => string.Equals(string.Empty, string.Empty)),
        ReflectionHelper.GetMethod(() => string.Equals(string.Empty, string.Empty, StringComparison.CurrentCulture)))
    {
    }

    public override string FormatValue(MethodInfo method, string value)
    {
        return value;
    }
}
