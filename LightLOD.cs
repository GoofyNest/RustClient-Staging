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

	// RVA: 0x4F1990 Offset: 0x4EFF90 VA: 0x1804F1990
	private int GetMaxLightCount() { }

	// RVA: 0x4F18E0 Offset: 0x4EFEE0 VA: 0x1804F18E0
	private List<LightLOD> GetCurrentLights() { }

	// RVA: 0x4F18C0 Offset: 0x4EFEC0 VA: 0x1804F18C0
	private void FadeIn() { }

	// RVA: 0x4F18D0 Offset: 0x4EFED0 VA: 0x1804F18D0
	private void FadeOut() { }

	// RVA: 0x4F14B0 Offset: 0x4EFAB0 VA: 0x1804F14B0
	protected void Awake() { }

	// RVA: 0x4F1BD0 Offset: 0x4F01D0 VA: 0x1804F1BD0
	protected void OnEnable() { }

	// RVA: 0x4F1AA0 Offset: 0x4F00A0 VA: 0x1804F1AA0
	protected void OnDisable() { }

	// RVA: 0x4F1830 Offset: 0x4EFE30 VA: 0x1804F1830
	public static void ClearAll() { }

	// RVA: 0x4F1CC0 Offset: 0x4F02C0 VA: 0x1804F1CC0
	public static void UpdateAll() { }

	// RVA: 0x4F2080 Offset: 0x4F0680 VA: 0x1804F2080
	private void UpdateLight(float lightIntensity, float shadowIntensity) { }

	// RVA: 0x4F1F70 Offset: 0x4F0570 VA: 0x1804F1F70
	private void UpdateLight() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x4F15A0 Offset: 0x4EFBA0 VA: 0x1804F15A0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x4EFC00 Offset: 0x4EE200 VA: 0x1804EFC00
	protected void OnValidate() { }

	// RVA: 0x4F2470 Offset: 0x4F0A70 VA: 0x1804F2470
	public void .ctor() { }

	// RVA: 0x4F2360 Offset: 0x4F0960 VA: 0x1804F2360
	private static void .cctor() { }

}

