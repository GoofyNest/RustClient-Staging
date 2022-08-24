public class EnvironmentVolumePropertiesCollection : ScriptableObject // TypeDefIndex: 10676
{	public float TransitionSpeed; // 0x18
	[HorizontalAttribute] // RVA: 0xAA030 Offset: 0xA9430 VA: 0x1800AA030
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] ReflectionMultipliers; // 0x20
	public float DefaultReflectionMultiplier; // 0x28
	[HorizontalAttribute] // RVA: 0xAA030 Offset: 0xA9430 VA: 0x1800AA030
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] AmbientMultipliers; // 0x30
	public float DefaultAmbientMultiplier; // 0x38
	public EnvironmentVolumePropertiesCollection.OceanParameters OceanOverrides; // 0x40


	public float FindReflectionMultiplier(EnvironmentType type) { }

	public float FindAmbientMultiplier(EnvironmentType type) { }

	public LayerMask FindReflectionCullingFlags() { }

	public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.EnvironmentMultiplier // TypeDefIndex: 10677
{	public EnvironmentType Type; // 0x10
	public float Multiplier; // 0x14


	public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.OceanParameters // TypeDefIndex: 10678
{	public AnimationCurve TransitionCurve; // 0x10
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float DirectionalLightMultiplier; // 0x18
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float AmbientLightMultiplier; // 0x1C
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float ReflectionMultiplier; // 0x20
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float SunMeshBrightnessMultiplier; // 0x24
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float MoonMeshBrightnessMultiplier; // 0x28
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float AtmosphereBrightnessMultiplier; // 0x2C
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float LightColorMultiplier; // 0x30
	public Color LightColor; // 0x34
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float SunRayColorMultiplier; // 0x44
	public Color SunRayColor; // 0x48
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
	public float MoonRayColorMultiplier; // 0x58
	public Color MoonRayColor; // 0x5C


	public void .ctor() { }

}

