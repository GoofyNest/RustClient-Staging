public class SharpenAndVignette : PostProcessEffectSettings // TypeDefIndex: 11979
{
	[HeaderAttribute] 
	public BoolParameter applySharpen; 
	[RangeAttribute] 
	public FloatParameter strength; 
	[RangeAttribute] 
	public FloatParameter clamp; 
	[HeaderAttribute] 
	public BoolParameter applyVignette; 
	[RangeAttribute] 
	public FloatParameter sharpness; 
	[RangeAttribute] 
	public FloatParameter darkness; 


	public void .ctor() { }

}

