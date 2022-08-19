public struct TextureData // TypeDefIndex: 10315
{	// Fields
	public int width; // 0x0
	public int height; // 0x4
	public Color32[] colors; // 0x8

	// Methods

	// RVA: 0xF9CD0 Offset: 0xF90D0 VA: 0x1800F9CD0
	public void .ctor(Texture2D tex) { }

	// RVA: 0xF97F0 Offset: 0xF8BF0 VA: 0x1800F97F0
	public Color32 GetColor(int x, int y) { }

	// RVA: 0xF9C20 Offset: 0xF9020 VA: 0x1800F9C20
	public int GetShort(int x, int y) { }

	// RVA: 0xF98D0 Offset: 0xF8CD0 VA: 0x1800F98D0
	public int GetInt(int x, int y) { }

	// RVA: 0xF9830 Offset: 0xF8C30 VA: 0x1800F9830
	public float GetFloat(int x, int y) { }

	// RVA: 0xF9880 Offset: 0xF8C80 VA: 0x1800F9880
	public float GetHalf(int x, int y) { }

	// RVA: 0xF9C70 Offset: 0xF9070 VA: 0x1800F9C70
	public Vector4 GetVector(int x, int y) { }

	// RVA: 0xF9BF0 Offset: 0xF8FF0 VA: 0x1800F9BF0
	public Vector3 GetNormal(int x, int y) { }

	// RVA: 0xF9920 Offset: 0xF8D20 VA: 0x1800F9920
	public Color32 GetInterpolatedColor(float x, float y) { }

	// RVA: 0xF9950 Offset: 0xF8D50 VA: 0x1800F9950
	public int GetInterpolatedInt(float x, float y) { }

	// RVA: 0xF9AA0 Offset: 0xF8EA0 VA: 0x1800F9AA0
	public int GetInterpolatedShort(float x, float y) { }

	// RVA: 0xF9930 Offset: 0xF8D30 VA: 0x1800F9930
	public float GetInterpolatedFloat(float x, float y) { }

	// RVA: 0xF9940 Offset: 0xF8D40 VA: 0x1800F9940
	public float GetInterpolatedHalf(float x, float y) { }

	// RVA: 0xF9BC0 Offset: 0xF8FC0 VA: 0x1800F9BC0
	public Vector4 GetInterpolatedVector(float x, float y) { }

	// RVA: 0xF9A70 Offset: 0xF8E70 VA: 0x1800F9A70
	public Vector3 GetInterpolatedNormal(float x, float y) { }

}

