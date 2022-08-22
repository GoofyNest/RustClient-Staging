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

	// RVA: 0x18EA330 Offset: 0x18E8930 VA: 0x1818EA330
	public LightType get_type() { }

	// RVA: 0x18EA620 Offset: 0x18E8C20 VA: 0x1818EA620
	public void set_type(LightType value) { }

	// RVA: 0x18EA2F0 Offset: 0x18E88F0 VA: 0x1818EA2F0
	public float get_spotAngle() { }

	// RVA: 0x18EA1E0 Offset: 0x18E87E0 VA: 0x1818EA1E0
	public Color get_color() { }

	// RVA: 0x18EA3C0 Offset: 0x18E89C0 VA: 0x1818EA3C0
	public void set_color(Color value) { }

	// RVA: 0x18EA230 Offset: 0x18E8830 VA: 0x1818EA230
	public float get_intensity() { }

	// RVA: 0x18EA450 Offset: 0x18E8A50 VA: 0x1818EA450
	public void set_intensity(float value) { }

	// RVA: 0x18EA150 Offset: 0x18E8750 VA: 0x1818EA150
	public float get_bounceIntensity() { }

	// RVA: 0x18EA4F0 Offset: 0x18E8AF0 VA: 0x1818EA4F0
	public void set_shadowBias(float value) { }

	// RVA: 0x18EA540 Offset: 0x18E8B40 VA: 0x1818EA540
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x18EA270 Offset: 0x18E8870 VA: 0x1818EA270
	public float get_range() { }

	// RVA: 0x18EA4A0 Offset: 0x18E8AA0 VA: 0x1818EA4A0
	public void set_range(float value) { }

	// RVA: 0x18EA410 Offset: 0x18E8A10 VA: 0x1818EA410
	public void set_cullingMask(int value) { }

	[NativeMethodAttribute] // RVA: 0x952F0 Offset: 0x946F0 VA: 0x1800952F0
	// RVA: 0x18EA2B0 Offset: 0x18E88B0 VA: 0x1818EA2B0
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute] // RVA: 0x953B0 Offset: 0x947B0 VA: 0x1800953B0
	// RVA: 0x18EA5E0 Offset: 0x18E8BE0 VA: 0x1818EA5E0
	public void set_shadows(LightShadows value) { }

	[FreeFunctionAttribute] // RVA: 0x954A0 Offset: 0x948A0 VA: 0x1800954A0
	// RVA: 0x18EA590 Offset: 0x18E8B90 VA: 0x1818EA590
	public void set_shadowStrength(float value) { }

	// RVA: 0x18E9FC0 Offset: 0x18E85C0 VA: 0x1818E9FC0
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x954E0 Offset: 0x948E0 VA: 0x1800954E0
	// RVA: 0x18EA020 Offset: 0x18E8620 VA: 0x1818EA020
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0x18EA0C0 Offset: 0x18E86C0 VA: 0x1818EA0C0
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0x18EA110 Offset: 0x18E8710 VA: 0x1818EA110
	public void RemoveCommandBuffers(LightEvent evt) { }

	[FreeFunctionAttribute] // RVA: 0x95580 Offset: 0x94980 VA: 0x180095580
	// RVA: 0x18EA080 Offset: 0x18E8680 VA: 0x1818EA080
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0x18EA190 Offset: 0x18E8790 VA: 0x1818EA190
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x18EA370 Offset: 0x18E8970 VA: 0x1818EA370
	private void set_color_Injected(ref Color value) { }

}

