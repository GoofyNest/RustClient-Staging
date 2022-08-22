public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	// Properties
	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E280 Offset: 0x8D680 VA: 0x18008E280
	public int positionCount { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x8DF20 Offset: 0x8D320 VA: 0x18008DF20
	// RVA: 0x18EA760 Offset: 0x18E8D60 VA: 0x1818EA760
	public void SetColors(Color start, Color end) { }

	// RVA: 0x18EAA40 Offset: 0x18E9040 VA: 0x1818EAA40
	public void set_startColor(Color value) { }

	// RVA: 0x18EA960 Offset: 0x18E8F60 VA: 0x1818EA960
	public void set_endColor(Color value) { }

	// RVA: 0x18EA8D0 Offset: 0x18E8ED0 VA: 0x1818EA8D0
	public int get_positionCount() { }

	// RVA: 0x18EA9B0 Offset: 0x18E8FB0 VA: 0x1818EA9B0
	public void set_positionCount(int value) { }

	// RVA: 0x18EA830 Offset: 0x18E8E30 VA: 0x1818EA830
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x18EA6B0 Offset: 0x18E8CB0 VA: 0x1818EA6B0
	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8DF80 Offset: 0x8D380 VA: 0x18008DF80
	// RVA: 0x18EA710 Offset: 0x18E8D10 VA: 0x1818EA710
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8E060 Offset: 0x8D460 VA: 0x18008E060
	// RVA: 0x18EA880 Offset: 0x18E8E80 VA: 0x1818EA880
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x18EA9F0 Offset: 0x18E8FF0 VA: 0x1818EA9F0
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x18EA910 Offset: 0x18E8F10 VA: 0x1818EA910
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x18EA7E0 Offset: 0x18E8DE0 VA: 0x1818EA7E0
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x18EA660 Offset: 0x18E8C60 VA: 0x1818EA660
	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

