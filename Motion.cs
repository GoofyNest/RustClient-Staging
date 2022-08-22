public class Motion : Object // TypeDefIndex: 4494
{
	protected void .ctor() { }

}

public class Motion : MonoBehaviour // TypeDefIndex: 8133
{	[SerializeField] // RVA: 0x934B0 Offset: 0x928B0 VA: 0x1800934B0
	[TooltipAttribute] // RVA: 0x934B0 Offset: 0x928B0 VA: 0x1800934B0
	private Motion.ExposureMode _exposureMode; // 0x18
	[SerializeField] // RVA: 0x935B0 Offset: 0x929B0 VA: 0x1800935B0
	[TooltipAttribute] // RVA: 0x935B0 Offset: 0x929B0 VA: 0x1800935B0
	private int _shutterSpeed; // 0x1C
	[SerializeField] // RVA: 0x93680 Offset: 0x92A80 VA: 0x180093680
	[TooltipAttribute] // RVA: 0x93680 Offset: 0x92A80 VA: 0x180093680
	private float _exposureTimeScale; // 0x20
	[SerializeField] // RVA: 0x93760 Offset: 0x92B60 VA: 0x180093760
	[TooltipAttribute] // RVA: 0x93760 Offset: 0x92B60 VA: 0x180093760
	private Motion.SampleCount _sampleCount; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int _sampleCountValue; // 0x28
	[SerializeField] // RVA: 0x939B0 Offset: 0x92DB0 VA: 0x1800939B0
	[RangeAttribute] // RVA: 0x939B0 Offset: 0x92DB0 VA: 0x1800939B0
	[TooltipAttribute] // RVA: 0x939B0 Offset: 0x92DB0 VA: 0x1800939B0
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

