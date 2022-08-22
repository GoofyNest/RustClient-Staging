public class Motion : Object // TypeDefIndex: 4494
{	// Methods

	// RVA: 0x22DD540 Offset: 0x22DBB40 VA: 0x1822DD540
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

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public Motion.ExposureMode get_exposureMode() { }

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_exposureMode(Motion.ExposureMode value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_shutterSpeed() { }

	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	public void set_shutterSpeed(int value) { }

	// RVA: 0x7747B0 Offset: 0x772DB0 VA: 0x1807747B0
	public float get_exposureTimeScale() { }

	// RVA: 0x7747F0 Offset: 0x772DF0 VA: 0x1807747F0
	public void set_exposureTimeScale(float value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public Motion.SampleCount get_sampleCount() { }

	// RVA: 0x7D0D70 Offset: 0x7CF370 VA: 0x1807D0D70
	public void set_sampleCount(Motion.SampleCount value) { }

	// RVA: 0x10706E0 Offset: 0x106ECE0 VA: 0x1810706E0
	public int get_sampleCountValue() { }

	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	public void set_sampleCountValue(int value) { }

	// RVA: 0x1070660 Offset: 0x106EC60 VA: 0x181070660
	public float get_maxBlurRadius() { }

	// RVA: 0x862BB0 Offset: 0x8611B0 VA: 0x180862BB0
	public void set_maxBlurRadius(float value) { }

	// RVA: 0x1070610 Offset: 0x106EC10 VA: 0x181070610
	private float get_VelocityScale() { }

	// RVA: 0x106FDA0 Offset: 0x106E3A0 VA: 0x18106FDA0
	private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format, RenderTextureReadWrite rw) { }

	// RVA: 0x691F10 Offset: 0x690510 VA: 0x180691F10
	private void ReleaseTemporaryRT(RenderTexture rt) { }

	// RVA: 0x106FF50 Offset: 0x106E550 VA: 0x18106FF50
	private void OnEnable() { }

	// RVA: 0x106FEB0 Offset: 0x106E4B0 VA: 0x18106FEB0
	private void OnDisable() { }

	// RVA: 0x1070070 Offset: 0x106E670 VA: 0x181070070
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x10705D0 Offset: 0x106EBD0 VA: 0x1810705D0
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

