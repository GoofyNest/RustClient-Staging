public class Motion : Object // TypeDefIndex: 4494
{	// Methods

	// RVA: 0x22DDD60 Offset: 0x22DC360 VA: 0x1822DDD60
	protected void .ctor() { }

}

public class Motion : MonoBehaviour // TypeDefIndex: 8133
{	// Fields
	[SerializeField] // RVA: 0x934B0 Offset: 0x928B0 VA: 0x1800934B0
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

	// Properties
	public Motion.ExposureMode exposureMode { get; set; }
	public int shutterSpeed { get; set; }
	public float exposureTimeScale { get; set; }
	public Motion.SampleCount sampleCount { get; set; }
	public int sampleCountValue { get; set; }
	public float maxBlurRadius { get; set; }
	private float VelocityScale { get; }

	// Methods

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public Motion.ExposureMode get_exposureMode() { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_exposureMode(Motion.ExposureMode value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_shutterSpeed() { }

	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	public void set_shutterSpeed(int value) { }

	// RVA: 0x774700 Offset: 0x772D00 VA: 0x180774700
	public float get_exposureTimeScale() { }

	// RVA: 0x774740 Offset: 0x772D40 VA: 0x180774740
	public void set_exposureTimeScale(float value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public Motion.SampleCount get_sampleCount() { }

	// RVA: 0x79C690 Offset: 0x79AC90 VA: 0x18079C690
	public void set_sampleCount(Motion.SampleCount value) { }

	// RVA: 0x1071150 Offset: 0x106F750 VA: 0x181071150
	public int get_sampleCountValue() { }

	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	public void set_sampleCountValue(int value) { }

	// RVA: 0x10710D0 Offset: 0x106F6D0 VA: 0x1810710D0
	public float get_maxBlurRadius() { }

	// RVA: 0x87E310 Offset: 0x87C910 VA: 0x18087E310
	public void set_maxBlurRadius(float value) { }

	// RVA: 0x1071080 Offset: 0x106F680 VA: 0x181071080
	private float get_VelocityScale() { }

	// RVA: 0x1070810 Offset: 0x106EE10 VA: 0x181070810
	private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format, RenderTextureReadWrite rw) { }

	// RVA: 0x691EA0 Offset: 0x6904A0 VA: 0x180691EA0
	private void ReleaseTemporaryRT(RenderTexture rt) { }

	// RVA: 0x10709C0 Offset: 0x106EFC0 VA: 0x1810709C0
	private void OnEnable() { }

	// RVA: 0x1070920 Offset: 0x106EF20 VA: 0x181070920
	private void OnDisable() { }

	// RVA: 0x1070AE0 Offset: 0x106F0E0 VA: 0x181070AE0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1071040 Offset: 0x106F640 VA: 0x181071040
	public void .ctor() { }

}

public enum Motion.ExposureMode // TypeDefIndex: 8134
{	// Fields
	public int value__; // 0x0
	public const Motion.ExposureMode Constant = 0;
	public const Motion.ExposureMode DeltaTime = 1;

}

public enum Motion.SampleCount // TypeDefIndex: 8135
{	// Fields
	public int value__; // 0x0
	public const Motion.SampleCount Low = 0;
	public const Motion.SampleCount Medium = 1;
	public const Motion.SampleCount High = 2;
	public const Motion.SampleCount Variable = 3;

}

private enum Motion.DebugMode // TypeDefIndex: 8136
{	// Fields
	public int value__; // 0x0
	public const Motion.DebugMode Off = 0;
	public const Motion.DebugMode Velocity = 1;
	public const Motion.DebugMode NeighborMax = 2;
	public const Motion.DebugMode Depth = 3;

}

