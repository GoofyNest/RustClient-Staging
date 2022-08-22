public struct TextureData // TypeDefIndex: 10315
{	// Fields
	public int width; // 0x0
	public int height; // 0x4
	public Color32[] colors; // 0x8

	// Methods

	// RVA: 0xF9C50 Offset: 0xF9050 VA: 0x1800F9C50
	public void .ctor(Texture2D tex) { }

	// RVA: 0xF9770 Offset: 0xF8B70 VA: 0x1800F9770
	public Color32 GetColor(int x, int y) { }

	// RVA: 0xF9BA0 Offset: 0xF8FA0 VA: 0x1800F9BA0
	public int GetShort(int x, int y) { }

	// RVA: 0xF9850 Offset: 0xF8C50 VA: 0x1800F9850
	public int GetInt(int x, int y) { }

	// RVA: 0xF97B0 Offset: 0xF8BB0 VA: 0x1800F97B0
	public float GetFloat(int x, int y) { }

	// RVA: 0xF9800 Offset: 0xF8C00 VA: 0x1800F9800
	public float GetHalf(int x, int y) { }

	// RVA: 0xF9BF0 Offset: 0xF8FF0 VA: 0x1800F9BF0
	public Vector4 GetVector(int x, int y) { }

	// RVA: 0xF9B70 Offset: 0xF8F70 VA: 0x1800F9B70
	public Vector3 GetNormal(int x, int y) { }

	// RVA: 0xF98A0 Offset: 0xF8CA0 VA: 0x1800F98A0
	public Color32 GetInterpolatedColor(float x, float y) { }

	// RVA: 0xF98D0 Offset: 0xF8CD0 VA: 0x1800F98D0
	public int GetInterpolatedInt(float x, float y) { }

	// RVA: 0xF9A20 Offset: 0xF8E20 VA: 0x1800F9A20
	public int GetInterpolatedShort(float x, float y) { }

	// RVA: 0xF98B0 Offset: 0xF8CB0 VA: 0x1800F98B0
	public float GetInterpolatedFloat(float x, float y) { }

	// RVA: 0xF98C0 Offset: 0xF8CC0 VA: 0x1800F98C0
	public float GetInterpolatedHalf(float x, float y) { }

	// RVA: 0xF9B40 Offset: 0xF8F40 VA: 0x1800F9B40
	public Vector4 GetInterpolatedVector(float x, float y) { }

	// RVA: 0xF99F0 Offset: 0xF8DF0 VA: 0x1800F99F0
	public Vector3 GetInterpolatedNormal(float x, float y) { }

}

