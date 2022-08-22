public struct TextureData // TypeDefIndex: 10315
{	// Fields
	public int width; // 0x0
	public int height; // 0x4
	public Color32[] colors; // 0x8

	// Methods

	// RVA: 0xF9900 Offset: 0xF8D00 VA: 0x1800F9900
	public void .ctor(Texture2D tex) { }

	// RVA: 0xF9420 Offset: 0xF8820 VA: 0x1800F9420
	public Color32 GetColor(int x, int y) { }

	// RVA: 0xF9850 Offset: 0xF8C50 VA: 0x1800F9850
	public int GetShort(int x, int y) { }

	// RVA: 0xF9500 Offset: 0xF8900 VA: 0x1800F9500
	public int GetInt(int x, int y) { }

	// RVA: 0xF9460 Offset: 0xF8860 VA: 0x1800F9460
	public float GetFloat(int x, int y) { }

	// RVA: 0xF94B0 Offset: 0xF88B0 VA: 0x1800F94B0
	public float GetHalf(int x, int y) { }

	// RVA: 0xF98A0 Offset: 0xF8CA0 VA: 0x1800F98A0
	public Vector4 GetVector(int x, int y) { }

	// RVA: 0xF9820 Offset: 0xF8C20 VA: 0x1800F9820
	public Vector3 GetNormal(int x, int y) { }

	// RVA: 0xF9550 Offset: 0xF8950 VA: 0x1800F9550
	public Color32 GetInterpolatedColor(float x, float y) { }

	// RVA: 0xF9580 Offset: 0xF8980 VA: 0x1800F9580
	public int GetInterpolatedInt(float x, float y) { }

	// RVA: 0xF96D0 Offset: 0xF8AD0 VA: 0x1800F96D0
	public int GetInterpolatedShort(float x, float y) { }

	// RVA: 0xF9560 Offset: 0xF8960 VA: 0x1800F9560
	public float GetInterpolatedFloat(float x, float y) { }

	// RVA: 0xF9570 Offset: 0xF8970 VA: 0x1800F9570
	public float GetInterpolatedHalf(float x, float y) { }

	// RVA: 0xF97F0 Offset: 0xF8BF0 VA: 0x1800F97F0
	public Vector4 GetInterpolatedVector(float x, float y) { }

	// RVA: 0xF96A0 Offset: 0xF8AA0 VA: 0x1800F96A0
	public Vector3 GetInterpolatedNormal(float x, float y) { }

}

