public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	// Properties
	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E280 Offset: 0x8D680 VA: 0x18008E280
	public int positionCount { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x8DF20 Offset: 0x8D320 VA: 0x18008DF20
	// RVA: 0x18EAA20 Offset: 0x18E9020 VA: 0x1818EAA20
	public void SetColors(Color start, Color end) { }

	// RVA: 0x18EAD00 Offset: 0x18E9300 VA: 0x1818EAD00
	public void set_startColor(Color value) { }

	// RVA: 0x18EAC20 Offset: 0x18E9220 VA: 0x1818EAC20
	public void set_endColor(Color value) { }

	// RVA: 0x18EAB90 Offset: 0x18E9190 VA: 0x1818EAB90
	public int get_positionCount() { }

	// RVA: 0x18EAC70 Offset: 0x18E9270 VA: 0x1818EAC70
	public void set_positionCount(int value) { }

	// RVA: 0x18EAAF0 Offset: 0x18E90F0 VA: 0x1818EAAF0
	public void SetPosition(int index, Vector3 position) { }

	// RVA: 0x18EA970 Offset: 0x18E8F70 VA: 0x1818EA970
	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8DF80 Offset: 0x8D380 VA: 0x18008DF80
	// RVA: 0x18EA9D0 Offset: 0x18E8FD0 VA: 0x1818EA9D0
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8E060 Offset: 0x8D460 VA: 0x18008E060
	// RVA: 0x18EAB40 Offset: 0x18E9140 VA: 0x1818EAB40
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x18EACB0 Offset: 0x18E92B0 VA: 0x1818EACB0
	private void set_startColor_Injected(ref Color value) { }

	// RVA: 0x18EABD0 Offset: 0x18E91D0 VA: 0x1818EABD0
	private void set_endColor_Injected(ref Color value) { }

	// RVA: 0x18EAAA0 Offset: 0x18E90A0 VA: 0x1818EAAA0
	private void SetPosition_Injected(int index, ref Vector3 position) { }

	// RVA: 0x18EA920 Offset: 0x18E8F20 VA: 0x1818EA920
	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

