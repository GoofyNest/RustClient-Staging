public sealed class LineRenderer : Renderer // TypeDefIndex: 3401
{	public Color startColor { set; }
	public Color endColor { set; }
	[NativePropertyAttribute] // RVA: 0x8E3C0 Offset: 0x8D7C0 VA: 0x18008E3C0
	public int positionCount { get; set; }


	[ObsoleteAttribute] // RVA: 0x8E060 Offset: 0x8D460 VA: 0x18008E060
	public void SetColors(Color start, Color end) { }

	public void set_startColor(Color value) { }

	public void set_endColor(Color value) { }

	public int get_positionCount() { }

	public void set_positionCount(int value) { }

	public void SetPosition(int index, Vector3 position) { }

	public Vector3 GetPosition(int index) { }

	[FreeFunctionAttribute] // RVA: 0x8E0C0 Offset: 0x8D4C0 VA: 0x18008E0C0
	public int GetPositions([Out] Vector3[] positions) { }

	[FreeFunctionAttribute] // RVA: 0x8E160 Offset: 0x8D560 VA: 0x18008E160
	public void SetPositions(Vector3[] positions) { }

	private void set_startColor_Injected(ref Color value) { }

	private void set_endColor_Injected(ref Color value) { }

	private void SetPosition_Injected(int index, ref Vector3 position) { }

	private void GetPosition_Injected(int index, out Vector3 ret) { }

}

