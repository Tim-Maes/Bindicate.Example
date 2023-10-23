using Bindicate.Attributes.Options;

namespace Bindicate.ProjectWithOptions;

//Parameter here is a section from appsettings
[RegisterOptions("sampleConfig")]
public sealed class SampleOptions
{
    public string SampleStringOption { get; set; } = "";

    public int SampleNumberOption { get; set; } = 0;
}

