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

	// RVA: 0x18E9D10 Offset: 0x18E8310 VA: 0x1818E9D10
	public LightType get_type() { }

	// RVA: 0x18EA000 Offset: 0x18E8600 VA: 0x1818EA000
	public void set_type(LightType value) { }

	// RVA: 0x18E9CD0 Offset: 0x18E82D0 VA: 0x1818E9CD0
	public float get_spotAngle() { }

	// RVA: 0x18E9BC0 Offset: 0x18E81C0 VA: 0x1818E9BC0
	public Color get_color() { }

	// RVA: 0x18E9DA0 Offset: 0x18E83A0 VA: 0x1818E9DA0
	public void set_color(Color value) { }

	// RVA: 0x18E9C10 Offset: 0x18E8210 VA: 0x1818E9C10
	public float get_intensity() { }

	// RVA: 0x18E9E30 Offset: 0x18E8430 VA: 0x1818E9E30
	public void set_intensity(float value) { }

	// RVA: 0x18E9B30 Offset: 0x18E8130 VA: 0x1818E9B30
	public float get_bounceIntensity() { }

	// RVA: 0x18E9ED0 Offset: 0x18E84D0 VA: 0x1818E9ED0
	public void set_shadowBias(float value) { }

	// RVA: 0x18E9F20 Offset: 0x18E8520 VA: 0x1818E9F20
	public void set_shadowNormalBias(float value) { }

	// RVA: 0x18E9C50 Offset: 0x18E8250 VA: 0x1818E9C50
	public float get_range() { }

	// RVA: 0x18E9E80 Offset: 0x18E8480 VA: 0x1818E9E80
	public void set_range(float value) { }

	// RVA: 0x18E9DF0 Offset: 0x18E83F0 VA: 0x1818E9DF0
	public void set_cullingMask(int value) { }

	[NativeMethodAttribute] // RVA: 0x952F0 Offset: 0x946F0 VA: 0x1800952F0
	// RVA: 0x18E9C90 Offset: 0x18E8290 VA: 0x1818E9C90
	public LightShadows get_shadows() { }

	[FreeFunctionAttribute] // RVA: 0x953B0 Offset: 0x947B0 VA: 0x1800953B0
	// RVA: 0x18E9FC0 Offset: 0x18E85C0 VA: 0x1818E9FC0
	public void set_shadows(LightShadows value) { }

	[FreeFunctionAttribute] // RVA: 0x954A0 Offset: 0x948A0 VA: 0x1800954A0
	// RVA: 0x18E9F70 Offset: 0x18E8570 VA: 0x1818E9F70
	public void set_shadowStrength(float value) { }

	// RVA: 0x18E99A0 Offset: 0x18E7FA0 VA: 0x1818E99A0
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x954E0 Offset: 0x948E0 VA: 0x1800954E0
	// RVA: 0x18E9A00 Offset: 0x18E8000 VA: 0x1818E9A00
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	// RVA: 0x18E9AA0 Offset: 0x18E80A0 VA: 0x1818E9AA0
	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	// RVA: 0x18E9AF0 Offset: 0x18E80F0 VA: 0x1818E9AF0
	public void RemoveCommandBuffers(LightEvent evt) { }

	[FreeFunctionAttribute] // RVA: 0x95580 Offset: 0x94980 VA: 0x180095580
	// RVA: 0x18E9A60 Offset: 0x18E8060 VA: 0x1818E9A60
	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	// RVA: 0x18E9B70 Offset: 0x18E8170 VA: 0x1818E9B70
	private void get_color_Injected(out Color ret) { }

	// RVA: 0x18E9D50 Offset: 0x18E8350 VA: 0x1818E9D50
	private void set_color_Injected(ref Color value) { }

}

