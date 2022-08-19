public class LightLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 11309
{	// Fields
	public float DistanceBias; // 0x18
	public bool ToggleLight; // 0x1C
	public bool ToggleShadows; // 0x1D
	private static List<LightLOD> pointLights; // 0x0
	private static List<LightLOD> spotLights; // 0x8
	private Light lightComponent; // 0x20
	private LightOccludee lightOccludee; // 0x28
	private LightEx lightEx; // 0x30
	private VolumetricLightBeam volumetricBeam; // 0x38
	private float cameraDist; // 0x40
	private float fadeSign; // 0x44
	private float maxLightIntensity; // 0x48
	private float shadowIntensity; // 0x4C
	private static ListHashSet<LightLOD> registered; // 0x10
	private static readonly int UpdatePerFrame; // 0x18
	private static int updateIndex; // 0x1C

	// Methods

	// RVA: 0x4F1A00 Offset: 0x4F0000 VA: 0x1804F1A00
	private int GetMaxLightCount() { }

	// RVA: 0x4F1950 Offset: 0x4EFF50 VA: 0x1804F1950
	private List<LightLOD> GetCurrentLights() { }

	// RVA: 0x4F1930 Offset: 0x4EFF30 VA: 0x1804F1930
	private void FadeIn() { }

	// RVA: 0x4F1940 Offset: 0x4EFF40 VA: 0x1804F1940
	private void FadeOut() { }

	// RVA: 0x4F1520 Offset: 0x4EFB20 VA: 0x1804F1520
	protected void Awake() { }

	// RVA: 0x4F1C40 Offset: 0x4F0240 VA: 0x1804F1C40
	protected void OnEnable() { }

	// RVA: 0x4F1B10 Offset: 0x4F0110 VA: 0x1804F1B10
	protected void OnDisable() { }

	// RVA: 0x4F18A0 Offset: 0x4EFEA0 VA: 0x1804F18A0
	public static void ClearAll() { }

	// RVA: 0x4F1D30 Offset: 0x4F0330 VA: 0x1804F1D30
	public static void UpdateAll() { }

	// RVA: 0x4F20F0 Offset: 0x4F06F0 VA: 0x1804F20F0
	private void UpdateLight(float lightIntensity, float shadowIntensity) { }

	// RVA: 0x4F1FE0 Offset: 0x4F05E0 VA: 0x1804F1FE0
	private void UpdateLight() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x4F1610 Offset: 0x4EFC10 VA: 0x1804F1610 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x4EFC70 Offset: 0x4EE270 VA: 0x1804EFC70
	protected void OnValidate() { }

	// RVA: 0x4F24E0 Offset: 0x4F0AE0 VA: 0x1804F24E0
	public void .ctor() { }

	// RVA: 0x4F23D0 Offset: 0x4F09D0 VA: 0x1804F23D0
	private static void .cctor() { }

}

