public class Motion : Object // TypeDefIndex: 4494
{
	protected void .ctor() { }

}

public class Motion : MonoBehaviour // TypeDefIndex: 8133
{	[SerializeField] // RVA: 0x934A0 Offset: 0x928A0 VA: 0x1800934A0
	[TooltipAttribute] // RVA: 0x934A0 Offset: 0x928A0 VA: 0x1800934A0
	private Motion.ExposureMode _exposureMode; // 0x18
	[SerializeField] // RVA: 0x935A0 Offset: 0x929A0 VA: 0x1800935A0
	[TooltipAttribute] // RVA: 0x935A0 Offset: 0x929A0 VA: 0x1800935A0
	private int _shutterSpeed; // 0x1C
	[SerializeField] // RVA: 0x93670 Offset: 0x92A70 VA: 0x180093670
	[TooltipAttribute] // RVA: 0x93670 Offset: 0x92A70 VA: 0x180093670
	private float _exposureTimeScale; // 0x20
	[SerializeField] // RVA: 0x93720 Offset: 0x92B20 VA: 0x180093720
	[TooltipAttribute] // RVA: 0x93720 Offset: 0x92B20 VA: 0x180093720
	private Motion.SampleCount _sampleCount; // 0x24
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int _sampleCountValue; // 0x28
	[SerializeField] // RVA: 0x93970 Offset: 0x92D70 VA: 0x180093970
	[RangeAttribute] // RVA: 0x93970 Offset: 0x92D70 VA: 0x180093970
	[TooltipAttribute] // RVA: 0x93970 Offset: 0x92D70 VA: 0x180093970
	private float _maxBlurRadius; // 0x2C
	[SerializeField] // RVA: 0x93AA0 Offset: 0x92EA0 VA: 0x180093AA0
	[TooltipAttribute] // RVA: 0x93AA0 Offset: 0x92EA0 VA: 0x180093AA0
	private Motion.DebugMode _debugMode; // 0x30
	private Material _prefilterMaterial; // 0x38
	private Material _reconstructionMaterial; // 0x40

	public Motion.ExposureMode exposureMode { get; set; }
	public int shutterSpeed { get; set; }
	public float exposureTimeScale { get; set; }
	public Motion.SampleCount sampleCount { get; set; }
	public int sampleCountValue { get; set; }
	public float maxBlurRadius { get; set; }
	private float VelocityScale { get; }


	public Motion.ExposureMode get_exposureMode() { }

	public void set_exposureMode(Motion.ExposureMode value) { }

	public int get_shutterSpeed() { }

	public void set_shutterSpeed(int value) { }

	public float get_exposureTimeScale() { }

	public void set_exposureTimeScale(float value) { }

	public Motion.SampleCount get_sampleCount() { }

	public void set_sampleCount(Motion.SampleCount value) { }

	public int get_sampleCountValue() { }

	public void set_sampleCountValue(int value) { }

	public float get_maxBlurRadius() { }

	public void set_maxBlurRadius(float value) { }

	private float get_VelocityScale() { }

	private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format, RenderTextureReadWrite rw) { }

	private void ReleaseTemporaryRT(RenderTexture rt) { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum Motion.ExposureMode // TypeDefIndex: 8134
{	public int value__; // 0x0
	public const Motion.ExposureMode Constant = 0;
	public const Motion.ExposureMode DeltaTime = 1;

}

public enum Motion.SampleCount // TypeDefIndex: 8135
{	public int value__; // 0x0
	public const Motion.SampleCount Low = 0;
	public const Motion.SampleCount Medium = 1;
	public const Motion.SampleCount High = 2;
	public const Motion.SampleCount Variable = 3;

}

private enum Motion.DebugMode // TypeDefIndex: 8136
{	public int value__; // 0x0
	public const Motion.DebugMode Off = 0;
	public const Motion.DebugMode Velocity = 1;
	public const Motion.DebugMode NeighborMax = 2;
	public const Motion.DebugMode Depth = 3;

}

