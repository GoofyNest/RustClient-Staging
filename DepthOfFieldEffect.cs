public class DepthOfFieldEffect : PostProcessEffectSettings // TypeDefIndex: 12001
{
	public FloatParameter focalLength;
	public FloatParameter focalSize;
	public FloatParameter aperture;
	public FloatParameter maxBlurSize;
	public BoolParameter highResolution;
	public DOFBlurSampleCountParameter blurSampleCount;
	public Transform focalTransform;


	public void .ctor() { }

}

