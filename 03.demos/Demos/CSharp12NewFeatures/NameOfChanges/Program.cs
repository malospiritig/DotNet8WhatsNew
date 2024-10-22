
using System.ComponentModel;

Console.WriteLine(NameOfTest.NameOfSampleTextLength);
Console.WriteLine(NameOfTest.NameOfSampleIntMaxValue);

public class NameOfTest 
{
    public string SampleText { get; set; } = string.Empty;
    public int SampleInt { get; set; }

    public const string NameOfSampleTextLength = nameof(SampleText.Length);
    public const string NameOfSampleIntMaxValue = nameof(SampleInt.MaxValue);

    [Description($"String {nameof(SampleText.Length)}")]
    public int StringLength(string s)
    { 
        return s.Length; 
    }
}