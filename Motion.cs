public class Motion : Object // TypeDefIndex: 4494
{	// Methods

	// RVA: 0x22DD280 Offset: 0x22DB880 VA: 0x1822DD280
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

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_exposureMode(Motion.ExposureMode value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_shutterSpeed() { }

	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	public void set_shutterSpeed(int value) { }

	// RVA: 0x7746A0 Offset: 0x772CA0 VA: 0x1807746A0
	public float get_exposureTimeScale() { }

	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	public void set_exposureTimeScale(float value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public Motion.SampleCount get_sampleCount() { }

	// RVA: 0x7D0C60 Offset: 0x7CF260 VA: 0x1807D0C60
	public void set_sampleCount(Motion.SampleCount value) { }

	// RVA: 0x1070420 Offset: 0x106EA20 VA: 0x181070420
	public int get_sampleCountValue() { }

	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	public void set_sampleCountValue(int value) { }

	// RVA: 0x10703A0 Offset: 0x106E9A0 VA: 0x1810703A0
	public float get_maxBlurRadius() { }

	// RVA: 0x862AA0 Offset: 0x8610A0 VA: 0x180862AA0
	public void set_maxBlurRadius(float value) { }

	// RVA: 0x1070350 Offset: 0x106E950 VA: 0x181070350
	private float get_VelocityScale() { }

	// RVA: 0x106FAE0 Offset: 0x106E0E0 VA: 0x18106FAE0
	private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format, RenderTextureReadWrite rw) { }

	// RVA: 0x691E00 Offset: 0x690400 VA: 0x180691E00
	private void ReleaseTemporaryRT(RenderTexture rt) { }

	// RVA: 0x106FC90 Offset: 0x106E290 VA: 0x18106FC90
	private void OnEnable() { }

	// RVA: 0x106FBF0 Offset: 0x106E1F0 VA: 0x18106FBF0
	private void OnDisable() { }

	// RVA: 0x106FDB0 Offset: 0x106E3B0 VA: 0x18106FDB0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1070310 Offset: 0x106E910 VA: 0x181070310
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

