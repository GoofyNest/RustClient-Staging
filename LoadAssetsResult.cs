public abstract class LoadAssetsResult : CustomYieldInstruction // TypeDefIndex: 6661
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <CompletedCount>k__BackingField; // 0x10
	public LoadAssetsResult.AssetLoaded OnAssetLoaded; // 0x18

	// Properties
	public abstract int TotalCount { get; }
	public virtual int CompletedCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_TotalCount();

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 9
	public virtual int get_CompletedCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0 Slot: 10
	protected virtual void set_CompletedCount(int value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Dictionary<string, Object> GetResult();

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	protected void .ctor() { }

}

public sealed class LoadAssetsResult.AssetLoaded : MulticastDelegate // TypeDefIndex: 6662
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(string path, Object obj) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(string path, Object obj, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

