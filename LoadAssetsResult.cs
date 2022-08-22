public abstract class LoadAssetsResult : CustomYieldInstruction // TypeDefIndex: 6661
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <CompletedCount>k__BackingField; // 0x10
	public LoadAssetsResult.AssetLoaded OnAssetLoaded; // 0x18

	// Properties
	public abstract int TotalCount { get; }
	public virtual int CompletedCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_TotalCount();

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 9
	public virtual int get_CompletedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970 Slot: 10
	protected virtual void set_CompletedCount(int value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Dictionary<string, Object> GetResult();

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

}

public sealed class LoadAssetsResult.AssetLoaded : MulticastDelegate // TypeDefIndex: 6662
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(string path, Object obj) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(string path, Object obj, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

