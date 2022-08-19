public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	// Properties
	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E200 Offset: 0x8D600 VA: 0x18008E200
	public int positionCount { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x8DEA0 Offset: 0x8D2A0 VA: 0x18008DEA0
	// RVA: 0x18EA7A0 Offset: 0x18E8DA0 VA: 0x1818EA7A0
	public void SetColors(Color start, Color end) { }

	// RVA: 0x18EAA80 Offset: 0x18E9080 VA: 0x1818EAA80
	public void set_startColor(Color value) { }

	// RVA: 0x18EA9A0 Offset: 0x18E8FA0 VA: 0x1818EA9A0
	public void set_endColor(Color value) { }

	// RVA: 0x18EA910 Offset: 0x18E8F10 VA: 0x1818EA910
	public int get_positionCount() { }

	// RVA: 0x18EA9F0 Offset: 0x18E8FF0 VA: 0x1818EA9F0
	public void set_positionCount(int value) { }

	// RVA: 0x18EA870 Offset: 0x18E8E70 VA: 0x1818EA870
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x18EA6F0 Offset: 0x18E8CF0 VA: 0x1818EA6F0
	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8DF00 Offset: 0x8D300 VA: 0x18008DF00
	// RVA: 0x18EA750 Offset: 0x18E8D50 VA: 0x1818EA750
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8DFE0 Offset: 0x8D3E0 VA: 0x18008DFE0
	// RVA: 0x18EA8C0 Offset: 0x18E8EC0 VA: 0x1818EA8C0
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x18EAA30 Offset: 0x18E9030 VA: 0x1818EAA30
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x18EA950 Offset: 0x18E8F50 VA: 0x1818EA950
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x18EA820 Offset: 0x18E8E20 VA: 0x1818EA820
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x18EA6A0 Offset: 0x18E8CA0 VA: 0x1818EA6A0
	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

