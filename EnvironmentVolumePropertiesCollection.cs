public class EnvironmentVolumePropertiesCollection : ScriptableObject // TypeDefIndex: 10672
{	// Fields
	public float TransitionSpeed; // 0x18
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] ReflectionMultipliers; // 0x20
	public float DefaultReflectionMultiplier; // 0x28
	[HorizontalAttribute] // RVA: 0xAA3F0 Offset: 0xA97F0 VA: 0x1800AA3F0
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] AmbientMultipliers; // 0x30
	public float DefaultAmbientMultiplier; // 0x38
	public EnvironmentVolumePropertiesCollection.OceanParameters OceanOverrides; // 0x40

	// Methods

	// RVA: 0x8CB850 Offset: 0x8C9E50 VA: 0x1808CB850
	public float FindReflectionMultiplier(EnvironmentType type) { }

	// RVA: 0x8CB740 Offset: 0x8C9D40 VA: 0x1808CB740
	public float FindAmbientMultiplier(EnvironmentType type) { }

	// RVA: 0x8CB7B0 Offset: 0x8C9DB0 VA: 0x1808CB7B0
	public LayerMask FindReflectionCullingFlags() { }

	// RVA: 0x8CB940 Offset: 0x8C9F40 VA: 0x1808CB940
	public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.EnvironmentMultiplier // TypeDefIndex: 10673
{	// Fields
	public EnvironmentType Type; // 0x10
	public float Multiplier; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.OceanParameters // TypeDefIndex: 10674
{	// Fields
	public AnimationCurve TransitionCurve; // 0x10
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float DirectionalLightMultiplier; // 0x18
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float AmbientLightMultiplier; // 0x1C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float ReflectionMultiplier; // 0x20
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float SunMeshBrightnessMultiplier; // 0x24
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float MoonMeshBrightnessMultiplier; // 0x28
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float AtmosphereBrightnessMultiplier; // 0x2C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float LightColorMultiplier; // 0x30
	public Color LightColor; // 0x34
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float SunRayColorMultiplier; // 0x44
	public Color SunRayColor; // 0x48
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float MoonRayColorMultiplier; // 0x58
	public Color MoonRayColor; // 0x5C

	// Methods

	// RVA: 0x8D6E00 Offset: 0x8D5400 VA: 0x1808D6E00
	public void .ctor() { }

}

