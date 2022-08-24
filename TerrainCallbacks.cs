public static class TerrainCallbacks // TypeDefIndex: 4096
{	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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

