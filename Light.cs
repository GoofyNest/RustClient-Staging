public sealed class Light : Behaviour // TypeDefIndex: 3408
{	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x95600 Offset: 0x94A00 VA: 0x180095600
	public LightType type { get; set; }
	public float spotAngle { get; }
	public Color color { get; set; }
	public float intensity { get; set; }
	public float bounceIntensity { get; }
	public float shadowBias { set; }
	public float shadowNormalBias { set; }
	public float range { get; set; }
	public int cullingMask { set; }
	public LightShadows shadows { get; set; }
	public float shadowStrength { set; }

	// Methods

	// RVA: 0x18EA5F0 Offset: 0x18E8BF0 VA: 0x1818EA5F0
	public LightType get_type() { }

	// RVA: 0x18EA8E0 Offset: 0x18E8EE0 VA: 0x1818EA8E0
	public void set_type(LightType value) { }

	// RVA: 0x18EA5B0 Offset: 0x18E8BB0 VA: 0x1818EA5B0
	public float get_spotAngle() { }

	// RVA: 0x18EA4A0 Offset: 0x18E8AA0 VA: 0x1818EA4A0
	public Color get_color() { }

	// RVA: 0x18EA680 Offset: 0x18E8C80 VA: 0x1818EA680
	public void set_color(Color value) { }

	// RVA: 0x18EA4F0 Offset: 0x18E8AF0 VA: 0x1818EA4F0
	public float get_intensity() { }

	// RVA: 0x18EA710 Offset: 0x18E8D10 VA: 0x1818EA710
	public void set_intensity(float value) { }

	// RVA: 0x18EA410 Offset: 0x18E8A10 VA: 0x1818EA410
	public float get_bounceIntensity() { }

	// RVA: 0x18EA7B0 Offset: 0x18E8DB0 VA: 0x1818EA7B0
	public void set_shadowBias(float value) { }

	// RVA: 0x18EA800 Offset: 0x18E8E00 VA: 0x1818EA800
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x18EA530 Offset: 0x18E8B30 VA: 0x1818EA530
	public float get_range() { }

	// RVA: 0x18EA760 Offset: 0x18E8D60 VA: 0x1818EA760
	public void set_range(float value) { }

	// RVA: 0x18EA6D0 Offset: 0x18E8CD0 VA: 0x1818EA6D0
	public void set_cullingMask(int value) { }

	[NativeMethodAttribute] // RVA: 0x952F0 Offset: 0x946F0 VA: 0x1800952F0
	// RVA: 0x18EA570 Offset: 0x18E8B70 VA: 0x1818EA570
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute] // RVA: 0x953B0 Offset: 0x947B0 VA: 0x1800953B0
	// RVA: 0x18EA8A0 Offset: 0x18E8EA0 VA: 0x1818EA8A0
	public void set_shadows(LightShadows value) { }

	[FreeFunctionAttribute] // RVA: 0x954A0 Offset: 0x948A0 VA: 0x1800954A0
	// RVA: 0x18EA850 Offset: 0x18E8E50 VA: 0x1818EA850
	public void set_shadowStrength(float value) { }

	// RVA: 0x18EA280 Offset: 0x18E8880 VA: 0x1818EA280
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x954E0 Offset: 0x948E0 VA: 0x1800954E0
	// RVA: 0x18EA2E0 Offset: 0x18E88E0 VA: 0x1818EA2E0
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0x18EA380 Offset: 0x18E8980 VA: 0x1818EA380
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0x18EA3D0 Offset: 0x18E89D0 VA: 0x1818EA3D0
	public void RemoveCommandBuffers(LightEvent evt) { }

	[FreeFunctionAttribute] // RVA: 0x95580 Offset: 0x94980 VA: 0x180095580
	// RVA: 0x18EA340 Offset: 0x18E8940 VA: 0x1818EA340
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0x18EA450 Offset: 0x18E8A50 VA: 0x1818EA450
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x18EA630 Offset: 0x18E8C30 VA: 0x1818EA630
	private void set_color_Injected(ref Color value) { }

}

