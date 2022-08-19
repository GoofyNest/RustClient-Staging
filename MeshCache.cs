public static class MeshCache // TypeDefIndex: 9153
{	// Fields
	public static Dictionary<Mesh, MeshCache.Data> dictionary; // 0x1CBC

	// Methods

	// RVA: 0x95FA10 Offset: 0x95E010 VA: 0x18095FA10
	public static MeshCache.Data Get(Mesh mesh) { }

	// RVA: 0x95FCA0 Offset: 0x95E2A0 VA: 0x18095FCA0
	private static void .cctor() { }

}

public class MeshCache.Data // TypeDefIndex: 9154
{	// Fields
	public Mesh mesh; // 0x10
	public Vector3[] vertices; // 0x18
	public Vector3[] normals; // 0x20
	public Vector4[] tangents; // 0x28
	public Color32[] colors32; // 0x30
	public int[] triangles; // 0x38
	public Vector2[] uv; // 0x40
	public Vector2[] uv2; // 0x48
	public Vector2[] uv3; // 0x50
	public Vector2[] uv4; // 0x58

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

