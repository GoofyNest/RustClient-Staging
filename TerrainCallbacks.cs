public static class TerrainCallbacks // TypeDefIndex: 4096
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }

}

public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 4097
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	public virtual IAsyncResult BeginInvoke(Terrain terrain, RectInt heightRegion, bool synched, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 4098
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	public virtual IAsyncResult BeginInvoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

