public sealed class Grain : PostProcessEffectSettings // TypeDefIndex: 13592
{
	[TooltipAttribute]
	public BoolParameter colored;
	[RangeAttribute]
	[TooltipAttribute]
	public FloatParameter intensity;
	[RangeAttribute]
	[TooltipAttribute]
	public FloatParameter size;
	[RangeAttribute]
	[DisplayNameAttribute]
	[TooltipAttribute]
	public FloatParameter lumContrib;


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

