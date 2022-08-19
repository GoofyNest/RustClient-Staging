public sealed class Light : Behaviour // TypeDefIndex: 3408
{	// Fields
	private int m_BakedIndex; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x95580 Offset: 0x94980 VA: 0x180095580
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

	// RVA: 0x18EA370 Offset: 0x18E8970 VA: 0x1818EA370
	public LightType get_type() { }

	// RVA: 0x18EA660 Offset: 0x18E8C60 VA: 0x1818EA660
	public void set_type(LightType value) { }

	// RVA: 0x18EA330 Offset: 0x18E8930 VA: 0x1818EA330
	public float get_spotAngle() { }

	// RVA: 0x18EA220 Offset: 0x18E8820 VA: 0x1818EA220
	public Color get_color() { }

	// RVA: 0x18EA400 Offset: 0x18E8A00 VA: 0x1818EA400
	public void set_color(Color value) { }

	// RVA: 0x18EA270 Offset: 0x18E8870 VA: 0x1818EA270
	public float get_intensity() { }

	// RVA: 0x18EA490 Offset: 0x18E8A90 VA: 0x1818EA490
	public void set_intensity(float value) { }

	// RVA: 0x18EA190 Offset: 0x18E8790 VA: 0x1818EA190
	public float get_bounceIntensity() { }

	// RVA: 0x18EA530 Offset: 0x18E8B30 VA: 0x1818EA530
	public void set_shadowBias(float value) { }

	// RVA: 0x18EA580 Offset: 0x18E8B80 VA: 0x1818EA580
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x18EA2B0 Offset: 0x18E88B0 VA: 0x1818EA2B0
	public float get_range() { }

	// RVA: 0x18EA4E0 Offset: 0x18E8AE0 VA: 0x1818EA4E0
	public void set_range(float value) { }

	// RVA: 0x18EA450 Offset: 0x18E8A50 VA: 0x1818EA450
	public void set_cullingMask(int value) { }

	[NativeMethodAttribute] // RVA: 0x95270 Offset: 0x94670 VA: 0x180095270
	// RVA: 0x18EA2F0 Offset: 0x18E88F0 VA: 0x1818EA2F0
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute] // RVA: 0x95330 Offset: 0x94730 VA: 0x180095330
	// RVA: 0x18EA620 Offset: 0x18E8C20 VA: 0x1818EA620
	public void set_shadows(LightShadows value) { }

	[FreeFunctionAttribute] // RVA: 0x95420 Offset: 0x94820 VA: 0x180095420
	// RVA: 0x18EA5D0 Offset: 0x18E8BD0 VA: 0x1818EA5D0
	public void set_shadowStrength(float value) { }

	// RVA: 0x18EA000 Offset: 0x18E8600 VA: 0x1818EA000
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x95460 Offset: 0x94860 VA: 0x180095460
	// RVA: 0x18EA060 Offset: 0x18E8660 VA: 0x1818EA060
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0x18EA100 Offset: 0x18E8700 VA: 0x1818EA100
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0x18EA150 Offset: 0x18E8750 VA: 0x1818EA150
	public void RemoveCommandBuffers(LightEvent evt) { }

	[FreeFunctionAttribute] // RVA: 0x95540 Offset: 0x94940 VA: 0x180095540
	// RVA: 0x18EA0C0 Offset: 0x18E86C0 VA: 0x1818EA0C0
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0x18EA1D0 Offset: 0x18E87D0 VA: 0x1818EA1D0
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x18EA3B0 Offset: 0x18E89B0 VA: 0x1818EA3B0
	private void set_color_Injected(ref Color value) { }

}

