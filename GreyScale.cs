public class GreyScale : PostProcessEffectSettings // TypeDefIndex: 12016
{
	[RangeAttribute]
	public FloatParameter redLuminance;
	[RangeAttribute]
	public FloatParameter greenLuminance;
	[RangeAttribute]
	public FloatParameter blueLuminance;
	[RangeAttribute]
	public FloatParameter amount;
	[ColorUsageAttribute]
	public ColorParameter color;


	public void .ctor() { }

}

