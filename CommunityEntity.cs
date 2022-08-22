public class CommunityEntity : PointEntity // TypeDefIndex: 8551
{	// Fields
	private static Dictionary<uint, List<MaskableGraphic>> requestingTextureImages; // 0x0
	private static Dictionary<uint, CommunityEntity.CachedTexture> _textureCache; // 0x8
	private static List<GameObject> AllUi; // 0x10
	private static Dictionary<string, GameObject> UiDict; // 0x18
	public static CommunityEntity ServerInstance; // 0x20
	public static CommunityEntity ClientInstance; // 0x28

	// Methods

	// RVA: 0x580B80 Offset: 0x57F180 VA: 0x180580B80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57EC50 Offset: 0x57D250 VA: 0x18057EC50
	public void CL_ReceiveFilePng(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5808F0 Offset: 0x57EEF0 VA: 0x1805808F0
	private static CommunityEntity.CachedTexture GetCachedTexture(uint textureId) { }

	// RVA: 0x581780 Offset: 0x57FD80 VA: 0x180581780
	private CommunityEntity.CachedTexture StoreCachedTexture(uint textureId, byte[] bytes) { }

	// RVA: 0x57E9B0 Offset: 0x57CFB0 VA: 0x18057E9B0
	private void ApplyTextureToImage(MaskableGraphic component, uint textureID) { }

	// RVA: 0x57E730 Offset: 0x57CD30 VA: 0x18057E730
	private void ApplyCachedTextureToImage(MaskableGraphic component, CommunityEntity.CachedTexture texture) { }

	// RVA: 0x581900 Offset: 0x57FF00 VA: 0x180581900
	private static void UnloadTextureCache() { }

	// RVA: 0x5804D0 Offset: 0x57EAD0 VA: 0x1805804D0
	public static void DestroyServerCreatedUI() { }

	// RVA: 0x5816D0 Offset: 0x57FCD0 VA: 0x1805816D0
	public void SetVisible(bool b) { }

	// RVA: 0x581610 Offset: 0x57FC10 VA: 0x180581610
	private static void RegisterUi(GameObject go) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57DF90 Offset: 0x57C590 VA: 0x18057DF90
	public void AddUI(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5807E0 Offset: 0x57EDE0 VA: 0x1805807E0
	private GameObject FindPanel(string name) { }

	// RVA: 0x57EF10 Offset: 0x57D510 VA: 0x18057EF10
	private void CreateComponents(GameObject go, Object obj) { }

	// RVA: -1 Offset: -1
	private static T ParseEnum<T>(string value, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CB340 Offset: 0x5C9940 VA: 0x1805CB340
	|-CommunityEntity.ParseEnum<Int32Enum>
	|-CommunityEntity.ParseEnum<TextAnchor>
	|-CommunityEntity.ParseEnum<Image.Type>
	|-CommunityEntity.ParseEnum<InputField.LineType>
	|-CommunityEntity.ParseEnum<VerticalWrapMode>
	*/

	// RVA: 0x580980 Offset: 0x57EF80 VA: 0x180580980
	private void GraphicComponentCreated(Graphic c, Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xAA280 Offset: 0xA9680 VA: 0x1800AA280
	// RVA: 0x580AF0 Offset: 0x57F0F0 VA: 0x180580AF0
	private IEnumerator LoadTextureFromWWW(RawImage c, string p) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x580790 Offset: 0x57ED90 VA: 0x180580790
	public void DestroyUI(BaseEntity.RPCMessage msg) { }

	// RVA: 0x580330 Offset: 0x57E930 VA: 0x180580330
	private void DestroyPanel(string pnlName) { }

	// RVA: 0x580A40 Offset: 0x57F040 VA: 0x180580A40 Slot: 28
	public override void InitShared() { }

	// RVA: 0x5806E0 Offset: 0x57ECE0 VA: 0x1805806E0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x581BE0 Offset: 0x5801E0 VA: 0x180581BE0
	public void .ctor() { }

	// RVA: 0x581A90 Offset: 0x580090 VA: 0x180581A90
	private static void .cctor() { }

}

private class CommunityEntity.Countdown : MonoBehaviour // TypeDefIndex: 8552
{	// Fields
	public string command; // 0x18
	public int endTime; // 0x20
	public int startTime; // 0x24
	public int step; // 0x28
	private int sign; // 0x2C
	private string tempText; // 0x30
	private Text textComponent; // 0x38

	// Methods

	// RVA: 0x583930 Offset: 0x581F30 VA: 0x180583930
	private void Start() { }

	// RVA: 0x583AA0 Offset: 0x5820A0 VA: 0x180583AA0
	private void UpdateCountdown() { }

	// RVA: 0x583850 Offset: 0x581E50 VA: 0x180583850
	private void End() { }

	// RVA: 0x583BA0 Offset: 0x5821A0 VA: 0x180583BA0
	public void .ctor() { }

}

private class CommunityEntity.FadeOut : MonoBehaviour // TypeDefIndex: 8553
{	// Fields
	public float duration; // 0x18

	// Methods

	// RVA: 0x583C70 Offset: 0x582270 VA: 0x180583C70
	public void FadeOutAndDestroy() { }

	// RVA: 0x583D50 Offset: 0x582350 VA: 0x180583D50
	public void Kill() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private class CommunityEntity.CachedTexture // TypeDefIndex: 8554
{	// Fields
	public Texture2D Texture; // 0x10
	public Sprite Sprite; // 0x18

	// Methods

	// RVA: 0x56FA80 Offset: 0x56E080 VA: 0x18056FA80
	public void Destroy() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_0 // TypeDefIndex: 8555
{	// Fields
	public Image c; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_1 // TypeDefIndex: 8556
{	// Fields
	public ulong requestedSkin; // 0x10
	public CommunityEntity.<>c__DisplayClass19_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3B30 Offset: 0x4B2130 VA: 0x1804B3B30
	internal bool <CreateComponents>b__0(ItemSkinDirectory.Skin x) { }

	// RVA: 0x589B00 Offset: 0x588100 VA: 0x180589B00
	internal void <CreateComponents>b__1() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_2 // TypeDefIndex: 8557
{	// Fields
	public string cmd; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589BB0 Offset: 0x5881B0 VA: 0x180589BB0
	internal void <CreateComponents>b__2() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_3 // TypeDefIndex: 8558
{	// Fields
	public string pnlName; // 0x10
	public CommunityEntity <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589BC0 Offset: 0x5881C0 VA: 0x180589BC0
	internal void <CreateComponents>b__3() { }

}

private sealed class CommunityEntity.<>c__DisplayClass19_4 // TypeDefIndex: 8559
{	// Fields
	public string cmd; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589BF0 Offset: 0x5881F0 VA: 0x180589BF0
	internal void <CreateComponents>b__4(string value) { }

}

private sealed class CommunityEntity.<LoadTextureFromWWW>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8560
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string p; // 0x20
	public RawImage c; // 0x28
	private WWW <www>5__2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x587540 Offset: 0x585B40 VA: 0x180587540 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x587960 Offset: 0x585F60 VA: 0x180587960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

